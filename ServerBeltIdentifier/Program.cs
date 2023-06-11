using Opc.Ua;
using Opc.Ua.Configuration;
using BeltIdentifierServer.Models;

namespace BeltIdentifierServer
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            ApplicationInstance application = new()
            {
                ApplicationType = ApplicationType.Server,
                ConfigSectionName = "ServerBeltIdentifier"
            };

            try
            {
                // Checa se o serviço está executando.
                if (!Environment.UserInteractive)
                {
                    application.StartAsService(new Server());
                    return;
                }

                // Carregar as configurações do aplicativo.
                application.LoadApplicationConfiguration("Models\\OpcComunication\\ServerBeltIdentifier.Config.xml", false).Wait();

                // Checar o certificado do aplicativo.
                application.CheckApplicationInstanceCertificate(false, 0).Wait();

                // Iniciar o Servidor.
                application.Start(new Server()).Wait();

                // Rodando o aplicativo.
                Application.Run(new ServerForm(application));

            }
            catch (Exception ex)
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