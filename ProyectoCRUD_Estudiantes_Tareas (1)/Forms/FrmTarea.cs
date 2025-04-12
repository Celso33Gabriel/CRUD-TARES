
using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoCRUD
{
    public partial class FrmTarea : Form
    {
        public FrmTarea()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dgvTareas.Rows.Add(txtTitulo.Text, txtDescripcion.Text);
            txtTitulo.Clear();
            txtDescripcion.Clear();
        }
    }
}
