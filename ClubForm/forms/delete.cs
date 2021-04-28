using CapaLogica;
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

        private SocioServices _socioServices;
        public delete()
        {
            InitializeComponent();
            _socioServices = new SocioServices();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            var idSocio = Convert.ToInt32(txtId.Text);
            var result = _socioServices.DelecteSocio(idSocio);

            if (result.Success != false)
            {
                MessageBox.Show("Socio Elimanado");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al eliminar Socio");
            }
        }


        private void delete_Load(object sender, EventArgs e)
        {

        }
    }
}
