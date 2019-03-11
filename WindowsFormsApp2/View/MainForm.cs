using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Model;
using WindowsFormsApp2.Presenter;

namespace WindowsFormsApp2.View
{
    public partial class MainForm : Form, IView
    {
        public MainForm(ProductTabUC prod, PromoTabUC promo, PriceTabUC price)
        {
            InitializeComponent();
            
            tabControl1.Controls.Add(prod.Page);
            tabControl1.Controls.Add(promo.Page);
            tabControl1.Controls.Add(price.Page);
        }
        
        public void WarningMessage(string msg)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
