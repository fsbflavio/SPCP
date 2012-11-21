using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;
using SPCP.Controller;
using SPCP.Model;

namespace SPCP.View
{
    public partial class frmCompra : SPCP.View.frmCadastroMain
    {
        ArrayList InseridosAtualizados = new ArrayList();
        ArrayList Excluidos = new ArrayList();

        BindingSource bs = new BindingSource();
        BindingSource pesquisa = new BindingSource();

        public frmCompra()
        {
            InitializeComponent();

            //bs.DataSource = InseridosAtualizados;
            //dgItens.DataSource = bs;

            //dgPesquisa.DataSource = pesquisa;
        }

        public override void InicializarComboBoxes()
        {
            this.cbxFornecedor.DataSource = ComboBoxSistema.GetFornecedores();
            this.cbxFornecedor.ValueMember = "Id";
            this.cbxFornecedor.DisplayMember = "Nome";
            this.cbxFornecedor.SelectedIndex = -1;

            this.dgDescricao.DataSource = ComboBoxSistema.ItensEstoque();
            //this.dgDescricao.DataPropertyName = "ID_ITEM";
            this.dgDescricao.ValueMember = "Id";
            this.dgDescricao.DisplayMember = "Descricao";

            //this.dgDescricao.DataSource = teste.GetItensEstoque();
            //this.dgDescricao.DataPropertyName = "ID_ITEM";
            //this.dgDescricao.ValueMember = "ID_ITEM";
            //this.dgDescricao.DisplayMember = "DESCRICAO";

            this.cbxStatus.DataSource = ComboBoxSistema.GetStatus();
            this.cbxStatus.ValueMember = "Id";
            this.cbxStatus.DisplayMember = "Descricao";

        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                //this.dgItens.CurrentRow.R

                if (this.dgItens.CurrentRow.Index + 1 < this.dgItens.Rows.Count)
                {
                    this.dgItens.Rows.Remove(this.dgItens.CurrentRow);
                }
                //lista.Clear();
                //this.dgItens.Rows.RemoveAt(this.dgItens.CurrentRow.Index);
            }
        }

        public void ConfiguraDataGrid(DataGridView dg, BindingSource bs)
        {
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

        }

