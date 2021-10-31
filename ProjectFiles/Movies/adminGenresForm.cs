using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Movies
{
    public partial class adminGenresForm : Form
    {
        TheMovieDatabaseDataClassesDataContext db = new TheMovieDatabaseDataClassesDataContext();

        public adminGenresForm()
        {
            InitializeComponent();
            refreshComboBox();
            refreshMovieComboBox();

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

        private void refreshComboBox()
        {
            var query = from Genre in db.Genres
                        select new
                        {
                            id = Genre.GenreID,
                            name = Genre.Name
                        };

            genresComboBox.DataSource = query;
            genresComboBox.DisplayMember = "name";
            genresComboBox.ValueMember = "id";
            nameTextBox2.Text = "";

            genresComboBox2.DataSource = query;
            genresComboBox2.DisplayMember = "name";
            genresComboBox2.ValueMember = "id";
        }

        private void refreshMovieComboBox()
        {
            var query = from Genre in db.Genres
                        join MovieGenre in db.MovieGenres on Genre.GenreID equals MovieGenre.GenreID
                        where MovieGenre.MovieID == Convert.ToInt32(movieComboBox2.SelectedValue)
                        select new
                        {
                            id = Genre.GenreID,
                            name = Genre.Name
                        };

            genresComboBox3.DataSource = query;
            genresComboBox3.DisplayMember = "name";
            genresComboBox3.ValueMember = "id";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Equals(""))
            {
                errorLabel.ForeColor = System.Drawing.Color.Red;
                errorLabel.Text = "Uzupełnij wszystkie pola przed dodaniem.";
            }
            else
            {
                Genres newGenre = new Genres();
                newGenre.Name = nameTextBox.Text;
                db.Genres.InsertOnSubmit(newGenre);

                try
                {
                    db.SubmitChanges();
                    refreshComboBox();
                    errorLabel.ForeColor = System.Drawing.Color.Black;
                    errorLabel.Text = "Dodano gatunek.";
                    nameTextBox.Text = "";
                }
                catch
                {
                    RejectPendingChanges(db);
                    errorLabel.ForeColor = System.Drawing.Color.Red;
                    errorLabel.Text = "Taki gatunek już istnieje.";
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox2.Text.Equals(""))
            {
                errorLabel.ForeColor = System.Drawing.Color.Red;
                errorLabel.Text = "Wybierz gatunek z listy i nie zostawiaj pustej nazwy.";
            }
            else
            {
                Genres editGenre = db.Genres.FirstOrDefault(e1 => e1.GenreID == Convert.ToInt32(genresComboBox.SelectedValue));
                editGenre.Name = nameTextBox2.Text;
                
                try
                {
                    db.SubmitChanges();
                    refreshComboBox();
                    errorLabel.ForeColor = System.Drawing.Color.Black;
                    errorLabel.Text = "Edytowano gatunek.";

                }
                catch
                {
                    RejectPendingChanges(db);
                    errorLabel.ForeColor = System.Drawing.Color.Red;
                    errorLabel.Text = "Taki gatunek już istnieje.";
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox2.Text.Equals(""))
            {
                errorLabel.ForeColor = System.Drawing.Color.Red;
                errorLabel.Text = "Wybierz gatunek z listy.";
            }
            else
            {
                Genres delGenre = db.Genres.FirstOrDefault(e1 => e1.GenreID == Convert.ToInt32(genresComboBox.SelectedValue));
                db.Genres.DeleteOnSubmit(delGenre);
                
                try
                {
                    db.SubmitChanges();
                    refreshComboBox();
                    errorLabel.ForeColor = System.Drawing.Color.Black;
                    errorLabel.Text = "Usunięto gatunek.";

                }
                catch
                {
                    RejectPendingChanges(db);
                    errorLabel.ForeColor = System.Drawing.Color.Red;
                    errorLabel.Text = "Nie można usunąć gatunku, dla którego istnieją relacje.";
                }
            }
        }

        private void genresComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            nameTextBox2.Text = genresComboBox.Text;
        }

        private void addButton2_Click(object sender, EventArgs e)
        {
            MovieGenres newItem = new MovieGenres();
            newItem.MovieID = Convert.ToInt32(movieComboBox.SelectedValue);
            newItem.GenreID = Convert.ToInt32(genresComboBox2.SelectedValue);
            db.MovieGenres.InsertOnSubmit(newItem);

            try
            {
                db.SubmitChanges();
                refreshMovieComboBox();
                errorLabel.ForeColor = System.Drawing.Color.Black;
                errorLabel.Text = "Dodano gatunek do filmu.";
            }
            catch
            {
                RejectPendingChanges(db);
                errorLabel.ForeColor = System.Drawing.Color.Red;
                errorLabel.Text = "Taki gatunek jest już dodany.";
            }
        }

        private void deleteButton2_Click(object sender, EventArgs e)
        {
            MovieGenres delItem = db.MovieGenres.FirstOrDefault(e1 => e1.MovieID == Convert.ToInt32(movieComboBox2.SelectedValue) && e1.GenreID == Convert.ToInt32(genresComboBox3.SelectedValue));
            db.MovieGenres.DeleteOnSubmit(delItem);
            db.SubmitChanges();
            refreshMovieComboBox();
            errorLabel.ForeColor = System.Drawing.Color.Black;
            errorLabel.Text = "Usunięto gatunek z filmu.";
        }

        private void movieComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshMovieComboBox();
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
