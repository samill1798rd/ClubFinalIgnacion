namespace ClubForm
{
    partial class servicios
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
            this.components = new System.ComponentModel.Container();
            this.listadoclientes = new System.Windows.Forms.GroupBox();
            this.datashow2 = new System.Windows.Forms.DataGridView();
            this.btnmanzana = new System.Windows.Forms.Button();
            this.btnedificio = new System.Windows.Forms.Button();
            this.datashow = new System.Windows.Forms.DataGridView();
            this.prestamoBindingSource10 = new System.Windows.Forms.BindingSource(this.components);
            this.prestamoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.prestamoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.prestamosDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestamoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.prestamoBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.prestamoBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.prestamoBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.prestamoBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.prestamoBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.prestamoBindingSource8 = new System.Windows.Forms.BindingSource(this.components);
            this.prestamoBindingSource9 = new System.Windows.Forms.BindingSource(this.components);
            this.listadoclientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datashow2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datashow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource9)).BeginInit();
            this.SuspendLayout();
            // 
            // listadoclientes
            // 
            this.listadoclientes.Controls.Add(this.datashow2);
            this.listadoclientes.Controls.Add(this.btnmanzana);
            this.listadoclientes.Controls.Add(this.btnedificio);
            this.listadoclientes.Controls.Add(this.datashow);
            this.listadoclientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listadoclientes.Location = new System.Drawing.Point(21, 51);
            this.listadoclientes.Name = "listadoclientes";
            this.listadoclientes.Size = new System.Drawing.Size(767, 387);
            this.listadoclientes.TabIndex = 16;
            this.listadoclientes.TabStop = false;
            this.listadoclientes.Text = "Listados Filtrados";
            this.listadoclientes.Enter += new System.EventHandler(this.listadoclientes_Enter);
            // 
            // datashow2
            // 
            this.datashow2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datashow2.Location = new System.Drawing.Point(389, 20);
            this.datashow2.Name = "datashow2";
            this.datashow2.Size = new System.Drawing.Size(356, 276);
            this.datashow2.TabIndex = 63;
            // 
            // btnmanzana
            // 
            this.btnmanzana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnmanzana.FlatAppearance.BorderSize = 0;
            this.btnmanzana.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnmanzana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmanzana.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmanzana.ForeColor = System.Drawing.Color.White;
            this.btnmanzana.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmanzana.Location = new System.Drawing.Point(515, 304);
            this.btnmanzana.Name = "btnmanzana";
            this.btnmanzana.Size = new System.Drawing.Size(112, 50);
            this.btnmanzana.TabIndex = 61;
            this.btnmanzana.Text = "Por Manzana";
            this.btnmanzana.UseVisualStyleBackColor = false;
            this.btnmanzana.Click += new System.EventHandler(this.btnmanzana_Click);
            // 
            // btnedificio
            // 
            this.btnedificio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnedificio.FlatAppearance.BorderSize = 0;
            this.btnedificio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnedificio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnedificio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedificio.ForeColor = System.Drawing.Color.White;
            this.btnedificio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnedificio.Location = new System.Drawing.Point(116, 302);
            this.btnedificio.Name = "btnedificio";
            this.btnedificio.Size = new System.Drawing.Size(112, 54);
            this.btnedificio.TabIndex = 62;
            this.btnedificio.Text = "Por Edificio";
            this.btnedificio.UseVisualStyleBackColor = false;
            this.btnedificio.Click += new System.EventHandler(this.btnedificio_Click);
            // 
            // datashow
            // 
            this.datashow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datashow.Location = new System.Drawing.Point(6, 20);
            this.datashow.Name = "datashow";
            this.datashow.Size = new System.Drawing.Size(367, 276);
            this.datashow.TabIndex = 0;
            // 
            // prestamoBindingSource10
            // 
            this.prestamoBindingSource10.DataMember = "prestamo";
            // 
            // prestamoBindingSource
            // 
            this.prestamoBindingSource.DataMember = "prestamo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Listados";
            // 
            // prestamoBindingSource1
            // 
            this.prestamoBindingSource1.DataMember = "prestamo";
            // 
            // prestamoBindingSource2
            // 
            this.prestamoBindingSource2.DataMember = "prestamo";
            // 
            // prestamoBindingSource3
            // 
            this.prestamoBindingSource3.DataMember = "prestamo";
            this.prestamoBindingSource3.DataSource = this.prestamosDataSet1BindingSource;
            // 
            // prestamoBindingSource4
            // 
            this.prestamoBindingSource4.DataMember = "prestamo";
            // 
            // prestamoBindingSource5
            // 
            this.prestamoBindingSource5.DataMember = "prestamo";
            // 
            // prestamoBindingSource6
            // 
            this.prestamoBindingSource6.DataMember = "prestamo";
            // 
            // prestamoBindingSource7
            // 
            this.prestamoBindingSource7.DataMember = "prestamo";
            this.prestamoBindingSource7.DataSource = this.prestamosDataSet1BindingSource;
            // 
            // prestamoBindingSource8
            // 
            this.prestamoBindingSource8.DataMember = "prestamo";
            this.prestamoBindingSource8.DataSource = this.prestamosDataSet1BindingSource;
            // 
            // prestamoBindingSource9
            // 
            this.prestamoBindingSource9.DataMember = "prestamo";
            // 
            // servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listadoclientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "servicios";
            this.Text = "servicios";
            this.Load += new System.EventHandler(this.servicios_Load);
            this.listadoclientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datashow2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datashow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox listadoclientes;

        private System.Windows.Forms.BindingSource prestamoBindingSource;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource prestamoBindingSource1;
        private System.Windows.Forms.BindingSource prestamoBindingSource2;

        private System.Windows.Forms.BindingSource prestamosDataSet1BindingSource;
        private System.Windows.Forms.BindingSource prestamoBindingSource3;
        private System.Windows.Forms.BindingSource prestamoBindingSource4;
        private System.Windows.Forms.BindingSource prestamoBindingSource5;
        private System.Windows.Forms.BindingSource prestamoBindingSource6;
        private System.Windows.Forms.BindingSource prestamoBindingSource9;
        private System.Windows.Forms.BindingSource prestamoBindingSource7;
        private System.Windows.Forms.BindingSource prestamoBindingSource8;

        private System.Windows.Forms.BindingSource prestamoBindingSource10;
        private System.Windows.Forms.Button btnedificio;
        private System.Windows.Forms.Button btnmanzana;
        private System.Windows.Forms.DataGridView datashow;
        private System.Windows.Forms.DataGridView datashow2;
    }
}