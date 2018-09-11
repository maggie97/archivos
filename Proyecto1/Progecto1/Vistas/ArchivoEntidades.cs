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
        FileStream file = null;
        StreamWriter swriter;
        BinaryReader breader;
        string Nombre;
        long Cabecera;

        /// <summary>
        /// El constructor de Editor sirve para crear la 
        /// pestaña en donde se realizaran las acciones a capturar 
        /// </summary>
        /// <param name="nomb">Nombre del proyecto</param>
        /// <param name="op"> Opcion de abrir o crear</param>
        public ArchivoEntidades(string nomb, int op)
        {
            InitializeComponent();
            Nombre = nomb;
            Cabecera = -1;
            if (op == 0)
                file = File.Open(Nombre, FileMode.Open, FileAccess.ReadWrite);
            else
                file = new FileStream(Nombre, FileMode.Create);
            swriter = new StreamWriter(file);
            breader = new BinaryReader(file);
            swriter.Write(Cabecera);
        }
        private void Editor_Load(object sender, EventArgs e)
        {
           // listView1.Size = new Size(new Point(ClientSize.Width - 22, ClientSize.Height - 22));
        }
        public void nuevaEnt(string nomb)
        {
            try
            {
                Entidad entidad = new Entidad(nomb.ToCharArray(), file.Length, -1, -1);
                swriter.WriteLine(entidad);
                dGVentidad.Rows.Add(entidad.NombreEntidad, entidad.Dir_Entidad, entidad.Dir_Atributos, entidad.Dir_Atributos);
            }
            catch (Exception e)
            {
                Console.WriteLine("causo una excepcion: ", e);
            }
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
            file.Close();
            swriter.Close();
            breader.Close();
        }
    }
}
