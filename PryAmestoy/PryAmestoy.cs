using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryAmestoy
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void CmbSuperheroes_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbSuperheroes.Items.Add("Batman");
            CmbSuperheroes.Items.Add("Superman");
            CmbSuperheroes.Items.Add("Ironman");
            CmbSuperheroes.Items.Add("Spiderman");
            CmbSuperheroes.Items.Add("hulk");

            if ()
            {

            }
        }

    }
}
