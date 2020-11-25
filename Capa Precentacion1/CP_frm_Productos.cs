using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;

namespace Capa_Precentacion1
{
    public partial class CP_frm_Productos : Form
    {
        CN_Productos ObjCN = new CN_Productos();

        public CP_frm_Productos()
        {
            InitializeComponent();
        }

        private void CP_frm_Productos_Load(object sender, EventArgs e)
        {
            ShowProd();
        }

        private void ShowProd()
        {
            dataGridView1.DataSource = ObjCN.ShowProd();
        }
    }
}
