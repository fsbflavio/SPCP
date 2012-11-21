using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using Oracle.DataAccess.Client;

namespace SPCP.Model
{
    public class FichaProduto
    {
        private static string strErrMsg;

        public int Id;
        public ItemEstoque itemEstoque;
        public Produto produto;
        public int Qtd;
        public string Observacao;

        public FichaProduto()
        {
            this.Id = 0;
            this.itemEstoque = new ItemEstoque();
            this.produto = new Produto();
            this.Qtd = 0;
            this.Observacao = string.Empty;
        }

        public static ArrayList GetFichaProduto(int id) //isso deverria ser um objeto so ao invez de um array?
        {
            FichaProduto ficha;
            ArrayList dt = new ArrayList();
            OracleDataReader dr;
            OracleConnection conn = Conexao.GetInstance();

            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "SELECT * " +
                                    "FROM FICHA_PRODUTO " +
                                    "WHERE (ID_PRODUTO = :Id) ";

                cmd.Parameters.Add(":Id", OracleDbType.Int32).Value = id;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ficha = new FichaProduto();
                    ficha.Id = Convert.ToInt32(dr["ID"]);
                    ficha.itemEstoque = ItemEstoque.GetItemEstoque(Convert.ToInt32(dr["ID_ITEM"]));
                    ficha.produto = Produto.GetProduto(Convert.ToInt32(dr["ID_PRODUTO"]));
                    ficha.Qtd = Convert.ToInt32(dr[3]);

                    if (dr[4] != DBNull.Value)
                    {
                        ficha.Observacao = dr.GetString(4);
                    }

                    dt.Add(ficha);
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
                                "VALUES (SQ_ID_FICHA_PRODUTO.NEXTVAL, :IdItem, :IdProduto, :Qtd, :Observacoes)";

                cmd.Parameters.Add(":IdItem", OracleDbType.Int32).Value = this.itemEstoque.Id;
                cmd.Parameters.Add(":IdProduto", OracleDbType.Int32).Value = this.produto.Id;
                cmd.Parameters.Add(":Qtd", OracleDbType.Int32).Value = this.Qtd;
                cmd.Parameters.Add(":Observacoes", OracleDbType.Varchar2, 100).Value = this.Observacao;

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

        public bool Incluir2()
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
                                "VALUES (SQ_ID_FICHA_PRODUTO.NEXTVAL, :IdItem, SQ_ID_PRODUTO.CURRVAL, :Qtd, :Observacoes)";

                cmd.Parameters.Add(":IdItem", OracleDbType.Int32).Value = this.itemEstoque.Id;
                cmd.Parameters.Add(":Qtd", OracleDbType.Int32).Value = this.Qtd;
                cmd.Parameters.Add(":Observacoes", OracleDbType.Varchar2, 100).Value = this.Observacao;

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

        public bool Alterar(int id)
        {
            OracleConnection conn = Conexao.GetInstance();
            OracleCommand cmd = new OracleCommand();

            try
            {
                cmd.CommandText = "UPDATE FICHA_PRODUTO SET " +
                                "ID_ITEM = :IdItem, " +
                                "ID_PRODUTO = :IdProduto, " +
                                "QTD = :Qtd, " +
                                "OBSERVACOES = :Observacoes " +
                                "WHERE ID = :Id";

                cmd.Parameters.Add(":IdItem", OracleDbType.Int32).Value = this.itemEstoque.Id;
                cmd.Parameters.Add(":IdProduto", OracleDbType.Int32).Value = this.produto.Id;
                cmd.Parameters.Add(":Qtd", OracleDbType.Int32).Value = this.Qtd;
                cmd.Parameters.Add(":Observacoes", OracleDbType.Varchar2, 100).Value = this.Observacao;
                cmd.Parameters.Add(":Id", OracleDbType.Int32).Value = id;

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

        public bool Excluir(int Id)
        {
            OracleConnection conn = Conexao.GetInstance();
            OracleCommand cmd = new OracleCommand();
            try
            {
                cmd.CommandText = "DELETE FROM FICHA_PRODUTO WHERE ID = :Id";

                cmd.Parameters.Add(":Id", OracleDbType.Int32).Value = Id;
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
    }
}
