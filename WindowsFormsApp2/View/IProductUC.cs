using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Presenter;

namespace WindowsFormsApp2.View
{
    public interface IProductUC : IView
    {
        int Id { get; set; }
        string Code { get; set; }
        string NameProduct { get; set; }
        string Weight { get; set; }
        string WeightType { get; set; }

        event EventHandler AddNewProduct;
        event EventHandler DeleteProduct;
        event EventHandler UpdateProduct;
        event EventHandler UpdateSelectedProduct;
    }
}
