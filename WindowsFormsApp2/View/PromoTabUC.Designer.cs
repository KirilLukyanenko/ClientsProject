namespace WindowsFormsApp2.View
{
    partial class PromoTabUC
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
            this.promoTab = new System.Windows.Forms.TabPage();
            this.removePromoBtn = new System.Windows.Forms.Button();
            this.updateDataPromoBtn = new System.Windows.Forms.Button();
            this.updatePromoBtn = new System.Windows.Forms.Button();
            this.addPromoBtn = new System.Windows.Forms.Button();
            this.promoGroupBox = new System.Windows.Forms.GroupBox();
            this.tillPromoDate = new System.Windows.Forms.DateTimePicker();
            this.fromPromoDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.acceptPromoBtn = new System.Windows.Forms.Button();
            this.promoNameTBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.promoDataGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.promoTab.SuspendLayout();
            this.promoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.promoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.promoTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1068, 516);
            this.tabControl1.TabIndex = 0;
            // 
            // promoTab
            // 
            this.promoTab.Controls.Add(this.removePromoBtn);
            this.promoTab.Controls.Add(this.updateDataPromoBtn);
            this.promoTab.Controls.Add(this.updatePromoBtn);
            this.promoTab.Controls.Add(this.addPromoBtn);
            this.promoTab.Controls.Add(this.promoGroupBox);
            this.promoTab.Controls.Add(this.promoDataGridView);
            this.promoTab.Location = new System.Drawing.Point(4, 25);
            this.promoTab.Name = "promoTab";
            this.promoTab.Padding = new System.Windows.Forms.Padding(3);
            this.promoTab.Size = new System.Drawing.Size(1060, 487);
            this.promoTab.TabIndex = 2;
            this.promoTab.Text = "Cenniki";
            this.promoTab.UseVisualStyleBackColor = true;
            // 
            // removePromoBtn
            // 
            this.removePromoBtn.Location = new System.Drawing.Point(223, 24);
            this.removePromoBtn.Name = "removePromoBtn";
            this.removePromoBtn.Size = new System.Drawing.Size(171, 45);
            this.removePromoBtn.TabIndex = 26;
            this.removePromoBtn.Text = "Usunąć ";
            this.removePromoBtn.UseVisualStyleBackColor = true;
            this.removePromoBtn.Click += new System.EventHandler(this.RemovePromoBtn_Click);
            // 
            // updateDataPromoBtn
            // 
            this.updateDataPromoBtn.Location = new System.Drawing.Point(614, 25);
            this.updateDataPromoBtn.Name = "updateDataPromoBtn";
            this.updateDataPromoBtn.Size = new System.Drawing.Size(161, 45);
            this.updateDataPromoBtn.TabIndex = 25;
            this.updateDataPromoBtn.Text = "Zaktualizować";
            this.updateDataPromoBtn.UseVisualStyleBackColor = true;
            this.updateDataPromoBtn.Click += new System.EventHandler(this.UpdateDataPromoBtn_Click);
            // 
            // updatePromoBtn
            // 
            this.updatePromoBtn.Location = new System.Drawing.Point(423, 25);
            this.updatePromoBtn.Name = "updatePromoBtn";
            this.updatePromoBtn.Size = new System.Drawing.Size(153, 45);
            this.updatePromoBtn.TabIndex = 24;
            this.updatePromoBtn.Text = "Zmienić";
            this.updatePromoBtn.UseVisualStyleBackColor = true;
            this.updatePromoBtn.Click += new System.EventHandler(this.UpdatePromoBtn_Click);
            // 
            // addPromoBtn
            // 
            this.addPromoBtn.Location = new System.Drawing.Point(24, 23);
            this.addPromoBtn.Name = "addPromoBtn";
            this.addPromoBtn.Size = new System.Drawing.Size(171, 45);
            this.addPromoBtn.TabIndex = 23;
            this.addPromoBtn.Text = "Dodać";
            this.addPromoBtn.UseVisualStyleBackColor = true;
            this.addPromoBtn.Click += new System.EventHandler(this.AddPromoBtn_Click);
            // 
            // promoGroupBox
            // 
            this.promoGroupBox.Controls.Add(this.tillPromoDate);
            this.promoGroupBox.Controls.Add(this.fromPromoDate);
            this.promoGroupBox.Controls.Add(this.label1);
            this.promoGroupBox.Controls.Add(this.acceptPromoBtn);
            this.promoGroupBox.Controls.Add(this.promoNameTBox);
            this.promoGroupBox.Controls.Add(this.label3);
            this.promoGroupBox.Controls.Add(this.label4);
            this.promoGroupBox.Location = new System.Drawing.Point(831, 90);
            this.promoGroupBox.Name = "promoGroupBox";
            this.promoGroupBox.Size = new System.Drawing.Size(214, 385);
            this.promoGroupBox.TabIndex = 22;
            this.promoGroupBox.TabStop = false;
            // 
            // tillPromoDate
            // 
            this.tillPromoDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tillPromoDate.Location = new System.Drawing.Point(25, 225);
            this.tillPromoDate.Name = "tillPromoDate";
            this.tillPromoDate.Size = new System.Drawing.Size(153, 22);
            this.tillPromoDate.TabIndex = 27;
            // 
            // fromPromoDate
            // 
            this.fromPromoDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromPromoDate.Location = new System.Drawing.Point(25, 138);
            this.fromPromoDate.Name = "fromPromoDate";
            this.fromPromoDate.Size = new System.Drawing.Size(153, 22);
            this.fromPromoDate.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data od";
            // 
            // acceptPromoBtn
            // 
            this.acceptPromoBtn.Location = new System.Drawing.Point(25, 321);
            this.acceptPromoBtn.Name = "acceptPromoBtn";
            this.acceptPromoBtn.Size = new System.Drawing.Size(153, 44);
            this.acceptPromoBtn.TabIndex = 9;
            this.acceptPromoBtn.Text = "Dodaj";
            this.acceptPromoBtn.UseVisualStyleBackColor = true;
            this.acceptPromoBtn.Click += new System.EventHandler(this.AcceptPromoBtn_Click);
            // 
            // promoNameTBox
            // 
            this.promoNameTBox.Location = new System.Drawing.Point(25, 54);
            this.promoNameTBox.Name = "promoNameTBox";
            this.promoNameTBox.Size = new System.Drawing.Size(153, 22);
            this.promoNameTBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data do";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nazwa";
            // 
            // promoDataGridView
            // 
            this.promoDataGridView.AllowUserToAddRows = false;
            this.promoDataGridView.AllowUserToDeleteRows = false;
            this.promoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.promoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.promoDataGridView.Location = new System.Drawing.Point(21, 90);
            this.promoDataGridView.Name = "promoDataGridView";
            this.promoDataGridView.ReadOnly = true;
            this.promoDataGridView.RowTemplate.Height = 24;
            this.promoDataGridView.Size = new System.Drawing.Size(763, 385);
            this.promoDataGridView.TabIndex = 0;
            // 
            // PromoTabUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "PromoTabUC";
            this.Size = new System.Drawing.Size(1087, 525);
            this.tabControl1.ResumeLayout(false);
            this.promoTab.ResumeLayout(false);
            this.promoGroupBox.ResumeLayout(false);
            this.promoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.promoDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage promoTab;
        private System.Windows.Forms.Button removePromoBtn;
        private System.Windows.Forms.Button updateDataPromoBtn;
        private System.Windows.Forms.Button updatePromoBtn;
        private System.Windows.Forms.Button addPromoBtn;
        private System.Windows.Forms.GroupBox promoGroupBox;
        private System.Windows.Forms.DateTimePicker tillPromoDate;
        private System.Windows.Forms.DateTimePicker fromPromoDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button acceptPromoBtn;
        private System.Windows.Forms.TextBox promoNameTBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView promoDataGridView;
    }
}
