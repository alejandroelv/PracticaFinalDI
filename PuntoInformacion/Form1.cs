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
        public Boolean modoAdministrador { set; get; }
        public Form1()
        {
            InitializeComponent();
            modoAdministrador = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.pantallaActiva = this.pantallaInicio1;
            pantallaInicio1.slideshow1.setCarpetaFotos(new System.IO.DirectoryInfo("../../Resources/fotosSlideshow"));
        }

        public void recargarCalendario()
        {
            this.pantallaCalendario1.cargarPDF();
        }

        private void pictureBoxSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void pictureBoxLoginAdmin_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin(this);
            login.ShowDialog();

            if (modoAdministrador == true)
            {
                pictureBoxLoginAdmin.Visible = false;
                pictureBoxConfiguracion.Visible = true;
            }
        }
        private void pictureBoxConfiguracion_Click(object sender, EventArgs e)
        {
            FormAdministrador configuracion = new FormAdministrador(this);
            configuracion.ShowDialog();
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

        private void buttonCalendario_Click(object sender, EventArgs e)
        {
            ocultarPantallaActiva();
            this.pantallaActiva = this.pantallaCalendario1;
            mostrarPantallaActiva();
        }
    }
}
