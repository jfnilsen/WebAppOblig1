using Oblig1WebApp.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Oblig1WebApp
{
    public partial class MainForm : Form
    {
        private Timer timer = new Timer();
        private DateTime startTime;

        private bool ChallengeStarted { get; set; }

        /// <summary>
        /// Constructor that calls the initialize method and sets eventhandlers for the required Controls
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(DisplayImage);
            this.scoreListView.ListViewItemSorter = new ListViewSecondColumnSorter();
            this.startChallengeButton.Click += new EventHandler(StartChallenge);
            this.MouseClick += new MouseEventHandler(SaveScore);
            this.picturePanel.MouseClick += new MouseEventHandler(SaveScore);
            this.settingsToolStripMenuItem.Click += new EventHandler(OpenSettingsForm);
            this.exitToolStripMenuItem.Click += new EventHandler(ExitMenuItemClicked);
        }

        /// <summary>
        /// A method that sets an interval randomly between two values configured in App.config and starts the timer.
        /// </summary>
        private void StartChallenge(object sender, EventArgs e)
        {
            if (!ChallengeStarted)
            {
                Random random = new Random();
                timer.Interval = random.Next((int)Settings.Default["MinimumInterval"], (int)Settings.Default["MaximumInterval"]);
                timer.Start();
                ChallengeStarted = true;
            }
        }

        /// <summary>
        /// A method that displays an image at a random location in the Panel Control.
        /// </summary>
        private void DisplayImage(object sender, EventArgs e)
        {
            PictureBox picture = new PictureBox()
            {
                Image = Image.FromFile((string)Settings.Default["PicturePath"]), 
                SizeMode = PictureBoxSizeMode.AutoSize
            };
            picture.MouseClick += new MouseEventHandler(SaveScore);
            SetRandomPictureLocation(picture, 700, 400);
            picturePanel.Controls.Add(picture);

            timer.Stop();
            startTime = DateTime.Now;
        }

        /// <summary>
        /// A method which sets the location of a PictureBox to random values between 0 and the entered max values
        /// </summary>
        /// <param name="picture"> A PictureBox to randomize </param>
        /// <param name="maxX"> The max x-value for the starting point of the image </param>
        /// <param name="maxY"> The max y-value for the starting point of the image </param>
        private static void SetRandomPictureLocation(PictureBox picture, int maxX, int maxY)
        {
            Random random = new Random();
            int x = random.Next(0, maxX);
            int y = random.Next(0, maxY);

            picture.Location = new Point(x, y);
        }

        /// <summary>
        /// A method which is called on any click of the form or picturePanel and records the time from the reaction event happened to the users first click.
        /// The score is then added in a listview together with the users name.
        /// </summary>
        private void SaveScore(object sender, MouseEventArgs e)
        {
            DateTime timeClicked = DateTime.Now;
            if (IsChallengeEnded())
            {
                ListViewItem nameListViewItem = new ListViewItem() { Text = nameTextBox.Text };
                nameListViewItem.SubItems.Add(GetReactionTime(timeClicked));
                scoreListView.Items.Add(nameListViewItem);

                scoreListView.Sort();
                Reset();
            }
            else if (IsClickTooEarly())
            {
                Reset();
                MessageBox.Show(this, "You clicked too early, challenge stopped.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// A method that determines if the challenge has been started and the image has appeared correctly.
        /// </summary>
        /// <returns> True if the challenge was started and the image has appered. </returns>
        private bool IsChallengeEnded()
        {
            return !timer.Enabled && ChallengeStarted;
        }

        /// <summary>
        /// A method that determines if a challenge has been started, but the image has not yet appeared.
        /// </summary>
        /// <returns> True if the image has not yet appeared and the challenge is started. </returns>
        private bool IsClickTooEarly()
        {
            return timer.Enabled && ChallengeStarted;
        }

        private string GetReactionTime(DateTime timeClicked)
        {
            TimeSpan time = timeClicked - startTime;
            return time.ToString();
        }

        /// <summary>
        /// A method that cleans up after a completed test
        /// </summary>
        private void Reset()
        {
            ChallengeStarted = false;
            timer.Stop();
            picturePanel.Controls.Clear();
        }

        /// <summary>
        /// A method which opens the settings form
        /// </summary>
        private void OpenSettingsForm(object sender, EventArgs e)
        {
            new SettingsForm().ShowDialog();
        }

        /// <summary>
        /// A method which closes the application
        /// </summary>
        private void ExitMenuItemClicked(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}