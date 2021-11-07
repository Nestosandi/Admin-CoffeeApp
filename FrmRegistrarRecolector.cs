using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace InterfazFincaCafetera_Borr
{
    public partial class FrmRegistrarRecolector : Form
    {
        public FrmRegistrarRecolector()
        {
            InitializeComponent();
        }

        private void txtCelular_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
            using (SqlConnection conexion = new SqlConnection(cnn))
            {
                string query = "INSERT INTO Recolectores VALUES (@cedula,@nombre,@celular,@fecha)";
                conexion.Open();

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@cedula", txtCedula.Text);
                comando.Parameters.AddWithValue("@nombre", txtNombre.Text);
                comando.Parameters.AddWithValue("@celular", txtCelular.Text);
                comando.Parameters.AddWithValue("@fecha", DtFecha.Text);
                comando.ExecuteNonQuery();

                MessageBox.Show("¡Recolector ingresado correctamente!");

                SqlCommand comando2 = new SqlCommand("SELECT * FROM Recolectores", conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando2;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                DgvRecolectores.DataSource = tabla;

                txtCedula.Clear();
                txtNombre.Clear();
                txtCelular.Clear();
                
            }
            
        }
    }
}
