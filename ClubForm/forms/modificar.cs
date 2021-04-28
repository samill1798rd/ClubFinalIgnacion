using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ClubForm
{
    public partial class modificar : Form
    {
        
        public modificar()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

     
        private void btnsave_Click(object sender, EventArgs e)
        {
  

            try
            {
                //per.Id = txt0.Text;
                //per.Cedula = txt1.Text;
                //per.Nombre = txt2.Text;
                //per.Manzana = txt3.Text;
                //per.Edificio = txt4.Text;
                //per.Apartamento = txt5.Text;


                //obj.modificar(per);
                MessageBox.Show("Persona Modicada Correctamente");

                this.Close();
            }
            catch(Exception ex)
                {

                MessageBox.Show(ex.ToString());

            }
           
        }

        private void modificar_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
