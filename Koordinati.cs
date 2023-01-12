using Microsoft.Data.SqlClient;
using System.Collections.Generic;

using System.Data;

namespace client
{
   public partial class Koordinati : Form
   {
      public bool rb_click = false;
      
      string connectionString;
      string log, pass;
      string sql = "SELECT * FROM Koordinati";
      public Koordinati(string login, string password)
      {
         log = login; pass = password;
         connectionString = $"Server=localhost\\SQLEXPRESS;User ID={login};Password={password};Trusted_Connection=False;DataBase=kadastr;Encrypt=false; TrustServerCertificate=true;";
        
      }

      public void ab_Click(string sistem, double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4, string knp)
      {
         if (rb_click)
         {
            string request = "AddKoordinati";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
               connection.Open();
               SqlCommand cmd = new SqlCommand(request, connection);
               cmd.CommandType = CommandType.StoredProcedure;
               cmd.Parameters.Add(new SqlParameter("@Sistema_koordinat", sistem));
               cmd.Parameters.Add(new SqlParameter("@x1", x1));
               cmd.Parameters.Add(new SqlParameter("@y1", y1));
               cmd.Parameters.Add(new SqlParameter("@x2", x2));
               cmd.Parameters.Add(new SqlParameter("@y2", y2));
               cmd.Parameters.Add(new SqlParameter("@x3", x3));
               cmd.Parameters.Add(new SqlParameter("@y3", y3));
               cmd.Parameters.Add(new SqlParameter("@x4", x4));
               cmd.Parameters.Add(new SqlParameter("@y4", y4));
               cmd.Parameters.Add(new SqlParameter("@KNP", knp));

               cmd.ExecuteNonQuery();
            }

         }
         rb_click = false;
      }

      public void db_CLick(string knp)
      {
         string request = "deleteKoordinati";
         using (SqlConnection connection = new SqlConnection(connectionString))
         {
            connection.Open();
            SqlCommand cmd = new SqlCommand(request, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@knp", knp));
            cmd.ExecuteNonQuery();
         }
      }


      public void ub_Click(string sistem, double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4, string knp)
      {
         string request = "UpdateKoordinati";
         using (SqlConnection connection = new SqlConnection(connectionString))
         {
            connection.Open();
            SqlCommand cmd = new SqlCommand(request, connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@Sistema_koordinat", sistem));
            cmd.Parameters.Add(new SqlParameter("@x1", x1));
            cmd.Parameters.Add(new SqlParameter("@y1", y1));
            cmd.Parameters.Add(new SqlParameter("@x2", x2));
            cmd.Parameters.Add(new SqlParameter("@y2", y2));
            cmd.Parameters.Add(new SqlParameter("@x3", x3));
            cmd.Parameters.Add(new SqlParameter("@y3", y3));
            cmd.Parameters.Add(new SqlParameter("@x4", x4));
            cmd.Parameters.Add(new SqlParameter("@y4", y4));
            cmd.Parameters.Add(new SqlParameter("@KNP", knp));


            cmd.ExecuteNonQuery();
         }
      }
   }
}
