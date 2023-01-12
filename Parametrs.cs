using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;

namespace client
{
   public partial class Parametrs : Form
   {
      public bool rb_click = false;
      string connectionString;
      string log, pass;
      string sql = "SELECT * FROM Parametrs";
      public Parametrs(string login, string password)
      {
         log = login;
         pass = password;
         connectionString = $"Server=localhost\\SQLEXPRESS;User ID={login};Password={password};Trusted_Connection=False;DataBase=kadastr;Encrypt=false; TrustServerCertificate=true;";
      }
      public void ab_Click(double square, string material, int floors, double price, string kno)
      {
         if (rb_click)
         {
            string request = "AddParametrs";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
               connection.Open();
               SqlCommand cmd = new SqlCommand(request, connection);
               cmd.CommandType = CommandType.StoredProcedure;
               cmd.Parameters.Add(new SqlParameter("@Plowad", square));
               cmd.Parameters.Add(new SqlParameter("@Material", material));
               cmd.Parameters.Add(new SqlParameter("@Floors_number", floors));
               cmd.Parameters.Add(new SqlParameter("@Price", price));
               cmd.Parameters.Add(new SqlParameter("@KNO", kno));

               cmd.ExecuteNonQuery();
            }

         }
         rb_click = false;
      }

      public void db_CLick(string kno)
      {
         string request = "deleteParametrs";
         using (SqlConnection connection = new SqlConnection(connectionString))
         {
            connection.Open();
            SqlCommand cmd = new SqlCommand(request, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@kno", kno));
            cmd.ExecuteNonQuery();
         }
      }

      public void ub_Click(double square, string material, int floors, double price, string kno)
      {
         string request = "UpdateParametrs";
         using (SqlConnection connection = new SqlConnection(connectionString))
         {
            connection.Open();
            SqlCommand cmd = new SqlCommand(request, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Plowad", square));
            cmd.Parameters.Add(new SqlParameter("@Material", material));
            cmd.Parameters.Add(new SqlParameter("@Floors_number", floors));
            cmd.Parameters.Add(new SqlParameter("@Price", price));
            cmd.Parameters.Add(new SqlParameter("@KNO", kno));
            cmd.ExecuteNonQuery();
         }
      }
   }
}
