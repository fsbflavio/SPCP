using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Oracle.DataAccess.Client;

namespace SPCP.Model
{
    public class Cliente : Pessoa
    {
        public void Incluir()
        {
            OracleConnection conn = Conexao.GetInstance();
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "INSERT INTO TBL_CLIENTE (" +
                            "ID_CLIENTE, " +
                            "NOME_CLIENTE, " +
                            "CNPJ_CLIENTE, " +
                            "RUA_CLIENTE, " +
                            "NUM_CLIENTE, " +
                            "BAIRRO_CLIENTE, " +
                            "COMPL_CLIENTE, " +
                            "CEP_CLIENTE, " +
                            "CIDADE_CLIENTE, " +
                            "UF_CLIENTE, " +
                            "ST_CLIENTE, " +
                            "TEL_CLIENTE, " +
                            "TELCEL_CLIENTE, " +
                            "EMAIL_CLIENTE) " +
                            "VALUES (SQ_ID_CLIENTE.NEXTVAL, :Nome, :Cnpj, :Rua, :NumRua, :Bairro, :Complemento, :Cep, :Cidade, :Uf, :Situacao, :Telefone, :Celular, :Email)";

            cmd.Parameters.Add(":Nome", OracleDbType.Varchar2, 100).Value = this.Nome;
            cmd.Parameters.Add(":Cnpj", OracleDbType.Varchar2, 20).Value = this.Cnpj;
            cmd.Parameters.Add(":Rua", OracleDbType.Varchar2, 100).Value = this.Rua;
            cmd.Parameters.Add(":NumRua", OracleDbType.Varchar2, 10).Value = this.NumRua;
            cmd.Parameters.Add(":Bairro", OracleDbType.Varchar2, 50).Value = this.Bairro;
            cmd.Parameters.Add(":Complemento", OracleDbType.Varchar2, 50).Value = this.Complemento;
            cmd.Parameters.Add(":Cep", OracleDbType.Varchar2, 10).Value = this.Cep;
            cmd.Parameters.Add(":Cidade", OracleDbType.Varchar2, 50).Value = this.Cidade;
            cmd.Parameters.Add(":Uf", OracleDbType.Varchar2, 2).Value = this.Uf;
            cmd.Parameters.Add(":Situacao", OracleDbType.Varchar2, 20).Value = this.Situacao;
            cmd.Parameters.Add(":Telefone", OracleDbType.Varchar2, 20).Value = this.Telefone;
            cmd.Parameters.Add(":Celular", OracleDbType.Varchar2, 20).Value = this.Celular;
            cmd.Parameters.Add(":Email", OracleDbType.Varchar2, 100).Value = this.Email;

            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
            return;
        }

        public void Alterar()
        {
            OracleConnection conn = Conexao.GetInstance();
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "UPDATE TBL_CLIENTE SET " +
                            "NOME_CLIENTE = :Nome, " +
                            "CNPJ_CLIENTE = :Cnpj, " +
                            "RUA_CLIENTE = :Rua, " +
                            "NUM_CLIENTE = :NumRua, " +
                            "BAIRRO_CLIENTE =  :Bairro, " +
                            "COMPL_CLIENTE = :Complemento, " +
                            "CEP_CLIENTE = :Cep, " +
                            "CIDADE_CLIENTE = :Cidade, " +
                            "UF_CLIENTE = :Uf, " +
                            "ST_CLIENTE = :Situacao, " +
                            "TEL_CLIENTE = :Telefone, " +
                            "TELCEL_CLIENTE = :Celular, " +
                            "EMAIL_CLIENTE = :Email " +
                            "WHERE ID_CLIENTE = :Id";

            cmd.Parameters.Add(":Nome", OracleDbType.Varchar2, 100).Value = this.Nome;
            cmd.Parameters.Add(":Cnpj", OracleDbType.Varchar2, 20).Value = this.Cnpj;
            cmd.Parameters.Add(":Rua", OracleDbType.Varchar2, 100).Value = this.Rua;
            cmd.Parameters.Add(":NumRua", OracleDbType.Varchar2, 10).Value = this.NumRua;
            cmd.Parameters.Add(":Bairro", OracleDbType.Varchar2, 50).Value = this.Bairro;
            cmd.Parameters.Add(":Complemento", OracleDbType.Varchar2, 50).Value = this.Complemento;
            cmd.Parameters.Add(":Cep", OracleDbType.Varchar2, 10).Value = this.Cep;
            cmd.Parameters.Add(":Cidade", OracleDbType.Varchar2, 50).Value = this.Cidade;
            cmd.Parameters.Add(":Uf", OracleDbType.Varchar2, 2).Value = this.Uf;
            cmd.Parameters.Add(":Situacao", OracleDbType.Varchar2, 20).Value = this.Situacao;
            cmd.Parameters.Add(":Telefone", OracleDbType.Varchar2, 20).Value = this.Telefone;
            cmd.Parameters.Add(":Celular", OracleDbType.Varchar2, 20).Value = this.Celular;
            cmd.Parameters.Add(":Email", OracleDbType.Varchar2, 100).Value = this.Email;
            cmd.Parameters.Add(":Id", OracleDbType.Int32).Value = this.Id;

            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
            return;
        }

        public bool Excluir(int Id)
        {
            OracleConnection conn = Conexao.GetInstance();
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "DELETE FROM TBL_CLIENTE WHERE ID_CLIENTE = :Id";

            cmd.Parameters.Add(":Id", OracleDbType.Int32).Value = Id;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
            return true;
        }

        public DataTable CarregarDadosCliente(int id)
        {
            DataTable dt = new DataTable();
            OracleDataReader dr;

            OracleConnection conn = Conexao.GetInstance();
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "SELECT * FROM TBL_CLIENTE WHERE ID_CLIENTE = :Id";
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

        public DataTable Pesquisar(string Nome)
        {
            DataTable dt = new DataTable();
            OracleConnection conn = Conexao.GetInstance();

            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "SELECT ID_CLIENTE, NOME_CLIENTE, CNPJ_CLIENTE, TEL_CLIENTE, CIDADE_CLIENTE FROM TBL_CLIENTE WHERE NOME_CLIENTE LIKE :Nome ORDER BY NOME_CLIENTE";
            cmd.Parameters.Add(":Nome", OracleDbType.Varchar2).Value = Nome + "%";
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
