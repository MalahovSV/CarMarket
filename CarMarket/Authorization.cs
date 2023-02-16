using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarMarket
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
            loginLabel.BackColor = System.Drawing.Color.Transparent;
            passwordLabel.BackColor = System.Drawing.Color.Transparent;
            aboutDeveloperLabel.BackColor = System.Drawing.Color.Transparent;
        }

        private void passwordCharCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (passwordCharCheck.Checked)
            {
                passwordField.PasswordChar = (char)0;
            } else
            {
                passwordField.PasswordChar = '●';
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(loginField.Text == "admin" && passwordField.Text == "1")
            {
                MainWindow main = new MainWindow(this);
                main.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Логин или пароль не верны!", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
