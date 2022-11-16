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
    public partial class BlockChainItem : UserControl
    {
        public BlockChainItem()
        {
            InitializeComponent();
        }

        #region
        private string _idLibro;
        private List<Asiento> _asientos;
        private string _fecha;

        [Category("CustomProps")]
        public string IdLibro
        {
            get { return _idLibro; }
            set { _idLibro = value; dataLabelIndice.Text = value; }
        }

        [Category("CustomProps")]
        public string FechaLibro
        {
            get { return _fecha; }
            set { _fecha = value; dataLabelFecha.Text = value; }
        }

        [Category("CustomProps")]
        public List<Asiento> Asientos
        {
            get { return _asientos; }
            set { _asientos = value; CargarDataGridAsientos(value); }
        }
        #endregion

        private void CargarDataGridAsientos(List<Asiento> asientos)
        {
            if (asientos == null)
            {
                asientos = new List<Asiento>();
            }

            foreach (Asiento asiento in asientos)
            {
                AgregarFilaDataGridAsientos(asiento);
            }
        }

        private void AgregarFilaDataGridAsientos(Asiento asiento)
        {
            int n = dataGridViewAsiento.Rows.Add();

            dataGridViewAsiento.Rows[n].Cells[0].Value = asiento.Fecha;
            dataGridViewAsiento.Rows[n].Cells[1].Value = asiento.Concepto;
        }


    }
}
