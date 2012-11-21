using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows;
using SPCP.Model;

namespace SPCP.Controller
{
    public class RelatorioControl
    {
        public string SQL;

        protected string sErrMsg; //Mensagens de Erros da Classe
        protected string sErrCap; //Caption das mensagens de erros

        //Cabeçalho e Rodapé
        public string pReportHeader;
        public string pReportOwner;
        public string pReportName;
        public string pReportUsuário;
        public string pReportPeríodo;
        public string pReportCPF_CNPJ;
        public string pReportEndereço;
        public string pReportCaption;
        public string pReportData;

        protected ReportDocument ReportBuilder(string sReportPath, DataSet ds)
        {
            ReportDocument Report = new ReportDocument();
            try
            {
                //Carrega o Arquivo de Relatório
                Report.Load(sReportPath);

                //Seta os Rotulos do Relátorio
                (Report.ReportDefinition.ReportObjects["txtReportHeader"] as TextObject).Text = pReportHeader;
                (Report.ReportDefinition.ReportObjects["txtReportOwner"] as TextObject).Text = pReportOwner;
                (Report.ReportDefinition.ReportObjects["txtReportPeríodo"] as TextObject).Text = "PERÍODO: " + pReportPeríodo;
                (Report.ReportDefinition.ReportObjects["txtReportName"] as TextObject).Text = "RELATÓRIO: " + pReportName;
                (Report.ReportDefinition.ReportObjects["txtReportUsuário"] as TextObject).Text = "USUÁRIO: " + pReportUsuário;
                (Report.ReportDefinition.ReportObjects["txtReportData"] as TextObject).Text = "TIPO: " + pReportData;

                //Configura a Origem dos dados
                Report.SetDataSource(ds.Tables[0]);

                return Report;

            }
            catch (Exception ex)
            {
                sErrMsg = "Atenção, o processamento de exibição final do relatório " + "\r\n" +
                        "detectou o seguinte problema:" + "\r\n" +
                        "Descrição : " + ex.Message.ToString() + "\r\n" +
                        "Origem : " + ex.Source.ToString();
                sErrCap = "Procedimento : " + ex.TargetSite.ToString();
                MessageBox.Show(sErrMsg, sErrCap, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;

            }
        }

        public ReportDocument GeraRol(int ID_REL)
        {
            string local;
            DataSet ds;
            local = Relatorio.GetLocalRol(ID_REL);
            ds = Relatorio.LoadRecords(this.SQL);

            return this.ReportBuilder(local, ds);
        }

        public static string MakeSql()
        {
            return "SELECT * FROM FICHA_PRODUTO";
        }

        public ArrayList GetRelatorios()
        {
            return Relatorio.GetRelatorios();
        }

    }
}
