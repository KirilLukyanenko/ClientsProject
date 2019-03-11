using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Presenter;

namespace WindowsFormsApp2.View
{
    public interface IPriceUC : IView
    {
        int Id { get; set; }
        object Promo { get; set; }
        object Product { get; set; }
        string Price { get; set; }
        string Discount { get; set; }

        event EventHandler AddNewPrice;
        event EventHandler DeletePrice;
        event EventHandler UpdatePrice;
        event EventHandler UpdateSelectedPrice;
        event EventHandler<PriceEventArgs> SaveCSV;
    }
}
