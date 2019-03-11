using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Model;
using WindowsFormsApp2.Presenter;
using WindowsFormsApp2.Properties;

namespace WindowsFormsApp2.View
{
    public partial class PromoTabUC : UserControl, IPromoUC
    {
        public TabPage Page
        {
            get { return promoTab; }
        }

        public int Id { get; set; }
        public string NamePromo
        {
            get { return promoNameTBox.Text; }
            set { promoNameTBox.Text = value; }
        }
        public DateTime? FromDate
        {
            get { return fromPromoDate.Value; }
            set { fromPromoDate.Text = value.ToString(); }
        }
        public DateTime? TillDate
        {
            get { return tillPromoDate.Value; }
            set { tillPromoDate.Text = value.ToString(); }
        }

        public PromoTabUC()
        {
            InitializeComponent();

            UpdatePromoDataGridView();
        }

        public event EventHandler AddNewPromo;
        public event EventHandler DeletePromo;
        public event EventHandler UpdatePromo;
        public event EventHandler UpdateSelectedPromo;

        public void WarningMessage(string msg)
        {
            MessageBox.Show(msg);
        }

        private void UpdatePromoDataGridView()
        {
            promoDataGridView.DataSource = PromoPresenter.GetPromotions();
        }

        private void ClearPromoGroupBoxFields()
        {
            promoNameTBox.Clear();
            fromPromoDate.Value = DateTime.Now;
            tillPromoDate.Value = DateTime.Now;
        }

        private void AddPromoBtn_Click(object sender, EventArgs e)
        {
            acceptPromoBtn.Text = Resources.AddBtnText;
            Id = 0;

            ClearPromoGroupBoxFields();
        }

        private void RemovePromoBtn_Click(object sender, EventArgs e)
        {
            int index = promoDataGridView.SelectedCells[0].RowIndex;
            int idPromo = 0;
            bool check = Int32.TryParse(promoDataGridView[0, index]
                .Value.ToString(), out idPromo);

            if (!check)
                return;

            if (MessageBox.Show(Resources.RemoveQuestion, Resources.AcceptRemoveText,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            Id = idPromo;

            DeletePromo.Invoke(sender, EventArgs.Empty);

            UpdatePromoDataGridView();

            Id = 0;
        }

        private void UpdatePromoBtn_Click(object sender, EventArgs e)
        {
            acceptPromoBtn.Text = Resources.UpdateBtnText;

            if (promoDataGridView.SelectedCells.Count != 1)
                return;

            int index = promoDataGridView.SelectedCells[0].RowIndex;
            int idPromo = 0;
            bool check = Int32.TryParse(promoDataGridView[0, index]
                .Value.ToString(), out idPromo);

            if (!check)
                return;

            Id = idPromo;

            UpdateSelectedPromo.Invoke(sender, EventArgs.Empty);
        }

        private void UpdateDataPromoBtn_Click(object sender, EventArgs e)
        {
            UpdatePromoDataGridView();
        }

        private void AcceptPromoBtn_Click(object sender, EventArgs e)
        {
            if (Id != 0)
            {
                UpdatePromo.Invoke(sender, EventArgs.Empty);
            }
            else
            {
                AddNewPromo.Invoke(sender, EventArgs.Empty);
            }

            UpdatePromoDataGridView();
            ClearPromoGroupBoxFields();
        }
    }
}
