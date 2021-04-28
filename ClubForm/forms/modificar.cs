using CapaDatos;
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
    public partial class modificar : Form
    {
        private SocioServices _socioServices;
        public modificar()
        {
            InitializeComponent();
            _socioServices = new SocioServices();
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
           var result = _socioServices.UpdateSocios(GetSocioModel());
        }

        private Socio GetSocioModel()
        {
            return new Socio()
            {
                Id = Convert.ToInt32(txtId.Text),
                IdSocio = txtlCodigoSocio.Text,
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Sexo = txtSexo.Text,
                Cedula = txtCedula.Text,
                Dirreccion = txtDirreccion.Text,
                Telefono = txtTelefono.Text,
                Celular = txtCelular.Text,
                Email = txtCorreo.Text,
                Estatus = 1
            };
        }
    }
}
