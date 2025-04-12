
using System;
using System.Windows.Forms;

namespace ProyectoCRUD
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstudiantes frm = new FrmEstudiantes();
            frm.ShowDialog();
        }

        private void tareasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTarea frm = new FrmTarea();
            frm.ShowDialog();
        }
    }
}
