namespace ClubForm
{
    partial class Insertar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Insertar));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigoSocio = new System.Windows.Forms.Label();
            this.txtlCodigoSocio = new System.Windows.Forms.TextBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.ptb1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.cboxTipoSocio = new System.Windows.Forms.ComboBox();
            this.lblTipoSocio = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.cboxSexo = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.dtPickerFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtDirreccion = new System.Windows.Forms.TextBox();
            this.lblDirreccion = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptb1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(115, 103);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(220, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(53, 104);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 15);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre :";
            // 
            // lblCodigoSocio
            // 
            this.lblCodigoSocio.AutoSize = true;
            this.lblCodigoSocio.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoSocio.Location = new System.Drawing.Point(22, 55);
            this.lblCodigoSocio.Name = "lblCodigoSocio";
            this.lblCodigoSocio.Size = new System.Drawing.Size(87, 15);
            this.lblCodigoSocio.TabIndex = 3;
            this.lblCodigoSocio.Text = "Codigo Socio  :";
            // 
            // txtlCodigoSocio
            // 
            this.txtlCodigoSocio.Location = new System.Drawing.Point(115, 50);
            this.txtlCodigoSocio.Name = "txtlCodigoSocio";
            this.txtlCodigoSocio.Size = new System.Drawing.Size(220, 20);
            this.txtlCodigoSocio.TabIndex = 1;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.Location = new System.Drawing.Point(58, 182);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(51, 15);
            this.lblCedula.TabIndex = 5;
            this.lblCedula.Text = "Cedula :";
            // 
            // ptb1
            // 
            this.ptb1.Image = ((System.Drawing.Image)(resources.GetObject("ptb1.Image")));
            this.ptb1.Location = new System.Drawing.Point(341, 31);
            this.ptb1.Name = "ptb1";
            this.ptb1.Size = new System.Drawing.Size(134, 145);
            this.ptb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb1.TabIndex = 8;
            this.ptb1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 18);
            this.label5.TabIndex = 39;
            this.label5.Text = "Registrar Socio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(476, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 18);
            this.label6.TabIndex = 40;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.Location = new System.Drawing.Point(12, 327);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(112, 40);
            this.btnRegistrar.TabIndex = 45;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // cboxTipoSocio
            // 
            this.cboxTipoSocio.FormattingEnabled = true;
            this.cboxTipoSocio.Items.AddRange(new object[] {
            "1"});
            this.cboxTipoSocio.Location = new System.Drawing.Point(115, 76);
            this.cboxTipoSocio.Name = "cboxTipoSocio";
            this.cboxTipoSocio.Size = new System.Drawing.Size(220, 21);
            this.cboxTipoSocio.TabIndex = 47;
            // 
            // lblTipoSocio
            // 
            this.lblTipoSocio.AutoSize = true;
            this.lblTipoSocio.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoSocio.Location = new System.Drawing.Point(39, 78);
            this.lblTipoSocio.Name = "lblTipoSocio";
            this.lblTipoSocio.Size = new System.Drawing.Size(70, 15);
            this.lblTipoSocio.TabIndex = 46;
            this.lblTipoSocio.Text = "Tipo Socio :";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(50, 131);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(59, 15);
            this.lblApellido.TabIndex = 48;
            this.lblApellido.Text = "Apellido :";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(115, 129);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(220, 20);
            this.txtApellido.TabIndex = 49;
            // 
            // cboxSexo
            // 
            this.cboxSexo.FormattingEnabled = true;
            this.cboxSexo.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cboxSexo.Location = new System.Drawing.Point(115, 155);
            this.cboxSexo.Name = "cboxSexo";
            this.cboxSexo.Size = new System.Drawing.Size(220, 21);
            this.cboxSexo.TabIndex = 51;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(71, 157);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(38, 15);
            this.lblSexo.TabIndex = 50;
            this.lblSexo.Text = "Sexo :";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(115, 182);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(368, 20);
            this.txtCedula.TabIndex = 52;
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNac.Location = new System.Drawing.Point(58, 213);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(111, 15);
            this.lblFechaNac.TabIndex = 53;
            this.lblFechaNac.Text = "Fecha Nacimiento :";
            // 
            // dtPickerFechaNacimiento
            // 
            this.dtPickerFechaNacimiento.Location = new System.Drawing.Point(175, 208);
            this.dtPickerFechaNacimiento.Name = "dtPickerFechaNacimiento";
            this.dtPickerFechaNacimiento.Size = new System.Drawing.Size(308, 20);
            this.dtPickerFechaNacimiento.TabIndex = 54;
            // 
            // txtDirreccion
            // 
            this.txtDirreccion.Location = new System.Drawing.Point(115, 234);
            this.txtDirreccion.Name = "txtDirreccion";
            this.txtDirreccion.Size = new System.Drawing.Size(368, 20);
            this.txtDirreccion.TabIndex = 56;
            // 
            // lblDirreccion
            // 
            this.lblDirreccion.AutoSize = true;
            this.lblDirreccion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirreccion.Location = new System.Drawing.Point(35, 236);
            this.lblDirreccion.Name = "lblDirreccion";
            this.lblDirreccion.Size = new System.Drawing.Size(74, 15);
            this.lblDirreccion.TabIndex = 55;
            this.lblDirreccion.Text = "Dirreccion  :";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(115, 260);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(142, 20);
            this.txtTelefono.TabIndex = 58;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(47, 262);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(62, 15);
            this.lblTelefono.TabIndex = 57;
            this.lblTelefono.Text = "Telefono  :";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(341, 260);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(142, 20);
            this.txtCelular.TabIndex = 60;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.Location = new System.Drawing.Point(282, 262);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(53, 15);
            this.lblCelular.TabIndex = 59;
            this.lblCelular.Text = "Celular :";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(115, 286);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(368, 20);
            this.txtCorreo.TabIndex = 62;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(59, 286);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(50, 15);
            this.lblCorreo.TabIndex = 61;
            this.lblCorreo.Text = "Correo :";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(130, 337);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 20);
            this.lblError.TabIndex = 63;
            // 
            // Insertar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 379);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtDirreccion);
            this.Controls.Add(this.lblDirreccion);
            this.Controls.Add(this.dtPickerFechaNacimiento);
            this.Controls.Add(this.lblFechaNac);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.cboxSexo);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.cboxTipoSocio);
            this.Controls.Add(this.lblTipoSocio);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ptb1);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.lblCodigoSocio);
            this.Controls.Add(this.txtlCodigoSocio);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Insertar";
            this.Text = "Insertar";
            this.Load += new System.EventHandler(this.Insertar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.Label lblNombre;
        public System.Windows.Forms.Label lblCodigoSocio;
        public System.Windows.Forms.TextBox txtlCodigoSocio;
        public System.Windows.Forms.Label lblCedula;
        public System.Windows.Forms.PictureBox ptb1;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btnRegistrar;
        public System.Windows.Forms.ComboBox cboxTipoSocio;
        public System.Windows.Forms.Label lblTipoSocio;
        public System.Windows.Forms.Label lblApellido;
        public System.Windows.Forms.TextBox txtApellido;
        public System.Windows.Forms.ComboBox cboxSexo;
        public System.Windows.Forms.Label lblSexo;
        public System.Windows.Forms.TextBox txtCedula;
        public System.Windows.Forms.Label lblFechaNac;
        public System.Windows.Forms.DateTimePicker dtPickerFechaNacimiento;
        public System.Windows.Forms.TextBox txtDirreccion;
        public System.Windows.Forms.Label lblDirreccion;
        public System.Windows.Forms.TextBox txtTelefono;
        public System.Windows.Forms.Label lblTelefono;
        public System.Windows.Forms.TextBox txtCelular;
        public System.Windows.Forms.Label lblCelular;
        public System.Windows.Forms.TextBox txtCorreo;
        public System.Windows.Forms.Label lblCorreo;
        public System.Windows.Forms.Label lblError;
    }
}