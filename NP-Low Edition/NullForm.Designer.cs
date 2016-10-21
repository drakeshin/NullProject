namespace NP_Low_Edition
{
    partial class NullProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NullProject));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esconderArquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trayCheckBox = new System.Windows.Forms.CheckBox();
            this.lookTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabApp = new System.Windows.Forms.TabControl();
            this.App = new System.Windows.Forms.TabPage();
            this.calcAbrirBT = new System.Windows.Forms.Button();
            this.processoMain = new System.Diagnostics.Process();
            this.menuStrip1.SuspendLayout();
            this.tabApp.SuspendLayout();
            this.App.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.redeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(572, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processosToolStripMenuItem,
            this.esconderArquivoToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // processosToolStripMenuItem
            // 
            this.processosToolStripMenuItem.Name = "processosToolStripMenuItem";
            this.processosToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.processosToolStripMenuItem.Text = "Processos";
            this.processosToolStripMenuItem.Click += new System.EventHandler(this.goToProcess);
            // 
            // esconderArquivoToolStripMenuItem
            // 
            this.esconderArquivoToolStripMenuItem.Name = "esconderArquivoToolStripMenuItem";
            this.esconderArquivoToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.esconderArquivoToolStripMenuItem.Text = "Esconder Arquivo";
            this.esconderArquivoToolStripMenuItem.Click += new System.EventHandler(this.abrirFormEsconder);
            // 
            // redeToolStripMenuItem
            // 
            this.redeToolStripMenuItem.Name = "redeToolStripMenuItem";
            this.redeToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.redeToolStripMenuItem.Text = "Rede";
            // 
            // trayCheckBox
            // 
            this.trayCheckBox.AutoSize = true;
            this.trayCheckBox.Location = new System.Drawing.Point(512, 3);
            this.trayCheckBox.Name = "trayCheckBox";
            this.trayCheckBox.Size = new System.Drawing.Size(56, 17);
            this.trayCheckBox.TabIndex = 2;
            this.trayCheckBox.Text = "Tray It";
            this.trayCheckBox.UseVisualStyleBackColor = true;
            this.trayCheckBox.CheckStateChanged += new System.EventHandler(this.goTray);
            // 
            // lookTrayIcon
            // 
            this.lookTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("lookTrayIcon.Icon")));
            this.lookTrayIcon.Text = "Null Project";
            this.lookTrayIcon.Visible = true;
            this.lookTrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lookTrayIcon_MouseDoubleClick);
            // 
            // tabApp
            // 
            this.tabApp.Controls.Add(this.App);
            this.tabApp.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabApp.Location = new System.Drawing.Point(0, 24);
            this.tabApp.Name = "tabApp";
            this.tabApp.SelectedIndex = 0;
            this.tabApp.Size = new System.Drawing.Size(217, 406);
            this.tabApp.TabIndex = 3;
            // 
            // App
            // 
            this.App.Controls.Add(this.calcAbrirBT);
            this.App.Location = new System.Drawing.Point(4, 22);
            this.App.Name = "App";
            this.App.Padding = new System.Windows.Forms.Padding(3);
            this.App.Size = new System.Drawing.Size(209, 380);
            this.App.TabIndex = 1;
            this.App.Text = "Aplicações";
            this.App.UseVisualStyleBackColor = true;
            // 
            // calcAbrirBT
            // 
            this.calcAbrirBT.Image = ((System.Drawing.Image)(resources.GetObject("calcAbrirBT.Image")));
            this.calcAbrirBT.Location = new System.Drawing.Point(8, 6);
            this.calcAbrirBT.Name = "calcAbrirBT";
            this.calcAbrirBT.Size = new System.Drawing.Size(64, 64);
            this.calcAbrirBT.TabIndex = 0;
            this.calcAbrirBT.UseVisualStyleBackColor = true;
            this.calcAbrirBT.Click += new System.EventHandler(this.abrirCalcClick);
            // 
            // processoMain
            // 
            this.processoMain.StartInfo.Domain = "";
            this.processoMain.StartInfo.LoadUserProfile = false;
            this.processoMain.StartInfo.Password = null;
            this.processoMain.StartInfo.StandardErrorEncoding = null;
            this.processoMain.StartInfo.StandardOutputEncoding = null;
            this.processoMain.StartInfo.UserName = "";
            this.processoMain.SynchronizingObject = this;
            // 
            // NullProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 430);
            this.Controls.Add(this.tabApp);
            this.Controls.Add(this.trayCheckBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NullProject";
            this.Text = "Null project";
            this.Resize += new System.EventHandler(this.resizing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabApp.ResumeLayout(false);
            this.App.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.CheckBox trayCheckBox;
        private System.Windows.Forms.NotifyIcon lookTrayIcon;
        private System.Windows.Forms.ToolStripMenuItem processosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esconderArquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redeToolStripMenuItem;
        private System.Windows.Forms.TabControl tabApp;
        private System.Windows.Forms.TabPage App;
        private System.Windows.Forms.Button calcAbrirBT;
        private System.Diagnostics.Process processoMain;
    }
}

