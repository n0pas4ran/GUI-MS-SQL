using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;

namespace client
{
   public partial class Holder
   {
      public bool rb_click = false;
      SqlDataAdapter adapter;
      SqlCommandBuilder commandBuilder;
      string connectionString;
      string log, pass;
      string sql = "SELECT * FROM Holder";
      public Holder(string login, string password)
      {
         connectionString = $"Server=localhost\\SQLEXPRESS;User ID={login};Password={password};Trusted_Connection=False;DataBase=kadastr;Encrypt=false; TrustServerCertificate=true;";
         log = login;
         pass = password;
      }
      public void ab_Click(int inn, string sur, string name, string otch, string ogr, string dop)
      {
         if (rb_click)
         {
            string request = "AddHolder";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
               connection.Open();
               SqlCommand cmd = new SqlCommand(request, connection);
               cmd.CommandType = CommandType.StoredProcedure;
               cmd.Parameters.Add(new SqlParameter("@inn", inn));
               cmd.Parameters.Add(new SqlParameter("@fam", sur));
               cmd.Parameters.Add(new SqlParameter("@name", name));
               cmd.Parameters.Add(new SqlParameter("@sec", otch));
               cmd.Parameters.Add(new SqlParameter("@ogr", ogr));
               cmd.Parameters.Add(new SqlParameter("@dop", dop));
               cmd.ExecuteNonQuery();
            }

         }
         rb_click = false;
      }
      public void db_CLick(int inn)
      {
         string request = "deleteHolder";
         using (SqlConnection connection = new SqlConnection(connectionString))
         {
            connection.Open();
            SqlCommand cmd = new SqlCommand(request, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@inn", inn));
            cmd.ExecuteNonQuery();
         }
      }
      public void ub_Click(int inn, string sur, string name, string otch, string ogr, string dop)
      {
         string request = "UpdateHolder";
         using (SqlConnection connection = new SqlConnection(connectionString))
         {
            connection.Open();
            SqlCommand cmd = new SqlCommand(request, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@inn", inn));
            cmd.Parameters.Add(new SqlParameter("@fam", sur));
            cmd.Parameters.Add(new SqlParameter("@name", name));
            cmd.Parameters.Add(new SqlParameter("@sec", otch));
            cmd.Parameters.Add(new SqlParameter("@ogr", ogr));
            cmd.Parameters.Add(new SqlParameter("@dop", dop));
            cmd.ExecuteNonQuery();
         }
      }
   }
}