namespace Proyecto_Consultorio_Medico.Vistas.Pacientes
{
    partial class NuevoTurno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMedicos = new System.Windows.Forms.ComboBox();
            this.proyecto_centro_medicoDataSet = new Proyecto_Consultorio_Medico.Proyecto_centro_medicoDataSet();
            this.medicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicosTableAdapter = new Proyecto_Consultorio_Medico.Proyecto_centro_medicoDataSetTableAdapters.MedicosTableAdapter();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.especialidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.especialidadesTableAdapter = new Proyecto_Consultorio_Medico.Proyecto_centro_medicoDataSetTableAdapters.EspecialidadesTableAdapter();
            this.fKConsultoriosEspecialidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultoriosTableAdapter = new Proyecto_Consultorio_Medico.Proyecto_centro_medicoDataSetTableAdapters.ConsultoriosTableAdapter();
            this.especialidadesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proyecto_centro_medicoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKConsultoriosEspecialidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(32)))), ((int)(((byte)(61)))));
            this.panelHeader.Controls.Add(this.lblTitulo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(945, 55);
            this.panelHeader.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(390, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(33, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Medicos:";
            // 
            // cmbMedicos
            // 
            this.cmbMedicos.FormattingEnabled = true;
            this.cmbMedicos.Location = new System.Drawing.Point(332, 78);
            this.cmbMedicos.Name = "cmbMedicos";
            this.cmbMedicos.Size = new System.Drawing.Size(167, 21);
            this.cmbMedicos.TabIndex = 3;
            // 
            // proyecto_centro_medicoDataSet
            // 
            this.proyecto_centro_medicoDataSet.DataSetName = "Proyecto_centro_medicoDataSet";
            this.proyecto_centro_medicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicosBindingSource
            // 
            this.medicosBindingSource.DataMember = "Medicos";
            this.medicosBindingSource.DataSource = this.proyecto_centro_medicoDataSet;
            // 
            // medicosTableAdapter
            // 
            this.medicosTableAdapter.ClearBeforeFill = true;
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.DataSource = this.especialidadesBindingSource1;
            this.cmbEspecialidad.DisplayMember = "Nombre";
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(106, 78);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(158, 21);
            this.cmbEspecialidad.TabIndex = 4;
            this.cmbEspecialidad.ValueMember = "Id";
            this.cmbEspecialidad.SelectedIndexChanged += new System.EventHandler(this.cmbEspecialidad_SelectedIndexChanged);
            // 
            // especialidadesBindingSource
            // 
            this.especialidadesBindingSource.DataMember = "Especialidades";
            this.especialidadesBindingSource.DataSource = this.proyecto_centro_medicoDataSet;
            // 
            // especialidadesTableAdapter
            // 
            this.especialidadesTableAdapter.ClearBeforeFill = true;
            // 
            // fKConsultoriosEspecialidadesBindingSource
            // 
            this.fKConsultoriosEspecialidadesBindingSource.DataMember = "FK_Consultorios_Especialidades";
            this.fKConsultoriosEspecialidadesBindingSource.DataSource = this.especialidadesBindingSource;
            // 
            // consultoriosTableAdapter
            // 
            this.consultoriosTableAdapter.ClearBeforeFill = true;
            // 
            // especialidadesBindingSource1
            // 
            this.especialidadesBindingSource1.DataMember = "Especialidades";
            this.especialidadesBindingSource1.DataSource = this.proyecto_centro_medicoDataSet;
            // 
            // NuevoTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(94)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(945, 532);
            this.Controls.Add(this.cmbEspecialidad);
            this.Controls.Add(this.cmbMedicos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelHeader);
            this.Name = "NuevoTurno";
            this.Text = "NuevoTurno";
            this.Load += new System.EventHandler(this.NuevoTurno_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proyecto_centro_medicoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKConsultoriosEspecialidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMedicos;
        private Proyecto_centro_medicoDataSet proyecto_centro_medicoDataSet;
        private System.Windows.Forms.BindingSource medicosBindingSource;
        private Proyecto_centro_medicoDataSetTableAdapters.MedicosTableAdapter medicosTableAdapter;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.BindingSource especialidadesBindingSource;
        private Proyecto_centro_medicoDataSetTableAdapters.EspecialidadesTableAdapter especialidadesTableAdapter;
        private System.Windows.Forms.BindingSource fKConsultoriosEspecialidadesBindingSource;
        private Proyecto_centro_medicoDataSetTableAdapters.ConsultoriosTableAdapter consultoriosTableAdapter;
        private System.Windows.Forms.BindingSource especialidadesBindingSource1;
    }
}