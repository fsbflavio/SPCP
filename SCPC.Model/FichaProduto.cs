using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace SPCP.Model
{
    public class FichaProduto
    {
        private string strErrMsg;

        public int Id;
        public int IdItemEstoque;
        public int IdProduto;
        public int Qtd;
        public string Observacao;

        public DataTable CarregaGrid(int id)
        {
            DataTable dt = new DataTable();
            OracleConnection conn = Conexao.GetInstance();

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "SELECT A.ID, A.ID_ITEM, A.ID_PRODUTO, B.DESCRICAO, B.UNIDADE_MEDIDA, A.QTD, A.OBSERVACOES " +
                                "FROM FICHA_PRODUTO A, ITEM_ESTOQUE B " +
                                "WHERE (A.ID_ITEM = B.ID_ITEM) AND (A.ID_PRODUTO = :Id) ";

            cmd.Parameters.Add(":Id", OracleDbType.Int32).Value = id;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            conn.Close();

            return dt;
        }

        public bool Incluir()
        {
            OracleConnection conn = Conexao.GetInstance();
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "INSERT INTO FICHA_PRODUTO (" +
                                "ID, " +
                                "ID_ITEM, " +
                                "ID_PRODUTO, " +
                                "QTD, " +
                                "OBSERVACOES) " +
                                "VALUES (SQ_ID_PRODUTO.NEXTVAL, :IdItem, :IdProduto, :Qtd, :Observacoes)";

                cmd.Parameters.Add(":IdItem", OracleDbType.Int32).Value = this.IdItemEstoque;
                cmd.Parameters.Add(":IdProduto", OracleDbType.Int32).Value = this.IdProduto;
                cmd.Parameters.Add(":Qtd", OracleDbType.Int32).Value = this.Qtd;
                cmd.Parameters.Add(":Observacoes", OracleDbType.Varchar2, 100).Value = this.Observacao;

                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (OracleException ex)
            {
                strErrMsg = "Atenção, o sistema detectou o seguinte problema: " + "\r\n" +
                    "Descrição: " + Convert.ToString(ex.Message) + "\r\n" +
                    "Origem: " + Convert.ToString(ex.Source);
                MessageBox.Show(strErrMsg, "Procedimento: " + Convert.ToString(ex.TargetSite),
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return false;
            }
        }
    }
}
