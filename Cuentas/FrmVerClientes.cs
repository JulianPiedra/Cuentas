using BussinessLogic;
using DataAccess.Models;
using Models;
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

        private void CargarTodosLosClientes()
        {
            List< ClienteDAO > clientes = ClientesLogic.ListaClientes
                .Select(c => new ClienteDAO
                {
                    IdCliente = c.IdCliente,
                    Nombre = c.Nombre,
                    Telefono = c.Telefono,
                    Correo = c.Correo,
                })
                .ToList();

            RecargarDatos(clientes);
        } 



        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            var searchText = txtBuscar.Text.ToLower();

            List<ClienteDAO> clientes = ClientesLogic.ListaClientes
                .Where(c => c.Nombre.ToLower().Contains(searchText) || c.Telefono.ToString().Contains(searchText) || c.IdCliente.ToLower().Contains(searchText))
                .Select(c => new ClienteDAO
                {
                    IdCliente = c.IdCliente,
                    Nombre = c.Nombre,
                    Telefono = c.Telefono,
                    Correo = c.Correo,
                })
                .ToList();

            RecargarDatos(clientes);
        }

        private async void DgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            var cliente = DgvClientes.Rows[e.RowIndex].Cells["IdCliente"].Value?.ToString();

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
