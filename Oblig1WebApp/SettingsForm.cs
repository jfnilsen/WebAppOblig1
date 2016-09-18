using Oblig1WebApp.Properties;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Oblig1WebApp
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            minimumTextbox.Text = String.Format("{0}", (int)Settings.Default["MinimumInterval"]);
            maximumTextbox.Text = String.Format("{0}", (int)Settings.Default["MaximumInterval"]);
            imageFilePathTextBox.Text = (string)Settings.Default["PicturePath"];
            minimumTextbox.KeyPress += NumbersOnlyTextfieldHandler;
            maximumTextbox.KeyPress += NumbersOnlyTextfieldHandler;
            filePickerButton.MouseClick += SelectFile;
            CheckRadioButtonFromSettings();
        }

        /// <summary>
        /// A method which will check the radiobutton from the stored settings
        /// </summary>
        private void CheckRadioButtonFromSettings()
        {
            string alertType = (string)Settings.Default["PictureOrSound"];
            switch (alertType)
            {
                case "Picture":
                    pictureRadioButton.Checked = true;
                    break;
                case "Sound":
                    soundRadioButton.Checked = true;
                    break;
            }
        }

        /// <summary>
        /// A method which cancels the keypress if its not a number or backspace
        /// </summary>
        private void NumbersOnlyTextfieldHandler(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Closes the form without saving new values
        /// </summary>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Saves the entered values in %userprofile%\Appdata\Local\Oblig1WebApp
        /// </summary>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            int minimumValue, maximumValue;
            if (IsIntervalTextfieldsValid(out minimumValue, out maximumValue))
            {
                Settings.Default["MinimumInterval"] = minimumValue;
                Settings.Default["MaximumInterval"] = maximumValue;
                Settings.Default["PictureOrSound"] = GetNameOfCheckedRadioButton();
                Settings.Default["PicturePath"] = imageFilePathTextBox.Text;
                Settings.Default.Save();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid values.");
            }
        }

        /// <summary>
        /// Gets the checked radiobutton in the pictureOrSoundGroupBox and returns its name
        /// </summary>
        /// <returns>A string "Picture" if the pictureradiobutton was checked, returns "Sound" in the other case</returns>
        private string GetNameOfCheckedRadioButton()
        {
            RadioButton checkedRadioButton = pictureOrSoundGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(radiobutton => radiobutton.Checked);
            return checkedRadioButton.Text;
        }

        /// <summary>
        /// A method which will check if textfield values are correct and min value is less than max value
        /// </summary>
        private bool IsIntervalTextfieldsValid(out int minimumValue, out int maximumValue)
        {
            minimumValue = 0;
            maximumValue = 0;
            bool minParseSuccess = int.TryParse(minimumTextbox.Text, out minimumValue);
            bool maxParseSuccess = int.TryParse(maximumTextbox.Text, out maximumValue);

            return minimumValue < maximumValue && minParseSuccess && maxParseSuccess;
        }

        private void SelectFile(object sender, MouseEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                Filter = "Image files|*.jpg;*.jpeg;*.png;*.gif;*.tif;*.tiff"
            };
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                imageFilePathTextBox.Text = dialog.FileName;
            }
        }
    }
}