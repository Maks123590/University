using System;
using System.Windows.Forms;

namespace WordInteractionLab8
{
    using WordInteractionLab8.Forms;
    using WordInteractionLab8.IoC;
    using WordInteractionLab8.Models;
    using WordInteractionLab8.Models.Interfaces;
    using WordInteractionLab8.Resources;

    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AppDomain.CurrentDomain.SetData("DataDirectory", System.IO.Directory.GetCurrentDirectory());

            RegisterComponents();

            Application.Run(new MainForm());
        }

        private static void RegisterComponents()
        {
            ServiceLocator.Register<IDbDownloader>(new CrbDbDownloader(AppResource.App_Data_Path));
            ServiceLocator.Register<IBankInfoFinder>(new BankInfoFinder());
            ServiceLocator.Register<IDbChanger>(new EntityFrameworkDbChanger());

            ServiceLocator.Register<IBankAccountFinder>(new BankAccountFinder());
            ServiceLocator.Register<IOrganizationFinder>(new OrganizationInfoFinder());
            ServiceLocator.Register<IPaymentOrderFinder>(new PaymentOrderFinder());

        }
    }
}
