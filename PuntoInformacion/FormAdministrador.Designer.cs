namespace PuntoInformacion
{
    partial class FormAdministrador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonCalendario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(167)))), ((int)(((byte)(221)))));
            this.buttonSalir.FlatAppearance.BorderSize = 0;
            this.buttonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.ForeColor = System.Drawing.Color.White;
            this.buttonSalir.Location = new System.Drawing.Point(63, 128);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(188, 35);
            this.buttonSalir.TabIndex = 0;
            this.buttonSalir.Text = "Salir modo administrador";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // buttonCalendario
            // 
            this.buttonCalendario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(167)))), ((int)(((byte)(221)))));
            this.buttonCalendario.FlatAppearance.BorderSize = 0;
            this.buttonCalendario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalendario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalendario.ForeColor = System.Drawing.Color.White;
            this.buttonCalendario.Location = new System.Drawing.Point(63, 65);
            this.buttonCalendario.Name = "buttonCalendario";
            this.buttonCalendario.Size = new System.Drawing.Size(188, 35);
            this.buttonCalendario.TabIndex = 1;
            this.buttonCalendario.Text = "Cambiar calendario escolar";
            this.buttonCalendario.UseVisualStyleBackColor = false;
            this.buttonCalendario.Click += new System.EventHandler(this.buttonCalendario_Click);
            // 
            // FormAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 220);
            this.Controls.Add(this.buttonCalendario);
            this.Controls.Add(this.buttonSalir);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(330, 259);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(330, 259);
            this.Name = "FormAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuración";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonCalendario;
    }
}