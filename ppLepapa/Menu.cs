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
    public partial class Menu : Form
    {
        public Menu()
        {

            InitializeComponent();
            if (Form1.users.type == "Teacher")
            {
                buttonAdmin.Enabled = false;
                buttonTeacher.Enabled = false;
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            Form formadmin = new AdminForm();
            formadmin.Show();

        }

        private void buttonTeacher_Click(object sender, EventArgs e)
        {
            Form formteacher = new FormTeacher();
            formteacher.Show();
        }

        private void buttonObject_Click(object sender, EventArgs e)
        {
            Form formobject = new FormОbjects();
            formobject.Show();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
