using System;
using System.ComponentModel;
using WindowsFormsApp2.Presenter;

namespace WindowsFormsApp2.Model
{
    public class PriceModel
    {
        public PriceModel(Ceny price)
        {
            Id = price.Id;
            RealPrice = price.Cena;
            Discount = price.Rabat;
            DiscountPrice = Discount == null ? 
                RealPrice : RealPrice * (1 - (decimal)Discount/100);
            Promotion = price.CennikId == null ? 
                null : PromoPresenter.GetPromotionById(price.CennikId);
            Product = price.TowarId == null ?
                null : ProductPresenter.GetProductById(price.TowarId);
        }

        public int Id { get; set; }
        [DisplayName("Cennik")]
        public Cenniki Promotion { get; set; }
        [DisplayName("Towar")]
        public Towary Product { get; set; }
        [DisplayName("Cena")]
        public decimal RealPrice { get; set; }
        [DisplayName("Rabat")]
        public Nullable<decimal> Discount { get; set; }
        [DisplayName("Promocyjna cena")]
        public decimal DiscountPrice { get; set; }
    }
}
