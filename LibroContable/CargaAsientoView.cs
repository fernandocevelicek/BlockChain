using LibroContable.Entidades;
using LibroContable.Persistencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibroContable
{
    public partial class CargaAsientoView : Form
    {
        List<MovimientoCuenta> movimientos { get; set; }

        public CargaAsientoView()
        {
            InitializeComponent();
            Iniciar();
        }

        private void btnAgregarMovimiento_Click(object sender, EventArgs e)
        {
            try
            {
                MovimientoCuenta movimiento = new MovimientoCuenta();
                if (!string.IsNullOrEmpty(txtDebe.Text))
                {
                    movimiento.Debe = Double.Parse(txtDebe.Text);
                }
                else if (!string.IsNullOrEmpty(txtHaber.Text))
                {
                    movimiento.Haber = Double.Parse(txtHaber.Text);
                }
                else
                {
                    throw new Exception("Indique monto Debe o Haber");
                }

                Cuenta selectedCuenta = (Cuenta)listBoxCuenta.SelectedItem;
                if (selectedCuenta == null)
                {
                    throw new Exception("Debe seleccionar una cuenta");
                }
                movimiento.Cuenta = selectedCuenta;

                movimientos.Add(movimiento);
                AgregarFilaDataGridMovimientos(movimiento);

                lblError.Text = "";
                txtDebe.Text = "";
                txtHaber.Text = "";
                listBoxCuenta.ClearSelected();
            }
            catch (FormatException ex)
            {
                lblError.Text = "Formato Invalido.";
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void btnCargarAsiento_Click(object sender, EventArgs e)
        {
            try
            {
                Asiento asiento = new Asiento();

                if (string.IsNullOrEmpty(txtConcepto.Text))
                {
                    throw new Exception("Debe cargar un concepto");
                }

                if (movimientos.Count <= 0)
                {
                    throw new Exception("Debe cargar movimientos");
                }

                asiento.Concepto = txtConcepto.Text;
                asiento.Movimientos = movimientos;

                asiento.Fecha = DateTime.Now;

                AsientoRepository.Guardar(asiento);

                lblError.Text = "";

                this.Close();
            }
            catch (FormatException ex)
            {
                lblError.Text = "Formato Invalido.";
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void Iniciar()
        {
            movimientos = new List<MovimientoCuenta>();
            lblError.Text = "";
            CargarListBoxCuentas();
            CargarDataGridMovimientos();
        }

        private void CargarListBoxCuentas()
        {
            foreach (Cuenta cuenta in CuentaRepository.Consultar())
            {
                listBoxCuenta.Items.Add(cuenta);
            }
        }

        private void CargarDataGridMovimientos()
        {
            foreach (MovimientoCuenta movimiento in movimientos)
            {
                AgregarFilaDataGridMovimientos(movimiento);
            }
        }

        private void AgregarFilaDataGridMovimientos(MovimientoCuenta movimiento)
        {
            int n = dataGridMovimientos.Rows.Add();

            dataGridMovimientos.Rows[n].Cells[0].Value = movimiento.Cuenta.Codigo;
            dataGridMovimientos.Rows[n].Cells[1].Value = movimiento.Cuenta.Denominacion;
            dataGridMovimientos.Rows[n].Cells[2].Value = movimiento.Debe;
            dataGridMovimientos.Rows[n].Cells[3].Value = movimiento.Haber;
        }
    }
}
