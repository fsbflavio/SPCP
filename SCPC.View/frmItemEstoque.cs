using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SPCP.Controller;
using SPCP.Util;

namespace SPCP.View
{
    public partial class frmItemEstoque : frmCadastroMain
    {
        public frmItemEstoque()
        {
            InitializeComponent();
        }

        public override void Salvar()
        {
            if (ValidaCampos())
            {
                ItemEstoqueControl itemEstoqueControl = new ItemEstoqueControl();
                
                ComboBoxItem grupoSelecionado = (ComboBoxItem)this.comboBoxGrupoEstoque.SelectedItem;
                ItemEstoqueDTO itemEstoqueDTO = new ItemEstoqueDTO();
                itemEstoqueDTO.Descricao = this.txtDescricao.Text;
                itemEstoqueDTO.UnidadeMedida = (UnidadeMedida)this.comboBoxUnidadeMedida.SelectedItem;
                itemEstoqueDTO.IdGrupoItemEstoque = grupoSelecionado.id;
                itemEstoqueDTO.EstoqueMinimo = int.Parse(this.textBoxEstoqueMinimo.Text);

                if (this.ModoOperacao == "E")
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

                    itemEstoqueControl.Incluir(itemEstoqueDTO);

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

        public override void Pesquisar(DataGridView dg, string nome)
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
                    "Descrição : " + this.txtDescricao.Text.ToUpper() + "\r\n" +
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

                ItemEstoqueControl itemEstoqueControl = new ItemEstoqueControl();
                excluido = itemEstoqueControl.Excluir(id);

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
            ItemEstoqueControl itemEstoque = new ItemEstoqueControl();
            DataTable dt = itemEstoque.CarregarDadosItemEstoque(id);
            //DataTable dt = fControl.CarregarDadosFornecedor(id);
            DataRow row = dt.Rows[0];

            //.Id = Convert.ToInt32(dr["ID_FORNECEDOR"]);
            this.textBoxCodigo.Text = row["ID_GRUPO"].ToString();
            this.txtDescricao.Text = row["DESCRICAO"].ToString();
            this.textBoxEstoqueMinimo.Text = row["ESTOQUE_MINIMO"].ToString();
            //this.comboBoxGrupoEstoque.Text = row["NUM_FORNECEDOR"].ToString();
            this.comboBoxUnidadeMedida.Text = row["UNIDADE_MEDIDA"].ToString();
        }

        public override bool ValidaCampos()
        {
            if (!ValidaPreenchimento(this.textBoxCodigo))
                return false;
            if (!ValidaPreenchimento(this.txtDescricao))
                return false;
            return true;
        }

        public override void InicializarComboBoxes()
        {
            // remover isso e inicializar do banco quando o cadastro estiver pronto
            this.comboBoxUnidadeMedida.Items.AddRange(ComboBoxSistema.unidadesMedida());
            this.comboBoxGrupoEstoque.Items.AddRange(ComboBoxSistema.gruposItemEstoque());
        }
    }
}
