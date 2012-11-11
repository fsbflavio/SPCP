using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Oracle.DataAccess.Client;
using SPCP.Util;

namespace SPCP.Model
{
    public class GrupoItemEstoque
    {
        public int Id;
        public String Descricao;

        public GrupoItemEstoque(String Descricao)
        {
            this.Descricao = Descricao;
        }

        public GrupoItemEstoque(int id, String Descricao)
        {
            this.Id = id;
            this.Descricao = Descricao;
        }

        public GrupoItemEstoque()
        {
        }

        public void incluir()
        {
            OracleConnection conn = Conexao.GetInstance();
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "INSERT INTO GRUPO_ITEM_ESTOQUE (" +
                            "ID, " +
                            "DESCRICAO) " +
                            "VALUES (SQ_ID_GRUPO_ITEM_ESTOQUE.NEXTVAL, :Descricao)";

            cmd.Parameters.Add(":Descricao", OracleDbType.Varchar2, 100).Value = this.Descricao;

            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
            return;
        }


        public void excluir(int id)
        {
            OracleConnection conn = Conexao.GetInstance();
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "DELETE FROM GRUPO_ITEM_ESTOQUE WHERE ID = :Id";

            cmd.Parameters.Add(":Id", OracleDbType.Int32).Value = Id;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            conn.Close();
            return;
        }

        public void alterar(int id)
        {
            OracleConnection conn = Conexao.GetInstance();
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "UPDATE GRUPO_ITEM_ESTOQUE SET " +
                            "DESCRICAO = :Descricao, " +
                            "WHERE ID_ITEM = :Id";

            cmd.Parameters.Add(":Descricao", OracleDbType.Varchar2, 100).Value = this.Descricao;
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
            cmd.CommandText = "SELECT ID, DESCRICAO FROM GRUPO_ITEM_ESTOQUE WHERE DESCRICAO LIKE :Descricao ORDER BY DESCRICAO";
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
            cmd.CommandText = "SELECT * FROM GRUPO_ITEM_ESTOQUE WHERE ID_ITEM = :Id";
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

        public static GrupoItemEstoque FindById(int id)
        {
            OracleConnection connection = Conexao.GetInstance();
            OracleDataReader dr;

            OracleCommand command = new OracleCommand();
            command.CommandText = "SELECT * FROM GRUPO_ITEM_ESTOQUE WHERE ID = :Id";
            command.Parameters.Add(":Id", OracleDbType.Int32).Value = id;

            command.CommandType = CommandType.Text;
            command.Connection = connection;
            dr = command.ExecuteReader();

            GrupoItemEstoque grupo = new GrupoItemEstoque();
            dr.Read();
            grupo.Id = Convert.ToInt32(dr["ID"]);
            grupo.Descricao = dr.GetString(1);

            return grupo;
        }

    }
}