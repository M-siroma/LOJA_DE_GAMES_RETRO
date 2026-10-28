using System.Globalization;
using LojaGamesRetro.Forms;
using LojaGamesRetro.Services;

namespace LojaGamesRetro
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // pra sempre mostrar R$ e data no formato do brasil
            var culturaBr = new CultureInfo("pt-BR");
            CultureInfo.DefaultThreadCurrentCulture = culturaBr;
            CultureInfo.DefaultThreadCurrentUICulture = culturaBr;
            Thread.CurrentThread.CurrentCulture = culturaBr;
            Thread.CurrentThread.CurrentUICulture = culturaBr;

            using (var splash = new FrmSplash())
            {
                if (splash.ShowDialog() != DialogResult.OK)
                    return;
            }

            LojaService.Carregar();
            Application.Run(new FrmMenu());
        }
    }
}
