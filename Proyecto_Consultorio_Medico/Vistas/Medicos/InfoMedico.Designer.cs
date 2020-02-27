namespace Proyecto_Consultorio_Medico.Vistas.Medicos
{
    partial class InfoMedico
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
            System.Windows.Forms.Label dNILabel;
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label cantidadTurnosLabel;
            System.Windows.Forms.Label contactoAuxLabel;
            System.Windows.Forms.Label fechaNacLabel;
            System.Windows.Forms.Label matriculaLabel;
            this.panelLabels = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCantidadTurnos = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtContactoAux = new System.Windows.Forms.TextBox();
            this.dgvEspecialidades = new System.Windows.Forms.DataGridView();
            this.Especialidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHorarios = new System.Windows.Forms.DataGridView();
            this.H_Entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.H_Salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lunes = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Martes = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Miercoles = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Jueves = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Viernes = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Sabado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Domingo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Consultorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHorarios = new System.Windows.Forms.Label();
            this.lblEspecialidades = new System.Windows.Forms.Label();
            this.btnAbrirCurricula = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvConsultasPendientes = new System.Windows.Forms.DataGridView();
            this.IdConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nTurnos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAbrirConsulta = new System.Windows.Forms.Button();
            this.lblPacientes = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            dNILabel = new System.Windows.Forms.Label();
            apellidoLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            cantidadTurnosLabel = new System.Windows.Forms.Label();
            contactoAuxLabel = new System.Windows.Forms.Label();
            fechaNacLabel = new System.Windows.Forms.Label();
            matriculaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFoto)).BeginInit();
            this.panelLabels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultasPendientes)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxFoto
            // 
            this.picBoxFoto.Location = new System.Drawing.Point(93, 61);
            this.picBoxFoto.Size = new System.Drawing.Size(159, 140);
            // 
            // panelHeader
            // 
            this.panelHeader.Size = new System.Drawing.Size(1395, 55);
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(65, 12);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 0;
            nombreLabel.Text = "Nombre:";
            // 
            // dNILabel
            // 
            dNILabel.AutoSize = true;
            dNILabel.Location = new System.Drawing.Point(83, 64);
            dNILabel.Name = "dNILabel";
            dNILabel.Size = new System.Drawing.Size(29, 13);
            dNILabel.TabIndex = 4;
            dNILabel.Text = "DNI:";
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Location = new System.Drawing.Point(65, 38);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(47, 13);
            apellidoLabel.TabIndex = 2;
            apellidoLabel.Text = "Apellido:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(57, 90);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 6;
            direccionLabel.Text = "Direccion:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(60, 194);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 14;
            telefonoLabel.Text = "Telefono:";
            // 
            // cantidadTurnosLabel
            // 
            cantidadTurnosLabel.AutoSize = true;
            cantidadTurnosLabel.Location = new System.Drawing.Point(24, 116);
            cantidadTurnosLabel.Name = "cantidadTurnosLabel";
            cantidadTurnosLabel.Size = new System.Drawing.Size(88, 13);
            cantidadTurnosLabel.TabIndex = 8;
            cantidadTurnosLabel.Text = "Cantidad Turnos:";
            // 
            // contactoAuxLabel
            // 
            contactoAuxLabel.AutoSize = true;
            contactoAuxLabel.Location = new System.Drawing.Point(38, 220);
            contactoAuxLabel.Name = "contactoAuxLabel";
            contactoAuxLabel.Size = new System.Drawing.Size(74, 13);
            contactoAuxLabel.TabIndex = 16;
            contactoAuxLabel.Text = "Contacto Aux:";
            // 
            // fechaNacLabel
            // 
            fechaNacLabel.AutoSize = true;
            fechaNacLabel.Location = new System.Drawing.Point(49, 142);
            fechaNacLabel.Name = "fechaNacLabel";
            fechaNacLabel.Size = new System.Drawing.Size(63, 13);
            fechaNacLabel.TabIndex = 10;
            fechaNacLabel.Text = "Fecha Nac:";
            // 
            // matriculaLabel
            // 
            matriculaLabel.AutoSize = true;
            matriculaLabel.Location = new System.Drawing.Point(59, 168);
            matriculaLabel.Name = "matriculaLabel";
            matriculaLabel.Size = new System.Drawing.Size(53, 13);
            matriculaLabel.TabIndex = 12;
            matriculaLabel.Text = "Matricula:";
            // 
            // panelLabels
            // 
            this.panelLabels.Controls.Add(nombreLabel);
            this.panelLabels.Controls.Add(dNILabel);
            this.panelLabels.Controls.Add(apellidoLabel);
            this.panelLabels.Controls.Add(direccionLabel);
            this.panelLabels.Controls.Add(telefonoLabel);
            this.panelLabels.Controls.Add(cantidadTurnosLabel);
            this.panelLabels.Controls.Add(contactoAuxLabel);
            this.panelLabels.Controls.Add(fechaNacLabel);
            this.panelLabels.Controls.Add(matriculaLabel);
            this.panelLabels.Location = new System.Drawing.Point(-17, 207);
            this.panelLabels.Name = "panelLabels";
            this.panelLabels.Size = new System.Drawing.Size(128, 281);
            this.panelLabels.TabIndex = 23;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(117, 216);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(135, 20);
            this.txtNombre.TabIndex = 24;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(117, 242);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ReadOnly = true;
            this.txtApellido.Size = new System.Drawing.Size(135, 20);
            this.txtApellido.TabIndex = 25;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(117, 268);
            this.txtDni.Name = "txtDni";
            this.txtDni.ReadOnly = true;
            this.txtDni.Size = new System.Drawing.Size(135, 20);
            this.txtDni.TabIndex = 26;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(117, 294);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(135, 20);
            this.txtDireccion.TabIndex = 27;
            // 
            // txtCantidadTurnos
            // 
            this.txtCantidadTurnos.Location = new System.Drawing.Point(117, 320);
            this.txtCantidadTurnos.Name = "txtCantidadTurnos";
            this.txtCantidadTurnos.ReadOnly = true;
            this.txtCantidadTurnos.Size = new System.Drawing.Size(135, 20);
            this.txtCantidadTurnos.TabIndex = 28;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(117, 346);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(135, 20);
            this.txtFecha.TabIndex = 29;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(117, 372);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.ReadOnly = true;
            this.txtMatricula.Size = new System.Drawing.Size(135, 20);
            this.txtMatricula.TabIndex = 30;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(117, 398);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(135, 20);
            this.txtTelefono.TabIndex = 31;
            // 
            // txtContactoAux
            // 
            this.txtContactoAux.Location = new System.Drawing.Point(117, 424);
            this.txtContactoAux.Name = "txtContactoAux";
            this.txtContactoAux.ReadOnly = true;
            this.txtContactoAux.Size = new System.Drawing.Size(135, 20);
            this.txtContactoAux.TabIndex = 32;
            // 
            // dgvEspecialidades
            // 
            this.dgvEspecialidades.AllowUserToAddRows = false;
            this.dgvEspecialidades.AllowUserToDeleteRows = false;
            this.dgvEspecialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEspecialidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Especialidades});
            this.dgvEspecialidades.Location = new System.Drawing.Point(275, 81);
            this.dgvEspecialidades.Name = "dgvEspecialidades";
            this.dgvEspecialidades.ReadOnly = true;
            this.dgvEspecialidades.Size = new System.Drawing.Size(141, 232);
            this.dgvEspecialidades.TabIndex = 34;
            this.dgvEspecialidades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Especialidades
            // 
            this.Especialidades.HeaderText = "Especialidades";
            this.Especialidades.Name = "Especialidades";
            this.Especialidades.ReadOnly = true;
            // 
            // dgvHorarios
            // 
            this.dgvHorarios.AllowUserToAddRows = false;
            this.dgvHorarios.AllowUserToDeleteRows = false;
            this.dgvHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.H_Entrada,
            this.H_Salida,
            this.Lunes,
            this.Martes,
            this.Miercoles,
            this.Jueves,
            this.Viernes,
            this.Sabado,
            this.Domingo,
            this.Consultorio});
            this.dgvHorarios.Location = new System.Drawing.Point(275, 349);
            this.dgvHorarios.Name = "dgvHorarios";
            this.dgvHorarios.ReadOnly = true;
            this.dgvHorarios.RowHeadersVisible = false;
            this.dgvHorarios.Size = new System.Drawing.Size(469, 253);
            this.dgvHorarios.TabIndex = 35;
            // 
            // H_Entrada
            // 
            this.H_Entrada.HeaderText = "H_Entrada";
            this.H_Entrada.Name = "H_Entrada";
            this.H_Entrada.ReadOnly = true;
            this.H_Entrada.Width = 80;
            // 
            // H_Salida
            // 
            this.H_Salida.HeaderText = "H_Salida";
            this.H_Salida.Name = "H_Salida";
            this.H_Salida.ReadOnly = true;
            this.H_Salida.Width = 80;
            // 
            // Lunes
            // 
            this.Lunes.HeaderText = "L";
            this.Lunes.Name = "Lunes";
            this.Lunes.ReadOnly = true;
            this.Lunes.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Lunes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Lunes.Width = 30;
            // 
            // Martes
            // 
            this.Martes.HeaderText = "Ma";
            this.Martes.Name = "Martes";
            this.Martes.ReadOnly = true;
            this.Martes.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Martes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Martes.Width = 30;
            // 
            // Miercoles
            // 
            this.Miercoles.HeaderText = "Mi";
            this.Miercoles.Name = "Miercoles";
            this.Miercoles.ReadOnly = true;
            this.Miercoles.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Miercoles.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Miercoles.Width = 30;
            // 
            // Jueves
            // 
            this.Jueves.HeaderText = "J";
            this.Jueves.Name = "Jueves";
            this.Jueves.ReadOnly = true;
            this.Jueves.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Jueves.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Jueves.Width = 30;
            // 
            // Viernes
            // 
            this.Viernes.HeaderText = "V";
            this.Viernes.Name = "Viernes";
            this.Viernes.ReadOnly = true;
            this.Viernes.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Viernes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Viernes.Width = 30;
            // 
            // Sabado
            // 
            this.Sabado.HeaderText = "S";
            this.Sabado.Name = "Sabado";
            this.Sabado.ReadOnly = true;
            this.Sabado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Sabado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Sabado.Width = 30;
            // 
            // Domingo
            // 
            this.Domingo.HeaderText = "Do";
            this.Domingo.Name = "Domingo";
            this.Domingo.ReadOnly = true;
            this.Domingo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Domingo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Domingo.Width = 30;
            // 
            // Consultorio
            // 
            this.Consultorio.HeaderText = "Consultorio";
            this.Consultorio.Name = "Consultorio";
            this.Consultorio.ReadOnly = true;
            // 
            // lblHorarios
            // 
            this.lblHorarios.AutoSize = true;
            this.lblHorarios.Location = new System.Drawing.Point(483, 332);
            this.lblHorarios.Name = "lblHorarios";
            this.lblHorarios.Size = new System.Drawing.Size(46, 13);
            this.lblHorarios.TabIndex = 36;
            this.lblHorarios.Text = "Horarios";
            // 
            // lblEspecialidades
            // 
            this.lblEspecialidades.AutoSize = true;
            this.lblEspecialidades.Location = new System.Drawing.Point(309, 65);
            this.lblEspecialidades.Name = "lblEspecialidades";
            this.lblEspecialidades.Size = new System.Drawing.Size(78, 13);
            this.lblEspecialidades.TabIndex = 37;
            this.lblEspecialidades.Text = "Especialidades";
            // 
            // btnAbrirCurricula
            // 
            this.btnAbrirCurricula.Location = new System.Drawing.Point(12, 494);
            this.btnAbrirCurricula.Name = "btnAbrirCurricula";
            this.btnAbrirCurricula.Size = new System.Drawing.Size(252, 23);
            this.btnAbrirCurricula.TabIndex = 38;
            this.btnAbrirCurricula.Text = "Ver curricula (PDF)";
            this.btnAbrirCurricula.UseVisualStyleBackColor = true;
            this.btnAbrirCurricula.Click += new System.EventHandler(this.btnAbrirCurricula_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(693, 81);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 39;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvConsultasPendientes
            // 
            this.dgvConsultasPendientes.AllowUserToAddRows = false;
            this.dgvConsultasPendientes.AllowUserToDeleteRows = false;
            this.dgvConsultasPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultasPendientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdConsulta,
            this.Nombre,
            this.DNI,
            this.nTurnos});
            this.dgvConsultasPendientes.Location = new System.Drawing.Point(432, 80);
            this.dgvConsultasPendientes.Name = "dgvConsultasPendientes";
            this.dgvConsultasPendientes.ReadOnly = true;
            this.dgvConsultasPendientes.Size = new System.Drawing.Size(255, 232);
            this.dgvConsultasPendientes.TabIndex = 40;
            // 
            // IdConsulta
            // 
            this.IdConsulta.HeaderText = "Id de la consulta";
            this.IdConsulta.Name = "IdConsulta";
            this.IdConsulta.ReadOnly = true;
            this.IdConsulta.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre y Apellido";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            // 
            // nTurnos
            // 
            this.nTurnos.HeaderText = "Nº de turno";
            this.nTurnos.Name = "nTurnos";
            this.nTurnos.ReadOnly = true;
            // 
            // btnAbrirConsulta
            // 
            this.btnAbrirConsulta.Location = new System.Drawing.Point(693, 122);
            this.btnAbrirConsulta.Name = "btnAbrirConsulta";
            this.btnAbrirConsulta.Size = new System.Drawing.Size(88, 23);
            this.btnAbrirConsulta.TabIndex = 41;
            this.btnAbrirConsulta.Text = "Abrir consulta";
            this.btnAbrirConsulta.UseVisualStyleBackColor = true;
            this.btnAbrirConsulta.Click += new System.EventHandler(this.btnAbrirConsulta_Click);
            // 
            // lblPacientes
            // 
            this.lblPacientes.AutoSize = true;
            this.lblPacientes.Location = new System.Drawing.Point(527, 65);
            this.lblPacientes.Name = "lblPacientes";
            this.lblPacientes.Size = new System.Drawing.Size(90, 13);
            this.lblPacientes.TabIndex = 42;
            this.lblPacientes.Text = "Ultimos pacientes";
            this.lblPacientes.Click += new System.EventHandler(this.lblPacientes_Click);
            // 
            // InfoMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 892);
            this.Controls.Add(this.lblPacientes);
            this.Controls.Add(this.btnAbrirConsulta);
            this.Controls.Add(this.dgvConsultasPendientes);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAbrirCurricula);
            this.Controls.Add(this.lblEspecialidades);
            this.Controls.Add(this.lblHorarios);
            this.Controls.Add(this.dgvHorarios);
            this.Controls.Add(this.dgvEspecialidades);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtContactoAux);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtCantidadTurnos);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.panelLabels);
            this.Name = "InfoMedico";
            this.Text = "InfoMedico";
            this.Load += new System.EventHandler(this.InfoMedico_Load);
            this.Controls.SetChildIndex(this.panelHeader, 0);
            this.Controls.SetChildIndex(this.picBoxFoto, 0);
            this.Controls.SetChildIndex(this.panelLabels, 0);
            this.Controls.SetChildIndex(this.txtDni, 0);
            this.Controls.SetChildIndex(this.txtApellido, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.txtFecha, 0);
            this.Controls.SetChildIndex(this.txtCantidadTurnos, 0);
            this.Controls.SetChildIndex(this.txtDireccion, 0);
            this.Controls.SetChildIndex(this.txtContactoAux, 0);
            this.Controls.SetChildIndex(this.txtTelefono, 0);
            this.Controls.SetChildIndex(this.txtMatricula, 0);
            this.Controls.SetChildIndex(this.dgvEspecialidades, 0);
            this.Controls.SetChildIndex(this.dgvHorarios, 0);
            this.Controls.SetChildIndex(this.lblHorarios, 0);
            this.Controls.SetChildIndex(this.lblEspecialidades, 0);
            this.Controls.SetChildIndex(this.btnAbrirCurricula, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.dgvConsultasPendientes, 0);
            this.Controls.SetChildIndex(this.btnAbrirConsulta, 0);
            this.Controls.SetChildIndex(this.lblPacientes, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFoto)).EndInit();
            this.panelLabels.ResumeLayout(false);
            this.panelLabels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultasPendientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelLabels;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCantidadTurnos;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtContactoAux;
        private System.Windows.Forms.DataGridView dgvEspecialidades;
        private System.Windows.Forms.DataGridView dgvHorarios;
        private System.Windows.Forms.Label lblHorarios;
        private System.Windows.Forms.Label lblEspecialidades;
        private System.Windows.Forms.Button btnAbrirCurricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn H_Entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn H_Salida;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Lunes;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Martes;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Miercoles;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Jueves;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Viernes;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Sabado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Domingo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consultorio;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvConsultasPendientes;
        private System.Windows.Forms.Button btnAbrirConsulta;
        private System.Windows.Forms.Label lblPacientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn nTurnos;
    }
}