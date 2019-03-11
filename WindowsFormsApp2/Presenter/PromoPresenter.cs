using System;
using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp2.Model;
using WindowsFormsApp2.Properties;
using WindowsFormsApp2.View;

namespace WindowsFormsApp2.Presenter
{
    public class PromoPresenter : Presenter<IPromoUC>
    {
        private static readonly PromotionsEntities db = new PromotionsEntities();

        public PromoPresenter(IPromoUC view) : base(view)
        {
            View.AddNewPromo += View_AddNewPromo;
            View.DeletePromo += View_DeletePromo;
            View.UpdatePromo += View_UpdatePromo;
            View.UpdateSelectedPromo += View_UpdateSelectedPromo;
        }

        public static Cenniki GetPromotionById(int? id)
        {
            return db.Promotions.FirstOrDefault(p => p.Id == id);
        }

        public static List<Cenniki> GetPromotions()
        {
            var list = new List<Cenniki>();

            try
            {
                list = db.Promotions.ToList();
            }
            catch (Exception ex) { }

            return list;
        }

        private void View_UpdateSelectedPromo(object sender, EventArgs e)
        {
            var promo = GetPromotionById(View.Id);

            View.NamePromo = promo.Nazwa;
            View.FromDate = promo.Data_Od;
            View.TillDate = promo.Data_Do;
        }

        private void View_UpdatePromo(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(View.NamePromo) || View.NamePromo.Length > 255)
            {
                View.WarningMessage(Resources.NameWarning);
                return;
            }

            var promo = GetPromotionById(View.Id);

            FillInPromotionFromView(promo);

            SaveDBChanges();
        }

        private void View_DeletePromo(object sender, EventArgs e)
        {
            db.Promotions.Remove(GetPromotionById(View.Id));
            SaveDBChanges();
        }

        private void View_AddNewPromo(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(View.NamePromo) || View.NamePromo.Length > 255)
            {
                View.WarningMessage(Resources.NameWarning);
                return;
            }

            var promo = new Cenniki();
            FillInPromotionFromView(promo);
            db.Promotions.Add(promo);

            SaveDBChanges();
        }

        private void FillInPromotionFromView(Cenniki promo)
        {
            promo.Nazwa = View.NamePromo;
            promo.Data_Od = View.FromDate;
            promo.Data_Do = View.TillDate;
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
    }
}
