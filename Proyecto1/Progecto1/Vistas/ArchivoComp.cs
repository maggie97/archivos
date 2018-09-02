using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1
{
    public partial class ArchivoCompleto
        : Form
    {
        
        /// <summary>
        /// El constructor de Editor sirve para crear la 
        /// pestaña en donde se realizaran las acciones a capturar 
        /// </summary>
        /// <param name="Nombre">Nombre del proyecto</param>
        /// <param name="n"> Número de pestaña </param>
        public ArchivoCompleto(string Nombre, int n)
        {
            InitializeComponent();
        }
        public ArchivoCompleto()
        {
            InitializeComponent();
        }
        
        private void Editor_Load(object sender, EventArgs e)
        {
            listView1.Size = new Size(new Point(ClientSize.Width - 22, ClientSize.Height - 22));
        }
    }
}
