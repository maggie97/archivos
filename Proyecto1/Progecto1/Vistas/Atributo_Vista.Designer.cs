namespace Proyecto1
{
    partial class Atributo_Vista
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.clm_Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clm_Dir = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clm_Tipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clm_Longitud = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clm_TipoIndice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clm_DirIndice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clm_SigAtrib = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Window;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clm_Nombre,
            this.clm_Dir,
            this.clm_Tipo,
            this.clm_Longitud,
            this.clm_TipoIndice,
            this.clm_DirIndice,
            this.clm_SigAtrib});
            this.listView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(807, 413);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // clm_Nombre
            // 
            this.clm_Nombre.Text = "Nombre";
            this.clm_Nombre.Width = 105;
            // 
            // clm_Dir
            // 
            this.clm_Dir.Text = "Direccion";
            this.clm_Dir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clm_Dir.Width = 105;
            // 
            // clm_Tipo
            // 
            this.clm_Tipo.Text = "Tipo";
            this.clm_Tipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clm_Tipo.Width = 105;
            // 
            // clm_Longitud
            // 
            this.clm_Longitud.Text = "Longitud";
            this.clm_Longitud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clm_Longitud.Width = 105;
            // 
            // clm_TipoIndice
            // 
            this.clm_TipoIndice.Text = "TipoIndice";
            this.clm_TipoIndice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clm_TipoIndice.Width = 105;
            // 
            // clm_DirIndice
            // 
            this.clm_DirIndice.Text = "Direcc Indice";
            this.clm_DirIndice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clm_DirIndice.Width = 112;
            // 
            // clm_SigAtrib
            // 
            this.clm_SigAtrib.Text = "Direccion Sig Atributo";
            this.clm_SigAtrib.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clm_SigAtrib.Width = 145;
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 437);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Editor";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Editor";
            this.Load += new System.EventHandler(this.Editor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader clm_Nombre;
        private System.Windows.Forms.ColumnHeader clm_Dir;
        private System.Windows.Forms.ColumnHeader clm_Tipo;
        private System.Windows.Forms.ColumnHeader clm_Longitud;
        private System.Windows.Forms.ColumnHeader clm_TipoIndice;
        private System.Windows.Forms.ColumnHeader clm_DirIndice;
        private System.Windows.Forms.ColumnHeader clm_SigAtrib;
    }
}