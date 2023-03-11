namespace LaVeterinaria1
{
    partial class InReportesEn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InReportesEn));
            this.TxtRepoteEnfe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtRepoteEnfe
            // 
            this.TxtRepoteEnfe.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtRepoteEnfe.Location = new System.Drawing.Point(54, 23);
            this.TxtRepoteEnfe.Multiline = true;
            this.TxtRepoteEnfe.Name = "TxtRepoteEnfe";
            this.TxtRepoteEnfe.ReadOnly = true;
            this.TxtRepoteEnfe.Size = new System.Drawing.Size(445, 413);
            this.TxtRepoteEnfe.TabIndex = 0;
            // 
            // InReportesEn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(525, 468);
            this.Controls.Add(this.TxtRepoteEnfe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InReportesEn";
            this.Text = "InReportesEn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtRepoteEnfe;
    }
}