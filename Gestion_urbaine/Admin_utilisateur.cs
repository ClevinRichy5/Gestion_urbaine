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
    public partial class Admin_utilisateur : Form
    {
        public Admin_utilisateur()
        {
            InitializeComponent();
            Formulaire_utilisateur fu = new Formulaire_utilisateur();
            Administrateur ad = new Administrateur();
        }

        private void btnUtilisateur_Click(object sender, EventArgs e)
        {
            Formulaire_utilisateur fu = new Formulaire_utilisateur();
            fu.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Administrateur ad = new Administrateur();
            ad.Show();
        }
    }
}
