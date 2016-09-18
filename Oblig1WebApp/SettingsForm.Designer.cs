namespace Oblig1WebApp
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.minmaxValuesGroupBox = new System.Windows.Forms.GroupBox();
            this.maximumLabel = new System.Windows.Forms.Label();
            this.minimumLabel = new System.Windows.Forms.Label();
            this.maximumTextbox = new System.Windows.Forms.TextBox();
            this.minimumTextbox = new System.Windows.Forms.TextBox();
            this.pictureOrSoundGroupBox = new System.Windows.Forms.GroupBox();
            this.soundRadioButton = new System.Windows.Forms.RadioButton();
            this.pictureRadioButton = new System.Windows.Forms.RadioButton();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.fileSelectionGroupBox = new System.Windows.Forms.GroupBox();
            this.imageFilePathTextBox = new System.Windows.Forms.TextBox();
            this.filePickerButton = new System.Windows.Forms.Button();
            this.minmaxValuesGroupBox.SuspendLayout();
            this.pictureOrSoundGroupBox.SuspendLayout();
            this.fileSelectionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // minmaxValuesGroupBox
            // 
            this.minmaxValuesGroupBox.Controls.Add(this.maximumLabel);
            this.minmaxValuesGroupBox.Controls.Add(this.minimumLabel);
            this.minmaxValuesGroupBox.Controls.Add(this.maximumTextbox);
            this.minmaxValuesGroupBox.Controls.Add(this.minimumTextbox);
            this.minmaxValuesGroupBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.minmaxValuesGroupBox.Location = new System.Drawing.Point(12, 12);
            this.minmaxValuesGroupBox.Name = "minmaxValuesGroupBox";
            this.minmaxValuesGroupBox.Size = new System.Drawing.Size(200, 100);
            this.minmaxValuesGroupBox.TabIndex = 0;
            this.minmaxValuesGroupBox.TabStop = false;
            this.minmaxValuesGroupBox.Text = "Delay before event (milliseconds)";
            // 
            // maximumLabel
            // 
            this.maximumLabel.AutoSize = true;
            this.maximumLabel.Location = new System.Drawing.Point(3, 62);
            this.maximumLabel.Name = "maximumLabel";
            this.maximumLabel.Size = new System.Drawing.Size(73, 13);
            this.maximumLabel.TabIndex = 3;
            this.maximumLabel.Text = "Maximum time";
            // 
            // minimumLabel
            // 
            this.minimumLabel.AutoSize = true;
            this.minimumLabel.Location = new System.Drawing.Point(3, 27);
            this.minimumLabel.Name = "minimumLabel";
            this.minimumLabel.Size = new System.Drawing.Size(70, 13);
            this.minimumLabel.TabIndex = 2;
            this.minimumLabel.Text = "Minimum time";
            // 
            // maximumTextbox
            // 
            this.maximumTextbox.Location = new System.Drawing.Point(90, 56);
            this.maximumTextbox.Name = "maximumTextbox";
            this.maximumTextbox.Size = new System.Drawing.Size(100, 20);
            this.maximumTextbox.TabIndex = 1;
            // 
            // minimumTextbox
            // 
            this.minimumTextbox.Location = new System.Drawing.Point(90, 20);
            this.minimumTextbox.Name = "minimumTextbox";
            this.minimumTextbox.Size = new System.Drawing.Size(100, 20);
            this.minimumTextbox.TabIndex = 0;
            // 
            // pictureOrSoundGroupBox
            // 
            this.pictureOrSoundGroupBox.Controls.Add(this.soundRadioButton);
            this.pictureOrSoundGroupBox.Controls.Add(this.pictureRadioButton);
            this.pictureOrSoundGroupBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.pictureOrSoundGroupBox.Location = new System.Drawing.Point(219, 13);
            this.pictureOrSoundGroupBox.Name = "pictureOrSoundGroupBox";
            this.pictureOrSoundGroupBox.Size = new System.Drawing.Size(200, 100);
            this.pictureOrSoundGroupBox.TabIndex = 1;
            this.pictureOrSoundGroupBox.TabStop = false;
            this.pictureOrSoundGroupBox.Text = "Picture or sound";
            // 
            // soundRadioButton
            // 
            this.soundRadioButton.AutoSize = true;
            this.soundRadioButton.Location = new System.Drawing.Point(6, 42);
            this.soundRadioButton.Name = "soundRadioButton";
            this.soundRadioButton.Size = new System.Drawing.Size(56, 17);
            this.soundRadioButton.TabIndex = 1;
            this.soundRadioButton.TabStop = true;
            this.soundRadioButton.Text = "Sound";
            this.soundRadioButton.UseVisualStyleBackColor = true;
            // 
            // pictureRadioButton
            // 
            this.pictureRadioButton.AutoSize = true;
            this.pictureRadioButton.Location = new System.Drawing.Point(6, 19);
            this.pictureRadioButton.Name = "pictureRadioButton";
            this.pictureRadioButton.Size = new System.Drawing.Size(58, 17);
            this.pictureRadioButton.TabIndex = 0;
            this.pictureRadioButton.TabStop = true;
            this.pictureRadioButton.Text = "Picture";
            this.pictureRadioButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(10, 202);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(342, 202);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // fileSelectionGroupBox
            // 
            this.fileSelectionGroupBox.Controls.Add(this.imageFilePathTextBox);
            this.fileSelectionGroupBox.Controls.Add(this.filePickerButton);
            this.fileSelectionGroupBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.fileSelectionGroupBox.Location = new System.Drawing.Point(12, 118);
            this.fileSelectionGroupBox.Name = "fileSelectionGroupBox";
            this.fileSelectionGroupBox.Size = new System.Drawing.Size(405, 78);
            this.fileSelectionGroupBox.TabIndex = 5;
            this.fileSelectionGroupBox.TabStop = false;
            this.fileSelectionGroupBox.Text = "Select your own image to be displayed";
            // 
            // imageFilePathTextBox
            // 
            this.imageFilePathTextBox.Location = new System.Drawing.Point(7, 20);
            this.imageFilePathTextBox.Name = "imageFilePathTextBox";
            this.imageFilePathTextBox.Size = new System.Drawing.Size(392, 20);
            this.imageFilePathTextBox.TabIndex = 1;
            // 
            // filePickerButton
            // 
            this.filePickerButton.Location = new System.Drawing.Point(305, 49);
            this.filePickerButton.Name = "filePickerButton";
            this.filePickerButton.Size = new System.Drawing.Size(94, 23);
            this.filePickerButton.TabIndex = 0;
            this.filePickerButton.Text = "Change image";
            this.filePickerButton.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 237);
            this.Controls.Add(this.fileSelectionGroupBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.pictureOrSoundGroupBox);
            this.Controls.Add(this.minmaxValuesGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.minmaxValuesGroupBox.ResumeLayout(false);
            this.minmaxValuesGroupBox.PerformLayout();
            this.pictureOrSoundGroupBox.ResumeLayout(false);
            this.pictureOrSoundGroupBox.PerformLayout();
            this.fileSelectionGroupBox.ResumeLayout(false);
            this.fileSelectionGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox minmaxValuesGroupBox;
        private System.Windows.Forms.Label maximumLabel;
        private System.Windows.Forms.Label minimumLabel;
        private System.Windows.Forms.TextBox maximumTextbox;
        private System.Windows.Forms.TextBox minimumTextbox;
        private System.Windows.Forms.GroupBox pictureOrSoundGroupBox;
        private System.Windows.Forms.RadioButton soundRadioButton;
        private System.Windows.Forms.RadioButton pictureRadioButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox fileSelectionGroupBox;
        private System.Windows.Forms.TextBox imageFilePathTextBox;
        private System.Windows.Forms.Button filePickerButton;
    }
}