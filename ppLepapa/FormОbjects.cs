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
    public partial class FormОbjects : Form
    {
        public FormОbjects()
        {
            InitializeComponent();
            ShowTeachers();
            showObjects();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void ShowTeachers()
        {
            comboBoxTeachers.Items.Clear();
            foreach (Teacher teacher in Program.wtfDb.Teacher)
            {
                string[] item = { teacher.Код_учителя.ToString() + ". ", teacher.Фамилия + " " + teacher.Имя + " " + teacher.Отчество };
                comboBoxTeachers.Items.Add(string.Join(" ", item));
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != null && comboBoxTeachers.SelectedItem != null)
            {
                Objects admin = new Objects();
                admin.Код_учителя = Convert.ToInt32(comboBoxTeachers.SelectedItem.ToString().Split('.')[0]);
                admin.Название = textBoxName.Text;
                Program.wtfDb.Objects.Add(admin);
                Program.wtfDb.SaveChanges();
                showObjects();
            }
            else
            {
                MessageBox.Show("Не все данные введены!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != null && comboBoxTeachers.SelectedItem != null)
            {
                Objects admin = listView1.SelectedItems[0].Tag as Objects;
                admin.Код_учителя = Convert.ToInt32(comboBoxTeachers.SelectedItem.ToString().Split('.')[0]);
                admin.Название = textBoxName.Text;
               
                Program.wtfDb.SaveChanges();
                showObjects();
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
                    Objects admin = listView1.SelectedItems[0].Tag as Objects;
                    Program.wtfDb.Objects.Remove(admin);
                    Program.wtfDb.SaveChanges();
                    showObjects();
                }
                
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                Objects admin = listView1.SelectedItems[0].Tag as Objects;
                comboBoxTeachers.SelectedIndex = comboBoxTeachers.FindString(admin.Код_учителя.ToString());
                textBoxName.Text = admin.Название;

            }
            else
            {
                comboBoxTeachers.SelectedItem = null;
                textBoxName.Text = "";
            }

        }
        void showObjects()
        {
            listView1.Items.Clear();
            foreach (Objects admin in Program.wtfDb.Objects)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
admin.Код_предмета.ToString(), admin.Название, admin.Teacher.Фамилия + " " + admin.Teacher.Имя + " " + admin.Teacher.Отчество

                        
                    });
                item.Tag = admin;
                listView1.Items.Add(item);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}
