using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Model;
using WindowsFormsApp2.Service;
using WindowsFormsApp2.View;

namespace WindowsFormsApp2.Presenter
{
    public class ProductPresenter : Presenter<IProductUC>
    {
        private static readonly ProductsEntities db = new ProductsEntities();

        public ProductPresenter(IProductUC view) : base(view)
        {
            View.AddNewProduct += View_AddNewProduct;
            View.DeleteProduct += View_DeleteProduct;
            View.UpdateProduct += View_UpdateProduct;
            View.UpdateSelectedProduct += View_UpdateSelectedProduct;
        }

        public static Towary GetProductById(int? id)
        {
            return db.Products.FirstOrDefault(p => p.Id == id);
        }

        public static List<Towary> GetProducts()
        {
            var list = new List<Towary>();

            try
            {
                list = db.Products.ToList();
            }
            catch (Exception ex) { }

            return list;
        }

        private void View_UpdateSelectedProduct(object sender, EventArgs e)
        {
            var product = GetProductById(View.Id);

            View.Code = product.Kod;
            View.NameProduct = product.Nazwa;
            View.Weight = product.Masa.ToString();
            View.WeightType = product.JM;
        }

        private void View_UpdateProduct(object sender, EventArgs e)
        {
            var check = new ProductValidation(View.Code, View.NameProduct,
                View.Weight);

            if (!check.IsValid)
            {
                View.WarningMessage(check.WarningMessage);
                return;
            }

            var product = GetProductById(View.Id);
            FillInProductFromView(product);

            product.Data_Modyfikacji = DateTime.Now;

            SaveDBChanges();
        }

        private void View_DeleteProduct(object sender, EventArgs e)
        {
            db.Products.Remove(GetProductById(View.Id));

            SaveDBChanges();
        }

        private void View_AddNewProduct(object sender, EventArgs e)
        {
            var check = new ProductValidation(View.Code, View.NameProduct,
                View.Weight);

            if (!check.IsValid)
            {
                View.WarningMessage(check.WarningMessage);
                return;
            }

            var product = new Towary();
            FillInProductFromView(product);
            product.Data_Utworzenia = DateTime.Now;
            db.Products.Add(product);

            SaveDBChanges();
        }

        private void FillInProductFromView(Towary product)
        {
            if (String.IsNullOrEmpty(View.Weight))
            {
                product.Masa = null;
            }
            else
            {
                product.Masa = Convert.ToDecimal(View.Weight);
            }

            product.Kod = View.Code;
            product.Nazwa = View.NameProduct;
            product.JM = View.WeightType;
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
