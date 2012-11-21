using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SPCP.Controller;

namespace SPCP.View
{
    public partial class frmRelatorio : Form
    {
        public frmRelatorio()
        {
            InitializeComponent();
        }

        public void GeraRelatorio()
        {
            frmVisualRelatorios frmCrystalViewer = new frmVisualRelatorios();
            RelatorioControl relatorio = new RelatorioControl();

            relatorio.pReportCaption = string.Empty;
            relatorio.pReportOwner = "EMPRESA XXXXX UNID. TAL TAL";
            relatorio.pReportPeríodo = string.Empty;
            relatorio.pReportName = this.tslIdRel + "-" + this.tslDescrRel;
            relatorio.pReportData = string.Empty;
            relatorio.pReportUsuário = string.Empty;
            relatorio.pReportCPF_CNPJ = string.Empty;
            relatorio.pReportHeader = "SPCP SOFTWARE - RELATÓRIOS - EMPRESA XXXXX/2012";
            relatorio.SQL = RelatorioControl.MakeSql();

            frmCrystalViewer.SetCrystalReportResources();
            frmCrystalViewer.crystalReportViewer1.ReportSource = relatorio.GeraRol(Convert.ToInt32(tslIdRel.Text));
            frmCrystalViewer.Show();
        }

        private void frmRelatorio_Load(object sender, EventArgs e)
        {
            Pesquisar(dgPesquisa);
        }

        public void Pesquisar(DataGridView dg)
        {
            RelatorioControl rControl = new RelatorioControl();
            BindingSource pesquisa = new BindingSource();

            pesquisa.DataSource = rControl.GetRelatorios();
            dg.DataSource = pesquisa;

            if (pesquisa.Count <= 0) //trata o caso q a busca é vazia.
            {
                return;
            }

            //popula o datagrid retornado
            dg.RowsDefaultCellStyle.BackColor = Color.White;
            dg.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dg.EnableHeadersVisualStyles = true;

            //formata as colunas do datagrid
            dg.Columns["Id"].HeaderText = "Rel. nº"; //Nome coluna
            dg.Columns["Id"].Width = 78; //largura coluna
            dg.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dg.Columns["Id"].ToolTipText = "Número do Relatório";
            dg.Columns["Id"].DefaultCellStyle.Format = "0000000";
            dg.Columns["Id"].Visible = true;

            dg.Columns["Descricao"].HeaderText = "Descrição"; //Nome coluna
            dg.Columns["Descricao"].Width = 597; //largura coluna
            dg.Columns["Descricao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dg.Columns["Descricao"].ToolTipText = "Descrição do Relatório";
            dg.Columns["Descricao"].Visible = true;

            dg.Refresh();
        }

        private void dgPesquisa_Click(object sender, EventArgs e)
        {
            if (dgPesquisa.CurrentRow != null)
            {
                this.tslIdRel.Text = dgPesquisa.CurrentRow.Cells[0].Value.ToString();
                this.tslDescrRel.Text = Convert.ToString(dgPesquisa.CurrentRow.Cells[1].Value);
            }
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.tslIdRel.Text))
            {
                GeraRelatorio();
            }
        }

    }
}
