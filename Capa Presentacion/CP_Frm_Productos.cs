using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;                 //llamamos a la capa negocio para hacer uso de sus atributos

namespace Capa_Presentacion
{
    public partial class CP_Frm_Productos : Form
    {
        //creamos un objeto para hacer uso de la capa negocio
        CN_Productos objectCN = new CN_Productos();

        public CP_Frm_Productos()
        {
            InitializeComponent();
        }

        private void CP_Frm_Productos_Load(object sender, EventArgs e)
        {

            ShowProductos();

        }

        //Se crea un metodo void para mostrar los productos en el datagrid 1
        private void ShowProductos()
        {
            dataGridView1.DataSource = objectCN.ShowProd();
        }
    }
}
