namespace PA04
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
            this.rbtn_PrintAll = new System.Windows.Forms.RadioButton();
            this.rbtn_Ryhming = new System.Windows.Forms.RadioButton();
            this.rbtn_Scrabble = new System.Windows.Forms.RadioButton();
            this.rbtn_Morph = new System.Windows.Forms.RadioButton();
            this.rbtn_MorphChain = new System.Windows.Forms.RadioButton();
            this.DisplayBox = new System.Windows.Forms.ListBox();
            this.btn_Fill = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.ending = new System.Windows.Forms.TextBox();
            this.starting = new System.Windows.Forms.TextBox();
            this.chainLength = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Label();
            this.end = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.help = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbtn_PrintAll
            // 
            this.rbtn_PrintAll.AutoSize = true;
            this.rbtn_PrintAll.Location = new System.Drawing.Point(12, 12);
            this.rbtn_PrintAll.Name = "rbtn_PrintAll";
            this.rbtn_PrintAll.Size = new System.Drawing.Size(89, 17);
            this.rbtn_PrintAll.TabIndex = 0;
            this.rbtn_PrintAll.TabStop = true;
            this.rbtn_PrintAll.Text = "List All Words";
            this.rbtn_PrintAll.UseVisualStyleBackColor = true;
            this.rbtn_PrintAll.CheckedChanged += new System.EventHandler(this.rbtn_PrintAll_CheckedChanged);
            // 
            // rbtn_Ryhming
            // 
            this.rbtn_Ryhming.AutoSize = true;
            this.rbtn_Ryhming.Location = new System.Drawing.Point(12, 35);
            this.rbtn_Ryhming.Name = "rbtn_Ryhming";
            this.rbtn_Ryhming.Size = new System.Drawing.Size(100, 17);
            this.rbtn_Ryhming.TabIndex = 1;
            this.rbtn_Ryhming.TabStop = true;
            this.rbtn_Ryhming.Text = "Ryhming Words";
            this.rbtn_Ryhming.UseVisualStyleBackColor = true;
            this.rbtn_Ryhming.CheckedChanged += new System.EventHandler(this.rbtn_Ryhming_CheckedChanged);
            // 
            // rbtn_Scrabble
            // 
            this.rbtn_Scrabble.AutoSize = true;
            this.rbtn_Scrabble.Location = new System.Drawing.Point(11, 58);
            this.rbtn_Scrabble.Name = "rbtn_Scrabble";
            this.rbtn_Scrabble.Size = new System.Drawing.Size(101, 17);
            this.rbtn_Scrabble.TabIndex = 2;
            this.rbtn_Scrabble.TabStop = true;
            this.rbtn_Scrabble.Text = "Scrabble Words";
            this.rbtn_Scrabble.UseVisualStyleBackColor = true;
            this.rbtn_Scrabble.CheckedChanged += new System.EventHandler(this.rbtn_Scrabble_CheckedChanged);
            // 
            // rbtn_Morph
            // 
            this.rbtn_Morph.AutoSize = true;
            this.rbtn_Morph.Location = new System.Drawing.Point(12, 81);
            this.rbtn_Morph.Name = "rbtn_Morph";
            this.rbtn_Morph.Size = new System.Drawing.Size(89, 17);
            this.rbtn_Morph.TabIndex = 3;
            this.rbtn_Morph.TabStop = true;
            this.rbtn_Morph.Text = "Morph Words";
            this.rbtn_Morph.UseVisualStyleBackColor = true;
            this.rbtn_Morph.CheckedChanged += new System.EventHandler(this.rbtn_Morph_CheckedChanged);
            // 
            // rbtn_MorphChain
            // 
            this.rbtn_MorphChain.AutoSize = true;
            this.rbtn_MorphChain.Location = new System.Drawing.Point(11, 104);
            this.rbtn_MorphChain.Name = "rbtn_MorphChain";
            this.rbtn_MorphChain.Size = new System.Drawing.Size(85, 17);
            this.rbtn_MorphChain.TabIndex = 4;
            this.rbtn_MorphChain.TabStop = true;
            this.rbtn_MorphChain.Text = "Morph Chain";
            this.rbtn_MorphChain.UseVisualStyleBackColor = true;
            this.rbtn_MorphChain.CheckedChanged += new System.EventHandler(this.rbtn_MorphChain_CheckedChanged);
            // 
            // DisplayBox
            // 
            this.DisplayBox.FormattingEnabled = true;
            this.DisplayBox.Location = new System.Drawing.Point(252, 81);
            this.DisplayBox.Name = "DisplayBox";
            this.DisplayBox.Size = new System.Drawing.Size(218, 238);
            this.DisplayBox.TabIndex = 5;
            // 
            // btn_Fill
            // 
            this.btn_Fill.Location = new System.Drawing.Point(252, 52);
            this.btn_Fill.Name = "btn_Fill";
            this.btn_Fill.Size = new System.Drawing.Size(75, 23);
            this.btn_Fill.TabIndex = 8;
            this.btn_Fill.Text = "Fill";
            this.btn_Fill.UseVisualStyleBackColor = true;
            this.btn_Fill.Click += new System.EventHandler(this.btn_Fill_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(395, 52);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 9;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // ending
            // 
            this.ending.Enabled = false;
            this.ending.Location = new System.Drawing.Point(162, 158);
            this.ending.Name = "ending";
            this.ending.Size = new System.Drawing.Size(87, 20);
            this.ending.TabIndex = 10;
            // 
            // starting
            // 
            this.starting.Enabled = false;
            this.starting.Location = new System.Drawing.Point(162, 101);
            this.starting.Name = "starting";
            this.starting.Size = new System.Drawing.Size(87, 20);
            this.starting.TabIndex = 11;
            // 
            // chainLength
            // 
            this.chainLength.Location = new System.Drawing.Point(162, 213);
            this.chainLength.Name = "chainLength";
            this.chainLength.Size = new System.Drawing.Size(87, 20);
            this.chainLength.TabIndex = 12;
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.Location = new System.Drawing.Point(159, 85);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(29, 13);
            this.start.TabIndex = 13;
            this.start.Text = "Start";
            // 
            // end
            // 
            this.end.AutoSize = true;
            this.end.Location = new System.Drawing.Point(162, 142);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(26, 13);
            this.end.TabIndex = 14;
            this.end.Text = "End";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Max Chain Length";
            // 
            // help
            // 
            this.help.Location = new System.Drawing.Point(11, 305);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(75, 23);
            this.help.TabIndex = 16;
            this.help.Text = "Help";
            this.help.UseVisualStyleBackColor = true;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 340);
            this.Controls.Add(this.help);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.end);
            this.Controls.Add(this.start);
            this.Controls.Add(this.chainLength);
            this.Controls.Add(this.starting);
            this.Controls.Add(this.ending);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Fill);
            this.Controls.Add(this.DisplayBox);
            this.Controls.Add(this.rbtn_MorphChain);
            this.Controls.Add(this.rbtn_Morph);
            this.Controls.Add(this.rbtn_Scrabble);
            this.Controls.Add(this.rbtn_Ryhming);
            this.Controls.Add(this.rbtn_PrintAll);
            this.Name = "Form1";
            this.Text = "PA04";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtn_PrintAll;
        private System.Windows.Forms.RadioButton rbtn_Ryhming;
        private System.Windows.Forms.RadioButton rbtn_Scrabble;
        private System.Windows.Forms.RadioButton rbtn_Morph;
        private System.Windows.Forms.RadioButton rbtn_MorphChain;
        private System.Windows.Forms.ListBox DisplayBox;
        private System.Windows.Forms.Button btn_Fill;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.TextBox ending;
        private System.Windows.Forms.TextBox starting;
        private System.Windows.Forms.TextBox chainLength;
        private System.Windows.Forms.Label start;
        private System.Windows.Forms.Label end;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button help;
    }
}

