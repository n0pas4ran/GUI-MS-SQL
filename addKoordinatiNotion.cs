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
    public partial class addKoordinatiNotion : Form
    {
        string log, pass;
        DataTable dt;
        public addKoordinatiNotion(string login, string password)
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

        private void addKoordinatiNotion_Load(object sender, EventArgs e)
        {

        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            string knp = comboBox1.SelectedItem.ToString();
            Koordinati form = new Koordinati(log, pass);
            form.rb_click = true;
            form.ab_Click(sistemBox.Text, Convert.ToDouble(x1Box.Text), Convert.ToDouble(y1Box.Text), Convert.ToDouble(x2Box.Text),
                Convert.ToDouble(y2Box.Text), Convert.ToDouble(x3Box.Text), Convert.ToDouble(y3Box.Text), Convert.ToDouble(x4Box.Text),
                Convert.ToDouble(y4Box.Text), knp);
            this.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
