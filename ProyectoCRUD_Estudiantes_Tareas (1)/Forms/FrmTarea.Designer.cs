
namespace ProyectoCRUD
{
    partial class FrmTarea
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvTareas;

        private void InitializeComponent()
        {
            txtTitulo = new System.Windows.Forms.TextBox();
            txtDescripcion = new System.Windows.Forms.TextBox();
            btnAgregar = new System.Windows.Forms.Button();
            dgvTareas = new System.Windows.Forms.DataGridView();
            dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvTareas).BeginInit();
            SuspendLayout();
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new System.Drawing.Point(12, 12);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new System.Drawing.Size(200, 27);
            txtTitulo.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new System.Drawing.Point(12, 40);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new System.Drawing.Size(200, 27);
            txtDescripcion.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new System.Drawing.Point(230, 12);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new System.Drawing.Size(75, 23);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvTareas
            // 
            dgvTareas.ColumnHeadersHeight = 29;
            dgvTareas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            dgvTareas.Location = new System.Drawing.Point(12, 70);
            dgvTareas.Name = "dgvTareas";
            dgvTareas.RowHeadersWidth = 51;
            dgvTareas.Size = new System.Drawing.Size(400, 200);
            dgvTareas.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Título";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Descripción";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // FrmTarea
            // 
            ClientSize = new System.Drawing.Size(430, 300);
            Controls.Add(txtTitulo);
            Controls.Add(txtDescripcion);
            Controls.Add(btnAgregar);
            Controls.Add(dgvTareas);
            ImeMode = System.Windows.Forms.ImeMode.On;
            Name = "FrmTarea";
            Text = "FrmTarea";
            ((System.ComponentModel.ISupportInitialize)dgvTareas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}
