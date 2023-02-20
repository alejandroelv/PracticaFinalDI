using AxAcroPDFLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoInformacion
{
    public partial class FormAdministrador : Form
    {
        Form1 formulario;
        public FormAdministrador()
        {
            InitializeComponent();
        }

        public FormAdministrador(Form1 formulario)
        {
            InitializeComponent();
            this.formulario = formulario;
        }

        private void buttonCalendario_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                almacenarRutaCalendario(openFileDialog1.FileName);
                this.formulario.recargarCalendario();
            }
        }

        private void almacenarRutaCalendario(String ruta)
        {
             System.IO.File.WriteAllText("../../rutaCalendario.txt", ruta);
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.formulario.modoAdministrador = false;
            this.Dispose();
        }
    }
}
