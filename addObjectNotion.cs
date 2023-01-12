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
    public partial class addObjectNotion : Form
    {
        string log, pass;
        DataTable dt;
        public addObjectNotion(string login, string password)
        {
            log = login;
            pass = password;
            InitializeComponent();
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

        private void objectAddNotion_Load(object sender, EventArgs e)
        {

        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            string selected = comboBox1.SelectedItem.ToString();
            string knp  = "";
            foreach(DataRow row in dt.Rows)
            {
                if(row[0].ToString() == selected)
                {
                    knp = row[0].ToString();
                }
                    
            }

            Object form = new Object(log, pass);
            form.rb_click = true;
            form.ab_Click(knoBox.Text, vidBox.Text, naznBox.Text, nameBox.Text, Convert.ToInt32(byearBox.Text), Convert.ToInt32(uyearBox.Text), adresBox.Text, knp);
            this.Close();

        }

       
    }
}
