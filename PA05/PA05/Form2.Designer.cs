namespace PA05
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.snoozeTime = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.setBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.snoozeTime)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Snooze Time";
            // 
            // snoozeTime
            // 
            this.snoozeTime.Location = new System.Drawing.Point(15, 25);
            this.snoozeTime.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.snoozeTime.Name = "snoozeTime";
            this.snoozeTime.Size = new System.Drawing.Size(37, 20);
            this.snoozeTime.TabIndex = 1;
            this.snoozeTime.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "seconds";
            // 
            // setBtn
            // 
            this.setBtn.Location = new System.Drawing.Point(125, 22);
            this.setBtn.Name = "setBtn";
            this.setBtn.Size = new System.Drawing.Size(75, 23);
            this.setBtn.TabIndex = 3;
            this.setBtn.Text = "Set";
            this.setBtn.UseVisualStyleBackColor = true;
            this.setBtn.Click += new System.EventHandler(this.setBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 54);
            this.Controls.Add(this.setBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.snoozeTime);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Snooze";
            ((System.ComponentModel.ISupportInitialize)(this.snoozeTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown snoozeTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button setBtn;
    }
}