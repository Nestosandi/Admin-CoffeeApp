using System;
using System.Windows.Forms;

namespace InterfazFincaCafetera_Borr
{
    public partial class FrmRegistrarProduccion : Form
    {
        public FrmRegistrarProduccion()
        {
            InitializeComponent();
        }

        private void BtnRegistrarProducción_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRegistrar_Produccion regPro = new FrmRegistrar_Produccion();
            regPro.ShowDialog();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
