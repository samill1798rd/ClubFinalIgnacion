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
using CapaDatos;
using CapaLogica;
using ClubForm.forms;

namespace ClubForm
{
    public partial class TipoSocioForm : Form
    {
        private TipoSocioService _tipoSocioService;

        public TipoSocioForm()
        {
            InitializeComponent();
            _tipoSocioService = new TipoSocioService();
            //_socioServices = new SocioServices();
            //dgvSocios.C = _sociosLogic.SearchEstudiantes("hola");
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void clientes_Load(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            forms.InsertTipoSocio fh = new forms.InsertTipoSocio();
            fh.StartPosition = FormStartPosition.CenterParent;
            fh.ShowDialog();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            ModificarTipoSocio frm = new ModificarTipoSocio();
            frm.StartPosition = FormStartPosition.CenterParent;
            if (dgvTipoSocio.SelectedRows.Count > 0)
            {
                frm.txtId.Text = dgvTipoSocio.CurrentRow.Cells[0].Value.ToString();
                frm.txtDescripcion.Text = dgvTipoSocio.CurrentRow.Cells[1].Value.ToString();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe selecionar una fila");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DeleteTipoSocio frm = new DeleteTipoSocio();
            frm.StartPosition = FormStartPosition.CenterParent;
            if (dgvTipoSocio.SelectedRows.Count > 0)
            {
                frm.txtId.Text = dgvTipoSocio.CurrentRow.Cells[0].Value.ToString();
                frm.txtDescripcion.Text = dgvTipoSocio.CurrentRow.Cells[1].Value.ToString();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe selecionar una fila");
            }


        }


        private void txt0_TextChanged(object sender, EventArgs e)
        {
    
           
        }

        private DataTable TableMaker(List<TipoSocio> tipoSociosList)
        {
            var table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Descripcion", typeof(string));


            foreach (var item in tipoSociosList)
            {
                table.Rows.Add(item.IdTipoSocio,
                               item.Descripcion);

            }
            return table;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarTabla();
        }
        private void ActualizarTabla()
        {
            var tipoSociosList = _tipoSocioService.GetallTipoSocios();
            dgvTipoSocio.DataSource = TableMaker(tipoSociosList);
        }
    }
}
