﻿using System;
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
