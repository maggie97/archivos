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
    public partial class ArchivoEntidades : Form
    { //Solo deberia de leer el archivo (teoricamente)

        List<Entidad> list_entidades, list_insercion;
        string fileName;
        bool vistaArch = true; // archivo

        public List<Entidad> List_entidades { get => list_entidades;  }

        /// <summary>
        /// El constructor de Editor sirve para crear la 
        /// pestaña en donde se realizaran las acciones a capturar 
        /// </summary>
        public ArchivoEntidades(string file)
        {
            InitializeComponent();
            list_entidades = new List<Entidad>();
            list_insercion = new List<Entidad>();
            fileName = file;
            dGVentidad.MultiSelect = false;
        }
        private void Editor_Load(object sender, EventArgs e)
        {
            // listView1.Size = new Size(new Point(ClientSize.Width - 22, ClientSize.Height - 22));
        }
        public long nuevaEnt(string nomb, long finArch)
        {
            long cab = -1;
            try
            {
                long sig_ent = -1;
                if (list_entidades.Count != 0)
                {
                    list_entidades.Last().Dir_sig = finArch;
                }
                Entidad entidad = new Entidad(nomb.ToCharArray(), finArch, -1, sig_ent);
                Console.WriteLine(nomb + entidad.Dir_Entidad.ToString() + entidad.Dir_sig.ToString());
                list_entidades.Add(entidad);
                list_insercion.Add(entidad);
                //Ordena las entidades
                list_entidades = list_entidades.OrderBy(o => o.sNombre).ToList();

                cab = list_entidades[0].Dir_Entidad; //Asigna el valor de la primera entidad a la cabecera 
                savCabecera(cab); //Se sobreescribe la cabecera

                savEntidad(entidad); //Se guarda la nueva entidad.
                ordena();
                reescribe();
            }
            catch (Exception e)
            {
                Console.WriteLine("causo una excepcion: ", e);
            }
            return cab;
        }
        public void ordena()
        {
            list_entidades = list_entidades.OrderBy(o => o.sNombre).ToList();
            for (int i = 0; i < list_entidades.Count - 1; i++)
            {
                list_entidades[i].Dir_sig = list_entidades[i + 1].Dir_Entidad;
            }
            list_entidades.Last().Dir_sig = -1;
            foreach (Entidad e in list_entidades)
            {
                int i = list_insercion.IndexOf(e);
                list_insercion[i] = e;
            }
        }
        public void RefreshGrid()
        {
            vistaArch = true;
            long cab = -1;
            dGVentidad.Rows.Clear();
            using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
            {
                cab = reader.ReadInt64();
                Console.WriteLine(cab);
                int i = 0;
                try
                {
                    while (reader.PeekChar() >= -1)
                    {
                        string nomb = "", dir_ent, dir_atr, dir_dat, dir_sig;
                        char[] nombre = reader.ReadChars(30);
                        foreach (char n in nombre)
                        {
                            nomb += n;
                        }
                        dir_ent = reader.ReadInt64().ToString();
                        dir_atr = reader.ReadInt64().ToString();
                        dir_dat = reader.ReadInt64().ToString();
                        dir_sig = reader.ReadInt64().ToString();
                        //Entidad n = new Entidad(nombre, Convert.ToInt64(dir_ent), dir_atr, dir_dat);
                        Console.WriteLine("{0}, {1}, {2}, {3}, {4}", nomb, dir_ent, dir_atr, dir_dat, dir_sig);
                        dGVentidad.Rows.Add(nomb, dir_ent, dir_atr, dir_dat, dir_sig);
                    }
                }
                catch { }
            }
        }
        public long leeArch()
        {
            vistaArch = true;
            long cab = -1;
            dGVentidad.Rows.Clear();
            using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
            {
                cab = reader.ReadInt64();
                Console.WriteLine(cab);
                int i = 0;
                try
                {
                    while (reader.PeekChar() >= -1)
                    {
                        string nomb = "";
                        long dir_ent, dir_atr, dir_dat, dir_sig;
                        char[] nombre = reader.ReadChars(30);
                        foreach (char n in nombre)
                        {
                            nomb += n;
                        }
                        dir_ent = reader.ReadInt64();
                        dir_atr = reader.ReadInt64();
                        dir_dat = reader.ReadInt64();
                        dir_sig = reader.ReadInt64();
                        Entidad nueva = new Entidad(nombre, dir_ent, dir_atr, dir_dat, dir_sig);
                        list_insercion.Add(nueva);
                        list_entidades.Add(nueva);
                        Console.WriteLine("{0}, {1}, {2}, {3}, {4}", nomb, dir_ent, dir_atr, dir_dat, dir_sig);
                        dGVentidad.Rows.Add(nomb, dir_ent, dir_atr, dir_dat, dir_sig);
                    }
                }
                catch { }
            }
            
            return cab;
        }

        public void savEntidad(Entidad e)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Append)))
            {

                writer.Write(e.NombreEntidad);
                writer.Write(e.Dir_Entidad);
                writer.Write(e.Dir_Atributos);
                writer.Write(e.Dir_Datos);
                writer.Write(e.Dir_sig);
            }
        }

        public void reescribe()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Open)))
            {
                writer.Seek(8, SeekOrigin.Begin);
                foreach (Entidad e in list_insercion)
                {
                    writer.Write(e.NombreEntidad);
                    writer.Write(e.Dir_Entidad);
                    writer.Write(e.Dir_Atributos);
                    writer.Write(e.Dir_Datos);
                    writer.Write(e.Dir_sig);
                }
            }
        }
        public void savCabecera(long primerEntidad)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Open)))
            {
                writer.Seek(0, SeekOrigin.Begin);
                writer.Write(primerEntidad);
            }
            /*using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
            {
                
                Console.WriteLine("Cabecera: " + reader.ReadInt64());
            }/**/
        }
        public long leerCabecera()
        {
            long cab = -1;
            using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
            {
                cab = reader.ReadInt64();
                Console.WriteLine("Cabecera: " + cab );

            }
            return cab;
        }
        public void Actualiza()
        {
            vistaArch = false; // alfabeticamente
            dGVentidad.Rows.Clear();
            try
            {
                foreach (Entidad e in list_entidades)
                {
                    dGVentidad.Rows.Add(e.sNombre, e.Dir_Entidad, e.Dir_Atributos,
                        e.Dir_Atributos, e.Dir_sig);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Excepcion:", ex);
            }
        }
        public void elimina()
        {
            if (!vistaArch)
            {
                foreach (DataGridViewRow r in dGVentidad.SelectedRows)
                {
                    if (!r.IsNewRow)
                    {
                        int i = dGVentidad.Rows.IndexOf(r);
                        dGVentidad.Rows.Remove(r);
                        long ds = list_entidades[i].Dir_sig;
                        //if (list_entidades.Count > i) list_entidades[i + 1].Dir_sig = ds;
                        for(int j = 0; j < list_insercion.Count; j++)
                        {
                            if (list_insercion[j].Dir_sig == list_entidades[i].Dir_Entidad)
                            {
                                list_insercion[j].Dir_sig = ds;
                                int ind = list_insercion.IndexOf(list_entidades[i]);
                                list_insercion[i].Dir_sig = -1;
                            }
                        }
                        
                        list_entidades.RemoveAt(i);
                        Console.WriteLine(i);
                    }


                    Console.WriteLine("");
                }

            }
        }

        private void dGVentidad_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Entidad eMod = list_entidades[e.RowIndex]; 
            string newName = Microsoft.VisualBasic.Interaction.InputBox("Modifica la entidad : " + eMod.sNombre + " " + e.RowIndex, "Modificar", eMod.sNombre, -1, -1);
            eMod.NombreEntidad = newName.ToCharArray(0, 30);
            reescribe();
        }

        private void ArchivoEntidades_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
        
    }
}
