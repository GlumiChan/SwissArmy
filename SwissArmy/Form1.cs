using System;
using System.Windows.Forms;
using SwissArmy.Modules;
using System.Diagnostics;

namespace SwissArmy
{
    public partial class Form1 : Form
    {
        #region Form1 Stuff
        public Form1()
        {
            InitializeComponent();
        }
        private void Init()
        {
            this.Text = Settings.SOFTWARE_NAME + " " + Settings.VERSION;
            MainNotify.Text = Settings.SOFTWARE_NAME + " " + Settings.VERSION;

            Core.RunThread(HideThis);
        }
        private void HideThis()
        {
            Invoker.ChangeVisible(this, false);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Generator_Button_Click(object sender, EventArgs e)
        {
            if (!StringGeneratorForm.open)
            {
                StringGeneratorForm frm = new StringGeneratorForm();
                frm.Show();
            }
        }
        #endregion
        #region Other Calls
        private void generatorString10LenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Core.GenerateString(15, true, true, true));
        }

        private void generateString10LenMD5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Core.MD5Hash(Core.GenerateString(15, true, true, true)));
        }

        private void generateString10LenSHA1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Core.SHA1Hash(Core.GenerateString(15, true, true, true)));
        }
        #endregion

        #region Module Calls
        private void basepathMoverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Management<FileBaseMover> modInit = Management<FileBaseMover>.InitModule();
            modInit.AddDialog(true, "Base Mover", "Enter your basepath");
            modInit.RunModule();
        }

        private void pHPDocSearchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Management<PHPDocs> modInit = Management<PHPDocs>.InitModule();
            modInit.AddDialog(true, "PHP Documenation search", "Search term: ");
            modInit.RunModule();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Management<YoutubeDownloader> modInit = Management<YoutubeDownloader>.InitModule();
            modInit.AddDialog(true, "Youtube Download", "Youtube ID/URL");
            modInit.RunModule();
        }

        private void iPLookupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Management<IPLookup> modInit = Management<IPLookup>.InitModule();
            string def = Core.IsIP(Clipboard.GetText()) ? Clipboard.GetText() : "";
            modInit.AddDialog(false, "IP Lookup", "Enter IP", def);
            modInit.RunModule();
        }
        #endregion

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SwissArmy " + Settings.VERSION + Environment.NewLine + "Coder: http://boehmer.pro/");
        }

        private void visitCoderpageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://boehmer.pro");
        }
    }
}
