using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace client
{
   public partial class updatePlaceNotion : Form
   {
      string log, pass, Knp; 
      DataTable dt;       
      public updatePlaceNotion(string login, string password, string knp, string square, string inn)
      {
         log = login;
         pass = password;
         Knp = knp;            
         InitializeComponent();
         squareBox.Text = square;
         comboBox1.Items.Clear();
         string connectionString = $"Server=localhost\\SQLEXPRESS;User ID={log};Password={pass};Trusted_Connection=False;DataBase=kadastr;Encrypt=false; TrustServerCertificate=true;";
         using (SqlConnection conn = new SqlConnection(connectionString))
         {
             conn.Open();
             string request = "select Inn, Familia from Holder";
             SqlCommand cmd = new SqlCommand(request, conn);
             cmd.ExecuteNonQuery();
             SqlDataAdapter adapter = new SqlDataAdapter(request, conn);
             dt = new DataTable();
             adapter.Fill(dt);
             foreach(DataRow row in dt.Rows)
             {
                 comboBox1.Items.Add(row[1] + "("+row[0]+")");
             }
         }

      }

      private void updatePlaceNotion_Load(object sender, EventArgs e)
      {

      }

      private void returnButton_Click(object sender, EventArgs e)
      {
         string selected = comboBox1.SelectedItem.ToString();
            string[] subs = selected.Split('(');
            int inn = 0;
            foreach(DataRow row in dt.Rows)
            {
                if(row[1].ToString() == subs[0])
                {
                    inn = Convert.ToInt32(row[0]);
                }
                    
            }
         Place form = new Place(log, pass);
         form.ub_Click(Knp, Convert.ToDouble(squareBox.Text), inn);
         this.Close();
      }

      private void label1_Click(object sender, EventArgs e)
      {

      }
   }
}
