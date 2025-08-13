
using BussinessLogic;
using DataAccess.Models;
using Models;
using Timer = System.Windows.Forms.Timer;

namespace Cuentas
{
    public partial class FrmAgregarCuenta : Form
    {
        private Timer inputDelayTimer;
        private List<PagoCuentaDAO> pagosCuentas = new();

        public FrmAgregarCuenta()
        {
            InitializeComponent();
            InicializarTimer();
            RecargarClientes();
        }

        private void InicializarTimer()
        {
            inputDelayTimer = new Timer
            {
                Interval = 500
            };
            inputDelayTimer.Tick += Delay_Tick;
        }



        private void RecargarClientes()
        {
            cmbCuenta.DataSource = null;
            cmbCuenta.DataSource = "ASD";
            cmbCuenta.DisplayMember = "Nombre";
        }

        public Frecuencia FrecuenciaSeleccionada()
        {
            if (RbMensual.Checked) return Frecuencia.Mensual;
            if (RbQuincenal.Checked) return Frecuencia.Quincenal;
            if (RbSemanal.Checked) return Frecuencia.Semanal;
            return Frecuencia.Ninguna;
        }

        private void MostrarControles()
        {
            if (cbIniciado.Checked || !RbSemanal.Checked)
            {
                dtpFecha.Visible = true;
                cmbSemanal.Visible = false;
            }
            else if (!cbIniciado.Checked && RbSemanal.Checked)
            {
                dtpFecha.Visible = false;
                cmbSemanal.Visible = true;
            }
        }



        private DateTime ObtenerFechaSemanaSeleccionada()
        {
            if (cmbSemanal.SelectedItem == null)
                return DateTime.Today;

            var diaSeleccionado = cmbSemanal.SelectedItem.ToString();
            var diaSemana = diaSeleccionado switch
            {
                "Lunes" => DayOfWeek.Monday,
                "Martes" => DayOfWeek.Tuesday,
                "Miercoles" => DayOfWeek.Wednesday,
                "Jueves" => DayOfWeek.Thursday,
                "Viernes" => DayOfWeek.Friday,
                "Sabado" => DayOfWeek.Saturday,
                "Domingo" => DayOfWeek.Sunday,
                _ => DateTime.Today.DayOfWeek
            };

            var hoy = DateTime.Today;
            int diasDiferencia = ((int)diaSemana - (int)hoy.DayOfWeek + 7) % 7;

            return hoy.AddDays(diasDiferencia == 0 ? 0 : diasDiferencia);
        }

        private DateTime[] CalcularFechasCuotas(DateTime inicio, int cantidad, Frecuencia frecuencia)
        {
            var fechas = new DateTime[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                fechas[i] = frecuencia switch
                {
                    Frecuencia.Mensual => inicio.AddMonths(i),
                    Frecuencia.Quincenal => inicio.AddDays(i * 15),
                    Frecuencia.Semanal => inicio.AddDays(i * 7),
                    _ => inicio
                };
            }
            return fechas;
        }


        private void LimpiarCampos()
        {
            foreach (Control control in Controls)
            {
                switch (control)
                {
                    case TextBox txt: txt.Clear(); break;
                    case ComboBox cmb: cmb.SelectedIndex = -1; break;
                    case CheckBox chk: chk.Checked = false; break;
                    case DataGridView dgv: dgv.Rows.Clear(); break;
                }
            }

        }

        private void GenerarCuotas()
        {
            if (txtMontoCuotas.Text == string.Empty || txtCantCuotas.Text == string.Empty)
            {
                return;
            }
            DgvPagos.Rows.Clear();

            int numCuotas = int.Parse(txtCantCuotas.Text);
            var frecuencia = FrecuenciaSeleccionada();
            var inicio = frecuencia == Frecuencia.Semanal
                ? (cbIniciado.Checked ? dtpFecha.Value : ObtenerFechaSemanaSeleccionada())
                : dtpFecha.Value;

            var fechas = CalcularFechasCuotas(inicio, numCuotas, frecuencia);
            var hoy = DateTime.Today;

            pagosCuentas.Clear();



            for (int i = 0; i < numCuotas; i++)
            {
                pagosCuentas.Add(new PagosCuenta
                {
                    FechaPago = DateOnly.FromDateTime(fechas[i]),
                    Cancelado = true && fechas[i] <= hoy,
                    Monto = Math.Round(decimal.Parse(txtMontoCuotas.Text), 2)
                });
            }
            foreach (var pago in pagosCuentas)
            {
                DgvPagos.Rows.Add(
                    $"{pago.FechaPago.ToString("dd/MM/yyyy")} - ₡{txtMontoCuotas.Text}",
                    pago.Cancelado
                );
            }
        }

        private async void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCuenta.SelectedItem is not Cliente cliente)
                {
                    MessageBox.Show("Debe seleccionar un cliente válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var monto = decimal.Parse(txtMontoCuenta.Text);
                var cuotas = int.Parse(txtCantCuotas.Text);

                var cuenta = new CuentaDAO(cliente.IdCliente, monto, cuotas, pagosCuentas);
                cuenta.Validate();

                var resultado = await CuentaLogic.AgregarCuenta(cuenta);
                MessageBox.Show(resultado, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear la cuenta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMontoCuenta.Text) || string.IsNullOrWhiteSpace(txtCantCuotas.Text))
                return;

            if (decimal.TryParse(txtMontoCuenta.Text, out var monto) &&
                int.TryParse(txtCantCuotas.Text, out var cantidad) &&
                monto > 0 && cantidad > 0)
            {
                txtMontoCuotas.Text = (monto / cantidad).ToString("F2");
            }
        }
        private void Control_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFecha.Visible && cbIniciado.Checked && dtpFecha.Value.Date > DateTime.Today)
            {
                MessageBox.Show("La fecha de inicio no puede ser anterior a hoy.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            inputDelayTimer.Stop();
            inputDelayTimer.Start();
        }

        private void txtChanged_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void FrmAgregarCuenta_Load(object sender, EventArgs e)
        {
            RecargarClientes();
        }
        private void Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            inputDelayTimer.Stop();

            var frecuencia = FrecuenciaSeleccionada();
            bool usarDatePicker = frecuencia == Frecuencia.Mensual || frecuencia == Frecuencia.Quincenal;
            MostrarControles();

            inputDelayTimer.Start();
        }

        private void cbIniciado_CheckedChanged(object sender, EventArgs e)
        {
            lblFrecuencia.Text = cbIniciado.Checked ? "Fecha del primer pago:" : "Fecha de pago:";
            MostrarControles();
            GenerarCuotas();
        }
        private void Delay_Tick(object sender, EventArgs e)
        {
            inputDelayTimer.Stop();
            GenerarCuotas();
        }

        private void DgvPagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (DgvPagos.Columns[e.ColumnIndex].Name == "Pagado" && e.RowIndex >= 0)
            {
                pagosCuentas[e.RowIndex].Cancelado = !pagosCuentas[e.RowIndex].Cancelado;
            }

        }
    }
}
