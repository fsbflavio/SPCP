using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SPCP.Controler;

namespace SPCP.View
{
    public partial class frmFornecedores : frmCadastroMain
    {
        public frmFornecedores()
        {
            InitializeComponent();
        }

        public override bool ValidaCampos()
        {
            if (!ValidaPreenchimento(this.txtNOME))
                return false;
            if (!ValidaPreenchimento(this.txtCNPJ))
                return false;
            return true;
        }

        public override void Salvar()
        {
            if (ValidaCampos())
            {
                if (ModoOperacao == "E")
                {
                    FornecedorDTO fornecedorDTO = new FornecedorDTO();
                    fornecedorDTO.Id = id;
                    fornecedorDTO.Nome = this.txtNOME.Text;
                    fornecedorDTO.Cnpj = this.txtCNPJ.Text;
                    fornecedorDTO.Rua = this.txtRUA.Text;
                    fornecedorDTO.Bairro = this.txtBAIRRO.Text;
                    fornecedorDTO.Complemento = this.txtCOMPLEMENTO.Text;
                    fornecedorDTO.Cidade = this.txtCIDADE.Text;
                    fornecedorDTO.Cep = this.txtCEP.Text;
                    fornecedorDTO.Celular = this.txtFONE_CELULAR.Text;
                    fornecedorDTO.Telefone = this.txtFONE_RESID.Text;
                    fornecedorDTO.Uf = this.cbxESTADO.Text;
                    fornecedorDTO.NumRua = this.txtNUM.Text;
                    fornecedorDTO.Situacao = this.cbxSITUACAO.Text;
                    fornecedorDTO.Email = this.txtEMAIL.Text;

                    FornecedorControl fornecedor = new FornecedorControl();
                    fornecedor.Alterar(fornecedorDTO);

                    ModoOperacao = "";
                    DesativaControles();

                    MessageBox.Show("O registro foi  Atualizado com sucesso!",
                                    "Transação Concluída", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                }

                if (ModoOperacao == "N")
                {
                    FornecedorDTO fornecedorDTO = new FornecedorDTO();
                    fornecedorDTO.Id = id;
                    fornecedorDTO.Nome = this.txtNOME.Text;
                    fornecedorDTO.Cnpj = this.txtCNPJ.Text;
                    fornecedorDTO.Rua = this.txtRUA.Text;
                    fornecedorDTO.Bairro = this.txtBAIRRO.Text;
                    fornecedorDTO.Complemento = this.txtCOMPLEMENTO.Text;
                    fornecedorDTO.Cidade = this.txtCIDADE.Text;
                    fornecedorDTO.Cep = this.txtCEP.Text;
                    fornecedorDTO.Celular = this.txtFONE_CELULAR.Text;
                    fornecedorDTO.Telefone = this.txtFONE_RESID.Text;
                    fornecedorDTO.Uf = this.cbxESTADO.Text;
                    fornecedorDTO.NumRua = this.txtNUM.Text;
                    fornecedorDTO.Situacao = this.cbxSITUACAO.Text;
                    fornecedorDTO.Email = this.txtEMAIL.Text;

                    FornecedorControl fornecedor = new FornecedorControl();

                    fornecedor.Incluir(fornecedorDTO);

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

        public override void CarregaDadosControles(int id)
        {
            FornecedorControl fornecedor = new FornecedorControl();
            DataTable dt = fornecedor.CarregarDadosFornecedor(id);
            //DataTable dt = fControl.CarregarDadosFornecedor(id);
            DataRow row = dt.Rows[0];

            //.Id = Convert.ToInt32(dr["ID_FORNECEDOR"]);
            this.txtNOME.Text = row["NOME_FORNECEDOR"].ToString();
            this.txtCNPJ.Text = row["CNPJ_FORNECEDOR"].ToString();
            this.txtRUA.Text = row["RUA_FORNECEDOR"].ToString();
            this.txtNUM.Text = row["NUM_FORNECEDOR"].ToString();
            this.txtBAIRRO.Text = row["BAIRRO_FORNECEDOR"].ToString();
            this.txtCOMPLEMENTO.Text = row["COMPL_FORNECEDOR"].ToString();
            this.txtCIDADE.Text = row["CIDADE_FORNECEDOR"].ToString();
            this.txtCEP.Text = row["CEP_FORNECEDOR"].ToString();
            this.txtFONE_CELULAR.Text = row["TELCEL_FORNECEDOR"].ToString();
            this.txtFONE_RESID.Text = row["TEL_FORNECEDOR"].ToString();
            this.cbxESTADO.Text = row["UF_FORNECEDOR"].ToString();
            this.cbxSITUACAO.Text = row["ST_FORNECEDOR"].ToString();
            this.txtEMAIL.Text = row["EMAIL_FORNECEDOR"].ToString();
        }

        public override void Pesquisar(DataGridView dg, string nome)
        {
            DataTable dt = new DataTable();
            FornecedorControl fornecedor = new FornecedorControl();
            dt = fornecedor.Pesquisar(nome);

            //popula o datagrid retornado
            dg.RowsDefaultCellStyle.BackColor = Color.White;
            dg.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dg.EnableHeadersVisualStyles = true;
            dg.DataSource = dt;

            //formata as colunas do datagrid
            dg.Columns["ID_FORNECEDOR"].HeaderText = "Reg. nº"; //Nome coluna
            dg.Columns["ID_FORNECEDOR"].Width = 80; //largura coluna
            dg.Columns["ID_FORNECEDOR"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dg.Columns["ID_FORNECEDOR"].ToolTipText = "Número do Registro";
            dg.Columns["ID_FORNECEDOR"].DefaultCellStyle.Format = "0000000";
            dg.Columns["ID_FORNECEDOR"].Visible = true;

            dg.Columns["NOME_FORNECEDOR"].HeaderText = "Nome"; //Nome coluna
            dg.Columns["NOME_FORNECEDOR"].Width = 300; //largura coluna
            dg.Columns["NOME_FORNECEDOR"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dg.Columns["NOME_FORNECEDOR"].ToolTipText = "Nome";
            dg.Columns["NOME_FORNECEDOR"].Visible = true;

            dg.Columns["CNPJ_FORNECEDOR"].HeaderText = "CNPJ"; //Nome coluna
            dg.Columns["CNPJ_FORNECEDOR"].Width = 150; //largura coluna
            dg.Columns["CNPJ_FORNECEDOR"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dg.Columns["CNPJ_FORNECEDOR"].ToolTipText = "CNPJ do Fornecedor";
            dg.Columns["CNPJ_FORNECEDOR"].Visible = true;

            dg.Columns["CIDADE_FORNECEDOR"].HeaderText = "Cidade"; //Nome coluna
            dg.Columns["CIDADE_FORNECEDOR"].Width = 150; //largura coluna
            dg.Columns["CIDADE_FORNECEDOR"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dg.Columns["CIDADE_FORNECEDOR"].ToolTipText = "Cidade";
            dg.Columns["CIDADE_FORNECEDOR"].Visible = true;

            dg.Columns["TEL_FORNECEDOR"].HeaderText = "Telefone"; //Nome coluna
            dg.Columns["TEL_FORNECEDOR"].Width = 150; //largura coluna
            dg.Columns["TEL_FORNECEDOR"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dg.Columns["TEL_FORNECEDOR"].ToolTipText = "Telefone";
            dg.Columns["TEL_FORNECEDOR"].Visible = true;

            dg.Refresh();

            //-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*
            return;
        }

        public override void Excluir(int id)
        {
            bool excluido;

            try
            {
                if (id == 0)
                {
                    MessageBox.Show("Atenção, não há um registro selecionado em vídeo " +
                        "para exclusão. Verifique, por favor!", "Transação Inválida",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                //inicia procedimento de exclusão do registro corrente
                DialogResult i;
                i = MessageBox.Show("Atenção, o seguinte registro será permanentemente " +
                    "excluído do sistema:" + "\r\n" + "\r\n" +
                    "Registro nº : " + id.ToString() + "\r\n" +
                    "Descrição : " + this.txtNOME.Text.ToUpper() + "\r\n" +
                        "\r\n" +
                    "Confirma a exclusão do registro corrente?", "Exclusão de Registros",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                switch (i)
                {
                    case (DialogResult.No):
                        MessageBox.Show("A exclusão do registro corrente foi cancelada " +
                            "pelo usuário!", "Exclusão Cancelada", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        return;
                }

                FornecedorControl fornecedor = new FornecedorControl();
                excluido = fornecedor.Excluir(id);

                if (excluido)
                {
                    LimpaCampos();
                    SistemaEmEspera();
                    Pesquisar(dgPesquisa, txtPESQUISA.Text);

                    MessageBox.Show("O registro foi excluído com sucesso!", "Exclusão " +
                        "de registros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Atenção, o registro não pôde ser excluído!. " +
                        "Repita a operação. Se o problema persistir, entre em contato " +
                        "com o suporte.", "Problema na exclusão do registro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

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
        }
    }
}
