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
        ArrayList itens = new ArrayList();

        public frmFichaProduto()
        {
            InitializeComponent();
        }

        public override void Salvar()
        {
            if (ValidaCampos())
            {
                ProdutoControl produto = new ProdutoControl();

                if (ModoOperacao == "E")
                {
                    ProdutoDTO produtoDTO = new ProdutoDTO();
                    produtoDTO.Id = id;
                    produtoDTO.Codigo = Convert.ToInt32(this.txtCodigo.Text);
                    produtoDTO.Descricao = this.txtNomeProduto.Text;

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
                    produtoDTO.Descricao = this.txtNomeProduto.Text;

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

                //teste
                FichaProdutoControl ficha = new FichaProdutoControl();
                ficha.SalvaGrid(itens);
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

        public override void Pesquisar(DataGridView dg, string nome)
        {
            ProdutoControl pControl = new ProdutoControl();
            //dg.DataSource = pControl.GetProdutos();

            //popula o datagrid retornado
            dg.RowsDefaultCellStyle.BackColor = Color.White;
            dg.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dg.EnableHeadersVisualStyles = true;
            dg.DataSource = pControl.GetProdutos();

            //formata as colunas do datagrid
            dg.Columns["Id"].HeaderText = "Reg. nº"; //Nome coluna
            dg.Columns["Id"].Width = 78; //largura coluna
            dg.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dg.Columns["Id"].ToolTipText = "Número do Registro";
            dg.Columns["Id"].DefaultCellStyle.Format = "0000000";
            dg.Columns["Id"].Visible = true;

            dg.Columns["Codigo"].HeaderText = "Código"; //Nome coluna
            dg.Columns["Codigo"].Width = 100; //largura coluna
            dg.Columns["Codigo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dg.Columns["Codigo"].ToolTipText = "Codigo do Produto";
            dg.Columns["Codigo"].Visible = true;

            dg.Columns["Descricao"].HeaderText = "Descrição"; //Nome coluna
            dg.Columns["Descricao"].Width = 845; //largura coluna
            dg.Columns["Descricao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dg.Columns["Descricao"].ToolTipText = "Descrição do Produto";
            dg.Columns["Descricao"].Visible = true;

            dg.Refresh();
        }

        public void CarregaDataGridCustos(DataGridView dg, int id)
        {
            FichaProdutoControl ficha = new FichaProdutoControl();
            BindingSource bs = new BindingSource();
            bs.DataSource = ficha.GetFicha(id);

            if (bs.Count <= 0) //trata o caso q a busca é vazia. evita q os cabeçalhos sumam.
            {
                bs.Clear();
                dg.DataSource = bs;
                return;
            }

            
            
            //popula o datagrid retornado
            dg.RowsDefaultCellStyle.BackColor = Color.White;
            dg.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dg.EnableHeadersVisualStyles = true;
            dg.DataSource = bs;

            //formata as colunas do datagrid
            dg.Columns["Id"].HeaderText = "Reg. nº"; //Nome coluna
            dg.Columns["Id"].Width = 78; //largura coluna
            dg.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dg.Columns["Id"].ToolTipText = "Número do Registro";
            dg.Columns["Id"].DefaultCellStyle.Format = "0000000";
            dg.Columns["Id"].Visible = true;

            dg.Columns["Item"].HeaderText = "Descrição"; //Nome coluna
            dg.Columns["Item"].Width = 400; //largura coluna
            dg.Columns["Item"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dg.Columns["Item"].ToolTipText = "Descrição Item";
            dg.Columns["Item"].Visible = true;

            dg.Columns["Produto"].HeaderText = "Produto"; //Nome coluna
            dg.Columns["Produto"].Width = 845; //largura coluna
            dg.Columns["Produto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dg.Columns["Produto"].ToolTipText = "Produto";
            dg.Columns["Produto"].Visible = false;

            dg.Columns["Qtd"].HeaderText = "QTD"; //Nome coluna
            dg.Columns["Qtd"].Width = 80; //largura coluna
            dg.Columns["Qtd"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dg.Columns["Qtd"].ToolTipText = "Quantidade";
            dg.Columns["Qtd"].Visible = true;

            dg.Columns["Observacao"].HeaderText = "Observações"; //Nome coluna
            dg.Columns["Observacao"].Width = 465; //largura coluna
            dg.Columns["Observacao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dg.Columns["Observacao"].ToolTipText = "Observações";
            dg.Columns["Observacao"].Visible = true;

            dg.Refresh();

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
                this.txtNomeProduto.Text = p.Descricao.ToString();

                
                CarregaDataGridCustos(dgMateriais, id); // Carrega os materiais de um produto no grid
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

        private void bttnAddDgCursos_Click(object sender, EventArgs e)
        {
            //DataRow row = dt.NewRow(); // Cria a nova Linha com as colunas da tabela[0]
            //row["ID_ITEM"] = cbxItem.SelectedValue;
            //row["ID_PRODUTO"] = cbxProduto.SelectedValue;
            //row["DESCRICAO"] = cbxItem.SelectedItem;
            //row["QTD"] = txtQtd.Text;
            //row["OBSERVACOES"] = txtObservacoes.Text;

            //dt.Rows.Add(row);

            FichaProdutoDTO p = new FichaProdutoDTO();
            p.Item = (ItemEstoqueDTO)cbxItem.SelectedItem;
            p.Produto.Id = this.id;
            p.Qtd = Convert.ToInt32(txtQtd.Text);
            p.Observacao = txtObservacoes.Text;


            itens.Add(p);

            
            BindingSource bs = new BindingSource();
            
            bs.DataSource = itens;
            dgMateriais.DataSource = bs;
            
        }
    }
}
