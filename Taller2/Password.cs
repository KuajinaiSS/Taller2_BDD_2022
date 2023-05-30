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
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string query = "SELECT password FROM PASSWORD";
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string password = conex.selectQueryScalar(query); // este nos retorna la contraseña de la bdd
            conex.close();

            string passwordInput = inputPassword.Text;
            if (password == passwordInput)
            {
                this.Close();
                MenuModificaciones MenuModificaciones = new MenuModificaciones();
                MenuModificaciones.Show();
            }
            else
            {
                MessageBox.Show("Contraseña Incorrecta");
            }


        }

        private void inputPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
