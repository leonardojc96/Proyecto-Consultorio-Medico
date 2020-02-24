namespace Proyecto_Consultorio_Medico.Vistas.Pacientes
{
    partial class ConsultaMedica
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
            System.Windows.Forms.Label id_MedicoLabel;
            System.Windows.Forms.Label estudiosLabel;
            System.Windows.Forms.Label fechaProxConsultaLabel;
            System.Windows.Forms.Label sintomasLabel;
            System.Windows.Forms.Label diagnosticoLabel;
            System.Windows.Forms.Label medicacionSugeridaLabel;
            System.Windows.Forms.Label observacionesLabel;
            System.Windows.Forms.Label notasLabel;
            System.Windows.Forms.Label estudiosSolicitadosLabel;
            System.Windows.Forms.Label estudiosResibidosLabel;
            System.Windows.Forms.Label resultadosEstudiosResibidosLabel;
            System.Windows.Forms.Label lblPaciente;
            this.id_MedicoTextBox = new System.Windows.Forms.TextBox();
            this.estudiosTextBox = new System.Windows.Forms.TextBox();
            this.fechaProxConsultaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sintomasTextBox = new System.Windows.Forms.TextBox();
            this.diagnosticoTextBox = new System.Windows.Forms.TextBox();
            this.medicacionSugeridaTextBox = new System.Windows.Forms.TextBox();
            this.observacionesTextBox = new System.Windows.Forms.TextBox();
            this.estudiosSolicitadosTextBox = new System.Windows.Forms.TextBox();
            this.estudiosResibidosTextBox = new System.Windows.Forms.TextBox();
            this.resultadosEstudiosResibidosTextBox = new System.Windows.Forms.TextBox();
            this.btnEstudios = new System.Windows.Forms.Button();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.openEstudios = new System.Windows.Forms.OpenFileDialog();
            this.rtxtNotas = new System.Windows.Forms.RichTextBox();
            id_MedicoLabel = new System.Windows.Forms.Label();
            estudiosLabel = new System.Windows.Forms.Label();
            fechaProxConsultaLabel = new System.Windows.Forms.Label();
            sintomasLabel = new System.Windows.Forms.Label();
            diagnosticoLabel = new System.Windows.Forms.Label();
            medicacionSugeridaLabel = new System.Windows.Forms.Label();
            observacionesLabel = new System.Windows.Forms.Label();
            notasLabel = new System.Windows.Forms.Label();
            estudiosSolicitadosLabel = new System.Windows.Forms.Label();
            estudiosResibidosLabel = new System.Windows.Forms.Label();
            resultadosEstudiosResibidosLabel = new System.Windows.Forms.Label();
            lblPaciente = new System.Windows.Forms.Label();
            this.panelAlta.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAlta
            // 
            this.panelAlta.Controls.Add(this.rtxtNotas);
            this.panelAlta.Controls.Add(this.btnEstudios);
            this.panelAlta.Controls.Add(this.txtPaciente);
            this.panelAlta.Controls.Add(lblPaciente);
            this.panelAlta.Controls.Add(this.id_MedicoTextBox);
            this.panelAlta.Controls.Add(this.resultadosEstudiosResibidosTextBox);
            this.panelAlta.Controls.Add(resultadosEstudiosResibidosLabel);
            this.panelAlta.Controls.Add(this.estudiosResibidosTextBox);
            this.panelAlta.Controls.Add(estudiosResibidosLabel);
            this.panelAlta.Controls.Add(this.estudiosSolicitadosTextBox);
            this.panelAlta.Controls.Add(estudiosSolicitadosLabel);
            this.panelAlta.Controls.Add(id_MedicoLabel);
            this.panelAlta.Controls.Add(notasLabel);
            this.panelAlta.Controls.Add(estudiosLabel);
            this.panelAlta.Controls.Add(this.observacionesTextBox);
            this.panelAlta.Controls.Add(this.estudiosTextBox);
            this.panelAlta.Controls.Add(observacionesLabel);
            this.panelAlta.Controls.Add(fechaProxConsultaLabel);
            this.panelAlta.Controls.Add(this.medicacionSugeridaTextBox);
            this.panelAlta.Controls.Add(this.fechaProxConsultaDateTimePicker);
            this.panelAlta.Controls.Add(medicacionSugeridaLabel);
            this.panelAlta.Controls.Add(sintomasLabel);
            this.panelAlta.Controls.Add(this.diagnosticoTextBox);
            this.panelAlta.Controls.Add(this.sintomasTextBox);
            this.panelAlta.Controls.Add(diagnosticoLabel);
            this.panelAlta.Location = new System.Drawing.Point(47, 53);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            // 
            // btnModificar
            // 
            this.btnModificar.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Visible = false;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(32)))), ((int)(((byte)(61)))));
            this.panelHeader.ForeColor = System.Drawing.Color.White;
            this.panelHeader.Size = new System.Drawing.Size(789, 55);
            // 
            // id_MedicoLabel
            // 
            id_MedicoLabel.AutoSize = true;
            id_MedicoLabel.Location = new System.Drawing.Point(105, 57);
            id_MedicoLabel.Name = "id_MedicoLabel";
            id_MedicoLabel.Size = new System.Drawing.Size(45, 13);
            id_MedicoLabel.TabIndex = 2;
            id_MedicoLabel.Text = "Medico:";
            // 
            // estudiosLabel
            // 
            estudiosLabel.AutoSize = true;
            estudiosLabel.Location = new System.Drawing.Point(100, 96);
            estudiosLabel.Name = "estudiosLabel";
            estudiosLabel.Size = new System.Drawing.Size(50, 13);
            estudiosLabel.TabIndex = 4;
            estudiosLabel.Text = "Estudios:";
            // 
            // fechaProxConsultaLabel
            // 
            fechaProxConsultaLabel.AutoSize = true;
            fechaProxConsultaLabel.Location = new System.Drawing.Point(42, 320);
            fechaProxConsultaLabel.Name = "fechaProxConsultaLabel";
            fechaProxConsultaLabel.Size = new System.Drawing.Size(108, 13);
            fechaProxConsultaLabel.TabIndex = 6;
            fechaProxConsultaLabel.Text = "Fecha Prox Consulta:";
            // 
            // sintomasLabel
            // 
            sintomasLabel.AutoSize = true;
            sintomasLabel.Location = new System.Drawing.Point(97, 124);
            sintomasLabel.Name = "sintomasLabel";
            sintomasLabel.Size = new System.Drawing.Size(53, 13);
            sintomasLabel.TabIndex = 8;
            sintomasLabel.Text = "Sintomas:";
            // 
            // diagnosticoLabel
            // 
            diagnosticoLabel.AutoSize = true;
            diagnosticoLabel.Location = new System.Drawing.Point(84, 152);
            diagnosticoLabel.Name = "diagnosticoLabel";
            diagnosticoLabel.Size = new System.Drawing.Size(66, 13);
            diagnosticoLabel.TabIndex = 10;
            diagnosticoLabel.Text = "Diagnostico:";
            // 
            // medicacionSugeridaLabel
            // 
            medicacionSugeridaLabel.AutoSize = true;
            medicacionSugeridaLabel.Location = new System.Drawing.Point(40, 180);
            medicacionSugeridaLabel.Name = "medicacionSugeridaLabel";
            medicacionSugeridaLabel.Size = new System.Drawing.Size(110, 13);
            medicacionSugeridaLabel.TabIndex = 12;
            medicacionSugeridaLabel.Text = "Medicacion Sugerida:";
            // 
            // observacionesLabel
            // 
            observacionesLabel.AutoSize = true;
            observacionesLabel.Location = new System.Drawing.Point(69, 208);
            observacionesLabel.Name = "observacionesLabel";
            observacionesLabel.Size = new System.Drawing.Size(81, 13);
            observacionesLabel.TabIndex = 14;
            observacionesLabel.Text = "Observaciones:";
            // 
            // notasLabel
            // 
            notasLabel.AutoSize = true;
            notasLabel.Location = new System.Drawing.Point(112, 348);
            notasLabel.Name = "notasLabel";
            notasLabel.Size = new System.Drawing.Size(38, 13);
            notasLabel.TabIndex = 16;
            notasLabel.Text = "Notas:";
            // 
            // estudiosSolicitadosLabel
            // 
            estudiosSolicitadosLabel.AutoSize = true;
            estudiosSolicitadosLabel.Location = new System.Drawing.Point(46, 236);
            estudiosSolicitadosLabel.Name = "estudiosSolicitadosLabel";
            estudiosSolicitadosLabel.Size = new System.Drawing.Size(104, 13);
            estudiosSolicitadosLabel.TabIndex = 18;
            estudiosSolicitadosLabel.Text = "Estudios Solicitados:";
            // 
            // estudiosResibidosLabel
            // 
            estudiosResibidosLabel.AutoSize = true;
            estudiosResibidosLabel.Location = new System.Drawing.Point(51, 264);
            estudiosResibidosLabel.Name = "estudiosResibidosLabel";
            estudiosResibidosLabel.Size = new System.Drawing.Size(99, 13);
            estudiosResibidosLabel.TabIndex = 20;
            estudiosResibidosLabel.Text = "Estudios Resibidos:";
            // 
            // resultadosEstudiosResibidosLabel
            // 
            resultadosEstudiosResibidosLabel.AutoSize = true;
            resultadosEstudiosResibidosLabel.Location = new System.Drawing.Point(-5, 292);
            resultadosEstudiosResibidosLabel.Name = "resultadosEstudiosResibidosLabel";
            resultadosEstudiosResibidosLabel.Size = new System.Drawing.Size(155, 13);
            resultadosEstudiosResibidosLabel.TabIndex = 22;
            resultadosEstudiosResibidosLabel.Text = "Resultados Estudios Resibidos:";
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.Location = new System.Drawing.Point(105, 31);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new System.Drawing.Size(52, 13);
            lblPaciente.TabIndex = 24;
            lblPaciente.Text = "Paciente:";
            // 
            // id_MedicoTextBox
            // 
            this.id_MedicoTextBox.Location = new System.Drawing.Point(185, 54);
            this.id_MedicoTextBox.Name = "id_MedicoTextBox";
            this.id_MedicoTextBox.ReadOnly = true;
            this.id_MedicoTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_MedicoTextBox.TabIndex = 3;
            // 
            // estudiosTextBox
            // 
            this.estudiosTextBox.Location = new System.Drawing.Point(185, 93);
            this.estudiosTextBox.Name = "estudiosTextBox";
            this.estudiosTextBox.Size = new System.Drawing.Size(200, 20);
            this.estudiosTextBox.TabIndex = 5;
            // 
            // fechaProxConsultaDateTimePicker
            // 
            this.fechaProxConsultaDateTimePicker.Location = new System.Drawing.Point(185, 317);
            this.fechaProxConsultaDateTimePicker.Name = "fechaProxConsultaDateTimePicker";
            this.fechaProxConsultaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaProxConsultaDateTimePicker.TabIndex = 7;
            // 
            // sintomasTextBox
            // 
            this.sintomasTextBox.Location = new System.Drawing.Point(185, 121);
            this.sintomasTextBox.Name = "sintomasTextBox";
            this.sintomasTextBox.Size = new System.Drawing.Size(200, 20);
            this.sintomasTextBox.TabIndex = 9;
            // 
            // diagnosticoTextBox
            // 
            this.diagnosticoTextBox.Location = new System.Drawing.Point(185, 149);
            this.diagnosticoTextBox.Name = "diagnosticoTextBox";
            this.diagnosticoTextBox.Size = new System.Drawing.Size(200, 20);
            this.diagnosticoTextBox.TabIndex = 11;
            // 
            // medicacionSugeridaTextBox
            // 
            this.medicacionSugeridaTextBox.Location = new System.Drawing.Point(185, 177);
            this.medicacionSugeridaTextBox.Name = "medicacionSugeridaTextBox";
            this.medicacionSugeridaTextBox.Size = new System.Drawing.Size(200, 20);
            this.medicacionSugeridaTextBox.TabIndex = 13;
            // 
            // observacionesTextBox
            // 
            this.observacionesTextBox.Location = new System.Drawing.Point(185, 205);
            this.observacionesTextBox.Name = "observacionesTextBox";
            this.observacionesTextBox.Size = new System.Drawing.Size(200, 20);
            this.observacionesTextBox.TabIndex = 15;
            // 
            // estudiosSolicitadosTextBox
            // 
            this.estudiosSolicitadosTextBox.Location = new System.Drawing.Point(185, 233);
            this.estudiosSolicitadosTextBox.Name = "estudiosSolicitadosTextBox";
            this.estudiosSolicitadosTextBox.Size = new System.Drawing.Size(200, 20);
            this.estudiosSolicitadosTextBox.TabIndex = 19;
            // 
            // estudiosResibidosTextBox
            // 
            this.estudiosResibidosTextBox.Location = new System.Drawing.Point(185, 261);
            this.estudiosResibidosTextBox.Name = "estudiosResibidosTextBox";
            this.estudiosResibidosTextBox.Size = new System.Drawing.Size(200, 20);
            this.estudiosResibidosTextBox.TabIndex = 21;
            // 
            // resultadosEstudiosResibidosTextBox
            // 
            this.resultadosEstudiosResibidosTextBox.Location = new System.Drawing.Point(185, 289);
            this.resultadosEstudiosResibidosTextBox.Name = "resultadosEstudiosResibidosTextBox";
            this.resultadosEstudiosResibidosTextBox.Size = new System.Drawing.Size(200, 20);
            this.resultadosEstudiosResibidosTextBox.TabIndex = 23;
            // 
            // btnEstudios
            // 
            this.btnEstudios.Location = new System.Drawing.Point(390, 91);
            this.btnEstudios.Name = "btnEstudios";
            this.btnEstudios.Size = new System.Drawing.Size(27, 23);
            this.btnEstudios.TabIndex = 24;
            this.btnEstudios.Text = "...";
            this.btnEstudios.UseVisualStyleBackColor = true;
            this.btnEstudios.Click += new System.EventHandler(this.btnEstudios_Click);
            // 
            // txtPaciente
            // 
            this.txtPaciente.Location = new System.Drawing.Point(185, 28);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.ReadOnly = true;
            this.txtPaciente.Size = new System.Drawing.Size(200, 20);
            this.txtPaciente.TabIndex = 25;
            // 
            // openEstudios
            // 
            this.openEstudios.FileName = "openFileDialog1";
            // 
            // rtxtNotas
            // 
            this.rtxtNotas.Location = new System.Drawing.Point(185, 345);
            this.rtxtNotas.Name = "rtxtNotas";
            this.rtxtNotas.Size = new System.Drawing.Size(200, 96);
            this.rtxtNotas.TabIndex = 26;
            this.rtxtNotas.Text = "";
            // 
            // ConsultaMedica
            // 
            this.AcceptButton = this.btnAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(806, 472);
            this.Name = "ConsultaMedica";
            this.Text = "ConsultaMedica";
            this.Load += new System.EventHandler(this.ConsultaMedica_Load);
            this.panelAlta.ResumeLayout(false);
            this.panelAlta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox id_MedicoTextBox;
        private System.Windows.Forms.TextBox estudiosTextBox;
        private System.Windows.Forms.DateTimePicker fechaProxConsultaDateTimePicker;
        private System.Windows.Forms.TextBox sintomasTextBox;
        private System.Windows.Forms.TextBox diagnosticoTextBox;
        private System.Windows.Forms.TextBox medicacionSugeridaTextBox;
        private System.Windows.Forms.TextBox observacionesTextBox;
        private System.Windows.Forms.TextBox estudiosSolicitadosTextBox;
        private System.Windows.Forms.TextBox estudiosResibidosTextBox;
        private System.Windows.Forms.TextBox resultadosEstudiosResibidosTextBox;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.Button btnEstudios;
        private System.Windows.Forms.OpenFileDialog openEstudios;
        private System.Windows.Forms.RichTextBox rtxtNotas;
    }
}