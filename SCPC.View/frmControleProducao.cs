using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SPCP.Controller;

namespace SPCP.View
{
    public partial class frmControleProducao : SPCP.View.frmCadastroMain
    {
        public frmControleProducao()
        {
            InitializeComponent();
        }

        public override void InicializarComboBoxes()
        {
            try
            {
                this.cbxFornecedor.DataSource = ComboBoxSistema.GetFornecedores();
                this.cbxFornecedor.ValueMember = "Id";
                this.cbxFornecedor.DisplayMember = "Nome";
                this.cbxFornecedor.SelectedIndex = -1;

                this.cbxServico.DataSource = ComboBoxSistema.GetServicos();
                this.cbxServico.ValueMember = "Id";
                this.cbxServico.DisplayMember = "Descricao";
                this.cbxServico.SelectedIndex = -1;

                this.cbxProduto.DataSource = ComboBoxSistema.Produtos();
                this.cbxProduto.ValueMember = "Id";
                this.cbxProduto.DisplayMember = "Descricao";
                this.cbxProduto.SelectedIndex = -1;

            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao carregar ComboBoxes: " + e.Message, "Carregamento de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public bool ValidaCamposMaoDeObra()
        {
            //valida inserção no grid
            if (!ValidaPreenchimento(this.cbxFornecedor))
                return false;
            if (!ValidaPreenchimento(this.cbxServico))
                return false;
            if (!ValidaPreenchimento(this.cbxProduto))
                return false;

            return true;
        }

        private void bttnAddDgCursos_Click(object sender, EventArgs e)
        {
            if (ValidaCamposMaoDeObra())
            {
                //FichaProdutoDTO p = new FichaProdutoDTO();
                //p.Item = (ItemEstoqueDTO)cbxItem.SelectedItem;
                //p.Produto.Id = this.id;
                //p.Qtd = Convert.ToInt32(txtQtd.Text);
                //p.Observacao = txtObservacoes.Text;


                //itensInsertUpdate.Add(p);
                //bs.DataSource = itensInsertUpdate;
                //dgMateriais.DataSource = bs; //atualiza o grid
            }
        }
    }
}
