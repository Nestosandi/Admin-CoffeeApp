using System;
using System.Windows.Forms;

namespace InterfazFincaCafetera_Borr
{
    public partial class FrmAdministrador : Form
    {
        public FrmAdministrador()
        {
            InitializeComponent();
        }

        private void BtnRegistrarR_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRegistrarRecolector reco = new FrmRegistrarRecolector();
            reco.ShowDialog();
        }

        private void BtnReporteDiario_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmReporteDiario dia = new FrmReporteDiario();
            dia.ShowDialog();
        }

        private void BtnReporteSemanal_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmReporteMensual mes = new FrmReporteMensual();
            mes.ShowDialog();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
