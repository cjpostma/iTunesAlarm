namespace ITunesAlarm
{
    partial class AlarmList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlarmList));
            this.AlarmLine = new System.Windows.Forms.GroupBox();
            this.AlarmActiveCheck = new System.Windows.Forms.CheckBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditAlarmButton = new System.Windows.Forms.Button();
            this.AlarmLine.SuspendLayout();
            this.SuspendLayout();
            // 
            // AlarmLine
            // 
            this.AlarmLine.Controls.Add(this.EditAlarmButton);
            this.AlarmLine.Controls.Add(this.DeleteButton);
            this.AlarmLine.Controls.Add(this.AlarmActiveCheck);
            this.AlarmLine.Location = new System.Drawing.Point(13, 13);
            this.AlarmLine.Name = "AlarmLine";
            this.AlarmLine.Size = new System.Drawing.Size(269, 44);
            this.AlarmLine.TabIndex = 0;
            this.AlarmLine.TabStop = false;
            this.AlarmLine.Text = "Alarm Name";
            // 
            // AlarmActiveCheck
            // 
            this.AlarmActiveCheck.AutoSize = true;
            this.AlarmActiveCheck.Location = new System.Drawing.Point(7, 14);
            this.AlarmActiveCheck.Name = "AlarmActiveCheck";
            this.AlarmActiveCheck.Size = new System.Drawing.Size(56, 17);
            this.AlarmActiveCheck.TabIndex = 0;
            this.AlarmActiveCheck.Text = "Active";
            this.AlarmActiveCheck.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(203, 14);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(56, 23);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Remove";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // EditAlarmButton
            // 
            this.EditAlarmButton.Location = new System.Drawing.Point(155, 14);
            this.EditAlarmButton.Name = "EditAlarmButton";
            this.EditAlarmButton.Size = new System.Drawing.Size(42, 23);
            this.EditAlarmButton.TabIndex = 2;
            this.EditAlarmButton.Text = "Edit";
            this.EditAlarmButton.UseVisualStyleBackColor = true;
            // 
            // AlarmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 261);
            this.Controls.Add(this.AlarmLine);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlarmList";
            this.Text = "iTunes Alarms";
            this.AlarmLine.ResumeLayout(false);
            this.AlarmLine.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AlarmLine;
        private System.Windows.Forms.Button EditAlarmButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.CheckBox AlarmActiveCheck;
    }
}