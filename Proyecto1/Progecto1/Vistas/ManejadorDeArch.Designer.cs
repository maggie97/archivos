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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Abrir = new System.Windows.Forms.Button();
            this.btn_ElimAtrib = new System.Windows.Forms.Button();
            this.btn_EliminaEnt = new System.Windows.Forms.Button();
            this.btn_Entidades = new System.Windows.Forms.Button();
            this.btn_Atributos = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_nvaEntidad = new System.Windows.Forms.Button();
            this.btn_nvoAtributo = new System.Windows.Forms.Button();
            this.contPrincipal = new System.Windows.Forms.Panel();
            this.panelForms = new System.Windows.Forms.Panel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cabeceraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_Cabecera = new System.Windows.Forms.ToolStripTextBox();
            this.longArchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtLong = new System.Windows.Forms.ToolStripTextBox();
            this.vistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alfabeticamenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.contPrincipal.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_Cerrar);
            this.panel1.Controls.Add(this.btn_Abrir);
            this.panel1.Controls.Add(this.btn_ElimAtrib);
            this.panel1.Controls.Add(this.btn_EliminaEnt);
            this.panel1.Controls.Add(this.btn_Entidades);
            this.panel1.Controls.Add(this.btn_Atributos);
            this.panel1.Controls.Add(this.btn_nuevo);
            this.panel1.Controls.Add(this.btn_nvaEntidad);
            this.panel1.Controls.Add(this.btn_nvoAtributo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 493);
            this.panel1.TabIndex = 4;
            // 
            // btn_Abrir
            // 
            this.btn_Abrir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Abrir.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Abrir.Location = new System.Drawing.Point(12, 14);
            this.btn_Abrir.Name = "btn_Abrir";
            this.btn_Abrir.Size = new System.Drawing.Size(172, 50);
            this.btn_Abrir.TabIndex = 21;
            this.btn_Abrir.Text = "Abrir Archivo";
            this.btn_Abrir.UseVisualStyleBackColor = false;
            this.btn_Abrir.Click += new System.EventHandler(this.btn_Abrir_Click);
            // 
            // btn_ElimAtrib
            // 
            this.btn_ElimAtrib.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ElimAtrib.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ElimAtrib.Location = new System.Drawing.Point(40, 362);
            this.btn_ElimAtrib.Name = "btn_ElimAtrib";
            this.btn_ElimAtrib.Size = new System.Drawing.Size(144, 36);
            this.btn_ElimAtrib.TabIndex = 20;
            this.btn_ElimAtrib.Text = "Elimina Atributo";
            this.btn_ElimAtrib.UseVisualStyleBackColor = false;
            // 
            // btn_EliminaEnt
            // 
            this.btn_EliminaEnt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_EliminaEnt.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EliminaEnt.Location = new System.Drawing.Point(40, 217);
            this.btn_EliminaEnt.Name = "btn_EliminaEnt";
            this.btn_EliminaEnt.Size = new System.Drawing.Size(144, 36);
            this.btn_EliminaEnt.TabIndex = 18;
            this.btn_EliminaEnt.Text = "Elimina Entidad";
            this.btn_EliminaEnt.UseVisualStyleBackColor = false;
            this.btn_EliminaEnt.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Entidades
            // 
            this.btn_Entidades.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Entidades.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Entidades.Location = new System.Drawing.Point(12, 123);
            this.btn_Entidades.Name = "btn_Entidades";
            this.btn_Entidades.Size = new System.Drawing.Size(172, 50);
            this.btn_Entidades.TabIndex = 15;
            this.btn_Entidades.Text = "Entidades";
            this.btn_Entidades.UseVisualStyleBackColor = false;
            this.btn_Entidades.Click += new System.EventHandler(this.btn_Entidades_Click);
            // 
            // btn_Atributos
            // 
            this.btn_Atributos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Atributos.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Atributos.Location = new System.Drawing.Point(12, 259);
            this.btn_Atributos.Name = "btn_Atributos";
            this.btn_Atributos.Size = new System.Drawing.Size(172, 54);
            this.btn_Atributos.TabIndex = 14;
            this.btn_Atributos.Text = "Atributos";
            this.btn_Atributos.UseVisualStyleBackColor = false;
            this.btn_Atributos.Click += new System.EventHandler(this.btn_Atributos_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_nuevo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo.Location = new System.Drawing.Point(12, 70);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(172, 50);
            this.btn_nuevo.TabIndex = 13;
            this.btn_nuevo.Text = "Nuevo Archivo";
            this.btn_nuevo.UseVisualStyleBackColor = false;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_nvaEntidad
            // 
            this.btn_nvaEntidad.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_nvaEntidad.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nvaEntidad.Location = new System.Drawing.Point(40, 175);
            this.btn_nvaEntidad.Name = "btn_nvaEntidad";
            this.btn_nvaEntidad.Size = new System.Drawing.Size(144, 36);
            this.btn_nvaEntidad.TabIndex = 12;
            this.btn_nvaEntidad.Text = "Nueva Entidad";
            this.btn_nvaEntidad.UseVisualStyleBackColor = false;
            this.btn_nvaEntidad.Click += new System.EventHandler(this.btn_nvaEntidad_Click);
            // 
            // btn_nvoAtributo
            // 
            this.btn_nvoAtributo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_nvoAtributo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nvoAtributo.Location = new System.Drawing.Point(40, 319);
            this.btn_nvoAtributo.Name = "btn_nvoAtributo";
            this.btn_nvoAtributo.Size = new System.Drawing.Size(144, 34);
            this.btn_nvoAtributo.TabIndex = 11;
            this.btn_nvoAtributo.Text = "Nuevo Atributo";
            this.btn_nvoAtributo.UseVisualStyleBackColor = false;
            this.btn_nvoAtributo.Click += new System.EventHandler(this.btn_nvoAtributo_Click);
            // 
            // contPrincipal
            // 
            this.contPrincipal.Controls.Add(this.panelForms);
            this.contPrincipal.Controls.Add(this.panelInfo);
            this.contPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contPrincipal.Location = new System.Drawing.Point(200, 0);
            this.contPrincipal.Name = "contPrincipal";
            this.contPrincipal.Size = new System.Drawing.Size(761, 493);
            this.contPrincipal.TabIndex = 5;
            // 
            // panelForms
            // 
            this.panelForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForms.Location = new System.Drawing.Point(0, 30);
            this.panelForms.Name = "panelForms";
            this.panelForms.Size = new System.Drawing.Size(761, 463);
            this.panelForms.TabIndex = 1;
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.menuStrip1);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(761, 30);
            this.panelInfo.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cabeceraToolStripMenuItem,
            this.txt_Cabecera,
            this.longArchToolStripMenuItem,
            this.txtLong,
            this.vistaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(1);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(761, 27);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cabeceraToolStripMenuItem
            // 
            this.cabeceraToolStripMenuItem.Name = "cabeceraToolStripMenuItem";
            this.cabeceraToolStripMenuItem.Size = new System.Drawing.Size(68, 23);
            this.cabeceraToolStripMenuItem.Text = "Cabecera";
            // 
            // txt_Cabecera
            // 
            this.txt_Cabecera.Enabled = false;
            this.txt_Cabecera.Name = "txt_Cabecera";
            this.txt_Cabecera.Size = new System.Drawing.Size(100, 23);
            // 
            // longArchToolStripMenuItem
            // 
            this.longArchToolStripMenuItem.Enabled = false;
            this.longArchToolStripMenuItem.Name = "longArchToolStripMenuItem";
            this.longArchToolStripMenuItem.Size = new System.Drawing.Size(74, 23);
            this.longArchToolStripMenuItem.Text = "Long Arch";
            // 
            // txtLong
            // 
            this.txtLong.Enabled = false;
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(100, 23);
            // 
            // vistaToolStripMenuItem
            // 
            this.vistaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alfabeticamenteToolStripMenuItem,
            this.archivoToolStripMenuItem});
            this.vistaToolStripMenuItem.Name = "vistaToolStripMenuItem";
            this.vistaToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
            this.vistaToolStripMenuItem.Text = "Vista";
            // 
            // alfabeticamenteToolStripMenuItem
            // 
            this.alfabeticamenteToolStripMenuItem.Name = "alfabeticamenteToolStripMenuItem";
            this.alfabeticamenteToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.alfabeticamenteToolStripMenuItem.Text = "Alfabeticamente";
            this.alfabeticamenteToolStripMenuItem.Click += new System.EventHandler(this.btn_Act_Click);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.archivoToolStripMenuItem.Text = "Archivo";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.btn_ActArch_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Cerrar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cerrar.Location = new System.Drawing.Point(12, 404);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(172, 54);
            this.btn_Cerrar.TabIndex = 22;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // ManejadorArch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(961, 493);
            this.Controls.Add(this.contPrincipal);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "ManejadorArch";
            this.Text = "Archivos";
            this.TransparencyKey = System.Drawing.SystemColors.Window;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManejadorArch_FormClosed);
            this.Load += new System.EventHandler(this.ManejadorArch_Load);
            this.panel1.ResumeLayout(false);
            this.contPrincipal.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Entidades;
        private System.Windows.Forms.Button btn_Atributos;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_nvaEntidad;
        private System.Windows.Forms.Button btn_nvoAtributo;
        private System.Windows.Forms.Panel contPrincipal;
        private System.Windows.Forms.Panel panelForms;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cabeceraToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox txt_Cabecera;
        private System.Windows.Forms.ToolStripMenuItem longArchToolStripMenuItem;
        private  System.Windows.Forms.ToolStripTextBox txtLong;
        private System.Windows.Forms.Button btn_ElimAtrib;
        private System.Windows.Forms.Button btn_EliminaEnt;
        private System.Windows.Forms.ToolStripMenuItem vistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alfabeticamenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.Button btn_Abrir;
        private System.Windows.Forms.Button btn_Cerrar;
    }
}

