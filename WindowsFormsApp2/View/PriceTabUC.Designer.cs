namespace WindowsFormsApp2.View
{
    partial class PriceTabUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.priceTab = new System.Windows.Forms.TabPage();
            this.priceRemoveBtn = new System.Windows.Forms.Button();
            this.priceUpdateDataBtn = new System.Windows.Forms.Button();
            this.updatePriceBtn = new System.Windows.Forms.Button();
            this.priceAddBtn = new System.Windows.Forms.Button();
            this.priceGroupBox = new System.Windows.Forms.GroupBox();
            this.discountTBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.promoComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.priceAcceptBtn = new System.Windows.Forms.Button();
            this.priceTBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.priceDataGridView = new System.Windows.Forms.DataGridView();
            this.saveFile = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.priceTab.SuspendLayout();
            this.priceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.priceTab);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1041, 515);
            this.tabControl1.TabIndex = 0;
            // 
            // priceTab
            // 
            this.priceTab.Controls.Add(this.saveFile);
            this.priceTab.Controls.Add(this.priceRemoveBtn);
            this.priceTab.Controls.Add(this.priceUpdateDataBtn);
            this.priceTab.Controls.Add(this.updatePriceBtn);
            this.priceTab.Controls.Add(this.priceAddBtn);
            this.priceTab.Controls.Add(this.priceGroupBox);
            this.priceTab.Controls.Add(this.priceDataGridView);
            this.priceTab.Location = new System.Drawing.Point(4, 25);
            this.priceTab.Name = "priceTab";
            this.priceTab.Padding = new System.Windows.Forms.Padding(3);
            this.priceTab.Size = new System.Drawing.Size(1033, 486);
            this.priceTab.TabIndex = 3;
            this.priceTab.Text = "Ceny";
            this.priceTab.UseVisualStyleBackColor = true;
            this.priceTab.Enter += new System.EventHandler(this.priceTab_Enter);
            // 
            // priceRemoveBtn
            // 
            this.priceRemoveBtn.Location = new System.Drawing.Point(230, 24);
            this.priceRemoveBtn.Name = "priceRemoveBtn";
            this.priceRemoveBtn.Size = new System.Drawing.Size(171, 45);
            this.priceRemoveBtn.TabIndex = 32;
            this.priceRemoveBtn.Text = "Usunąć ";
            this.priceRemoveBtn.UseVisualStyleBackColor = true;
            this.priceRemoveBtn.Click += new System.EventHandler(this.PriceRemoveBtn_Click);
            // 
            // priceUpdateDataBtn
            // 
            this.priceUpdateDataBtn.Location = new System.Drawing.Point(621, 25);
            this.priceUpdateDataBtn.Name = "priceUpdateDataBtn";
            this.priceUpdateDataBtn.Size = new System.Drawing.Size(161, 45);
            this.priceUpdateDataBtn.TabIndex = 31;
            this.priceUpdateDataBtn.Text = "Zaktualizować";
            this.priceUpdateDataBtn.UseVisualStyleBackColor = true;
            this.priceUpdateDataBtn.Click += new System.EventHandler(this.PriceUpdateDataBtn_Click);
            // 
            // updatePriceBtn
            // 
            this.updatePriceBtn.Location = new System.Drawing.Point(430, 25);
            this.updatePriceBtn.Name = "updatePriceBtn";
            this.updatePriceBtn.Size = new System.Drawing.Size(153, 45);
            this.updatePriceBtn.TabIndex = 30;
            this.updatePriceBtn.Text = "Zmienić";
            this.updatePriceBtn.UseVisualStyleBackColor = true;
            this.updatePriceBtn.Click += new System.EventHandler(this.UpdatePriceBtn_Click);
            // 
            // priceAddBtn
            // 
            this.priceAddBtn.Location = new System.Drawing.Point(31, 23);
            this.priceAddBtn.Name = "priceAddBtn";
            this.priceAddBtn.Size = new System.Drawing.Size(171, 45);
            this.priceAddBtn.TabIndex = 29;
            this.priceAddBtn.Text = "Dodać";
            this.priceAddBtn.UseVisualStyleBackColor = true;
            this.priceAddBtn.Click += new System.EventHandler(this.PriceAddBtn_Click);
            // 
            // priceGroupBox
            // 
            this.priceGroupBox.Controls.Add(this.discountTBox);
            this.priceGroupBox.Controls.Add(this.label7);
            this.priceGroupBox.Controls.Add(this.productComboBox);
            this.priceGroupBox.Controls.Add(this.promoComboBox);
            this.priceGroupBox.Controls.Add(this.label2);
            this.priceGroupBox.Controls.Add(this.priceAcceptBtn);
            this.priceGroupBox.Controls.Add(this.priceTBox);
            this.priceGroupBox.Controls.Add(this.label5);
            this.priceGroupBox.Controls.Add(this.label6);
            this.priceGroupBox.Location = new System.Drawing.Point(838, 75);
            this.priceGroupBox.Name = "priceGroupBox";
            this.priceGroupBox.Size = new System.Drawing.Size(214, 400);
            this.priceGroupBox.TabIndex = 28;
            this.priceGroupBox.TabStop = false;
            // 
            // discountTBox
            // 
            this.discountTBox.Location = new System.Drawing.Point(25, 293);
            this.discountTBox.Name = "discountTBox";
            this.discountTBox.Size = new System.Drawing.Size(153, 22);
            this.discountTBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Rabat";
            // 
            // productComboBox
            // 
            this.productComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(26, 134);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(152, 24);
            this.productComboBox.TabIndex = 11;
            // 
            // promoComboBox
            // 
            this.promoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.promoComboBox.FormattingEnabled = true;
            this.promoComboBox.Location = new System.Drawing.Point(25, 56);
            this.promoComboBox.Name = "promoComboBox";
            this.promoComboBox.Size = new System.Drawing.Size(153, 24);
            this.promoComboBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Towar";
            // 
            // priceAcceptBtn
            // 
            this.priceAcceptBtn.Location = new System.Drawing.Point(25, 343);
            this.priceAcceptBtn.Name = "priceAcceptBtn";
            this.priceAcceptBtn.Size = new System.Drawing.Size(153, 44);
            this.priceAcceptBtn.TabIndex = 9;
            this.priceAcceptBtn.Text = "Dodaj";
            this.priceAcceptBtn.UseVisualStyleBackColor = true;
            this.priceAcceptBtn.Click += new System.EventHandler(this.PriceAcceptBtn_Click);
            // 
            // priceTBox
            // 
            this.priceTBox.Location = new System.Drawing.Point(26, 217);
            this.priceTBox.Name = "priceTBox";
            this.priceTBox.Size = new System.Drawing.Size(153, 22);
            this.priceTBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cena";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cennik";
            // 
            // priceDataGridView
            // 
            this.priceDataGridView.AllowUserToAddRows = false;
            this.priceDataGridView.AllowUserToDeleteRows = false;
            this.priceDataGridView.AllowUserToOrderColumns = true;
            this.priceDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.priceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.priceDataGridView.Location = new System.Drawing.Point(28, 90);
            this.priceDataGridView.Name = "priceDataGridView";
            this.priceDataGridView.RowTemplate.Height = 24;
            this.priceDataGridView.RowTemplate.ReadOnly = true;
            this.priceDataGridView.Size = new System.Drawing.Size(763, 385);
            this.priceDataGridView.TabIndex = 27;
            // 
            // saveFile
            // 
            this.saveFile.Location = new System.Drawing.Point(850, 25);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(167, 45);
            this.saveFile.TabIndex = 33;
            this.saveFile.Text = "Zapisz do CSV";
            this.saveFile.UseVisualStyleBackColor = true;
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // PriceTabUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "PriceTabUC";
            this.Size = new System.Drawing.Size(1051, 526);
            this.tabControl1.ResumeLayout(false);
            this.priceTab.ResumeLayout(false);
            this.priceGroupBox.ResumeLayout(false);
            this.priceGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage priceTab;
        private System.Windows.Forms.Button priceRemoveBtn;
        private System.Windows.Forms.Button priceUpdateDataBtn;
        private System.Windows.Forms.Button updatePriceBtn;
        private System.Windows.Forms.Button priceAddBtn;
        private System.Windows.Forms.GroupBox priceGroupBox;
        private System.Windows.Forms.TextBox discountTBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.ComboBox promoComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button priceAcceptBtn;
        private System.Windows.Forms.TextBox priceTBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView priceDataGridView;
        private System.Windows.Forms.Button saveFile;
    }
}
