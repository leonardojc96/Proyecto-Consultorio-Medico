using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Consultorio_Medico.Negocios
{
    public class Inicioadores
    {  
        public static void  MenuStrip (MenuStrip menu)
        {
            menu.Dock = DockStyle.Left;
            menu.BackColor = Color.FromArgb(69, 144, 180);
            menu.Padding = new Padding(0, 0, 0, 0);
            
            foreach (ToolStripMenuItem item in menu.Items)
            {
                item.BackColor = Color.FromArgb(28, 162, 162);
                item.AutoSize = false;
                item.Width = Application.OpenForms["frmPrincipal"].Width;
                item.Height = Application.OpenForms["frmPrincipal"].Width / 10;
                item.Margin = new Padding(0, 20, 10, 0);
                item.Font = new Font("calibri", 24, FontStyle.Bold);
                item.ForeColor = Color.White;
            }
        }

        public static void ComboBox <T>(ComboBox comboBox, ICollection<T> datos)
        {
            comboBox.DataSource = datos;
            comboBox.DisplayMember = "Nombre";
            comboBox.ValueMember = "Id";
        }

        public static void ComboBox(ComboBox comboBox, ICollection<object> datos, string Display, string Value)
        {
            comboBox.DataSource = datos;
            comboBox.DisplayMember = Display;
            comboBox.ValueMember = Value;
        }

        public static void DataGrid (DataGridView dataGrid)
        {
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToResizeRows = false;
            dataGrid.AllowUserToResizeColumns = false;
            dataGrid.RowHeadersVisible = false;
            dataGrid.ReadOnly = true;
            foreach (DataGridViewColumn item in dataGrid.Columns)
            {
                item.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                
            }
        }

        public static void TextoBlanco(Panel panel)
        {
            panel.ForeColor = Color.White;
            panel.Font = new Font("calibri", 13);

        }

        public static void FormInicio(Form form)
        {
            form.IsMdiContainer = true;
            form.WindowState = FormWindowState.Maximized;
            form.Font = new Font("calibri", 10);
        }

        public static void Plantillas(Form form)
        {
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            form.BackColor = Color.FromArgb(29, 94, 150);
            form.ForeColor = Color.Black;
        }

        public static void Titulo(Label label)
        {
            label.Font = new Font("Calibri", 20, FontStyle.Bold);
            label.Font = new Font(label.Font, FontStyle.Underline);  
        }

        public static void Labels(Label label)
        {
            label.Font = new Font("Calibri", 12, FontStyle.Bold);
            label.ForeColor = Color.White;
        }

        public static void Header(Panel panel)
        {
            panel.BackColor = Color.FromArgb(151, 32, 61);
            panel.ForeColor = Color.White;
        }
    }
}
