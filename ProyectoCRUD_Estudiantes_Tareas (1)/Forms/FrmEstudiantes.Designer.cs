
namespace ProyectoCRUD
{
    partial class FrmEstudiantes
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.ComboBox comboSeccion;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvEstudiantes;

        private void InitializeComponent()
        {
            txtCarnet = new System.Windows.Forms.TextBox();
            comboSeccion = new System.Windows.Forms.ComboBox();
            btnBuscar = new System.Windows.Forms.Button();
            dgvEstudiantes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).BeginInit();
            SuspendLayout();
            // 
            // txtCarnet
            // 
            txtCarnet.BackColor = System.Drawing.SystemColors.Info;
            txtCarnet.Location = new System.Drawing.Point(12, 12);
            txtCarnet.Name = "txtCarnet";
            txtCarnet.Size = new System.Drawing.Size(160, 27);
            txtCarnet.TabIndex = 0;
            txtCarnet.TextChanged += txtCarnet_TextChanged;
            // 
            // comboSeccion
            // 
            comboSeccion.BackColor = System.Drawing.SystemColors.Info;
            comboSeccion.Items.AddRange(new object[] { "A", "B", "C" });
            comboSeccion.Location = new System.Drawing.Point(12, 40);
            comboSeccion.Name = "comboSeccion";
            comboSeccion.Size = new System.Drawing.Size(160, 28);
            comboSeccion.TabIndex = 1;
            comboSeccion.SelectedIndexChanged += comboSeccion_SelectedIndexChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnBuscar.Location = new System.Drawing.Point(180, 12);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(75, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvEstudiantes
            // 
            dgvEstudiantes.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dgvEstudiantes.ColumnHeadersHeight = 29;
            dgvEstudiantes.Location = new System.Drawing.Point(12, 70);
            dgvEstudiantes.Name = "dgvEstudiantes";
            dgvEstudiantes.RowHeadersWidth = 51;
            dgvEstudiantes.Size = new System.Drawing.Size(400, 200);
            dgvEstudiantes.TabIndex = 3;
            // 
            // FrmEstudiantes
            // 
            ClientSize = new System.Drawing.Size(430, 300);
            Controls.Add(txtCarnet);
            Controls.Add(comboSeccion);
            Controls.Add(btnBuscar);
            Controls.Add(dgvEstudiantes);
            Name = "FrmEstudiantes";
            Text = "FrmEstudiantes";
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
