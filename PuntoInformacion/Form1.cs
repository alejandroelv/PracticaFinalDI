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

namespace PuntoInformacion
{
    public partial class Form1 : Form
    {
        UserControl pantallaActiva;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.pantallaActiva = this.pantallaInicio1;
            pantallaInicio1.slideshow1.setCarpetaFotos(new System.IO.DirectoryInfo("../../Resources/fotosSlideshow"));
        }

        private void pictureBoxSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ocultarPantallaActiva()
        {
            this.pantallaActiva.Visible = false;
            this.pantallaActiva.SendToBack();
        }

        private void mostrarPantallaActiva()
        {
            this.pantallaActiva.Visible = true;
            this.pantallaActiva.BringToFront();
        }
        private void buttonInicio_Click(object sender, EventArgs e)
        {
            ocultarPantallaActiva();
            this.pantallaActiva = this.pantallaInicio1;
            mostrarPantallaActiva();
        }

        private void buttonContacto_Click(object sender, EventArgs e)
        {
            ocultarPantallaActiva();
            this.pantallaActiva = this.pantallaInformacion1;
            mostrarPantallaActiva();
        }

        private void buttonSugerencias_Click(object sender, EventArgs e)
        {
            ocultarPantallaActiva();
            this.pantallaActiva = this.pantallaSugerencias1;
            mostrarPantallaActiva();
        }

        private void buttonLugaresCercanos_Click(object sender, EventArgs e)
        {
            ocultarPantallaActiva();
            this.pantallaActiva = this.pantallaLugaresCercanos1;
            mostrarPantallaActiva();
        }
    }
}
