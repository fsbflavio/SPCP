using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using SPCP.Controller;
using SPCP.Util; //remover?

namespace SPCP.View
{
    public partial class frmFichaProduto : SPCP.View.frmCadastroMain
    {
        DataTable dt;

        public frmFichaProduto()
        {
            InitializeComponent();
        }

        public override void Salvar()
        {
            if (ValidaCampos())
            {
                if (ModoOperacao == "E")
                {
                    ProdutoDTO produtoDTO = new ProdutoDTO();
                    produtoDTO.Id = id;
                    produtoDTO.Codigo = Convert.ToInt32(this.txtCodigo.Text);
                    produtoDTO.Nome = this.txtNomeProduto.Text;

                    ProdutoControl produto = new ProdutoControl();
                    produto.Alterar(produtoDTO);

                    ModoOperacao = "";
                    DesativaControles();

                    MessageBox.Show("O registro foi  Atualizado com sucesso!",
                                    "Transação Concluída", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                }

                if (ModoOperacao == "N")
                {
                    ProdutoDTO produtoDTO = new ProdutoDTO();
                    produtoDTO.Codigo = Convert.ToInt32(this.txtCodigo.Text);
                    produtoDTO.Nome = this.txtNomeProduto.Text;

                    ProdutoControl produto = new ProdutoControl();

                    produto.Incluir(produtoDTO);

                    ModoOperacao = "";
                    DesativaControles();

                    MessageBox.Show("O registro foi salvo com sucesso!",
                                    "Transação Concluída", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }

                Pesquisar(dgPesquisa, this.txtPESQUISA.Text);
                SistemaEmEspera();
                InicializarComboBoxes(); //recarregar
            }
        }

        public override bool ValidaCampos()
        {
            if (!ValidaPreenchimento(this.txtCodigo))
                return false;
            if (!ValidaPreenchimento(this.txtNomeProduto))
                return false;
            return true;
        }


        public void CarregaDataGrid(DataGridView dg, int id)
        {
            FichaProdutoControl ficha = new FichaProdutoControl();
            dt = ficha.CarregaGrid(id);

            //popula o datagrid retornado
            dg.RowsDefaultCellStyle.BackColor = Color.White;
            dg.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dg.EnableHeadersVisualStyles = true;
            dg.DataSource = dt;
            
            //formata as colunas do datagrid
            dg.Columns["ID"].HeaderText = "Reg. nº"; //Nome coluna
            dg.Columns["ID"].Width = 80; //largura coluna
            dg.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dg.Columns["ID"].ToolTipText = "Número do Registro";
            dg.Columns["ID"].DefaultCellStyle.Format = "0000000";
            dg.Columns["ID"].Visible = false;

            dg.Columns["ID_ITEM"].HeaderText = "Reg. nº"; //Nome coluna
            dg.Columns["ID_ITEM"].Width = 80; //largura coluna
            dg.Columns["ID_ITEM"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dg.Columns["ID_ITEM"].ToolTipText = "Número do Registro";
            dg.Columns["ID_ITEM"].Visible = true;

            dg.Columns["ID_PRODUTO"].HeaderText = "CNPJ"; //Nome coluna
            dg.Columns["ID_PRODUTO"].Width = 150; //largura coluna
            dg.Columns["ID_PRODUTO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dg.Columns["ID_PRODUTO"].ToolTipText = "CNPJ do CLIENTE";
            dg.Columns["ID_PRODUTO"].Visible = false;

            dg.Columns["DESCRICAO"].HeaderText = "Descrição"; //Nome coluna
            dg.Columns["DESCRICAO"].Width = 150; //largura coluna
            dg.Columns["DESCRICAO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dg.Columns["DESCRICAO"].ToolTipText = "Descrição do Item";
            dg.Columns["DESCRICAO"].Visible = true;

            dg.Columns["UNIDADE_MEDIDA"].HeaderText = "U.M."; //Nome coluna
            dg.Columns["UNIDADE_MEDIDA"].Width = 100; //largura coluna
            dg.Columns["UNIDADE_MEDIDA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dg.Columns["UNIDADE_MEDIDA"].ToolTipText = "Unidade de Medida";
            dg.Columns["UNIDADE_MEDIDA"].Visible = true;

            dg.Columns["QTD"].HeaderText = "QTD"; //Nome coluna
            dg.Columns["QTD"].Width = 100; //largura coluna
            dg.Columns["QTD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dg.Columns["QTD"].ToolTipText = "Quantidade";
            dg.Columns["QTD"].Visible = true;

            dg.Columns["OBSERVACOES"].HeaderText = "Observações"; //Nome coluna
            dg.Columns["OBSERVACOES"].Width = 200; //largura coluna
            dg.Columns["OBSERVACOES"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dg.Columns["OBSERVACOES"].ToolTipText = "Observações";
            dg.Columns["OBSERVACOES"].Visible = true;

            dg.Refresh();

            //-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*
            return;

        }

        public override void CarregaDadosControles(int id)
        {
            ProdutoControl produto = new ProdutoControl();
            ProdutoDTO p = produto.GetProduto(id);
            
            try
            {
                this.id = p.Id;
                this.txtCodigo.Text = p.Codigo.ToString();
                this.txtNomeProduto.Text = p.Nome.ToString();

                CarregaDataGrid(dgMateriais, id); // Carrega os materiais de um produto no grid
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao carregar dados do Produto: " + e.Message, "Carregamento de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void InicializarComboBoxes()
        {
            try
            {
                this.cbxProduto.DataSource = ComboBoxSistema.Produtos();
                this.cbxProduto.ValueMember = "Id";
                this.cbxProduto.DisplayMember = "Descricao";
                this.cbxProduto.SelectedIndex = -1;

                this.cbxGrupo.DataSource = ComboBoxSistema.gruposItemEstoque();
                this.cbxGrupo.ValueMember = "id";
                this.cbxGrupo.DisplayMember = "descricao";
                this.cbxGrupo.SelectedIndex = -1;

                this.cbxItem.DataSource = ComboBoxSistema.ItensEstoque();
                this.cbxItem.ValueMember = "Id";
                this.cbxItem.DisplayMember = "Descricao";
                this.cbxItem.SelectedIndex = -1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao carregar ComboBoxes: " + e.Message, "Carregamento de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cbxProduto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CarregaDadosControles(Convert.ToInt32(cbxProduto.SelectedValue));
        }

        private void bttnAddDgCursos_Click(object sender, EventArgs e)
        {
            DataRow row = dt.NewRow(); // Cria a nova Linha com as colunas da tabela[0]
            row["ID_ITEM"] = cbxItem.SelectedValue;
            row["DESCRICAO"] = cbxItem.SelectedValue;
            row["QTD"] = cbxItem.SelectedValue;
            row["OBSERVACOES"] = cbxItem.SelectedValue;



            dt.Rows.Add(row);
            
        }
    }
}
