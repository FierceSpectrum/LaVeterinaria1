namespace LaVeterinaria1
{
    partial class InMedicamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InMedicamento));
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtMedicamento = new System.Windows.Forms.TextBox();
            this.PEnfermedad = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cmb_Mascota = new System.Windows.Forms.ComboBox();
            this.Cmb_enfermedad = new System.Windows.Forms.ComboBox();
            this.Enfermedad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(247, 438);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 23);
            this.button3.TabIndex = 54;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(132, 438);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 23);
            this.button2.TabIndex = 53;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(2, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 52;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtMedicamento
            // 
            this.TxtMedicamento.Location = new System.Drawing.Point(177, 142);
            this.TxtMedicamento.Name = "TxtMedicamento";
            this.TxtMedicamento.Size = new System.Drawing.Size(134, 20);
            this.TxtMedicamento.TabIndex = 51;
            this.TxtMedicamento.TextChanged += new System.EventHandler(this.TxtEnfermedad_TextChanged);
            // 
            // PEnfermedad
            // 
            this.PEnfermedad.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PEnfermedad.Location = new System.Drawing.Point(317, 63);
            this.PEnfermedad.Name = "PEnfermedad";
            this.PEnfermedad.Size = new System.Drawing.Size(238, 355);
            this.PEnfermedad.TabIndex = 49;
            this.PEnfermedad.Paint += new System.Windows.Forms.PaintEventHandler(this.PEnfermedad_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "Medicamento";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Mascota";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 24);
            this.label1.TabIndex = 46;
            this.label1.Text = "Registrar Medicamento\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Cmb_Mascota
            // 
            this.Cmb_Mascota.FormattingEnabled = true;
            this.Cmb_Mascota.Items.AddRange(new object[] {
            "Hola\t",
            "que",
            "hace",
            "todo",
            "bien?"});
            this.Cmb_Mascota.Location = new System.Drawing.Point(177, 93);
            this.Cmb_Mascota.Margin = new System.Windows.Forms.Padding(4);
            this.Cmb_Mascota.Name = "Cmb_Mascota";
            this.Cmb_Mascota.Size = new System.Drawing.Size(133, 21);
            this.Cmb_Mascota.TabIndex = 6;
            // 
            // Cmb_enfermedad
            // 
            this.Cmb_enfermedad.FormattingEnabled = true;
            this.Cmb_enfermedad.Items.AddRange(new object[] {
            "Hola\t",
            "que",
            "hace",
            "todo",
            "bien?"});
            this.Cmb_enfermedad.Location = new System.Drawing.Point(177, 189);
            this.Cmb_enfermedad.Margin = new System.Windows.Forms.Padding(4);
            this.Cmb_enfermedad.Name = "Cmb_enfermedad";
            this.Cmb_enfermedad.Size = new System.Drawing.Size(133, 21);
            this.Cmb_enfermedad.TabIndex = 55;
            // 
            // Enfermedad
            // 
            this.Enfermedad.AutoSize = true;
            this.Enfermedad.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Enfermedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enfermedad.Location = new System.Drawing.Point(12, 190);
            this.Enfermedad.Name = "Enfermedad";
            this.Enfermedad.Size = new System.Drawing.Size(97, 20);
            this.Enfermedad.TabIndex = 56;
            this.Enfermedad.Text = "Enfermedad";
            // 
            // InMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(557, 487);
            this.Controls.Add(this.Cmb_enfermedad);
            this.Controls.Add(this.Enfermedad);
            this.Controls.Add(this.Cmb_Mascota);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtMedicamento);
            this.Controls.Add(this.PEnfermedad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InMedicamento";
            this.Text = "InMedicamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtMedicamento;
        private System.Windows.Forms.Panel PEnfermedad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cmb_Mascota;
        private System.Windows.Forms.ComboBox Cmb_enfermedad;
        private System.Windows.Forms.Label Enfermedad;
    }
}