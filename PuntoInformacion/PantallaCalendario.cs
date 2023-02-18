using PdfiumViewer;
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
        String filePath;
        public PantallaCalendario()
        {
            InitializeComponent();
            this.filePath = "C:\\Users\\Usuario\\Downloads\\Calendario_2022_2023.pdf";
            cargarPDF();
        }

        private void cargarPDF()
        {
            byte[] bytes = System.IO.File.ReadAllBytes(filePath);
            var stream = new MemoryStream(bytes);
            PdfDocument pdf = PdfDocument.Load(stream);
            pdfViewer1.Document = pdf;
        }
    }
}
