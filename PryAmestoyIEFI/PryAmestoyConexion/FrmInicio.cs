using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace PryAmestoyConexion
{
    public partial class FrmInicio : Form
    {
        ClsConexion conexion = new ClsConexion();
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.DarkGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if( txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor= Color.DimGray;

            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if(txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor= Color.DarkGray;
                txtContraseña.UseSystemPasswordChar = true;
            }
       
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if(txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor=( Color.DimGray );
                txtContraseña.UseSystemPasswordChar= false;
            }
        }
       
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void btnAcceder_Click(object sender, EventArgs e)
        {
           
          
            string query = "select * from Contactos where Nombre='"+txtUsuario.Text+"'and Contraseña='"+txtContraseña.Text+"'";
          
            SqlCommand Comando = new SqlCommand(query,conexion.Conectar());
            SqlDataReader lector;
            lector = Comando.ExecuteReader();

            if(lector.HasRows == true)
            {
                MessageBox.Show("bienvenido");
                Form Formulario = new FrmPrincipal();
                Formulario.Show();
                
              
            }
            else
            {
                MessageBox.Show("usuario o contraseña incorrectos");
            }
            
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
     
                if (conexion.Conectar().State == ConnectionState.Open)
                {
                    MessageBox.Show("¡Conectado correctamente!");
                }
              
        }
    }
}
