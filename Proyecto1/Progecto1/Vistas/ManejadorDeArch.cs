using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Windows.Forms;


namespace Proyecto1
{
    public partial class ManejadorArch : Form
    {
        ArchivoCompleto V_Atributo;
        List<Object> elementos;
        public ManejadorArch()
        {
            InitializeComponent();
            elementos = new List<Object>();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ManejadorArch_Load(object sender, EventArgs e)
        {

        }
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            elementos = new List<object>();
            V_Atributo = new ArchivoCompleto();
            V_Atributo.TopLevel = false;
        }

        private void btn_ArchivoComp_Click(object sender, EventArgs e)
        {
            V_Atributo.Visible = true;
            V_Atributo.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(V_Atributo);
        }
    }
}
