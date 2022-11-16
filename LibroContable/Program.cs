using LibroContable.Entidades;
using LibroContable.Persistencia;

namespace LibroContable
{
    internal static class Program
    {
        public static BlockChain mainBlockchain = new BlockChain();

        [STAThread]
        static void Main()
        {
            CargaInicialCuentas();

            try
            {
                Console.WriteLine("CANT BLOQUES: " + mainBlockchain.Chain.Count);
            } catch (TypeInitializationException e)
            {
                Console.WriteLine(e.StackTrace);
                ApplicationConfiguration.Initialize();
                Application.Run(new ErrorView(e.InnerException.Message));
                return;
            } 

            ApplicationConfiguration.Initialize();
            Application.Run(new MainView());
        }

        static void CargaInicialCuentas()
        {
            CuentaRepository.Guardar(new Cuenta() { Codigo = 1101, Denominacion = "CAJA" });
            CuentaRepository.Guardar(new Cuenta() { Codigo = 1401, Denominacion = "DEUDORES VARIOS" });
            CuentaRepository.Guardar(new Cuenta() { Codigo = 1501, Denominacion = "MERCADERIAS" });
            CuentaRepository.Guardar(new Cuenta() { Codigo = 1601, Denominacion = "RODADOS" });
            CuentaRepository.Guardar(new Cuenta() { Codigo = 1605, Denominacion = "MUEBLES Y UTILES" });
            CuentaRepository.Guardar(new Cuenta() { Codigo = 1603, Denominacion = "INSTALACIONES" });
            CuentaRepository.Guardar(new Cuenta() { Codigo = 3101, Denominacion = "CAPITAL SOCIAL" });
        }
    }
}