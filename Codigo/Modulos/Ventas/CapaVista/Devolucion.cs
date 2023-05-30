using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace CapaVista
{
    public partial class Devolucion : Form
    {
        public Devolucion()
        {
            InitializeComponent();

        }


        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "1000";
            TextBox[] Grupotextbox = { txt_id, txt_cliente, txt_fecha, txt_nota_credito, txt_factura };
            TextBox[] Idtextbox = { txt_id, txt_cliente };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dataGridView1;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dataGridView1, Grupotextbox, "tbl_devolucion");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fechaPago = DateTime.ParseExact(dateTimePicker1.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string fechaPagoFormateado = fechaPago.ToString("yyyy-MM-dd");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AyudaDev ayudad = new AyudaDev();
            ayudad.Show();
        }

        private void Devolucion_Load(object sender, EventArgs e)
        {

        }
    }
}
