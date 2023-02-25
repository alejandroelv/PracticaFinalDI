using PuntoInformacion.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PuntoInformacion
{
    public partial class PantallaCalendario : UserControl
    {
        String filepath;
        public String archivoRuta { set; get; }
        public PantallaCalendario()
        {
            InitializeComponent();
        }

        private void leerRuta()
        {
            string[] lines = File.ReadAllLines(archivoRuta);
            filepath = lines[0];
        }
        public void cargarPDF()
        {
            leerRuta();
            axAcroPDF1.src = filepath;
        }
    }
}
