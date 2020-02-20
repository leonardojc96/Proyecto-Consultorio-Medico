using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Consultorio_Medico.Vistas.Plantillas
{
    public partial class PlantillaInfo : Plantilla
    {
        public PlantillaInfo()
        {
            InitializeComponent();
            //hacer metodo cargar foto al abrir
        }

        public PlantillaInfo(string titulo) : base(titulo)
        {
            InitializeComponent();
        }

        private void PlantillaInfo_Load(object sender, EventArgs e)
        {

        }

        public void CargarFoto(string foto)
        {
            try
            {
                Bitmap picture = new Bitmap(foto);
                picBoxFoto.Image = (Image)picture;
            }
            catch (Exception)
            {

            }
            
        }
    }
}
