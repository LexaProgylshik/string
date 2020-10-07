using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ppLepapa
  
{
    public struct User
    {
        public string login;
        public string password;
        public string type;
    }
    public partial class Form1 : Form
    {
        public static User users = new User();
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "" && textBoxPassword.Text == "")
            {
                MessageBox.Show("Введите данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool key = false;
                foreach (Admin user in Program.wtfDb.Admin)
                {
                    if (textBoxLogin.Text == user.Логин && textBoxPassword.Text == user.Пароль)
                    {
                        key = true;
                        users.login = user.Логин;
                        users.password = user.Пароль;
                        users.type = "Admin";
                    }
                }
                foreach (Teacher user in Program.wtfDb.Teacher)
                {
                    if (textBoxLogin.Text == user.Логин && textBoxPassword.Text == user.Пароль)
                    {
                        key = true;
                        users.login = user.Логин;
                        users.password = user.Пароль;
                        users.type = "Teacher";
                    }
                }
                if (!key)
                {
                    MessageBox.Show("Проверьте данные", "Пользователь не найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Menu menu = new Menu();
                    menu.Show();
                    this.Hide();
                }
            }
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
