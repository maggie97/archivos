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

        FileStream file = null;
        BinaryWriter swriter;
        BinaryReader breader;
        string Nombre;
        long Cabecera;

        List<Object> elementos;
        public ManejadorArch()
        {
            InitializeComponent();
            elementos = new List<Object>();
            vistaComp = new ArchivoCompleto();
            atrb = new SoloAtributos();
            vEnt = new ArchivoEntidades();

            vistaComp.TopLevel = false;
            atrb.TopLevel = false;
            vEnt.TopLevel = false;

            while (panelForms.Controls.Count > 0)
            {
                panelForms.Controls.RemoveAt(0);
            }
            panelForms.Controls.Add(vistaComp);
            panelForms.Controls.Add(atrb);
            panelForms.Controls.Add(vEnt);

            Cabecera = -1;
            file = new FileStream("Ent.dd", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            swriter = new BinaryWriter(file);
            //breader = new BinaryReader(file);
            swriter.Write(Cabecera);
            //file.Close();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ManejadorArch_Load(object sender, EventArgs e)
        {
            //txtLong.Text = file.Length.ToString();
        }
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            file.Close();
            swriter.Close();
            
            elementos = new List<object>();
            vistaComp = new ArchivoCompleto();
            atrb = new SoloAtributos();
            vEnt = new ArchivoEntidades();

            vistaComp.TopLevel = false;
            atrb.TopLevel = false;
            vEnt.TopLevel = false;

            while (panelForms.Controls.Count > 0)
            {
                panelForms.Controls.RemoveAt(0);
            }
            panelForms.Controls.Add(vistaComp);
            panelForms.Controls.Add(atrb);
            panelForms.Controls.Add(vEnt);

            Cabecera = -1;
            file = new FileStream("Ent.dd", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            swriter = new BinaryWriter(file);
            breader = new BinaryReader(file);
            swriter.Write(Cabecera);
            //file.Close();

            Actualiza();

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
                vEnt.nuevaEnt(nueva_ent.Nombre_Entidad.ToString(), swriter, file.Length);
                Actualiza();
            }
        }
        private void Actualiza()
        {
            txtLong.Text = file.Length.ToString();
        }
        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void ManejadorArch_FormClosed(object sender, FormClosedEventArgs e)
        {
            swriter.Close();
            //breader.Close();
        }
    }
}
