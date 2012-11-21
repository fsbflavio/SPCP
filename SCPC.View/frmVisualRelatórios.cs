using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SPCP.Controller;

using CrystalDecisions.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace SPCP.View
{
    public partial class frmVisualRelatorios : Form
    {
        string strErrMsg;

        protected string sErrMsg; //Mensagens de Erros da Classe
        protected string sErrCap; //Caption das mensagens de erros

        public string NomeForm;

        public CrystalReportViewer CrystalReportViewer;

        public frmVisualRelatorios()
        {
            InitializeComponent();
        }

        //■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■
        private void ConfiguraFormulário()
        {
            try
            {
                //centraliza o formulário dentro da área de trabalho do form MDI
                Cursor.Current = Cursors.AppStarting; //aciona o cursos de carregamento de aplicativo
                Application.DoEvents();
                short xScreen, yScreen, xFrm, yFrm, xDesktop, yDesktop;

                xScreen = Convert.ToInt16(Screen.PrimaryScreen.WorkingArea.Width);
                yScreen = Convert.ToInt16(Screen.PrimaryScreen.WorkingArea.Height);
                xFrm = Convert.ToInt16(this.Width);
                yFrm = Convert.ToInt16(this.Height);
                xDesktop = Convert.ToInt16((xScreen / 2) - (xFrm / 2));
                yDesktop = Convert.ToInt16((yScreen / 2) - (yFrm / 2) - 60);
                this.SetDesktopLocation(xDesktop, yDesktop);

                this.crystalReportViewer1 = CrystalReportViewer;

                Cursor.Current = Cursors.Default;
                return;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
                strErrMsg = "Atenção, o sistema detectou o seguinte problema: " + "\r\n" +
                        "Descrição: " + Convert.ToString(ex.Message) + "\r\n" +
                        "Origem: " + Convert.ToString(ex.Source) + "\r\n" +
                        "Se o problema persistir, entre em contato com o suporte imediatamente.";
                MessageBox.Show(strErrMsg, "Procedimento: " + Convert.ToString(ex.TargetSite),
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                ConfiguraFormulário();
                return;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
                strErrMsg = "Atenção, o sistema detectou o seguinte problema: " + "\r\n" +
                        "Descrição: " + Convert.ToString(ex.Message) + "\r\n" +
                        "Origem: " + Convert.ToString(ex.Source) + "\r\n" +
                        "Se o problema persistir, entre em contato com o suporte imediatamente.";
                MessageBox.Show(strErrMsg, "Procedimento: " + Convert.ToString(ex.TargetSite),
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        public void SetCrystalReportResources()
        {
            try
            {
                //Configura as características visuais e recursos na visualização do relatório

                this.crystalReportViewer1.DisplayBackgroundEdge = true;
                this.crystalReportViewer1.ShowGroupTreeButton = false;
                this.crystalReportViewer1.DisplayToolbar = true;
                this.crystalReportViewer1.ShowCloseButton = true;
                this.crystalReportViewer1.ShowExportButton = true;
                this.crystalReportViewer1.ShowGotoPageButton = true;
                this.crystalReportViewer1.ShowGroupTreeButton = false;
                this.crystalReportViewer1.ShowPageNavigateButtons = true;
                this.crystalReportViewer1.ShowPrintButton = true;
                this.crystalReportViewer1.ShowRefreshButton = false;
                this.crystalReportViewer1.ShowTextSearchButton = true;
                this.crystalReportViewer1.ShowZoomButton = true;
                this.crystalReportViewer1.EnableToolTips = true;
                this.crystalReportViewer1.EnableDrillDown = false;

                this.Text = NomeForm;
                return;
            }
            catch (Exception ex)
            {
                sErrMsg = "Atenção, a configuração de exibição do arquivo fonte de relatório " + "\r\n" +
                        "detectou o seguinte problema:" + "\r\n" +
                        "Descrição : " + ex.Message.ToString() + "\r\n" +
                        "Origem : " + ex.Source.ToString();
                sErrCap = "Procedimento : " + ex.TargetSite.ToString();
                MessageBox.Show(sErrMsg, sErrCap, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
