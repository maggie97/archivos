using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Proyecto1
{
    public partial class ArchivoEntidades : Form
    { //Solo deberia de leer el archivo (teoricamente)

        List<Entidad> list_entidades;
        FileStream f;
        /// <summary>
        /// El constructor de Editor sirve para crear la 
        /// pestaña en donde se realizaran las acciones a capturar 
        /// </summary>
        public ArchivoEntidades(FileStream file)
        {
            InitializeComponent();
            list_entidades = new List<Entidad>();
            f = file;
        }
        private void Editor_Load(object sender, EventArgs e)
        {
           // listView1.Size = new Size(new Point(ClientSize.Width - 22, ClientSize.Height - 22));
        }
        public void nuevaEnt(string nomb, BinaryWriter bw, long finArch)
        {
            try
            {
                long sig_ent = -1;
                if (list_entidades.Count != 0)
                    list_entidades.Last().Dir_sig = finArch;
                Entidad entidad = new Entidad(nomb.ToCharArray(), finArch, -1, sig_ent);
                Console.WriteLine(nomb, entidad.Dir_Entidad, entidad.Dir_sig);
                list_entidades.Add(entidad);
                dGVentidad.Rows.Add(nomb, entidad.Dir_Entidad, entidad.Dir_Atributos, entidad.Dir_Atributos, entidad.Dir_sig);
                saveLast(bw, entidad);
            }
            catch (Exception e)
            {
                Console.WriteLine("causo una excepcion: ", e);
            }
            
        }

        public void saveLast(BinaryWriter bw, Entidad e)
        {
            bw.Write(e.NombreEntidad);
            bw.Write(e.Dir_Entidad);
            bw.Write(e.Dir_Atributos);
            bw.Write(e.Dir_Atributos);
            bw.Write(e.Dir_sig);
        }

        public void Actualiza()
        {
            dGVentidad.Rows.Clear();
            try
            {
            }
            catch
            {

            }
        }

        private void ArchivoEntidades_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
