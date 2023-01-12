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
   public partial class updateHolderNotion : Form
   {
      string log, pass;
      int Inn;
      public updateHolderNotion(string login ,string password, int inn, string sur, string name, string last, string ogr, string dop)
      {
         log = login;
         pass = password;
         Inn = inn;
         InitializeComponent();
         surBox.Text = sur;
         nameBox.Text = name;
         otchBox.Text = last;
         ogrBox.Text = ogr;
         dopBox.Text = dop;
      }

      private void updateHolderNotion_Load(object sender, EventArgs e)
      {

      }

      private void returnButton_Click(object sender, EventArgs e)
      {
         Holder form = new Holder(log, pass);
         form.ub_Click(Inn, surBox.Text, nameBox.Text, otchBox.Text, ogrBox.Text, dopBox.Text);
         this.Close();
      }
   }
}
