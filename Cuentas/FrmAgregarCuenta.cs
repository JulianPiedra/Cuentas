using Models;
using System;
using System.Windows.Forms;
using System.Threading;
using Timer = System.Windows.Forms.Timer;
using BussinessLogic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic;
using DataAccess.Models;
using System.Globalization;

namespace Cuentas
{
    public partial class FrmAgregarCuenta : Form
    {
        private Timer inputDelayTimer;

        public FrmAgregarCuenta()
        {
            InitializeComponent();

            inputDelayTimer = new Timer();
            inputDelayTimer.Interval = 500;
            inputDelayTimer.Tick += InputDelayTimer_Tick;

            cmbCuenta.DataSource = ClientesLogic.ListaClientes;
            cmbCuenta.DisplayMember = "Nombre";
        }
        private void InputDelayTimer_Tick(object sender, EventArgs e)
        {
            inputDelayTimer.Stop();
            GenerarCuotas();
        }

        public Frecuencia GetSelectedFrecuencia()
        {
            if (RbMensual.Checked) return Frecuencia.Mensual;
            if (RbQuincenal.Checked) return Frecuencia.Quincenal;
            if (RbSemanal.Checked) return Frecuencia.Semanal;
            return Frecuencia.Ninguna;
        }


        // Establece la visibilidad de controles según la frecuencia
        private void SetVisibilityForFrequencyControls(bool showAll, bool useDatePicker)
        {
            lblFrecuencia.Visible = showAll;
            cbIniciado.Visible = showAll;
            txtMontoCuotas.Visible = showAll;
            lblMontoCuotas.Visible = showAll;
            txtCantCuotas.Visible = showAll;
            lblNumCuotas.Visible = showAll;
            if (cbIniciado.Checked)
            {
                dtpFecha.Visible = true;
                cmbSemanal.Visible = false;
            }
            else
            {
                cmbSemanal.Visible = false;
                dtpFecha.Visible = true;
            }

        }

        private void Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            var checkbox = sender as RadioButton;
            inputDelayTimer.Stop();
            var frecuencia = GetSelectedFrecuencia();
            bool useDatePicker = frecuencia == Frecuencia.Mensual || frecuencia == Frecuencia.Quincenal;
            SetVisibilityForFrequencyControls(true, useDatePicker);
            inputDelayTimer.Start();
        }

        // Actualiza la visibilidad solo para frecuencia semanal
        private void UpdateWeeklyControls()
        {
            if (GetSelectedFrecuencia() == Frecuencia.Semanal)
            {
                dtpFecha.Visible = cbIniciado.Checked;
                cmbSemanal.Visible = !cbIniciado.Checked;
            }
        }
        private DateTime[] CalcularFechasCuotas(DateTime fechaInicio, int numCuotas, Frecuencia frecuencia)
        {
            DateTime[] fechas = new DateTime[numCuotas];
            for (int i = 0; i < numCuotas; i++)
            {
                switch (frecuencia)
                {
                    case Frecuencia.Mensual:
                        fechas[i] = fechaInicio.AddMonths(i);
                        break;
                    case Frecuencia.Quincenal:
                        fechas[i] = fechaInicio.AddDays(i * 15);
                        break;
                    case Frecuencia.Semanal:
                        fechas[i] = fechaInicio.AddDays(i * 7);
                        break;
                    default:
                        fechas[i] = fechaInicio;
                        break;
                }
            }
            return fechas;
        }


        private void cbIniciado_CheckedChanged(object sender, EventArgs e)
        {
            lblFrecuencia.Text = cbIniciado.Checked ? "Fecha del primer pago:" : "Fecha de pago:";
            UpdateWeeklyControls();
            GenerarCuotas();
        }

