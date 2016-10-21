namespace NP_Low_Edition.Menus
{
    partial class EsconderArquivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EsconderArquivos));
            this.browserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.getItemBt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.arquivoPego = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.slctFileBt = new System.Windows.Forms.Button();
            this.pathArquivoEsconde = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // getItemBt
            // 
            this.getItemBt.Location = new System.Drawing.Point(15, 71);
            this.getItemBt.Name = "getItemBt";
            this.getItemBt.Size = new System.Drawing.Size(75, 23);
            this.getItemBt.TabIndex = 0;
            this.getItemBt.Text = "Abrir";
            this.getItemBt.UseVisualStyleBackColor = true;
            this.getItemBt.Click += new System.EventHandler(this.browserFile);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Arquivo que será escondido:";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(15, 8);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(508, 23);
            this.progressBar.TabIndex = 2;
            // 
            // arquivoPego
            // 
            this.arquivoPego.Location = new System.Drawing.Point(97, 73);
            this.arquivoPego.Name = "arquivoPego";
            this.arquivoPego.ReadOnly = true;
            this.arquivoPego.Size = new System.Drawing.Size(426, 20);
            this.arquivoPego.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Arquivo que esconderá:";
            // 
            // slctFileBt
            // 
            this.slctFileBt.Location = new System.Drawing.Point(15, 140);
            this.slctFileBt.Name = "slctFileBt";
            this.slctFileBt.Size = new System.Drawing.Size(75, 23);
            this.slctFileBt.TabIndex = 5;
            this.slctFileBt.Text = "Selecionar";
            this.slctFileBt.UseVisualStyleBackColor = true;
            this.slctFileBt.Click += new System.EventHandler(this.hideToBt);
            // 
            // pathArquivoEsconde
            // 
            this.pathArquivoEsconde.Location = new System.Drawing.Point(97, 142);
            this.pathArquivoEsconde.Name = "pathArquivoEsconde";
            this.pathArquivoEsconde.ReadOnly = true;
            this.pathArquivoEsconde.Size = new System.Drawing.Size(426, 20);
            this.pathArquivoEsconde.TabIndex = 6;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // EsconderArquivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 177);
            this.Controls.Add(this.pathArquivoEsconde);
            this.Controls.Add(this.slctFileBt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.arquivoPego);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.getItemBt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(551, 216);
            this.MinimumSize = new System.Drawing.Size(551, 216);
            this.Name = "EsconderArquivos";
            this.Text = "Esconder Arquivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog browserDialog;
        private System.Windows.Forms.Button getItemBt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox arquivoPego;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button slctFileBt;
        private System.Windows.Forms.TextBox pathArquivoEsconde;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}