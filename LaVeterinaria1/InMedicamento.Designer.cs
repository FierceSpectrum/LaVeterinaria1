﻿namespace LaVeterinaria1
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDueño = new System.Windows.Forms.TextBox();
            this.ListaMascotas = new System.Windows.Forms.ComboBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.TxtMedicamento = new System.Windows.Forms.TextBox();
            this.PEnfermedad = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.LEnfermedad = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.LPeso = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.LAnimal = new System.Windows.Forms.Label();
            this.LRaza = new System.Windows.Forms.Label();
            this.LMedida = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtldDueño = new System.Windows.Forms.Label();
            this.ListaEnfermedades = new System.Windows.Forms.ComboBox();
            this.PEnfermedad.SuspendLayout();
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
            // TxtDueño
            // 
            this.TxtDueño.Location = new System.Drawing.Point(142, 87);
            this.TxtDueño.Name = "TxtDueño";
            this.TxtDueño.Size = new System.Drawing.Size(148, 20);
            this.TxtDueño.TabIndex = 62;
            // 
            // ListaMascotas
            // 
            this.ListaMascotas.DisplayMember = "Nombre";
            this.ListaMascotas.FormattingEnabled = true;
            this.ListaMascotas.Location = new System.Drawing.Point(57, 259);
            this.ListaMascotas.Margin = new System.Windows.Forms.Padding(4);
            this.ListaMascotas.Name = "ListaMascotas";
            this.ListaMascotas.Size = new System.Drawing.Size(180, 21);
            this.ListaMascotas.TabIndex = 61;
            this.ListaMascotas.Text = "Mascotas";
            this.ListaMascotas.SelectedIndexChanged += new System.EventHandler(this.ListaMascotas_SelectedIndexChanged);
            // 
            // btBuscar
            // 
            this.btBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.Location = new System.Drawing.Point(87, 229);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(124, 23);
            this.btBuscar.TabIndex = 60;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // TxtMedicamento
            // 
            this.TxtMedicamento.Location = new System.Drawing.Point(142, 136);
            this.TxtMedicamento.Name = "TxtMedicamento";
            this.TxtMedicamento.Size = new System.Drawing.Size(148, 20);
            this.TxtMedicamento.TabIndex = 59;
            // 
            // PEnfermedad
            // 
            this.PEnfermedad.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PEnfermedad.Controls.Add(this.label2);
            this.PEnfermedad.Controls.Add(this.LEnfermedad);
            this.PEnfermedad.Controls.Add(this.label8);
            this.PEnfermedad.Controls.Add(this.label9);
            this.PEnfermedad.Controls.Add(this.label10);
            this.PEnfermedad.Controls.Add(this.label11);
            this.PEnfermedad.Controls.Add(this.label12);
            this.PEnfermedad.Controls.Add(this.LPeso);
            this.PEnfermedad.Controls.Add(this.LNombre);
            this.PEnfermedad.Controls.Add(this.LAnimal);
            this.PEnfermedad.Controls.Add(this.LRaza);
            this.PEnfermedad.Controls.Add(this.LMedida);
            this.PEnfermedad.Location = new System.Drawing.Point(307, 67);
            this.PEnfermedad.Name = "PEnfermedad";
            this.PEnfermedad.Size = new System.Drawing.Size(238, 324);
            this.PEnfermedad.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Enfermedad:";
            // 
            // LEnfermedad
            // 
            this.LEnfermedad.AutoSize = true;
            this.LEnfermedad.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LEnfermedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEnfermedad.Location = new System.Drawing.Point(131, 262);
            this.LEnfermedad.Name = "LEnfermedad";
            this.LEnfermedad.Size = new System.Drawing.Size(99, 20);
            this.LEnfermedad.TabIndex = 47;
            this.LEnfermedad.Text = "__________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 46;
            this.label8.Text = "Peso:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 45;
            this.label9.Text = "Nombre:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 20);
            this.label10.TabIndex = 44;
            this.label10.Text = "Tipo Animal:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(25, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 20);
            this.label11.TabIndex = 43;
            this.label11.Text = "Raza:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(25, 213);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 20);
            this.label12.TabIndex = 42;
            this.label12.Text = "Medida:";
            // 
            // LPeso
            // 
            this.LPeso.AutoSize = true;
            this.LPeso.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPeso.Location = new System.Drawing.Point(131, 170);
            this.LPeso.Name = "LPeso";
            this.LPeso.Size = new System.Drawing.Size(90, 20);
            this.LPeso.TabIndex = 41;
            this.LPeso.Text = "_________";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.Location = new System.Drawing.Point(131, 31);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(90, 20);
            this.LNombre.TabIndex = 40;
            this.LNombre.Text = "_________";
            // 
            // LAnimal
            // 
            this.LAnimal.AutoSize = true;
            this.LAnimal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAnimal.Location = new System.Drawing.Point(131, 75);
            this.LAnimal.Name = "LAnimal";
            this.LAnimal.Size = new System.Drawing.Size(90, 20);
            this.LAnimal.TabIndex = 39;
            this.LAnimal.Text = "_________";
            // 
            // LRaza
            // 
            this.LRaza.AutoSize = true;
            this.LRaza.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LRaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRaza.Location = new System.Drawing.Point(131, 123);
            this.LRaza.Name = "LRaza";
            this.LRaza.Size = new System.Drawing.Size(90, 20);
            this.LRaza.TabIndex = 38;
            this.LRaza.Text = "_________";
            // 
            // LMedida
            // 
            this.LMedida.AutoSize = true;
            this.LMedida.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LMedida.Location = new System.Drawing.Point(131, 213);
            this.LMedida.Name = "LMedida";
            this.LMedida.Size = new System.Drawing.Size(90, 20);
            this.LMedida.TabIndex = 37;
            this.LMedida.Text = "_________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 57;
            this.label3.Text = "Medicamento:";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // TxtldDueño
            // 
            this.TxtldDueño.AutoSize = true;
            this.TxtldDueño.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtldDueño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtldDueño.Location = new System.Drawing.Point(8, 87);
            this.TxtldDueño.Name = "TxtldDueño";
            this.TxtldDueño.Size = new System.Drawing.Size(107, 20);
            this.TxtldDueño.TabIndex = 56;
            this.TxtldDueño.Text = "Identificación:";
            // 
            // ListaEnfermedades
            // 
            this.ListaEnfermedades.DisplayMember = "NEfermedad";
            this.ListaEnfermedades.FormattingEnabled = true;
            this.ListaEnfermedades.Location = new System.Drawing.Point(57, 288);
            this.ListaEnfermedades.Margin = new System.Windows.Forms.Padding(4);
            this.ListaEnfermedades.Name = "ListaEnfermedades";
            this.ListaEnfermedades.Size = new System.Drawing.Size(180, 21);
            this.ListaEnfermedades.TabIndex = 63;
            this.ListaEnfermedades.Text = "Enfermedades";
            this.ListaEnfermedades.SelectedIndexChanged += new System.EventHandler(this.ListaEnfermedades_SelectedIndexChanged);
            // 
            // InMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(557, 487);
            this.Controls.Add(this.ListaEnfermedades);
            this.Controls.Add(this.TxtDueño);
            this.Controls.Add(this.ListaMascotas);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.TxtMedicamento);
            this.Controls.Add(this.PEnfermedad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtldDueño);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InMedicamento";
            this.Text = "InMedicamento";
            this.PEnfermedad.ResumeLayout(false);
            this.PEnfermedad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDueño;
        private System.Windows.Forms.ComboBox ListaMascotas;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TextBox TxtMedicamento;
        private System.Windows.Forms.Panel PEnfermedad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label LPeso;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LAnimal;
        private System.Windows.Forms.Label LRaza;
        private System.Windows.Forms.Label LMedida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TxtldDueño;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LEnfermedad;
        private System.Windows.Forms.ComboBox ListaEnfermedades;
    }
}