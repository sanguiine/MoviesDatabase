using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Movies
{
    public partial class userSearchForm : Form
    {
        TheMovieDatabaseDataClassesDataContext db = new TheMovieDatabaseDataClassesDataContext();
        private Form activeForm = null;
        private int currentID;

        public userSearchForm(int userID)
        {
            InitializeComponent();
            currentID = userID;

            var query = from Genre in db.Genres
                        select new
                        {
                            id = Genre.GenreID,
                            name = Genre.Name
                        };

            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("name", typeof(String));
            DataRow dr = dt.NewRow();
            dr[0] = -1;
            dr[1] = "-";
            dt.Rows.InsertAt(dr, 0);

            foreach (var item in query)
            {
                dt.Rows.Add(item.id, item.name);
            }

            genreComboBox.DataSource = dt;
            genreComboBox.DisplayMember = "name";
            genreComboBox.ValueMember = "id";

            var query2 = from Movie in db.Movies
                        select new
                        {
                            Movie.MovieID,
                            Movie.ReleaseDate.Year,
                            Movie.Title
                        };

            searchGridView.DataSource = query2;
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(childForm);
            mainPanel.Tag = childForm;
            mainPanel.BringToFront();
            mainPanel.Visible = true;
            childForm.Show();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(genreComboBox.SelectedValue) == -1)
            {
                var query = from Movie in db.Movies
                            where Movie.Title.StartsWith(titleTextBox.Text)
                            select new
                            {
                                Movie.MovieID,
                                Movie.ReleaseDate.Year,
                                Movie.Title
                            };

                searchGridView.DataSource = query;
            }
            else
            {
                var query = from Movie in db.Movies
                            join Genre in db.MovieGenres
                            on Movie.MovieID equals Genre.MovieID
                            where Movie.Title.StartsWith(titleTextBox.Text) && Genre.GenreID == Convert.ToInt32(genreComboBox.SelectedValue)
                            select new
                            {
                                Movie.MovieID,
                                Movie.ReleaseDate.Year,
                                Movie.Title
                            };

                searchGridView.DataSource = query;
            }
        }

        private void search_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int movieID = Convert.ToInt32(searchGridView.CurrentRow.Cells[0].Value);
            openChildForm(new userMovie(currentID, movieID, mainPanel, searchGridView, null));
        }

        private void searchGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (searchGridView.RowCount > 0)
            {
                searchGridView.Rows[0].Cells[0].Selected = false;
                searchGridView.Columns[0].Visible = false;
                searchGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                searchGridView.Columns[1].Width = 70;
                errorLabel.Text = "";
            }
            else
            {
                errorLabel.Text = "Brak wyników o podanych kryteriach.";
            }
        }

        private void nameAsc_Click(object sender, EventArgs e)
        {
            searchGridView.Sort(searchGridView.Columns[2], ListSortDirection.Ascending);
            searchGridView.Rows[0].Cells[0].Selected = false;
        }

        private void nameDesc_Click(object sender, EventArgs e)
        {
            searchGridView.Sort(searchGridView.Columns[2], ListSortDirection.Descending);
            searchGridView.Rows[0].Cells[0].Selected = false;
        }

        private void yearAsc_Click(object sender, EventArgs e)
        {
            searchGridView.Sort(searchGridView.Columns[1], ListSortDirection.Ascending);
            searchGridView.Rows[0].Cells[0].Selected = false;
        }

        private void yearDesc_Click(object sender, EventArgs e)
        {
            searchGridView.Sort(searchGridView.Columns[1], ListSortDirection.Descending);
            searchGridView.Rows[0].Cells[0].Selected = false;
        }
    }
}
