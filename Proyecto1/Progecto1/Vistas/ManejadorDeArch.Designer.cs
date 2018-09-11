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
            this.contPrincipal = new System.Windows.Forms.Panel();
            this.btn_Entidades = new System.Windows.Forms.Button();
            this.btn_Atributos = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_nvaEntidad = new System.Windows.Forms.Button();
            this.btn_nvoAtributo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
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
            // contPrincipal
            // 
            this.contPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contPrincipal.Location = new System.Drawing.Point(200, 0);
            this.contPrincipal.Name = "contPrincipal";
            this.contPrincipal.Size = new System.Drawing.Size(761, 493);
            this.contPrincipal.TabIndex = 5;
            // 
            // btn_Entidades
            // 
            this.btn_Entidades.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Entidades.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Entidades.Location = new System.Drawing.Point(12, 65);
            this.btn_Entidades.Name = "btn_Entidades";
            this.btn_Entidades.Size = new System.Drawing.Size(172, 50);
            this.btn_Entidades.TabIndex = 15;
            this.btn_Entidades.Text = "Entidades";
            this.btn_Entidades.UseVisualStyleBackColor = false;
            // 
            // btn_Atributos
            // 
            this.btn_Atributos.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Atributos.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Atributos.Location = new System.Drawing.Point(12, 171);
            this.btn_Atributos.Name = "btn_Atributos";
            this.btn_Atributos.Size = new System.Drawing.Size(172, 50);
            this.btn_Atributos.TabIndex = 14;
            this.btn_Atributos.Text = "Atributos";
            this.btn_Atributos.UseVisualStyleBackColor = false;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.Color.LightBlue;
            this.btn_nuevo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo.Location = new System.Drawing.Point(12, 12);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(172, 50);
            this.btn_nuevo.TabIndex = 13;
            this.btn_nuevo.Text = "Nuevo Archivo";
            this.btn_nuevo.UseVisualStyleBackColor = false;
            // 
            // btn_nvaEntidad
            // 
            this.btn_nvaEntidad.BackColor = System.Drawing.Color.LightBlue;
            this.btn_nvaEntidad.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nvaEntidad.Location = new System.Drawing.Point(12, 117);
            this.btn_nvaEntidad.Name = "btn_nvaEntidad";
            this.btn_nvaEntidad.Size = new System.Drawing.Size(172, 50);
            this.btn_nvaEntidad.TabIndex = 12;
            this.btn_nvaEntidad.Text = "Nueva Entidad";
            this.btn_nvaEntidad.UseVisualStyleBackColor = false;
            // 
            // btn_nvoAtributo
            // 
            this.btn_nvoAtributo.BackColor = System.Drawing.Color.LightBlue;
            this.btn_nvoAtributo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nvoAtributo.Location = new System.Drawing.Point(12, 224);
            this.btn_nvoAtributo.Name = "btn_nvoAtributo";
            this.btn_nvoAtributo.Size = new System.Drawing.Size(172, 50);
            this.btn_nvoAtributo.TabIndex = 11;
            this.btn_nvoAtributo.Text = "Nuevo Atributo";
            this.btn_nvoAtributo.UseVisualStyleBackColor = false;
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
            this.Load += new System.EventHandler(this.ManejadorArch_Load);
            this.panel1.ResumeLayout(false);
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
    }
}

