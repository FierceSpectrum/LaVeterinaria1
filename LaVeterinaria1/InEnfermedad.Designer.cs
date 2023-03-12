namespace LaVeterinaria1
{
    partial class InEnfermedad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InEnfermedad));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PEnfermedad = new System.Windows.Forms.Panel();
            this.TxtEnfermedad = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.ListaMascotas = new System.Windows.Forms.ComboBox();
            this.Cmb_mascota = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resgitro de Enfermedades";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mascota:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enfermedad:";
            // 
            // PEnfermedad
            // 
            this.PEnfermedad.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PEnfermedad.Location = new System.Drawing.Point(317, 65);
            this.PEnfermedad.Name = "PEnfermedad";
            this.PEnfermedad.Size = new System.Drawing.Size(238, 355);
            this.PEnfermedad.TabIndex = 3;
            // 
            // TxtEnfermedad
            // 
            this.TxtEnfermedad.Location = new System.Drawing.Point(163, 144);
            this.TxtEnfermedad.Name = "TxtEnfermedad";
            this.TxtEnfermedad.Size = new System.Drawing.Size(148, 20);
            this.TxtEnfermedad.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(247, 440);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 23);
            this.button3.TabIndex = 45;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(132, 440);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 23);
            this.button2.TabIndex = 44;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(2, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 43;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.Location = new System.Drawing.Point(91, 238);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(124, 23);
            this.btBuscar.TabIndex = 46;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.button4_Click);
            // 
            // ListaMascotas
            // 
            this.ListaMascotas.FormattingEnabled = true;
            this.ListaMascotas.Items.AddRange(new object[] {
            "Amarillo",
            "Azul",
            "Rojo",
            "Verde",
            "Negro"});
            this.ListaMascotas.Location = new System.Drawing.Point(61, 268);
            this.ListaMascotas.Margin = new System.Windows.Forms.Padding(4);
            this.ListaMascotas.Name = "ListaMascotas";
            this.ListaMascotas.Size = new System.Drawing.Size(180, 21);
            this.ListaMascotas.TabIndex = 47;
            this.ListaMascotas.Text = "Mascotas";
            // 
            // Cmb_mascota
            // 
            this.Cmb_mascota.FormattingEnabled = true;
            this.Cmb_mascota.Items.AddRange(new object[] {
            "Hola\t",
            "que",
            "hace",
            "todo",
            "bien?"});
            this.Cmb_mascota.Location = new System.Drawing.Point(163, 95);
            this.Cmb_mascota.Margin = new System.Windows.Forms.Padding(4);
            this.Cmb_mascota.Name = "Cmb_mascota";
            this.Cmb_mascota.Size = new System.Drawing.Size(149, 21);
            this.Cmb_mascota.TabIndex = 6;
            // 
            // InEnfermedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(561, 475);
            this.Controls.Add(this.Cmb_mascota);
            this.Controls.Add(this.ListaMascotas);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtEnfermedad);
            this.Controls.Add(this.PEnfermedad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InEnfermedad";
            this.Text = "InEnfermedad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PEnfermedad;
        private System.Windows.Forms.TextBox TxtEnfermedad;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.ComboBox ListaMascotas;
        private System.Windows.Forms.ComboBox Cmb_mascota;
    }
}