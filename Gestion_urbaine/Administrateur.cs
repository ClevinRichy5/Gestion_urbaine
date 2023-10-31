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
namespace Gestion_urbaine
{
    public partial class Administrateur : Form
    {
        //private SqlConnection cnx;

        public Administrateur()
        {
            InitializeComponent();
            Regarder();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtid.Text);
            SqlConnection cnx = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mr Richy\Desktop\Projet\Gestion_urbaine\DAL\Commun.mdf;Integrated Security=True");
            cnx.Open();
            SqlCommand commande = new SqlCommand("SELECT * FROM User WHERE Id=@id", cnx);
            commande.Parameters.AddWithValue("@id", id);

            SqlDataReader read = commande.ExecuteReader();

            DataTable table = new DataTable();

            table.Load(read);

            //dataGridView1.DataSource = table;
            dataGridView1.DataSource = table;

            read.Close();
            cnx.Close();
        }
        private void Regarder()
        {

            SqlConnection cnx = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mr Richy\Desktop\Projet\Gestion_urbaine\DAL\Commun.mdf;Integrated Security=True");
            cnx.Open();
            SqlCommand con = new SqlCommand("SELECT * FROM [User] ", cnx);
            SqlDataReader let = con.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(let);
            dataGridView1.DataSource = table;
            let.Close();
            cnx.Close();

        }
    }
}
