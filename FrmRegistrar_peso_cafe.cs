using System;
using System.Configuration;
using System.Data.SqlClient;
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

        private void cmbBx_recolector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmRegistrar_peso_cafe_Load(object sender, EventArgs e)
        {
            string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
            using (SqlConnection conexion = new SqlConnection(cnn))
            {
                string query = "SELECT Nombre FROM Recolectores";
                conexion.Open();
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader registro = comando.ExecuteReader();
                while (registro.Read())
                {
                    cmbBx_recolector.Items.Add(registro["Nombre"]);
                }
                conexion.Close();
            }
        }
    }
}
