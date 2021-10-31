using System;
using System.Drawing;
using System.Windows.Forms;

namespace Movies
{
    public partial class adminForm : Form
    {
        private Button currentButton;
        private Panel leftBorderPanel;
        private Form activeForm = null;
        private int currentID;

        public adminForm(int userID)
        {
            InitializeComponent();
            currentID = userID;
            leftBorderPanel = new Panel();
            leftBorderPanel.Size = new Size(5, 60);
            leftPanel.Controls.Add(leftBorderPanel);
        }

        private void activateLeftBorderPanel(object sender)
        {
            if (sender != null)
            {
                disableLeftBorderPanel();
                currentButton = (Button)sender;
                currentButton.BackColor = Color.FromArgb(78, 78, 78);
                leftBorderPanel.BackColor = Color.FromArgb(95, 125, 149);
                leftBorderPanel.Location = new Point(0, currentButton.Location.Y);
                leftBorderPanel.Visible = true;
                leftBorderPanel.BringToFront();
            }
        }

        private void disableLeftBorderPanel()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(54, 54, 54);
                leftBorderPanel.Visible = false;
            }
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
            childForm.BringToFront();
            childForm.Show();
        }

        private void logoPictureBox_Click(object sender, EventArgs e)
        {
            disableLeftBorderPanel();

            if (activeForm != null)
            {
                activeForm.Close();
            }
        }

        private void usersButton_Click(object sender, EventArgs e)
        {
            activateLeftBorderPanel(sender);
            openChildForm(new adminUsersForm());
        }

        private void moviesButton_Click(object sender, EventArgs e)
        {
            activateLeftBorderPanel(sender);
            openChildForm(new adminMoviesForm());
        }

        private void castButton_Click(object sender, EventArgs e)
        {
            activateLeftBorderPanel(sender);
            openChildForm(new adminCastAndCrewForm());
        }

        private void genresButton_Click(object sender, EventArgs e)
        {
            activateLeftBorderPanel(sender);
            openChildForm(new adminGenresForm());
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            activateLeftBorderPanel(sender);
            openChildForm(new userSettingsForm(currentID));
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void adminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