        public override void Pesquisar(DataGridView dg, string nome)
        {
            ComprasControl compras = new ComprasControl();
            
            pesquisa.DataSource = compras.getCompras();
            dg.DataSource = pesquisa;

            if (pesquisa.Count <= 0) //trata o caso q a busca é vazia. evita q os cabeçalhos sumam.
            {
                return;
            }

            //popula o datagrid retornado
            dg.RowsDefaultCellStyle.BackColor = Color.White;
            dg.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dg.EnableHeadersVisualStyles = true;

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

            dg.Columns["NomeFornecedor"].HeaderText = "Descrição"; //Nome coluna
            dg.Columns["NomeFornecedor"].Width = 300; //largura coluna
            dg.Columns["NomeFornecedor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dg.Columns["NomeFornecedor"].ToolTipText = "Descrição do Produto";
            dg.Columns["NomeFornecedor"].Visible = true;

            dg.Columns["PrevisaoEntrega"].HeaderText = "Descrição"; //Nome coluna
            dg.Columns["PrevisaoEntrega"].Width = 445; //largura coluna
            dg.Columns["PrevisaoEntrega"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dg.Columns["PrevisaoEntrega"].ToolTipText = "Descrição do Produto";
            dg.Columns["PrevisaoEntrega"].Visible = true;

            dg.Refresh();
        }

        public override void CarregaDadosControles(int id) //esta sendo chamado demais 
        {
            ComprasControl compras = new ComprasControl();
            ComprasDTO comprasDTO = compras.getCompra(id);

            try
            {
                this.id = comprasDTO.Id;
                //this.txtCodigo.Text = comprasDTO.Codigo.ToString(); codigo nem existe..ASFA
                this.cbxFornecedor.SelectedValue = comprasDTO.Fornecedor;
                //this.dtPrevisao.Value = comprasDTO.PrevisaoEntrega;
                this.cbxStatus.SelectedValue = comprasDTO.Status;
                this.txtObs.Text = comprasDTO.Observacoes;

                bs.DataSource = comprasDTO.ItemCompra;
                dgItens.DataSource = bs;
                //dgItens.DataSource = teste.GetItensCompra(comprasDTO.Id);
                dgItens.Refresh();

                CarregaGridItens(dgItens, id); // Carrega os materiais de um produto no grid
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao carregar dados do Produto: " + e.Message, "Carregamento de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CarregaGridItens(DataGridView dg, int id)
        {
            
        }

        public override bool ValidaCampos()
        {
            if (!ValidaPreenchimento(this.txtCodigo))
                return false;
            if (!ValidaPreenchimento(this.cbxFornecedor))
                return false;
            if (!ValidaPreenchimento(this.cbxStatus))
                return false;
            if (!ValidaPreenchimento(this.dtPrevisao))
                return false;

            decimal result;
            if (!decimal.TryParse(this.txtCodigo.Text, out result))
            {
                MessageBox.Show("Deve ser Informado um valor numérico no campo Código da Ficha", "Tipo de dado informado Invalido!");
                return false;
            }
            if (dgItens.Rows.Count <= 1) //grid não pode estar vazio
            {
                MessageBox.Show("A lista de composição do Produto esta vazia. Insira os materiais ", "Composição vazia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public override void Salvar()
        {

            if (ValidaCampos())
            {
                ComprasDTO compras = new ComprasDTO();
                LinkedList<ItemCompraDTO> itemList = new LinkedList<ItemCompraDTO>();

                ComprasControl comprasControl = new ComprasControl();
                compras.Id = id;
                compras.Codigo = this.txtCodigo.Text;
                compras.Fornecedor = (int)this.cbxFornecedor.SelectedValue;
                compras.PrevisaoEntrega = this.dtPrevisao.Value;
                compras.Status = (int)this.cbxStatus.SelectedValue;
                compras.Observacoes = this.txtObs.Text;

                ItemCompraDTO item;

                foreach (DataGridViewRow i in dgItens.Rows)
                {
                    if (i.Index < dgItens.Rows.Count - 1) // não insere a ultima linha.. pois é vazia
                    {
                        item = new ItemCompraDTO();
                        item.Id = Convert.ToInt32(dgItens.Rows[i.Index].Cells["Id"].Value);
                        item.IdItemDeEstoque = Convert.ToInt32(dgItens.Rows[i.Index].Cells["dgDescricao"].Value);
                        item.IPI = Convert.ToInt32(dgItens.Rows[i.Index].Cells["IPI"].Value);
                        item.ValorUnitario = Convert.ToInt32(dgItens.Rows[i.Index].Cells["Unit"].Value);
                        item.Qtd = Convert.ToInt32(dgItens.Rows[i.Index].Cells["Qtd"].Value);
                        item.ICMS = Convert.ToInt32(dgItens.Rows[i.Index].Cells["ICMS"].Value);
                        item.Observacao = Convert.ToString(dgItens.Rows[i.Index].Cells["Obs"].Value);

                        itemList.AddLast(item);
                    }
                }

                compras.ItemCompra = itemList;

                if (ModoOperacao == "N")
                {
                    comprasControl.Incluir(compras);

                    ModoOperacao = "";
                    DesativaControles();


                    MessageBox.Show("O registro foi salvo com sucesso!",
                                    "Transação Concluída", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }

                if (ModoOperacao == "E")
                {
                    comprasControl.Alterar(compras);

                    ModoOperacao = "";
                    DesativaControles();

                    MessageBox.Show("O registro foi  Atualizado com sucesso!",
                                    "Transação Concluída", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }

                Pesquisar(dgPesquisa, this.txtPESQUISA.Text);
                SistemaEmEspera();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ItemCompraDTO a = new ItemCompraDTO();

           // a.IdItemDeEstoque = 20;
           // bs.Add(a);

            //bs.Add(
            dgItens.AllowUserToAddRows = true;
          bs.AllowNew = true;
           //object b = bs.Current;
            //bs.AddNew();

            //dgItens.Rows.Add(1);
        }

    }
}
