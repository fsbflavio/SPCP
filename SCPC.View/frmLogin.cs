using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace SPCP.View
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtUsuario.Text == "trololo")
            {
                pictureBox1.Image = SPCP.View.Properties.Resources.easteregg;
                txtUsuario.Text = "";
            }
            else
            {

                if (txtUsuario.Text == "admin" && txtSenha.Text == "admin")
                {
                    for (int i = 0; i < 100; i++)
                    {
                        Thread.Sleep(10);
                        this.progressBar1.Value = i;
                    }

                    frmMainMDI frmMainMDI = new frmMainMDI();
                    frmMainMDI.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Nome de Usuario ou senha invalidos. Verifique, por favor.", this.Text.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtSenha.Text = "";
                    this.txtUsuario.Text = "";
                    this.txtUsuario.Focus();
                }

            }
        }

        private bool ValidaCampos()
        {
            try
            { //valida os campos do formulário de login
                //valida nome do usuário
                if (this.txtUsuario.Text.ToString() == string.Empty)
                {
                    MessageBox.Show("O nome do usuário informado é inválido. Verifique, por favor.",
                        this.Text.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtUsuario.Focus();
                    return false;

                }

                //valida a senha do usuário
                if (this.txtSenha.Text.ToString() == string.Empty)
                {
                    MessageBox.Show("A senha do usuário informada é inválida. Verifique, por favor.",
                        this.Text.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    this.txtSenha.Focus();
                    return false;
                }
                return true; //validação OK

            }
            catch (Exception ex)
            {
                string strMsg;
                strMsg = "Atenção, o sistema detectou o seguinte problema na validação de campos: " + "\r\n" +
                    "Descrição: " + Convert.ToString(ex.Message) + "\r\n" +
                    "Origem: " + Convert.ToString(ex.Source);
                MessageBox.Show(strMsg, "Procedimento: " + Convert.ToString(ex.TargetSite),
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.button1_Click(sender, null);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
