using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller2
{
    public partial class MenuModificaciones : Form
    {
        public MenuModificaciones()
        {
            InitializeComponent();
            
        }

        private void button_Vender_Click(object sender, EventArgs e)
        {
            this.Close();
            Vender vender = new Vender();
            vender.Show();
        }

        private void button_Comprar_Click(object sender, EventArgs e)
        {
            this.Close();
            Comprar comprar = new Comprar();
            comprar.Show();
        }


        private void button_Modificar_Click(object sender, EventArgs e)
        {
            this.Close();
            Modificar modificar = new Modificar();
            modificar.Show();
        }


        private void button_Insertar_Click(object sender, EventArgs e)
        {
            this.Close();
            Insertar insertar = new Insertar();
            insertar.Show();
        }

        private void button_Regresar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void MenuModificaciones_Load(object sender, EventArgs e)
        {

        }


    }
}
