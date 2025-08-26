using BussinessLogic;
using DataAccess.Models;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using UILogic;

namespace Cuentas
{
    public partial class FrmVerClientes : Form
    {
        private List<ClienteDAO> clientesCache = new();

        public FrmVerClientes()
        {
            InitializeComponent();
        }

        private void DgvClientess_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (DgvClientes.Columns[e.ColumnIndex].Name != "IdCliente" || e.RowIndex < 0)
                return;
            var valorCelda = DgvClientes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();
            if (!clientesCache.Any(p => p.IdCliente == valorCelda && p.Cuentas.Count() > 0))
                e.CellStyle.BackColor = System.Drawing.Color.LightBlue;

        }

        public void RecargarDatos(IEnumerable<ClienteDAO> clientes)
        {
            DgvClientes.Rows.Clear();

            foreach (var item in clientes)
            {
                DgvClientes.Rows.Add(
                    item.IdCliente,
                    item.Nombre,
                    item.Telefono,
                    item.Correo
                );
            }
        }

        private void FrmVerClientes_Load(object sender, EventArgs e)
        {
            CargarTodosLosClientes();
        }

        private async void CargarTodosLosClientes()
        {
            try
            {
                clientesCache = await ApiFetch.FetchAsync<List<ClienteDAO>>("/clientes/obtener", HttpMethod.Get, null);
                RecargarDatos(clientesCache);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar clientes\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            var searchText = txtBuscar.Text.ToLower();
            var filtered = clientesCache
                .Where(c => c.Nombre.ToLower().Contains(searchText)
                         || c.IdCliente.ToLower().Contains(searchText)
                         || c.Correo?.ToLower().Contains(searchText) == true
                         || c.Telefono.ToString().Contains(searchText) == true)
                .ToList();

            RecargarDatos(filtered);
        }


        private async void DgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            var cliente = DgvClientes.Rows[e.RowIndex].Cells["IdCliente"].Value?.ToString();

            if (DgvClientes.Columns[e.ColumnIndex].Name == "VerCliente")
            {
                try {
                    var listaCliente = await ApiFetch.FetchAsync<ClienteDAO>($"/clientes/{cliente}", HttpMethod.Get, null);

                    var frmVerPagos = new FrmVerDetalleCliente(listaCliente)
                    {
                        Owner = this
                    };
                    frmVerPagos.ShowDialog();
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Error al obtener los detalles del cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
