using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using CapaDatos;
using CapaLogica;

namespace ClubForm
{
    public partial class Insertar : Form
    {
        private SocioServices _socioServices;
        //private DataGridView _dgvSocios;
        //private Library _library;
        //SocioServices _socioServices = new SocioServices();

        public Insertar()
        {

            InitializeComponent();
            _socioServices = new SocioServices();
            //_dgvSocios = dgvSocios;
            //_library = new Library();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            var socioModel = GetSocioModel();
            var result = _socioServices.CreateSocios(socioModel);
            if (result.Success != false)
                this.Close();
            else
                lblError.Text = "Error al registrar";

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Insertar_Load(object sender, EventArgs e)
        {
            var result = _socioServices.GetallTipoSocio();

            var Valores = new List<TipoSocio>();

            foreach (var item in result)
            {
                Valores.Add(new TipoSocio() { IdTipoSocio = item.IdTipoSocio, Descripcion = item.Descripcion});
            }

            cboxTipoSocio.DataSource = Valores;
            cboxTipoSocio.DisplayMember = "Descripcion";
            cboxTipoSocio.ValueMember = "IdTipoSocio";

            var sexo = new List<Tuple<int ,string>>();
            sexo.Add(Tuple.Create <Int32, string>(1,"M"));
            sexo.Add(Tuple.Create <Int32, string>(2,"F"));
            cboxSexo.DataSource = sexo;
            cboxSexo.DisplayMember = "item2";
            cboxSexo.ValueMember = "item1";



        }


        private Socio GetSocioModel()
        {
            var fullname = $"{txtNombre.Text} {txtApellido.Text}";
            return new Socio()
            {
                IdSocio = txtlCodigoSocio.Text,
                IdTipoSocio = Convert.ToInt32(cboxTipoSocio.SelectedValue),
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                NombreCompleto = fullname,
                Sexo = Sexo(Convert.ToInt32(cboxSexo.SelectedValue)),
                Cedula = txtCedula.Text,
                FechaIngreso = DateTime.Now,
                FechaNac = dtPickerFechaNacimiento.Value,
                Dirreccion = txtDirreccion.Text,
                Telefono = txtTelefono.Text,
                Celular = txtCelular.Text,
                Email = txtCorreo.Text,
                Estatus = 1
            };
        }

        private void ActulizarTabla()
        {
            //var socioList = _socioServices.GetallSocios();
            //_dgvSocios.DataSource = TableMaker(socioList);
        }

        private DataTable TableMaker(List<Socio> socioList)
        {
            var table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("IdSocio", typeof(int));
            table.Columns.Add("Tipo Socio", typeof(string));
            table.Columns.Add("Nombre", typeof(string));
            table.Columns.Add("Apellido", typeof(string));
            table.Columns.Add("Nombre Completo", typeof(string));
            table.Columns.Add("Sexo", typeof(string));
            table.Columns.Add("Cedula", typeof(string));
            table.Columns.Add("Fecha Ingreso", typeof(DateTime));
            table.Columns.Add("Fecha Nacimiento", typeof(DateTime));
            table.Columns.Add("Dirrecion", typeof(string));
            table.Columns.Add("Telefono", typeof(string));
            table.Columns.Add("Celular", typeof(string));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("Estatus", typeof(string));


            foreach (var item in socioList)
            {
                table.Rows.Add(item.Id,
                               item.IdSocio,
                               item.TipoSocio.Descripcion,
                               item.Nombre,
                               item.Apellido,
                               item.NombreCompleto,
                               item.Sexo,
                               item.Cedula,
                               item.FechaIngreso,
                               item.FechaNac,
                               item.Dirreccion,
                               item.Telefono,
                               item.Celular,
                               item.Email,
                               item.Estatus);

            }
            return table;
        }

        private string Sexo(int num)
        {
            var sexo = string.Empty;

            switch (num)
            {
                case 1:
                    sexo = "M";
                    break;

                case 2:
                    sexo = "F";
                    break;
            }
            return sexo;
        }

    }

}
