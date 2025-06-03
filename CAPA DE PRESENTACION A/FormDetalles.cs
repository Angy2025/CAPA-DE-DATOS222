using System;
using System.Windows.Forms;
using CapaNegocios; // Necesario para usar la clase Eventos

namespace CAPA_DE_PRESENTACION_A
{
    public partial class FormDetalles : Form
    {
        private readonly Eventos evento;

        public FormDetalles(Eventos eventoRecibido)
        {
            InitializeComponent();
            evento = eventoRecibido;
        }

        private void FormDetalles_Load(object sender, EventArgs e)
        {
            if (evento != null)
            {
                txtNombre.Text = evento.Nombre;
                txtFecha.Text = evento.Fecha;
                txtLugar.Text = evento.Lugar;
            }
        }
    }
}

