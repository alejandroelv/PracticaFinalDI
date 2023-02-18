using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;
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
    public partial class PantallaLugaresCercanos : UserControl
    {
        double latitud = 37.18430122995844;
        double longitud = -3.5933792580700343;
        GMap.NET.PointLatLng posicionInstituto;
        public PantallaLugaresCercanos()
        {
            InitializeComponent();
            posicionInstituto = new GMap.NET.PointLatLng(latitud, longitud);
        }
        private void PantallaCafeterias_Load(object sender, EventArgs e)
        {
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = posicionInstituto;
            gMapControl1.MinZoom = 13;
            gMapControl1.MaxZoom = 20;
            gMapControl1.Zoom = 18;
            gMapControl1.AutoScroll = true;
        }

        private void PantallaCafeterias_VisibleChanged(object sender, EventArgs e)
        {
            gMapControl1.Position = posicionInstituto;
        }
    }
}
