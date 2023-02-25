using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoInformacion
{
    public partial class PantallaPlanos : UserControl
    {
        public PantallaPlanos()
        {
            InitializeComponent();
        }

        private void buttonExteriores_Click(object sender, EventArgs e)
        {
            pictureBoxPlanos.Image = (Image)Properties.Resources.ResourceManager.GetObject("Plano_exterior");
        }

        private void buttonPlantaBaja_Click(object sender, EventArgs e)
        {
            pictureBoxPlanos.Image = (Image)Properties.Resources.ResourceManager.GetObject("Plano_planta_baja");
        }

        private void buttonPrimeraPlanta_Click(object sender, EventArgs e)
        {
            pictureBoxPlanos.Image = (Image)Properties.Resources.ResourceManager.GetObject("Plano_primera_planta");
        }

        private void buttonSegundaPlanta_Click(object sender, EventArgs e)
        {
            pictureBoxPlanos.Image = (Image)Properties.Resources.ResourceManager.GetObject("Planos_segunda_planta");
        }
    }
}
