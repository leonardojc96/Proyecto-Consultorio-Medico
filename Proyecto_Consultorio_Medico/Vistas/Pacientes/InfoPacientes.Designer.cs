namespace Proyecto_Consultorio_Medico.Vistas.Pacientes
{
    partial class InfoPacientes
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
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label fechaNacLabel;
            System.Windows.Forms.Label fechaIngresoLabel;
            System.Windows.Forms.Label dNILabel;
            System.Windows.Forms.Label obraSocialLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label ultimaVisitaLabel;
            System.Windows.Forms.Label detallesLabel;
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.dNITextBox = new System.Windows.Forms.TextBox();
            this.obraSocialTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.detallesTextBox = new System.Windows.Forms.TextBox();
            this.panelLabels = new System.Windows.Forms.Panel();
            this.txtFechaNac = new System.Windows.Forms.TextBox();
            this.txtFecIngreso = new System.Windows.Forms.TextBox();
            this.txtFecUltimaVis = new System.Windows.Forms.TextBox();
            this.dgvConsultas = new System.Windows.Forms.DataGridView();
            this.IdColumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNuevoTur = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            nombreLabel = new System.Windows.Forms.Label();
            apellidoLabel = new System.Windows.Forms.Label();
            fechaNacLabel = new System.Windows.Forms.Label();
            fechaIngresoLabel = new System.Windows.Forms.Label();
            dNILabel = new System.Windows.Forms.Label();
            obraSocialLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            ultimaVisitaLabel = new System.Windows.Forms.Label();
            detallesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFoto)).BeginInit();
            this.panelLabels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxFoto
            // 
            this.picBoxFoto.Location = new System.Drawing.Point(12, 63);
            this.picBoxFoto.Size = new System.Drawing.Size(160, 84);
            // 
            // panelHeader
            // 
            this.panelHeader.Size = new System.Drawing.Size(766, 55);
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(3, 2);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 5;
            nombreLabel.Text = "Nombre:";
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Location = new System.Drawing.Point(3, 41);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(47, 13);
            apellidoLabel.TabIndex = 7;
            apellidoLabel.Text = "Apellido:";
            // 
            // fechaNacLabel
            // 
            fechaNacLabel.AutoSize = true;
            fechaNacLabel.Location = new System.Drawing.Point(3, 79);
            fechaNacLabel.Name = "fechaNacLabel";
            fechaNacLabel.Size = new System.Drawing.Size(63, 13);
            fechaNacLabel.TabIndex = 9;
            fechaNacLabel.Text = "Fecha Nac:";
            // 
            // fechaIngresoLabel
            // 
            fechaIngresoLabel.AutoSize = true;
            fechaIngresoLabel.Location = new System.Drawing.Point(3, 118);
            fechaIngresoLabel.Name = "fechaIngresoLabel";
            fechaIngresoLabel.Size = new System.Drawing.Size(78, 13);
            fechaIngresoLabel.TabIndex = 11;
            fechaIngresoLabel.Text = "Fecha Ingreso:";
            // 
            // dNILabel
            // 
            dNILabel.AutoSize = true;
            dNILabel.Location = new System.Drawing.Point(3, 157);
            dNILabel.Name = "dNILabel";
            dNILabel.Size = new System.Drawing.Size(29, 13);
            dNILabel.TabIndex = 13;
            dNILabel.Text = "DNI:";
            // 
            // obraSocialLabel
            // 
            obraSocialLabel.AutoSize = true;
            obraSocialLabel.Location = new System.Drawing.Point(5, 193);
            obraSocialLabel.Name = "obraSocialLabel";
            obraSocialLabel.Size = new System.Drawing.Size(65, 13);
            obraSocialLabel.TabIndex = 15;
            obraSocialLabel.Text = "Obra Social:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(5, 228);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 17;
            telefonoLabel.Text = "Telefono:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(3, 264);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 19;
            direccionLabel.Text = "Direccion:";
            // 
            // ultimaVisitaLabel
            // 
            ultimaVisitaLabel.AutoSize = true;
            ultimaVisitaLabel.Location = new System.Drawing.Point(3, 301);
            ultimaVisitaLabel.Name = "ultimaVisitaLabel";
            ultimaVisitaLabel.Size = new System.Drawing.Size(67, 13);
            ultimaVisitaLabel.TabIndex = 23;
            ultimaVisitaLabel.Text = "Ultima Visita:";
            // 
            // detallesLabel
            // 
            detallesLabel.AutoSize = true;
            detallesLabel.Location = new System.Drawing.Point(3, 341);
            detallesLabel.Name = "detallesLabel";
            detallesLabel.Size = new System.Drawing.Size(48, 13);
            detallesLabel.TabIndex = 25;
            detallesLabel.Text = "Detalles:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(104, 152);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(198, 20);
            this.nombreTextBox.TabIndex = 6;
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.Location = new System.Drawing.Point(104, 191);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(198, 20);
            this.apellidoTextBox.TabIndex = 8;
            // 
            // dNITextBox
            // 
            this.dNITextBox.Location = new System.Drawing.Point(104, 307);
            this.dNITextBox.Name = "dNITextBox";
            this.dNITextBox.Size = new System.Drawing.Size(198, 20);
            this.dNITextBox.TabIndex = 14;
            // 
            // obraSocialTextBox
            // 
            this.obraSocialTextBox.Location = new System.Drawing.Point(104, 343);
            this.obraSocialTextBox.Name = "obraSocialTextBox";
            this.obraSocialTextBox.Size = new System.Drawing.Size(198, 20);
            this.obraSocialTextBox.TabIndex = 16;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.Location = new System.Drawing.Point(104, 378);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(198, 20);
            this.telefonoTextBox.TabIndex = 18;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.Location = new System.Drawing.Point(104, 414);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(198, 20);
            this.direccionTextBox.TabIndex = 20;
            // 
            // detallesTextBox
            // 
            this.detallesTextBox.Location = new System.Drawing.Point(104, 491);
            this.detallesTextBox.Name = "detallesTextBox";
            this.detallesTextBox.Size = new System.Drawing.Size(198, 20);
            this.detallesTextBox.TabIndex = 26;
            // 
            // panelLabels
            // 
            this.panelLabels.Controls.Add(apellidoLabel);
            this.panelLabels.Controls.Add(detallesLabel);
            this.panelLabels.Controls.Add(ultimaVisitaLabel);
            this.panelLabels.Controls.Add(nombreLabel);
            this.panelLabels.Controls.Add(direccionLabel);
            this.panelLabels.Controls.Add(telefonoLabel);
            this.panelLabels.Controls.Add(obraSocialLabel);
            this.panelLabels.Controls.Add(dNILabel);
            this.panelLabels.Controls.Add(fechaNacLabel);
            this.panelLabels.Controls.Add(fechaIngresoLabel);
            this.panelLabels.Location = new System.Drawing.Point(0, 153);
            this.panelLabels.Name = "panelLabels";
            this.panelLabels.Size = new System.Drawing.Size(98, 397);
            this.panelLabels.TabIndex = 27;
            // 
            // txtFechaNac
            // 
            this.txtFechaNac.Location = new System.Drawing.Point(104, 229);
            this.txtFechaNac.Name = "txtFechaNac";
            this.txtFechaNac.Size = new System.Drawing.Size(198, 20);
            this.txtFechaNac.TabIndex = 28;
            // 
            // txtFecIngreso
            // 
            this.txtFecIngreso.Location = new System.Drawing.Point(104, 268);
            this.txtFecIngreso.Name = "txtFecIngreso";
            this.txtFecIngreso.Size = new System.Drawing.Size(198, 20);
            this.txtFecIngreso.TabIndex = 29;
            // 
            // txtFecUltimaVis
            // 
            this.txtFecUltimaVis.Location = new System.Drawing.Point(104, 451);
            this.txtFecUltimaVis.Name = "txtFecUltimaVis";
            this.txtFecUltimaVis.Size = new System.Drawing.Size(198, 20);
            this.txtFecUltimaVis.TabIndex = 30;
            // 
            // dgvConsultas
            // 
            this.dgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumna,
            this.ClmDoc,
            this.ClmFecha,
            this.ClmMedico});
            this.dgvConsultas.Location = new System.Drawing.Point(332, 113);
            this.dgvConsultas.Name = "dgvConsultas";
            this.dgvConsultas.Size = new System.Drawing.Size(539, 296);
            this.dgvConsultas.TabIndex = 31;
            this.dgvConsultas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultas_CellDoubleClick);
            // 
            // IdColumna
            // 
            this.IdColumna.HeaderText = "N°";
            this.IdColumna.Name = "IdColumna";
            // 
            // ClmDoc
            // 
            this.ClmDoc.HeaderText = "Doc";
            this.ClmDoc.Name = "ClmDoc";
            this.ClmDoc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ClmFecha
            // 
            this.ClmFecha.HeaderText = "Fecha";
            this.ClmFecha.Name = "ClmFecha";
            // 
            // ClmMedico
            // 
            this.ClmMedico.HeaderText = "Medico";
            this.ClmMedico.Name = "ClmMedico";
            // 
            // btnNuevoTur
            // 
            this.btnNuevoTur.Location = new System.Drawing.Point(332, 450);
            this.btnNuevoTur.Name = "btnNuevoTur";
            this.btnNuevoTur.Size = new System.Drawing.Size(144, 48);
            this.btnNuevoTur.TabIndex = 32;
            this.btnNuevoTur.Text = "Nuevo Turno";
            this.btnNuevoTur.UseVisualStyleBackColor = true;
            this.btnNuevoTur.Click += new System.EventHandler(this.btnNuevoTur_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(592, 450);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(144, 48);
            this.btnSalir.TabIndex = 33;
            this.btnSalir.Text = "Volver";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // InfoPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 555);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNuevoTur);
            this.Controls.Add(this.dgvConsultas);
            this.Controls.Add(this.txtFecUltimaVis);
            this.Controls.Add(this.txtFecIngreso);
            this.Controls.Add(this.txtFechaNac);
            this.Controls.Add(this.panelLabels);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(this.dNITextBox);
            this.Controls.Add(this.obraSocialTextBox);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(this.detallesTextBox);
            this.Name = "InfoPacientes";
            this.Text = "InfoPacientes";
            this.Load += new System.EventHandler(this.InfoPacientes_Load);
            this.Controls.SetChildIndex(this.detallesTextBox, 0);
            this.Controls.SetChildIndex(this.direccionTextBox, 0);
            this.Controls.SetChildIndex(this.telefonoTextBox, 0);
            this.Controls.SetChildIndex(this.obraSocialTextBox, 0);
            this.Controls.SetChildIndex(this.dNITextBox, 0);
            this.Controls.SetChildIndex(this.apellidoTextBox, 0);
            this.Controls.SetChildIndex(this.nombreTextBox, 0);
            this.Controls.SetChildIndex(this.panelLabels, 0);
            this.Controls.SetChildIndex(this.panelHeader, 0);
            this.Controls.SetChildIndex(this.picBoxFoto, 0);
            this.Controls.SetChildIndex(this.txtFechaNac, 0);
            this.Controls.SetChildIndex(this.txtFecIngreso, 0);
            this.Controls.SetChildIndex(this.txtFecUltimaVis, 0);
            this.Controls.SetChildIndex(this.dgvConsultas, 0);
            this.Controls.SetChildIndex(this.btnNuevoTur, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFoto)).EndInit();
            this.panelLabels.ResumeLayout(false);
            this.panelLabels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox dNITextBox;
        private System.Windows.Forms.TextBox obraSocialTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox detallesTextBox;
        private System.Windows.Forms.Panel panelLabels;
        private System.Windows.Forms.TextBox txtFechaNac;
        private System.Windows.Forms.TextBox txtFecIngreso;
        private System.Windows.Forms.TextBox txtFecUltimaVis;
        private System.Windows.Forms.DataGridView dgvConsultas;
        private System.Windows.Forms.Button btnNuevoTur;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmMedico;
    }
}