using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;                   //es agregado para poder crear las consultas a la base de datos mysql
using System.Data;                              //es agregado para usar en las consultas


namespace Capa_datos
{
    public class CD_Productos // se agrega el "public" para poder hacerse uso de las otras capas
    {
        private CD_Conexion cnn = new CD_Conexion();

        MySqlDataReader read;
        DataTable table = new DataTable();
        MySqlCommand cmd = new MySqlCommand();

        public DataTable ShowT()
        {
            //Transact SQL
            cmd.Connection = cnn.AbrirConexion();
            cmd.CommandText = "SELECT * FROM Productos";
            read = cmd.ExecuteReader();
            table.Load(read);
            cnn.CerrarConexion();
            return table;

                //Procedimientos 
        }


    }
}
