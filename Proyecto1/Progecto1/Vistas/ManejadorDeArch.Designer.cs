namespace Proyecto1
{
    partial class ManejadorArch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManejadorArch));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarcomoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_ArchivoComp = new System.Windows.Forms.Button();
            this.btn_nvaEntidad = new System.Windows.Forms.Button();
            this.btn_nvoAtributo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Teal;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(961, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.toolStripSeparator,
            this.guardarToolStripMenuItem,
            this.guardarcomoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoToolStripMenuItem.Image")));
            this.nuevoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.nuevoToolStripMenuItem.Text = "&Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("abrirToolStripMenuItem.Image")));
            this.abrirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.abrirToolStripMenuItem.Text = "&Abrir";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(153, 6);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("guardarToolStripMenuItem.Image")));
            this.guardarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.guardarToolStripMenuItem.Text = "&Guardar";
            // 
            // guardarcomoToolStripMenuItem
            // 
            this.guardarcomoToolStripMenuItem.Name = "guardarcomoToolStripMenuItem";
            this.guardarcomoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.guardarcomoToolStripMenuItem.Text = "G&uardar como";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AllowDrop = true;
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Teal;
            this.splitContainer1.Panel1.Controls.Add(this.btn_nuevo);
            this.splitContainer1.Panel1.Controls.Add(this.btn_ArchivoComp);
            this.splitContainer1.Panel1.Controls.Add(this.btn_nvaEntidad);
            this.splitContainer1.Panel1.Controls.Add(this.btn_nvoAtributo);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.ForeColor = System.Drawing.Color.Black;
            this.splitContainer1.Size = new System.Drawing.Size(961, 469);
            this.splitContainer1.SplitterDistance = 182;
            this.splitContainer1.TabIndex = 2;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.Color.LightBlue;
            this.btn_nuevo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo.Location = new System.Drawing.Point(5, 24);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(172, 50);
            this.btn_nuevo.TabIndex = 8;
            this.btn_nuevo.Text = "Nuevo Archivo";
            this.btn_nuevo.UseVisualStyleBackColor = false;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_ArchivoComp
            // 
            this.btn_ArchivoComp.BackColor = System.Drawing.Color.LightBlue;
            this.btn_ArchivoComp.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ArchivoComp.Location = new System.Drawing.Point(5, 80);
            this.btn_ArchivoComp.Name = "btn_ArchivoComp";
            this.btn_ArchivoComp.Size = new System.Drawing.Size(172, 50);
            this.btn_ArchivoComp.TabIndex = 7;
            this.btn_ArchivoComp.Text = "Archivo Completo";
            this.btn_ArchivoComp.UseVisualStyleBackColor = false;
            this.btn_ArchivoComp.Click += new System.EventHandler(this.btn_ArchivoComp_Click);
            // 
            // btn_nvaEntidad
            // 
            this.btn_nvaEntidad.BackColor = System.Drawing.Color.LightBlue;
            this.btn_nvaEntidad.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nvaEntidad.Location = new System.Drawing.Point(5, 188);
            this.btn_nvaEntidad.Name = "btn_nvaEntidad";
            this.btn_nvaEntidad.Size = new System.Drawing.Size(172, 50);
            this.btn_nvaEntidad.TabIndex = 6;
            this.btn_nvaEntidad.Text = "Nueva Entidad";
            this.btn_nvaEntidad.UseVisualStyleBackColor = false;
            // 
            // btn_nvoAtributo
            // 
            this.btn_nvoAtributo.BackColor = System.Drawing.Color.LightBlue;
            this.btn_nvoAtributo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nvoAtributo.Location = new System.Drawing.Point(5, 134);
            this.btn_nvoAtributo.Name = "btn_nvoAtributo";
            this.btn_nvoAtributo.Size = new System.Drawing.Size(172, 50);
            this.btn_nvoAtributo.TabIndex = 5;
            this.btn_nvoAtributo.Text = "Nuevo Atributo";
            this.btn_nvoAtributo.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 0;
            // 
            // ManejadorArch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(961, 493);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ManejadorArch";
            this.Text = "Archivos";
            this.TransparencyKey = System.Drawing.SystemColors.Window;
            this.Load += new System.EventHandler(this.ManejadorArch_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarcomoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_ArchivoComp;
        private System.Windows.Forms.Button btn_nvaEntidad;
        private System.Windows.Forms.Button btn_nvoAtributo;
    }
}

