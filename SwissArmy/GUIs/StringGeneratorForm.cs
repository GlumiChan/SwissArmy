using System.Windows.Forms;
using System;
using System.Collections.Generic;

namespace SwissArmy
{
    public partial class StringGeneratorForm : MetroFramework.Forms.MetroForm
    {
        public StringGeneratorForm()
        {
            InitializeComponent();
        }
        public static bool open = false;
        private void GeneratorTrigger()
        {
            string generated = "";
            if (Checkbox_SpecialChars.Checked)
            {
                List<string> specialChars = new List<string>();
                foreach (char chr in metroTextBox2.Text)
                {
                    specialChars.Add(chr.ToString());
                }
                generated = Core.GenerateString((int)numericUpDown1.Value, Checkbox_Numeric.Checked, Checkbox_LowerCase.Checked, Checkbox_UpperCase.Checked, specialChars);
            }
            else
            {
                generated = Core.GenerateString((int)numericUpDown1.Value, Checkbox_Numeric.Checked, Checkbox_LowerCase.Checked, Checkbox_UpperCase.Checked);
            }

            metroTextBox1.Text = generated;
            if (Checkbox_MD5.Checked)
            {
                metroTextBox3.Text = Core.MD5Hash(generated);
            }
            if (Checkbox_SHA1.Checked)
            {
                metroTextBox4.Text = Core.SHA1Hash(generated);
            }
        }
        private void StringGeneratorForm_Load(object sender, EventArgs e)
        {
            open = true;
        }

        private void StringGeneratorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            open = false;
        }
        private void Checkbox_SpecialChars_CheckedChanged(object sender, EventArgs e)
        {
            if (Checkbox_SpecialChars.Checked)
            {
                metroTextBox2.Visible = true;
            }
            else
            {
                metroTextBox2.Visible = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GeneratorTrigger();
        }

        private void Checkbox_SpecialChars_CheckedChanged_1(object sender, EventArgs e)
        {
            if (Checkbox_SpecialChars.Checked)
            {
                metroTextBox2.Visible = true;
            }
            else
            {
                metroTextBox2.Visible = false;
            }
        }

        private void Checkbox_MD5_CheckedChanged(object sender, EventArgs e)
        {
            if (Checkbox_MD5.Checked)
            {
                metroTextBox3.Visible = true;
            }
            else
            {
                metroTextBox3.Visible = false;
            }
            
        }

        private void Checkbox_SHA1_CheckedChanged(object sender, EventArgs e)
        {
            if (Checkbox_SHA1.Checked)
            {
                metroTextBox4.Visible = true;
            }
            else
            {
                metroTextBox4.Visible = false;
            }
        }
    }
}
