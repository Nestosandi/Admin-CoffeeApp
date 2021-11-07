using System;
using System.Windows.Forms;

namespace InterfazFincaCafetera_Borr
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }



        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLoginAll adminitrador = new FrmLoginAll();
            adminitrador.Perfil = "Administrador";
            adminitrador.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLoginAll Propietario = new FrmLoginAll();
            Propietario.Perfil = "Propietario";
            Propietario.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLoginAll Mayordomo = new FrmLoginAll();
            Mayordomo.Perfil = "Mayordomo";
            Mayordomo.ShowDialog();
        }
    }
}
