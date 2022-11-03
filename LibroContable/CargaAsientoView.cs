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
            MovimientoCuenta movimiento = new MovimientoCuenta();
            if (!string.IsNullOrEmpty(txtDebe.Text))
            {
                movimiento.Debe = Double.Parse(txtDebe.Text);
            } else if (!string.IsNullOrEmpty(txtHaber.Text))
            {
                movimiento.Haber = Double.Parse(txtHaber.Text);
            } else
            {
                //TODO: lanzar exception
            }

            Cuenta selectedCuenta = (Cuenta)listBoxCuenta.SelectedItem;
            if (selectedCuenta == null)
            {
                //TODO: lanzar exception
                Console.WriteLine(selectedCuenta);
                return;
            }
            movimiento.Cuenta = selectedCuenta;

            movimientos.Add(movimiento);
            AgregarFilaDataGridMovimientos(movimiento);

            txtDebe.Text = "";
            txtHaber.Text = "";
            listBoxCuenta.ClearSelected();
        }

        private void btnCargarAsiento_Click(object sender, EventArgs e)
        {
            Asiento asiento = new Asiento();

            if(string.IsNullOrEmpty(txtConcepto.Text))
            {
                //TODO: lanzar exception
                return;
            }

            if (movimientos.Count <= 0)
            {
                //TODO: lanzar exception
                return;
            }

            asiento.Concepto = txtConcepto.Text;
            asiento.Movimientos = movimientos;

            asiento.Fecha = DateTime.Now;
            
            AsientoRepository.Guardar(asiento);

            this.Close();
        }

        private void Iniciar()
        {
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
            if (movimientos == null)
            {
                movimientos = new List<MovimientoCuenta>();
            }

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
