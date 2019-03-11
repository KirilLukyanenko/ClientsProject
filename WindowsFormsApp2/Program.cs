using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Model;
using WindowsFormsApp2.Presenter;
using WindowsFormsApp2.View;

namespace WindowsFormsApp2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var prodTabView = new ProductTabUC();
            var prodPresenter = new ProductPresenter(prodTabView);

            var promoTabView = new PromoTabUC();
            var promoPresenter = new PromoPresenter(promoTabView);

            var priceTabView = new PriceTabUC();
            var pricePresenter = new PricePresenter(priceTabView);

            Application.Run(new MainForm(prodTabView, promoTabView, priceTabView));
        }
    }
}
