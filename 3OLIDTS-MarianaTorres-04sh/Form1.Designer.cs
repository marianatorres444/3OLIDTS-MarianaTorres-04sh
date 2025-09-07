namespace _3OLIDTS_MarianaTorres_04sh
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbnombre = new System.Windows.Forms.Label();
            this.lbapellidos = new System.Windows.Forms.Label();
            this.lbtelefono = new System.Windows.Forms.Label();
            this.lbestatura = new System.Windows.Forms.Label();
            this.lbedad = new System.Windows.Forms.Label();
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.tbapellidos = new System.Windows.Forms.TextBox();
            this.tbtelefono = new System.Windows.Forms.TextBox();
            this.tbestatura = new System.Windows.Forms.TextBox();
            this.tbedad = new System.Windows.Forms.TextBox();
            this.gb = new System.Windows.Forms.GroupBox();
            this.rb = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.gua = new System.Windows.Forms.Button();
            this.lim = new System.Windows.Forms.Button();
            this.gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbnombre
            // 
            this.lbnombre.AutoSize = true;
            this.lbnombre.Font = new System.Drawing.Font("Stencil", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnombre.Location = new System.Drawing.Point(293, 53);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(64, 16);
            this.lbnombre.TabIndex = 0;
            this.lbnombre.Text = "Nombre:";
            // 
            // lbapellidos
            // 
            this.lbapellidos.AutoSize = true;
            this.lbapellidos.Font = new System.Drawing.Font("Stencil", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbapellidos.Location = new System.Drawing.Point(292, 98);
            this.lbapellidos.Name = "lbapellidos";
            this.lbapellidos.Size = new System.Drawing.Size(77, 16);
            this.lbapellidos.TabIndex = 1;
            this.lbapellidos.Text = "Apellidos:";
            // 
            // lbtelefono
            // 
            this.lbtelefono.AutoSize = true;
            this.lbtelefono.Font = new System.Drawing.Font("Stencil", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtelefono.Location = new System.Drawing.Point(293, 143);
            this.lbtelefono.Name = "lbtelefono";
            this.lbtelefono.Size = new System.Drawing.Size(74, 16);
            this.lbtelefono.TabIndex = 2;
            this.lbtelefono.Text = "Teléfono:";
            // 
            // lbestatura
            // 
            this.lbestatura.AutoSize = true;
            this.lbestatura.Font = new System.Drawing.Font("Stencil", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbestatura.Location = new System.Drawing.Point(293, 185);
            this.lbestatura.Name = "lbestatura";
            this.lbestatura.Size = new System.Drawing.Size(76, 16);
            this.lbestatura.TabIndex = 3;
            this.lbestatura.Text = "Estatura:";
            // 
            // lbedad
            // 
            this.lbedad.AutoSize = true;
            this.lbedad.Font = new System.Drawing.Font("Stencil", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbedad.Location = new System.Drawing.Point(304, 241);
            this.lbedad.Name = "lbedad";
            this.lbedad.Size = new System.Drawing.Size(43, 16);
            this.lbedad.TabIndex = 4;
            this.lbedad.Text = "Edad:";
            // 
            // tbnombre
            // 
            this.tbnombre.Location = new System.Drawing.Point(395, 53);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(100, 22);
            this.tbnombre.TabIndex = 5;
            // 
            // tbapellidos
            // 
            this.tbapellidos.Location = new System.Drawing.Point(395, 94);
            this.tbapellidos.Name = "tbapellidos";
            this.tbapellidos.Size = new System.Drawing.Size(100, 22);
            this.tbapellidos.TabIndex = 6;
            // 
            // tbtelefono
            // 
            this.tbtelefono.Location = new System.Drawing.Point(395, 139);
            this.tbtelefono.Name = "tbtelefono";
            this.tbtelefono.Size = new System.Drawing.Size(100, 22);
            this.tbtelefono.TabIndex = 7;
            // 
            // tbestatura
            // 
            this.tbestatura.Location = new System.Drawing.Point(395, 185);
            this.tbestatura.Name = "tbestatura";
            this.tbestatura.Size = new System.Drawing.Size(100, 22);
            this.tbestatura.TabIndex = 8;
            // 
            // tbedad
            // 
            this.tbedad.Location = new System.Drawing.Point(395, 237);
            this.tbedad.Name = "tbedad";
            this.tbedad.Size = new System.Drawing.Size(100, 22);
            this.tbedad.TabIndex = 9;
            // 
            // gb
            // 
            this.gb.BackColor = System.Drawing.Color.IndianRed;
            this.gb.Controls.Add(this.rb2);
            this.gb.Controls.Add(this.rb);
            this.gb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb.Location = new System.Drawing.Point(241, 312);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(335, 100);
            this.gb.TabIndex = 10;
            this.gb.TabStop = false;
            this.gb.Text = "Género";
            // 
            // rb
            // 
            this.rb.AutoSize = true;
            this.rb.Location = new System.Drawing.Point(29, 36);
            this.rb.Name = "rb";
            this.rb.Size = new System.Drawing.Size(102, 20);
            this.rb.TabIndex = 0;
            this.rb.TabStop = true;
            this.rb.Text = "Masculino:";
            this.rb.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(199, 36);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(100, 20);
            this.rb2.TabIndex = 1;
            this.rb2.TabStop = true;
            this.rb2.Text = "Femenino:";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // gua
            // 
            this.gua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gua.Location = new System.Drawing.Point(295, 419);
            this.gua.Name = "gua";
            this.gua.Size = new System.Drawing.Size(74, 32);
            this.gua.TabIndex = 11;
            this.gua.Text = "Guardar";
            this.gua.UseVisualStyleBackColor = false;
            this.gua.Click += new System.EventHandler(this.gua_Click);
            // 
            // lim
            // 
            this.lim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lim.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lim.ForeColor = System.Drawing.Color.Maroon;
            this.lim.Location = new System.Drawing.Point(494, 418);
            this.lim.Name = "lim";
            this.lim.Size = new System.Drawing.Size(82, 33);
            this.lim.TabIndex = 12;
            this.lim.Text = "Limpiar";
            this.lim.UseVisualStyleBackColor = false;
            this.lim.Click += new System.EventHandler(this.lim_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(878, 475);
            this.Controls.Add(this.lim);
            this.Controls.Add(this.gua);
            this.Controls.Add(this.gb);
            this.Controls.Add(this.tbedad);
            this.Controls.Add(this.tbestatura);
            this.Controls.Add(this.tbtelefono);
            this.Controls.Add(this.tbapellidos);
            this.Controls.Add(this.tbnombre);
            this.Controls.Add(this.lbedad);
            this.Controls.Add(this.lbestatura);
            this.Controls.Add(this.lbtelefono);
            this.Controls.Add(this.lbapellidos);
            this.Controls.Add(this.lbnombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbnombre;
        private System.Windows.Forms.Label lbapellidos;
        private System.Windows.Forms.Label lbtelefono;
        private System.Windows.Forms.Label lbestatura;
        private System.Windows.Forms.Label lbedad;
        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.TextBox tbapellidos;
        private System.Windows.Forms.TextBox tbtelefono;
        private System.Windows.Forms.TextBox tbestatura;
        private System.Windows.Forms.TextBox tbedad;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb;
        private System.Windows.Forms.Button gua;
        private System.Windows.Forms.Button lim;
    }
}

