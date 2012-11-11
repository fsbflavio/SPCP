using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Oracle.DataAccess.Client;

namespace SPCP.Model
{
    public class FichaProduto
    {
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
    }
}
