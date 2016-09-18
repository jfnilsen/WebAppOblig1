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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.groupBox1.SuspendLayout();
            this.pictureOrSoundGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maximumLabel);
            this.groupBox1.Controls.Add(this.minimumLabel);
            this.groupBox1.Controls.Add(this.maximumTextbox);
            this.groupBox1.Controls.Add(this.minimumTextbox);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Time to wait values";
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
            this.saveButton.Location = new System.Drawing.Point(10, 118);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(344, 120);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 151);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.pictureOrSoundGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pictureOrSoundGroupBox.ResumeLayout(false);
            this.pictureOrSoundGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
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
    }
}