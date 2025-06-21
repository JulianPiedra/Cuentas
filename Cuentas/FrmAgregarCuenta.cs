
using BussinessLogic;
using DataAccess.Models;
using Models;
using Timer = System.Windows.Forms.Timer;

namespace Cuentas
{
    public partial class FrmAgregarCuenta : Form
    {
        private Timer inputDelayTimer;
        private List<PagosCuenta> pagosCuentas = new();

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
            cmbCuenta.DataSource = ClientesLogic.ListaClientes;
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
                "Miércoles" => DayOfWeek.Wednesday,
                "Jueves" => DayOfWeek.Thursday,
                "Viernes" => DayOfWeek.Friday,
                "Sábado" => DayOfWeek.Saturday,
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

        private void LimpiarTlp()
        {
            tlpCuotas.SuspendLayout();
            tlpCuotas.Controls.Clear();
            tlpCuotas.RowStyles.Clear();
            tlpCuotas.ColumnStyles.Clear();
            tlpCuotas.RowCount = 0;
            tlpCuotas.AutoScrollPosition = new Point(0, 0);
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
                }
            }

            LimpiarTlp();
            tlpCuotas.ResumeLayout();
        }

        private void GenerarCuotas()
        {
            if (!decimal.TryParse(txtMontoCuotas.Text, out var monto) || monto <= 0)
            {
                LimpiarTlp();
                tlpCuotas.ResumeLayout();
                return;
            }

            int numCuotas = int.Parse(txtCantCuotas.Text);
            var frecuencia = FrecuenciaSeleccionada();
            var inicio = frecuencia == Frecuencia.Semanal
                ? (cbIniciado.Checked ? dtpFecha.Value : ObtenerFechaSemanaSeleccionada())
                : dtpFecha.Value;

            var fechas = CalcularFechasCuotas(inicio, numCuotas, frecuencia);
            var hoy = DateTime.Today;

            LimpiarTlp();
            pagosCuentas.Clear();

            tlpCuotas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tlpCuotas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));

            for (int i = 0; i < numCuotas; i++)
            {
                tlpCuotas.RowCount++;
                tlpCuotas.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));

                var label = new Label
                {
                    Text = $"Cuota {i + 1}: {monto:C} - {fechas[i]:dd/MM/yyyy}",
                    AutoSize = true,
                };

                var checkBox = new CheckBox
                {
                    Text = "Pagada",
                    Checked = cbIniciado.Checked && fechas[i] <= hoy,
                    AutoSize = true
                };

                tlpCuotas.Controls.Add(label, 0, i);
                tlpCuotas.Controls.Add(checkBox, 1, i);

                pagosCuentas.Add(new PagosCuenta
                {
                    FechaPago = DateOnly.FromDateTime(fechas[i]),
                    Cancelado = checkBox.Checked
                });
            }

            tlpCuotas.ResumeLayout();
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
                var canceladas = pagosCuentas.Count(p => p.Cancelado);
                var siguientePago = pagosCuentas.First(p => !p.Cancelado).FechaPago;

                var cuenta = new CuentaDAO(cliente.IdCliente, monto, cuotas, canceladas, siguientePago, pagosCuentas);
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
            inputDelayTimer.Stop();
            inputDelayTimer.Start();
        }

        private void txtChanged_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void FrmAgregarCuenta_Activated(object sender, EventArgs e)
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
    }
}
