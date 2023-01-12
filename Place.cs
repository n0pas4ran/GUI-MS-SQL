using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;

namespace client
{
   public partial class Place : Form
   {
      public bool rb_click = false;
      
      string connectionString;
      string log, pass;
      string sql = "SELECT * FROM Place";
      public Place(string login, string password)
      {
         connectionString = $"Server=localhost\\SQLEXPRESS;User ID={login};Password={password};Trusted_Connection=False;DataBase=kadastr;Encrypt=false; TrustServerCertificate=true;";
         log = login;
         pass = password;
      }
      public void ab_Click(string knp, double square, int inn)
      {
         if (rb_click)
         {
            string request = "AddPlace";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
               connection.Open();
               SqlCommand cmd = new SqlCommand(request, connection);
               cmd.CommandType = CommandType.StoredProcedure;
               cmd.Parameters.Add(new SqlParameter("@KNP", knp));
               cmd.Parameters.Add(new SqlParameter("@squ", square));
               cmd.Parameters.Add(new SqlParameter("@inn", inn));

               cmd.ExecuteNonQuery();
            }

         }
         rb_click = false;
      }     
      public void db_CLick(string knp)
      {
         string request = "deletePlace";
         using (SqlConnection connection = new SqlConnection(connectionString))
         {
            connection.Open();
            SqlCommand cmd = new SqlCommand(request, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@knp", knp));
            cmd.ExecuteNonQuery();
         }
      }

     
      public void ub_Click(string knp, double square, int inn)
      {
         string request = "UpdatePlace";
         using (SqlConnection connection = new SqlConnection(connectionString))
         {
            connection.Open();
            SqlCommand cmd = new SqlCommand(request, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@KNP", knp));
            cmd.Parameters.Add(new SqlParameter("@squ", square));
            cmd.Parameters.Add(new SqlParameter("@inn", inn));
            cmd.ExecuteNonQuery();
         }
      }
   }
}
