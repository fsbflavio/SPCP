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
        public static string strErrMsg;

        public int Id { get; set; }
        public int Codigo;
        public string Descricao { get; set; }

        public bool Incluir()
        {
            OracleConnection conn = Conexao.GetInstance();
            OracleCommand cmd = new OracleCommand();

            try
            {
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
            finally
            {
                conn.Close();
            }
        }

        public bool Alterar(int id)
        {
            OracleConnection conn = Conexao.GetInstance();
            OracleCommand cmd = new OracleCommand();
            try
            {
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
                return true;
            }
            catch (Exception ex)
            {
                strErrMsg = "Atenção, o sistema detectou o seguinte problema: " + "\r\n" +
                    "Descrição: " + Convert.ToString(ex.Message) + "\r\n" +
                    "Origem: " + Convert.ToString(ex.Source);
                MessageBox.Show(strErrMsg, "Procedimento: " + Convert.ToString(ex.TargetSite),
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool Excluir(int Id)
        {
            OracleConnection conn = Conexao.GetInstance();
            OracleCommand cmd = new OracleCommand();

            try
            {
                cmd.CommandText = "DELETE FROM PRODUTO WHERE ID = :Id";

                cmd.Parameters.Add(":Id", OracleDbType.Int32).Value = Id;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (OracleException ex)
            {
                strErrMsg = "Atenção, o sistema detectou o seguinte problema: " + "\r\n" +
                    "Descrição: " + Convert.ToString(ex.Message) + "\r\n" +
                    "Origem: " + Convert.ToString(ex.Source);
                MessageBox.Show(strErrMsg, "Procedimento: " + Convert.ToString(ex.TargetSite),
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public static ArrayList GetProdutos()
        {
            OracleDataReader dr;
            ArrayList array = new ArrayList();
            OracleConnection conn = Conexao.GetInstance();

            OracleCommand cmd = new OracleCommand();
            try
            {
                cmd.CommandText = "SELECT * FROM PRODUTO ";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                dr = cmd.ExecuteReader();

                Produto p;
                while (dr.Read())
                {
                    p = new Produto();
                    p.Id = Convert.ToInt32(dr["ID"]);
                    p.Codigo = Convert.ToInt32(dr["CODIGO"]);
                    p.Descricao = dr.GetString(2);
                    array.Add(p);
                }
            }
            catch (Exception ex)
            {
                strErrMsg = "Atenção, o sistema detectou o seguinte problema: " + "\r\n" +
                    "Descrição: " + Convert.ToString(ex.Message) + "\r\n" +
                    "Origem: " + Convert.ToString(ex.Source);
                MessageBox.Show(strErrMsg, "Procedimento: " + Convert.ToString(ex.TargetSite),
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return array;
        }


        public static Produto GetProduto(int id)
        {
            OracleDataReader dr;
            Produto p = new Produto();
            OracleConnection conn = Conexao.GetInstance();

            OracleCommand cmd = new OracleCommand();
            try
            {
                cmd.CommandText = "SELECT * FROM PRODUTO WHERE ID = :Id";
                cmd.Parameters.Add(":Id", OracleDbType.Int32).Value = id;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    p.Id = Convert.ToInt32(dr["ID"]);
                    p.Codigo = Convert.ToInt32(dr["CODIGO"]);
                    p.Descricao = dr.GetString(2);
                }
            }
            catch (Exception ex)
            {
                strErrMsg = "Atenção, o sistema detectou o seguinte problema: " + "\r\n" +
                    "Descrição: " + Convert.ToString(ex.Message) + "\r\n" +
                    "Origem: " + Convert.ToString(ex.Source);
                MessageBox.Show(strErrMsg, "Procedimento: " + Convert.ToString(ex.TargetSite),
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //conn.Close();
            }

            return p;
        }

        public override string ToString()
        {
            return this.Descricao;
        }

    }
}
