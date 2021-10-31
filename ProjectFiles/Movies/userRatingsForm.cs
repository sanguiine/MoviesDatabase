using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Movies
{
    public partial class userRatingsForm : Form
    {
        TheMovieDatabaseDataClassesDataContext db = new TheMovieDatabaseDataClassesDataContext();
        private Form activeForm = null;
        private int currentID;

        public userRatingsForm(int userID)
        {
            InitializeComponent();
            currentID = userID;

            var query = from Movie in db.Movies
                        join Rating in db.Ratings
                        on Movie.MovieID equals Rating.MovieID
                        where Rating.UserID == currentID
                        select new
                        {
                            Movie.MovieID,
                            Movie.ReleaseDate.Year,
                            Movie.Title,
                            Rating.Rate
                        };

            watchedGridView.DataSource = query;

            DataTable table = new DataTable();
            table.Columns.Add("Liczba", typeof(int));
            table.Columns.Add("Ocena", typeof(int));

            for (int i = 0; i <= 10; i++)
            {
                table.Rows.Add(i, 0);
            }

            var query2 = from Ratings in db.Ratings
                        where Ratings.UserID == currentID
                        group Ratings by Ratings.Rate into ratingGroup
                        select new
                        {
                            Rating = ratingGroup.Key,
                            Count = ratingGroup.Count()
                        };

            foreach (var item in query2)
            {
                table.Rows[item.Rating].SetField(1, item.Count);
            }

            ratingChart.Series["Series1"].XValueMember = "Liczba";
            ratingChart.Series["Series1"].YValueMembers = "Ocena";
            ratingChart.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
            ratingChart.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;
            ratingChart.ChartAreas["ChartArea1"].AxisX.IsMarginVisible = true;
            ratingChart.DataSource = table;
            ratingChart.DataBind();
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

        private void watched_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int movieID = Convert.ToInt32(watchedGridView.CurrentRow.Cells[0].Value);
            openChildForm(new userMovie(currentID, movieID, mainPanel, watchedGridView, ratingChart));
        }

        private void watchedGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (watchedGridView.RowCount > 0)
            {
                watchedGridView.Rows[0].Cells[0].Selected = false;
                watchedGridView.Columns[0].Visible = false;
                watchedGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                watchedGridView.Columns[1].Width = 70;
                watchedGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                watchedGridView.Columns[3].Width = 50;
                errorLabel.Text = "";
            }
            else
            {
                errorLabel.Text = "Brak obejrzanych filmów.";
            }
        }
    }
}
