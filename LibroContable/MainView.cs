using LibroContable.Entidades;
using System.Data;

namespace LibroContable
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void BtnAgregarCuenta_Click(object sender, EventArgs e)
        {
            CargaCuentaView cargaCuentaView = new CargaCuentaView();
            cargaCuentaView.ShowDialog();

            //recargar tabla asientos
        }
    }
}