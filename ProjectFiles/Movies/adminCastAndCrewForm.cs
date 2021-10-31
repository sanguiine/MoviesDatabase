using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Movies
{
    public partial class adminCastAndCrewForm : Form
    {
        TheMovieDatabaseDataClassesDataContext db = new TheMovieDatabaseDataClassesDataContext();

        public adminCastAndCrewForm()
        {
            InitializeComponent();
            refreshGridView();
            refreshComboBox();

            var query = from Movie in db.Movies
                        select new
                        {
                            id = Movie.MovieID,
                            name = Movie.Title
                        };

            movieComboBox.DataSource = query;
            movieComboBox.DisplayMember = "name";
            movieComboBox.ValueMember = "id";
            movieComboBox2.DataSource = query;
            movieComboBox2.DisplayMember = "name";
            movieComboBox2.ValueMember = "id";
        }

        private void refreshGridView()
        {
            var query = from CastAndCrew in db.CastAndCrews
                        select new
                        {
                            CastAndCrew.PersonID,
                            CastAndCrew.FirstName,
                            CastAndCrew.LastName
                        };

            peopleGridView.DataSource = query;
        }

        private void refreshComboBox()
        {
            var query2 = from CastAndCrew in db.CastAndCrews
                         select new
                         {
                             id = CastAndCrew.PersonID,
                             name = CastAndCrew.FirstName + " " + CastAndCrew.LastName
                         };

            peopleComboBox.DataSource = query2;
            peopleComboBox.DisplayMember = "name";
            peopleComboBox.ValueMember = "id";
        }

        private void refreshComboBox2()
        {
            if (roleComboBox2.SelectedItem != null)
            {
                if (roleComboBox2.SelectedItem.Equals("reżyser"))
                {
                    var query = from MovieDirector in db.MovieDirectors
                                join CastAndCrew in db.CastAndCrews on MovieDirector.PersonID equals CastAndCrew.PersonID
                                join Movie in db.Movies on MovieDirector.MovieID equals Movie.MovieID
                                where MovieDirector.MovieID == Convert.ToInt32(movieComboBox2.SelectedValue)
                                select new
                                {
                                    id = CastAndCrew.PersonID,
                                    name = CastAndCrew.FirstName + " " + CastAndCrew.LastName
                                };

                    peopleComboBox2.DataSource = query;
                    peopleComboBox2.DisplayMember = "name";
                    peopleComboBox2.ValueMember = "id";
                }
                else if (roleComboBox2.SelectedItem.Equals("scenarzysta"))
                {
                    var query = from MovieWriter in db.MovieWriters
                                join CastAndCrew in db.CastAndCrews on MovieWriter.PersonID equals CastAndCrew.PersonID
                                join Movie in db.Movies on MovieWriter.MovieID equals Movie.MovieID
                                where MovieWriter.MovieID == Convert.ToInt32(movieComboBox2.SelectedValue)
                                select new
                                {
                                    id = CastAndCrew.PersonID,
                                    name = CastAndCrew.FirstName + " " + CastAndCrew.LastName
                                };

                    peopleComboBox2.DataSource = query;
                    peopleComboBox2.DisplayMember = "name";
                    peopleComboBox2.ValueMember = "id";
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text.Equals("") || lastNameTextBox.Text.Equals(""))
            {
                errorLabel.ForeColor = System.Drawing.Color.Red;
                errorLabel.Text = "Uzupełnij wszystkie pola przed dodaniem.";
            }
            else
            {
                CastAndCrew newPerson = new CastAndCrew();
                newPerson.FirstName = firstNameTextBox.Text;
                newPerson.LastName = lastNameTextBox.Text;
                db.CastAndCrews.InsertOnSubmit(newPerson);

                try
                {
                    db.SubmitChanges();
                    refreshGridView();
                    refreshComboBox();
                    errorLabel.ForeColor = System.Drawing.Color.Black;
                    errorLabel.Text = "Dodano osobę.";
                    firstNameTextBox.Text = "";
                    lastNameTextBox.Text = "";
                }
                catch
                {
                    RejectPendingChanges(db);
                    errorLabel.ForeColor = System.Drawing.Color.Red;
                    errorLabel.Text = "Taka osoba już istnieje.";
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            CastAndCrew editPerson = null;

            if (peopleGridView.SelectedRows.Count == 0)
            {
                errorLabel.ForeColor = System.Drawing.Color.Red;
                errorLabel.Text = "Wybierz osobę z listy.";
            }
            else
            {
                editPerson = db.CastAndCrews.FirstOrDefault(e1 => e1.PersonID == Convert.ToInt32(peopleGridView.CurrentRow.Cells[0].Value));

                if (firstNameTextBox2.Text.Equals("") || lastNameTextBox2.Text.Equals(""))
                {
                    errorLabel.ForeColor = System.Drawing.Color.Red;
                    errorLabel.Text = "Uzupełnij wszystkie pola przed edycją.";
                }
                else
                {
                    editPerson.FirstName = firstNameTextBox2.Text;
                    editPerson.LastName = lastNameTextBox2.Text;

                    try
                    {
                        db.SubmitChanges();
                        refreshGridView();
                        refreshComboBox();
                        refreshComboBox2();
                        errorLabel.ForeColor = System.Drawing.Color.Black;
                        errorLabel.Text = "Edytowano osobę.";
                        firstNameTextBox2.Text = "";
                        lastNameTextBox2.Text = "";
                    }
                    catch
                    {
                        RejectPendingChanges(db);
                        errorLabel.ForeColor = System.Drawing.Color.Red;
                        errorLabel.Text = "Użytkownik z takimi danymi już istnieje.";
                    }
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            CastAndCrew delPerson = null;

            if (peopleGridView.SelectedRows.Count == 0)
            {
                errorLabel.ForeColor = System.Drawing.Color.Red;
                errorLabel.Text = "Wybierz osobę z listy.";
            }
            else
            {
                delPerson = db.CastAndCrews.FirstOrDefault(e1 => e1.PersonID == Convert.ToInt32(peopleGridView.CurrentRow.Cells[0].Value));
                db.CastAndCrews.DeleteOnSubmit(delPerson);

                try
                {
                    db.SubmitChanges();
                    refreshGridView();
                    refreshComboBox();
                    firstNameTextBox2.Text = "";
                    lastNameTextBox2.Text = "";
                    errorLabel.ForeColor = System.Drawing.Color.Black;
                    errorLabel.Text = "Usunięto osobę.";
                }
                catch
                {
                    RejectPendingChanges(db);
                    errorLabel.ForeColor = System.Drawing.Color.Red;
                    errorLabel.Text = "Nie można usunąć osoby, dla której istnieją relacje.";
                }
            }
        }

        private void addButton2_Click(object sender, EventArgs e)
        {
            if(movieComboBox.SelectedItem == null || roleComboBox.SelectedItem == null || peopleComboBox.SelectedItem == null)
            {
                errorLabel.ForeColor = System.Drawing.Color.Red;
                errorLabel.Text = "Uzupełnij puste pola.";
            }
            else
            {
                if (roleComboBox.SelectedItem.Equals("reżyser"))
                {
                    MovieDirectors newDirector = new MovieDirectors();
                    newDirector.MovieID = Convert.ToInt32(movieComboBox.SelectedValue);
                    newDirector.PersonID = Convert.ToInt32(peopleComboBox.SelectedValue);
                    db.MovieDirectors.InsertOnSubmit(newDirector);
                }
                else if (roleComboBox.SelectedItem.Equals("scenarzysta"))
                {
                    MovieWriters newWriter = new MovieWriters();
                    newWriter.MovieID = Convert.ToInt32(movieComboBox.SelectedValue);
                    newWriter.PersonID = Convert.ToInt32(peopleComboBox.SelectedValue);
                    db.MovieWriters.InsertOnSubmit(newWriter);
                }

                try
                {
                    db.SubmitChanges();
                    refreshComboBox2();
                    errorLabel.ForeColor = System.Drawing.Color.Black;
                    errorLabel.Text = "Dodano osobę do filmu.";
                }
                catch
                {
                    RejectPendingChanges(db);
                    errorLabel.ForeColor = System.Drawing.Color.Red;
                    errorLabel.Text = "Taka osoba jest już przypisana do filmu.";
                }
            }
        }

        private void deleteButton2_Click(object sender, EventArgs e)
        {
            if (movieComboBox2.SelectedItem == null || roleComboBox2.SelectedItem == null || peopleComboBox2.SelectedItem == null || roleComboBox2.SelectedItem.Equals(""))
            {
                errorLabel.ForeColor = System.Drawing.Color.Red;
                errorLabel.Text = "Uzupełnij puste pola.";
            }
            else
            {
                if (roleComboBox2.SelectedItem.Equals("reżyser"))
                {
                    MovieDirectors delPerson = db.MovieDirectors.FirstOrDefault(e1 => e1.PersonID == Convert.ToInt32(peopleComboBox2.SelectedValue) && e1.MovieID == Convert.ToInt32(movieComboBox2.SelectedValue));
                    db.MovieDirectors.DeleteOnSubmit(delPerson);
                }
                else if (roleComboBox2.SelectedItem.Equals("scenarzysta"))
                {
                    MovieWriters delPerson = db.MovieWriters.FirstOrDefault(e1 => e1.PersonID == Convert.ToInt32(peopleComboBox2.SelectedValue) && e1.MovieID == Convert.ToInt32(movieComboBox2.SelectedValue));
                    db.MovieWriters.DeleteOnSubmit(delPerson);
                }

                try
                {
                    db.SubmitChanges();
                    refreshComboBox2();
                    errorLabel.ForeColor = System.Drawing.Color.Black;
                    errorLabel.Text = "Usunięto osobę z filmu.";
                }
                catch
                {
                    RejectPendingChanges(db);
                    errorLabel.ForeColor = System.Drawing.Color.Red;
                    errorLabel.Text = "Nie można usunąć osoby.";
                }
            }
        }

        private void people_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CastAndCrew person = db.CastAndCrews.FirstOrDefault(e1 => e1.PersonID == Convert.ToInt32(peopleGridView.CurrentRow.Cells[0].Value));
            firstNameTextBox2.Text = person.FirstName;
            lastNameTextBox2.Text = person.LastName;
        }

        private void peopleGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (peopleGridView.RowCount > 0)
            {
                peopleGridView.Rows[0].Cells[0].Selected = false;
                peopleGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                peopleGridView.Columns[0].Width = 60;
            }
            else
            {
                errorLabel.ForeColor = System.Drawing.Color.Red;
                errorLabel.Text = "Brak użytkowników.";
            }
        }

        private void roleComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roleComboBox2.SelectedItem.Equals("reżyser"))
            {
                var query = from MovieDirector in db.MovieDirectors
                            join CastAndCrew in db.CastAndCrews on MovieDirector.PersonID equals CastAndCrew.PersonID
                            join Movie in db.Movies on MovieDirector.MovieID equals Movie.MovieID
                            where MovieDirector.MovieID == Convert.ToInt32(movieComboBox2.SelectedValue)
                            select new
                            {
                                id = CastAndCrew.PersonID,
                                name = CastAndCrew.FirstName + " " + CastAndCrew.LastName
                            };

                peopleComboBox2.DataSource = query;
                peopleComboBox2.DisplayMember = "name";
                peopleComboBox2.ValueMember = "id";
            }
            else if (roleComboBox2.SelectedItem.Equals("scenarzysta"))
            {
                var query = from MovieWriter in db.MovieWriters
                            join CastAndCrew in db.CastAndCrews on MovieWriter.PersonID equals CastAndCrew.PersonID
                            join Movie in db.Movies on MovieWriter.MovieID equals Movie.MovieID
                            where MovieWriter.MovieID == Convert.ToInt32(movieComboBox2.SelectedValue)
                            select new
                            {
                                id = CastAndCrew.PersonID,
                                name = CastAndCrew.FirstName + " " + CastAndCrew.LastName
                            };

                peopleComboBox2.DataSource = query;
                peopleComboBox2.DisplayMember = "name";
                peopleComboBox2.ValueMember = "id";
            }
        }

        private void movieComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshComboBox2();
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
