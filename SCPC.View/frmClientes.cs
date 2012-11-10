using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using SPCP.Controller;

namespace SPCP.View
{
    public partial class frmClientes : frmCadastroMain
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        public override void Salvar()
        {
            if (ValidaCampos())
            {
                if (ModoOperacao == "E")
                {
                    ClienteDTO clienteDTO = new ClienteDTO();
                    clienteDTO.Id = id;
                    clienteDTO.Nome = this.txtNOME.Text;
                    clienteDTO.Cnpj = this.txtCNPJ.Text;
                    clienteDTO.Rua = this.txtRUA.Text;
                    clienteDTO.Bairro = this.txtBAIRRO.Text;
                    clienteDTO.Complemento = this.txtCOMPLEMENTO.Text;
                    clienteDTO.Cidade = this.txtCIDADE.Text;
                    clienteDTO.Cep = this.txtCEP.Text;
                    clienteDTO.Celular = this.txtFONE_CELULAR.Text;
                    clienteDTO.Telefone = this.txtFONE_RESID.Text;
                    clienteDTO.Uf = this.cbxESTADO.Text;
                    clienteDTO.NumRua = this.txtNUM.Text;
                    clienteDTO.Situacao = this.cbxSITUACAO.Text;
                    clienteDTO.Email = this.txtEMAIL.Text;

                    ClienteControl cliente = new ClienteControl();
                    cliente.Alterar(clienteDTO);

                    ModoOperacao = "";
                    DesativaControles();

                    MessageBox.Show("O registro foi  Atualizado com sucesso!",
                                    "Transação Concluída", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                }

                if (ModoOperacao == "N")
                {
                    ClienteDTO clienteDTO = new ClienteDTO();
                    clienteDTO.Id = id;
                    clienteDTO.Nome = this.txtNOME.Text;
                    clienteDTO.Cnpj = this.txtCNPJ.Text;
                    clienteDTO.Rua = this.txtRUA.Text;
                    clienteDTO.Bairro = this.txtBAIRRO.Text;
                    clienteDTO.Complemento = this.txtCOMPLEMENTO.Text;
                    clienteDTO.Cidade = this.txtCIDADE.Text;
                    clienteDTO.Cep = this.txtCEP.Text;
                    clienteDTO.Celular = this.txtFONE_CELULAR.Text;
                    clienteDTO.Telefone = this.txtFONE_RESID.Text;
                    clienteDTO.Uf = this.cbxESTADO.Text;
                    clienteDTO.NumRua = this.txtNUM.Text;
                    clienteDTO.Situacao = this.cbxSITUACAO.Text;
                    clienteDTO.Email = this.txtEMAIL.Text;

                    ClienteControl cliente = new ClienteControl();

                    cliente.Incluir(clienteDTO);

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

                ClienteControl cliente = new ClienteControl();
                excluido = cliente.Excluir(id);

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

        public override void CarregaDadosControles(int id)
        {
            ClienteControl cliente = new ClienteControl();
            DataTable dt = cliente.CarregarDadosCliente(id);
            DataRow row = dt.Rows[0];

            this.txtNOME.Text = row["NOME_CLIENTE"].ToString();
            this.txtCNPJ.Text = row["CNPJ_CLIENTE"].ToString();
            this.txtRUA.Text = row["RUA_CLIENTE"].ToString();
            this.txtNUM.Text = row["NUM_CLIENTE"].ToString();
            this.txtBAIRRO.Text = row["BAIRRO_CLIENTE"].ToString();
            this.txtCOMPLEMENTO.Text = row["COMPL_CLIENTE"].ToString();
            this.txtCIDADE.Text = row["CIDADE_CLIENTE"].ToString();
            this.txtCEP.Text = row["CEP_CLIENTE"].ToString();
            this.txtFONE_CELULAR.Text = row["TELCEL_CLIENTE"].ToString();
            this.txtFONE_RESID.Text = row["TEL_CLIENTE"].ToString();
            this.cbxESTADO.Text = row["UF_CLIENTE"].ToString();
            this.cbxSITUACAO.Text = row["ST_CLIENTE"].ToString();
            this.txtEMAIL.Text = row["EMAIL_CLIENTE"].ToString();
        }

        public override void Pesquisar(DataGridView dg, string nome)
        {
            DataTable dt = new DataTable();
            ClienteControl cliente = new ClienteControl();
            dt = cliente.Pesquisar(nome);

            //popula o datagrid retornado
            dg.RowsDefaultCellStyle.BackColor = Color.White;
            dg.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dg.EnableHeadersVisualStyles = true;
            dg.DataSource = dt;

            //formata as colunas do datagrid
            dg.Columns["ID_CLIENTE"].HeaderText = "Reg. nº"; //Nome coluna
            dg.Columns["ID_CLIENTE"].Width = 80; //largura coluna
            dg.Columns["ID_CLIENTE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dg.Columns["ID_CLIENTE"].ToolTipText = "Número do Registro";
            dg.Columns["ID_CLIENTE"].DefaultCellStyle.Format = "0000000";
            dg.Columns["ID_CLIENTE"].Visible = true;

            dg.Columns["NOME_CLIENTE"].HeaderText = "Nome"; //Nome coluna
            dg.Columns["NOME_CLIENTE"].Width = 300; //largura coluna
            dg.Columns["NOME_CLIENTE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dg.Columns["NOME_CLIENTE"].ToolTipText = "Nome";
            dg.Columns["NOME_CLIENTE"].Visible = true;

            dg.Columns["CNPJ_CLIENTE"].HeaderText = "CNPJ"; //Nome coluna
            dg.Columns["CNPJ_CLIENTE"].Width = 150; //largura coluna
            dg.Columns["CNPJ_CLIENTE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dg.Columns["CNPJ_CLIENTE"].ToolTipText = "CNPJ do CLIENTE";
            dg.Columns["CNPJ_CLIENTE"].Visible = true;

            dg.Columns["CIDADE_CLIENTE"].HeaderText = "Cidade"; //Nome coluna
            dg.Columns["CIDADE_CLIENTE"].Width = 150; //largura coluna
            dg.Columns["CIDADE_CLIENTE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dg.Columns["CIDADE_CLIENTE"].ToolTipText = "Cidade";
            dg.Columns["CIDADE_CLIENTE"].Visible = true;

            dg.Columns["TEL_CLIENTE"].HeaderText = "Telefone"; //Nome coluna
            dg.Columns["TEL_CLIENTE"].Width = 150; //largura coluna
            dg.Columns["TEL_CLIENTE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dg.Columns["TEL_CLIENTE"].ToolTipText = "Telefone";
            dg.Columns["TEL_CLIENTE"].Visible = true;

            dg.Refresh();

            //-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*
            return;
        
        }

        public override bool ValidaCampos()
        {
            if (!ValidaPreenchimento(this.txtNOME))
                return false;

            if (!ValidaPreenchimento(this.txtCNPJ))
                return false;
            return true;
        }


    }
}
