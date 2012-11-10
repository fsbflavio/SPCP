using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;
using System.Data;
using System.Windows.Forms;

namespace SPCP.Model
{
    public class Produto
    {
        private string strErrMsg;
        public int Codigo;
        public string Descricao;

        public bool Incluir()
        {
            OracleConnection conn = Conexao.GetInstance();
            try
            {
                conn.Open();

                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "INSERT INTO PRODUTO (" +
                                "ID, " +
                                "CODIGO, " +
                                "DESCRICAO) " +
                                "VALUES (PRODUTO.NEXTVAL, :Codigo, :Descricao)";

                cmd.Parameters.Add(":Codigo", OracleDbType.Int32).Value = this.Codigo;
                cmd.Parameters.Add(":Descricao", OracleDbType.Varchar2, 20).Value = this.Descricao;

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

        public void Alterar(int id)
        {
            OracleConnection conn = Conexao.GetInstance();
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "UPDATE PRODUTO SET " +
                            "CODIGO = :Codigo, " +
                            "DESCRICAO = :Descricao " +
                            "WHERE ID = :Id";

            cmd.Parameters.Add(":Codigo", OracleDbType.Varchar2, 20).Value = this.Codigo;
            cmd.Parameters.Add(":Descricao", OracleDbType.Varchar2, 100).Value = this.Descricao;
            cmd.Parameters.Add(":Id", OracleDbType.Int32).Value = id;

            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
            return;
        }

        public bool Excluir(int Id)
        {
            OracleConnection conn = Conexao.GetInstance();
            try
            {
                conn.Open();

                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "DELETE FROM PRODUTO WHERE ID = :Id";

                cmd.Parameters.Add(":Id", OracleDbType.Int32).Value = Id;
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

        public DataTable CarregarDadosFornecedor(int id)
        {
            DataTable dt = new DataTable();
            OracleDataReader dr;

            OracleConnection conn = Conexao.GetInstance();
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "SELECT * FROM PRODUTO WHERE ID = :Id";
            cmd.Parameters.Add(":Id", OracleDbType.Int32).Value = id;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            dr = cmd.ExecuteReader();

            dt.Load(dr);

            //OracleDataAdapter da = new OracleDataAdapter();
            //da.SelectCommand = cmd;
            //da.Fill(dt);
            conn.Close();

            return dt;
        }

    }
}
