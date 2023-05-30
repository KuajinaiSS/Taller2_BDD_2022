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
    public partial class Consultas : Form
    {
        /****************************************************************
        * tools
        ****************************************************************/
        public Consultas()
        {
            InitializeComponent();
        }

        private void button_Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Consultas_Load(object sender, EventArgs e)
        {
            Input_Listado.Items.Add("Proveedor");
            Input_Listado.Items.Add("Cliente");
            Input_Listado.Items.Add("Producto");
            Input_Listado.Items.Add("Categoria");
            Input_Listado.Items.Add("Vendedor");

            VendedoresNumerosList();
            BoletaIDList();
            ProductosIDList();
            CategoriasIDList();
            ProveedorRutList();




            HideAll();

        }

        private void HideAll()
        {
            Input_Listado.Hide();
            Input_Vendedor.Hide();
            Input_DatosOrdenCompra.Hide();
            Input_CategoriaProducto.Hide();
            Input_CantidadProductosAsociados.Hide();
            Input_ProductoProveedores.Hide();
            Input_ProveedorProductos.Hide();


        }

        /****************************************************************
        * COLOCAR VALORES EN LISTAS
        ****************************************************************/
        private void VendedoresNumerosList()
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string query = "SELECT numero FROM vendedor";
            DataTable vendedores = conex.selectQuery(query);
            for (int i = 0; i < vendedores.Rows.Count; i++)
            {
                Input_Vendedor.Items.Add(vendedores.Rows[i]["numero"]);
            }
            conex.close();
        }

        private void BoletaIDList()
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string query = "SELECT ID FROM boleta";
            DataTable boletas = conex.selectQuery(query);
            for (int i = 0; i < boletas.Rows.Count; i++)
            {
                Input_DatosOrdenCompra.Items.Add(boletas.Rows[i]["ID"]);
            }
            conex.close();
        }


        private void ProductosIDList()
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string query = "SELECT id FROM producto";
            DataTable productos = conex.selectQuery(query);
            for (int i = 0; i < productos.Rows.Count; i++)
            {
                Input_CategoriaProducto.Items.Add(productos.Rows[i]["id"]);
                Input_ProductoProveedores.Items.Add(productos.Rows[i]["id"]);
            }
            conex.close();
        }

        private void CategoriasIDList()
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string query = "SELECT id FROM categoria";
            DataTable categorias = conex.selectQuery(query);
            for (int i = 0; i < categorias.Rows.Count; i++)
            {
                Input_CantidadProductosAsociados.Items.Add(categorias.Rows[i]["id"]);
            }
            conex.close();
        }

        private void ProveedorRutList()
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string query = "SELECT rut FROM proveedor";
            DataTable proveedores = conex.selectQuery(query);
            for (int i = 0; i < proveedores.Rows.Count; i++)
            {
                Input_ProveedorProductos.Items.Add(proveedores.Rows[i]["rut"]);
            }
            conex.close();
        }


        /****************************************************************
        * BOTONES APRETADOS
        ****************************************************************/

        private void radioEmitirListado_CheckedChanged(object sender, EventArgs e)
        {
            HideAll();
            Input_Listado.Show();
            
        }

        private void radioDatoVendedor_CheckedChanged(object sender, EventArgs e)
        {
           HideAll();
           Input_Vendedor.Show();
            
        }


        private void radioDatoOrdenCompra_CheckedChanged(object sender, EventArgs e)
        {
            HideAll();
            Input_DatosOrdenCompra.Show();
            

        }

        private void radioCategoriaProducto_CheckedChanged(object sender, EventArgs e)
        {
            HideAll();
            Input_CategoriaProducto.Show();

        }

        private void Input_CategoriaProductosAsociados_CheckedChanged(object sender, EventArgs e)
        {
            HideAll();
            Input_CantidadProductosAsociados.Show();

        }

        private void radio_ProductoSuministranProveedores_CheckedChanged(object sender, EventArgs e)
        {
            HideAll();
            Input_ProductoProveedores.Show();
        }

        private void radio_ProductosSuministradosProveedor_CheckedChanged(object sender, EventArgs e)
        {
            HideAll();
            Input_ProveedorProductos.Show();

        }

        /****************************************************************
        * CONSULTAS A LA BDD
        ****************************************************************/



        private void Input_Listado_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string query = "SELECT * FROM " + Input_Listado.Text;
            dataGridView.DataSource = conex.selectQuery(query);
            conex.close();
        }



        private void Input_Vendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numeroVendedor;
            int.TryParse(Input_Vendedor.Text, out numeroVendedor);

            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string query = "SELECT * FROM vendedor WHERE numero = " + numeroVendedor;
            dataGridView.DataSource = conex.selectQuery(query);
            conex.close();
        }



        private void Input_DatosOrdenCompra_SelectedIndexChanged(object sender, EventArgs e)
        {
            int IDBoleta;
            int.TryParse(Input_DatosOrdenCompra.Text, out IDBoleta);


            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string query = "SELECT * FROM boleta INNER JOIN producto_boleta ON boleta.ID = producto_boleta.BoletaID " +
                "WHERE ID = " + IDBoleta;
            dataGridView.DataSource = conex.selectQuery(query);
            conex.close();
        }


        private void Input_CategoriaProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            int IDProducto;
            int.TryParse(Input_CategoriaProducto.Text, out IDProducto);

            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string query = "SELECT categoria.id, categoria.nombre, categoria.descripcion " +
                "FROM producto INNER JOIN categoria ON producto.CategoriaID = categoria.id " +
                "WHERE producto.id = " + IDProducto;
            dataGridView.DataSource = conex.selectQuery(query);
            conex.close();
        }



        
        private void Input_CantidadProductosAsociados_SelectedIndexChanged(object sender, EventArgs e)
        {
            int IDCategoria;
            int.TryParse(Input_CantidadProductosAsociados.Text, out IDCategoria);

            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string query = "SELECT COUNT(*) " +
                "FROM categoria INNER JOIN producto ON categoria.id = producto.CategoriaID " +
                "WHERE categoria.id = " + IDCategoria;
            dataGridView.DataSource = conex.selectQuery(query);
            conex.close();
        }



        private void Input_ProductoProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            int IDProducto;
            int.TryParse(Input_ProductoProveedores.Text, out IDProducto);

            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string query = "SELECT proveedor.rut, proveedor.nombre, proveedor.direccion " +
                "FROM producto INNER JOIN proveedor_producto ON producto.id = proveedor_producto.ProductoID " +
                "INNER JOIN proveedor ON proveedor_producto.ProveedorRut = proveedor.rut " +
                "WHERE producto.id = " + IDProducto;
            dataGridView.DataSource = conex.selectQuery(query);
            conex.close();
        }

        private void Input_ProveedorProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string query = "SELECT producto.id, proveedor_producto.cantidadSuministrada, producto.precio " +
                "FROM proveedor INNER JOIN proveedor_producto ON proveedor.rut = proveedor_producto.ProveedorRut " +
                "INNER JOIN producto ON proveedor_producto.ProductoID = producto.id " +
                "WHERE proveedor.rut = '" + Input_ProveedorProductos.Text+ "'";
            dataGridView.DataSource = conex.selectQuery(query);
            conex.close();

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
