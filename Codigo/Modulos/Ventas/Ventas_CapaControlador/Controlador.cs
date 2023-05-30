using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo_Ventas;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Data;



namespace Ventas_CapaControlador
{
    public class Controlador
    {
        Cpconexion conexion = new Cpconexion();
<<<<<<< Updated upstream
        string numeroId = "SELECT Pk_idCotizacion FROM `ModuloVentas`.`tbl_cotizacion` ORDER BY Pk_idCotizacion DESC LIMIT 1;";
        string numeroIdDetalle = "SELECT Pk_detallecotizacion FROM `ModuloVentas`.`tbl_detalle_cotizacion` ORDER BY Pk_detallecotizacion DESC LIMIT 1;";
        string comboProductos = "select nombre_producto from `ModuloVentas`.`tbl_producto`";
        string comboAlmacen = "select nombre_almacen from `ModuloVentas`.`tbl_almacen`";
        string comboCliente = "select Dpi_clientes from `ModuloVentas`.`tbl_clientes`";
        string comboEstado = "select descripcion_estado_cotizacion from `ModuloVentas`.`tbl_estado_cotizacion`";
        

        public string llenarTextBoxID()
=======
        Sentencias sn = new Sentencias();
        public double IDS


        public string[] llenartabla3(string idFactura, string proveedor, string almacen)//Funcion para llenar tabla
        {
            string[] datos = new string[7];
            try
            {
                OdbcDataAdapter dt = sn.llenartabla3(idFactura, proveedor, almacen);
                DataTable table = new DataTable();
                dt.Fill(table);
                for (int x = 0; x < datos.Length; x++)
                {
                    datos[x] = table.Rows[table.Rows.Count - 1][x].ToString();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e);
            }
            return datos;
        }



        public void Guardar(Dictionary<string, List<string>> valoresPorTagTabla, Dictionary<string, List<string>> valoresPorTagColumnas)
>>>>>>> Stashed changes
        {
            OdbcCommand cmdId = new OdbcCommand(numeroId, conexion.Conexion());
            OdbcDataReader readerId = cmdId.ExecuteReader();

            while (readerId.Read())
            {
                int idActual = int.Parse(readerId.GetString(0));
                idActual = idActual + 1;
                return idActual.ToString();
            }
            return "No hay valor";
        }
        public string llenarTextBoxIdDetalle()
        {
            OdbcCommand cmdIdDetalle = new OdbcCommand(numeroIdDetalle, conexion.Conexion());
            OdbcDataReader readerIdDetalle = cmdIdDetalle.ExecuteReader();

            while (readerIdDetalle.Read())
            {
                int idActualDetalle = int.Parse(readerIdDetalle.GetString(0));
                idActualDetalle = idActualDetalle + 1;
                return idActualDetalle.ToString();
            }
            return "No hay valor";
        }
        public string llenarComboProductos()
        {
            OdbcCommand productos = new OdbcCommand(comboProductos, conexion.Conexion());
            OdbcDataReader readerProductos = productos.ExecuteReader();

            while (readerProductos.Read())
            {
                return readerProductos.GetString(0);
            }
            return "No hay valor";
        }
        public string llenarComboAlmacen()
        {
            OdbcCommand cmd = new OdbcCommand(comboAlmacen, conexion.Conexion());
            OdbcDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                return reader.GetString(0);
            }
            return "No hay valor";
        }
        public string llenarComboCliente()
        {
            OdbcCommand cliente = new OdbcCommand(comboCliente, conexion.Conexion());
            OdbcDataReader readerCliente = cliente.ExecuteReader();

            while (readerCliente.Read())
            {
                return readerCliente.GetString(0);
            }
            return "No hay valor";
        }
        public string llenarComboEstado()
        {
            OdbcCommand estado = new OdbcCommand(comboEstado, conexion.Conexion());
            OdbcDataReader readerEstado = estado.ExecuteReader();

            while (readerEstado.Read())
            {
                return readerEstado.GetString(0);
            }
            return "No hay valor";
        }
        public string obtenerPrecioUnitario(string productos)
        {
            string precio = "SELECT preciouni_producto FROM `ModuloVentas`.`tbl_producto` WHERE nombre_producto = '" + productos + "';";
            OdbcCommand cmd = new OdbcCommand(precio, conexion.Conexion());
            OdbcDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                return reader.GetString(0);
            }
            return "No hay valor";
        }



        public void fillTable(string ntabla, DataGridView tabla)//Funcion para llenar tabla
        {
            try
            {
                OdbcDataAdapter dt = sn.llenartabla(ntabla);
                DataTable table = new DataTable();
                dt.Fill(table);
                tabla.DataSource = table;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e);
            }
        }




    }
    
}
