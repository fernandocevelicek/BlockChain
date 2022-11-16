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
    public partial class CargaCuentaView : Form
    {
        public CargaCuentaView()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargarCuenta_Click(object sender, EventArgs e)
        {
            PersistirCuenta();
        }

        private void PersistirCuenta()
        {
            try
            {
                if (string.IsNullOrEmpty(txtCodigoCuenta.Text)) throw new Exception("Debe cargar un codigo");
                if (string.IsNullOrEmpty(txtDenominacion.Text)) throw new Exception("Debe cargar una denominacion");

                Cuenta cuenta = new Cuenta()
                {
                    Codigo = Int32.Parse(txtCodigoCuenta.Text),
                    Denominacion = txtDenominacion.Text
                };

                lblError.Text = "";

                CuentaRepository.Guardar(cuenta);
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
    }
}
