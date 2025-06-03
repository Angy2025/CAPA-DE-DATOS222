using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPA_DE_DATOS; 

namespace CAPA_DE_PRESENTACION222
{
    public partial class FormDetalles : Form
    {
        private Eventos evento;
        public FormDetalles(Eventos eventoSeleccionado)
        {
            InitializeComponent();
            evento = eventoSeleccionado;
        }

        private void FormDetalles_Load(object sender, EventArgs e)
        {
            if (evento != null)
            {
                textBoxResumen.Text =
                    $"📌 Evento: {evento.Nombre}\r\n" +
                    $"📍 Lugar: {evento.Lugar}\r\n" +
                   $"📅 Fecha: {Convert.ToDateTime(evento.Fecha).ToShortDateString()}\r\n" +
                    $"🎭 Tipo: {evento.Tipo}";
            }
            else
            {
                textBoxResumen.Text = "No se pudo cargar la información del evento.";
            }
        }

        private void textBoxResumen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

