using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace InterfazFincaCafetera_Borr
{
    public partial class FrmLoginAll : Form
    {
        public FrmLoginAll()
        {
            InitializeComponent();
        }
        public String Perfil { get; set; }


        private void FrmLoginAll_Load(object sender, EventArgs e)
        {
            if (this.Perfil == "Administrador")
            {
                PicPerfil.Image = imageList1.Images[2];
            }
            else
            {
                if (this.Perfil == "Mayordomo")
                {
                    PicPerfil.Image = imageList1.Images[0];
                }
                else
                {
                    if (this.Perfil == "Propietario")
                    {
                        PicPerfil.Image = imageList1.Images[1];
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnEnterLoginAll_Click(object sender, EventArgs e)
        {
            if (this.Perfil == "Administrador")
            {
                try
                {
                    string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                    using (SqlConnection conexion = new SqlConnection(cnn))
                    {
                        conexion.Open();
                        using (SqlCommand cmd = new SqlCommand("SELECT Username, Contraseña FROM Usuarios WHERE Username='"
                            + txtUser.Text + "' AND Contraseña='" + txtPass.Text + "'" + " AND Rol='Administrador'", conexion))
                        {
                            SqlDataReader dr = cmd.ExecuteReader();
                            if (dr.Read())
                            {
                                MessageBox.Show("Login exitoso.");
                                FrmAdministrador admin = new FrmAdministrador();
                                admin.ShowDialog();
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
            else
            {
                if (this.Perfil == "Mayordomo")
                {
                    try
                    {
                        string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                        using (SqlConnection conexion = new SqlConnection(cnn))
                        {
                            conexion.Open();
                            using (SqlCommand cmd = new SqlCommand("SELECT Username, Contraseña FROM Usuarios WHERE Username='"
                                + txtUser.Text + "' AND Contraseña='" + txtPass.Text + "'" + " AND Rol='Mayordomo'", conexion))
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
                else
                {
                    if (this.Perfil == "Propietario")
                    {
                        try
                        {
                            string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                            using (SqlConnection conexion = new SqlConnection(cnn))
                            {
                                conexion.Open();
                                using (SqlCommand cmd = new SqlCommand("SELECT Username, Contraseña FROM Usuarios WHERE Username='"
                                    + txtUser.Text + "' AND Contraseña='" + txtPass.Text + "'" + " AND Rol='Propietario'", conexion))
                                {
                                    SqlDataReader dr = cmd.ExecuteReader();
                                    if (dr.Read())
                                    {
                                        MessageBox.Show("Login exitoso.");
                                        FrmRegistrarProduccion prop = new FrmRegistrarProduccion();
                                        prop.ShowDialog();
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

        }

        private void BtnCancelLoginAll_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    Perfil = comboBox1.Text;
        //    this.FrmLoginAll_Load(sender, e);

        //}
    }
}
