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
    public partial class FormTeacher : Form
    {
        public FormTeacher()
        {
            InitializeComponent();
            showTeacher();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                Teacher admin = listView1.SelectedItems[0].Tag as Teacher;
                textBoxФамилия.Text = admin.Фамилия;
                textBoxИмя.Text = admin.Имя;
                textBoxОтчество.Text = admin.Отчество;
                textBoxТелефон.Text = admin.Телефон;
                textBoxЭлектроннаяПочта.Text = admin.Электронная_почта;
            }
            else
            {
                textBoxФамилия.Text = "";
                textBoxИмя.Text = "";
                textBoxОтчество.Text = "";
                textBoxТелефон.Text = "";
                textBoxЭлектроннаяПочта.Text = "";
            }


        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxФамилия.Text != null && textBoxИмя.Text != null && textBoxОтчество.Text != null && textBoxЛогин.Text != null && textBoxПароль.Text != null && textBoxТелефон.Text != null && textBoxЭлектроннаяПочта.Text != null)
            {
                Teacher admin = new Teacher();
                admin.Фамилия = textBoxФамилия.Text;
                admin.Имя = textBoxИмя.Text;
                admin.Отчество = textBoxОтчество.Text;
                admin.Логин = textBoxЛогин.Text;
                admin.Пароль = textBoxПароль.Text;
                admin.Телефон = textBoxТелефон.Text;
                admin.Электронная_почта = textBoxЭлектроннаяПочта.Text;
                Program.wtfDb.Teacher.Add(admin);
                Program.wtfDb.SaveChanges();
                showTeacher();
            }
            else
            {
                MessageBox.Show("Не все данные введены!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxФамилия.Text != null && textBoxИмя.Text != null && textBoxОтчество.Text != null && textBoxЛогин.Text != null && textBoxПароль.Text != null && textBoxТелефон.Text != null && textBoxЭлектроннаяПочта.Text != null )
            {
                Teacher admin = listView1.SelectedItems[0].Tag as Teacher;
                admin.Фамилия = textBoxФамилия.Text;
                admin.Имя = textBoxИмя.Text;
                admin.Отчество = textBoxОтчество.Text;
                admin.Логин = textBoxЛогин.Text;
                admin.Пароль = textBoxПароль.Text;
                admin.Телефон = textBoxТелефон.Text;
                admin.Электронная_почта = textBoxЭлектроннаяПочта.Text;
                Program.wtfDb.SaveChanges();
                showTeacher();
            }
            else
            {
                MessageBox.Show("Не все данные введены!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDell_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count == 1)
                {
                    Teacher admin = listView1.SelectedItems[0].Tag as Teacher;
                    Program.wtfDb.Teacher.Remove(admin);
                    Program.wtfDb.SaveChanges();
                    showTeacher();
                }
                textBoxФамилия.Text = "";
                textBoxИмя.Text = "";
                textBoxОтчество.Text = "";
                textBoxТелефон.Text = "";
                textBoxЭлектроннаяПочта.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void showTeacher()
        {
            listView1.Items.Clear();
            foreach (Teacher admin in Program.wtfDb.Teacher)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        admin.Код_учителя.ToString(),admin.Фамилия, admin.Имя, admin.Отчество, admin.Телефон, admin.Электронная_почта
                    });
                item.Tag = admin;
                listView1.Items.Add(item);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}
