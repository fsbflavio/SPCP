using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Oracle.DataAccess.Client;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows;

namespace SPCP.Model
{
    public class Relatorio
    {
        public int Id {get; set;}
        public string Descricao { get; set; }
        public string Local;
        public string Nome;

        protected static string sErrMsg; //Mensagens de Erros da Classe
        protected static string sErrCap; //Caption das mensagens de erros

        public static string GetLocalRol(int ID_REL)
        {
            OracleDataReader dr;
            OracleCommand cmd = new OracleCommand();
            string res = null;
            string sql = string.Empty;
            try
            {

                cmd.Connection = Conexao.GetInstance();
                cmd.CommandType = CommandType.Text;

                sql = "SELECT LOCAL, NOME " +
                            "FROM RELatorio " +
                            "WHERE ID = '" + ID_REL + "'";

                cmd.CommandText = sql;
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    res = dr["LOCAL"].ToString() + dr["NOME"].ToString();
                }

                //=====================================================================|
                //Finaliza ds
                cmd.Dispose();
                return res;

            }
            catch (Exception ex)
            {
                sErrMsg = "Atenção, a função de recuperação de dados (Certificados/Etiquetas) " +
                    "detectou o seguinte problema:" +
                     "\r\n" + "\r\n" +
                    "Descrição : " + ex.Message.ToString() + "\r\n" +
                    "Origem : " + ex.Source.ToString();
                sErrCap = "Procedimento : " + ex.TargetSite.ToString();
                MessageBox.Show(sErrMsg, sErrCap, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                cmd.Dispose();
                return null;
            }
        }

        public DataTable GetListaRelatorio()
        {
            DataTable dt = new DataTable();
            OracleDataAdapter da = new OracleDataAdapter();
            OracleCommand cmd = new OracleCommand();
            string sql = string.Empty;
            try
            {

                cmd.Connection = Conexao.GetInstance();
                cmd.CommandType = CommandType.Text;

                sql = "SELECT ID_REL, DESCR_REL " +
                            "FROM CA_REL ";

                cmd.CommandText = sql;
                da.SelectCommand = cmd;
                da.Fill(dt);

                //Finaliza ds
                cmd.Dispose();
                return dt;

            }
            catch (Exception ex)
            {
                sErrMsg = "Atenção, a função de recuperação de dados (Certificados/Etiquetas) " +
                    "detectou o seguinte problema:" +
                     "\r\n" + "\r\n" +
                    "Descrição : " + ex.Message.ToString() + "\r\n" +
                    "Origem : " + ex.Source.ToString();
                sErrCap = "Procedimento : " + ex.TargetSite.ToString();
                MessageBox.Show(sErrMsg, sErrCap, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                cmd.Dispose();
                return null;
            }
        }

        public static ArrayList GetRelatorios()
        {
            Relatorio relatorio;

            OracleDataReader dr;
            ArrayList array = new ArrayList();
            OracleCommand cmd = new OracleCommand();
            string sql = string.Empty;
            try
            {

                cmd.Connection = Conexao.GetInstance();
                cmd.CommandType = CommandType.Text;

                sql = "SELECT * " +
                      "FROM RELATORIO ";

                cmd.CommandText = sql;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    relatorio = new Relatorio();

                    relatorio.Id = Convert.ToInt32(dr["ID"]);
                    relatorio.Descricao = dr.GetString(1);
                    relatorio.Local = dr.GetString(2);
                    relatorio.Nome = dr.GetString(3);

                    array.Add(relatorio);
                }

                //Finaliza ds
                cmd.Dispose();
                return array;

            }
            catch (Exception ex)
            {
                sErrMsg = "Atenção, a função de recuperação de dados (Certificados/Etiquetas) " +
                    "detectou o seguinte problema:" +
                     "\r\n" + "\r\n" +
                    "Descrição : " + ex.Message.ToString() + "\r\n" +
                    "Origem : " + ex.Source.ToString();
                sErrCap = "Procedimento : " + ex.TargetSite.ToString();
                MessageBox.Show(sErrMsg, sErrCap, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                cmd.Dispose();
                return null;
            }
        }

        public static DataSet LoadRecords(string SQL)
        {

            OracleDataAdapter da = new OracleDataAdapter();
            OracleCommand cmd = new OracleCommand();
            DataSet ds = new DataSet(); ;
            string sql = string.Empty;
            try
            {

                cmd.Connection = Conexao.GetInstance();
                cmd.CommandType = CommandType.Text;

                sql = SQL;

                cmd.CommandText = sql;
                da.SelectCommand = cmd;
                da = new OracleDataAdapter(cmd);
                da.Fill(ds, "Table");


                //=====================================================================|
                //Finaliza ds
                da.Dispose();
                cmd.Dispose();
                return ds;

            }
            catch (Exception ex)
            {
                sErrMsg = "Atenção, a função de recuperação de dados (Certificados/Etiquetas) " +
                    "detectou o seguinte problema:" +
                     "\r\n" + "\r\n" +
                    "Descrição : " + ex.Message.ToString() + "\r\n" +
                    "Origem : " + ex.Source.ToString();
                sErrCap = "Procedimento : " + ex.TargetSite.ToString();
                MessageBox.Show(sErrMsg, sErrCap, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                da.Dispose();
                cmd.Dispose();
                ds.Dispose();
                return null;

            }
        }//fim LoadLists

    }
}
