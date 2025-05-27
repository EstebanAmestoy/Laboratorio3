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
    public partial class FrmStock : Form
    {
        public FrmStock()
        {
            InitializeComponent();
        }
        ClsConexion conexion = new ClsConexion();
        private void DgvStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtCodigoS.Text = DgvStock.SelectedCells[0].Value.ToString();
            TxtNombreS.Text = DgvStock.SelectedCells[1].Value.ToString();
            TxtDescripcionS.Text = DgvStock.SelectedCells[2].Value.ToString();
            TxtPrecioS.Text = DgvStock.SelectedCells[3].Value.ToString();
            TxtStockS.Text = DgvStock.SelectedCells[4].Value.ToString();
            TxtCategoriaS.Text = DgvStock.SelectedCells[5].Value.ToString();
        }

        private void FrmStock_Load(object sender, EventArgs e)
        {
            string query = "select * from Productos";
            SqlDataAdapter AD = new SqlDataAdapter(query, conexion.Conectar());
            DataTable Dt = new DataTable();
            AD.Fill(Dt);
            DgvStock.DataSource = Dt;
        }

        private void BtnAgregarS_Click(object sender, EventArgs e)
        {
            conexion.Conectar();
            string query = "INSERT INTO Contactos Values('" + TxtCodigoS.Text + "','" + TxtNombreS.Text + "','" + TxtDescripcionS.Text + "','" + TxtPrecioS.Text + "','" + TxtStockS.Text + "','" + TxtCategoriaS.Text + "')";
            SqlCommand comando = new SqlCommand(query, conexion.Conectar());
            comando.ExecuteNonQuery();
            MessageBox.Show("¡Registro Agregado!");

        }

        private void BtnEliminarS_Click(object sender, EventArgs e)
        {
            conexion.Conectar();
            string query = "DELETE FROM Productos WHERE Codigo = @Codigo ";
            SqlCommand comando = new SqlCommand(query, conexion.Conectar());
            comando.Parameters.AddWithValue("@Codigo", TxtCodigoS);
            comando.ExecuteNonQuery();
            MessageBox.Show("¡Producto Eliminado!");
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
