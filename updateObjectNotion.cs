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
   public partial class updateObjectNotion : Form
   {
      string log, pass, Kno, Knp;
      DataTable dt;
      public updateObjectNotion(string login, string password, string kno, string vid, string nazn, string name, string byear, string uyear, string adres, string knp)
      {
         log = login;pass = password;
         Kno = kno;
         Knp = knp;
         InitializeComponent();
         vidBox.Text = vid;
         naznBox.Text = nazn;
         nameBox.Text = name;
         byearBox.Text = byear;
         uyearBox.Text = uyear;
         adresBox.Text = adres;
         comboBox1.Items.Clear();
         string connectionString = $"Server=localhost\\SQLEXPRESS;User ID={log};Password={pass};Trusted_Connection=False;DataBase=kadastr;Encrypt=false; TrustServerCertificate=true;";
         using (SqlConnection conn = new SqlConnection(connectionString))
         {
            conn.Open();
            string request = "select Kadastr_nomer from Place";
            SqlCommand cmd = new SqlCommand(request, conn);
            cmd.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(request, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            foreach(DataRow row in dt.Rows)
            {
              comboBox1.Items.Add(row[0]);
            }
         }
      }

      private void updateObjectNotion_Load(object sender, EventArgs e)
      {

      }

      private void returnButton_Click(object sender, EventArgs e)
      {
         string knp = comboBox1.SelectedItem.ToString();
         Object form = new Object(log, pass);
         form.ub_Click(Kno, vidBox.Text, naznBox.Text, nameBox.Text, Convert.ToInt32(byearBox.Text), Convert.ToInt32(uyearBox.Text), adresBox.Text, Knp);
         this.Close();
      }
   }
}
