namespace ClubForm
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
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btncliente = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.icocerrar = new System.Windows.Forms.PictureBox();
            this.icominimizar = new System.Windows.Forms.PictureBox();
            this.icorestaurar = new System.Windows.Forms.PictureBox();
            this.icomaximizar = new System.Windows.Forms.PictureBox();
            this.btnSlide = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.MenuVertical.SuspendLayout();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icocerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icominimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icorestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icomaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.MenuVertical.Controls.Add(this.button1);
            this.MenuVertical.Controls.Add(this.button2);
            this.MenuVertical.Controls.Add(this.btncliente);
            this.MenuVertical.Controls.Add(this.lblname);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(250, 650);
            this.MenuVertical.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(1, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Tipo de Socios";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btncliente
            // 
            this.btncliente.FlatAppearance.BorderSize = 0;
            this.btncliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btncliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncliente.ForeColor = System.Drawing.Color.White;
            this.btncliente.Image = ((System.Drawing.Image)(resources.GetObject("btncliente.Image")));
            this.btncliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncliente.Location = new System.Drawing.Point(1, 140);
            this.btncliente.Name = "btncliente";
            this.btncliente.Size = new System.Drawing.Size(250, 40);
            this.btncliente.TabIndex = 0;
            this.btncliente.Text = "Socios";
            this.btncliente.UseVisualStyleBackColor = true;
            this.btncliente.Click += new System.EventHandler(this.btncliente_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblname.Location = new System.Drawing.Point(40, 10);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(149, 34);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Club SYS";
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BarraTitulo.Controls.Add(this.icocerrar);
            this.BarraTitulo.Controls.Add(this.icominimizar);
            this.BarraTitulo.Controls.Add(this.icorestaurar);
            this.BarraTitulo.Controls.Add(this.icomaximizar);
            this.BarraTitulo.Controls.Add(this.btnSlide);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(250, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1050, 50);
            this.BarraTitulo.TabIndex = 1;
            this.BarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.BarraTitulo_Paint);
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // icocerrar
            // 
            this.icocerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icocerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icocerrar.Image = ((System.Drawing.Image)(resources.GetObject("icocerrar.Image")));
            this.icocerrar.Location = new System.Drawing.Point(1013, 3);
            this.icocerrar.Name = "icocerrar";
            this.icocerrar.Size = new System.Drawing.Size(25, 24);
            this.icocerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icocerrar.TabIndex = 3;
            this.icocerrar.TabStop = false;
            this.icocerrar.Click += new System.EventHandler(this.icocerrar_Click);
            // 
            // icominimizar
            // 
            this.icominimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icominimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icominimizar.Image = ((System.Drawing.Image)(resources.GetObject("icominimizar.Image")));
            this.icominimizar.Location = new System.Drawing.Point(951, 3);
            this.icominimizar.Name = "icominimizar";
            this.icominimizar.Size = new System.Drawing.Size(25, 24);
            this.icominimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icominimizar.TabIndex = 2;
            this.icominimizar.TabStop = false;
            this.icominimizar.Click += new System.EventHandler(this.icominimizar_Click);
            // 
            // icorestaurar
            // 
            this.icorestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icorestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icorestaurar.Image = ((System.Drawing.Image)(resources.GetObject("icorestaurar.Image")));
            this.icorestaurar.Location = new System.Drawing.Point(982, 3);
            this.icorestaurar.Name = "icorestaurar";
            this.icorestaurar.Size = new System.Drawing.Size(25, 24);
            this.icorestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icorestaurar.TabIndex = 2;
            this.icorestaurar.TabStop = false;
            this.icorestaurar.Visible = false;
            this.icorestaurar.Click += new System.EventHandler(this.icorestaurar_Click);
            // 
            // icomaximizar
            // 
            this.icomaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icomaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icomaximizar.Image = ((System.Drawing.Image)(resources.GetObject("icomaximizar.Image")));
            this.icomaximizar.Location = new System.Drawing.Point(982, 3);
            this.icomaximizar.Name = "icomaximizar";
            this.icomaximizar.Size = new System.Drawing.Size(25, 24);
            this.icomaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icomaximizar.TabIndex = 2;
            this.icomaximizar.TabStop = false;
            this.icomaximizar.Click += new System.EventHandler(this.icomaximizar_Click);
            // 
            // btnSlide
            // 
            this.btnSlide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSlide.Image = ((System.Drawing.Image)(resources.GetObject("btnSlide.Image")));
            this.btnSlide.Location = new System.Drawing.Point(6, 9);
            this.btnSlide.Name = "btnSlide";
            this.btnSlide.Size = new System.Drawing.Size(35, 35);
            this.btnSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSlide.TabIndex = 0;
            this.btnSlide.TabStop = false;
            this.btnSlide.Click += new System.EventHandler(this.btnSlide_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContenedor.Location = new System.Drawing.Point(250, 50);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1050, 597);
            this.panelContenedor.TabIndex = 2;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint_1);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Reportes";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuVertical.ResumeLayout(false);
            this.MenuVertical.PerformLayout();
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icocerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icominimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icorestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icomaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox btnSlide;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.PictureBox icominimizar;
        private System.Windows.Forms.PictureBox icorestaurar;
        private System.Windows.Forms.PictureBox icomaximizar;
        private System.Windows.Forms.PictureBox icocerrar;
        private System.Windows.Forms.Button btncliente;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

