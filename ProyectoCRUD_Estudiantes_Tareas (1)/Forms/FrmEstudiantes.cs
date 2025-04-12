
using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoCRUD
{
    public partial class FrmEstudiantes : Form
    {
        public FrmEstudiantes()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvEstudiantes.DataSource = Estudiante.Buscar(txtCarnet.Text, comboSeccion.Text);
        }

        private void txtCarnet_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboSeccion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
