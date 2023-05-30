using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ubiety.Dns.Core;
using WindowsFormsApp1;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Taller2
{
    public partial class Modificar : Form
    {

        /****************************************************************
        * tools
        ****************************************************************/
        public Modificar()
        {
            InitializeComponent();
            HideAll();

            ProductosIDList();
            VendedoresNumerosList();
            ClientesRutList();
        }

        private void HideAll()
        {
            Box_AgregarDinero.Hide();
            Box_CambiarEstado.Hide();
            Box_CambiarPrecio.Hide();
            Box_CambiarSalario.Hide();
            BOXACTIVO.Hide();
            BOXINACTIVO.Hide();

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
                input_ProductoCambiarPrecio.Items.Add(productos.Rows[i]["id"]);
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
                Input_VendedorCambiarSalario.Items.Add(vendedores.Rows[i]["numero"]);
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
                Input_ClienteCambiarEstado.Items.Add(clientes.Rows[i]["rut"]);
                Input_ClienteAgregarDinero.Items.Add(clientes.Rows[i]["rut"]);
            }
            conex.close();
        }







        /****************************************************************
        * BOTONES MOSTRAR BOX
        ****************************************************************/

        private void button_MostrarBoxProductoPrecio_Click(object sender, EventArgs e)
        {
            HideAll();
            Box_CambiarPrecio.Show();
        }

        private void button_MostrarBoxSalarioVendedor_Click(object sender, EventArgs e)
        {
            HideAll();
            Box_CambiarSalario.Show();
        }

        private void button_MostrarBoxDineroCliente_Click(object sender, EventArgs e)
        {
            HideAll();
            Box_AgregarDinero.Show();
        }

        private void button_MostrarBoxEstadoCliente_Click(object sender, EventArgs e)
        {
            HideAll();
            Box_CambiarEstado.Show();
        }

        /****************************************************************
         * BOTONES MODIFICAR BDD
         ****************************************************************/

        private void button_ModificarPrecioProducto_Click(object sender, EventArgs e)
        {
            if (input_ProductoCambiarPrecio.Text != "" && input_NuevoMontoProducto.Text != "")
            {
                int auxNuevoMonto;
                int auxProductoID;
                bool isParseableNuevoMonto = int.TryParse(input_NuevoMontoProducto.Text, out auxNuevoMonto);
                bool isParseableProductoID = int.TryParse(input_ProductoCambiarPrecio.Text, out auxProductoID);

                if (isParseableNuevoMonto && isParseableProductoID)
                {

                    DialogResult result = MessageBox.Show("¿Seguro que quieres cambiar estos valores?", "Warning",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                    if (result.Equals(DialogResult.Yes))
                    {
                        try
                        {
                            ConexMySQL conex = new ConexMySQL();
                            conex.open();


                            string query = "UPDATE producto SET precio = " + auxNuevoMonto +
                                " WHERE id = " + auxProductoID;

                            int respose = conex.executeNonQuery(query);
                            

                            if (respose != -1) MessageBox.Show("Se modifico correctamente");
                            else MessageBox.Show("No se pudo modificar", "ERROR");


                            conex.close();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("" + ex, "ERROR");
                        }
                    }
                }else MessageBox.Show("El Nuevo monto debe de ser numerico", "ERROR");
            }else MessageBox.Show("LLene todos los campos para continuar", "ERROR");
        }




        private void button_ModificarSalarioVendedor_Click(object sender, EventArgs e)
        {
            if (Input_VendedorCambiarSalario.Text != "" && Input_NuevoSalarioVendedor.Text != "")
            {
                int auxSalario;
                int auxVendedorNumero;
                bool isParseableMonto = int.TryParse(Input_NuevoSalarioVendedor.Text, out auxSalario);
                bool isParseableNumero = int.TryParse(Input_VendedorCambiarSalario.Text, out auxVendedorNumero);

                if (isParseableMonto && isParseableNumero)
                {
                    DialogResult result = MessageBox.Show("¿Seguro que quieres cambiar estos valores?", "Warning",
                   MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                    if (result.Equals(DialogResult.Yes))
                    {
                        try
                        {
                            ConexMySQL conex = new ConexMySQL();
                            conex.open();


                            string query = "UPDATE vendedor SET salario = " + auxSalario +
                                " WHERE numero = " + auxVendedorNumero;

                            int respose = conex.executeNonQuery(query);


                            if (respose != -1) MessageBox.Show("Se modifico correctamente");
                            else MessageBox.Show("No se pudo modificar", "ERROR");


                            conex.close();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("" + ex, "ERROR");
                        }
                    }
                }else MessageBox.Show("El Nuevo monto debe de ser numerico", "ERROR");
            }else MessageBox.Show("LLene todos los campos para continuar", "ERROR");
        }




        private void button_ModificarDineroCliente_Click(object sender, EventArgs e)
        {
            if (Input_ClienteAgregarDinero.Text != "" && Input_ClienteMontoAgregar.Text != "")
            {
                int auxMontoAgregar;
                int auxClienteRut;

                bool isParseableSaldo = int.TryParse(Input_ClienteMontoAgregar.Text, out auxMontoAgregar);
                bool isParseableNumero = int.TryParse(Input_ClienteAgregarDinero.Text, out auxClienteRut);


                if (isParseableNumero && isParseableSaldo)
                {
                    DialogResult result = MessageBox.Show("¿Seguro que quieres cambiar estos valores?", "Warning",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                    if (result.Equals(DialogResult.Yes))
                    {
                        try
                        {
                            ConexMySQL conex = new ConexMySQL();
                            conex.open();

                            int saldoActual;
                            string querysaldo = "SELECT saldo FROM cliente WHERE rut = '" + auxClienteRut + "'"; // aca el saldo es varchar T.T
                            string auxsaldoActual = conex.selectQueryScalar(querysaldo);
                            int.TryParse(auxsaldoActual, out saldoActual);

                            MessageBox.Show("="+saldoActual + "+" + auxMontoAgregar + "=" + (saldoActual+auxMontoAgregar), "ERROR");


                            string query = "UPDATE cliente SET saldo = " + (auxMontoAgregar+saldoActual) +
                                " WHERE rut = " + auxClienteRut;
                            int respose = conex.executeNonQuery(query);

                            if (respose != -1) MessageBox.Show("Se modifico correctamente");
                            else MessageBox.Show("No se pudo modificar", "ERROR");


                            conex.close();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("" + ex, "ERROR");
                        }
                    }
                }
            }
        }




        private void button_ModificarEstadoCliente_Click_Click(object sender, EventArgs e)
        {
            if (Input_ClienteCambiarEstado.Text != "")
            {
                DialogResult result = MessageBox.Show("¿Seguro que quieres cambiar el estado?", "Warning",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (result.Equals(DialogResult.Yes))
                {
                    ConexMySQL conex = new ConexMySQL();
                    conex.open();
                    string query = "SELECT estado FROM cliente WHERE rut = '" + Input_ClienteCambiarEstado.Text + "'";
                    string estado = conex.selectQueryScalar(query);


                    if (estado.Equals("activo"))
                    {
                        BOXACTIVO.Hide();
                        BOXINACTIVO.Show();
                        string cambiar = "UPDATE cliente SET ESTADO = 'inactivo' WHERE rut = '" + Input_ClienteCambiarEstado.Text + "'";
                        int respose = conex.executeNonQuery(cambiar);



                    }
                    else
                    {
                        BOXINACTIVO.Hide();
                        BOXACTIVO.Show();
                        string cambiar = "UPDATE cliente SET ESTADO = 'activo' WHERE rut = '" + Input_ClienteCambiarEstado.Text + "'";
                        int respose = conex.executeNonQuery(cambiar);

                    }
                }
            }
        }


        /****************************************************************
         * COMBOBOX CHANGED REACTION
        ****************************************************************/


        private void input_ProductoCambiarPrecio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Input_ClienteCambiarEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            BOXACTIVO.Hide();
            BOXINACTIVO.Hide();

            if (Input_ClienteCambiarEstado.Text != "")
            {
                ConexMySQL conex = new ConexMySQL();
                conex.open();
                string query = "SELECT estado FROM cliente WHERE rut = '" + Input_ClienteCambiarEstado.Text + "'";
                string estado = conex.selectQueryScalar(query);

                conex.close();

                if (estado.Equals("activo"))
                {
                    BOXACTIVO.Show();
                }
                else
                {
                    BOXINACTIVO.Show();
                }
            }
        }

        /****************************************************************
        * COLOCAR VALORES EN LISTAS
        ****************************************************************/

        private void Input_VendedorCambiarSalario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
