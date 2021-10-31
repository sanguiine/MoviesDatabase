using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Movies
{
    public partial class userWantToSeeForm : Form
    {
        TheMovieDatabaseDataClassesDataContext db = new TheMovieDatabaseDataClassesDataContext();
        private Form activeForm = null;
        private int currentID;

        public userWantToSeeForm(int userID)
        {
            InitializeComponent();
            currentID = userID;

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

            wantToSeeGridView.DataSource = query;
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

        private void wantToSee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int movieID = Convert.ToInt32(wantToSeeGridView.CurrentRow.Cells[0].Value);
            openChildForm(new userMovie(currentID, movieID, mainPanel, wantToSeeGridView, null));
        }

        private void wantToSeeGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (wantToSeeGridView.RowCount > 0)
            {
                wantToSeeGridView.Rows[0].Cells[0].Selected = false;
                wantToSeeGridView.Columns[0].Visible = false;
                wantToSeeGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                wantToSeeGridView.Columns[1].Width = 70;
                errorLabel.Text = "";
            }
            else
            {
                errorLabel.Text = "Brak filmów na liście do obejrzenia.";
            }
        }
    }
}
