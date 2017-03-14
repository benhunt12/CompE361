namespace PA05
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.alarmPanel = new System.Windows.Forms.Panel();
            this.appointmentPanel = new System.Windows.Forms.Panel();
            this.alarm = new System.Windows.Forms.Label();
            this.appointments = new System.Windows.Forms.Label();
            this.snooze = new System.Windows.Forms.Button();
            this.setAlarm = new System.Windows.Forms.Button();
            this.stopAlarm = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.Button();
            this.hide = new System.Windows.Forms.Button();
            this.alarmSetLabel = new System.Windows.Forms.Label();
            this.alarmLabel = new System.Windows.Forms.Label();
            this.secondsSet = new System.Windows.Forms.NumericUpDown();
            this.minutesSet = new System.Windows.Forms.NumericUpDown();
            this.hoursSet = new System.Windows.Forms.NumericUpDown();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.setSnooze = new System.Windows.Forms.Button();
            this.alarmPanel.SuspendLayout();
            this.appointmentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secondsSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(11, 24);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(72, 31);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(208, 24);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(74, 31);
            this.timeLabel.TabIndex = 1;
            this.timeLabel.Text = "Time";
            // 
            // alarmPanel
            // 
            this.alarmPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.alarmPanel.Controls.Add(this.setSnooze);
            this.alarmPanel.Controls.Add(this.label3);
            this.alarmPanel.Controls.Add(this.label2);
            this.alarmPanel.Controls.Add(this.label1);
            this.alarmPanel.Controls.Add(this.hoursSet);
            this.alarmPanel.Controls.Add(this.minutesSet);
            this.alarmPanel.Controls.Add(this.secondsSet);
            this.alarmPanel.Controls.Add(this.alarmLabel);
            this.alarmPanel.Controls.Add(this.alarmSetLabel);
            this.alarmPanel.Controls.Add(this.stopAlarm);
            this.alarmPanel.Controls.Add(this.setAlarm);
            this.alarmPanel.Controls.Add(this.snooze);
            this.alarmPanel.Controls.Add(this.alarm);
            this.alarmPanel.Location = new System.Drawing.Point(12, 58);
            this.alarmPanel.Name = "alarmPanel";
            this.alarmPanel.Size = new System.Drawing.Size(153, 234);
            this.alarmPanel.TabIndex = 3;
            // 
            // appointmentPanel
            // 
            this.appointmentPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.appointmentPanel.Controls.Add(this.hide);
            this.appointmentPanel.Controls.Add(this.show);
            this.appointmentPanel.Controls.Add(this.appointments);
            this.appointmentPanel.Location = new System.Drawing.Point(191, 58);
            this.appointmentPanel.Name = "appointmentPanel";
            this.appointmentPanel.Size = new System.Drawing.Size(153, 234);
            this.appointmentPanel.TabIndex = 4;
            // 
            // alarm
            // 
            this.alarm.AutoSize = true;
            this.alarm.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarm.Location = new System.Drawing.Point(3, 0);
            this.alarm.Name = "alarm";
            this.alarm.Size = new System.Drawing.Size(46, 20);
            this.alarm.TabIndex = 5;
            this.alarm.Text = "Alarm";
            // 
            // appointments
            // 
            this.appointments.AutoSize = true;
            this.appointments.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointments.Location = new System.Drawing.Point(3, 0);
            this.appointments.Name = "appointments";
            this.appointments.Size = new System.Drawing.Size(98, 20);
            this.appointments.TabIndex = 0;
            this.appointments.Text = "Appointments";
            // 
            // snooze
            // 
            this.snooze.Location = new System.Drawing.Point(5, 208);
            this.snooze.Name = "snooze";
            this.snooze.Size = new System.Drawing.Size(68, 23);
            this.snooze.TabIndex = 6;
            this.snooze.Text = "Snooze";
            this.snooze.UseVisualStyleBackColor = true;
            this.snooze.Click += new System.EventHandler(this.snooze_Click);
            // 
            // setAlarm
            // 
            this.setAlarm.Location = new System.Drawing.Point(3, 150);
            this.setAlarm.Name = "setAlarm";
            this.setAlarm.Size = new System.Drawing.Size(147, 23);
            this.setAlarm.TabIndex = 7;
            this.setAlarm.Text = "Set Alarm";
            this.setAlarm.UseVisualStyleBackColor = true;
            this.setAlarm.Click += new System.EventHandler(this.setAlarm_Click);
            // 
            // stopAlarm
            // 
            this.stopAlarm.Location = new System.Drawing.Point(3, 179);
            this.stopAlarm.Name = "stopAlarm";
            this.stopAlarm.Size = new System.Drawing.Size(147, 23);
            this.stopAlarm.TabIndex = 8;
            this.stopAlarm.Text = "Stop Alarm";
            this.stopAlarm.UseVisualStyleBackColor = true;
            this.stopAlarm.Click += new System.EventHandler(this.stopAlarm_Click);
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(3, 23);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(147, 23);
            this.show.TabIndex = 1;
            this.show.Text = "Show";
            this.show.UseVisualStyleBackColor = true;
            // 
            // hide
            // 
            this.hide.Location = new System.Drawing.Point(3, 52);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(147, 23);
            this.hide.TabIndex = 2;
            this.hide.Text = "Hide";
            this.hide.UseVisualStyleBackColor = true;
            // 
            // alarmSetLabel
            // 
            this.alarmSetLabel.AutoSize = true;
            this.alarmSetLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarmSetLabel.Location = new System.Drawing.Point(23, 31);
            this.alarmSetLabel.Name = "alarmSetLabel";
            this.alarmSetLabel.Size = new System.Drawing.Size(107, 20);
            this.alarmSetLabel.TabIndex = 9;
            this.alarmSetLabel.Text = "Alarm Set Time:";
            // 
            // alarmLabel
            // 
            this.alarmLabel.AutoSize = true;
            this.alarmLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarmLabel.Location = new System.Drawing.Point(44, 61);
            this.alarmLabel.Name = "alarmLabel";
            this.alarmLabel.Size = new System.Drawing.Size(59, 20);
            this.alarmLabel.TabIndex = 10;
            this.alarmLabel.Text = "6:30:00";
            // 
            // secondsSet
            // 
            this.secondsSet.Location = new System.Drawing.Point(102, 123);
            this.secondsSet.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.secondsSet.Name = "secondsSet";
            this.secondsSet.Size = new System.Drawing.Size(39, 21);
            this.secondsSet.TabIndex = 11;
            // 
            // minutesSet
            // 
            this.minutesSet.Location = new System.Drawing.Point(57, 123);
            this.minutesSet.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutesSet.Name = "minutesSet";
            this.minutesSet.Size = new System.Drawing.Size(39, 21);
            this.minutesSet.TabIndex = 12;
            // 
            // hoursSet
            // 
            this.hoursSet.Location = new System.Drawing.Point(12, 123);
            this.hoursSet.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hoursSet.Name = "hoursSet";
            this.hoursSet.Size = new System.Drawing.Size(39, 21);
            this.hoursSet.TabIndex = 13;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Minutes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Seconds";
            // 
            // setSnooze
            // 
            this.setSnooze.Location = new System.Drawing.Point(82, 208);
            this.setSnooze.Name = "setSnooze";
            this.setSnooze.Size = new System.Drawing.Size(68, 23);
            this.setSnooze.TabIndex = 17;
            this.setSnooze.Text = "Set Snooze";
            this.setSnooze.UseVisualStyleBackColor = true;
            this.setSnooze.Click += new System.EventHandler(this.setSnooze_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 304);
            this.Controls.Add(this.appointmentPanel);
            this.Controls.Add(this.alarmPanel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.dateLabel);
            this.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "About TIme";
            this.alarmPanel.ResumeLayout(false);
            this.alarmPanel.PerformLayout();
            this.appointmentPanel.ResumeLayout(false);
            this.appointmentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secondsSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Panel alarmPanel;
        private System.Windows.Forms.Panel appointmentPanel;
        private System.Windows.Forms.Label alarm;
        private System.Windows.Forms.Label appointments;
        private System.Windows.Forms.Button stopAlarm;
        private System.Windows.Forms.Button setAlarm;
        private System.Windows.Forms.Button snooze;
        private System.Windows.Forms.Button hide;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Label alarmLabel;
        private System.Windows.Forms.Label alarmSetLabel;
        private System.Windows.Forms.NumericUpDown secondsSet;
        private System.Windows.Forms.NumericUpDown hoursSet;
        private System.Windows.Forms.NumericUpDown minutesSet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button setSnooze;
    }
}

