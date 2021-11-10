using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InterfazFincaCafetera_Borr
{
    class Login
    {

        public string usuario { get; set; }
        public string contraseña { get; set; }
        public void Autenticar(string usuario, string contraseña, string rol)
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT Username, Contraseña FROM Usuarios WHERE Username='"
                        + usuario + "' AND Contraseña='" + contraseña + "'" + " AND Rol=' " + rol + "'", conexion))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            MessageBox.Show("Login exitoso.");
                            FrmRegistrar_Cafe mayor = new FrmRegistrar_Cafe();
                            mayor.ShowDialog();
                            conexion.Close();
                        }
                        else
                        {
                            MessageBox.Show("Datos incorrectos.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
