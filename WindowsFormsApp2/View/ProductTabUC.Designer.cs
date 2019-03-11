namespace WindowsFormsApp2.View
{
    partial class ProductTabUC
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
            this.productTab = new System.Windows.Forms.TabPage();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.weightTypeCBox = new System.Windows.Forms.ComboBox();
            this.codeLbl = new System.Windows.Forms.Label();
            this.codeTBox = new System.Windows.Forms.TextBox();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.nameTBox = new System.Windows.Forms.TextBox();
            this.weightTBox = new System.Windows.Forms.TextBox();
            this.weightTypeLbl = new System.Windows.Forms.Label();
            this.weightLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateDataBtn = new System.Windows.Forms.Button();
            this.updateProductBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.productTab.SuspendLayout();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.productTab);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1089, 511);
            this.tabControl1.TabIndex = 0;
            // 
            // productTab
            // 
            this.productTab.Controls.Add(this.groupBox);
            this.productTab.Controls.Add(this.dataGridView);
            this.productTab.Controls.Add(this.deleteBtn);
            this.productTab.Controls.Add(this.updateDataBtn);
            this.productTab.Controls.Add(this.updateProductBtn);
            this.productTab.Controls.Add(this.addBtn);
            this.productTab.Location = new System.Drawing.Point(4, 25);
            this.productTab.Name = "productTab";
            this.productTab.Padding = new System.Windows.Forms.Padding(3);
            this.productTab.Size = new System.Drawing.Size(1081, 482);
            this.productTab.TabIndex = 1;
            this.productTab.Text = "Towary";
            this.productTab.UseVisualStyleBackColor = true;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.weightTypeCBox);
            this.groupBox.Controls.Add(this.codeLbl);
            this.groupBox.Controls.Add(this.codeTBox);
            this.groupBox.Controls.Add(this.acceptBtn);
            this.groupBox.Controls.Add(this.nameTBox);
            this.groupBox.Controls.Add(this.weightTBox);
            this.groupBox.Controls.Add(this.weightTypeLbl);
            this.groupBox.Controls.Add(this.weightLbl);
            this.groupBox.Controls.Add(this.nameLbl);
            this.groupBox.Location = new System.Drawing.Point(846, 101);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(214, 368);
            this.groupBox.TabIndex = 21;
            this.groupBox.TabStop = false;
            // 
            // weightTypeCBox
            // 
            this.weightTypeCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.weightTypeCBox.FormattingEnabled = true;
            this.weightTypeCBox.Location = new System.Drawing.Point(25, 275);
            this.weightTypeCBox.Name = "weightTypeCBox";
            this.weightTypeCBox.Size = new System.Drawing.Size(153, 24);
            this.weightTypeCBox.TabIndex = 10;
            // 
            // codeLbl
            // 
            this.codeLbl.AutoSize = true;
            this.codeLbl.Location = new System.Drawing.Point(22, 19);
            this.codeLbl.Name = "codeLbl";
            this.codeLbl.Size = new System.Drawing.Size(33, 17);
            this.codeLbl.TabIndex = 5;
            this.codeLbl.Text = "Kod";
            // 
            // codeTBox
            // 
            this.codeTBox.Location = new System.Drawing.Point(25, 51);
            this.codeTBox.Name = "codeTBox";
            this.codeTBox.Size = new System.Drawing.Size(153, 22);
            this.codeTBox.TabIndex = 1;
            // 
            // acceptBtn
            // 
            this.acceptBtn.Location = new System.Drawing.Point(25, 321);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(153, 44);
            this.acceptBtn.TabIndex = 9;
            this.acceptBtn.Text = "Dodaj";
            this.acceptBtn.UseVisualStyleBackColor = true;
            this.acceptBtn.Click += new System.EventHandler(this.AcceptBtn_Click);
            // 
            // nameTBox
            // 
            this.nameTBox.Location = new System.Drawing.Point(25, 127);
            this.nameTBox.Name = "nameTBox";
            this.nameTBox.Size = new System.Drawing.Size(153, 22);
            this.nameTBox.TabIndex = 2;
            // 
            // weightTBox
            // 
            this.weightTBox.Location = new System.Drawing.Point(25, 202);
            this.weightTBox.Name = "weightTBox";
            this.weightTBox.Size = new System.Drawing.Size(153, 22);
            this.weightTBox.TabIndex = 3;
            // 
            // weightTypeLbl
            // 
            this.weightTypeLbl.AutoSize = true;
            this.weightTypeLbl.Location = new System.Drawing.Point(22, 242);
            this.weightTypeLbl.Name = "weightTypeLbl";
            this.weightTypeLbl.Size = new System.Drawing.Size(26, 17);
            this.weightTypeLbl.TabIndex = 8;
            this.weightTypeLbl.Text = "JM";
            // 
            // weightLbl
            // 
            this.weightLbl.AutoSize = true;
            this.weightLbl.Location = new System.Drawing.Point(22, 172);
            this.weightLbl.Name = "weightLbl";
            this.weightLbl.Size = new System.Drawing.Size(42, 17);
            this.weightLbl.TabIndex = 7;
            this.weightLbl.Text = "Masa";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(22, 96);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(50, 17);
            this.nameLbl.TabIndex = 6;
            this.nameLbl.Text = "Nazwa";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(20, 104);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(769, 365);
            this.dataGridView.TabIndex = 20;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(223, 24);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(171, 45);
            this.deleteBtn.TabIndex = 19;
            this.deleteBtn.Text = "Usunąć ";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // updateDataBtn
            // 
            this.updateDataBtn.Location = new System.Drawing.Point(614, 25);
            this.updateDataBtn.Name = "updateDataBtn";
            this.updateDataBtn.Size = new System.Drawing.Size(161, 45);
            this.updateDataBtn.TabIndex = 18;
            this.updateDataBtn.Text = "Zaktualizować";
            this.updateDataBtn.UseVisualStyleBackColor = true;
            this.updateDataBtn.Click += new System.EventHandler(this.UpdateDataBtn_Click);
            // 
            // updateProductBtn
            // 
            this.updateProductBtn.Location = new System.Drawing.Point(423, 25);
            this.updateProductBtn.Name = "updateProductBtn";
            this.updateProductBtn.Size = new System.Drawing.Size(153, 45);
            this.updateProductBtn.TabIndex = 17;
            this.updateProductBtn.Text = "Zmienić";
            this.updateProductBtn.UseVisualStyleBackColor = true;
            this.updateProductBtn.Click += new System.EventHandler(this.UpdateProductBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(24, 23);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(171, 45);
            this.addBtn.TabIndex = 16;
            this.addBtn.Text = "Dodać";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ProductTabUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "ProductTabUC";
            this.Size = new System.Drawing.Size(1098, 523);
            this.tabControl1.ResumeLayout(false);
            this.productTab.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage productTab;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label codeLbl;
        private System.Windows.Forms.TextBox codeTBox;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.TextBox nameTBox;
        private System.Windows.Forms.TextBox weightTBox;
        private System.Windows.Forms.Label weightTypeLbl;
        private System.Windows.Forms.Label weightLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateDataBtn;
        private System.Windows.Forms.Button updateProductBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ComboBox weightTypeCBox;
    }
}
