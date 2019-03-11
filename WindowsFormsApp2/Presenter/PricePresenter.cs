using System;
using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp2.Model;
using WindowsFormsApp2.Service;
using WindowsFormsApp2.View;

namespace WindowsFormsApp2.Presenter
{
    public class PricePresenter : Presenter<IPriceUC>
    {
        private static readonly PricesEntities db = new PricesEntities();

        public PricePresenter(IPriceUC view) : base(view)
        {
            View.AddNewPrice += View_AddNewPrice;
            View.DeletePrice += View_DeletePrice;
            View.UpdatePrice += View_UpdatePrice;
            View.UpdateSelectedPrice += View_UpdateSelectedPrice;
            View.SaveCSV += View_SaveCSV;
        }

        public static List<PriceModel> GetPrices()
        {
            var prices = new List<Ceny>();

            try
            {
                prices = db.Prices.ToList();
            }
            catch (Exception ex) { }

            var listModels = new List<PriceModel>();

            foreach (var pr in prices)
            {
                var price = new PriceModel(pr);
                listModels.Add(price);
            }

            return listModels;
        }

        private void View_SaveCSV(object sender, PriceEventArgs args)
        {
            var export = new ExportCSV(args.FilePath, args.Models);
            if (!String.IsNullOrEmpty(export.WarningMessage))
            {
                View.WarningMessage(export.WarningMessage);
            }
        }

        private void View_UpdateSelectedPrice(object sender, EventArgs e)
        {
            var price = GetPriceById(View.Id);

            View.Product = ProductPresenter.GetProductById(price.TowarId);
            View.Promo = PromoPresenter.GetPromotionById(price.CennikId);
            View.Price = price.Cena.ToString();
            View.Discount = price.Rabat.ToString();
        }

        private void View_UpdatePrice(object sender, EventArgs e)
        {
            var check = new PriceValidation(View.Price, View.Discount);
            if (!check.IsValid)
            {
                View.WarningMessage(check.WarningMessage);
                return;
            }

            var price = GetPriceById(View.Id);

            FillInPriceFromView(price);

            SaveDBChanges();
        }

        private void View_DeletePrice(object sender, EventArgs e)
        {
            db.Prices.Remove(GetPriceById(View.Id));
            SaveDBChanges();
        }

        private void View_AddNewPrice(object sender, EventArgs e)
        {
            var check = new PriceValidation(View.Price, View.Discount);
            if (!check.IsValid)
            {
                View.WarningMessage(check.WarningMessage);
                return;
            }

            var price = new Ceny();
            FillInPriceFromView(price);
            db.Prices.Add(price);

            SaveDBChanges();
        }

        private void FillInPriceFromView(Ceny price)
        {
            var prod = View.Product as Towary;
            if (prod == null)
            {
                price.TowarId = null;
            }
            else
            {
                price.TowarId = prod.Id;
            }

            var promo = View.Promo as Cenniki;
            if (promo == null)
            {
                price.CennikId = null;
            }
            else
            {
                price.CennikId = promo.Id;
            }

            if (View.Discount == null)
            {
                price.Rabat = null;
            }
            else
            {
                price.Rabat = Convert.ToDecimal(View.Discount);
            }

            price.Cena = Convert.ToDecimal(View.Price);
        }

        private void SaveDBChanges()
        {
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                View.WarningMessage(ex.Message);
            }
        }

        private Ceny GetPriceById(int id)
        {
            return db.Prices.FirstOrDefault(p => p.Id == id);
        }
    }
}
