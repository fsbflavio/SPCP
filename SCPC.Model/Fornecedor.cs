using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;
using System.Data;
using System.Windows.Forms;

namespace SPCP.Model
{
    public class Fornecedor : Pessoa
    {
        string strErrMsg; // mensagens de erro

        public bool Incluir()
        {
            OracleConnection conn = Conexao.GetInstance();
            try
            {
                conn.Open();

                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "INSERT INTO TBL_FORNECEDOR (" +
                                "ID_FORNECEDOR, " +
                                "NOME_FORNECEDOR, " +
                                "CNPJ_FORNECEDOR, " +
                                "RUA_FORNECEDOR, " +
                                "NUM_FORNECEDOR, " +
                                "BAIRRO_FORNECEDOR, " +
                                "COMPL_FORNECEDOR, " +
                                "CEP_FORNECEDOR, " +
                                "CIDADE_FORNECEDOR, " +
                                "UF_FORNECEDOR, " +
                                "ST_FORNECEDOR, " +
                                "TEL_FORNECEDOR, " +
                                "TELCEL_FORNECEDOR, " +
                                "EMAIL_FORNECEDOR) " +
                                "VALUES (SQ_ID_FORNECEDOR.NEXTVAL, :Nome, :Cnpj, :Rua, :NumRua, :Bairro, :Complemento, :Cep, :Cidade, :Uf, :Situacao, :Telefone, :Celular, :Email)";

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

        public void Alterar(int Id, string nome, string cnpj, string rua, string numRua, string bairro, string complemento,
            string cidade, string cep, string celular, string telefone, string uf, string situacao, string email)
        {
            OracleConnection conn = Conexao.GetInstance();
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "UPDATE TBL_FORNECEDOR SET " +
                            "NOME_FORNECEDOR = :Nome, " +
                            "CNPJ_FORNECEDOR = :Cnpj, " +
                            "RUA_FORNECEDOR = :Rua, " +
                            "NUM_FORNECEDOR = :NumRua, " +
                            "BAIRRO_FORNECEDOR =  :Bairro, " +
                            "COMPL_FORNECEDOR = :Complemento, " +
                            "CEP_FORNECEDOR = :Cep, " +
                            "CIDADE_FORNECEDOR = :Cidade, " +
                            "UF_FORNECEDOR = :Uf, " +
                            "ST_FORNECEDOR = :Situacao, " +
                            "TEL_FORNECEDOR = :Telefone, " +
                            "TELCEL_FORNECEDOR = :Celular, " +
                            "EMAIL_FORNECEDOR = :Email " +
                            "WHERE ID_FORNECEDOR = :Id";

            cmd.Parameters.Add(":Nome", OracleDbType.Varchar2, 100).Value = nome;
            cmd.Parameters.Add(":Cnpj", OracleDbType.Varchar2, 20).Value = cnpj;
            cmd.Parameters.Add(":Rua", OracleDbType.Varchar2, 100).Value = rua;
            cmd.Parameters.Add(":NumRua", OracleDbType.Varchar2, 10).Value = numRua;
            cmd.Parameters.Add(":Bairro", OracleDbType.Varchar2, 50).Value = bairro;
            cmd.Parameters.Add(":Complemento", OracleDbType.Varchar2, 50).Value = complemento;
            cmd.Parameters.Add(":Cep", OracleDbType.Varchar2, 10).Value = cep;
            cmd.Parameters.Add(":Cidade", OracleDbType.Varchar2, 50).Value = cidade;
            cmd.Parameters.Add(":Uf", OracleDbType.Varchar2, 2).Value = uf;
            cmd.Parameters.Add(":Situacao", OracleDbType.Varchar2, 20).Value = situacao;
            cmd.Parameters.Add(":Telefone", OracleDbType.Varchar2, 20).Value = telefone;
            cmd.Parameters.Add(":Celular", OracleDbType.Varchar2, 20).Value = celular;
            cmd.Parameters.Add(":Email", OracleDbType.Varchar2, 100).Value = email;
            cmd.Parameters.Add(":Id", OracleDbType.Int32).Value = Id;

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
                cmd.CommandText = "DELETE FROM TBL_FORNECEDOR WHERE ID_FORNECEDOR = :Id";

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
            cmd.CommandText = "SELECT * FROM TBL_FORNECEDOR WHERE ID_FORNECEDOR = :Id";
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
            cmd.CommandText = "SELECT ID_FORNECEDOR, NOME_FORNECEDOR, CNPJ_FORNECEDOR, TEL_FORNECEDOR, CIDADE_FORNECEDOR FROM TBL_FORNECEDOR WHERE NOME_FORNECEDOR LIKE :Nome ORDER BY NOME_FORNECEDOR";
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
