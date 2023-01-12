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
   public partial class updateParametrsNotion : Form
   {
      string log, pass, Kno;
      public updateParametrsNotion(string login, string password, string square, string material, string floors, string price, string kno)
      {
         log = login;
         pass = password;
         Kno = kno;
         InitializeComponent();
         squareBox.Text = square;
         materialBox.Text = material;
         floorsBox.Text = floors;
         priceBox.Text = price;
      }

      private void updateParametrsNotion_Load(object sender, EventArgs e)
      {

      }

      private void returnButton_Click(object sender, EventArgs e)
      {
         Parametrs form = new Parametrs(log, pass);
         form.ub_Click(Convert.ToDouble(squareBox.Text), materialBox.Text, Convert.ToInt32(floorsBox.Text), Convert.ToDouble(priceBox.Text), Kno);
         this.Close();
      }

      private void label1_Click(object sender, EventArgs e)
      {

      }

      private void label5_Click(object sender, EventArgs e)
      {

      }
   }
}
