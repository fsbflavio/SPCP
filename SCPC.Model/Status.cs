using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;
using Oracle.DataAccess.Client;

namespace SPCP.Model
{
    public class Status
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public static ArrayList GetServicos()
        {
            OracleDataReader dr;
            OracleConnection conn = Conexao.GetInstance();

            ArrayList array = new ArrayList();

            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "SELECT * FROM STATUS_COMPRA ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            dr = cmd.ExecuteReader();

            Status p;
            while (dr.Read())
            {
                try
                {
                    p = new Status();
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
