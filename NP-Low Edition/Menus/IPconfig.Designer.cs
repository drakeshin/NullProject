namespace NP_Low_Edition.Menus
{
    partial class IPconfigForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IPconfigForm));
            this.ipConfigBox = new System.Windows.Forms.TextBox();
            this.reloadBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ipConfigBox
            // 
            this.ipConfigBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ipConfigBox.Location = new System.Drawing.Point(0, 0);
            this.ipConfigBox.Multiline = true;
            this.ipConfigBox.Name = "ipConfigBox";
            this.ipConfigBox.ReadOnly = true;
            this.ipConfigBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ipConfigBox.Size = new System.Drawing.Size(592, 303);
            this.ipConfigBox.TabIndex = 0;
            // 
            // reloadBt
            // 
            this.reloadBt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reloadBt.Image = ((System.Drawing.Image)(resources.GetObject("reloadBt.Image")));
            this.reloadBt.Location = new System.Drawing.Point(0, 303);
            this.reloadBt.Name = "reloadBt";
            this.reloadBt.Size = new System.Drawing.Size(592, 30);
            this.reloadBt.TabIndex = 1;
            this.reloadBt.UseVisualStyleBackColor = true;
            this.reloadBt.Click += new System.EventHandler(this.clickReload);
            // 
            // IPconfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 333);
            this.Controls.Add(this.ipConfigBox);
            this.Controls.Add(this.reloadBt);
            this.Name = "IPconfigForm";
            this.Text = "Configurações de IP";
            this.Load += new System.EventHandler(this.carregaConfig);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ipConfigBox;
        private System.Windows.Forms.Button reloadBt;
    }
}