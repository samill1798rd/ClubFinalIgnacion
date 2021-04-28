using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaLogica;

namespace ClubForm
{
    public partial class servicios : Form
    {

        public servicios()
        {
            InitializeComponent();
        }

        private void servicios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'prestamosDataSet2.prestamo' Puede moverla o quitarla según sea necesario.



        }

  
        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
         
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

       

        private void btnmanzana_Click(object sender, EventArgs e)
        {
            //datashow2.DataSource = obj.vermanzana();
        }

        private void btnedificio_Click(object sender, EventArgs e)
        {
            //datashow.DataSource = obj.veredifico();
        }

        private void listadoclientes_Enter(object sender, EventArgs e)
        {

        }
    }
}
