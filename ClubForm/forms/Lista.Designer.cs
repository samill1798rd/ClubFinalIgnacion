namespace ClubForm
{
    partial class Lista
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
            this.btnedificio = new System.Windows.Forms.Button();
            this.txt0 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnmanzana = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listadoclientes = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listadoclientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.btnedificio.Location = new System.Drawing.Point(651, 267);
            this.btnedificio.Name = "btnedificio";
            this.btnedificio.Size = new System.Drawing.Size(112, 54);
            this.btnedificio.TabIndex = 68;
            this.btnedificio.Text = "Por Edificio";
            this.btnedificio.UseVisualStyleBackColor = false;
            // 
            // txt0
            // 
            this.txt0.Location = new System.Drawing.Point(206, 62);
            this.txt0.Name = "txt0";
            this.txt0.Size = new System.Drawing.Size(362, 20);
            this.txt0.TabIndex = 66;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 15);
            this.label6.TabIndex = 65;
            this.label6.Text = "Buscar Mediante Cliente ID:";
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
            this.btnmanzana.Location = new System.Drawing.Point(651, 147);
            this.btnmanzana.Name = "btnmanzana";
            this.btnmanzana.Size = new System.Drawing.Size(112, 50);
            this.btnmanzana.TabIndex = 67;
            this.btnmanzana.Text = "Por Manzana";
            this.btnmanzana.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 64;
            this.label1.Text = "Listados";
            // 
            // listadoclientes
            // 
            this.listadoclientes.Controls.Add(this.dataGridView1);
            this.listadoclientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listadoclientes.Location = new System.Drawing.Point(38, 102);
            this.listadoclientes.Name = "listadoclientes";
            this.listadoclientes.Size = new System.Drawing.Size(576, 338);
            this.listadoclientes.TabIndex = 63;
            this.listadoclientes.TabStop = false;
            this.listadoclientes.Text = "Listados Filtrados";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 312);
            this.dataGridView1.TabIndex = 0;
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnedificio);
            this.Controls.Add(this.txt0);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnmanzana);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listadoclientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lista";
            this.Text = "Lista";
            this.Load += new System.EventHandler(this.Lista_Load);
            this.listadoclientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnedificio;
        public System.Windows.Forms.TextBox txt0;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnmanzana;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox listadoclientes;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}