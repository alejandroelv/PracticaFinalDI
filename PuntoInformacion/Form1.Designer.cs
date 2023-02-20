namespace PuntoInformacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.buttonInicio = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonLugaresCercanos = new System.Windows.Forms.Button();
            this.buttonSugerencias = new System.Windows.Forms.Button();
            this.buttonContacto = new System.Windows.Forms.Button();
            this.buttonCalendario = new System.Windows.Forms.Button();
            this.pantallaCalendario1 = new PuntoInformacion.PantallaCalendario();
            this.pantallaInicio1 = new PuntoInformacion.PantallaInicio();
            this.pantallaInformacion1 = new PuntoInformacion.PantallaInformacion();
            this.pantallaLugaresCercanos1 = new PuntoInformacion.PantallaLugaresCercanos();
            this.pantallaSugerencias1 = new PuntoInformacion.PantallaSugerencias();
            this.pictureBoxLoginAdmin = new System.Windows.Forms.PictureBox();
            this.pictureBoxConfiguracion = new System.Windows.Forms.PictureBox();
            this.pictureBoxSalir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoginAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConfiguracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(109)))), ((int)(((byte)(153)))));
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(195, 544);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // buttonInicio
            // 
            this.buttonInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(167)))), ((int)(((byte)(221)))));
            this.buttonInicio.FlatAppearance.BorderSize = 0;
            this.buttonInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInicio.ForeColor = System.Drawing.Color.White;
            this.buttonInicio.Location = new System.Drawing.Point(0, 0);
            this.buttonInicio.Name = "buttonInicio";
            this.buttonInicio.Size = new System.Drawing.Size(195, 50);
            this.buttonInicio.TabIndex = 3;
            this.buttonInicio.Text = "Inicio";
            this.buttonInicio.UseVisualStyleBackColor = false;
            this.buttonInicio.Click += new System.EventHandler(this.buttonInicio_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(167)))), ((int)(((byte)(221)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 50);
            this.button2.TabIndex = 4;
            this.button2.Text = "Plano del centro";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(167)))), ((int)(((byte)(221)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 51);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(195, 50);
            this.button3.TabIndex = 5;
            this.button3.Text = "Equipo directivo";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // buttonLugaresCercanos
            // 
            this.buttonLugaresCercanos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(167)))), ((int)(((byte)(221)))));
            this.buttonLugaresCercanos.FlatAppearance.BorderSize = 0;
            this.buttonLugaresCercanos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLugaresCercanos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLugaresCercanos.ForeColor = System.Drawing.Color.White;
            this.buttonLugaresCercanos.Location = new System.Drawing.Point(0, 204);
            this.buttonLugaresCercanos.Name = "buttonLugaresCercanos";
            this.buttonLugaresCercanos.Size = new System.Drawing.Size(195, 50);
            this.buttonLugaresCercanos.TabIndex = 7;
            this.buttonLugaresCercanos.Text = "Lugares cercanos";
            this.buttonLugaresCercanos.UseVisualStyleBackColor = false;
            this.buttonLugaresCercanos.Click += new System.EventHandler(this.buttonLugaresCercanos_Click);
            // 
            // buttonSugerencias
            // 
            this.buttonSugerencias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(167)))), ((int)(((byte)(221)))));
            this.buttonSugerencias.FlatAppearance.BorderSize = 0;
            this.buttonSugerencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSugerencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSugerencias.ForeColor = System.Drawing.Color.White;
            this.buttonSugerencias.Location = new System.Drawing.Point(0, 306);
            this.buttonSugerencias.Name = "buttonSugerencias";
            this.buttonSugerencias.Size = new System.Drawing.Size(195, 50);
            this.buttonSugerencias.TabIndex = 8;
            this.buttonSugerencias.Text = "Sugerencias";
            this.buttonSugerencias.UseVisualStyleBackColor = false;
            this.buttonSugerencias.Click += new System.EventHandler(this.buttonSugerencias_Click);
            // 
            // buttonContacto
            // 
            this.buttonContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(167)))), ((int)(((byte)(221)))));
            this.buttonContacto.FlatAppearance.BorderSize = 0;
            this.buttonContacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContacto.ForeColor = System.Drawing.Color.White;
            this.buttonContacto.Location = new System.Drawing.Point(0, 255);
            this.buttonContacto.Name = "buttonContacto";
            this.buttonContacto.Size = new System.Drawing.Size(195, 50);
            this.buttonContacto.TabIndex = 9;
            this.buttonContacto.Text = "Contacto";
            this.buttonContacto.UseVisualStyleBackColor = false;
            this.buttonContacto.Click += new System.EventHandler(this.buttonContacto_Click);
            // 
            // buttonCalendario
            // 
            this.buttonCalendario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(167)))), ((int)(((byte)(221)))));
            this.buttonCalendario.FlatAppearance.BorderSize = 0;
            this.buttonCalendario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalendario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalendario.ForeColor = System.Drawing.Color.White;
            this.buttonCalendario.Location = new System.Drawing.Point(0, 153);
            this.buttonCalendario.Name = "buttonCalendario";
            this.buttonCalendario.Size = new System.Drawing.Size(195, 50);
            this.buttonCalendario.TabIndex = 15;
            this.buttonCalendario.Text = "Calendario escolar";
            this.buttonCalendario.UseVisualStyleBackColor = false;
            this.buttonCalendario.Click += new System.EventHandler(this.buttonCalendario_Click);
            // 
            // pantallaCalendario1
            // 
            this.pantallaCalendario1.Location = new System.Drawing.Point(201, 12);
            this.pantallaCalendario1.Name = "pantallaCalendario1";
            this.pantallaCalendario1.Size = new System.Drawing.Size(653, 514);
            this.pantallaCalendario1.TabIndex = 16;
            this.pantallaCalendario1.Visible = false;
            // 
            // pantallaInicio1
            // 
            this.pantallaInicio1.AutoScroll = true;
            this.pantallaInicio1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pantallaInicio1.Location = new System.Drawing.Point(213, 0);
            this.pantallaInicio1.Name = "pantallaInicio1";
            this.pantallaInicio1.Size = new System.Drawing.Size(660, 544);
            this.pantallaInicio1.TabIndex = 11;
            // 
            // pantallaInformacion1
            // 
            this.pantallaInformacion1.Location = new System.Drawing.Point(280, 0);
            this.pantallaInformacion1.Name = "pantallaInformacion1";
            this.pantallaInformacion1.Size = new System.Drawing.Size(600, 560);
            this.pantallaInformacion1.TabIndex = 12;
            this.pantallaInformacion1.Visible = false;
            // 
            // pantallaLugaresCercanos1
            // 
            this.pantallaLugaresCercanos1.Location = new System.Drawing.Point(219, 21);
            this.pantallaLugaresCercanos1.Name = "pantallaLugaresCercanos1";
            this.pantallaLugaresCercanos1.Size = new System.Drawing.Size(625, 492);
            this.pantallaLugaresCercanos1.TabIndex = 14;
            this.pantallaLugaresCercanos1.Visible = false;
            // 
            // pantallaSugerencias1
            // 
            this.pantallaSugerencias1.Location = new System.Drawing.Point(213, 21);
            this.pantallaSugerencias1.Name = "pantallaSugerencias1";
            this.pantallaSugerencias1.Size = new System.Drawing.Size(631, 486);
            this.pantallaSugerencias1.TabIndex = 13;
            this.pantallaSugerencias1.Visible = false;
            // 
            // pictureBoxLoginAdmin
            // 
            this.pictureBoxLoginAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(109)))), ((int)(((byte)(153)))));
            this.pictureBoxLoginAdmin.ErrorImage = global::PuntoInformacion.Properties.Resources.user;
            this.pictureBoxLoginAdmin.Image = global::PuntoInformacion.Properties.Resources.user;
            this.pictureBoxLoginAdmin.Location = new System.Drawing.Point(62, 498);
            this.pictureBoxLoginAdmin.Name = "pictureBoxLoginAdmin";
            this.pictureBoxLoginAdmin.Size = new System.Drawing.Size(34, 37);
            this.pictureBoxLoginAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLoginAdmin.TabIndex = 18;
            this.pictureBoxLoginAdmin.TabStop = false;
            this.pictureBoxLoginAdmin.Click += new System.EventHandler(this.pictureBoxLoginAdmin_Click);
            // 
            // pictureBoxConfiguracion
            // 
            this.pictureBoxConfiguracion.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBoxConfiguracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(109)))), ((int)(((byte)(153)))));
            this.pictureBoxConfiguracion.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxConfiguracion.ErrorImage")));
            this.pictureBoxConfiguracion.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxConfiguracion.Image")));
            this.pictureBoxConfiguracion.Location = new System.Drawing.Point(62, 498);
            this.pictureBoxConfiguracion.Name = "pictureBoxConfiguracion";
            this.pictureBoxConfiguracion.Size = new System.Drawing.Size(37, 37);
            this.pictureBoxConfiguracion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxConfiguracion.TabIndex = 17;
            this.pictureBoxConfiguracion.TabStop = false;
            this.pictureBoxConfiguracion.Visible = false;
            this.pictureBoxConfiguracion.Click += new System.EventHandler(this.pictureBoxConfiguracion_Click);
            // 
            // pictureBoxSalir
            // 
            this.pictureBoxSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(109)))), ((int)(((byte)(153)))));
            this.pictureBoxSalir.ErrorImage = global::PuntoInformacion.Properties.Resources.logout;
            this.pictureBoxSalir.Image = global::PuntoInformacion.Properties.Resources.logout;
            this.pictureBoxSalir.Location = new System.Drawing.Point(12, 499);
            this.pictureBoxSalir.Name = "pictureBoxSalir";
            this.pictureBoxSalir.Size = new System.Drawing.Size(34, 34);
            this.pictureBoxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSalir.TabIndex = 10;
            this.pictureBoxSalir.TabStop = false;
            this.pictureBoxSalir.Click += new System.EventHandler(this.pictureBoxSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(873, 544);
            this.Controls.Add(this.pictureBoxLoginAdmin);
            this.Controls.Add(this.pictureBoxConfiguracion);
            this.Controls.Add(this.pantallaCalendario1);
            this.Controls.Add(this.buttonCalendario);
            this.Controls.Add(this.pantallaInicio1);
            this.Controls.Add(this.pictureBoxSalir);
            this.Controls.Add(this.buttonContacto);
            this.Controls.Add(this.buttonSugerencias);
            this.Controls.Add(this.buttonLugaresCercanos);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonInicio);
            this.Controls.Add(this.pantallaInformacion1);
            this.Controls.Add(this.pantallaLugaresCercanos1);
            this.Controls.Add(this.pantallaSugerencias1);
            this.Controls.Add(this.splitter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoginAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConfiguracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button buttonInicio;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonLugaresCercanos;
        private System.Windows.Forms.Button buttonSugerencias;
        private System.Windows.Forms.Button buttonContacto;
        private System.Windows.Forms.PictureBox pictureBoxSalir;
        private PantallaInicio pantallaInicio1;
        private PantallaInformacion pantallaInformacion1;
        private PantallaSugerencias pantallaSugerencias1;
        private PantallaLugaresCercanos pantallaLugaresCercanos1;
        private System.Windows.Forms.Button buttonCalendario;
        private PantallaCalendario pantallaCalendario1;
        private System.Windows.Forms.PictureBox pictureBoxConfiguracion;
        private System.Windows.Forms.PictureBox pictureBoxLoginAdmin;
    }
}

