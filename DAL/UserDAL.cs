using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Windows.Input;
using System.IO;
using System.Windows.Forms;

namespace DAL
{
    public class UserDAL
    {
       // #region Methode insert Utilisateur
        public void utilisateur(UserBLL usr)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString)) {

                cnx.Open();
                string query = "INSERT INTO Table User (Nom, Prenom, Ville, Image,Niveau) VALUES (@Nom, @Prenom, @Ville, @Image,@Niveau)";

                using (SqlCommand command = new SqlCommand(query, cnx))
                {
                    // Set values to parameters
                    command.Parameters.AddWithValue("@Nom", "Nom");

                    command.Parameters.AddWithValue("@Prenom", "Prenom");

                    command.Parameters.AddWithValue("@Ville", "Ville");

                    byte[] bytes = File.ReadAllBytes("image.jpg");

                    command.Parameters.AddWithValue("@Image", bytes);

                    command.Parameters.AddWithValue("@Niveau", "Niveau");

                    command.ExecuteNonQuery();

                
                }
            }

        }

    }
}