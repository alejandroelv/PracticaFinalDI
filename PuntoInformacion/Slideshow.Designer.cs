namespace PuntoInformacion
{
    partial class Slideshow
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxBackward = new System.Windows.Forms.PictureBox();
            this.pictureBoxFordward = new System.Windows.Forms.PictureBox();
            this.slider = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFordward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBackward
            // 
            this.pictureBoxBackward.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBackward.Image = global::PuntoInformacion.Properties.Resources.backward_arrow;
            this.pictureBoxBackward.Location = new System.Drawing.Point(11, 130);
            this.pictureBoxBackward.Name = "pictureBoxBackward";
            this.pictureBoxBackward.Size = new System.Drawing.Size(65, 37);
            this.pictureBoxBackward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBackward.TabIndex = 2;
            this.pictureBoxBackward.TabStop = false;
            this.pictureBoxBackward.Click += new System.EventHandler(this.pictureBoxBackward_Click);
            // 
            // pictureBoxFordward
            // 
            this.pictureBoxFordward.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFordward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxFordward.Image = global::PuntoInformacion.Properties.Resources.forward_arrow;
            this.pictureBoxFordward.Location = new System.Drawing.Point(495, 130);
            this.pictureBoxFordward.Name = "pictureBoxFordward";
            this.pictureBoxFordward.Size = new System.Drawing.Size(61, 37);
            this.pictureBoxFordward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFordward.TabIndex = 1;
            this.pictureBoxFordward.TabStop = false;
            this.pictureBoxFordward.Click += new System.EventHandler(this.pictureBoxFordward_Click);
            // 
            // slider
            // 
            this.slider.BackColor = System.Drawing.Color.Transparent;
            this.slider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slider.Location = new System.Drawing.Point(0, 0);
            this.slider.Name = "slider";
            this.slider.Size = new System.Drawing.Size(569, 294);
            this.slider.TabIndex = 0;
            this.slider.TabStop = false;
            // 
            // Slideshow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBoxBackward);
            this.Controls.Add(this.pictureBoxFordward);
            this.Controls.Add(this.slider);
            this.Name = "Slideshow";
            this.Size = new System.Drawing.Size(569, 294);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFordward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox slider;
        private System.Windows.Forms.PictureBox pictureBoxFordward;
        private System.Windows.Forms.PictureBox pictureBoxBackward;
    }
}
