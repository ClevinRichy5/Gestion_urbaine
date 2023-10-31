using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_urbaine
{
    public partial class Accueil : Form
    {
        int progress = 0;
        public Accueil()
        {
            InitializeComponent();
            Admin_utilisateur adm = new Admin_utilisateur();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progress++;
            if (progress <= progressBar1.Maximum)
            {
                progressBar1.Value = progress;
                label1.Text = progressBar1.Value + "%";

                if (progressBar1.Value == 100)
                {
                    Admin_utilisateur adm = new Admin_utilisateur();
                    adm.Show();
                }


            }


        }
    }
}
