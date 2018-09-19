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
        
        OpenFileDialog open;
        SaveFileDialog save;
        string NombreArch = "Nuevo";
        long Cabecera;

        List<Object> elementos;
        public ManejadorArch()
        {
            InitializeComponent();

            open = new OpenFileDialog();
            elementos = new List<Object>();
            Cabecera = -1;
            //Hola maggie, apesta a que no funciona >:c (by charles)
            /**/
            while (panelForms.Controls.Count > 0)
            {
                panelForms.Controls.RemoveAt(0);
            }
            
        }


        private void ManejadorArch_Load(object sender, EventArgs e)
        {
            //txtLong.Text = file.Length.ToString();
        }
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            
            elementos = new List<object>();
            nuevo();
            vistaComp = new ArchivoCompleto();
            atrb = new SoloAtributos(NombreArch);
            vEnt = new ArchivoEntidades(NombreArch);

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
            Actualiza();

        }
        private bool nuevo()
        {
            bool r = false;
            using(nuevoArchivo n = new nuevoArchivo())
            {
                if(n.ShowDialog() == DialogResult.OK)
                {
                    NombreArch = n.Path;
                    Cabecera = -1;
                    //using (FileStream f = new FileStream(NombreArch, FileMode.Create))
                    using(BinaryWriter writer = new BinaryWriter(File.Open(NombreArch, FileMode.Create)))
                    {
                        writer.Write(Cabecera);
                        txt_Cabecera.Text = Cabecera.ToString();
                    }
                    r = true;
                }
            }
            return r;
        }
        private void abrir(string nombre)
        {
            NombreArch = nombre;
            vistaComp = new ArchivoCompleto();
            atrb = new SoloAtributos(nombre);
            vEnt = new ArchivoEntidades(nombre);

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
            NuevoAtributo nuevo = new NuevoAtributo(vEnt.List_entidades);
            if (nuevo.ShowDialog() == DialogResult.OK)
            {
                vEnt.List_entidades[nuevo.Index].nuevoA(
                    new Atributo(nuevo.Nombre_atributo, Convert.ToInt64(txtLong.Text), nuevo.Tipo, nuevo.Long, 0,-1,  -1));

                Cabecera = atrb.nuevoAtrib(vEnt.List_entidades[nuevo.Index].Atrib.Last(), Convert.ToInt64(txtLong.Text) );
                Actualiza();
            }
        }

        private void btn_nvaEntidad_Click(object sender, EventArgs e)
        {
            NuevaEntidad nueva_ent = new NuevaEntidad();
            if(nueva_ent.ShowDialog() == DialogResult.OK)
            {
                Cabecera = vEnt.nuevaEnt(nueva_ent.Nombre_Entidad.ToString(), Convert.ToInt64(txtLong.Text));
                Actualiza();
            }
        }
        private void Actualiza()
        {
            txt_Cabecera.Text = Cabecera.ToString();
            using (FileStream file = new FileStream(NombreArch, FileMode.Open, FileAccess.Read))
                txtLong.Text = file.Length.ToString();
        }
        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void ManejadorArch_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void btn_Act_Click(object sender, EventArgs e)
        {
            vEnt.Actualiza();
        }

        private void btn_ActArch_Click(object sender, EventArgs e)
        {
            try
            {
                vEnt.RefreshGrid();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Excepcion: " + ex + " Generada en Actualiza Arch");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vEnt.elimina();
        }

        private void btn_Abrir_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog open = new OpenFileDialog())
            {
                if(open.ShowDialog() == DialogResult.OK)
                {
                    //vEnt = new ArchivoEntidades(open.FileName);
                    abrir(open.FileName);
                    Cabecera = vEnt.leeArch();
                    Actualiza();
                }
            }
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            btn_Atributos.Enabled = false;
            btn_Entidades.Enabled = false;
            btn_nvaEntidad.Enabled = false;
            btn_nvoAtributo.Enabled = false;
            btn_EliminaEnt.Enabled = false;
            btn_ElimAtrib.Enabled = false;
        }


    }
}
