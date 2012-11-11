using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using SPCP.Controller;

namespace SPCP.View
{
    public partial class frmFichaProduto : SPCP.View.frmCadastroMain
    {
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

        public override void CarregaDadosControles(int id)
        {
            ProdutoControl produto = new ProdutoControl();
            ProdutoDTO p = produto.GetProduto(id);

            try
            {
                this.id = p.Id;
                this.txtCodigo.Text = p.Codigo.ToString();
                this.txtNomeProduto.Text = p.Nome.ToString();
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
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void cbxProduto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CarregaDadosControles(Convert.ToInt32(cbxProduto.SelectedValue));
        }
    }
}
