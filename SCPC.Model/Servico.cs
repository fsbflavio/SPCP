using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using Oracle.DataAccess.Client;

namespace SPCP.Model
{
    public class Servico
    {
        public int Id {get; set;}
        public string Descricao {get; set;}

        public static ArrayList GetServicos()
        {
            OracleDataReader dr;
            OracleConnection conn = Conexao.GetInstance();

            ArrayList array = new ArrayList();

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "SELECT * FROM SERVICO ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            dr = cmd.ExecuteReader();

            Servico p;
            while (dr.Read())
            {
                try
                {
                    p = new Servico();
                    p.Id = Convert.ToInt32(dr["ID"]);
                    p.Descricao = dr.GetString(1);
                    array.Add(p);
                }
                catch (Exception)
                {

                }
            }

            conn.Close();

            return array;
        }
    }
}
