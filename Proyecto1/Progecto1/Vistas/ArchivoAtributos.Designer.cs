namespace Proyecto1
{
    partial class SoloAtributos
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
            this.dgvAtributos = new System.Windows.Forms.DataGridView();
            this.clm_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_DirAtr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_TipoD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Long = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Indice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_DirIndice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_SigAtr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtributos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAtributos
            // 
            this.dgvAtributos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtributos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_Nombre,
            this.clm_DirAtr,
            this.clm_TipoD,
            this.clm_Long,
            this.clm_Indice,
            this.clm_DirIndice,
            this.clm_SigAtr});
            this.dgvAtributos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAtributos.EnableHeadersVisualStyles = false;
            this.dgvAtributos.Location = new System.Drawing.Point(14, 13);
            this.dgvAtributos.Name = "dgvAtributos";
            this.dgvAtributos.Size = new System.Drawing.Size(783, 407);
            this.dgvAtributos.TabIndex = 0;
            this.dgvAtributos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // clm_Nombre
            // 
            this.clm_Nombre.HeaderText = "Nombre";
            this.clm_Nombre.Name = "clm_Nombre";
            // 
            // clm_DirAtr
            // 
            this.clm_DirAtr.HeaderText = "Dirección Atributo";
            this.clm_DirAtr.Name = "clm_DirAtr";
            // 
            // clm_TipoD
            // 
            this.clm_TipoD.HeaderText = "Tipo De Dato";
            this.clm_TipoD.Name = "clm_TipoD";
            // 
            // clm_Long
            // 
            this.clm_Long.HeaderText = "Longitud";
            this.clm_Long.Name = "clm_Long";
            // 
            // clm_Indice
            // 
            this.clm_Indice.HeaderText = "Tipo de Indice";
            this.clm_Indice.Name = "clm_Indice";
            // 
            // clm_DirIndice
            // 
            this.clm_DirIndice.HeaderText = "Direccion del Indice";
            this.clm_DirIndice.Name = "clm_DirIndice";
            this.clm_DirIndice.Width = 120;
            // 
            // clm_SigAtr
            // 
            this.clm_SigAtr.HeaderText = "Direccion del Siguiente Atributo";
            this.clm_SigAtr.Name = "clm_SigAtr";
            this.clm_SigAtr.Width = 120;
            // 
            // SoloAtributos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(811, 433);
            this.Controls.Add(this.dgvAtributos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SoloAtributos";
            this.Padding = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Editor_Load);
            this.SizeChanged += new System.EventHandler(this.SoloAtributos_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtributos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAtributos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_DirAtr;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_TipoD;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Long;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Indice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_DirIndice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_SigAtr;
    }
}