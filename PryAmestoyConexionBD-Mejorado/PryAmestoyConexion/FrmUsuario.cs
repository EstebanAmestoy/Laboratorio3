using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PryAmestoyConexion
{
    public partial class FrmUsuario : Form
    {
        ClsConexion conexion = new ClsConexion();
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void pictureCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            string query = "select * from Contactos";
            SqlDataAdapter AD = new SqlDataAdapter(query, conexion.Conectar());
            DataTable Dt = new DataTable();
            AD.Fill(Dt);
            DgvListado.DataSource = Dt;

        }

        private void DgvListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigoUS.Text = DgvListado.SelectedCells[0].Value.ToString();
            txtNombre.Text = DgvListado.SelectedCells[1].Value.ToString();
            txtDni.Text = DgvListado.SelectedCells[2].Value.ToString();
            txtDireccion.Text = DgvListado.SelectedCells[3].Value.ToString();
            txtContraseña.Text = DgvListado.SelectedCells[4].Value.ToString();
            txtTelefono.Text = DgvListado.SelectedCells[5].Value.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            conexion.Conectar();
            string query = "INSERT INTO Productos Values('" + txtCodigoUS.Text + "','" + txtNombre.Text + "','" + txtDni.Text + "','" + txtDireccion.Text + "','" + txtContraseña.Text + "','" + txtTelefono.Text + "')";
            SqlCommand comando = new SqlCommand(query,conexion.Conectar());
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro Agregado");

            

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conexion.Conectar();
            string query = "DELETE FROM Contactos WHERE CodigoUS = @CodigoUS ";
            SqlCommand comando = new SqlCommand(query, conexion.Conectar());
            comando.Parameters.AddWithValue("@CodigoUS", txtCodigoUS);
            comando.ExecuteNonQuery();
            MessageBox.Show("¡Producto Eliminado!");

        }

        private void pictureMinimizar1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            conexion.Conectar();
            string query = "UPDATE FROM set CodigoUS=" + txtCodigoUS.Text + ",Nombre= '" + txtNombre.Text + "',Dni= '" + txtDni.Text + "' ,Direccion= '" + txtDireccion.Text + "' Contraseña= '" + txtContraseña.Text + "' Telefono= '" + txtTelefono.Text + "' where CodigoUS=" + txtCodigoUS.Text + "";
            SqlCommand comando = new SqlCommand(query, conexion.Conectar());
            int cantidad;
            cantidad = comando.ExecuteNonQuery();
            if(cantidad > 0)
            {
                MessageBox.Show("¡Registro Modificado!");
            }

        }
    }
}
