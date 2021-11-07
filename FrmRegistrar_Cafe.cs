using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazFincaCafetera_Borr
{
    public partial class FrmRegistrar_Cafe : Form
    {
        public FrmRegistrar_Cafe()
        {
            InitializeComponent();
        }

        private void FrmRegistrar_Cafe_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRegistrarCafé_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRegistrar_peso_cafe Peso = new FrmRegistrar_peso_cafe();
            Peso.ShowDialog();
        }

        private void btnCancelCafé_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
