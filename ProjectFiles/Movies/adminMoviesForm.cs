using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Movies
{
    public partial class adminMoviesForm : Form
    {
        TheMovieDatabaseDataClassesDataContext db = new TheMovieDatabaseDataClassesDataContext();

        public adminMoviesForm()
        {
            InitializeComponent();
            refreshGridView();
        }

        public static byte[] ImageToByteArray(Image imageIn)
        {
            var ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }

        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            var ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void refreshGridView()
        {
            var query = from Movie in db.Movies
                        select new
                        {
                            Movie.MovieID,
                            Movie.Title,
                            Movie.ReleaseDate
                        };

            moviesGridView.DataSource = query;
        }

        private void addPosterButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    posterPictureBox.Load(openFileDialog.FileName);
                    errorLabel.ForeColor = System.Drawing.Color.Black;
                    errorLabel.Text = "";
                }
                catch
                {
                    errorLabel.ForeColor = System.Drawing.Color.Red;
                    errorLabel.Text = "Niepoprawny format pliku.";
                }
            }
        }

        private void changePosterButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    posterPictureBox2.Load(openFileDialog.FileName);
                    errorLabel.ForeColor = System.Drawing.Color.Black;
                    errorLabel.Text = "";
                }
                catch
                {
                    errorLabel.ForeColor = System.Drawing.Color.Red;
                    errorLabel.Text = "Niepoprawny format pliku.";
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (titleTextBox.Text.Equals("") || descriptionTextBox.Text.Equals(""))
            {
                errorLabel.ForeColor = System.Drawing.Color.Red;
                errorLabel.Text = "Uzupełnij puste pola.";
            }
            else
            {
                Movies newMovie = new Movies();
                newMovie.Title = titleTextBox.Text;
                newMovie.Overview = descriptionTextBox.Text;
                newMovie.ReleaseDate = dateTimePicker.Value;

                if (posterPictureBox.Image != null)
                {
                    byte[] img = ImageToByteArray(posterPictureBox.Image);
                    newMovie.Cover = img;
                }

                db.Movies.InsertOnSubmit(newMovie);

                try
                {
                    db.SubmitChanges();
                    refreshGridView();
                    errorLabel.ForeColor = System.Drawing.Color.Black;
                    errorLabel.Text = "Dodano film.";
                    titleTextBox.Text = "";
                    descriptionTextBox.Text = "";
                    posterPictureBox.Image = null;
                }
                catch
                {
                    RejectPendingChanges(db);
                    errorLabel.ForeColor = System.Drawing.Color.Red;
                    errorLabel.Text = "Taki film już istnieje.";
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Movies editMovie = null;

            if (moviesGridView.SelectedRows.Count == 0)
            {
                errorLabel.ForeColor = System.Drawing.Color.Red;
                errorLabel.Text = "Wybierz film z listy.";
            }
            else
            {
                editMovie = db.Movies.FirstOrDefault(e1 => e1.MovieID == Convert.ToInt32(moviesGridView.CurrentRow.Cells[0].Value));

                if (titleTextBox2.Text.Equals("") || descriptionTextBox2.Text.Equals(""))
                {
                    errorLabel.ForeColor = System.Drawing.Color.Red;
                    errorLabel.Text = "Uzupełnij wszystkie pola przed edycją.";
                }
                else
                {
                    editMovie.Title = titleTextBox2.Text;
                    editMovie.Overview = descriptionTextBox2.Text;
                    editMovie.ReleaseDate = dateTimePicker2.Value;

                    if (posterPictureBox2.Image != null)
                    {
                        byte[] img = ImageToByteArray(posterPictureBox2.Image);
                        editMovie.Cover = img;
                    }

                    try
                    {
                        db.SubmitChanges();
                        refreshGridView();
                        errorLabel.ForeColor = System.Drawing.Color.Black;
                        errorLabel.Text = "Edytowano film.";
                        titleTextBox2.Text = "";
                        descriptionTextBox2.Text = "";
                        posterPictureBox2.Image = null;
                    }
                    catch
                    {
                        RejectPendingChanges(db);
                        errorLabel.ForeColor = System.Drawing.Color.Red;
                        errorLabel.Text = "Taki film już istnieje.";
                    }
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Movies delMovie = null;

            if (moviesGridView.SelectedRows.Count == 0)
            {
                errorLabel.ForeColor = System.Drawing.Color.Red;
                errorLabel.Text = "Wybierz film z listy.";
            }
            else
            {
                delMovie = db.Movies.FirstOrDefault(e1 => e1.MovieID == Convert.ToInt32(moviesGridView.CurrentRow.Cells[0].Value));
                db.Movies.DeleteOnSubmit(delMovie);

                try
                {
                    db.SubmitChanges();
                    refreshGridView();
                    errorLabel.ForeColor = System.Drawing.Color.Black;
                    errorLabel.Text = "Usunięto film.";
                    titleTextBox2.Text = "";
                    descriptionTextBox2.Text = "";
                    posterPictureBox2.Image = null;
                }
                catch
                {
                    RejectPendingChanges(db);
                    errorLabel.ForeColor = System.Drawing.Color.Red;
                    errorLabel.Text = "Nie można usunąć filmu, dla którego istnieją relacje.";
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

        private void moviesGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (moviesGridView.RowCount > 0)
            {
                moviesGridView.Rows[0].Cells[0].Selected = false;
                moviesGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                moviesGridView.Columns[0].Width = 50;
                moviesGridView.Columns[2].Width = 70;
            }
            else
            {
                errorLabel.ForeColor = System.Drawing.Color.Red;
                errorLabel.Text = "Brak filmów.";
            }
        }

        private void moviesGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Movies fillMovie = db.Movies.FirstOrDefault(e1 => e1.MovieID == Convert.ToInt32(moviesGridView.CurrentRow.Cells[0].Value));
            titleTextBox2.Text = fillMovie.Title;
            descriptionTextBox2.Text = fillMovie.Overview;
            dateTimePicker2.Value = fillMovie.ReleaseDate;
            
            if(fillMovie.Cover != null)
            {
                posterPictureBox2.Image = ByteArrayToImage(fillMovie.Cover.ToArray());
            }
            
        }
    }
}
