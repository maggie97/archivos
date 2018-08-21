using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progecto1
{
    public partial class Editor : Form
    {
        
        /// <summary>
        /// El constructor de Editor sirve para crear la 
        /// pestaña en donde se realizaran las acciones a capturar 
        /// </summary>
        /// <param name="Nombre">Nombre del proyecto</param>
        /// <param name="n"> Número de pestaña </param>
        public Editor(string Nombre, int n)
        {
            

            InitializeComponent();
        }

        private void Editor_Load(object sender, EventArgs e)
        {
            
        }
    }
}
