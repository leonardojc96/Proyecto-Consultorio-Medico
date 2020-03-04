namespace Proyecto_Consultorio_Medico.Vistas.Pacientes
{
    partial class DetalleConsultaMedica
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
            System.Windows.Forms.Label fechaProxConsultaLabel;
            System.Windows.Forms.Label sintomasLabel;
            System.Windows.Forms.Label diagnosticoLabel;
            System.Windows.Forms.Label medicacionSugeridaLabel;
            System.Windows.Forms.Label observacionesLabel;
            System.Windows.Forms.Label notasLabel;
            System.Windows.Forms.Label estudiosSolicitadosLabel;
            System.Windows.Forms.Label estudiosResibidosLabel;
            System.Windows.Forms.Label resultadosEstudiosResibidosLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalleConsultaMedica));
            this.id_MedicoTextBox = new System.Windows.Forms.TextBox();
            this.sintomasTextBox = new System.Windows.Forms.TextBox();
            this.diagnosticoTextBox = new System.Windows.Forms.TextBox();
            this.medicacionSugeridaTextBox = new System.Windows.Forms.TextBox();
            this.observacionesTextBox = new System.Windows.Forms.TextBox();
            this.estudiosSolicitadosTextBox = new System.Windows.Forms.TextBox();
            this.estudiosResibidosTextBox = new System.Windows.Forms.TextBox();
            this.resultadosEstudiosResibidosTextBox = new System.Windows.Forms.TextBox();
            this.txtFechaProx = new System.Windows.Forms.TextBox();
            this.richTxtNotas = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pdfEstudios = new AxAcroPDFLib.AxAcroPDF();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblEstudios = new System.Windows.Forms.Label();
            id_MedicoLabel = new System.Windows.Forms.Label();
            fechaProxConsultaLabel = new System.Windows.Forms.Label();
            sintomasLabel = new System.Windows.Forms.Label();
            diagnosticoLabel = new System.Windows.Forms.Label();
            medicacionSugeridaLabel = new System.Windows.Forms.Label();
            observacionesLabel = new System.Windows.Forms.Label();
            notasLabel = new System.Windows.Forms.Label();
            estudiosSolicitadosLabel = new System.Windows.Forms.Label();
            estudiosResibidosLabel = new System.Windows.Forms.Label();
            resultadosEstudiosResibidosLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pdfEstudios)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(32)))), ((int)(((byte)(61)))));
            this.panelHeader.ForeColor = System.Drawing.Color.White;
            this.panelHeader.Size = new System.Drawing.Size(1395, 55);
            // 
            // id_MedicoLabel
            // 
            id_MedicoLabel.AutoSize = true;
            id_MedicoLabel.Location = new System.Drawing.Point(83, 37);
            id_MedicoLabel.Name = "id_MedicoLabel";
            id_MedicoLabel.Size = new System.Drawing.Size(45, 13);
            id_MedicoLabel.TabIndex = 2;
            id_MedicoLabel.Text = "Medico:";
            // 
            // fechaProxConsultaLabel
            // 
            fechaProxConsultaLabel.AutoSize = true;
            fechaProxConsultaLabel.Location = new System.Drawing.Point(32, 68);
            fechaProxConsultaLabel.Name = "fechaProxConsultaLabel";
            fechaProxConsultaLabel.Size = new System.Drawing.Size(108, 13);
            fechaProxConsultaLabel.TabIndex = 6;
            fechaProxConsultaLabel.Text = "Fecha Prox Consulta:";
            // 
            // sintomasLabel
            // 
            sintomasLabel.AutoSize = true;
            sintomasLabel.Location = new System.Drawing.Point(87, 99);
            sintomasLabel.Name = "sintomasLabel";
            sintomasLabel.Size = new System.Drawing.Size(53, 13);
            sintomasLabel.TabIndex = 8;
            sintomasLabel.Text = "Sintomas:";
            // 
            // diagnosticoLabel
            // 
            diagnosticoLabel.AutoSize = true;
            diagnosticoLabel.Location = new System.Drawing.Point(74, 130);
            diagnosticoLabel.Name = "diagnosticoLabel";
            diagnosticoLabel.Size = new System.Drawing.Size(66, 13);
            diagnosticoLabel.TabIndex = 10;
            diagnosticoLabel.Text = "Diagnostico:";
            // 
            // medicacionSugeridaLabel
            // 
            medicacionSugeridaLabel.AutoSize = true;
            medicacionSugeridaLabel.Location = new System.Drawing.Point(30, 161);
            medicacionSugeridaLabel.Name = "medicacionSugeridaLabel";
            medicacionSugeridaLabel.Size = new System.Drawing.Size(110, 13);
            medicacionSugeridaLabel.TabIndex = 12;
            medicacionSugeridaLabel.Text = "Medicacion Sugerida:";
            // 
            // observacionesLabel
            // 
            observacionesLabel.AutoSize = true;
            observacionesLabel.Location = new System.Drawing.Point(59, 192);
            observacionesLabel.Name = "observacionesLabel";
            observacionesLabel.Size = new System.Drawing.Size(81, 13);
            observacionesLabel.TabIndex = 14;
            observacionesLabel.Text = "Observaciones:";
            // 
            // notasLabel
            // 
            notasLabel.AutoSize = true;
            notasLabel.Location = new System.Drawing.Point(102, 311);
            notasLabel.Name = "notasLabel";
            notasLabel.Size = new System.Drawing.Size(38, 13);
            notasLabel.TabIndex = 16;
            notasLabel.Text = "Notas:";
            // 
            // estudiosSolicitadosLabel
            // 
            estudiosSolicitadosLabel.AutoSize = true;
            estudiosSolicitadosLabel.Location = new System.Drawing.Point(36, 223);
            estudiosSolicitadosLabel.Name = "estudiosSolicitadosLabel";
            estudiosSolicitadosLabel.Size = new System.Drawing.Size(104, 13);
            estudiosSolicitadosLabel.TabIndex = 18;
            estudiosSolicitadosLabel.Text = "Estudios Solicitados:";
            // 
            // estudiosResibidosLabel
            // 
            estudiosResibidosLabel.AutoSize = true;
            estudiosResibidosLabel.Location = new System.Drawing.Point(41, 254);
            estudiosResibidosLabel.Name = "estudiosResibidosLabel";
            estudiosResibidosLabel.Size = new System.Drawing.Size(99, 13);
            estudiosResibidosLabel.TabIndex = 20;
            estudiosResibidosLabel.Text = "Estudios Resibidos:";
            // 
            // resultadosEstudiosResibidosLabel
            // 
            resultadosEstudiosResibidosLabel.AutoSize = true;
            resultadosEstudiosResibidosLabel.Location = new System.Drawing.Point(-15, 285);
            resultadosEstudiosResibidosLabel.Name = "resultadosEstudiosResibidosLabel";
            resultadosEstudiosResibidosLabel.Size = new System.Drawing.Size(155, 13);
            resultadosEstudiosResibidosLabel.TabIndex = 22;
            resultadosEstudiosResibidosLabel.Text = "Resultados Estudios Resibidos:";
            // 
            // id_MedicoTextBox
            // 
            this.id_MedicoTextBox.Location = new System.Drawing.Point(192, 109);
            this.id_MedicoTextBox.Name = "id_MedicoTextBox";
            this.id_MedicoTextBox.ReadOnly = true;
            this.id_MedicoTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_MedicoTextBox.TabIndex = 3;
            // 
            // sintomasTextBox
            // 
            this.sintomasTextBox.Location = new System.Drawing.Point(192, 171);
            this.sintomasTextBox.Name = "sintomasTextBox";
            this.sintomasTextBox.ReadOnly = true;
            this.sintomasTextBox.Size = new System.Drawing.Size(200, 20);
            this.sintomasTextBox.TabIndex = 9;
            // 
            // diagnosticoTextBox
            // 
            this.diagnosticoTextBox.Location = new System.Drawing.Point(192, 202);
            this.diagnosticoTextBox.Name = "diagnosticoTextBox";
            this.diagnosticoTextBox.ReadOnly = true;
            this.diagnosticoTextBox.Size = new System.Drawing.Size(200, 20);
            this.diagnosticoTextBox.TabIndex = 11;
            // 
            // medicacionSugeridaTextBox
            // 
            this.medicacionSugeridaTextBox.Location = new System.Drawing.Point(192, 233);
            this.medicacionSugeridaTextBox.Name = "medicacionSugeridaTextBox";
            this.medicacionSugeridaTextBox.ReadOnly = true;
            this.medicacionSugeridaTextBox.Size = new System.Drawing.Size(200, 20);
            this.medicacionSugeridaTextBox.TabIndex = 13;
            // 
            // observacionesTextBox
            // 
            this.observacionesTextBox.Location = new System.Drawing.Point(192, 264);
            this.observacionesTextBox.Name = "observacionesTextBox";
            this.observacionesTextBox.ReadOnly = true;
            this.observacionesTextBox.Size = new System.Drawing.Size(200, 20);
            this.observacionesTextBox.TabIndex = 15;
            // 
            // estudiosSolicitadosTextBox
            // 
            this.estudiosSolicitadosTextBox.Location = new System.Drawing.Point(192, 295);
            this.estudiosSolicitadosTextBox.Name = "estudiosSolicitadosTextBox";
            this.estudiosSolicitadosTextBox.ReadOnly = true;
            this.estudiosSolicitadosTextBox.Size = new System.Drawing.Size(200, 20);
            this.estudiosSolicitadosTextBox.TabIndex = 19;
            // 
            // estudiosResibidosTextBox
            // 
            this.estudiosResibidosTextBox.Location = new System.Drawing.Point(192, 326);
            this.estudiosResibidosTextBox.Name = "estudiosResibidosTextBox";
            this.estudiosResibidosTextBox.ReadOnly = true;
            this.estudiosResibidosTextBox.Size = new System.Drawing.Size(200, 20);
            this.estudiosResibidosTextBox.TabIndex = 21;
            // 
            // resultadosEstudiosResibidosTextBox
            // 
            this.resultadosEstudiosResibidosTextBox.Location = new System.Drawing.Point(192, 357);
            this.resultadosEstudiosResibidosTextBox.Name = "resultadosEstudiosResibidosTextBox";
            this.resultadosEstudiosResibidosTextBox.ReadOnly = true;
            this.resultadosEstudiosResibidosTextBox.Size = new System.Drawing.Size(200, 20);
            this.resultadosEstudiosResibidosTextBox.TabIndex = 23;
            // 
            // txtFechaProx
            // 
            this.txtFechaProx.Location = new System.Drawing.Point(192, 140);
            this.txtFechaProx.Name = "txtFechaProx";
            this.txtFechaProx.ReadOnly = true;
            this.txtFechaProx.Size = new System.Drawing.Size(200, 20);
            this.txtFechaProx.TabIndex = 24;
            // 
            // richTxtNotas
            // 
            this.richTxtNotas.Location = new System.Drawing.Point(192, 388);
            this.richTxtNotas.Name = "richTxtNotas";
            this.richTxtNotas.ReadOnly = true;
            this.richTxtNotas.Size = new System.Drawing.Size(200, 96);
            this.richTxtNotas.TabIndex = 26;
            this.richTxtNotas.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(id_MedicoLabel);
            this.panel1.Controls.Add(resultadosEstudiosResibidosLabel);
            this.panel1.Controls.Add(estudiosResibidosLabel);
            this.panel1.Controls.Add(estudiosSolicitadosLabel);
            this.panel1.Controls.Add(notasLabel);
            this.panel1.Controls.Add(observacionesLabel);
            this.panel1.Controls.Add(fechaProxConsultaLabel);
            this.panel1.Controls.Add(medicacionSugeridaLabel);
            this.panel1.Controls.Add(sintomasLabel);
            this.panel1.Controls.Add(diagnosticoLabel);
            this.panel1.Location = new System.Drawing.Point(12, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 375);
            this.panel1.TabIndex = 27;
            // 
            // pdfEstudios
            // 
            this.pdfEstudios.Dock = System.Windows.Forms.DockStyle.Right;
            this.pdfEstudios.Enabled = true;
            this.pdfEstudios.Location = new System.Drawing.Point(1018, 55);
            this.pdfEstudios.Name = "pdfEstudios";
            this.pdfEstudios.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdfEstudios.OcxState")));
            this.pdfEstudios.Size = new System.Drawing.Size(377, 837);
            this.pdfEstudios.TabIndex = 28;
            this.pdfEstudios.OnError += new System.EventHandler(this.pdfEstudios_OnError);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(317, 515);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 29;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblEstudios
            // 
            this.lblEstudios.AutoSize = true;
            this.lblEstudios.Location = new System.Drawing.Point(418, 295);
            this.lblEstudios.Name = "lblEstudios";
            this.lblEstudios.Size = new System.Drawing.Size(50, 13);
            this.lblEstudios.TabIndex = 30;
            this.lblEstudios.Text = "Estudios:";
            // 
            // DetalleConsultaMedica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1395, 892);
            this.Controls.Add(this.lblEstudios);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pdfEstudios);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTxtNotas);
            this.Controls.Add(this.txtFechaProx);
            this.Controls.Add(this.id_MedicoTextBox);
            this.Controls.Add(this.sintomasTextBox);
            this.Controls.Add(this.diagnosticoTextBox);
            this.Controls.Add(this.medicacionSugeridaTextBox);
            this.Controls.Add(this.observacionesTextBox);
            this.Controls.Add(this.estudiosSolicitadosTextBox);
            this.Controls.Add(this.estudiosResibidosTextBox);
            this.Controls.Add(this.resultadosEstudiosResibidosTextBox);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetalleConsultaMedica";
            this.Text = "DetalleConsultaMedica";
            this.Load += new System.EventHandler(this.DetalleConsultaMedica_Load);
            this.Controls.SetChildIndex(this.resultadosEstudiosResibidosTextBox, 0);
            this.Controls.SetChildIndex(this.estudiosResibidosTextBox, 0);
            this.Controls.SetChildIndex(this.estudiosSolicitadosTextBox, 0);
            this.Controls.SetChildIndex(this.observacionesTextBox, 0);
            this.Controls.SetChildIndex(this.medicacionSugeridaTextBox, 0);
            this.Controls.SetChildIndex(this.diagnosticoTextBox, 0);
            this.Controls.SetChildIndex(this.sintomasTextBox, 0);
            this.Controls.SetChildIndex(this.id_MedicoTextBox, 0);
            this.Controls.SetChildIndex(this.txtFechaProx, 0);
            this.Controls.SetChildIndex(this.richTxtNotas, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panelHeader, 0);
            this.Controls.SetChildIndex(this.pdfEstudios, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.lblEstudios, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pdfEstudios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id_MedicoTextBox;
        private System.Windows.Forms.TextBox sintomasTextBox;
        private System.Windows.Forms.TextBox diagnosticoTextBox;
        private System.Windows.Forms.TextBox medicacionSugeridaTextBox;
        private System.Windows.Forms.TextBox observacionesTextBox;
        private System.Windows.Forms.TextBox estudiosSolicitadosTextBox;
        private System.Windows.Forms.TextBox estudiosResibidosTextBox;
        private System.Windows.Forms.TextBox resultadosEstudiosResibidosTextBox;
        private System.Windows.Forms.TextBox txtFechaProx;
        private System.Windows.Forms.RichTextBox richTxtNotas;
        private System.Windows.Forms.Panel panel1;
        private AxAcroPDFLib.AxAcroPDF pdfEstudios;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblEstudios;
    }
}