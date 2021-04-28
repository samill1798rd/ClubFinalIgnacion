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

namespace ClubForm.forms
{
    public partial class InsertTipoSocio : Form
    {
        private TipoSocioService _tipoSocioService;
        public InsertTipoSocio()
        {
            InitializeComponent();
           _tipoSocioService = new TipoSocioService();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            var result = _tipoSocioService.CreateTipoSocio(GetTipoSocioMapper());
            if (result.Success != false)
                this.Close();
            else
                lblError.Text = "Error al registrar";
        }

        private TipoSocio GetTipoSocioMapper()
        {
            return new TipoSocio() { Descripcion = txtTipoSocio.Text };

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
