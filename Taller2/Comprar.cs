using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Taller2
{
    public partial class Comprar : Form
    {
        /****************************************************************
        * tools
        ****************************************************************/
        public Comprar()
        {
            InitializeComponent();
            ProveedorIDList();
            ProductosIDList();
        }

        private void button_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuModificaciones menuModificaciones = new MenuModificaciones();
            menuModificaciones.Show();
        }

        /****************************************************************
        * COLOCAR VALORES EN LISTAS
        ****************************************************************/

        private void ProductosIDList()
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string query = "SELECT id FROM producto";
            DataTable productos = conex.selectQuery(query);
            for (int i = 0; i < productos.Rows.Count; i++)
            {
                Input_IDProducto.Items.Add(productos.Rows[i]["id"]);
            }
            conex.close();
        }

        private void ProveedorIDList()
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string query = "SELECT rut FROM proveedor";
            DataTable proveedores = conex.selectQuery(query);
            for (int i = 0; i<proveedores.Rows.Count; i++)
            {
                Input_IDProveedor.Items.Add(proveedores.Rows[i]["rut"]);
            }
            conex.close();
        }


        /****************************************************************
        * BOTONES MODIFICAR BDD
        ****************************************************************/

        private void button_comprar_Click(object sender, EventArgs e)
        {
            if (Input_CantidadComprar.Text != "" && Input_IDProducto.Text != "" && Input_IDProveedor.Text != "")
            {
                int cantidadCompra;
                bool isParseableCantidad = int.TryParse(Input_CantidadComprar.Text, out cantidadCompra);

                if (isParseableCantidad)
                {
                    DialogResult result = MessageBox.Show("¿Seguro que quieres cambiar estos valores?", "Warning",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                    if (result.Equals(DialogResult.Yes))
                    {
                        try
                        {
                            ConexMySQL conex = new ConexMySQL();
                            conex.open();

                            int precio;
                            string queryPrecio = "Select precio FROM producto WHERE id = " + Input_IDProducto.Text;
                            string auxPrecio = conex.selectQueryScalar(queryPrecio);
                            int.TryParse(auxPrecio, out precio);


                            int cantidadActual;
                            string queryCantidad = "Select stock FROM producto WHERE id = " + Input_IDProducto.Text;
                            string auxCantidad = conex.selectQueryScalar(queryCantidad);
                            int.TryParse(auxCantidad, out cantidadActual);


                            string queryStock = "UPDATE producto SET stock = " + (cantidadCompra+cantidadActual) +
                            " WHERE id = " + Input_IDProducto.Text;
                            int resposeStock = conex.executeNonQuery(queryStock);

                            
                            string queryInsert = "INSERT INTO proveedor_producto VALUES('" +
                                Input_IDProveedor.Text + "' ," +
                                Input_IDProducto.Text + ", " +
                                precio + ", " +
                                cantidadCompra + ")";
                            
                            int resposeInsert = conex.executeNonQuery(queryInsert);


                            if (resposeInsert != -1 && resposeStock != -1) MessageBox.Show("La compra se realizo correctamente");
                            else MessageBox.Show("No se pudo modificar", "ERROR");


                            conex.close();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("" + ex, "ERROR");
                        }
                    }
                }else MessageBox.Show("La cantidad debe de ser numeros", "ERROR");
            }else MessageBox.Show("LLene todos los campos para continuar", "ERROR");
        }






        /****************************************************************
        * NOSECOMOQUITARESTOAYUDAAAA
        ****************************************************************/



        private void Comprar_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Input_IDProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
