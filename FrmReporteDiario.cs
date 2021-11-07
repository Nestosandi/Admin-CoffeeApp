using System;
using System.Windows.Forms;

namespace InterfazFincaCafetera_Borr
{
    public partial class FrmReporteDiario : Form
    {
        public FrmReporteDiario()
        {
            InitializeComponent();
        }

        private void btnRDcancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRDMostrar_Click(object sender, EventArgs e)
        {
            FrmInformacionEmpleado InfoEmpleado = new FrmInformacionEmpleado();
            InfoEmpleado.ShowDialog();
        }
    }
}
