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
    public partial class Slideshow : UserControl
    {

        private int indice;
        public DirectoryInfo carpetaFotos { set; get; }
        private List<Image> listaImagenes;
        public Slideshow()
        {
            InitializeComponent();
            this.BackColor = Color.Transparent;
            slider.Controls.Add(pictureBoxBackward);
            slider.Controls.Add(pictureBoxFordward);
            listaImagenes = new List<Image>();
            indice = 0;
            slider.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public Slideshow(String carpetaFotos)
        {
            InitializeComponent();
            this.BackColor = Color.Transparent;
            slider.Controls.Add(pictureBoxBackward);
            slider.Controls.Add(pictureBoxFordward);
            listaImagenes = new List<Image>();
            indice = 0;
            slider.SizeMode = PictureBoxSizeMode.StretchImage;
            this.carpetaFotos = new DirectoryInfo(carpetaFotos);
            cargarFotos();
            slider.Image = listaImagenes[0];
        }

        public void setCarpetaFotos(DirectoryInfo carpetaFotos)
        {
            this.carpetaFotos = carpetaFotos;
            cargarFotos();
            slider.Image = listaImagenes[0];
        }

        private void cargarFotos()
        {
            cargarFotosEnLista("*.jpg");
            cargarFotosEnLista("*.png");
            cargarFotosEnLista("*.bmp");
        }

        private void cargarFotosEnLista(String extension)
        {
            FileInfo[] fotos = carpetaFotos.GetFiles(extension);
            foreach (FileInfo foto in fotos)
            {
                listaImagenes.Add(Image.FromFile(foto.FullName));
            }
        }

        private void retroceder()
        {
            if (indice == 0)
            {
                indice = listaImagenes.Count - 1;
            }
            else
            {
                indice--;
            }

            slider.Image = listaImagenes[indice];
        }

        private void avanzar()
        {
            if (indice + 1 == listaImagenes.Count)
            {
                indice = 0;
            }
            else
            {
                indice++;
            }

            slider.Image = listaImagenes[indice];
        }

        private void pictureBoxBackward_Click(object sender, EventArgs e)
        {
            retroceder();
        }

        private void pictureBoxFordward_Click(object sender, EventArgs e)
        {
            avanzar();
        }
    }
}
