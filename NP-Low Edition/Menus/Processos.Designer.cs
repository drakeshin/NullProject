namespace NP_Low_Edition.Menus
{
    partial class Processos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Processos));
            this.processosSys = new System.Diagnostics.Process();
            this.listProcesso = new System.Windows.Forms.DataGridView();
            this.closeProsBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listProcesso)).BeginInit();
            this.SuspendLayout();
            // 
            // processosSys
            // 
            this.processosSys.StartInfo.Domain = "";
            this.processosSys.StartInfo.LoadUserProfile = false;
            this.processosSys.StartInfo.Password = null;
            this.processosSys.StartInfo.StandardErrorEncoding = null;
            this.processosSys.StartInfo.StandardOutputEncoding = null;
            this.processosSys.StartInfo.UserName = "";
            this.processosSys.SynchronizingObject = this;
            // 
            // listProcesso
            // 
            this.listProcesso.AllowUserToAddRows = false;
            this.listProcesso.AllowUserToDeleteRows = false;
            this.listProcesso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listProcesso.Location = new System.Drawing.Point(12, 12);
            this.listProcesso.Name = "listProcesso";
            this.listProcesso.ReadOnly = true;
            this.listProcesso.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listProcesso.Size = new System.Drawing.Size(232, 389);
            this.listProcesso.TabIndex = 0;
            // 
            // closeProsBt
            // 
            this.closeProsBt.Location = new System.Drawing.Point(250, 12);
            this.closeProsBt.Name = "closeProsBt";
            this.closeProsBt.Size = new System.Drawing.Size(122, 23);
            this.closeProsBt.TabIndex = 1;
            this.closeProsBt.Text = "Fechar Processo";
            this.closeProsBt.UseVisualStyleBackColor = true;
            this.closeProsBt.Click += new System.EventHandler(this.closeProcess);
            // 
            // Processos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 408);
            this.Controls.Add(this.closeProsBt);
            this.Controls.Add(this.listProcesso);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(397, 447);
            this.MinimumSize = new System.Drawing.Size(397, 447);
            this.Name = "Processos";
            this.Text = "Processos";
            this.Load += new System.EventHandler(this.loadAll);
            ((System.ComponentModel.ISupportInitialize)(this.listProcesso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Diagnostics.Process processosSys;
        private System.Windows.Forms.DataGridView listProcesso;
        private System.Windows.Forms.Button closeProsBt;
    }
}