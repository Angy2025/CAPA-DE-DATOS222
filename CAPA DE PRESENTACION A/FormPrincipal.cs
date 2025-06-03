using System;
using System.Windows.Forms;
using System.Collections.Generic;
using CapaNegocios;
using CAPA_DE_DATOS;

namespace CAPA_DE_PRESENTACION_A
{
    public partial class FormPrincipal : Form
    {
        private List<Eventos> eventosMostrados = new List<Eventos>();
        private EventosNegocios eventosNegocios = new EventosNegocios();
        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            // Este método se ejecuta cuando se carga el formulario.
            // Puedes dejarlo vacío si no necesitas lógica de carga.
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void CargarTodosLosEventos()
        {
            eventosMostrados = EventosNegocios.ObtenerListaEventosPorTipo();
            dgvDatos.DataSource = eventosMostrados;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string textoBusqueda = txtBuscar.Text.ToLower();

            var filtrados = eventosMostrados.FindAll(e =>
                e.Nombre.ToLower().Contains(textoBusqueda) ||
                e.Lugar.ToLower().Contains(textoBusqueda));

            dgvDatos.DataSource = filtrados;
        }
        private void btnBuscarCultural_Click(object sender, EventArgs e)
        {
            eventosMostrados = eventosNegocios.ObtenerListaEventosPorTipo("Cultural");
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = eventosMostrados;
        }

        private void btnDeportivos_Click(object sender, EventArgs e)
        {
            eventosMostrados = eventosNegocios.ObtenerListaEventosPorTipo("Deportivo");
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = eventosMostrados;
        }

        private void btnVerDetalles_Click(object sender, EventArgs e)
        {
            if (dgvDatos.CurrentRow != null)
            {
                Eventos eventoSeleccionado = dgvDatos.CurrentRow.DataBoundItem as Eventos;

                if (eventoSeleccionado != null)
                {
                    FormDetalles formDetalles = new FormDetalles(eventoSeleccionado);
                    formDetalles.ShowDialog();
                }
            }
        }
    }
}

