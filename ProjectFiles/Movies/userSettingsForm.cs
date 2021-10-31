using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Movies
{
    public partial class userSettingsForm : Form
    {
        TheMovieDatabaseDataClassesDataContext db = new TheMovieDatabaseDataClassesDataContext();
        private int currentID;

        public userSettingsForm(int userID)
        {
            InitializeComponent();
            currentID = userID;
            Users user = db.Users.FirstOrDefault(e => e.UserID.Equals(currentID));
            nameTextBox.Text = user.FirstName;
            emailTextBox.Text = user.Email;
            errorLabel.Text = "";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Users editUser = db.Users.FirstOrDefault(e1 => e1.UserID.Equals(currentID));

            if (nameTextBox.Text.Equals("") || emailTextBox.Text.Equals(""))
            {
                errorLabel.ForeColor = System.Drawing.Color.Red;
                errorLabel.Text = "Uzupełnij imię i email przed dodaniem.";
            }
            else
            {
                editUser.FirstName = nameTextBox.Text;
                editUser.Email = emailTextBox.Text;

                if (!(passwordTextBox.Text.Equals("")))
                {
                    //SHA512 sha512 = SHA512Managed.Create();
                    //byte[] bytes = Encoding.UTF8.GetBytes(passwordTextBox.Text);
                    //byte[] hash = sha512.ComputeHash(bytes);
                    //String pass = Encoding.Default.GetString(hash);
                    editUser.Password = passwordTextBox.Text;
                }
                
                int rowsUpdated = db.GetChangeSet().Updates.Count;
                db.Refresh(System.Data.Linq.RefreshMode.KeepChanges, editUser);

                try
                {
                    db.SubmitChanges();

                    if (rowsUpdated == 0)
                    {
                        errorLabel.ForeColor = System.Drawing.Color.Black;
                        errorLabel.Text = "Brak zmian.";
                    }
                    else
                    {
                        errorLabel.ForeColor = System.Drawing.Color.Black;
                        errorLabel.Text = "Zapisano zmiany.";
                    }
                }
                catch
                {
                    RejectPendingChanges(db);
                    errorLabel.ForeColor = System.Drawing.Color.Red;
                    errorLabel.Text = "Taki email już istnieje.";
                }
            }
        }

        private void RejectPendingChanges(TheMovieDatabaseDataClassesDataContext db)
        {
            var chgset = db.GetChangeSet();

            if (chgset != null)
            {
                foreach (object objToInsert in chgset.Inserts)
                {
                    db.GetTable(objToInsert.GetType()).DeleteOnSubmit(objToInsert);
                }

                foreach (object objToDelete in chgset.Deletes)
                {
                    db.GetTable(objToDelete.GetType()).InsertOnSubmit(objToDelete);
                }

                db.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, chgset.Updates);
            }
        }
    }
}
