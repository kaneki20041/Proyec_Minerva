﻿using CapaDatos;
using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class ReportePrendas : Form
    {
        // Mantener una lista original de prendas
        private List<entPrendas> listaOriginalPrendas;

        public string idprenda { get; private set; }
        public string descripcion { get; private set; }
        public string categoria { get; private set; }
        public string talla { get; private set; }
        public string colegio { get; private set; }
        public string precioCompra { get; private set; }
        public string precioVenta { get; private set; }
        public string stock { get; private set; }

        public ReportePrendas()
        {
            InitializeComponent();
            listarReportePrendas();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void listarReportePrendas()
        {
            try
            {
                // Cargar la lista original de prendas
                listaOriginalPrendas = logPrendas.Instancia.ListarPrendas();

                // Asignar la lista al DataGridView sin filtrar
                dgvPrendas.DataSource = listaOriginalPrendas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Método para aplicar el filtro a las prendas basado en el comboBox y el textBox
        private void AplicarFiltroPrendas()
        {
            // Asegúrate de que haya un valor seleccionado en el ComboBox
            if (cbBusqueda.SelectedItem == null) return;

            // Obtener el filtro seleccionado y el texto de búsqueda
            string filtro = cbBusqueda.SelectedItem.ToString();
            string busqueda = txtBusqueda.Text.ToLower();

            // Filtrar la lista original de prendas, no la lista actual del DataGridView
            var prendasFiltradas = listaOriginalPrendas.Where(p =>
            {
                switch (filtro)
                {
                    case "Descripcion":
                        return p.Descripcion.ToLower().Contains(busqueda);
                    case "Categoria":
                        return p.Categoria.ToLower().Contains(busqueda);
                    case "Talla":
                        return p.Talla.ToString().Contains(busqueda);
                    case "Colegio":
                        return p.Colegio.ToLower().Contains(busqueda);
                    case "PrecioCompra":
                        return p.PrecioCompra.ToString().Contains(busqueda);
                    case "PrecioVenta":
                        return p.PrecioVenta.ToString().Contains(busqueda);
                    default:
                        return false;
                }
            }).ToList();

            // Actualizar el DataGridView con los resultados filtrados
            dgvPrendas.DataSource = prendasFiltradas;
        }

        // Evento para cuando se cambia el filtro en el ComboBox
        private void cbBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltroPrendas(); // Llamar al método de filtrado
        }

        // Evento cuando se escribe en el TextBox de búsqueda
        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltroPrendas(); // Llamar al método de filtrado
        }

        private void dgvPrendas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvPrendas.Rows[e.RowIndex];

            descripcion = filaActual.Cells[1].Value.ToString();
            categoria = filaActual.Cells[2].Value.ToString();
            talla = filaActual.Cells[3].Value.ToString();
            colegio = filaActual.Cells[4].Value.ToString();
            precioCompra = filaActual.Cells[5].Value.ToString();
            precioVenta = filaActual.Cells[6].Value.ToString();
            stock = filaActual.Cells[7].Value.ToString();

            DialogResult = DialogResult.OK;
            Close();
        }
        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {

        }














    }
}
