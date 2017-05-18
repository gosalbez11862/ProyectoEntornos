namespace NavajaSuiza.Tema5.Ejercicio3
{
    /// <summary>
    /// 	Introducir 10 numeros en un vector 
    /// 	y leer todos ellos y sacar el menor de todos ellos
    /// </summary>
    partial class NumeroVectorMenor
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
            this.BLeer = new System.Windows.Forms.Button();
            this.BComprobar = new System.Windows.Forms.Button();
            this.TNumero = new System.Windows.Forms.TextBox();
            this.LResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BLeer
            // 
            this.BLeer.Enabled = false;
            this.BLeer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLeer.Location = new System.Drawing.Point(47, 24);
            this.BLeer.Name = "BLeer";
            this.BLeer.Size = new System.Drawing.Size(127, 42);
            this.BLeer.TabIndex = 0;
            this.BLeer.Text = "Insertar";
            this.BLeer.UseVisualStyleBackColor = true;
            this.BLeer.Click += new System.EventHandler(this.BLeer_Click);
            // 
            // BComprobar
            // 
            this.BComprobar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BComprobar.Location = new System.Drawing.Point(47, 162);
            this.BComprobar.Name = "BComprobar";
            this.BComprobar.Size = new System.Drawing.Size(127, 42);
            this.BComprobar.TabIndex = 1;
            this.BComprobar.Text = "Comprobar";
            this.BComprobar.UseVisualStyleBackColor = true;
            this.BComprobar.Click += new System.EventHandler(this.BComprobar_Click);
            // 
            // TNumero
            // 
            this.TNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TNumero.Location = new System.Drawing.Point(47, 97);
            this.TNumero.MaxLength = 9;
            this.TNumero.Name = "TNumero";
            this.TNumero.Size = new System.Drawing.Size(127, 29);
            this.TNumero.TabIndex = 2;
            this.TNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TNumero.TextChanged += new System.EventHandler(this.ComprobarTextBox);
            // 
            // LResultado
            // 
            this.LResultado.AutoSize = true;
            this.LResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LResultado.Location = new System.Drawing.Point(12, 236);
            this.LResultado.Name = "LResultado";
            this.LResultado.Size = new System.Drawing.Size(0, 24);
            this.LResultado.TabIndex = 3;
            // 
            // NumeroVectorMenor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(220, 269);
            this.Controls.Add(this.LResultado);
            this.Controls.Add(this.TNumero);
            this.Controls.Add(this.BComprobar);
            this.Controls.Add(this.BLeer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NumeroVectorMenor";
            this.Text = "Ejercicio 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BLeer;
        private System.Windows.Forms.Button BComprobar;
        private System.Windows.Forms.TextBox TNumero;
        private System.Windows.Forms.Label LResultado;
    }
}