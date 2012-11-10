using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SPCP.Controler;

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
                    ProdutoDTO produtoDTO= new ProdutoDTO();
                    produtoDTO.Codigo = Convert.ToInt32(this.txtCodigo.Text);
                    produtoDTO.Nome = this.txtNomeProduto.Text;

                    FornecedorControl fornecedor = new FornecedorControl();
                    //fornecedor.Alterar(fornecedorDTO);

                    ModoOperacao = "";
                    DesativaControles();

                    MessageBox.Show("O registro foi  Atualizado com sucesso!",
                                    "Transação Concluída", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                }

                if (ModoOperacao == "N")
                {
                    //fornecedorDTO.Email = this.txtEMAIL.Text;

                    FornecedorControl fornecedor = new FornecedorControl();

                    //fornecedor.Incluir(fornecedorDTO);

                    ModoOperacao = "";
                    DesativaControles();

                    MessageBox.Show("O registro foi salvo com sucesso!",
                                    "Transação Concluída", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }

                Pesquisar(dgPesquisa, this.txtPESQUISA.Text);
                SistemaEmEspera();
            }
        }

    }
}
