namespace ITunesAlarm
{
    partial class EditAlarmForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAlarmForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SaveAlarmButton = new System.Windows.Forms.Button();
            this.VolumeSelector = new System.Windows.Forms.TrackBar();
            this.VolumeLabel = new System.Windows.Forms.Label();
            this.SecondsLabel = new System.Windows.Forms.Label();
            this.SecondSelector = new System.Windows.Forms.NumericUpDown();
            this.FadeLabel = new System.Windows.Forms.Label();
            this.PlaylistDropdown = new System.Windows.Forms.ComboBox();
            this.PlaylistLabel = new System.Windows.Forms.Label();
            this.SundayCheck = new System.Windows.Forms.CheckBox();
            this.SaturdayCheck = new System.Windows.Forms.CheckBox();
            this.FridayCheck = new System.Windows.Forms.CheckBox();
            this.ThursdayCheck = new System.Windows.Forms.CheckBox();
            this.WednesdayCheck = new System.Windows.Forms.CheckBox();
            this.TuesdayCheck = new System.Windows.Forms.CheckBox();
            this.MondayCheck = new System.Windows.Forms.CheckBox();
            this.EveryLabel = new System.Windows.Forms.Label();
            this.WakeTimePicker = new System.Windows.Forms.DateTimePicker();
            this.WakeLabel = new System.Windows.Forms.Label();
            this.AlarmNameTextBox = new System.Windows.Forms.TextBox();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.AlarmNameTextBox);
            this.MainPanel.Controls.Add(this.SaveAlarmButton);
            this.MainPanel.Controls.Add(this.VolumeSelector);
            this.MainPanel.Controls.Add(this.VolumeLabel);
            this.MainPanel.Controls.Add(this.SecondsLabel);
            this.MainPanel.Controls.Add(this.SecondSelector);
            this.MainPanel.Controls.Add(this.FadeLabel);
            this.MainPanel.Controls.Add(this.PlaylistDropdown);
            this.MainPanel.Controls.Add(this.PlaylistLabel);
            this.MainPanel.Controls.Add(this.SundayCheck);
            this.MainPanel.Controls.Add(this.SaturdayCheck);
            this.MainPanel.Controls.Add(this.FridayCheck);
            this.MainPanel.Controls.Add(this.ThursdayCheck);
            this.MainPanel.Controls.Add(this.WednesdayCheck);
            this.MainPanel.Controls.Add(this.TuesdayCheck);
            this.MainPanel.Controls.Add(this.MondayCheck);
            this.MainPanel.Controls.Add(this.EveryLabel);
            this.MainPanel.Controls.Add(this.WakeTimePicker);
            this.MainPanel.Controls.Add(this.WakeLabel);
            this.MainPanel.Location = new System.Drawing.Point(12, 12);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(282, 258);
            this.MainPanel.TabIndex = 0;
            // 
            // SaveAlarmButton
            // 
            this.SaveAlarmButton.Location = new System.Drawing.Point(7, 224);
            this.SaveAlarmButton.Name = "SaveAlarmButton";
            this.SaveAlarmButton.Size = new System.Drawing.Size(75, 23);
            this.SaveAlarmButton.TabIndex = 27;
            this.SaveAlarmButton.Text = "Save Alarm";
            this.SaveAlarmButton.UseVisualStyleBackColor = true;
            this.SaveAlarmButton.Click += new System.EventHandler(this.SaveAlarmButton_Click);
            // 
            // VolumeSelector
            // 
            this.VolumeSelector.Location = new System.Drawing.Point(76, 187);
            this.VolumeSelector.Maximum = 20;
            this.VolumeSelector.Minimum = 1;
            this.VolumeSelector.Name = "VolumeSelector";
            this.VolumeSelector.Size = new System.Drawing.Size(115, 45);
            this.VolumeSelector.TabIndex = 26;
            this.VolumeSelector.Value = 10;
            // 
            // VolumeLabel
            // 
            this.VolumeLabel.AutoSize = true;
            this.VolumeLabel.Location = new System.Drawing.Point(7, 187);
            this.VolumeLabel.Name = "VolumeLabel";
            this.VolumeLabel.Size = new System.Drawing.Size(42, 13);
            this.VolumeLabel.TabIndex = 25;
            this.VolumeLabel.Text = "Volume";
            // 
            // SecondsLabel
            // 
            this.SecondsLabel.AutoSize = true;
            this.SecondsLabel.Location = new System.Drawing.Point(125, 163);
            this.SecondsLabel.Name = "SecondsLabel";
            this.SecondsLabel.Size = new System.Drawing.Size(47, 13);
            this.SecondsLabel.TabIndex = 24;
            this.SecondsLabel.Text = "seconds";
            // 
            // SecondSelector
            // 
            this.SecondSelector.Location = new System.Drawing.Point(76, 161);
            this.SecondSelector.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.SecondSelector.Name = "SecondSelector";
            this.SecondSelector.Size = new System.Drawing.Size(43, 20);
            this.SecondSelector.TabIndex = 23;
            this.SecondSelector.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // FadeLabel
            // 
            this.FadeLabel.AutoSize = true;
            this.FadeLabel.Location = new System.Drawing.Point(7, 163);
            this.FadeLabel.Name = "FadeLabel";
            this.FadeLabel.Size = new System.Drawing.Size(60, 13);
            this.FadeLabel.TabIndex = 22;
            this.FadeLabel.Text = "Fade in for ";
            // 
            // PlaylistDropdown
            // 
            this.PlaylistDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlaylistDropdown.FormattingEnabled = true;
            this.PlaylistDropdown.Location = new System.Drawing.Point(7, 133);
            this.PlaylistDropdown.Name = "PlaylistDropdown";
            this.PlaylistDropdown.Size = new System.Drawing.Size(262, 21);
            this.PlaylistDropdown.TabIndex = 21;
            // 
            // PlaylistLabel
            // 
            this.PlaylistLabel.AutoSize = true;
            this.PlaylistLabel.Location = new System.Drawing.Point(7, 116);
            this.PlaylistLabel.Name = "PlaylistLabel";
            this.PlaylistLabel.Size = new System.Drawing.Size(39, 13);
            this.PlaylistLabel.TabIndex = 20;
            this.PlaylistLabel.Text = "Playlist";
            // 
            // SundayCheck
            // 
            this.SundayCheck.AutoSize = true;
            this.SundayCheck.Location = new System.Drawing.Point(188, 73);
            this.SundayCheck.Name = "SundayCheck";
            this.SundayCheck.Size = new System.Drawing.Size(39, 17);
            this.SundayCheck.TabIndex = 19;
            this.SundayCheck.Text = "Su";
            this.SundayCheck.UseVisualStyleBackColor = true;
            // 
            // SaturdayCheck
            // 
            this.SaturdayCheck.AutoSize = true;
            this.SaturdayCheck.Location = new System.Drawing.Point(141, 96);
            this.SaturdayCheck.Name = "SaturdayCheck";
            this.SaturdayCheck.Size = new System.Drawing.Size(39, 17);
            this.SaturdayCheck.TabIndex = 18;
            this.SaturdayCheck.Text = "Sa";
            this.SaturdayCheck.UseVisualStyleBackColor = true;
            // 
            // FridayCheck
            // 
            this.FridayCheck.AutoSize = true;
            this.FridayCheck.Location = new System.Drawing.Point(141, 73);
            this.FridayCheck.Name = "FridayCheck";
            this.FridayCheck.Size = new System.Drawing.Size(35, 17);
            this.FridayCheck.TabIndex = 17;
            this.FridayCheck.Text = "Fr";
            this.FridayCheck.UseVisualStyleBackColor = true;
            // 
            // ThursdayCheck
            // 
            this.ThursdayCheck.AutoSize = true;
            this.ThursdayCheck.Location = new System.Drawing.Point(94, 96);
            this.ThursdayCheck.Name = "ThursdayCheck";
            this.ThursdayCheck.Size = new System.Drawing.Size(39, 17);
            this.ThursdayCheck.TabIndex = 16;
            this.ThursdayCheck.Text = "Th";
            this.ThursdayCheck.UseVisualStyleBackColor = true;
            // 
            // WednesdayCheck
            // 
            this.WednesdayCheck.AutoSize = true;
            this.WednesdayCheck.Location = new System.Drawing.Point(94, 73);
            this.WednesdayCheck.Name = "WednesdayCheck";
            this.WednesdayCheck.Size = new System.Drawing.Size(43, 17);
            this.WednesdayCheck.TabIndex = 15;
            this.WednesdayCheck.Text = "We";
            this.WednesdayCheck.UseVisualStyleBackColor = true;
            // 
            // TuesdayCheck
            // 
            this.TuesdayCheck.AutoSize = true;
            this.TuesdayCheck.Location = new System.Drawing.Point(47, 96);
            this.TuesdayCheck.Name = "TuesdayCheck";
            this.TuesdayCheck.Size = new System.Drawing.Size(39, 17);
            this.TuesdayCheck.TabIndex = 14;
            this.TuesdayCheck.Text = "Tu";
            this.TuesdayCheck.UseVisualStyleBackColor = true;
            // 
            // MondayCheck
            // 
            this.MondayCheck.AutoSize = true;
            this.MondayCheck.Location = new System.Drawing.Point(47, 73);
            this.MondayCheck.Name = "MondayCheck";
            this.MondayCheck.Size = new System.Drawing.Size(41, 17);
            this.MondayCheck.TabIndex = 13;
            this.MondayCheck.Text = "Mo";
            this.MondayCheck.UseVisualStyleBackColor = true;
            // 
            // EveryLabel
            // 
            this.EveryLabel.AutoSize = true;
            this.EveryLabel.Location = new System.Drawing.Point(7, 73);
            this.EveryLabel.Name = "EveryLabel";
            this.EveryLabel.Size = new System.Drawing.Size(34, 13);
            this.EveryLabel.TabIndex = 5;
            this.EveryLabel.Text = "Every";
            // 
            // WakeTimePicker
            // 
            this.WakeTimePicker.CustomFormat = "HH:mm";
            this.WakeTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.WakeTimePicker.Location = new System.Drawing.Point(81, 43);
            this.WakeTimePicker.Name = "WakeTimePicker";
            this.WakeTimePicker.ShowUpDown = true;
            this.WakeTimePicker.Size = new System.Drawing.Size(56, 20);
            this.WakeTimePicker.TabIndex = 4;
            this.WakeTimePicker.Value = new System.DateTime(2016, 10, 15, 8, 0, 0, 0);
            // 
            // WakeLabel
            // 
            this.WakeLabel.AutoSize = true;
            this.WakeLabel.Location = new System.Drawing.Point(7, 43);
            this.WakeLabel.Name = "WakeLabel";
            this.WakeLabel.Size = new System.Drawing.Size(68, 13);
            this.WakeLabel.TabIndex = 3;
            this.WakeLabel.Text = "Wake me on";
            // 
            // AlarmNameTextBox
            // 
            this.AlarmNameTextBox.Location = new System.Drawing.Point(7, 10);
            this.AlarmNameTextBox.Name = "AlarmNameTextBox";
            this.AlarmNameTextBox.Size = new System.Drawing.Size(262, 20);
            this.AlarmNameTextBox.TabIndex = 28;
            // 
            // EditAlarmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 281);
            this.Controls.Add(this.MainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditAlarmForm";
            this.Text = "iTunes Alarm";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondSelector)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label WakeLabel;
        private System.Windows.Forms.DateTimePicker WakeTimePicker;
        private System.Windows.Forms.Label EveryLabel;
        private System.Windows.Forms.CheckBox SundayCheck;
        private System.Windows.Forms.CheckBox SaturdayCheck;
        private System.Windows.Forms.CheckBox FridayCheck;
        private System.Windows.Forms.CheckBox ThursdayCheck;
        private System.Windows.Forms.CheckBox WednesdayCheck;
        private System.Windows.Forms.CheckBox TuesdayCheck;
        private System.Windows.Forms.CheckBox MondayCheck;
        private System.Windows.Forms.ComboBox PlaylistDropdown;
        private System.Windows.Forms.Label PlaylistLabel;
        private System.Windows.Forms.Label VolumeLabel;
        private System.Windows.Forms.Label SecondsLabel;
        private System.Windows.Forms.NumericUpDown SecondSelector;
        private System.Windows.Forms.Label FadeLabel;
        private System.Windows.Forms.TrackBar VolumeSelector;
        private System.Windows.Forms.Button SaveAlarmButton;
        private System.Windows.Forms.TextBox AlarmNameTextBox;
    }
}

