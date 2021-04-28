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
    public partial class ModificarTipoSocio : Form
    {
        private TipoSocioService _tipoSocioService;
        public ModificarTipoSocio()
        {
            InitializeComponent();
            _tipoSocioService = new TipoSocioService();

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            var result = _tipoSocioService.UpdateTipoSocio(MapperTipoSocio());
            if (result.Success != false)
                this.Close();
            else
                MessageBox.Show("Error al modifcar");
        }

        private TipoSocio MapperTipoSocio()
        {
            return new TipoSocio()
            {
                IdTipoSocio = Convert.ToInt32(txtId.Text),
                Descripcion = txtDescripcion.Text
            };
        }
    }
}
