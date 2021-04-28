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
    public partial class delete : Form
    {


        public delete()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            try
            {
                //per.Id = txt0.Text;
                //obj.eliminar(per);

                MessageBox.Show("Persona Elimanada");
               this.Close();
            }

            catch(Exception ex)
            {

                MessageBox.Show(ex.ToString());

            }

        }

        private void delete_Load(object sender, EventArgs e)
        {

        }
    }
}
