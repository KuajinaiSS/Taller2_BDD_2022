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

using WindowsFormsApp1;

namespace Taller2
{
    public partial class Insertar : Form
    {
        /****************************************************************
        * tools
        ****************************************************************/


        public Insertar()
        {
            InitializeComponent();
            HideALL();
        }


        private void HideALL()
        {
            this.Box_Categoria.Hide();
            this.Box_Cliente.Hide();
            this.Box_Producto.Hide();
            this.Box_Proveedor.Hide();
            this.Box_Vendedor.Hide();
        }

        private void CleanALL()
        {
            input_DescripcionCategoria.Clear();
            input_DireccionCliente.Clear();
            input_DireccionProveedor.Clear();
            input_IDCategoria.Clear();
            input_IDProducto.Clear();
            input_NombreCategoria.Clear();
            input_NombreCliente.Clear();
            input_NombreProducto.Clear();
            input_NombreProveedor.Clear();
            input_NombreVendedor.Clear();
            input_NumeroVendedor.Clear();
            input_PrecioProducto.Clear();
            input_RutCliente.Clear();
            input_RutProveedor.Clear();
            input_SalarioVendedor.Clear();
            input_SaldoCliente.Clear();
            input_StockProducto.Clear();
            input_TelefonoCliente.Clear();

        }

        private void CategoriasProducto()
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string query = "SELECT id FROM categoria";
            DataTable categorias = conex.selectQuery(query);

            input_IDCategoriaProducto.Items.Clear();

            for (int i = 0; i < categorias.Rows.Count; i++)
            {
                input_IDCategoriaProducto.Items.Add(categorias.Rows[i]["id"]);
            }
            conex.close();
        }

        /****************************************************************
        * BOTONES MOSTRAR BOX
        ****************************************************************/


