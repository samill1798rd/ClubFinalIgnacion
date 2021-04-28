using CapaDatos;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubForm
{
    public class Library
    {
        private SocioServices _socioServices;

        public Library()
        {
            _socioServices = new SocioServices(); 
        }

        public void ActualizarTable(DataGridView dgvSocios)
        {
            var socioList = _socioServices.GetallSocios();
            dgvSocios.DataSource = TableMaker(socioList);
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
    }
}
