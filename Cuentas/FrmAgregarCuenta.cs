
using BussinessLogic;
using DataAccess.Models;
using Models;
using UILogic;
using Timer = System.Windows.Forms.Timer;

namespace Cuentas
{
    public partial class FrmAgregarCuenta : Form
    {
        private Timer inputDelayTimer;
        private List<PagoCuentaDAO> pagosCuentas = new();
        private List<CuentaDAO> _cuentum;
        private bool primeraGeneracion = true;
        private string _idCliente;
        private async void InitializeAsync()
        {
            InicializarTimer();
            await RecargarClientes();
            await RecargarTipoPago();
            await RecargarTipoCuenta();
        }
        public FrmAgregarCuenta()
        {
            InitializeComponent();
            InitializeAsync(); 
        }
        public FrmAgregarCuenta(string idCliente)
        {
            InitializeComponent();
            _idCliente = idCliente;
            InitializeAsync();
        }
        public FrmAgregarCuenta(List<CuentaDAO> cuentum)
        {
            InitializeComponent();
            InitializeAsync();
            _cuentum = cuentum;
            if (_cuentum != null && _cuentum.Count > 0)
            {
                cbIniciado.Checked = true;
                pnlRadios.Enabled = false;
                dtpFecha.Enabled = false;


                txtMontoCuenta.Text = _cuentum[0].Monto.ToString("F2");
                txtCantCuotas.Text = _cuentum[0].Cuotas.ToString();
                pagosCuentas = _cuentum[0].PagosCuenta;

                // Detectar la frecuencia y marcar RadioButton
                var frecuencia = DetectarFrecuencia(pagosCuentas);
                switch (frecuencia)
                {
                    case Frecuencia.Mensual: RbMensual.Checked = true; break;
                    case Frecuencia.Quincenal: RbQuincenal.Checked = true; break;
                    case Frecuencia.Semanal: RbSemanal.Checked = true; break;
                }
            }

        }
        private Frecuencia DetectarFrecuencia(List<PagoCuentaDAO> pagos)
        {
            if (pagos == null || pagos.Count < 2)
                return Frecuencia.Ninguna;

            var diferencias = pagos
                .OrderBy(p => p.FechaPago)
                .Zip(pagos.OrderBy(p => p.FechaPago).Skip(1), (a, b) => b.FechaPago.DayNumber - a.FechaPago.DayNumber)
                .ToList();

            int promedio = (int)diferencias.Average();

            return promedio switch
            {
                >= 28 and <= 31 => Frecuencia.Mensual,
                >= 14 and <= 16 => Frecuencia.Quincenal,
                >= 7 and <= 8 => Frecuencia.Semanal,
                _ => Frecuencia.Ninguna
            };
        }


        private void InicializarTimer()
        {
            inputDelayTimer = new Timer
            {
                Interval = 500
            };
            inputDelayTimer.Tick += Delay_Tick;
        }



        private async Task RecargarClientes()
        {
            cmbCuenta.DataSource = null;
            cmbCuenta.DataSource = await ApiFetch.FetchAsync<List<ClienteDAO>>($"/clientes/obtener", HttpMethod.Get, null); ;
            cmbCuenta.DisplayMember = "Nombre";
            cmbCuenta.ValueMember = "IdCliente";
            if (_cuentum != null || _idCliente != null)
            {
                cmbCuenta.SelectedValue = _idCliente ?? _cuentum[0].IdCliente;
            }

        }
        private async Task RecargarTipoPago()
        {
            cmbTipoPago.DataSource = null;
            cmbTipoPago.DataSource = await ApiFetch.FetchAsync<List<TipoPagoDAO>>($"/cuentas/tipoPago/obtener", HttpMethod.Get, null); ;
            cmbTipoPago.DisplayMember = "Nombre";
            cmbTipoPago.ValueMember = "IdTipoPago";
            if (_cuentum != null)
            {
                cmbTipoPago.SelectedValue = _cuentum[0].TipoPago?.IdTipoPago ?? 1;
            }

        }
        private async Task RecargarTipoCuenta()
        {
            cmbTipoCuenta.DataSource = null;
            cmbTipoCuenta.DataSource = await ApiFetch.FetchAsync<List<TipoCuentaDAO>>($"/cuentas/tipoCuenta/obtener", HttpMethod.Get, null); ;
            cmbTipoCuenta.DisplayMember = "Nombre";
            cmbTipoCuenta.ValueMember = "IdTipoCuenta";
            if (_cuentum != null)
            {
                cmbTipoCuenta.SelectedValue = _cuentum[0].TipoCuenta?.IdTipoCuenta ?? 1;
            }

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
            foreach (Control control in pnlControles.Controls)
            {
                switch (control)
                {
                    case TextBox txt: txt.Clear(); break;
                    case CheckBox chk: chk.Checked = false; break;
                }
            }
            DgvPagos.Rows.Clear();

        }