        private void button_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuModificaciones menuModificaciones = new MenuModificaciones();
            menuModificaciones.Show();
        }

        private void button_NuevoCliente_Click(object sender, EventArgs e)
        {
            HideALL();
            Box_Cliente.Show();

        }

        private void button_NuevoProveedor_Click(object sender, EventArgs e)
        {
            HideALL();
            Box_Proveedor.Show();

        }

        private void button_NuevoProducto_Click(object sender, EventArgs e)
        {
            
            HideALL();
            CategoriasProducto();
            Box_Producto.Show();

        }

        private void button_NuevoVendedor_Click(object sender, EventArgs e)
        {
            HideALL();
            Box_Vendedor.Show();

        }

        private void button_NuevoCategoria_Click(object sender, EventArgs e)
        {
            HideALL();
            Box_Categoria.Show();

        }

        private void Box_Producto_Enter(object sender, EventArgs e)
        {
            
            HideALL();
            Box_Producto.Show();

        }


        /****************************************************************
        * BOTONES MOSTRAR BOX
        ****************************************************************/



        /*
         problema combobox
         */
        private void button_AgregarProducto_Click_1(object sender, EventArgs e)
        {
            if (input_IDProducto.Text != "" && input_NombreProducto.Text != "" &&
                input_PrecioProducto.Text != "" && input_StockProducto.Text != "" &&
                input_IDCategoriaProducto.Text != "")
            {
                int auxID;
                int auxPrecio;
                int auxStock;
                int auxIDCategoria;

                bool isParseableID = int.TryParse(input_IDProducto.Text, out auxID);
                bool isParseablePrecio = int.TryParse(input_PrecioProducto.Text, out auxPrecio);
                bool isParseableStock = int.TryParse(input_StockProducto.Text, out auxStock);
                bool isParseableIDCategoria = int.TryParse(input_IDCategoriaProducto.Text, out auxIDCategoria);

                if (isParseableID && isParseablePrecio && isParseableStock && isParseableIDCategoria)
                {
                    DialogResult result = MessageBox.Show("Los datos son correctos?", "Warning",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                    if (result.Equals(DialogResult.Yes))
                    {
                        try
                        {
                            ConexMySQL conex = new ConexMySQL();
                            conex.open();


                            string query = "INSERT INTO producto VALUES(" +
                                auxID + ", '" +
                                input_NombreProducto.Text + "', " +
                                auxPrecio + ", " +
                                auxStock + ", " +
                                auxIDCategoria + ")";

                            int respose = conex.executeNonQuery(query);

                            if (respose != -1) MessageBox.Show("el producto se agrego");
                            else MessageBox.Show("No se pudo insertar el producto", "ERROR");


                            conex.close();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("" + ex, "ERROR");
                        }

                    }

                }else MessageBox.Show("El ID, Precio y/o Stock deben de ser numeros", "ERROR");
            }else MessageBox.Show("LLene todos los campos para continuar", "ERROR");
            CleanALL();
        }



        private void button_AgregarVendedor_Click(object sender, EventArgs e)
        {
            if (input_NumeroVendedor.Text != "" && input_NombreVendedor.Text != "" &&
                input_SalarioVendedor.Text != "" && input_FechaContratacion.Text != "")
            {
                int auxNumero;
                int auxSalario;
                bool isParsableSalario = int.TryParse(input_SalarioVendedor.Text, out auxSalario);
                bool isParsableNumero = int.TryParse(input_NumeroVendedor.Text, out auxNumero);
                string auxContratacion = input_FechaContratacion.Value.ToString("yyyy-MM-dd");

                if (isParsableNumero && isParsableSalario)
                {

                    DialogResult result = MessageBox.Show("Los datos son correctos?", "Warning",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                    if (result.Equals(DialogResult.Yes))
                    {
                        try
                        {
                            ConexMySQL conex = new ConexMySQL();
                            conex.open();


                            string query = "INSERT INTO vendedor VALUES(" +
                                auxNumero + ", '" +
                                input_NombreVendedor.Text + "', " +
                                auxSalario + ", '" +
                                auxContratacion + "')";


                            int respose = conex.executeNonQuery(query);

                            if (respose != -1) MessageBox.Show("el empleado se agrego");
                            else MessageBox.Show("No se pudo insertar el empleado", "ERROR");


                            conex.close();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(""+ex,"ERROR");
                        }

                    }
                }else MessageBox.Show("El salario y/o numero deben de ser numeros", "ERROR");
            }else MessageBox.Show("LLene todos los campos para continuar", "ERROR");
            CleanALL();
        }



        private void button_AgregarCategoria_Click(object sender, EventArgs e)
        {
            if (input_NombreCategoria.Text != "" && input_IDCategoria.Text != "" && 
                input_DescripcionCategoria.Text != "")
            {
                int auxID;
                bool isParseable = int.TryParse(input_IDCategoria.Text, out auxID);
                if (isParseable)
                {
                    DialogResult result = MessageBox.Show("Los datos son correctos?", "Warning",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                    if (result.Equals(DialogResult.Yes))
                    {
                        try
                        {
                            ConexMySQL conex = new ConexMySQL();
                            conex.open();
                            string query = "INSERT INTO categoria VALUES(" +
                            auxID + ", '" +
                            input_NombreCategoria.Text + "', '" +
                            input_DescripcionCategoria.Text + "')";

                            int respose = conex.executeNonQuery(query);


                            if (respose != -1)
                            {
                                CategoriasProducto();
                                MessageBox.Show("La categoria se agrego");
                            }
                            else MessageBox.Show("No se pudo insertar la categoria", "ERROR");


                            conex.close();

                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show("" + ex, "ERROR");
                        }
                    }
                }else MessageBox.Show("El ID debe de ser numeros", "ERROR");
            }else MessageBox.Show("LLene todos los campos para continuar", "ERROR");
            CleanALL();
        }



        private void button_AgregarProveedor_Click(object sender, EventArgs e)
        {
            if (input_DireccionProveedor.Text != "" && input_NombreProveedor.Text != "" &&
                input_RutProveedor.Text != "")
            {
                DialogResult result = MessageBox.Show("Los datos son correctos?", "Warning",
                 MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (result.Equals(DialogResult.Yes))
                {
                    try
                    {
                        ConexMySQL conex = new ConexMySQL();
                        conex.open();
                        string query = "INSERT INTO proveedor VALUES('" +
                        input_RutProveedor.Text + "', '" +
                        input_NombreProveedor.Text + "', '" +
                        input_DireccionProveedor.Text + "')";

                        int respose = conex.executeNonQuery(query);


                        if (respose != -1) MessageBox.Show("el proveedor se agrego");
                        else MessageBox.Show("No se pudo insertar el proveedor", "ERROR");


                        conex.close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex, "ERROR");
                    }


                }
            }else MessageBox.Show("LLene todos los campos para continuar", "ERROR");
            CleanALL();
        }


        private void button_AgregarCliente_Click(object sender, EventArgs e)
        {
            if (input_RutCliente.Text != "" && input_NombreCliente.Text != "" &&
                input_SaldoCliente.Text != "" && input_DireccionCliente.Text != "" &&
                input_TelefonoCliente.Text != "")
            {

                int auxSaldo;
                int auxTelefono;

                bool isParsableSaldo = int.TryParse(input_SaldoCliente.Text, out auxSaldo);
                bool isParsebleTelefono = int.TryParse(input_TelefonoCliente.Text, out auxTelefono);

                if (isParsableSaldo && isParsebleTelefono)
                {

                    DialogResult result = MessageBox.Show("Los datos son correctos?", "Warning",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                    if (result.Equals(DialogResult.Yes))
                    {
                        try
                        {
                            ConexMySQL conex = new ConexMySQL();
                            conex.open();
                            string query = "INSERT INTO cliente VALUES('" +
                            input_RutCliente.Text + "', '" +
                            input_NombreCliente.Text + "', '" +
                            input_SaldoCliente.Text + "', '" +
                            input_DireccionCliente.Text + "', '" +
                            input_TelefonoCliente.Text + "', 'activo')";
    
                            int respose = conex.executeNonQuery(query);


                            if (respose != -1) MessageBox.Show("el cliente se agrego");
                            else MessageBox.Show("No se pudo insertar el cliente", "ERROR");


                            conex.close();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("" + ex, "ERROR");
                        }
                    }
                }else MessageBox.Show("El Saldo debe de ser numeros", "ERROR");
            }else MessageBox.Show("LLene todos los campos para continuar", "ERROR");
            CleanALL();
        }






        /****************************************************************
        * NOSE COMO BORRAR ESTO XD
        ****************************************************************/


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void input_IDProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void input_NombreProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void input_IDCategoriaProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Insertar_Load(object sender, EventArgs e)
        {

        }

        private void input_EstadoCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void Box_Cliente_Enter(object sender, EventArgs e)
        {

        }
    }
}
