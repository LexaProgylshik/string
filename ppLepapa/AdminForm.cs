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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            showAdmin();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                Admin admin = listView1.SelectedItems[0].Tag as Admin;
                textBoxФамилия.Text = admin.Фамилия;
                textBoxИмя.Text = admin.Имя;
                textBoxОтчество.Text = admin.Отчество;
            }
            else
            {
                textBoxФамилия.Text = "";
                textBoxИмя.Text = "";
                textBoxОтчество.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxФамилия.Text != null && textBoxИмя.Text != null && textBoxОтчество.Text != null && textBoxЛогин.Text != null && textBoxПароль.Text != null) 
            {
                Admin admin= new Admin();
                admin.Фамилия = textBoxФамилия.Text;
                admin.Имя = textBoxИмя.Text;
                admin.Отчество = textBoxОтчество.Text;
                admin.Логин = textBoxЛогин.Text;
                admin.Пароль = textBoxПароль.Text;
                Program.wtfDb.Admin.Add(admin);
                Program.wtfDb.SaveChanges();
                showAdmin();
            }
            else
            {
                MessageBox.Show("Не все данные введены!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxФамилия.Text != null && textBoxИмя.Text != null && textBoxОтчество.Text != null && textBoxЛогин.Text != null && textBoxПароль.Text != null)
            {
                Admin admin = listView1.SelectedItems[0].Tag as Admin;
                admin.Фамилия = textBoxФамилия.Text;
                admin.Имя = textBoxИмя.Text;
                admin.Отчество = textBoxОтчество.Text;
                admin.Логин = textBoxЛогин.Text;
                admin.Пароль = textBoxПароль.Text;
                Program.wtfDb.SaveChanges();
                showAdmin();
            }
            else
            {
                MessageBox.Show("Не все данные введены!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count == 1)
                {
                    Admin admin = listView1.SelectedItems[0].Tag as Admin;
                    Program.wtfDb.Admin.Remove(admin);
                    Program.wtfDb.SaveChanges();
                    showAdmin();
                }
                textBoxФамилия.Text = "";
                textBoxИмя.Text = "";
                textBoxОтчество.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxФамилия_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
        void showAdmin()
        {
            listView1.Items.Clear();
            foreach (Admin admin in Program.wtfDb.Admin)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        admin.Код_администратора.ToString(),admin.Фамилия, admin.Имя, admin.Отчество
                    });
                item.Tag = admin;
                listView1.Items.Add(item);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}
