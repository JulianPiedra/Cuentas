using BussinessLogic;
using DataAccess.Models;
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
    public partial class FrmVerPagos : Form
    {
        List<Cuentum> _cuentum;
        public FrmVerPagos(List<Cuentum> cuentum)
        {
            InitializeComponent();
            _cuentum = cuentum;
        }

        private void FrmVerPagos_Load(object sender, EventArgs e)
        {

            lblCanceladas.Text = "Cuotas canceladas: " + _cuentum[0].Canceladas.ToString();
            lblCuotas.Text = "Numero total de cuotas: " + _cuentum[0].Cuotas.ToString();
            lblMonto.Text = "Monto total: " + _cuentum[0].Monto.ToString("C2");
            lblSiguientePago.Text = "Siguiente pago: " + _cuentum[0].SiguientePago.ToString("dd/MM/yyyy");
            lblCliente.Text = "Nombre: " + _cuentum[0].IdClienteNavigation.Nombre;


            foreach (var pago in _cuentum[0].PagoCuenta)
            {
                tlpCuotas.RowCount++;
                tlpCuotas.Controls.Add(new Label
                {
                    Text = pago.FechaPago.ToString("dd/MM/yyyy"),
                }, 1, tlpCuotas.RowCount);

                tlpCuotas.Controls.Add(new CheckBox
                {
                    Checked = pago.Cancelado,
                    Enabled = pago.Cancelado ? false : true,
                }, 0, tlpCuotas.RowCount);
            }

        }
    }
}
