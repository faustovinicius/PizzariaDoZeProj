using System.Globalization;
using System;
using System.Threading;
using System.Windows.Forms;
using System.Configuration;
using System.Data.Common;

namespace PizzariaDoZeProj
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region Idioma
            // Tratamento para evitar valor nulo
            string? auxIdiomaRegiao =
                (ConfigurationManager.AppSettings.Get("IdiomaRegiao") is not null) ?
                ConfigurationManager.AppSettings.Get("IdiomaRegiao") : "";

            // Tratamento para afirmar que o valor não é nulo
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(auxIdiomaRegiao!);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(auxIdiomaRegiao!);
            #endregion
            // Integração Database
            DbProviderFactories.RegisterFactory("System.Data.SqlClient", System.Data.SqlClient.SqlClientFactory.Instance);
            DbProviderFactories.RegisterFactory("MySql.Data.MySqlClient", MySql.Data.MySqlClient.MySqlClientFactory.Instance);

            // Chama a inicialização do aplicativo antes de criar qualquer janela
            ApplicationConfiguration.Initialize();

            // Crie a janela principal após a inicialização do aplicativo
            Form1 mainForm = new Form1();

            // Chame o método de ajuste de recursos
            Funcoes.AjustaResourcesControl(mainForm);

            Application.Run(mainForm);


            
        }

        static public void AjustaIdiomaRegiao()
        {
            // ? indica que o valor pode ser nulo
            // no ternário estamos tratando para isso não acontecer
            string? auxIdiomaRegiao = (ConfigurationManager.AppSettings.Get("IdiomaRegiao") is not null) ? ConfigurationManager.AppSettings.Get("IdiomaRegiao") : "";
            // ajusta o idioma/região
            // o operador ! (null-forgiving) afirma que o valor já foi tratado e não será nulo aqui
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(auxIdiomaRegiao!);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(auxIdiomaRegiao!);
        }


    }
}
