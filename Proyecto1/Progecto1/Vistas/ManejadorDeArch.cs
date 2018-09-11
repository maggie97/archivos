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
        ArchivoEntidades vEnt;
        List<Object> elementos;
        public ManejadorArch()
        {
            InitializeComponent();
            elementos = new List<Object>();
            vistaComp = new ArchivoCompleto();
            atrb = new SoloAtributos();
            vEnt = new ArchivoEntidades("holi.txt", 1);

            vistaComp.TopLevel = false;
            atrb.TopLevel = false;
            vEnt.TopLevel = false;

            while (contPrincipal.Controls.Count > 0)
            {
                contPrincipal.Controls.RemoveAt(0);
            }
            contPrincipal.Controls.Add(vistaComp);
            contPrincipal.Controls.Add(atrb);
            contPrincipal.Controls.Add(vEnt);
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
            vEnt = new ArchivoEntidades("holi", 1);//Por ahora 

            vistaComp.TopLevel = false;
            atrb.TopLevel = false;
            vEnt.TopLevel = false;

            while (splitContainer1.Panel2.Controls.Count > 0)
            {
                splitContainer1.Panel2.Controls.RemoveAt(0);
            }
            splitContainer1.Panel2.Controls.Add(vistaComp);
            splitContainer1.Panel2.Controls.Add(atrb);
            splitContainer1.Panel2.Controls.Add(vEnt);
        }

        private void btn_ArchivoComp_Click(object sender, EventArgs e)
        {
            vistaComp.Visible = true;
            atrb.Visible = false;
            vEnt.Visible = false;
            vistaComp.Dock = DockStyle.Fill;
        }

        private void btn_Atributos_Click(object sender, EventArgs e)
        {
            vistaComp.Visible = false;
            atrb.Visible = true;
            vEnt.Visible = false;
            atrb.Dock = DockStyle.Fill;
        }

        private void btn_Entidades_Click(object sender, EventArgs e)
        {
            vistaComp.Visible = false;
            atrb.Visible = false;
            vEnt.Visible = true;
            vEnt.Dock = DockStyle.Fill;
        }

        private void btn_nvoAtributo_Click(object sender, EventArgs e)
        {
            Console.Write("Atributo");
        }

        private void btn_nvaEntidad_Click(object sender, EventArgs e)
        {
            NuevaEntidad nueva_ent = new NuevaEntidad();
            if(nueva_ent.ShowDialog() == DialogResult.OK)
            {

                vEnt.nuevaEnt(nueva_ent.Nombre_Entidad);
            }
            
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
