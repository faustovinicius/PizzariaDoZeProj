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

            // Tratamento para afirmar que o valor n�o � nulo
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(auxIdiomaRegiao!);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(auxIdiomaRegiao!);
            #endregion
            // Integra��o Database
            DbProviderFactories.RegisterFactory("System.Data.SqlClient", System.Data.SqlClient.SqlClientFactory.Instance);
            DbProviderFactories.RegisterFactory("MySql.Data.MySqlClient", MySql.Data.MySqlClient.MySqlClientFactory.Instance);

            // Chama a inicializa��o do aplicativo antes de criar qualquer janela
            ApplicationConfiguration.Initialize();

            // Crie a janela principal ap�s a inicializa��o do aplicativo
            Form1 mainForm = new Form1();

            // Chame o m�todo de ajuste de recursos
            Funcoes.AjustaResourcesControl(mainForm);

            Application.Run(mainForm);


            
        }

        static public void AjustaIdiomaRegiao()
        {
            // ? indica que o valor pode ser nulo
            // no tern�rio estamos tratando para isso n�o acontecer
            string? auxIdiomaRegiao = (ConfigurationManager.AppSettings.Get("IdiomaRegiao") is not null) ? ConfigurationManager.AppSettings.Get("IdiomaRegiao") : "";
            // ajusta o idioma/regi�o
            // o operador ! (null-forgiving) afirma que o valor j� foi tratado e n�o ser� nulo aqui
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(auxIdiomaRegiao!);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(auxIdiomaRegiao!);
        }


    }
}
