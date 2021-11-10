using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace InterfazFincaCafetera_Borr
{
    class Recolector
    {
        public int cedula { get; set; }
        public string nombre { get; set; }
        public int celular { get; set; }
        public string fecha { get; set; }
        public void RegistrarRecolector(int cedula, string nombre, int celular, string fecha)
        {
            FrmRegistrarRecolector frmR = new FrmRegistrarRecolector();
            
            string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
            using (SqlConnection conexion = new SqlConnection(cnn))
            {
                string query = "INSERT INTO Recolectores VALUES (@cedula,@nombre,@celular,@fecha)";
                conexion.Open();

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@cedula", cedula);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@celular", celular);
                comando.Parameters.AddWithValue("@fecha", fecha);
                comando.ExecuteNonQuery();

                MessageBox.Show("¡Recolector ingresado correctamente!");
            }
        }

        public void MostrarRecolector(System.Windows.Forms.DataGridView DgvRecolectores)
        {
            FrmRegistrarRecolector frmR = new FrmRegistrarRecolector();

            string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
            using (SqlConnection conexion = new SqlConnection(cnn))
            {
                SqlCommand comando2 = new SqlCommand("SELECT * FROM Recolectores", conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando2;
                System.Data.DataSet tabla = new System.Data.DataSet();
                adaptador.Fill(tabla);
                DgvRecolectores.DataSource = tabla;
            }
        }
    }
}
