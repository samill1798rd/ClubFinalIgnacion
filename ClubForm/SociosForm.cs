﻿using System;
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


namespace ClubForm
{
    public partial class SociosForm : Form
    {
        private SocioServices _socioServices;

        public SociosForm()
        {
            InitializeComponent();
            _socioServices = new SocioServices();
            //_socioServices = new SocioServices();
            //dgvSocios.C = _sociosLogic.SearchEstudiantes("hola");
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void clientes_Load(object sender, EventArgs e)
        {
 

            var socioList = _socioServices.GetallSocios();
            dgvSocios.DataSource = TableMaker(socioList);
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Insertar fh = new Insertar();
            fh.StartPosition = FormStartPosition.CenterParent;
            fh.ShowDialog();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            modificar frm = new modificar();
            frm.StartPosition = FormStartPosition.CenterParent;
            if (dgvSocios.SelectedRows.Count > 0)
            {
                frm.txtId.Text = dgvSocios.CurrentRow.Cells[0].Value.ToString();
                frm.txtlCodigoSocio.Text = dgvSocios.CurrentRow.Cells[1].Value.ToString();
                frm.txtNombre.Text = dgvSocios.CurrentRow.Cells[2].Value.ToString();
                frm.txtApellido.Text = dgvSocios.CurrentRow.Cells[3].Value.ToString();
                frm.txtNombre.Text = dgvSocios.CurrentRow.Cells[4].Value.ToString();
                frm.cboxSexo.Text = (ComboBox)dgvSocios.CurrentRow.Cells[6].Value;
                frm.txtlCodigoSocio.Text = dgvSocios.CurrentRow.Cells[1].Value.ToString();
                //frm.txt2.Text = dgvSocios.CurrentRow.Cells[2].Value.ToString();
                //frm.txt3.Text = dgvSocios.CurrentRow.Cells[3].Value.ToString();
                //frm.txt4.Text = dgvSocios.CurrentRow.Cells[4].Value.ToString();
                //frm.txt5.Text = dgvSocios.CurrentRow.Cells[5].Value.ToString();
                frm.ShowDialog();

            //    (item.Id,
            //                   item.IdSocio,
            //                   item.TipoSocio.Descripcion,
            //                   item.Nombre,
            //                   item.Apellido,
            //                   item.NombreCompleto,
            //                   item.Sexo,
            //                   item.Cedula,
            //                   item.FechaIngreso,
            //                   item.FechaNac,
            //                   item.Dirreccion,
            //                   item.Telefono,
            //                   item.Celular,
            //                   item.Email,
            //                   item.Estatus);
            }
            else
            {
                MessageBox.Show("Debe selecionar una fila");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            delete frm = new delete();
            frm.StartPosition = FormStartPosition.CenterParent;
            if (dgvSocios.SelectedRows.Count > 0)
            {
                frm.txt0.Text = dgvSocios.CurrentRow.Cells[0].Value.ToString();
                frm.txt1.Text = dgvSocios.CurrentRow.Cells[1].Value.ToString();
                frm.txt2.Text = dgvSocios.CurrentRow.Cells[2].Value.ToString();
                frm.txt3.Text = dgvSocios.CurrentRow.Cells[3].Value.ToString();
                frm.txt4.Text = dgvSocios.CurrentRow.Cells[4].Value.ToString();
                frm.txt5.Text = dgvSocios.CurrentRow.Cells[5].Value.ToString();
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
