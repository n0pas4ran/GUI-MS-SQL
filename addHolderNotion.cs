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
    public partial class addHolderNotion : Form
    {
        string log, pass;
        public addHolderNotion(string login, string password)
        {
            log = login;
            pass = password;
            InitializeComponent();
        }

        private void holderAddNotion_Load(object sender, EventArgs e)
        {

        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            Holder form = new Holder(log, pass);
            form.rb_click = true;
            form.ab_Click(Convert.ToInt32(innBox.Text), surBox.Text, nameBox.Text, otchBox.Text, ogrBox.Text, dopBox.Text);
            this.Close();
         

      }

       
    }
}
