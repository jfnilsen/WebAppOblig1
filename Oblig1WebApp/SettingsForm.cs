using Oblig1WebApp.Properties;
using System;
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
            minimumTextbox.KeyPress += NumbersOnlyTextfieldHandler;
            maximumTextbox.KeyPress += NumbersOnlyTextfieldHandler;
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

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int minimumValue, maximumValue;
            if (IsIntervalTextfieldsValid(out minimumValue, out maximumValue))
            {
                Settings.Default["MinimumInterval"] = minimumValue;
                Settings.Default["MaximumInterval"] = maximumValue;
                Settings.Default.Save();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid values.");
            }
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
    }
}