using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Oracle.DataAccess.Client;
using System.Windows.Forms;

namespace SPCP.Model
{
    public class teste
    {
        public static string strErrMsg;

        public static DataTable GetItensCompra(int id_ficha_compra)
        {
            DataTable dt = new DataTable();
            OracleDataAdapter da = new OracleDataAdapter();

            OracleConnection conn = Conexao.GetInstance();

            OracleCommand cmd = new OracleCommand();
            try
            {
                cmd.CommandText = "SELECT * FROM FICHA_DE_COMPRA_ITEM " +
                                    "WHERE ID_FICHA_DE_COMPRA = :Id";

                cmd.Parameters.Add(":Id", OracleDbType.Int32).Value = id_ficha_compra;

                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                da.SelectCommand = cmd;
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                strErrMsg = "Atenção, o sistema detectou o seguinte problema: " + "\r\n" +
                    "Descrição: " + Convert.ToString(ex.Message) + "\r\n" +
                    "Origem: " + Convert.ToString(ex.Source);
                MessageBox.Show(strErrMsg, "Procedimento: " + Convert.ToString(ex.TargetSite),
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static DataTable GetItensEstoque()
        {
            DataTable dt = new DataTable();
            OracleDataAdapter da = new OracleDataAdapter();

            OracleConnection conn = Conexao.GetInstance();

            OracleCommand cmd = new OracleCommand();
            try
            {
                cmd.CommandText = "SELECT * FROM ITEM_ESTOQUE ";


                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                da.SelectCommand = cmd;
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                strErrMsg = "Atenção, o sistema detectou o seguinte problema: " + "\r\n" +
                    "Descrição: " + Convert.ToString(ex.Message) + "\r\n" +
                    "Origem: " + Convert.ToString(ex.Source);
                MessageBox.Show(strErrMsg, "Procedimento: " + Convert.ToString(ex.TargetSite),
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
