using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace SPCP.Model
{
    public class Compras
    {
        private static string strErrMsg;

        public int Id;
        public string Codigo;
        public Fornecedor Fornecedor;
        public DateTime Data;
        public int Status;
        public string Observacoes;

        public LinkedList<ItemCompra> Item;

        public Compras()
        {
            this.Fornecedor = new Fornecedor();
            this.Item = new LinkedList<ItemCompra>();
        }

        public bool Incluir()
        {
            OracleConnection conn = Conexao.GetInstance();
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "INSERT INTO FICHA_DE_COMPRA (" +
                                "ID, " +
                                "ID_FORNECEDOR, " +
                                "DATA_PREVISAO, " +
                                "ID_STATUS, " +
                                "OBSERVACOES) " +
                                "VALUES (SQ_ID_FICHA_DE_COMPRA.NEXTVAL, :Id_Fornecedor, :Data_Previsao, :Id_Status, :Observacoes)";

                cmd.Parameters.Add(":Id_Forncedor", OracleDbType.Int32).Value = this.Fornecedor.Id;
                cmd.Parameters.Add(":Data_Previsao", OracleDbType.Date).Value = this.Data;
                cmd.Parameters.Add(":Id_Status", OracleDbType.Int32).Value = this.Status;
                cmd.Parameters.Add(":Observacoes", OracleDbType.Varchar2).Value = this.Observacoes;


                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();

                // cmd = new OracleCommand();

                cmd.CommandText = "INSERT INTO FICHA_DE_COMPRA_ITEM (" +
                                "ID, " +
                                "ID_ITEM, " +
                                "ICMS, " +
                                "IPI, " +
                                "QTD, " +
                                "UNIT, " +
                                "OBS, " +
                                "ID_FICHA_DE_COMPRA) " +
                                "VALUES (SQ_ID_FICHA_DE_COMPRA_ITEM.NEXTVAL, :Id_Item, :ICMS, :IPI, :Qtd, :Unit, :Obs, SQ_ID_FICHA_DE_COMPRA.CURRVAL)";


                foreach (ItemCompra i in Item)
                {

                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(":Id_Item", OracleDbType.Int32).Value = i.ItemDeEstoque.Id;
                    cmd.Parameters.Add(":ICMS", OracleDbType.Double).Value = i.ICMS;
                    cmd.Parameters.Add(":IPI", OracleDbType.Double).Value = i.IPI;
                    cmd.Parameters.Add(":Qtd", OracleDbType.Int32).Value = i.Qtd;
                    cmd.Parameters.Add(":Unit", OracleDbType.Int32).Value = i.ValorUnitario;
                    cmd.Parameters.Add(":Obs", OracleDbType.Varchar2).Value = i.Observacao;

                    //cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                }

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
            cmd.CommandText = "UPDATE FICHA_DE_COMPRA SET " +
                            "ID_FORNECEDOR = :IdFornecedor, " +
                            "DATA_PREVISAO = :DataPrevisao, " +
                            "ID_STATUS = :IdStatus, " +
                            "OBSERVACOES = :Obs " +
                            "WHERE ID = :Id";

            cmd.Parameters.Add(":IdFornecedor", OracleDbType.Int32, 20).Value = this.Fornecedor.Id;
            cmd.Parameters.Add(":DataPrevisao", OracleDbType.Date, 100).Value = this.Data;
            cmd.Parameters.Add(":IdStatus", OracleDbType.Int32, 100).Value = this.Status;
            cmd.Parameters.Add(":Obs", OracleDbType.Varchar2, 100).Value = this.Observacoes;
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

        public static LinkedList<Compras> GetCompras()
        {
            OracleDataReader dr;
            LinkedList<Compras> array = new LinkedList<Compras>();
            OracleConnection conn = Conexao.GetInstance();

            OracleCommand cmd = new OracleCommand();
            try
            {
                cmd.CommandText = "SELECT * FROM FICHA_DE_COMPRA ";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                dr = cmd.ExecuteReader();

                Compras compras;
                while (dr.Read())
                {
                    compras = new Compras();
                    compras.Id = Convert.ToInt32(dr["ID"]);
                    compras.Data = Convert.ToDateTime(dr[2]);
                    compras.Status = Convert.ToInt32(dr["ID_STATUS"]);
                    
                    if (dr["OBSERVACOES"] != DBNull.Value)
                        compras.Observacoes = dr.GetString(4);

                    compras.Fornecedor = Fornecedor.GetFornecedor(Convert.ToInt32(dr["ID_FORNECEDOR"]));
                    compras.Item = ItemCompra.GetItensCompra(compras.Id);
                    array.AddLast(compras);
                }
                return array;
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


        public static Compras GetCompra(int id)
        {
            OracleDataReader dr;
            Compras compras = new Compras();
            OracleConnection conn = Conexao.GetInstance();

            OracleCommand cmd = new OracleCommand();
            try
            {
                cmd.CommandText = "SELECT * FROM FICHA_DE_COMPRA " +
                                    "WHERE ID = :Id";

                cmd.Parameters.Add(":Id", OracleDbType.Int32).Value = id;

                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    compras = new Compras();
                    compras.Id = Convert.ToInt32(dr["ID"]);
                    compras.Data = Convert.ToDateTime(dr[2]);
                    compras.Status = Convert.ToInt32(dr["ID_STATUS"]);

                    if (dr["OBSERVACOES"] != DBNull.Value)
                        compras.Observacoes = dr.GetString(4);

                    compras.Fornecedor = Fornecedor.GetFornecedor(Convert.ToInt32(dr["ID_FORNECEDOR"]));
                    compras.Item = ItemCompra.GetItensCompra(compras.Id);
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

            return compras;

        }
    }
}
