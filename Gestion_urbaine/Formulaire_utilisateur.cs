using System;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;



namespace Gestion_urbaine
{
    public partial class Formulaire_utilisateur : Form
    {
        public Formulaire_utilisateur()
        {
            InitializeComponent();
        }

        private void btnimage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();


            openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

                pictureBox2.Image = new Bitmap(openFileDialog.FileName);

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "") {

                MessageBox.Show("Echec! veillez entree des information");

            }
            else
            {

                try
                {

                    using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
                    {

                        cnx.Open();


                    }
                }
                finally
                {

                }
                    

                }
        }
        }
    }


