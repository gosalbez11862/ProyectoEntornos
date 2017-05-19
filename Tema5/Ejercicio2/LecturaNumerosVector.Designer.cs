namespace NavajaSuiza.Tema5.Ejercicio2
{
    /// <summary>
    /// Lee los numeros que introducimos en el vector,
    /// calcula la media despues de a ver llenado el vector 
    /// y por ultimo paso nos mostrara la media del mismo.
    /// </summary>
    partial class LecturaNumerosVector
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
            this.label1 = new System.Windows.Forms.Label();
            this.TNumeros = new System.Windows.Forms.TextBox();
            this.BInsertar = new System.Windows.Forms.Button();
            this.BMostrar = new System.Windows.Forms.Button();
            this.LResultado = new System.Windows.Forms.Label();
            this.LMensaje = new System.Windows.Forms.Label();
            this.LContador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lectura de los 10 primeros numeros";
            // 
            // TNumeros
            // 
            this.TNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TNumeros.Location = new System.Drawing.Point(225, 71);
            this.TNumeros.MaxLength = 9;
            this.TNumeros.Name = "TNumeros";
            this.TNumeros.Size = new System.Drawing.Size(100, 29);
            this.TNumeros.TabIndex = 1;
            this.TNumeros.TextChanged += new System.EventHandler(this.ComprobarTextBox);
            // 
            // BInsertar
            // 
            this.BInsertar.Enabled = false;
            this.BInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BInsertar.Location = new System.Drawing.Point(120, 72);
            this.BInsertar.Name = "BInsertar";
            this.BInsertar.Size = new System.Drawing.Size(86, 29);
            this.BInsertar.TabIndex = 2;
            this.BInsertar.Text = "Insertar";
            this.BInsertar.UseVisualStyleBackColor = true;
            this.BInsertar.Click += new System.EventHandler(this.BInsertar_Click);
            // 
            // BMostrar
            // 
            this.BMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMostrar.Location = new System.Drawing.Point(17, 72);
            this.BMostrar.Name = "BMostrar";
            this.BMostrar.Size = new System.Drawing.Size(86, 29);
            this.BMostrar.TabIndex = 3;
            this.BMostrar.Text = "Mostrar";
            this.BMostrar.UseVisualStyleBackColor = true;
            this.BMostrar.Click += new System.EventHandler(this.BMostrar_Click);
            // 
            // LResultado
            // 
            this.LResultado.AutoSize = true;
            this.LResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LResultado.Location = new System.Drawing.Point(221, 116);
            this.LResultado.Name = "LResultado";
            this.LResultado.Size = new System.Drawing.Size(0, 24);
            this.LResultado.TabIndex = 4;
            // 
            // LMensaje
            // 
            this.LMensaje.AutoSize = true;
            this.LMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LMensaje.Location = new System.Drawing.Point(62, 116);
            this.LMensaje.Name = "LMensaje";
            this.LMensaje.Size = new System.Drawing.Size(144, 24);
            this.LMensaje.TabIndex = 5;
            this.LMensaje.Text = "El resultado es: ";
            // 
            // LContador
            // 
            this.LContador.AutoSize = true;
            this.LContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LContador.Location = new System.Drawing.Point(13, 116);
            this.LContador.Name = "LContador";
            this.LContador.Size = new System.Drawing.Size(0, 24);
            this.LContador.TabIndex = 6;
            // 
            // LecturaNumerosVector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 159);
            this.Controls.Add(this.LContador);
            this.Controls.Add(this.LMensaje);
            this.Controls.Add(this.LResultado);
            this.Controls.Add(this.BMostrar);
            this.Controls.Add(this.BInsertar);
            this.Controls.Add(this.TNumeros);
            this.Controls.Add(this.label1);
            this.Name = "LecturaNumerosVector";
            this.Text = "Ejercicio 2";
            this.Load += new System.EventHandler(this.LecturaNumerosVector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TNumeros;
        private System.Windows.Forms.Button BInsertar;
        private System.Windows.Forms.Button BMostrar;
        private System.Windows.Forms.Label LResultado;
        private System.Windows.Forms.Label LMensaje;
        private System.Windows.Forms.Label LContador;
    }
}