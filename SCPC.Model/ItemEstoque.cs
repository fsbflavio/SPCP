using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Oracle.DataAccess.Client;
using System.Collections;
using SPCP.Util;

namespace SPCP.Model
{
    public class ItemEstoque
    {
        public int Id {get; set; }
        public String Descricao {get; set;}
        public int EstoqueMinimo;
        public UnidadeMedida UnidadeMedida;
        public GrupoItemEstoque GrupoItemEstoque;
                     
        public void incluir()
        {
            OracleConnection conn = Conexao.GetInstance();
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "INSERT INTO ITEM_ESTOQUE (" +
                            "ID_ITEM, " +
                            "DESCRICAO, " +
                            "UNIDADE_MEDIDA, " +
                            "ESTOQUE_MINIMO, " +
                            "ID_GRUPO) " +
                            "VALUES (SQ_ID_ITEM_ESTOQUE.NEXTVAL, :Descricao, :UnidadeMedida, :EstoqueMinimo, :Grupo)";

            cmd.Parameters.Add(":Descricao", OracleDbType.Varchar2, 100).Value = this.Descricao;
            cmd.Parameters.Add(":UnidadeMedida", OracleDbType.Varchar2, 10).Value = this.UnidadeMedida;
            cmd.Parameters.Add(":EstoqueMinimo", OracleDbType.Int32).Value = this.EstoqueMinimo;
            cmd.Parameters.Add(":Grupo", OracleDbType.Varchar2, 100).Value = this.GrupoItemEstoque.Id;
            
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
            return;
        }


        public bool excluir(int id)
        {
            OracleConnection conn = Conexao.GetInstance();
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "DELETE FROM ITEM_ESTOQUE WHERE ID = :Id";

            cmd.Parameters.Add(":Id", OracleDbType.Int32).Value = Id;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            conn.Close();
            return true;
        }

        public void alterar(int id)
        {
            OracleConnection conn = Conexao.GetInstance();
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "UPDATE ITEM_ESTOQUE SET " +
                            "DESCRICAO = :Descricao, " +
                            "UNIDADE_MEDIDA = :UnidadeMedida, " +
                            "ESTOQUE_MINIMO = :EstoqueMinimo, " +
                            "ID_GRUPO = :Grupo, " +
                            "WHERE ID_ITEM = :Id";

            cmd.Parameters.Add(":Descricao", OracleDbType.Varchar2, 100).Value = this.Descricao;
            cmd.Parameters.Add(":UnidadeMedida", OracleDbType.Varchar2, 1).Value = this.UnidadeMedida;
            cmd.Parameters.Add(":EstoqueMinimo", OracleDbType.Int32).Value = this.EstoqueMinimo;
            cmd.Parameters.Add(":Grupo", OracleDbType.Varchar2, 100).Value = this.GrupoItemEstoque.Id;
            cmd.Parameters.Add(":Id", OracleDbType.Int32).Value = this.Id;

            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
            return;
        }


        public DataTable pesquisar(string Descricao)
        {
            DataTable dt = new DataTable();

            OracleConnection conn = Conexao.GetInstance();
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "SELECT ID_ITEM, DESCRICAO, UNIDADE_MEDIDA, ESTOQUE_MINIMO, ID_GRUPO FROM ITEM_ESTOQUE WHERE DESCRICAO LIKE :Descricao ORDER BY DESCRICAO";
            cmd.Parameters.Add(":Descricao", OracleDbType.Varchar2).Value = Descricao + "%";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            conn.Close();

            return dt;
        }

        public DataTable CarregarDadosItemEstoque(int id)
        {
            DataTable dt = new DataTable();
            OracleDataReader dr;

            OracleConnection conn = Conexao.GetInstance();
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "SELECT * FROM ITEM_ESTOQUE WHERE ID_ITEM = :Id";
            cmd.Parameters.Add(":Id", OracleDbType.Int32).Value = id;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            dr = cmd.ExecuteReader();

            dt.Load(dr);
            OracleDataAdapter da = new OracleDataAdapter();
            //da.SelectCommand = cmd;
            da.Fill(dt);
            conn.Close();

            return dt;
        }

        public ArrayList GetItensEstoque()
        {
            ItemEstoque item;
            ArrayList array = new ArrayList();

            OracleDataReader dr;
            OracleConnection conn = Conexao.GetInstance();
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "SELECT * FROM ITEM_ESTOQUE ";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    item = new ItemEstoque();

                    item.Id = Convert.ToInt32(dr["ID_ITEM"]);
                    item.Descricao = (string)dr["DESCRICAO"];
                    item.UnidadeMedida = (UnidadeMedida)Convert.ToInt32(dr["UNIDADE_MEDIDA"]);
                    item.EstoqueMinimo = (int)dr["ESTOQUE_MINIMO"];
                    item.GrupoItemEstoque = GrupoItemEstoque.FindById(Convert.ToInt32(dr["ID_GRUPO"]));

                    array.Add(item);
                }
            }
            catch (Exception e)
            {
 
            }

            return array;
        }

        public override string ToString()
        {
            return this.Descricao;
        }
    }
}
