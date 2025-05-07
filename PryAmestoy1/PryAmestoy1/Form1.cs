using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryAmestoy1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbmSuperheroes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbmSuperheroes.Items.Clear();
            cbmSuperheroes.Items.Add("Batman");
            cbmSuperheroes.Items.Add("Superman");
            cbmSuperheroes.Items.Add("Spiderman");
            cbmSuperheroes.Items.Add("Iron man");
            cbmSuperheroes.Items.Add("Hulk");

            string Nombre = cbmSuperheroes.SelectedItem.ToString();

            if( Nombre == "batman")
            {
                
            }



        }
    }
}
