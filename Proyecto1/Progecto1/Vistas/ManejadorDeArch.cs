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
        ArchivoCompleto vistaComp;
        SoloAtributos atrb;
        SoloEntidades ent;
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
            vistaComp = new ArchivoCompleto();
            atrb = new SoloAtributos();
            ent = new SoloEntidades();

            vistaComp.TopLevel = false;
            atrb.TopLevel = false;
            ent.TopLevel = false;

            while (splitContainer1.Panel2.Controls.Count > 0)
            {
                splitContainer1.Panel2.Controls.RemoveAt(0);
            }
            splitContainer1.Panel2.Controls.Add(vistaComp);
            splitContainer1.Panel2.Controls.Add(atrb);
            splitContainer1.Panel2.Controls.Add(ent);
        }

        private void btn_ArchivoComp_Click(object sender, EventArgs e)
        {
            vistaComp.Visible = true;
            atrb.Visible = false;
            ent.Visible = false;
            vistaComp.Dock = DockStyle.Fill;
        }

        private void btn_Atributos_Click(object sender, EventArgs e)
        {
            vistaComp.Visible = false;
            atrb.Visible = true;
            ent.Visible = false;
            atrb.Dock = DockStyle.Fill;
        }

        private void btn_Entidades_Click(object sender, EventArgs e)
        {
            vistaComp.Visible = false;
            atrb.Visible = false;
            ent.Visible = true;
            ent.Dock = DockStyle.Fill;
        }
    }
}
