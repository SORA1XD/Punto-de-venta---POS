using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;                          //es agregado para usar en las consultas
using MySql.Data.MySqlClient;               //es agregado para poder crear las consultas a la base de datos mysql
using Capa_datos;                           //es agregado para hacer uso de la metodologia nCapaas


namespace Capa_Negocio
{
     public class CN_Productos   // se agrega el "public" para poder hacerse uso de las otras capas
    {
        private CD_Productos objectCD = new CD_Productos();

        public DataTable ShowProd()
        {
            DataTable table = new DataTable();
            table = objectCD.ShowT();
            return table;
        }
    }
}
