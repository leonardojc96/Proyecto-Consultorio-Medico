namespace Proyecto_Consultorio_Medico.Vistas
{
    partial class Menu
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNuevoPaciente = new System.Windows.Forms.Button();
            this.btnNuevoMedico = new System.Windows.Forms.Button();
            this.btnListaPacientes = new System.Windows.Forms.Button();
            this.btnListaMEdicos = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(32)))), ((int)(((byte)(61)))));
            this.panelHeader.ForeColor = System.Drawing.Color.White;
            this.panelHeader.Size = new System.Drawing.Size(1370, 55);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnNuevoPaciente, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnNuevoMedico, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnListaPacientes, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnListaMEdicos, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 55);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(103);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1370, 837);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnNuevoPaciente
            // 
            this.btnNuevoPaciente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNuevoPaciente.Location = new System.Drawing.Point(13, 640);
            this.btnNuevoPaciente.Margin = new System.Windows.Forms.Padding(13);
            this.btnNuevoPaciente.Name = "btnNuevoPaciente";
            this.btnNuevoPaciente.Size = new System.Drawing.Size(1344, 184);
            this.btnNuevoPaciente.TabIndex = 3;
            this.btnNuevoPaciente.Text = "Nuevo paciente";
            this.btnNuevoPaciente.UseVisualStyleBackColor = true;
            this.btnNuevoPaciente.Click += new System.EventHandler(this.btnNuevoPaciente_Click);
            // 
            // btnNuevoMedico
            // 
            this.btnNuevoMedico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNuevoMedico.Location = new System.Drawing.Point(13, 431);
            this.btnNuevoMedico.Margin = new System.Windows.Forms.Padding(13);
            this.btnNuevoMedico.Name = "btnNuevoMedico";
            this.btnNuevoMedico.Size = new System.Drawing.Size(1344, 183);
            this.btnNuevoMedico.TabIndex = 2;
            this.btnNuevoMedico.Text = "Nuevo medico";
            this.btnNuevoMedico.UseVisualStyleBackColor = true;
            this.btnNuevoMedico.Click += new System.EventHandler(this.btnNuevoMedico_Click);
            // 
            // btnListaPacientes
            // 
            this.btnListaPacientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnListaPacientes.Location = new System.Drawing.Point(13, 222);
            this.btnListaPacientes.Margin = new System.Windows.Forms.Padding(13);
            this.btnListaPacientes.Name = "btnListaPacientes";
            this.btnListaPacientes.Size = new System.Drawing.Size(1344, 183);
            this.btnListaPacientes.TabIndex = 1;
            this.btnListaPacientes.Text = "Lista de pacientes";
            this.btnListaPacientes.UseVisualStyleBackColor = true;
            this.btnListaPacientes.Click += new System.EventHandler(this.btnListaPacientes_Click);
            // 
            // btnListaMEdicos
            // 
            this.btnListaMEdicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnListaMEdicos.Location = new System.Drawing.Point(13, 13);
            this.btnListaMEdicos.Margin = new System.Windows.Forms.Padding(13);
            this.btnListaMEdicos.Name = "btnListaMEdicos";
            this.btnListaMEdicos.Padding = new System.Windows.Forms.Padding(10);
            this.btnListaMEdicos.Size = new System.Drawing.Size(1344, 183);
            this.btnListaMEdicos.TabIndex = 0;
            this.btnListaMEdicos.Text = "Lista de medicos";
            this.btnListaMEdicos.UseVisualStyleBackColor = true;
            this.btnListaMEdicos.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 892);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.Controls.SetChildIndex(this.panelHeader, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnNuevoPaciente;
        private System.Windows.Forms.Button btnNuevoMedico;
        private System.Windows.Forms.Button btnListaPacientes;
        private System.Windows.Forms.Button btnListaMEdicos;
    }
}