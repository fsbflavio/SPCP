using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using SPCP.Controler;
using SPCP.Util;

namespace SPCP.View
{
    public partial class frmItemEstoqueold : Form
    {
        private string strErrMsg;
        private string ModoOperacao;
        private int id_item;

        ItemEstoqueControl itemEstoqueControl = new ItemEstoqueControl();

        public frmItemEstoqueold()
        {
            InitializeComponent();
        }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            ModoOperacao = "N";
            limpaCampos();
            exibeTabPage(1);
            AtivaControles();

            SistemaEmEdicao();
        }

        private void SistemaEmEdicao()
        {
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true; ;
        }

        private void limpaCampos()
        {
            ClearControlsTxt(tabCadastro);
        }

        private void exibeTabPage(int i)
        {
            switch (i)
            {
                case 0:
                    tabControlItemEstoque.SelectedTab = tabPesquisa;
                    break;
                case 1:
                    tabControlItemEstoque.SelectedTab = tabCadastro;
                    break;
            }
            return;
        }

        private void frmItemEstoque_Load(object sender, EventArgs e)
        {
            inicializarComboBoxes();
            
            DesativaControles();
            SistemaEmEspera();
            ModoOperacao= "";
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

        private void inicializarComboBoxes()
        {
            // remover isso e inicializar do banco quando o cadastro estiver pronto
            this.comboBoxUnidadeMedida.Items.AddRange(ComboBoxSistema.unidadesMedida());
            this.comboBoxGrupoEstoque.Items.AddRange(ComboBoxSistema.gruposItemEstoque());
        }

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

        public bool ValidaCampos()
        {
            if (!ValidaPreenchimento(this.textBoxCodigo))
                return false;
            if (!ValidaPreenchimento(this.textBoxDescricao))
                return false;
            return true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {

                if (ModoOperacao == "E")
                {
                    itemEstoqueControl.Alterar(new ItemEstoqueDTO());

                    ModoOperacao = "";
                    DesativaControles();

                    MessageBox.Show("O registro foi  Atualizado com sucesso!",
                                    "Transação Concluída", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                }

                if (ModoOperacao == "N")
                {
                    ComboBoxItem grupoSelecionado = (ComboBoxItem) this.comboBoxGrupoEstoque.SelectedItem;

                    ItemEstoqueDTO itemEstoqueDTO = new ItemEstoqueDTO();
                    itemEstoqueDTO.Descricao = this.textBoxDescricao.Text;
                    itemEstoqueDTO.UnidadeMedida = (UnidadeMedida) this.comboBoxUnidadeMedida.SelectedItem;
                    itemEstoqueDTO.IdGrupoItemEstoque = grupoSelecionado.id;
                    itemEstoqueDTO.EstoqueMinimo = int.Parse(this.textBoxEstoqueMinimo.Text);

                    itemEstoqueControl.Incluir(itemEstoqueDTO);

                    ModoOperacao = "";
                    DesativaControles();

                    MessageBox.Show("O registro foi salvo com sucesso!",
                                    "Transação Concluída", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }

                ConfiguraDataGridView(dgPesquisa, this.txtPESQUISA.Text);
                SistemaEmEspera();
            }
            
        }

        public static void ConfiguraDataGridView(DataGridView dg, string nome)
        {
            DataTable dt = new DataTable();
            ItemEstoqueControl itemEstoque = new ItemEstoqueControl();
            dt = itemEstoque.Pesquisar(nome);

            //popula o datagrid retornado
            dg.RowsDefaultCellStyle.BackColor = Color.White;
            dg.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dg.EnableHeadersVisualStyles = true;
            dg.DataSource = dt;

            //formata as colunas do datagrid
            dg.Columns["ID_ITEM"].HeaderText = "Reg. nº"; //Nome coluna
            dg.Columns["ID_ITEM"].Width = 80; //largura coluna
            dg.Columns["ID_ITEM"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dg.Columns["ID_ITEM"].ToolTipText = "Número do Registro";
            dg.Columns["ID_ITEM"].DefaultCellStyle.Format = "0000000";
            dg.Columns["ID_ITEM"].Visible = true;

            dg.Columns["DESCRICAO"].HeaderText = "Descrição"; //Nome coluna
            dg.Columns["DESCRICAO"].Width = 300; //largura coluna
            dg.Columns["DESCRICAO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dg.Columns["DESCRICAO"].ToolTipText = "Descrição";
            dg.Columns["DESCRICAO"].Visible = true;

            dg.Columns["UNIDADE_MEDIDA"].HeaderText = "Unidade de Medida"; //Nome coluna
            dg.Columns["UNIDADE_MEDIDA"].Width = 150; //largura coluna
            dg.Columns["UNIDADE_MEDIDA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dg.Columns["UNIDADE_MEDIDA"].ToolTipText = "Unidade de Medida";
            dg.Columns["UNIDADE_MEDIDA"].Visible = true;

            dg.Columns["ESTOQUE_MINIMO"].HeaderText = "Estoque Minimo"; //Nome coluna
            dg.Columns["ESTOQUE_MINIMO"].Width = 150; //largura coluna
            dg.Columns["ESTOQUE_MINIMO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dg.Columns["ESTOQUE_MINIMO"].ToolTipText = "Estoque Minimo";
            dg.Columns["ESTOQUE_MINIMO"].Visible = true;

            dg.Refresh();

            //-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*
            return;
        }

        private void SistemaEmEspera()
        {
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
        }

        private void DesativaControles()
        {
            this.textBoxDescricao.Enabled = false;
            this.textBoxEstoqueMinimo.Enabled = false;
            this.textBoxCodigo.Enabled = false;
            this.comboBoxGrupoEstoque.Enabled = false;
            this.comboBoxUnidadeMedida.Enabled = false;
        }

        private void CarregaDados(int id_item)
        {
            ItemEstoqueControl itemEstoque = new ItemEstoqueControl();
            DataTable dt = itemEstoque.CarregarDadosItemEstoque(id_item);
            //DataTable dt = fControl.CarregarDadosFornecedor(id);
            DataRow row = dt.Rows[0];

            //.Id = Convert.ToInt32(dr["ID_FORNECEDOR"]);
            this.textBoxCodigo.Text = row["ID_GRUPO"].ToString();
            this.textBoxDescricao.Text = row["DESCRICAO"].ToString();
            this.textBoxEstoqueMinimo.Text = row["ESTOQUE_MINIMO"].ToString();
            //this.comboBoxGrupoEstoque.Text = row["NUM_FORNECEDOR"].ToString();
            this.comboBoxUnidadeMedida.Text = row["UNIDADE_MEDIDA"].ToString();
        }

        private void dgPesquisa_Click(object sender, EventArgs e)
        {
            id_item = Convert.ToInt32(dgPesquisa.CurrentRow.Cells["ID_ITEM"].Value);

            CarregaDados(id_item);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ConfiguraDataGridView(dgPesquisa, txtPESQUISA.Text);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ExibeTabPage(1);
            AtivaControles();
            ModoOperacao = "E";
        }

        private void ExibeTabPage(int i)
        {
            switch (i)
            {
                case 0:
                    tabControlItemEstoque.SelectedTab = tabPesquisa;
                    break;
                case 1:
                    tabControlItemEstoque.SelectedTab = tabCadastro;
                    break;
            }
            return;
        }


        private void AtivaControles()
        {
            this.textBoxDescricao.Enabled = true;
            this.textBoxEstoqueMinimo.Enabled = true;
            this.textBoxCodigo.Enabled = true;
            this.comboBoxGrupoEstoque.Enabled = true;
            this.comboBoxUnidadeMedida.Enabled = true;
        }

    }
}
