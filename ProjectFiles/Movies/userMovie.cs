using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Movies
{
    public partial class userMovie : Form
    {
        TheMovieDatabaseDataClassesDataContext db = new TheMovieDatabaseDataClassesDataContext();
        private Panel activePanel = null;
        private DataGridView currentGridView;
        private Chart currentChart;
        private int currentID;
        private int currentMovieID;
        
        public userMovie(int userID, int movieID, Panel mainPanel, DataGridView GridView, Chart ratingChart)
        {
            InitializeComponent();
            currentID = userID;
            currentMovieID = movieID;
            activePanel = mainPanel;
            currentGridView = GridView;
            currentChart = ratingChart;
            setAverageRate();

            var query = from Movie in db.Movies
                        where Movie.MovieID == movieID
                        select Movie;

            titleLabel.Text = query.First().Title + " (" + query.First().ReleaseDate.Year.ToString() + ")";
            descriptionLabel.Text = query.First().Overview;

            if(query.First().Cover != null)
            {
                byte[] b = query.First().Cover.ToArray();
                MemoryStream ms = new MemoryStream(b);
                coverPictureBox.Image = Image.FromStream(ms);
            }

           var query2 = from Movie in db.Movies
                         join MovieDirector in db.MovieDirectors on Movie.MovieID equals MovieDirector.MovieID
                         join CastAndCrew in db.CastAndCrews on MovieDirector.PersonID equals CastAndCrew.PersonID
                         where Movie.MovieID == movieID
                         select CastAndCrew;

            foreach (var item in query2)
            {
                directorLabel.Text += item.FirstName + " " + item.LastName + " | ";
            }

            if(!(directorLabel.Text.Equals("")))
            {
                directorLabel.Text = directorLabel.Text.Remove(directorLabel.Text.Length - 3);
            }

            var query3 = from Movie in db.Movies
                         join MovieWriter in db.MovieWriters on Movie.MovieID equals MovieWriter.MovieID
                         join CastAndCrew in db.CastAndCrews on MovieWriter.PersonID equals CastAndCrew.PersonID
                         where Movie.MovieID == movieID
                         select CastAndCrew;

            foreach (var item in query3)
            {
                writerLabel.Text += item.FirstName + " " + item.LastName + " | ";
            }

            if (!(writerLabel.Text.Equals("")))
            {
                writerLabel.Text = writerLabel.Text.Remove(writerLabel.Text.Length - 3);
            }

            var query4 = from Movie in db.Movies
                         join MovieGenre in db.MovieGenres on Movie.MovieID equals MovieGenre.MovieID
                         join Genre in db.Genres on MovieGenre.GenreID equals Genre.GenreID
                         where Movie.MovieID == movieID
                         select Genre;

            foreach (var item in query4)
            {
                genreLabel.Text += item.Name + " | ";
            }

            if (!(genreLabel.Text.Equals("")))
            {
                genreLabel.Text = genreLabel.Text.Remove(genreLabel.Text.Length - 3);
            }    
            
            var query5 = from WantToSee in db.WantToSees
                         where WantToSee.MovieID == movieID && WantToSee.UserID == currentID
                         select WantToSee;

            if (query5.Any())
            {
                wantToSeeCheckBox.Checked = true;
            }
            else
            {
                wantToSeeCheckBox.Checked = false;
            }
            
            var query6 = from Rating in db.Ratings
                         where Rating.MovieID == movieID && Rating.UserID == currentID
                         select Rating;

            if (query6.Any())
            {
                watchedCheckBox.Checked = true;
                rateTrackBar.Enabled = true;
                saveButton.Enabled = true;

                if(query6.First().Rate >= 1 && query6.First().Rate <= 10)
                {
                    rateTrackBar.Value = (int)query6.First().Rate;
                    rateTitleLabel.Text = "Twoja ocena: " + rateTrackBar.Value.ToString();
                }
                else
                {
                    rateTrackBar.Value = 1;
                    rateTitleLabel.Text = "Twoja ocena: brak";
                }
            }
            else
            {
                rateTrackBar.Enabled = false;
                saveButton.Enabled = false;
                rateTitleLabel.Text = "Twoja ocena: brak";
                rateTrackBar.Value = 1;
            }
        }

        private void setAverageRate()
        {
            double rate = (double)db.funMovieRate(currentMovieID);
            rate = Math.Round(rate, 2);

            if (rate == 0)
            {
                noAverageLabel.Visible = true;
                averageLabel.Text = "";
            }
            else
            {
                noAverageLabel.Visible = false;
                averageLabel.Text = rate.ToString();
            }
        }

        private void watchedCheckBox_Click(object sender, EventArgs e)
        {
            if (watchedCheckBox.Checked == true)
            {
                rateTrackBar.Enabled = true;
                saveButton.Enabled = true;

                Ratings newWatched = new Ratings();
                newWatched.UserID = currentID;
                newWatched.MovieID = currentMovieID;
                db.Ratings.InsertOnSubmit(newWatched);
                db.SubmitChanges();
            }
            else
            {
                rateTrackBar.Enabled = false;
                saveButton.Enabled = false;
                rateTitleLabel.Text = "Twoja ocena: brak";
                rateTrackBar.Value = 1;

                Ratings delWatched = db.Ratings.FirstOrDefault(e1 => e1.MovieID.Equals(currentMovieID) && e1.UserID.Equals(currentID));
                db.Ratings.DeleteOnSubmit(delWatched);
                db.SubmitChanges();
                setAverageRate();
            }
        }

        private void wantToSee_Click(object sender, EventArgs e)
        {
            if (wantToSeeCheckBox.Checked == true)
            {
                WantToSee newWantToSee = new WantToSee();
                newWantToSee.UserID = currentID;
                newWantToSee.MovieID = currentMovieID;
                db.WantToSees.InsertOnSubmit(newWantToSee);
                db.SubmitChanges();
            }
            else
            {
                WantToSee delWantToSee = db.WantToSees.FirstOrDefault(e1 => e1.MovieID.Equals(currentMovieID) && e1.UserID.Equals(currentID));
                db.WantToSees.DeleteOnSubmit(delWantToSee);
                db.SubmitChanges();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            rateTitleLabel.Text = "Twoja ocena: " + rateTrackBar.Value.ToString();

            Ratings editRating = db.Ratings.FirstOrDefault(e1 => e1.MovieID.Equals(currentMovieID) && e1.UserID.Equals(currentID));
            editRating.Rate = rateTrackBar.Value;
            db.SubmitChanges();
            setAverageRate();
        }

        private void backPictureBox_Click(object sender, EventArgs e)
        {
            if (currentGridView.Name.Equals("watchedGridView"))
            {
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

                currentGridView.DataSource = query;

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

                currentChart.Series["Series1"].XValueMember = "Liczba";
                currentChart.Series["Series1"].YValueMembers = "Ocena";
                currentChart.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
                currentChart.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;
                currentChart.ChartAreas["ChartArea1"].AxisX.IsMarginVisible = true;
                currentChart.DataSource = table;
                currentChart.DataBind();
            }
            else if (currentGridView.Name.Equals("wantToSeeGridView"))
            {
                var query = from Movie in db.Movies
                            join WantToSee in db.WantToSees
                            on Movie.MovieID equals WantToSee.MovieID
                            where WantToSee.UserID == currentID
                            select new
                            {
                                Movie.MovieID,
                                Movie.ReleaseDate.Year,
                                Movie.Title
                            };

                currentGridView.DataSource = query;
            }

            if (activePanel != null)
            {
                activePanel.SendToBack();
                activePanel.Visible = false;
            }
        }
    }
}
