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
    public partial class FrmRegistrar_peso_cafe : Form
    {
        public FrmRegistrar_peso_cafe()
        {
            InitializeComponent();
        }

        private void btn_cancelar_peso_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
