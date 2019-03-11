using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Presenter;

namespace WindowsFormsApp2.View
{
    public interface IPromoUC : IView
    {
        int Id { get; set; }
        string NamePromo { get; set; }
        DateTime? FromDate { get; set; }
        DateTime? TillDate { get; set; }

        event EventHandler AddNewPromo;
        event EventHandler DeletePromo;
        event EventHandler UpdatePromo;
        event EventHandler UpdateSelectedPromo;
    }
}
