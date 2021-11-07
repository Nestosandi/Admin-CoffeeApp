using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace InterfazFincaCafetera_Borr
{
    public partial class FrmInformacionEmpleado : Form
    {
        public FrmInformacionEmpleado()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbNombreRecolector_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
            using (SqlConnection conexion = new SqlConnection(cnn))
            {
                string query = "SELECT Nombre FROM Recolectores";
                conexion.Open();
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader registro = comando.ExecuteReader();
            }
        }

        private void FrmInformacionEmpleado_Load(object sender, EventArgs e)
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
                    cmbNombreRecolector.Items.Add(registro["Nombre"]);
                }
                conexion.Close();
            }
        }
    }
}