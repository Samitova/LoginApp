using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class MainForm : Form
    {
        UserContext db;

        public MainForm()
        {
            InitializeComponent();
            this.Text = "Login Form";
            this.StartPosition = FormStartPosition.CenterScreen;
            db = new UserContext();
            db.Users.Load();
           
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "")
            {
                MessageBox.Show("Enter login, please.");
            }
            else if (textBoxPassword.Text == "")
            {
                MessageBox.Show("Enter password, please.");
            }
            else
            {
                User user = db.Users
                    .FirstOrDefault(u => u.Login == textBoxLogin.Text.Trim() && u.Password == textBoxPassword.Text.Trim());
                if (user != null)
                {
                    LoggedForm loggedForm = new LoggedForm();                    
                    loggedForm.StartPosition = FormStartPosition.CenterScreen;
                    loggedForm.dataGridView1.DataSource = db.Users.Local.ToBindingList();
                    loggedForm.Show();
                }
                else
                    MessageBox.Show("No such user, register first.");
            }

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.StartPosition = FormStartPosition.CenterScreen;
            regForm.Show();             
        }
    }
}
