﻿namespace Proyecto1
{
    partial class SoloEntidades
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
            this.clm_SigAtrib = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clm_DirAtr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clm_Dirl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Window;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clm_Nombre,
            this.clm_Dir,
            this.clm_DirAtr,
            this.clm_Dirl,
            this.clm_SigAtrib});
            this.listView1.Cursor = System.Windows.Forms.Cursors.Help;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(10, 10);
            this.listView1.Margin = new System.Windows.Forms.Padding(0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(780, 417);
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
            // clm_SigAtrib
            // 
            this.clm_SigAtrib.Text = "Direccion Sig Atributo";
            this.clm_SigAtrib.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clm_SigAtrib.Width = 145;
            // 
            // clm_DirAtr
            // 
            this.clm_DirAtr.Text = "Direccion Atributos";
            this.clm_DirAtr.Width = 126;
            // 
            // clm_Dirl
            // 
            this.clm_Dirl.Text = "Dir";
            // 
            // SoloEntidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 437);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SoloEntidades";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Editor_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader clm_Nombre;
        private System.Windows.Forms.ColumnHeader clm_Dir;
        private System.Windows.Forms.ColumnHeader clm_SigAtrib;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader clm_DirAtr;
        private System.Windows.Forms.ColumnHeader clm_Dirl;
    }
}