        // Calcula y muestra el monto por cuota
        private void CalcularMontoCuota(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMontoCuenta.Text) || string.IsNullOrWhiteSpace(txtCantCuotas.Text))
            {
                return;
            }
            if (Decimal.Parse(txtMontoCuenta.Text) > 0 && Decimal.Parse(txtCantCuotas.Text) > 0)
            {
                txtMontoCuotas.Text = (Decimal.Parse(txtMontoCuenta.Text) / Decimal.Parse(txtCantCuotas.Text)).ToString();
            }
        }
        private DateTime ObtenerFechaSemanaSeleccionada()
        {
            if (cmbSemanal.SelectedItem == null)
                return DateTime.Today;

            // Suponiendo que cmbSemanal tiene nombres de días: "Lunes", "Martes", etc.
            var diaSeleccionado = cmbSemanal.SelectedItem.ToString();

            // Mapea nombre del día a DayOfWeek
            DayOfWeek diaSemana = diaSeleccionado switch
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

            DateTime hoy = DateTime.Today;
            int diasHastaDia = ((int)diaSemana - (int)hoy.DayOfWeek + 7) % 7;

            if (diasHastaDia == 0) // Si hoy es el día seleccionado, tomamos hoy
                return hoy;

            return hoy.AddDays(diasHastaDia);
        }
        private void LimpiarTlp()
        {
            tlpCuotas.SuspendLayout();
            tlpCuotas.Controls.Clear();
            tlpCuotas.RowStyles.Clear();
            tlpCuotas.ColumnStyles.Clear();
            tlpCuotas.RowCount = 0;
            tlpCuotas.AutoScrollPosition = new Point(0, 0);
            return;
        }

        private void GenerarCuotas()
        {

            // Validar entradas
            if (txtMontoCuotas.Text == string.Empty || decimal.TryParse(txtMontoCuotas.Text, out decimal monto) == false || monto <= 0)
            {
                LimpiarTlp();
                tlpCuotas.ResumeLayout();
                return;
            }


            int numCuotas = (int)Decimal.Parse(txtCantCuotas.Text);
            if (!decimal.TryParse(txtMontoCuotas.Text, out decimal montoCuota)) return;

            Frecuencia frecuencia = GetSelectedFrecuencia();
            DateTime fechaInicio = frecuencia == Frecuencia.Semanal
                ? (cbIniciado.Checked ? dtpFecha.Value : ObtenerFechaSemanaSeleccionada())
                : dtpFecha.Value;

            var fechasCuotas = CalcularFechasCuotas(fechaInicio, numCuotas, frecuencia);
            DateTime fechaActual = DateTime.Today;

            LimpiarTlp();
            tlpCuotas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tlpCuotas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));


            for (int i = 0; i < numCuotas; i++)
            {
                tlpCuotas.RowCount++;
                tlpCuotas.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));

                var label = new Label
                {
                    Text = $"Cuota {i + 1}: {montoCuota:C} - {fechasCuotas[i]:dd/MM/yyyy}",
                    AutoSize = true,
                };
                var checkBox = new CheckBox
                {
                    Text = "Pagada",
                    Checked = cbIniciado.Checked && fechasCuotas[i] <= fechaActual,
                    AutoSize = true,
                };
                tlpCuotas.Height = tlpCuotas.RowCount * 40;
                tlpCuotas.Controls.Add(label, 0, i);
                tlpCuotas.Controls.Add(checkBox, 1, i);

            }
            tlpCuotas.ResumeLayout();
        }

        private void Control_ValueChanged(object sender, EventArgs e)
        {
            inputDelayTimer.Stop();
            inputDelayTimer.Start();
        }

        private async void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCuenta.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var cliente = cmbCuenta.SelectedItem as Cliente;
                if (cliente == null)
                {
                    MessageBox.Show("Cliente no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var monto = decimal.Parse(txtMontoCuenta.Text);
                var cuotas = int.Parse(txtCantCuotas.Text);
                var canceladas = 0; 

                var pagosCuenta = new List<PagosCuenta>();
                for (int i = 0; i < tlpCuotas.RowCount; i++)
                {
                    var checkBox = tlpCuotas.GetControlFromPosition(1, i) as CheckBox;
                    if (checkBox != null)
                    {
                        var texto = tlpCuotas.GetControlFromPosition(0, i).Text;
                        var fechaStr = texto.Split('-')[1].Trim(); 

                        var fechaPago = DateTime.ParseExact(fechaStr, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        pagosCuenta.Add(new PagosCuenta {FechaPago= DateOnly.FromDateTime(fechaPago), Cancelado = checkBox.Checked });
                        if (checkBox.Checked)
                        {
                            canceladas++;
                        }
                    }
                }
                var siguientePago =  pagosCuenta.First(f => f.Cancelado == false).FechaPago;


                var cuenta = new CuentaDAO(cliente.IdCliente, monto, cuotas, canceladas, siguientePago, pagosCuenta);
                cuenta.Validate();

                var  result = await CuentaLogic.AgregarCuenta(cuenta);
                MessageBox.Show(result, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear la cuenta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtChanged_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


    }
}
