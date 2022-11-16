using LibroContable.Entidades;
using LibroContable.Persistencia;
using LibroContable.View;
using System.Data;

namespace LibroContable
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
            Iniciar();
        }

        private void BtnAgregarCuenta_Click(object sender, EventArgs e)
        {
            CargaCuentaView cargaCuentaView = new CargaCuentaView();
            cargaCuentaView.ShowDialog();

            Iniciar();
        }

        private void btnAgregarAsiento_Click(object sender, EventArgs e)
        {
            CargaAsientoView cargaAsientoView = new CargaAsientoView();
            cargaAsientoView.ShowDialog();

            Iniciar();
        }

        private void Iniciar()
        {
            CargarFlowLayoutAsientos();
        }

        private void CargarFlowLayoutAsientos()
        {
            if(flowLayoutPanelAsientos.Controls.Count > 0)
            {
                flowLayoutPanelAsientos.Controls.Clear();
            }

            foreach (Asiento asiento in AsientoRepository.Consultar())
            {
                AgregarItemAsiento(asiento);
            }
        }

        private void AgregarItemAsiento(Asiento asiento)
        {
            AsientoListItem listItem = new AsientoListItem();
            listItem.IdAsiento = asiento.Id.ToString();
            listItem.Concepto = asiento.Concepto;
            listItem.Fecha = asiento.Fecha.ToString();
            listItem.Movimientos = asiento.Movimientos;

            flowLayoutPanelAsientos.Controls.Add(listItem);
        }

        private void btnConfirmarLibro_Click(object sender, EventArgs e)
        {
            foreach (Asiento asiento in AsientoRepository.Consultar())
            {
                Console.WriteLine(asiento.Concepto);
            }

            LibroDiario libroDiario = new LibroDiario()
            {
                fecha = DateTime.Now,
                asientos = AsientoRepository.Consultar()
            };

            Console.WriteLine(libroDiario.asientos.Count);

            LibroDiarioRepository.GuardarEnBlockchain(libroDiario);

            AsientoRepository.Vaciar();

            flowLayoutPanelAsientos.Controls.Clear();
        }

        private void btnVerBlockchain_Click(object sender, EventArgs e)
        {
            BlockchainView blockchainView = new BlockchainView();
            blockchainView.ShowDialog();

            Iniciar();
        }
    }
}