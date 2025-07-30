using BussinessLogic;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Cuentas
{
    public partial class FrmVerClientes : Form
    {
        public FrmVerClientes()
        {
            InitializeComponent();
        }

        public void RecargarDatos(IEnumerable<object> clientes)
        {
            var source = new BindingSource
            {
                DataSource = clientes
            };
            DgvClientes.DataSource = source;

            if (!DgvClientes.Columns.Contains("VerCliente"))
            {
                DgvClientes.Columns.Add(new DataGridViewButtonColumn
                {
                    Name = "VerCliente",
                    Text = "Detalles del cliente",
                    UseColumnTextForButtonValue = true,
                    HeaderText = "Ver cliente"
                });
            }
        }

        private void FrmVerClientes_Load(object sender, EventArgs e)
        {
            CargarTodosLosClientes();
        }

        private void CargarTodosLosClientes()
        {
            var clientes = ClientesLogic.ListaClientes
                .Select(c => new
                {
                    Cedula = c.IdCliente,
                    c.Nombre,
                    c.Telefono,
                    c.Correo,
                })
                .ToList();

            RecargarDatos(clientes);
        } 



        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            var searchText = txtBuscar.Text;

            var filteredClientes = ClientesLogic.ListaClientes
                .Where(c => c.Nombre.Contains(searchText) || c.Telefono.ToString().Contains(searchText) || c.IdCliente.Contains(searchText))
                .Select(c => new
                {
                    Cedula = c.IdCliente,
                    c.Nombre,
                    c.Telefono,
                    c.Correo,
                })
                .ToList();

            RecargarDatos(filteredClientes);
        }

        private async void DgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            var cliente = DgvClientes.Rows[e.RowIndex].Cells["Cedula"].Value?.ToString();

            if (DgvClientes.Columns[e.ColumnIndex].Name == "VerCliente")
            {
                try { 
                    var listaCliente = await ClientesLogic.ObtenerClienteConMultimedia(cliente);

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
