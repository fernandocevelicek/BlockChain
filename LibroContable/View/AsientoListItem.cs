using LibroContable.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibroContable.View
{
    public partial class AsientoListItem : UserControl
    {
        public Asiento asiento { get; set; }

        public AsientoListItem()
        {
            InitializeComponent();
        }

        #region
        private string _idAsiento;
        private string _concepto;
        private string _fecha;
        private List<MovimientoCuenta> _movimientos;

        [Category("CustomProps")]
        public string IdAsiento
        {
            get { return _idAsiento; }
            set { _idAsiento = value; dataLabelAsientoID.Text = value; }
        }

        [Category("CustomProps")]
        public string Concepto
        {
            get { return _concepto; }
            set { _concepto = value; dataLabelConcepto.Text = value; }
        }

        [Category("CustomProps")]
        public string Fecha
        {
            get { return _fecha; }
            set { _fecha = value; dataLabelFecha.Text = value; }
        }

        [Category("CustomProps")]
        public List<MovimientoCuenta> Movimientos
        {
            get { return _movimientos; }
            set { _movimientos = value; CargarDataGridMovimientos(value); }
        }
        #endregion

        private void CargarDataGridMovimientos(List<MovimientoCuenta> movimientos)
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

        private void AsientoListItem_Load(object sender, EventArgs e)
        {

        }
    }
}
