namespace SwissArmy
{
    partial class StringGeneratorForm
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
            this.Checkbox_Numeric = new MetroFramework.Controls.MetroCheckBox();
            this.Checkbox_SpecialChars = new MetroFramework.Controls.MetroCheckBox();
            this.Checkbox_LowerCase = new MetroFramework.Controls.MetroCheckBox();
            this.Checkbox_UpperCase = new MetroFramework.Controls.MetroCheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.Checkbox_MD5 = new MetroFramework.Controls.MetroCheckBox();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.Checkbox_SHA1 = new MetroFramework.Controls.MetroCheckBox();
            this.metroTextBox4 = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Checkbox_Numeric
            // 
            this.Checkbox_Numeric.AutoSize = true;
            this.Checkbox_Numeric.Location = new System.Drawing.Point(140, 75);
            this.Checkbox_Numeric.Name = "Checkbox_Numeric";
            this.Checkbox_Numeric.Size = new System.Drawing.Size(69, 15);
            this.Checkbox_Numeric.TabIndex = 0;
            this.Checkbox_Numeric.Text = "Numeric";
            this.Checkbox_Numeric.UseSelectable = true;
            // 
            // Checkbox_SpecialChars
            // 
            this.Checkbox_SpecialChars.AutoSize = true;
            this.Checkbox_SpecialChars.Location = new System.Drawing.Point(23, 120);
            this.Checkbox_SpecialChars.Name = "Checkbox_SpecialChars";
            this.Checkbox_SpecialChars.Size = new System.Drawing.Size(91, 15);
            this.Checkbox_SpecialChars.TabIndex = 2;
            this.Checkbox_SpecialChars.Text = "Special chars";
            this.Checkbox_SpecialChars.UseSelectable = true;
            this.Checkbox_SpecialChars.CheckedChanged += new System.EventHandler(this.Checkbox_SpecialChars_CheckedChanged_1);
            // 
            // Checkbox_LowerCase
            // 
            this.Checkbox_LowerCase.AutoSize = true;
            this.Checkbox_LowerCase.Location = new System.Drawing.Point(248, 75);
            this.Checkbox_LowerCase.Name = "Checkbox_LowerCase";
            this.Checkbox_LowerCase.Size = new System.Drawing.Size(81, 15);
            this.Checkbox_LowerCase.TabIndex = 3;
            this.Checkbox_LowerCase.Text = "Lower case";
            this.Checkbox_LowerCase.UseSelectable = true;
            // 
            // Checkbox_UpperCase
            // 
            this.Checkbox_UpperCase.AutoSize = true;
            this.Checkbox_UpperCase.Location = new System.Drawing.Point(366, 75);
            this.Checkbox_UpperCase.Name = "Checkbox_UpperCase";
            this.Checkbox_UpperCase.Size = new System.Drawing.Size(81, 15);
            this.Checkbox_UpperCase.TabIndex = 4;
            this.Checkbox_UpperCase.Text = "Upper case";
            this.Checkbox_UpperCase.UseSelectable = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(98, 166);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(349, 20);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(20, 166);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(55, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Length: ";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(327, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox1.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(98, 196);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.PromptText = "Output";
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(349, 23);
            this.metroTextBox1.TabIndex = 7;
            this.metroTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMark = "Output";
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(23, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(424, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Lines = new string[0];
            this.metroTextBox2.Location = new System.Drawing.Point(140, 117);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.PromptText = "Type some custom characters";
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(307, 23);
            this.metroTextBox2.TabIndex = 9;
            this.metroTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.Visible = false;
            this.metroTextBox2.WaterMark = "Type some custom characters";
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Checkbox_MD5
            // 
            this.Checkbox_MD5.AutoSize = true;
            this.Checkbox_MD5.Location = new System.Drawing.Point(27, 232);
            this.Checkbox_MD5.Name = "Checkbox_MD5";
            this.Checkbox_MD5.Size = new System.Drawing.Size(51, 15);
            this.Checkbox_MD5.TabIndex = 10;
            this.Checkbox_MD5.Text = " MD5";
            this.Checkbox_MD5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Checkbox_MD5.UseSelectable = true;
            this.Checkbox_MD5.CheckedChanged += new System.EventHandler(this.Checkbox_MD5_CheckedChanged);
            // 
            // metroTextBox3
            // 
            // 
            // 
            // 
            this.metroTextBox3.CustomButton.Image = null;
            this.metroTextBox3.CustomButton.Location = new System.Drawing.Point(327, 1);
            this.metroTextBox3.CustomButton.Name = "";
            this.metroTextBox3.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox3.CustomButton.TabIndex = 1;
            this.metroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox3.CustomButton.UseSelectable = true;
            this.metroTextBox3.CustomButton.Visible = false;
            this.metroTextBox3.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox3.Lines = new string[0];
            this.metroTextBox3.Location = new System.Drawing.Point(98, 224);
            this.metroTextBox3.MaxLength = 32767;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.PromptText = "Hash";
            this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox3.SelectedText = "";
            this.metroTextBox3.SelectionLength = 0;
            this.metroTextBox3.SelectionStart = 0;
            this.metroTextBox3.ShortcutsEnabled = true;
            this.metroTextBox3.Size = new System.Drawing.Size(349, 23);
            this.metroTextBox3.TabIndex = 11;
            this.metroTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextBox3.UseSelectable = true;
            this.metroTextBox3.Visible = false;
            this.metroTextBox3.WaterMark = "Hash";
            this.metroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Checkbox_SHA1
            // 
            this.Checkbox_SHA1.AutoSize = true;
            this.Checkbox_SHA1.Location = new System.Drawing.Point(27, 253);
            this.Checkbox_SHA1.Name = "Checkbox_SHA1";
            this.Checkbox_SHA1.Size = new System.Drawing.Size(52, 15);
            this.Checkbox_SHA1.TabIndex = 12;
            this.Checkbox_SHA1.Text = "SHA1";
            this.Checkbox_SHA1.UseSelectable = true;
            this.Checkbox_SHA1.CheckedChanged += new System.EventHandler(this.Checkbox_SHA1_CheckedChanged);
            // 
            // metroTextBox4
            // 
            // 
            // 
            // 
            this.metroTextBox4.CustomButton.Image = null;
            this.metroTextBox4.CustomButton.Location = new System.Drawing.Point(327, 1);
            this.metroTextBox4.CustomButton.Name = "";
            this.metroTextBox4.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox4.CustomButton.TabIndex = 1;
            this.metroTextBox4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox4.CustomButton.UseSelectable = true;
            this.metroTextBox4.CustomButton.Visible = false;
            this.metroTextBox4.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox4.Lines = new string[0];
            this.metroTextBox4.Location = new System.Drawing.Point(98, 253);
            this.metroTextBox4.MaxLength = 32767;
            this.metroTextBox4.Name = "metroTextBox4";
            this.metroTextBox4.PasswordChar = '\0';
            this.metroTextBox4.PromptText = "Hash";
            this.metroTextBox4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox4.SelectedText = "";
            this.metroTextBox4.SelectionLength = 0;
            this.metroTextBox4.SelectionStart = 0;
            this.metroTextBox4.ShortcutsEnabled = true;
            this.metroTextBox4.Size = new System.Drawing.Size(349, 23);
            this.metroTextBox4.TabIndex = 13;
            this.metroTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextBox4.UseSelectable = true;
            this.metroTextBox4.Visible = false;
            this.metroTextBox4.WaterMark = "Hash";
            this.metroTextBox4.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox4.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // StringGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 320);
            this.Controls.Add(this.metroTextBox4);
            this.Controls.Add(this.Checkbox_SHA1);
            this.Controls.Add(this.metroTextBox3);
            this.Controls.Add(this.Checkbox_MD5);
            this.Controls.Add(this.metroTextBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.Checkbox_UpperCase);
            this.Controls.Add(this.Checkbox_LowerCase);
            this.Controls.Add(this.Checkbox_SpecialChars);
            this.Controls.Add(this.Checkbox_Numeric);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StringGeneratorForm";
            this.Resizable = false;
            this.Text = "String Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StringGeneratorForm_FormClosing);
            this.Load += new System.EventHandler(this.StringGeneratorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroCheckBox Checkbox_Numeric;
        private MetroFramework.Controls.MetroCheckBox Checkbox_SpecialChars;
        private MetroFramework.Controls.MetroCheckBox Checkbox_LowerCase;
        private MetroFramework.Controls.MetroCheckBox Checkbox_UpperCase;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroCheckBox Checkbox_MD5;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroCheckBox Checkbox_SHA1;
        private MetroFramework.Controls.MetroTextBox metroTextBox4;
    }
}