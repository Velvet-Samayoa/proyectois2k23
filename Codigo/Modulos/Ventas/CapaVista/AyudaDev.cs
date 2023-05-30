using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ventas_CapaControlador;

namespace CapaVista
{
    public partial class AyudaDev : Form
    {
        Controlador cn = new Controlador();

        public AyudaDev()
        {
            InitializeComponent();
        }
        public DataGridView tabla;


        private void button1_Click(object sender, EventArgs e)
        {
            tabla = dataGridView1;
            cn.fillTable(tabla.Tag.ToString(), dataGridView1);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
               string[] datos = cn.llenartabla3(dataGridView1.CurrentRow.Cells[0].Value.ToString(), dataGridView1.CurrentRow.Cells[2].Value.ToString(), dataGridView1.CurrentRow.Cells[1].Value.ToString());
                txtIdAlmacen.Text = datos[1];
                txtIdProveedor.Text = datos[2];
                txtIdFactura.Text = datos[3];
                txtEmision.Text = datos[4];
                cn.IDS = Convert.ToDouble(datos[6]);
                this.Close();
            }
        }
    }
}
