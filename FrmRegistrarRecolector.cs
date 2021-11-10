using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
            //string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
            //using (SqlConnection conexion = new SqlConnection(cnn))
            //{

            //string query = "INSERT INTO Recolectores VALUES (@cedula,@nombre,@celular,@fecha)";
            //conexion.Open();

            //SqlCommand comando = new SqlCommand(query, conexion);
            //comando.Parameters.AddWithValue("@cedula", txtCedula.Text);
            //comando.Parameters.AddWithValue("@nombre", txtNombre.Text);
            //comando.Parameters.AddWithValue("@celular", txtCelular.Text);
            //comando.Parameters.AddWithValue("@fecha", DtFecha.Text.ToString());
            //comando.ExecuteNonQuery();

            //MessageBox.Show("¡Recolector ingresado correctamente!");

            Recolector Rec = new Recolector();
            Rec.RegistrarRecolector(Convert.ToInt32(txtCedula.Text), txtNombre.Text,
                Convert.ToInt32(txtCelular.Text), DtFecha.Text);

            Rec.MostrarRecolector(DgvRecolectores);

                txtCedula.Clear();
                txtNombre.Clear();
                txtCelular.Clear();

            }

        }
    }

