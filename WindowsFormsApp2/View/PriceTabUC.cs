using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp2.Model;
using WindowsFormsApp2.Presenter;
using WindowsFormsApp2.Properties;

namespace WindowsFormsApp2.View
{
    public partial class PriceTabUC : UserControl, IPriceUC
    {
        public TabPage Page
        {
            get { return priceTab; }
        }

        public int Id { get; set; }
        public object Promo
        {
            get { return promoComboBox.SelectedItem; }
            set { promoComboBox.SelectedItem = value; }
        }
        public object Product
        {
            get { return productComboBox.SelectedItem; }
            set { productComboBox.SelectedItem = value; }
        }
        public string Price
        {
            get { return priceTBox.Text; }
            set { priceTBox.Text = value; }
        }
        public string Discount
        {
            get { return discountTBox.Text; }
            set { discountTBox.Text = value; }
        }

        public PriceTabUC()
        {
            InitializeComponent();

            UpdatePriceDataGridView();
        }

        public event EventHandler AddNewPrice;
        public event EventHandler DeletePrice;
        public event EventHandler UpdatePrice;
        public event EventHandler UpdateSelectedPrice;
        public event EventHandler<PriceEventArgs> SaveCSV;

        public void WarningMessage(string msg)
        {
            MessageBox.Show(msg);
        }

        private void UpdatePriceDataGridView()
        {
            priceDataGridView.DataSource = PricePresenter.GetPrices();
        }

        private void ClearPriceGroupBoxFields()
        {
            promoComboBox.SelectedItem = null;
            productComboBox.SelectedItem = null;
            priceTBox.Clear();
            discountTBox.Clear();
        }

        private void PriceRemoveBtn_Click(object sender, EventArgs e)
        {
            int index = priceDataGridView.SelectedCells[0].RowIndex;
            int idPrice = 0;
            bool check = Int32.TryParse(priceDataGridView[0, index]
                .Value.ToString(), out idPrice);

            if (!check)
                return;

            if (MessageBox.Show(Resources.RemoveQuestion, Resources.AcceptRemoveText,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            Id = idPrice;

            DeletePrice.Invoke(sender, EventArgs.Empty);

            UpdatePriceDataGridView();

            Id = 0;
        }

        private void UpdatePriceBtn_Click(object sender, EventArgs e)
        {
            priceAcceptBtn.Text = Resources.UpdateBtnText;

            if (priceDataGridView.SelectedCells.Count != 1)
                return;

            int index = priceDataGridView.SelectedCells[0].RowIndex;
            int idPrice = 0;
            bool check = Int32.TryParse(priceDataGridView[0, index]
                .Value.ToString(), out idPrice);

            if (!check)
                return;

            Id = idPrice;

            UpdateSelectedPrice.Invoke(sender, EventArgs.Empty);
        }

        private void PriceUpdateDataBtn_Click(object sender, EventArgs e)
        {
            UpdatePriceDataGridView();
        }

        private void PriceAddBtn_Click(object sender, EventArgs e)
        {
            priceAcceptBtn.Text = Resources.AddBtnText;
            Id = 0;

            ClearPriceGroupBoxFields();
        }

        private void PriceAcceptBtn_Click(object sender, EventArgs e)
        {
            if (Id != 0)
            {
                UpdatePrice.Invoke(sender, EventArgs.Empty);
            }
            else
            {
                AddNewPrice.Invoke(sender, EventArgs.Empty);
            }

            UpdatePriceDataGridView();
            ClearPriceGroupBoxFields();
        }

        private void priceTab_Enter(object sender, EventArgs e)
        {
            promoComboBox.Items.Clear();
            productComboBox.Items.Clear();

            promoComboBox.Items.AddRange(PromoPresenter.GetPromotions().ToArray());
            productComboBox.Items.AddRange(ProductPresenter.GetProducts().ToArray());
        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = Resources.TitleSaveDialog;
            saveFileDialog.CheckPathExists = true;
            saveFileDialog.DefaultExt = Resources.FileExtension;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var args = new PriceEventArgs(saveFileDialog.FileName, priceDataGridView.DataSource);
                SaveCSV.Invoke(sender, args);
            }
        }
    }
}
