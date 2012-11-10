using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using SPCP.Controler;

namespace SPCP.View
{
    public partial class frmCadastroMain : Form
    {
        public int id;
        public string strErrMsg;

        public string ModoOperacao;

        public frmCadastroMain()
        {
            InitializeComponent();
        }

        public void frmCadastroMain_Load(object sender, EventArgs e)
        {
            DesativaControles();
            SistemaEmEspera();
            ModoOperacao = "";
            InicializarComboBoxes();
        }

        public void carregaCombos()
        {
            string[] items = new string[27] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" };
            string[] status = new string[2] { "ATIVO", "INATIVO" };
        }

        public void DesativaControles()
        {
            this.grpCadastro.Enabled = false;
        }

        public void AtivaControles()
        {
            this.grpCadastro.Enabled = true;
        }

        public void ExibeTabPage(int i)
        {
            switch (i)
            {
                case 0:
                    tabCadCliente.SelectedTab = tabPesquisa;
                    break;
                case 1:
                    tabCadCliente.SelectedTab = tabCadastro;
                    break;
            }
            return;
        }

        public void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            ExibeTabPage(1);
            AtivaControles();
            ModoOperacao = "N";

            SistemaEmEdicao();
        }

        public void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        public void SistemaEmEspera()
        {
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
        }

        public void SistemaEmEdicao()
        {
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true; ;
        }

        public void dtPesquisa_DoubleClick(object sender, EventArgs e)
        {
            ExibeTabPage(1);
        }

        public void btnCancelar_Click(object sender, EventArgs e)
        {
            DesativaControles();
            SistemaEmEspera();
        }

        public void btnEditar_Click(object sender, EventArgs e)
        {
            ExibeTabPage(1);
            AtivaControles();
            ModoOperacao = "E";
            SistemaEmEdicao();

        }

        public void LimpaCampos()
        {
            ClearControlsTxt(this.grpCadastro);
        }

