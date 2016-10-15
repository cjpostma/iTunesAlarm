namespace ITunesAlarm
{
    partial class MainForm
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.AlarmLabel = new System.Windows.Forms.Label();
            this.AlarmDropDownList = new System.Windows.Forms.ComboBox();
            this.AddAlarmButton = new System.Windows.Forms.Button();
            this.WakeLabel = new System.Windows.Forms.Label();
            this.WakeTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EveryLabel = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.EveryLabel);
            this.MainPanel.Controls.Add(this.WakeTimePicker);
            this.MainPanel.Controls.Add(this.WakeLabel);
            this.MainPanel.Controls.Add(this.AddAlarmButton);
            this.MainPanel.Controls.Add(this.AlarmDropDownList);
            this.MainPanel.Controls.Add(this.AlarmLabel);
            this.MainPanel.Location = new System.Drawing.Point(12, 12);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(282, 237);
            this.MainPanel.TabIndex = 0;
            // 
            // AlarmLabel
            // 
            this.AlarmLabel.AutoSize = true;
            this.AlarmLabel.Location = new System.Drawing.Point(4, 4);
            this.AlarmLabel.Name = "AlarmLabel";
            this.AlarmLabel.Size = new System.Drawing.Size(38, 13);
            this.AlarmLabel.TabIndex = 0;
            this.AlarmLabel.Text = "Alarms";
            // 
            // AlarmDropDownList
            // 
            this.AlarmDropDownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AlarmDropDownList.FormattingEnabled = true;
            this.AlarmDropDownList.Location = new System.Drawing.Point(7, 21);
            this.AlarmDropDownList.Name = "AlarmDropDownList";
            this.AlarmDropDownList.Size = new System.Drawing.Size(181, 21);
            this.AlarmDropDownList.TabIndex = 1;
            // 
            // AddAlarmButton
            // 
            this.AddAlarmButton.Location = new System.Drawing.Point(194, 21);
            this.AddAlarmButton.Name = "AddAlarmButton";
            this.AddAlarmButton.Size = new System.Drawing.Size(75, 23);
            this.AddAlarmButton.TabIndex = 2;
            this.AddAlarmButton.Text = "Add Alarm";
            this.AddAlarmButton.UseVisualStyleBackColor = true;
            // 
            // WakeLabel
            // 
            this.WakeLabel.AutoSize = true;
            this.WakeLabel.Location = new System.Drawing.Point(7, 49);
            this.WakeLabel.Name = "WakeLabel";
            this.WakeLabel.Size = new System.Drawing.Size(68, 13);
            this.WakeLabel.TabIndex = 3;
            this.WakeLabel.Text = "Wake me on";
            // 
            // WakeTimePicker
            // 
            this.WakeTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.WakeTimePicker.Location = new System.Drawing.Point(81, 48);
            this.WakeTimePicker.Name = "WakeTimePicker";
            this.WakeTimePicker.Size = new System.Drawing.Size(65, 20);
            this.WakeTimePicker.TabIndex = 4;
            this.WakeTimePicker.Value = new System.DateTime(2016, 10, 15, 12, 0, 0, 0);
            // 
            // EveryLabel
            // 
            this.EveryLabel.AutoSize = true;
            this.EveryLabel.Location = new System.Drawing.Point(7, 71);
            this.EveryLabel.Name = "EveryLabel";
            this.EveryLabel.Size = new System.Drawing.Size(34, 13);
            this.EveryLabel.TabIndex = 5;
            this.EveryLabel.Text = "Every";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 261);
            this.Controls.Add(this.MainPanel);
            this.Name = "MainForm";
            this.Text = "iTunes Alarm";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label WakeLabel;
        private System.Windows.Forms.Button AddAlarmButton;
        private System.Windows.Forms.ComboBox AlarmDropDownList;
        private System.Windows.Forms.Label AlarmLabel;
        private System.Windows.Forms.DateTimePicker WakeTimePicker;
        private System.Windows.Forms.Label EveryLabel;
    }
}

