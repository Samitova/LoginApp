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
    public partial class RegisterForm : Form
    {
        UserContext db;

        public RegisterForm()
        {
            InitializeComponent();
            db = new UserContext();
            db.Users.Load();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (textBoxRegPassword.Text == "" || textBoxRegComfPaswd.Text == "" || textBoxRegLogin.Text == "")
                MessageBox.Show("Input information, please.");
            else if (textBoxRegPassword.Text != textBoxRegComfPaswd.Text)
                MessageBox.Show("Wrong password confirmation");
            else if (db.Users.FirstOrDefault(u => u.Login == textBoxRegLogin.Text) != null)
                MessageBox.Show("Such user is existed allready. Choose another login, please.");
            else
            {
                User user = new User();
                user.Login = textBoxRegLogin.Text;
                user.Password = textBoxRegPassword.Text;

                db.Users.Add(user);
                db.SaveChanges();

                MessageBox.Show("Thank you for registration.");
                this.Close();
            }           
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
