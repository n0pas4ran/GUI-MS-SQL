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
    public partial class addParametrsNotion : Form
    {
        string log, pass;
        
        DataTable dt;
        public addParametrsNotion(string login, string password)
        {
            log = login;pass=password;   
            InitializeComponent();
            comboBox1.Items.Clear();
            string connectionString = $"Server=localhost\\SQLEXPRESS;User ID={log};Password={pass};Trusted_Connection=False;DataBase=kadastr;Encrypt=false; TrustServerCertificate=true;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string request = "select Kadastr_nomer_obj, Name from Object";
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

        private void addParametrsNotion_Load(object sender, EventArgs e)
        {

        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            string selected = comboBox1.SelectedItem.ToString();
            string[] subs = selected.Split('(');
            string kno = "";
            foreach(DataRow row in dt.Rows)
            {
                if(row[1].ToString() == subs[0])
                {
                    kno = row[0].ToString();
                }
                    
            }
            Parametrs form = new Parametrs(log, pass);
            form.rb_click = true;
            form.ab_Click(Convert.ToDouble(squareBox.Text), materialBox.Text, Convert.ToInt32(floorsBox.Text), Convert.ToDouble(priceBox.Text), kno);
            this.Close();

        }

       
    }
}
