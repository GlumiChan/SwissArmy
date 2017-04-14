namespace SwissArmy
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainNotify = new System.Windows.Forms.NotifyIcon(this.components);
            this.NotifyMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.Generator_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.generatorString10LenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateString10LenMD5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateString10LenSHA1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.modulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basepathMoverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iPLookupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pHPDocSearchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.CloseButton = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitCoderpageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NotifyMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainNotify
            // 
            this.MainNotify.ContextMenuStrip = this.NotifyMenuStrip;
            this.MainNotify.Icon = ((System.Drawing.Icon)(resources.GetObject("MainNotify.Icon")));
            this.MainNotify.Text = "notifyIcon1";
            this.MainNotify.Visible = true;
            // 
            // NotifyMenuStrip
            // 
            this.NotifyMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.Generator_Button,
            this.toolStripMenuItem4,
            this.modulesToolStripMenuItem,
            this.toolStripMenuItem1,
            this.aboutToolStripMenuItem,
            this.CloseButton});
            this.NotifyMenuStrip.Name = "NotifyMenuStrip";
            this.NotifyMenuStrip.Size = new System.Drawing.Size(161, 132);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(157, 6);
            // 
            // Generator_Button
            // 
            this.Generator_Button.BackColor = System.Drawing.Color.Transparent;
            this.Generator_Button.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generatorString10LenToolStripMenuItem,
            this.generateString10LenMD5ToolStripMenuItem,
            this.generateString10LenSHA1ToolStripMenuItem});
            this.Generator_Button.Name = "Generator_Button";
            this.Generator_Button.Size = new System.Drawing.Size(160, 22);
            this.Generator_Button.Text = "String Generator";
            this.Generator_Button.Click += new System.EventHandler(this.Generator_Button_Click);
            // 
            // generatorString10LenToolStripMenuItem
            // 
            this.generatorString10LenToolStripMenuItem.Name = "generatorString10LenToolStripMenuItem";
            this.generatorString10LenToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.generatorString10LenToolStripMenuItem.Text = "Generate String (15 Len)";
            this.generatorString10LenToolStripMenuItem.Click += new System.EventHandler(this.generatorString10LenToolStripMenuItem_Click);
            // 
            // generateString10LenMD5ToolStripMenuItem
            // 
            this.generateString10LenMD5ToolStripMenuItem.Name = "generateString10LenMD5ToolStripMenuItem";
            this.generateString10LenMD5ToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.generateString10LenMD5ToolStripMenuItem.Text = "Generate String (15 Len) (MD5)";
            this.generateString10LenMD5ToolStripMenuItem.Click += new System.EventHandler(this.generateString10LenMD5ToolStripMenuItem_Click);
            // 
            // generateString10LenSHA1ToolStripMenuItem
            // 
            this.generateString10LenSHA1ToolStripMenuItem.Name = "generateString10LenSHA1ToolStripMenuItem";
            this.generateString10LenSHA1ToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.generateString10LenSHA1ToolStripMenuItem.Text = "Generate String (15 Len) (SHA1)";
            this.generateString10LenSHA1ToolStripMenuItem.Click += new System.EventHandler(this.generateString10LenSHA1ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(157, 6);
            // 
            // modulesToolStripMenuItem
            // 
            this.modulesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basepathMoverToolStripMenuItem,
            this.iPLookupToolStripMenuItem,
            this.pHPDocSearchToolStripMenuItem1,
            this.toolStripMenuItem5});
            this.modulesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modulesToolStripMenuItem.Name = "modulesToolStripMenuItem";
            this.modulesToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.modulesToolStripMenuItem.Text = "Modules";
            // 
            // basepathMoverToolStripMenuItem
            // 
            this.basepathMoverToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basepathMoverToolStripMenuItem.Name = "basepathMoverToolStripMenuItem";
            this.basepathMoverToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.basepathMoverToolStripMenuItem.Text = "Basepath Mover";
            this.basepathMoverToolStripMenuItem.Click += new System.EventHandler(this.basepathMoverToolStripMenuItem_Click);
            // 
            // iPLookupToolStripMenuItem
            // 
            this.iPLookupToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iPLookupToolStripMenuItem.Name = "iPLookupToolStripMenuItem";
            this.iPLookupToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.iPLookupToolStripMenuItem.Text = "IP Lookup";
            this.iPLookupToolStripMenuItem.Click += new System.EventHandler(this.iPLookupToolStripMenuItem_Click);
            // 
            // pHPDocSearchToolStripMenuItem1
            // 
            this.pHPDocSearchToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pHPDocSearchToolStripMenuItem1.Name = "pHPDocSearchToolStripMenuItem1";
            this.pHPDocSearchToolStripMenuItem1.Size = new System.Drawing.Size(176, 22);
            this.pHPDocSearchToolStripMenuItem1.Text = "PHP Doc Search";
            this.pHPDocSearchToolStripMenuItem1.Click += new System.EventHandler(this.pHPDocSearchToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(176, 22);
            this.toolStripMenuItem5.Text = "Youtube Download";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(157, 6);
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(160, 22);
            this.CloseButton.Text = "Beenden";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visitCoderpageToolStripMenuItem});
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // visitCoderpageToolStripMenuItem
            // 
            this.visitCoderpageToolStripMenuItem.Name = "visitCoderpageToolStripMenuItem";
            this.visitCoderpageToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.visitCoderpageToolStripMenuItem.Text = "Visit Homepage";
            this.visitCoderpageToolStripMenuItem.Click += new System.EventHandler(this.visitCoderpageToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 185);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "XXXXXXXXXX";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.NotifyMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon MainNotify;
        private System.Windows.Forms.ContextMenuStrip NotifyMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem CloseButton;
        private System.Windows.Forms.ToolStripMenuItem Generator_Button;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem generatorString10LenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateString10LenMD5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateString10LenSHA1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem modulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basepathMoverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pHPDocSearchToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem iPLookupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitCoderpageToolStripMenuItem;
    }
}

