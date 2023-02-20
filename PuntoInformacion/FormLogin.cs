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
    public partial class FormLogin : Form
    {
        Form1 formulario;
        public FormLogin()
        {
            InitializeComponent();
        }

        public FormLogin(Form1 formulario)
        {
            InitializeComponent();
            this.formulario = formulario;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(!this.textBoxUsuario.Text.Equals("admin") || !this.textBoxUsuario.Text.Equals("admin"))
            {
                MessageBox.Show("El usuario o la contraseña introducidos no son válidos.","Credenciales incorrectas",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Logeado correctamente", "Login correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.formulario.modoAdministrador = true;
            this.Dispose();
        }
    }
}
