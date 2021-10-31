using System;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Movies
{
    public partial class adminUsersForm : Form
    {
        TheMovieDatabaseDataClassesDataContext db = new TheMovieDatabaseDataClassesDataContext();

        public adminUsersForm()
        {
            InitializeComponent();
            refreshGridView();
        }

        private void refreshGridView()
        {
            var query = from User in db.Users
                        select new
                        {
                            User.UserID,
                            User.FirstName,
                            User.Email,
                            User.Password,
                            User.UserType
                        };

            usersGridView.DataSource = query;
        }

        private void usersGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (usersGridView.RowCount > 0)
            {
                usersGridView.Rows[0].Cells[0].Selected = false;
                usersGridView.Columns[3].Visible = false;
                usersGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                usersGridView.Columns[0].Width = 60;
            }
            else
            {
                errorLabel.ForeColor = System.Drawing.Color.Red;
                errorLabel.Text = "Brak użytkowników.";
            }
        }

        private void users_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Users fillUser = db.Users.FirstOrDefault(e1 => e1.UserID == Convert.ToInt32(usersGridView.CurrentRow.Cells[0].Value));
            idLabel.Text = fillUser.UserID.ToString();
            nameTextBox2.Text = fillUser.FirstName;
            emailTextBox2.Text = fillUser.Email;
            typeComboBox2.SelectedItem = fillUser.UserType;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Users editUser = null;

            if (usersGridView.SelectedRows.Count == 0)
            {
                errorLabel.ForeColor = System.Drawing.Color.Red;
                errorLabel.Text = "Wybierz użytkownika z listy.";
            }
            else
            {
                editUser = db.Users.FirstOrDefault(e1 => e1.UserID == Convert.ToInt32(idLabel.Text));

                if (nameTextBox2.Text.Equals("") || emailTextBox2.Text.Equals("") || typeComboBox2.SelectedItem == null)
                {
                    errorLabel.ForeColor = System.Drawing.Color.Red;
                    errorLabel.Text = "Uzupełnij wszystkie pola przed edycją.";
                }
                else
                {
                    editUser.FirstName = nameTextBox2.Text;
                    editUser.Email = emailTextBox2.Text;

                    if (!(passwordTextBox2.Text.Equals("")))
                    {
                        //SHA512 sha512 = SHA512Managed.Create();
                        //byte[] bytes = Encoding.UTF8.GetBytes(passwordTextBox.Text);
                        //byte[] hash = sha512.ComputeHash(bytes);
                        //String pass = Encoding.Default.GetString(hash);
                        editUser.Password = passwordTextBox2.Text;
                    }
                       
                    editUser.UserType = typeComboBox2.SelectedItem.ToString();
                    db.Refresh(System.Data.Linq.RefreshMode.KeepChanges, editUser);

                    try
                    {
                        db.SubmitChanges();
                        refreshGridView();
                        errorLabel.ForeColor = System.Drawing.Color.Black;
                        errorLabel.Text = "Edytowano użytkownika.";
                        idLabel.Text = "brak";
                        nameTextBox2.Text = "";
                        emailTextBox2.Text = "";
                        passwordTextBox2.Text = "";
                    }
                    catch
                    {
                        RejectPendingChanges(db);
                        errorLabel.ForeColor = System.Drawing.Color.Red;
                        errorLabel.Text = "Użytkownik z takim adresem email już istnieje.";
                    }
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Users delUser = null;

            if (usersGridView.SelectedRows.Count == 0)
            {
                errorLabel.ForeColor = System.Drawing.Color.Red;
                errorLabel.Text = "Wybierz użytkownika z listy.";
            }
            else
            {
                delUser = db.Users.FirstOrDefault(e1 => e1.UserID == Convert.ToInt32(idLabel.Text));
                db.Users.DeleteOnSubmit(delUser);
                db.Refresh(System.Data.Linq.RefreshMode.KeepChanges, delUser);

                try
                {
                    db.SubmitChanges();
                    refreshGridView();
                    idLabel.Text = "brak";
                    nameTextBox2.Text = "";
                    emailTextBox2.Text = "";
                    passwordTextBox2.Text = "";
                    errorLabel.ForeColor = System.Drawing.Color.Black;
                    errorLabel.Text = "Usunięto użytkownika.";
                }
                catch
                {
                    RejectPendingChanges(db);
                    errorLabel.ForeColor = System.Drawing.Color.Red;
                    errorLabel.Text = "Nie można usunąć użytkownika, dla którego istnieją relacje.";
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(nameTextBox.Text.Equals("") || emailTextBox.Text.Equals("") || passwordTextBox.Text.Equals("") || typeComboBox.SelectedItem == null)
            {
                errorLabel.ForeColor = System.Drawing.Color.Red;
                errorLabel.Text = "Uzupełnij wszystkie pola przed dodaniem.";
            } 
            else
            {
                Users newUser = new Users();
                newUser.FirstName = nameTextBox.Text;
                newUser.Email = emailTextBox.Text;

                //SHA512 sha512 = SHA512Managed.Create();
                //byte[] bytes = Encoding.UTF8.GetBytes(passwordTextBox.Text);
                //byte[] hash = sha512.ComputeHash(bytes);
                //String pass = Encoding.Default.GetString(hash);

                newUser.Password = passwordTextBox.Text;
                newUser.UserType = typeComboBox.SelectedItem.ToString();
                db.Users.InsertOnSubmit(newUser);

                try
                {
                    db.SubmitChanges();
                    refreshGridView();

                    errorLabel.ForeColor = System.Drawing.Color.Black;
                    errorLabel.Text = "Dodano użytkownika.";
                    nameTextBox.Text = "";
                    emailTextBox.Text = "";
                    passwordTextBox.Text = "";
                }
                catch
                {
                    RejectPendingChanges(db);
                    errorLabel.ForeColor = System.Drawing.Color.Red;
                    errorLabel.Text = "Użytkownik z takim adresem email już istnieje.";
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
