namespace Proyecto1
{
    partial class ArchivoEntidades
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
            this.dGVentidad = new System.Windows.Forms.DataGridView();
            this.Nomb_Entidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dir_Entidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dir_Atributos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dir_Datos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dir_Sig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGVentidad)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVentidad
            // 
            this.dGVentidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVentidad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nomb_Entidad,
            this.Dir_Entidad,
            this.Dir_Atributos,
            this.Dir_Datos,
            this.Dir_Sig});
            this.dGVentidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVentidad.Location = new System.Drawing.Point(10, 10);
            this.dGVentidad.Name = "dGVentidad";
            this.dGVentidad.Size = new System.Drawing.Size(780, 417);
            this.dGVentidad.TabIndex = 0;
            // 
            // Nomb_Entidad
            // 
            this.Nomb_Entidad.HeaderText = "Nombre Entidad";
            this.Nomb_Entidad.Name = "Nomb_Entidad";
            // 
            // Dir_Entidad
            // 
            this.Dir_Entidad.HeaderText = "Direccion Entidad";
            this.Dir_Entidad.Name = "Dir_Entidad";
            // 
            // Dir_Atributos
            // 
            this.Dir_Atributos.HeaderText = "Direccion Atributos";
            this.Dir_Atributos.Name = "Dir_Atributos";
            // 
            // Dir_Datos
            // 
            this.Dir_Datos.HeaderText = "Direccion Datos";
            this.Dir_Datos.Name = "Dir_Datos";
            // 
            // Dir_Sig
            // 
            this.Dir_Sig.HeaderText = "Direccion Sig Entidad";
            this.Dir_Sig.Name = "Dir_Sig";
            // 
            // ArchivoEntidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 437);
            this.Controls.Add(this.dGVentidad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ArchivoEntidades";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ArchivoEntidades_FormClosing);
            this.Load += new System.EventHandler(this.Editor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVentidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVentidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomb_Entidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dir_Entidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dir_Atributos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dir_Datos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dir_Sig;
    }
}