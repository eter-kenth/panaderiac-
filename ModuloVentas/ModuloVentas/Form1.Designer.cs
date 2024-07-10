namespace ModuloVentas
{
    partial class frmControlAcceso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmControlAcceso));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btConectar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.picPanDeVida = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPanDeVida)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(226)))), ((int)(((byte)(206)))));
            this.lblUsuario.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.lblUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblUsuario.Location = new System.Drawing.Point(61, 286);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(161, 33);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(226)))), ((int)(((byte)(206)))));
            this.lblContraseña.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.lblContraseña.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblContraseña.Location = new System.Drawing.Point(61, 343);
            this.lblContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(148, 34);
            this.lblContraseña.TabIndex = 1;
            this.lblContraseña.Text = "Contraseña";
            this.lblContraseña.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txtUsuario.Location = new System.Drawing.Point(253, 286);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(225, 33);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.SystemColors.Window;
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContraseña.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(253, 343);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseña.Multiline = true;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(225, 33);
            this.txtContraseña.TabIndex = 3;
            // 
            // btConectar
            // 
            this.btConectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(226)))), ((int)(((byte)(206)))));
            this.btConectar.FlatAppearance.BorderSize = 0;
            this.btConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConectar.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btConectar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btConectar.Location = new System.Drawing.Point(137, 406);
            this.btConectar.Margin = new System.Windows.Forms.Padding(4);
            this.btConectar.Name = "btConectar";
            this.btConectar.Size = new System.Drawing.Size(100, 28);
            this.btConectar.TabIndex = 4;
            this.btConectar.Text = "Conectar";
            this.btConectar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btConectar.UseVisualStyleBackColor = false;
            this.btConectar.Click += new System.EventHandler(this.btConectar_Click);
            // 
            // btSalir
            // 
            this.btSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(226)))), ((int)(((byte)(206)))));
            this.btSalir.FlatAppearance.BorderSize = 0;
            this.btSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalir.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btSalir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btSalir.Location = new System.Drawing.Point(293, 406);
            this.btSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(100, 28);
            this.btSalir.TabIndex = 5;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = false;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // picPanDeVida
            // 
            this.picPanDeVida.BackColor = System.Drawing.Color.Transparent;
            this.picPanDeVida.Image = global::ModuloVentas.Properties.Resources.Rico_Pansito;
            this.picPanDeVida.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picPanDeVida.Location = new System.Drawing.Point(137, 15);
            this.picPanDeVida.Margin = new System.Windows.Forms.Padding(4);
            this.picPanDeVida.Name = "picPanDeVida";
            this.picPanDeVida.Size = new System.Drawing.Size(307, 255);
            this.picPanDeVida.TabIndex = 6;
            this.picPanDeVida.TabStop = false;
            // 
            // frmControlAcceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::ModuloVentas.Properties.Resources.Pan;
            this.ClientSize = new System.Drawing.Size(521, 452);
            this.Controls.Add(this.picPanDeVida);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btConectar);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmControlAcceso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control De Acceso";
            this.Load += new System.EventHandler(this.frmControlAcceso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPanDeVida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btConectar;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.PictureBox picPanDeVida;
    }
}

