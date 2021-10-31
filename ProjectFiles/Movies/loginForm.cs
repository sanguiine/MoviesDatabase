using System;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Movies
{
    public partial class loginForm : Form
    {
        TheMovieDatabaseDataClassesDataContext db = new TheMovieDatabaseDataClassesDataContext();

        public loginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            SHA512 sha512 = SHA512Managed.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(passwordTextBox.Text);
            byte[] hash = sha512.ComputeHash(bytes);
            String pass = Encoding.Default.GetString(hash);

            var query = from Users in db.Users
                        where Users.Email == emailTextBox.Text && Users.Password == pass
                        select Users;

            if(query.Any())
            {
                errorLabel.Text = "";

                if (query.First().UserType.Equals("user"))
                {
                    Form f = new userForm(query.First().UserID);
                    f.Show();
                    this.Hide();
                }
                else if (query.First().UserType.Equals("admin"))
                {
                    Form f = new adminForm(query.First().UserID);
                    f.Show();
                    this.Hide();
                }
            }
            else
            {
                errorLabel.Text = "Nieprawidłowe dane.";
            }
        }
    }
}
