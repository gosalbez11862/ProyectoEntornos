namespace NavajaSuiza.Tema4.Ejercicio4
{
    partial class ConvertirPtsEuros
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
            this.BEuros = new System.Windows.Forms.Button();
            this.LPesetas = new System.Windows.Forms.Label();
            this.TPesetas = new System.Windows.Forms.TextBox();
            this.TEuros = new System.Windows.Forms.TextBox();
            this.Euros = new System.Windows.Forms.Label();
            this.BPesetas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BEuros
            // 
            this.BEuros.Enabled = false;
            this.BEuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BEuros.Location = new System.Drawing.Point(167, 138);
            this.BEuros.Name = "BEuros";
            this.BEuros.Size = new System.Drawing.Size(95, 61);
            this.BEuros.TabIndex = 0;
            this.BEuros.Text = "Convertir a Euros";
            this.BEuros.UseVisualStyleBackColor = true;
            this.BEuros.Click += new System.EventHandler(this.BEuros_Click);
            // 
            // LPesetas
            // 
            this.LPesetas.AutoSize = true;
            this.LPesetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPesetas.Location = new System.Drawing.Point(42, 40);
            this.LPesetas.Name = "LPesetas";
            this.LPesetas.Size = new System.Drawing.Size(76, 24);
            this.LPesetas.TabIndex = 1;
            this.LPesetas.Text = "Pesetas";
            // 
            // TPesetas
            // 
            this.TPesetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPesetas.Location = new System.Drawing.Point(134, 37);
            this.TPesetas.MaxLength = 4;
            this.TPesetas.Name = "TPesetas";
            this.TPesetas.Size = new System.Drawing.Size(102, 29);
            this.TPesetas.TabIndex = 2;
            this.TPesetas.TextChanged += new System.EventHandler(this.ComprobarTextBox);
            // 
            // TEuros
            // 
            this.TEuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEuros.Location = new System.Drawing.Point(134, 81);
            this.TEuros.MaxLength = 4;
            this.TEuros.Name = "TEuros";
            this.TEuros.Size = new System.Drawing.Size(102, 29);
            this.TEuros.TabIndex = 4;
            this.TEuros.TextChanged += new System.EventHandler(this.ComprobarTextBox);
            // 
            // Euros
            // 
            this.Euros.AutoSize = true;
            this.Euros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Euros.Location = new System.Drawing.Point(42, 84);
            this.Euros.Name = "Euros";
            this.Euros.Size = new System.Drawing.Size(60, 24);
            this.Euros.TabIndex = 3;
            this.Euros.Text = "Euros";
            // 
            // BPesetas
            // 
            this.BPesetas.Enabled = false;
            this.BPesetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BPesetas.Location = new System.Drawing.Point(25, 138);
            this.BPesetas.Name = "BPesetas";
            this.BPesetas.Size = new System.Drawing.Size(102, 61);
            this.BPesetas.TabIndex = 5;
            this.BPesetas.Text = "Convertir a Pesetas";
            this.BPesetas.UseVisualStyleBackColor = true;
            this.BPesetas.Click += new System.EventHandler(this.BPesetas_Click);
            // 
            // Convertir_PTS_Euros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 215);
            this.Controls.Add(this.BPesetas);
            this.Controls.Add(this.TEuros);
            this.Controls.Add(this.Euros);
            this.Controls.Add(this.TPesetas);
            this.Controls.Add(this.LPesetas);
            this.Controls.Add(this.BEuros);
            this.Name = "Convertir_PTS_Euros";
            this.Text = "Convertir_PTS_Euros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BEuros;
        private System.Windows.Forms.Label LPesetas;
        private System.Windows.Forms.TextBox TPesetas;
        private System.Windows.Forms.TextBox TEuros;
        private System.Windows.Forms.Label Euros;
        private System.Windows.Forms.Button BPesetas;
    }
}