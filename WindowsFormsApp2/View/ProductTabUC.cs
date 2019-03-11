using System;
using System.Windows.Forms;
using WindowsFormsApp2.Enums;
using WindowsFormsApp2.Presenter;
using WindowsFormsApp2.Properties;

namespace WindowsFormsApp2.View
{
    public partial class ProductTabUC : UserControl, IProductUC
    {
        public TabPage Page
        {
            get { return productTab; }
        }

        public int Id { get; set; }
        public string Code
        {
            get { return codeTBox.Text; }
            set { codeTBox.Text = value; }
        }
        public string NameProduct
        {
            get { return nameTBox.Text; }
            set { nameTBox.Text = value; }
        }
        public string Weight
        {
            get { return weightTBox.Text; }
            set { weightTBox.Text = value; }
        }
        public string WeightType
        {
            get { return weightTypeCBox.Text; }
            set { weightTypeCBox.SelectedItem = value; }
        }

        public ProductTabUC()
        {
            InitializeComponent();

            UpdateDataGridView();
            weightTypeCBox.Items.AddRange(Enum.GetNames(typeof(WeightTypes)));
        }

        public event EventHandler AddNewProduct;
        public event EventHandler DeleteProduct;
        public event EventHandler UpdateProduct;
        public event EventHandler UpdateSelectedProduct;

        public void WarningMessage(string msg)
        {
            MessageBox.Show(msg);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            acceptBtn.Text = Resources.AddBtnText;
            Id = 0;

            ClearGroupBoxFields();
        }

        private void UpdateProductBtn_Click(object sender, EventArgs e)
        {
            acceptBtn.Text = Resources.UpdateBtnText;

            if (dataGridView.SelectedCells.Count != 1)
                return;

            int index = dataGridView.SelectedCells[0].RowIndex;
            int idProduct = 0;
            bool check = Int32.TryParse(dataGridView[0, index]
                .Value.ToString(), out idProduct);

            if (!check)
                return;

            Id = idProduct;

            UpdateSelectedProduct.Invoke(sender, EventArgs.Empty);
        }

        private void UpdateDataBtn_Click(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            if (Id != 0)
            {
                UpdateProduct.Invoke(sender, EventArgs.Empty);
            }
            else
            {
                AddNewProduct.Invoke(sender, EventArgs.Empty);
            }

            UpdateDataGridView();
            ClearGroupBoxFields();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int index = dataGridView.SelectedCells[0].RowIndex;
            int productId = 0;
            bool check = Int32.TryParse(dataGridView[0, index]
                .Value.ToString(), out productId);

            if (!check)
                return;

            if (MessageBox.Show(Resources.RemoveQuestion, Resources.AcceptRemoveText,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            Id = productId;

            DeleteProduct.Invoke(sender, EventArgs.Empty);

            UpdateDataGridView();

            Id = 0;
        }

        private void UpdateDataGridView()
        {
            dataGridView.DataSource = ProductPresenter.GetProducts();
        }

        private void ClearGroupBoxFields()
        {
            codeTBox.Clear();
            nameTBox.Clear();
            weightTBox.Clear();
            weightTypeCBox.SelectedItem = null;
        }
    }
}
