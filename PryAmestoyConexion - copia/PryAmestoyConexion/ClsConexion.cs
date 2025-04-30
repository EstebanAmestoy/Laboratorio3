using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace PryAmestoyConexion
{
    internal class ClsConexion
    {
        SqlConnection conn;

        public SqlConnection Conexion()
        {
            try
            {
                conn = new SqlConnection("Data Source=DESKTOP-GUR9QFC;Initial Catalog=Comercio;Integrated Security=True;Encrypt=False");
                conn.Open();
               
                if (conn.State != ConnectionState.Open)
                {
                    MessageBox.Show(" no conectado");
                   
                }
           

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            return conn;
        }
    }
}
