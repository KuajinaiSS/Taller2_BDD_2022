using Google.Protobuf.WellKnownTypes;
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
    public partial class Vender : Form
    {
        /****************************************************************
        * tools
        ****************************************************************/
        public Vender()
        {
            InitializeComponent();
            ProductosIDList();
            VendedoresNumerosList();
            ClientesRutList();
        }

        private void button_Regresar_Click(object sender, EventArgs e)
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
                Input_Producto.Items.Add(productos.Rows[i]["id"]);
            }
            conex.close();
        }

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


        private void ClientesRutList()
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string query = "SELECT rut FROM cliente";
            DataTable clientes = conex.selectQuery(query);
            for (int i = 0; i < clientes.Rows.Count; i++)
            {
                Input_Cliente.Items.Add(clientes.Rows[i]["rut"]);
            }
            conex.close();
        }

        private bool descuentoValido(string descuentoAux)
        {
            int descuento;
            bool isParseable = int.TryParse(descuentoAux, out descuento);

            if (isParseable)
            {
                if (descuento <= 100 && descuento >= 0)
                {
                    return true;
                }
            }
            return false;
        }


        /****************************************************************
        * BOTONES MODIFICAR BDD
        ****************************************************************/
        private void button_Vender_Click(object sender, EventArgs e)
        {
            if (Input_CantidadCompra.Text != "" && Input_Cliente.Text != "" &&
                Input_Producto.Text != "" && Input_Vendedor.Text != "" && descuentoValido(Input_Descuento.Text))
            {
                int cantidadCompra;
                bool isParseableCantidad = int.TryParse(Input_CantidadCompra.Text, out cantidadCompra);
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

                            int precioProducto;
                            string queryPrecio = "Select precio FROM producto WHERE id = " + Input_Producto.Text;
                            string auxPrecioProducto = conex.selectQueryScalar(queryPrecio);
                            int.TryParse(auxPrecioProducto, out precioProducto);


                            int cantidadStock;
                            string queryCantidad = "Select stock FROM producto WHERE id = " + Input_Producto.Text;
                            string auxCantidad = conex.selectQueryScalar(queryCantidad);
                            int.TryParse(auxCantidad, out cantidadStock);


                            int saldoCliente;
                            string querySaldo = "Select saldo FROM cliente WHERE rut = '" + Input_Cliente.Text + "'";
                            string auxSaldo = conex.selectQueryScalar(querySaldo);
                            int.TryParse(auxSaldo, out saldoCliente);

                            if (saldoCliente > (precioProducto*cantidadCompra) )
                            {
                                if (cantidadStock >= cantidadCompra)
                                {

                                    string queryStock = "UPDATE producto SET stock = " + (cantidadStock - cantidadCompra) +
                                    " WHERE id = " + Input_Producto.Text;
                                    int resposeStock = conex.executeNonQuery(queryStock);

                                    string querySaldoNuevo = "UPDATE cliente SET saldo = " + (saldoCliente - (precioProducto * cantidadCompra) ) +
                                        " WHERE rut = '" + Input_Cliente.Text + "'";
                                    int responseSaldoNuevo = conex.executeNonQuery(querySaldoNuevo);




                                    string fecha = DateTime.Now.ToString("yyyy-MM-dd");
                                    int descuento;
                                    bool isParseable = int.TryParse(Input_Descuento.Text, out descuento);

                                    string queryBoleta = "INSERT INTO boleta (fecha,descuento,ClienteRut,VendedorNumero) VALUES('" +
                                        fecha + "', " + 
                                        descuento + ", '" +
                                        Input_Cliente.Text + "', " +
                                        Input_Vendedor.Text + ")";
                                        int resposeBoleta = conex.executeNonQuery(queryBoleta);





                                        int productoID;
                                        int.TryParse(Input_Producto.Text, out productoID);

                               

                                        string queryIDBoleta = "SELECT ID FROM boleta WHERE ID=( SELECT MAX(id) from boleta)";
                                        string auxBoleta = conex.selectQueryScalar(queryIDBoleta);
                                        int BoletaID;
                                        bool isParseableAuxBoleta = int.TryParse(auxBoleta, out BoletaID);


                                        string queryProducto_Boleta = "INSERT INTO producto_boleta VALUES(" +
                                                productoID + ", " +
                                                BoletaID + ", " +
                                                cantidadCompra + ")";
                                        int resposeInsert = conex.executeNonQuery(queryProducto_Boleta);




                                        if (resposeInsert != -1 && resposeStock != -1 && responseSaldoNuevo != -1) MessageBox.Show("Compra realizada con exito", "ERROR");
                                        else MessageBox.Show("No se pudo realizar la compra", "CORRECTO");



                                }else MessageBox.Show("La cantidad excede el stock", "ERROR");

                            }else MessageBox.Show("Saldo del cliente Insuiciente", "ERROR");
                            conex.close();
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(""+ex, "ERROR");
                        }

                    }
                }else MessageBox.Show("La cantidad debe de ser numeros", "ERROR");
            }else MessageBox.Show("LLene todos los campos para continuar", "ERROR");
        }



        /****************************************************************
        * NOSECOMOQUITARESTOAYUDAAAA
        ****************************************************************/

        private void Vender_Load(object sender, EventArgs e)
        {

        }

        private void Input_Cliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
