namespace StorePOS
{
    partial class SaleForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.orderItemGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.cbxProductList = new System.Windows.Forms.ComboBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.lblOrderTotalValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderItemGridView
            // 
            this.orderItemGridView.AllowUserToAddRows = false;
            this.orderItemGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderItemGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderItemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderItemGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ProductName,
            this.Quantity,
            this.Unit,
            this.Amount,
            this.Action});
            this.orderItemGridView.Location = new System.Drawing.Point(605, 56);
            this.orderItemGridView.MultiSelect = false;
            this.orderItemGridView.Name = "orderItemGridView";
            this.orderItemGridView.RowTemplate.Height = 24;
            this.orderItemGridView.Size = new System.Drawing.Size(803, 245);
            this.orderItemGridView.TabIndex = 0;
            this.orderItemGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderItemGridView_CellValueChanged);
            this.orderItemGridView.Click += new System.EventHandler(this.orderItemGridView_Click);
            // 
            // Id
            // 
            this.Id.HeaderText = "STT";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Tên thuốc";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Số lượng";
            this.Quantity.Name = "Quantity";
            // 
            // Unit
            // 
            this.Unit.HeaderText = "Đơn vị";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Thành tiền";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Action
            // 
            this.Action.HeaderText = "Thao tác";
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Text = "Xóa";
            this.Action.UseColumnTextForButtonValue = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddItem);
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Controls.Add(this.lblQuantity);
            this.panel1.Controls.Add(this.cbxProductList);
            this.panel1.Controls.Add(this.lblProductName);
            this.panel1.Location = new System.Drawing.Point(12, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 229);
            this.panel1.TabIndex = 1;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(198, 155);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(161, 48);
            this.btnAddItem.TabIndex = 4;
            this.btnAddItem.Text = "THÊM";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(198, 88);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(310, 26);
            this.txtQuantity.TabIndex = 3;
            this.txtQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQuantity.ValueChanged += new System.EventHandler(this.txtQuantity_ValueChanged);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(29, 93);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(68, 17);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Số lượng:";
            // 
            // cbxProductList
            // 
            this.cbxProductList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxProductList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxProductList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProductList.FormattingEnabled = true;
            this.cbxProductList.ItemHeight = 20;
            this.cbxProductList.Location = new System.Drawing.Point(198, 13);
            this.cbxProductList.Name = "cbxProductList";
            this.cbxProductList.Size = new System.Drawing.Size(310, 28);
            this.cbxProductList.TabIndex = 1;
            this.cbxProductList.SelectedIndexChanged += new System.EventHandler(this.cbxProductList_SelectedIndexChanged);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(29, 16);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(76, 17);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Tên thuốc:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblOrderTotalValue);
            this.panel2.Controls.Add(this.lblOrderTotal);
            this.panel2.Location = new System.Drawing.Point(605, 307);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(702, 137);
            this.panel2.TabIndex = 2;
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.AutoSize = true;
            this.lblOrderTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderTotal.Location = new System.Drawing.Point(397, 26);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(133, 29);
            this.lblOrderTotal.TabIndex = 0;
            this.lblOrderTotal.Text = "Tổng Tiền:";
            // 
            // lblOrderTotalValue
            // 
            this.lblOrderTotalValue.AutoSize = true;
            this.lblOrderTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderTotalValue.Location = new System.Drawing.Point(547, 26);
            this.lblOrderTotalValue.Name = "lblOrderTotalValue";
            this.lblOrderTotalValue.Size = new System.Drawing.Size(27, 29);
            this.lblOrderTotalValue.TabIndex = 2;
            this.lblOrderTotalValue.Text = "0";
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 781);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.orderItemGridView);
            this.Name = "SaleForm";
            this.Text = "Sale";
            this.Load += new System.EventHandler(this.SaleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderItemGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView orderItemGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.ComboBox cbxProductList;
        private System.Windows.Forms.NumericUpDown txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblOrderTotalValue;
        private System.Windows.Forms.Label lblOrderTotal;
    }
}

