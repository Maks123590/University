using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

            RegisterComponents();

            Application.Run(new MainForm());
        }

        private static void RegisterComponents()
        {
            ServiceLocator.Register<IDbDownoader>(new CrbDbDownloader(AppResource.App_Data_Path));
            ServiceLocator.Register<IBankInfoFinder>(new BankInfoFinder());
        }
    }
}
