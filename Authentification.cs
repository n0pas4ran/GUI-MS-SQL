using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    public partial class Authentification : Form
    {
        MainPage mainPage;
        public Authentification(MainPage win)
        {
            mainPage = win;
            InitializeComponent();
            this.passBox.KeyPress += new KeyPressEventHandler(keypressed);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((loginBox.Text == "DBadmin" && passBox.Text == "admin") || (loginBox.Text == "DBguest" && passBox.Text == "testpass"))
            {
                mainPage.connection(loginBox.Text, passBox.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Такого пользователя не существует");
                return;
            }

        }

        private void keypressed(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Return)
            {
                if((loginBox.Text == "DBadmin" && passBox.Text == "admin") || (loginBox.Text == "DBguest" && passBox.Text == "testpass"))
                {
                    mainPage.connection(loginBox.Text, passBox.Text);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Такого пользователя не существует");
                    return;
                }
            }
        }
    }
}