        private void GenerarCuotas()
        {
            if (txtMontoCuotas.Text == string.Empty || txtCantCuotas.Text == string.Empty)
                return;

            DgvPagos.Visible = true;
            int numCuotas = int.Parse(txtCantCuotas.Text);
            var frecuencia = FrecuenciaSeleccionada();
            var inicio = frecuencia == Frecuencia.Semanal
                ? (cbIniciado.Checked ? dtpFecha.Value : ObtenerFechaSemanaSeleccionada())
                : dtpFecha.Value;

            // Si ya existe _cuentum con pagos, los usamos
            if (_cuentum != null && _cuentum.Count > 0 && pagosCuentas.Count > 0)
            {

                var hoy = DateTime.Today;
                decimal montoTotal = decimal.Parse(txtMontoCuenta.Text);
                int totalCuotas = int.Parse(txtCantCuotas.Text);
                decimal montoCuota = decimal.Parse(txtMontoCuotas.Text);
                // Recalculamos solo las cuotas no canceladas, manteniendo las canceladas intactas
                var nuevasFechas = CalcularFechasCuotas(inicio, totalCuotas, frecuencia);

                DgvPagos.Rows.Clear();

                primeraGeneracion = false;
                for (int i = 0; i < totalCuotas; i++)
                {
                    PagoCuentaDAO pagoExistente = i < pagosCuentas.Count ? pagosCuentas[i] : null;

                    if (pagoExistente != null && pagoExistente.Cancelado)
                    {
                        // Mantenemos pagos cancelados intactos
                        DgvPagos.Rows.Add($"{pagoExistente.FechaPago:dd/MM/yyyy} - ₡{pagoExistente.Monto:F2}", true);
                        DgvPagos.Rows[DgvPagos.Rows.Count - 1].ReadOnly = true;
                    }
                    else
                    {
                        // Si no existe pago o no está cancelado, creamos uno nuevo con monto actualizado
                        var fechaPago = pagoExistente != null ? pagoExistente.FechaPago : DateOnly.FromDateTime(nuevasFechas[i]);
                        var cancelado = pagoExistente != null ? pagoExistente.Cancelado : false;

                        if (i < pagosCuentas.Count)
                        {
                            pagosCuentas[i].Monto = montoCuota;
                            pagosCuentas[i].FechaPago = fechaPago;
                            pagosCuentas[i].Cancelado = cancelado;
                        }
                        else
                        {
                            pagosCuentas.Add(new PagoCuentaDAO
                            {
                                FechaPago = fechaPago,
                                Monto = montoCuota,
                                Cancelado = cancelado
                            });
                        }

                        DgvPagos.Rows.Add($"{fechaPago:dd/MM/yyyy} - ₡{montoCuota:F2}", cancelado);
                    }
                }

                return;
            }
            DgvPagos.Rows.Clear();
            // Caso normal sin pagos previos
            var fechas = CalcularFechasCuotas(inicio, numCuotas, frecuencia);
            var hoyNormal = DateTime.Today;

            pagosCuentas.Clear();

            for (int i = 0; i < numCuotas; i++)
            {
                pagosCuentas.Add(new PagoCuentaDAO
                {
                    FechaPago = DateOnly.FromDateTime(fechas[i]),
                    Cancelado = fechas[i] <= hoyNormal,
                    Monto = Math.Round(decimal.Parse(txtMontoCuotas.Text), 2)
                });
            }

            foreach (var pago in pagosCuentas)
            {
                DgvPagos.Rows.Add($"{pago.FechaPago:dd/MM/yyyy} - ₡{pago.Monto:F2}", pago.Cancelado);
            }
        }

        private async void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCuenta.SelectedItem is not ClienteDAO cliente)
                {
                    MessageBox.Show("Debe seleccionar un cliente válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validar monto
                if (!decimal.TryParse(txtMontoCuenta.Text, out var monto))
                {
                    MessageBox.Show("Debe ingresar un monto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validar cuotas
                if (!int.TryParse(txtCantCuotas.Text, out var cuotas))
                {
                    MessageBox.Show("Debe ingresar la cantidad de cuotas en números válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var cuenta = new CuentaDAO
                {
                    IdCliente = cliente.IdCliente ?? "",
                    Monto = monto,
                    Cuotas = cuotas ,
                    Canceladas = pagosCuentas.Where(p => p.Cancelado == true).Count(),
                    PagosCuenta = pagosCuentas,
                    TipoCuenta = cmbTipoCuenta.SelectedItem as TipoCuentaDAO,
                    TipoPago = cmbTipoPago.SelectedItem as TipoPagoDAO,
                };
                cuenta.Validate();
                if (_cuentum != null)
                {
                    cuenta.Cuenta = _cuentum[0].Cuenta;
                    var result = await ApiFetch.FetchAsync<string>($"/cuentas/editar", HttpMethod.Put, cuenta);
                    MessageBox.Show(result, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    return;
                }
                var resultado = await ApiFetch.FetchAsync<string>($"/cuentas/agregar", HttpMethod.Post, cuenta);
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
                if (_cuentum != null)
                {
                    decimal MontoCancelado = _cuentum[0].PagosCuenta.Where(p => p.Cancelado).Sum(p => p.Monto);
                    int canceladas = _cuentum[0].PagosCuenta.Where(p => p.Cancelado).Count();
                    txtMontoCuotas.Text = ((monto - MontoCancelado) / (cantidad - canceladas)).ToString("F2");
                    return;

                }
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

        private void FrmAgregarCuenta_Load(object sender, EventArgs e)
        {
            RecargarClientes();
            if (_cuentum != null)
            {
                btnCrearCuenta.Text = "Actualizar Cuenta";
                var primeraFecha = _cuentum[0].PagosCuenta.Min(p => p.FechaPago);
                dtpFecha.Value = primeraFecha.ToDateTime(TimeOnly.MinValue);
            }

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
            lblFecha.Text = cbIniciado.Checked ? "Fecha del primer pago:" : "Fecha de pago:";
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
