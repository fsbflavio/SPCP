using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;
using System.Windows.Forms; //Para as mensagens

namespace SPCP.Model
{
    public static class Conexao
    {
        private static OracleConnection pConnection;

        public static OracleConnection GetInstance() 
        {
            try
            {
                if (pConnection == null)
                {
                    pConnection = new OracleConnection();
                    pConnection.ConnectionString = "Data Source=SPCP;Persist Security Info=True;User ID=SPCP;Password=SPCP#XYFJL127TT4MCINLUK;";
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(String.Format("Falha na Conexão: {0}", ex.Message));
            }
            return pConnection;
        }
    }
}
