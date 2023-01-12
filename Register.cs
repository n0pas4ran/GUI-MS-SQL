using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;

namespace client
{
   public partial class Register : Form
   {
      public bool rb_click = false;
      string connectionString;
      string log, pass;
      string sql = "SELECT * FROM Register";
      public Register(string login, string password)
      {
         log = login;
         pass = password;
         connectionString = $"Server=localhost\\SQLEXPRESS;User ID={login};Password={password};Trusted_Connection=False;DataBase=kadastr;Encrypt=false; TrustServerCertificate=true;";  
      }      
      public void ab_Click(string tip, DateTime date, int inn)
      {
         if (rb_click)
         {
            string request = "AddRegister";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
               connection.Open();
               SqlCommand cmd = new SqlCommand(request, connection);
               cmd.CommandType = CommandType.StoredProcedure;
               cmd.Parameters.Add(new SqlParameter("@Tip", tip));
               cmd.Parameters.Add(new SqlParameter("@Date", date));
               cmd.Parameters.Add(new SqlParameter("@Inn_h", inn));

               cmd.ExecuteNonQuery();
            }

         }
         rb_click = false;
      }      
      public void db_CLick(string inn)
      {
         string request = "deleteRegister";
         using (SqlConnection connection = new SqlConnection(connectionString))
         {
            connection.Open();
            SqlCommand cmd = new SqlCommand(request, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@inn", inn));
            cmd.ExecuteNonQuery();
         }
      }
      public void ub_Click(string tip, DateTime date, int inn)
      {
         string request = "UpdateRegister";
         using (SqlConnection connection = new SqlConnection(connectionString))
         {
            connection.Open();
            SqlCommand cmd = new SqlCommand(request, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Tip", tip));
            cmd.Parameters.Add(new SqlParameter("@Date", date));
            cmd.Parameters.Add(new SqlParameter("@Inn_h", inn));

            cmd.ExecuteNonQuery();
         }
      }
   }
}
