using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace Capa_datos
{
    class CD_Conexion
    {
        /*public static MySqlConnection Conectionsql()
        {
            try
            {
                MySqlConnection cnn = new MySqlConnection("server=162.241.62.3;user id=progbysc_manuel;pwd=Manuxo1234;persistsecurityinfo=True;database=progbysc_POS_Ventas");
                //MessageBox.Show(string.Format("se pudo conextar a la base de datos correctamente"));
                return cnn;

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("error; " + ex.Message);
                MessageBox.Show("ocurrio un error al conectar a la base de datos");
                return null;

            }
        }*/

        private MySqlConnection Conexion = new MySqlConnection("server=162.241.62.3;user id=progbysc_manuel;pwd=Manuxo1234;persistsecurityinfo=True;database=progbysc_POS_Ventas");

        public MySqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        public MySqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
