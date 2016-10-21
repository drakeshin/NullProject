namespace NP_Low_Edition.Menus
{
    partial class ArpForm
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
            this.textGetInfo = new System.Windows.Forms.TextBox();
            this.updateBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textGetInfo
            // 
            this.textGetInfo.Location = new System.Drawing.Point(12, 12);
            this.textGetInfo.Multiline = true;
            this.textGetInfo.Name = "textGetInfo";
            this.textGetInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textGetInfo.Size = new System.Drawing.Size(464, 205);
            this.textGetInfo.TabIndex = 0;
            // 
            // updateBt
            // 
            this.updateBt.Location = new System.Drawing.Point(12, 223);
            this.updateBt.Name = "updateBt";
            this.updateBt.Size = new System.Drawing.Size(464, 34);
            this.updateBt.TabIndex = 1;
            this.updateBt.UseVisualStyleBackColor = true;
            // 
            // ArpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 264);
            this.Controls.Add(this.updateBt);
            this.Controls.Add(this.textGetInfo);
            this.Name = "ArpForm";
            this.Text = "Arping Your Network";
            this.Load += new System.EventHandler(this.onLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textGetInfo;
        private System.Windows.Forms.Button updateBt;
    }
}