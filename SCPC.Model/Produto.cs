using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;
using System.Data;
using System.Windows.Forms;
using System.Collections;

namespace SPCP.Model
{
    public class Produto
    {
        private string strErrMsg;
        
        public int Id {get; set;}
        public int Codigo;
        public string Descricao {get; set;}

        public bool Incluir()
        {
            OracleConnection conn = Conexao.GetInstance();
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "INSERT INTO PRODUTO (" +
                                "ID, " +
                                "CODIGO, " +
                                "DESCRICAO) " +
                                "VALUES (SQ_ID_PRODUTO.NEXTVAL, :Codigo, :Descricao)";

                cmd.Parameters.Add(":Codigo", OracleDbType.Int32).Value = this.Codigo;
                cmd.Parameters.Add(":Descricao", OracleDbType.Varchar2, 100).Value = this.Descricao;

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

        public ArrayList GetProdutos()
        {
            OracleDataReader dr;
            OracleConnection conn = Conexao.GetInstance();

            ArrayList array = new ArrayList();

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "SELECT * FROM PRODUTO ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            dr = cmd.ExecuteReader();

            Produto p;
            while (dr.Read())
            {
                try
                {
                    p = new Produto();
                    p.Id = Convert.ToInt32(dr["ID"]);
                    p.Codigo = Convert.ToInt32(dr["CODIGO"]);
                    p.Descricao = dr.GetString(2);
                    array.Add(p);
                }
                catch (Exception)
                {

                }
            }

            conn.Close();

            return array;
        }


        public static Produto GetProduto(int id)
        {
            OracleDataReader dr;
            Produto p = new Produto();
            OracleConnection conn = Conexao.GetInstance();

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "SELECT * FROM PRODUTO WHERE ID = :Id";
            cmd.Parameters.Add(":Id", OracleDbType.Int32).Value = id;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                try
                {
                    p.Id = Convert.ToInt32(dr["ID"]);
                    p.Codigo = Convert.ToInt32(dr["CODIGO"]);
                    p.Descricao = dr.GetString(2);
                }
                catch (Exception )
                {

                }
            }

            conn.Close();

            return p;
        }

        public override string ToString()
        {
            return this.Descricao;
        }



    }
}
