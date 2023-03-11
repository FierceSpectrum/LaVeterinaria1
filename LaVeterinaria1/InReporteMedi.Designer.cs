namespace LaVeterinaria1
{
    partial class InReporteMedi
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
            this.TxtRepoMedi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtRepoMedi
            // 
            this.TxtRepoMedi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtRepoMedi.Location = new System.Drawing.Point(46, 30);
            this.TxtRepoMedi.Multiline = true;
            this.TxtRepoMedi.Name = "TxtRepoMedi";
            this.TxtRepoMedi.ReadOnly = true;
            this.TxtRepoMedi.Size = new System.Drawing.Size(445, 396);
            this.TxtRepoMedi.TabIndex = 0;
            // 
            // InReporteMedi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(522, 468);
            this.Controls.Add(this.TxtRepoMedi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InReporteMedi";
            this.Text = "InReporteMedi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtRepoMedi;
    }
}