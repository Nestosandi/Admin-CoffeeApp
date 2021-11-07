using System;
using System.Windows.Forms;

namespace InterfazFincaCafetera_Borr
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

            FrmLogin lg = new FrmLogin();
            lg.ShowDialog();







        }

        private void label2_Click(object sender, EventArgs e)
        {

            FrmLogin lg = new FrmLogin();
            lg.ShowDialog();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }
    }
}
