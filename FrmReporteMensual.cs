using System;
using System.Windows.Forms;

namespace InterfazFincaCafetera_Borr
{
    public partial class FrmReporteMensual : Form
    {
        public FrmReporteMensual()
        {
            InitializeComponent();
        }

        private void btn3Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            FrmInformacionEmpleado InfoEmpleado = new FrmInformacionEmpleado();
            InfoEmpleado.ShowDialog();
        }
    }
}
