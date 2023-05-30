using WindowsFormsApp1;
namespace Taller2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            conex.close();
           
        }

        private void button_Modificaciones_Click(object sender, EventArgs e)
        {
            Password password = new Password();
            password.Show();
        }


        private void button_Consultas_Click(object sender, EventArgs e)
        {
            Consultas consultas = new Consultas();
            consultas.Show();
        }
    }
}