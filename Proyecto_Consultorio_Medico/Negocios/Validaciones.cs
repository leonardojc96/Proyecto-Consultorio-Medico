using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Consultorio_Medico.Negocios
{
    public static class Validaciones
    {
        public static bool FormularioNoAbierto(string formName)
        {
            bool noAbierto = true;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == formName)
                {
                    form.Show();
                    form.BringToFront();
                    noAbierto = false;
                }
            }

            return noAbierto;
        }

        public static void CambiarEnable(Form form)
        {
            foreach (Control item in form.Controls)
            {
                item.Enabled = true;
            }
        }

        public static bool NoEsNullNiVacio(Panel panel)
        {
            foreach (Control item in panel.Controls)
            {
                if (string.IsNullOrEmpty(item.Text) || item is null && item is TextBox)
                {
                    MessageBox.Show("Completa todos los campos");
                    return false;
                }
            }

            return true;
        }

        public static void Limpiar(Panel panel)
        {
            foreach (var item in panel.Controls)
            {
                if(item is TextBox)
                {
                    
                    TextBox text = (TextBox)item;
                    text.Clear();
                }
            }
        }

        public static void ValidaNombre(KeyPressEventArgs e)
        {
            Regex rex = new Regex("^[a-zA-Z ]+$");

            if (rex.IsMatch(e.KeyChar.ToString()) || char.IsControl(e.KeyChar)) 
                e.Handled = false;
            else e.Handled = true;
        }

        public static void ValidaEntero(KeyPressEventArgs e)
        {

            Regex rex = new Regex("^[0-9]+$");

            if (rex.IsMatch(e.KeyChar.ToString()) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public static void ValidaPrecio(KeyPressEventArgs e, string text)
        {

            Regex rex = new Regex("^[0-9,]+$");

            if (rex.IsMatch(e.KeyChar.ToString()) || char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == ',' && (text.Contains(',') ||  string.IsNullOrEmpty(text)))
                {
                    e.Handled = true;
                }
                else
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
