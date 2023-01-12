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
   public partial class updateKoordinatiNotion : Form
   {
      string log, pass, Knp;
      public updateKoordinatiNotion(string login, string password, string sistem, string x1, string y1, string x2, string y2,
      string x3, string y3, string x4, string y4, string knp)
      {
         log = login;
         pass = password;
         Knp = knp;
         InitializeComponent();
         sistemBox.Text = sistem;
         x1Box.Text = x1;
         y1Box.Text = y1;
         x2Box.Text = x2;
         y2Box.Text = y2;
         x3Box.Text = x3;
         y3Box.Text = y3;
         x4Box.Text = x4;
         y4Box.Text = y4;
      }

      private void updateKoordinatiNotion_Load(object sender, EventArgs e)
      {

      }

      private void returnButton_Click(object sender, EventArgs e)
      {
         Koordinati form = new Koordinati(log, pass);
         form.ub_Click(sistemBox.Text, Convert.ToDouble(x1Box.Text), Convert.ToDouble(y1Box.Text), Convert.ToDouble(x2Box.Text),
                           Convert.ToDouble(y2Box.Text), Convert.ToDouble(x3Box.Text), Convert.ToDouble(y3Box.Text), Convert.ToDouble(x4Box.Text),
                           Convert.ToDouble(y4Box.Text), Knp);
         this.Close();
      }

      private void label1_Click(object sender, EventArgs e)
      {

      }

      private void textBox5_TextChanged(object sender, EventArgs e)
      {

      }
   }
}