        public void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar(dgPesquisa, txtPESQUISA.Text);
        }

        public void dgPesquisa_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dgPesquisa.CurrentRow.Cells[0].Value);
            CarregaDadosControles(id);
        }

        public void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir(id);
        }

        public void ClearControlsTxt(System.Windows.Forms.Control Ctrl)
        {
            try
            {
                if (Ctrl is MaskedTextBox)
                {
                    MaskedTextBox MskTx = Ctrl as MaskedTextBox;
                    MskTx.Text = "";
                }
                else if (Ctrl is ComboBox)
                {
                    ComboBox ctrCbx = Ctrl as ComboBox;
                    ctrCbx.Text = "";
                    ctrCbx.SelectedValue = 0;
                    ctrCbx.SelectedItem = null;
                    ctrCbx.SelectedIndex = -1;
                }
                else if (Ctrl is TextBox)
                {
                    TextBox ctrTxt = Ctrl as TextBox;
                    ctrTxt.Text = "";
                }

                //chamada recursiva
                foreach (System.Windows.Forms.Control ctrChild in Ctrl.Controls)
                    ClearControlsTxt(ctrChild);

                return;
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                strErrMsg = "Atenção, o sistema detectou o seguinte problema: " + "\r\n" +
                    "Descrição: " + Convert.ToString(ex.Message) + "\r\n" +
                    "Origem: " + Convert.ToString(ex.Source);
                MessageBox.Show(strErrMsg, "Procedimento: " + Convert.ToString(ex.TargetSite),
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//fim ClearControlsTxt

        public bool ValidaPreenchimento(System.Windows.Forms.Control ctrl)
        {
            try
            {
                //valida controles do tipo MaskedTextBox
                if (ctrl is MaskedTextBox)
                {
                    MaskedTextBox mskTXT = ctrl as MaskedTextBox;
                    if ((mskTXT.Mask == "99/99/9999") | (mskTXT.Mask == "##/##/####"))
                    {
                        //usando expressões regulares para verificar se uma data é válida
                        Regex Data = new Regex(@"^((((0?[1-9]|[12]\d|3[01])[\-](0?[13578]|1[02])[\-]((1[6-9]|[2-9]\d)?\d{2}))|((0?[1-9]|[12]\d|30)[\-](0?[13456789]|1[012])[\-]((1[6-9]|[2-9]\d)?\d{2}))|((0?[1-9]|1\d|2[0-8])[\-]0?2[\-]((1[6-9]|[2-9]\d)?\d{2}))|(29[\-]0?2[\-]((1[6-9]|[2-9]\d)?(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00)|00)))|(((0[1-9]|[12]\d|3[01])(0[13578]|1[02])((1[6-9]|[2-9]\d)?\d{2}))|((0[1-9]|[12]\d|30)(0[13456789]|1[012])((1[6-9]|[2-9]\d)?\d{2}))|((0[1-9]|1\d|2[0-8])02((1[6-9]|[2-9]\d)?\d{2}))|(2902((1[6-9]|[2-9]\d)?(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00)|00))))$");
                        if (Data.IsMatch(mskTXT.Text.ToString()) == false)
                        {
                            MessageBox.Show("Atenção, o valor informado no campo '" + mskTXT.Tag.ToString() +
                                "' é inválido!. Verifique, por favor.", "Validação de dados dos formulários",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            mskTXT.Focus();
                            mskTXT.SelectAll();
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }

                    if (mskTXT.Text == "")
                    {
                        MessageBox.Show("Atenção, o valor informado no campo '" + mskTXT.Tag.ToString() +
                            "' é inválido!. Verifique, por favor.", "Validação de dados dos formulários",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        mskTXT.Focus();
                        mskTXT.SelectAll();
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }

                //Valida controles do tipo COMBOBOX
                else if (ctrl is ComboBox)
                {
                    ComboBox ctrlCbx = ctrl as ComboBox;
                    if (ctrlCbx.SelectedIndex < 0)
                    {
                        MessageBox.Show("Atenção, o valor informado no campo '" + ctrlCbx.Tag.ToString() +
                            "' é inválido!. Verifique, por favor.", "Validação de dados dos formulários",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ctrlCbx.Focus();
                        ctrlCbx.SelectAll();
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }

                else if (ctrl is TextBox)
                {
                    TextBox ctrlTxt = ctrl as TextBox;

                    if (ENumerico(ctrlTxt.Text) == true)
                    {
                        decimal result;
                        if (decimal.TryParse(ctrlTxt.Text, out result))
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Atenção, o valor informado no campo '" + ctrlTxt.Tag.ToString() +
                                "' é inválido!. Verifique, por favor.", "Validação de dados dos formulários",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ctrlTxt.Focus();
                            ctrlTxt.SelectAll();
                            return false;
                        }
                    }//fim ÉNumérico
                    //----------------------------------------------------------------------------------//
                    if (ctrlTxt.Text == "")
                    {
                        MessageBox.Show("Atenção, o valor informado no campo '" + ctrlTxt.Tag.ToString() +
                            "' é inválido!. Verifique, por favor.", "Validação de dados dos formulários",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ctrlTxt.Focus();
                        ctrlTxt.SelectAll();
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                strErrMsg = "Atenção, o sistema detectou o seguinte problema: " + "\r\n" +
                    "Descrição: " + Convert.ToString(ex.Message) + "\r\n" +
                    "Origem: " + Convert.ToString(ex.Source);
                MessageBox.Show(strErrMsg, "Procedimento: " + Convert.ToString(ex.TargetSite),
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }//fim ValidaPreenchimento

        public bool ENumerico(string val)
        {
            try
            {
                bool b = false;
                Int32 result;
                if (Int32.TryParse(val, out result))
                {
                    b = true;
                }
                return b;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Atenção, o procedimento de verificação do tipo de dado Numérico informado " +
                    "para validação de 'Campos de Dados dos Formulário'" + " gerou o seguinte erro:" + "\r\n" + "\r\n" +
                    "Descrição: " + Convert.ToString(ex.Message) + "\r\n" +
                    "Origem: " + Convert.ToString(ex.Source) + "\r\n" +
                    "Procedimento: " + Convert.ToString(ex.TargetSite), ex.InnerException.ToString(),
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
        }
        
        public virtual void Salvar()
        {
            //esse metodo deve ser sobrescrito na classe filha
        }

        public virtual void Pesquisar(DataGridView dg, string nome)
        {
            //esse metodo deve ser sobrescrito na classe filha
        }

        public virtual void Excluir(int id)
        {
            //esse metodo deve ser sobrescrito na classe filha
        }

        public virtual void CarregaDadosControles(int id)
        {
            //esse metodo deve ser sobrescrito na classe filha
        }

        public virtual bool ValidaCampos()
        {
            //esse metodo deve ser sobrescrito na classe filha
            return false;
        }

        public virtual void InicializarComboBoxes()
        {
            //esse metodo deve ser sobrescrito na classe filha
        }
    }
}
