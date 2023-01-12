using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;

namespace client
{
   public partial class Object : Form
   {
      public bool rb_click = false;
      
      string connectionString;
      string log, pass;
      string sql = "SELECT * FROM Object";
      public Object(string login, string password)
      {
         log = login;
         pass = password;
         connectionString = $"Server=localhost\\SQLEXPRESS;User ID={login};Password={password};Trusted_Connection=False;DataBase=kadastr;Encrypt=false; TrustServerCertificate=true;";
      }

      public void ab_Click(string kno, string vid, string nazn, string name, int byear, int uyear, string adres, string knp)
      {
         if (rb_click)
         {
            string request = "AddObject";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
               Console.WriteLine(kno);
               Console.WriteLine(knp);
               Console.WriteLine(byear);
               Console.WriteLine(uyear);
               connection.Open();
               SqlCommand cmd = new SqlCommand(request, connection);
               cmd.CommandType = CommandType.StoredProcedure;
               cmd.Parameters.Add(new SqlParameter("@Kadastr_nomer_obj", kno));
               cmd.Parameters.Add(new SqlParameter("@Vid", vid));
               cmd.Parameters.Add(new SqlParameter("@Nazna4enie", nazn));
               cmd.Parameters.Add(new SqlParameter("@Name", name));
               cmd.Parameters.Add(new SqlParameter("@Build_year", byear));
               cmd.Parameters.Add(new SqlParameter("@Use_year", uyear));
               cmd.Parameters.Add(new SqlParameter("@Adres", adres));
               cmd.Parameters.Add(new SqlParameter("@KNP", knp));

               cmd.ExecuteNonQuery();
            }

         }
         rb_click = false;
      }

      public void db_CLick(string kno)
      {
         string request = "deleteObject";
         using (SqlConnection connection = new SqlConnection(connectionString))
         {
            connection.Open();
            SqlCommand cmd = new SqlCommand(request, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@kno", kno));
            cmd.ExecuteNonQuery();
         }
      }

      public void ub_Click(string kno, string vid, string nazn, string name, int byear, int uyear, string adres, string knp)
      {
         string request = "UpdateObject";
         using (SqlConnection connection = new SqlConnection(connectionString))
         {
            connection.Open();
            SqlCommand cmd = new SqlCommand(request, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Kadastr_nomer_obj", kno));
            cmd.Parameters.Add(new SqlParameter("@Vid", vid));
            cmd.Parameters.Add(new SqlParameter("@Nazna4enie", nazn));
            cmd.Parameters.Add(new SqlParameter("@Name", name));
            cmd.Parameters.Add(new SqlParameter("@Build_year", byear));
            cmd.Parameters.Add(new SqlParameter("@Use_year", uyear));
            cmd.Parameters.Add(new SqlParameter("@Adres", adres));
            cmd.Parameters.Add(new SqlParameter("@KNP", knp));


            cmd.ExecuteNonQuery();
         }
      }
   }
}
