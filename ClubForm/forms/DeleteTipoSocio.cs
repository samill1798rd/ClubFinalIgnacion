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
    public partial class DeleteTipoSocio : Form
    {
        private TipoSocioService _tipoSocioService;
        public DeleteTipoSocio()
        {
            InitializeComponent();
            _tipoSocioService = new TipoSocioService();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            var result = _tipoSocioService.DelecteTipoSocio(Convert.ToInt32(txtId.Text));
            if (result.Success != false)
                this.Close();
            else
                MessageBox.Show("Error al eliminar");
        }
    }
}
