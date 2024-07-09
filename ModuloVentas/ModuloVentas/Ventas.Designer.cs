namespace ModuloVentas
{
    partial class frmVentas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            this.ctmVentas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tipoDeVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metodoPagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculoVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnrArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnrHerramientas = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnrConfiguracion = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impresionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnrDocumentos = new System.Windows.Forms.ToolStripMenuItem();
            this.regresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnrAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mnrSI = new System.Windows.Forms.ToolStripMenuItem();
            this.mnrEquipo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnrManual = new System.Windows.Forms.ToolStripMenuItem();
            this.mnrOtros = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anularVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDeVentasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ctmVentas.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctmVentas
            // 
            this.ctmVentas.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctmVentas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoDeVentaToolStripMenuItem,
            this.metodoPagoToolStripMenuItem,
            this.detalleVentaToolStripMenuItem,
            this.calculoVentaToolStripMenuItem});
            this.ctmVentas.Name = "ctmVentas";
            this.ctmVentas.Size = new System.Drawing.Size(173, 100);
            this.ctmVentas.Text = "Ventas";
            // 
            // tipoDeVentaToolStripMenuItem
            // 
            this.tipoDeVentaToolStripMenuItem.Name = "tipoDeVentaToolStripMenuItem";
            this.tipoDeVentaToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.tipoDeVentaToolStripMenuItem.Text = "Tipo De Venta";
            // 
            // metodoPagoToolStripMenuItem
            // 
            this.metodoPagoToolStripMenuItem.Name = "metodoPagoToolStripMenuItem";
            this.metodoPagoToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.metodoPagoToolStripMenuItem.Text = "Metodo Pago";
            // 
            // detalleVentaToolStripMenuItem
            // 
            this.detalleVentaToolStripMenuItem.Name = "detalleVentaToolStripMenuItem";
            this.detalleVentaToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.detalleVentaToolStripMenuItem.Text = "Detalle Venta";
            // 
            // calculoVentaToolStripMenuItem
            // 
            this.calculoVentaToolStripMenuItem.Name = "calculoVentaToolStripMenuItem";
            this.calculoVentaToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.calculoVentaToolStripMenuItem.Text = "Calculo Venta";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnrArchivo,
            this.mnrAyuda,
            this.ingresarVentaToolStripMenuItem,
            this.anularVentasToolStripMenuItem,
            this.historialDeVentasToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1605, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnrArchivo
            // 
            this.mnrArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnrHerramientas,
            this.mnrConfiguracion,
            this.mnrDocumentos,
            this.regresarToolStripMenuItem});
            this.mnrArchivo.Name = "mnrArchivo";
            this.mnrArchivo.Size = new System.Drawing.Size(73, 24);
            this.mnrArchivo.Text = "Archivo";
            this.mnrArchivo.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // mnrHerramientas
            // 
            this.mnrHerramientas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadoraToolStripMenuItem,
            this.excelToolStripMenuItem});
            this.mnrHerramientas.Name = "mnrHerramientas";
            this.mnrHerramientas.Size = new System.Drawing.Size(252, 26);
            this.mnrHerramientas.Text = "Herramientas";
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.excelToolStripMenuItem.Text = "Excel";
            // 
            // mnrConfiguracion
            // 
            this.mnrConfiguracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.impresionToolStripMenuItem,
            this.otrosToolStripMenuItem});
            this.mnrConfiguracion.Name = "mnrConfiguracion";
            this.mnrConfiguracion.Size = new System.Drawing.Size(252, 26);
            this.mnrConfiguracion.Text = "Configuracion";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // impresionToolStripMenuItem
            // 
            this.impresionToolStripMenuItem.Name = "impresionToolStripMenuItem";
            this.impresionToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.impresionToolStripMenuItem.Text = "Impresion";
            // 
            // otrosToolStripMenuItem
            // 
            this.otrosToolStripMenuItem.Name = "otrosToolStripMenuItem";
            this.otrosToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.otrosToolStripMenuItem.Text = "Otros";
            // 
            // mnrDocumentos
            // 
            this.mnrDocumentos.Name = "mnrDocumentos";
            this.mnrDocumentos.Size = new System.Drawing.Size(252, 26);
            this.mnrDocumentos.Text = "Documentos";
            // 
            // regresarToolStripMenuItem
            // 
            this.regresarToolStripMenuItem.Name = "regresarToolStripMenuItem";
            this.regresarToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.regresarToolStripMenuItem.Text = "Regresar Menu Principal";
            this.regresarToolStripMenuItem.Click += new System.EventHandler(this.regresarToolStripMenuItem_Click);
            // 
            // mnrAyuda
            // 
            this.mnrAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnrSI,
            this.mnrEquipo,
            this.mnrManual,
            this.mnrOtros});
            this.mnrAyuda.Name = "mnrAyuda";
            this.mnrAyuda.Size = new System.Drawing.Size(65, 24);
            this.mnrAyuda.Text = "Ayuda";
            // 
            // mnrSI
            // 
            this.mnrSI.Name = "mnrSI";
            this.mnrSI.Size = new System.Drawing.Size(210, 26);
            this.mnrSI.Text = "Sobre el SI";
            // 
            // mnrEquipo
            // 
            this.mnrEquipo.Name = "mnrEquipo";
            this.mnrEquipo.Size = new System.Drawing.Size(210, 26);
            this.mnrEquipo.Text = "Equipo desarrollo";
            // 
            // mnrManual
            // 
            this.mnrManual.Name = "mnrManual";
            this.mnrManual.Size = new System.Drawing.Size(210, 26);
            this.mnrManual.Text = "Manual usuario";
            // 
            // mnrOtros
            // 
            this.mnrOtros.Name = "mnrOtros";
            this.mnrOtros.Size = new System.Drawing.Size(210, 26);
            this.mnrOtros.Text = "Otros";
            // 
            // ingresarVentaToolStripMenuItem
            // 
            this.ingresarVentaToolStripMenuItem.Name = "ingresarVentaToolStripMenuItem";
            this.ingresarVentaToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.ingresarVentaToolStripMenuItem.Text = "Ingresar venta";
            this.ingresarVentaToolStripMenuItem.Click += new System.EventHandler(this.ingresarVentaToolStripMenuItem_Click);
            // 
            // anularVentasToolStripMenuItem
            // 
            this.anularVentasToolStripMenuItem.Name = "anularVentasToolStripMenuItem";
            this.anularVentasToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.anularVentasToolStripMenuItem.Text = "Anular ventas";
            this.anularVentasToolStripMenuItem.Click += new System.EventHandler(this.anularVentasToolStripMenuItem_Click);
            // 
            // historialDeVentasToolStripMenuItem1
            // 
            this.historialDeVentasToolStripMenuItem1.Name = "historialDeVentasToolStripMenuItem1";
            this.historialDeVentasToolStripMenuItem1.Size = new System.Drawing.Size(149, 24);
            this.historialDeVentasToolStripMenuItem1.Text = "Historial De Ventas";
            this.historialDeVentasToolStripMenuItem1.Click += new System.EventHandler(this.historialDeVentasToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(924, 417);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(226)))), ((int)(((byte)(206)))));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(864, 582);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(442, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bienvenido al Modulo de Venta";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ModuloVentas.Properties.Resources.Sales_report_25411;
            this.pictureBox1.Location = new System.Drawing.Point(994, 397);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 167);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ModuloVentas.Properties.Resources.Pan;
            this.ClientSize = new System.Drawing.Size(1605, 752);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.ctmVentas.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip ctmVentas;
        private System.Windows.Forms.ToolStripMenuItem tipoDeVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metodoPagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detalleVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculoVentaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnrArchivo;
        private System.Windows.Forms.ToolStripMenuItem mnrHerramientas;
        private System.Windows.Forms.ToolStripMenuItem mnrConfiguracion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem mnrDocumentos;
        private System.Windows.Forms.ToolStripMenuItem mnrAyuda;
        private System.Windows.Forms.ToolStripMenuItem historialDeVentasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impresionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnrSI;
        private System.Windows.Forms.ToolStripMenuItem mnrEquipo;
        private System.Windows.Forms.ToolStripMenuItem mnrManual;
        private System.Windows.Forms.ToolStripMenuItem mnrOtros;
        private System.Windows.Forms.ToolStripMenuItem regresarToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem ingresarVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anularVentasToolStripMenuItem;
    }
}