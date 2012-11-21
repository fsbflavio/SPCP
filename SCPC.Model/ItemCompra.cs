using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace SPCP.Model
{
    public class ItemCompra
    {
        public static string strErrMsg;

        public int Id;
        public ItemEstoque ItemDeEstoque;
        public float ICMS;
        public float IPI;
        public int Qtd;
        public float ValorUnitario;
        public string Observacao;
        public Compras Compra;

        public ItemCompra()
        {
            this.ItemDeEstoque = new ItemEstoque();
            this.Compra = new Compras();
        }

        public bool Incluir()
        {
            OracleConnection conn = Conexao.GetInstance();
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "INSERT INTO FICHA_DE_COMPRA_ITEM (" +
                                "ID, " +
                                "ID_ITEM, " +
                                "ICMS, " +
                                "IPI, " +
                                "QTD, " +
                                "UNIT, " +
                                "OBS, " +
                                "ID_FICHA_DE_COMPRA) " +
                                "VALUES (SQ_ID_FICHA_DE_COMPRA_ITEM.NEXTVAL, :Id_Item, :ICMS, :IPI, :Qtd, :Unit, :Obs, :IdCompra)";

                cmd.Parameters.Add(":Id_Item", OracleDbType.Int32).Value = this.ItemDeEstoque.Id;
                cmd.Parameters.Add(":ICMS", OracleDbType.Double).Value = this.ICMS;
                cmd.Parameters.Add(":IPI", OracleDbType.Double).Value = this.IPI;
                cmd.Parameters.Add(":Qtd", OracleDbType.Int32).Value = this.Qtd;
                cmd.Parameters.Add(":Unit", OracleDbType.Int32).Value = this.ValorUnitario;
                cmd.Parameters.Add(":Obs", OracleDbType.Varchar2).Value = this.Observacao;
                cmd.Parameters.Add(":IdCompra", OracleDbType.Int32).Value = this.Compra.Id;


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

        public void Alterar()
        {
            OracleConnection conn = Conexao.GetInstance();

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "UPDATE FICHA_DE_COMPRA_ITEM SET " +
                            "ID_ITEM = :IdItem, " +
                            "ICMS = :ICMS, " +
                            "IPI = :IPI, " +
                            "QTD = :Qtd, " +
                            "UNIT = :Unit, " +
                            "OBS = :Obs " +
                            "WHERE ID = :Id";

            cmd.Parameters.Add(":IdItem", OracleDbType.Int32).Value = this.ItemDeEstoque.Id;
            cmd.Parameters.Add(":ICMS", OracleDbType.Decimal).Value = this.ICMS;
            cmd.Parameters.Add(":IPI", OracleDbType.Decimal).Value = this.IPI;
            cmd.Parameters.Add(":Qtd", OracleDbType.Int32).Value = this.Qtd;
            cmd.Parameters.Add(":Unit", OracleDbType.Int32).Value = this.ValorUnitario;
            cmd.Parameters.Add(":Obs", OracleDbType.Varchar2, 100).Value = this.Observacao;

            cmd.Parameters.Add(":Id", OracleDbType.Int32).Value = this.Id;

            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
            return;
        }

        public static LinkedList<ItemCompra> GetItensCompra(int id_ficha_compra)
        {
            OracleDataReader dr;
            LinkedList<ItemCompra> array = new LinkedList<ItemCompra>();
            OracleConnection conn = Conexao.GetInstance();

            OracleCommand cmd = new OracleCommand();
            try
            {
                cmd.CommandText = "SELECT * FROM FICHA_DE_COMPRA_ITEM " +
                                    "WHERE ID_FICHA_DE_COMPRA = :Id";

                cmd.Parameters.Add(":Id", OracleDbType.Int32).Value = id_ficha_compra;

                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                dr = cmd.ExecuteReader();

                ItemCompra Itemcompra;
                while (dr.Read())
                {
                    Itemcompra = new ItemCompra();
                    Itemcompra.Id = Convert.ToInt32(dr["ID"]);
                    Itemcompra.ItemDeEstoque.Id = Convert.ToInt32(dr["ID_ITEM"]);
                    if (dr["ICMS"] != DBNull.Value)
                        Itemcompra.ICMS = (float) dr.GetDecimal(2);
                    if (dr["IPI"] != DBNull.Value)
                        Itemcompra.IPI = (float)dr.GetDecimal(3);
                    if (dr["QTD"] != DBNull.Value)
                        Itemcompra.Qtd = Convert.ToInt32(dr.GetDecimal(4)); // arrumar no banco

                    Itemcompra.ValorUnitario = Convert.ToInt32(dr[5]);
                    if (dr["OBS"] != DBNull.Value)
                        Itemcompra.Observacao = dr.GetString(6);
                    Itemcompra.Compra.Id = Convert.ToInt32(dr[7]);

                    array.AddLast(Itemcompra);
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
               // conn.Close();
            }

            return array;
        }

    }
}
