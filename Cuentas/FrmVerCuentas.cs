using BussinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuentas
{
    public partial class FrmVerCuentas : Form
    {
        public FrmVerCuentas()
        {
            InitializeComponent();
        }

        private void FrmVerCuentas_Load(object sender, EventArgs e)
        {
            var cuentas = CuentaLogic.ListaCuentas
             .Select(c => new
             {
                 Cuenta = c.IdCuenta,
                 Cliente = c.IdClienteNavigation.Nombre,
                 c.Monto,
                 c.Cuotas,
                 c.Canceladas,
                 c.SiguientePago
             })
             .ToList();

            var source = new BindingSource
            {
                DataSource = cuentas
            };

            DgvCuentas.DataSource = source;
            DgvCuentas.Columns["SiguientePago"].HeaderText = "Siguiente Pago";
            DgvCuentas.Columns["Cuenta"].Visible = false;
            DgvCuentas.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "VerPagos",
                Text = "Ver Pagos",
                UseColumnTextForButtonValue = true,
                HeaderText = "Pagos"
            });
            DgvCuentas.CellClick += DgvCuentas_CellContentClick;
        }
        private async void DgvCuentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex <0) return; 
            if (DgvCuentas.Columns[e.ColumnIndex].Name == "VerPagos" && e.RowIndex >= 0)
            {
                var listaPagos = await CuentaLogic.ObtenerCuentasConPagos(int.Parse(DgvCuentas.Rows[e.RowIndex].Cells["Cuenta"].Value.ToString()));

                var frmVerPagos = new FrmVerPagos(listaPagos);
                frmVerPagos.ShowDialog();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            var searchText = txtBuscar.Text.ToLower();
            var filteredCuentas = CuentaLogic.ListaCuentas
                .Where(c => c.IdClienteNavigation.Nombre.ToLower().Contains(searchText))
                .Select(c => new
                {
                    Cuenta = c.IdCuenta,
                    Cliente = c.IdClienteNavigation.Nombre,
                    c.Monto,
                    c.Cuotas,
                    c.Canceladas,
                    c.SiguientePago
                })
                .ToList();

            var source = new BindingSource
            {
                DataSource = filteredCuentas
            };

            DgvCuentas.DataSource = source;

        }
    }
}
