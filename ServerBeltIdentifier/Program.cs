using Opc.Ua;
using Opc.Ua.Configuration;
using BeltIdentifierServer.Models;

namespace BeltIdentifierServer
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            
            ApplicationInstance application = new ApplicationInstance();
            application.ApplicationType = ApplicationType.Server;
            application.ConfigSectionName = "ServerBeltIdentifier";

            try
            {
                // process and command line arguments.
                if (application.ProcessCommandLine())
                {
                    return;
                }

                // check if running as a service.
                if (!Environment.UserInteractive)
                {
                    application.StartAsService(new Server());
                    return;
                }

                // Carregar as configurações do aplicativo.
                application.LoadApplicationConfiguration("C:\\Users\\engja\\source\\repos\\SimulatorBeltIdentifier\\ServerBeltIdentifier\\Models\\OpcComunication\\ServerBeltIdentifier.Config.xml", false).Wait();

                // Checar o certificado do aplicativo.
                application.CheckApplicationInstanceCertificate(false, 0).Wait();

                // Iniciar o Servidor.
                application.Start(new Server()).Wait();

                // Rodando o aplicativo.
                Application.Run(new Form1(application));

            }catch (Exception ex) 
            {
                string text = "Exception: " + ex.Message;
                if (ex.InnerException != null) 
                {
                    text += "\r\nInner exception: ";
                    text += ex.InnerException.Message;
                }
                MessageBox.Show(text, application.ApplicationName);
            }

        }
    }
}