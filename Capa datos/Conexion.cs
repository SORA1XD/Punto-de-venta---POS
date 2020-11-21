using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Capa_datos
{
    class Conexion
    {
        public static MySqlConnection Conection()
        {
            try
            {
                MySqlConnection cnn = new MySqlConnection("server=162.241.62.3;user id=progbysc_manuel; pwd=manuxo1234; persistsecurityinfo=True;database=progbysc_POS_Ventas");
                return cnn;
            }catch(MySqlException ex)
            {
                Console.WriteLine("error; " + ex.Message);
                MessageBox.Show("ocurrio un error al conectar a la base de datos");
                return null;
            }
        }
    }
}
