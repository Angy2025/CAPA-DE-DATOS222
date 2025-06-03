using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CapaNegocios;
using CAPA_DE_DATOS;

namespace CAPA_DE_PRESENTACION222
{
    public partial class FormPrincipal : Form
    {
        EventosNegocios negocios = new EventosNegocios();
        List<Eventos> listaEventos = new List<Eventos>();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            comboBoxTipo.Items.Add("Cultural");
            comboBoxTipo.Items.Add("Deportivo");
            comboBoxTipo.SelectedIndex = 0; // Opcional: selección por defecto

            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // No necesario, lo puedes eliminar si no usas el label
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // No necesario, lo puedes eliminar si no usas el label
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string tipo = comboBoxTipo.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(tipo))
            {
                MessageBox.Show("Seleccione un tipo de evento válido.");
                return;
            }

            listaEventos = negocios.ObtenerListaEventosPorTipo(tipo);

            if (listaEventos.Count == 0)
            {
                MessageBox.Show("No hay eventos de ese tipo.");
                dgvDatos.DataSource = null;
                return;
            }

            dgvDatos.DataSource = listaEventos.Select(ev => new { ev.Id, ev.Nombre }).ToList();
        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un evento de la lista.");
                return;
            }

            int idSeleccionado = Convert.ToInt32(dgvDatos.SelectedRows[0].Cells["Id"].Value);
            Eventos eventoSeleccionado = listaEventos.FirstOrDefault(ev => ev.Id == idSeleccionado);

            if (eventoSeleccionado != null)
            {
                FormDetalles resumenForm = new FormDetalles(eventoSeleccionado);
                resumenForm.ShowDialog();
            }
        }
    }
}
