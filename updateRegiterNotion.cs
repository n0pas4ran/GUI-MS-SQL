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
   public partial class updateRegisterNotion : Form
   {
      string log, pass;
      int Inn;
      
      public updateRegisterNotion(string login, string password, string date, string tip, string inn)
      {
         log = login;
         pass = password;
         InitializeComponent();
         Inn = Convert.ToInt32(inn);
         dateBox.Text = date;
         tipBox.Text = tip;
      }

      private void updateRegisterNotion_Load(object sender, EventArgs e)
      {

      }

      private void returnButton_Click(object sender, EventArgs e)
      {
         Register form = new Register(log, pass);
         form.ub_Click(tipBox.Text, DateTime.ParseExact(dateBox.Text, "dd/MM/yyyy", null), Inn);
         this.Close();
      }

      private void label1_Click(object sender, EventArgs e)
      {

      }
   }
}
