using StorePOS.Extensions;
using StorePOS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace StorePOS
{
    public partial class SaleForm : Form
    {
        private int _currentProductId = 0;
        private Order _order;
        private Product[] _products;

        public SaleForm()
        {
            InitializeComponent();
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {
            _order = new Order();

            InitializeProductListCombobox();

            ValidateForm();
        }

        private void InitializeProductListCombobox()
        {
            _products = new Product[]
            {
                new Product(1, "ABC", 10, "Cai"),
                new Product(2, "ABC1", 10, "Cai"),
                new Product(3, "XYZ", 10, "Cai")
            };

            cbxProductList.Items.AddRange(_products);
        }

        private void cbxProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxProductList.SelectedItem == null)
            {
                _currentProductId = 0;
            }
            else
            {
                var product = (Product)cbxProductList.SelectedItem;
                _currentProductId = product.Id;
            }

            ValidateForm();
        }

        private bool ValidateForm()
        {
            var isValid = _currentProductId > 0 && (int)txtQuantity.Value > 0;
            btnAddItem.Enabled = isValid;

            return isValid;
        }

        private void ClearForm()
        {
            _currentProductId = 0;
            txtQuantity.Value = 1;
            cbxProductList.SelectedItem = null;

            ValidateForm();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            var product = _products.First(p => p.Id == _currentProductId);
            var quantity = (int)txtQuantity.Value;
            var orderItem = new OrderItem(product, quantity);
            var addedItem = _order.AddItem(orderItem);

            var isAddNew = addedItem.Quantity == quantity;
            if (isAddNew)
            {
                AddNewRowGridView(orderItem);
            }
            else
            {
                UpdateRowGridView(orderItem);
            }

            UpdateOrderTotalAmount();

            ClearForm();
        }

        private void AddNewRowGridView(OrderItem item)
        {
            var index = orderItemGridView.Rows.Add();
            orderItemGridView.Rows[index].Cells[1].Value = item.Product.Name;
            orderItemGridView.Rows[index].Cells[2].Value = item.Quantity;
            orderItemGridView.Rows[index].Cells[3].Value = item.Product.Unit;
            orderItemGridView.Rows[index].Cells[4].Value = item.GetAmount();

            int idx = 0;
            foreach (DataGridViewRow r in orderItemGridView.Rows)
            {
                idx++;
                r.Cells[0].Value = idx;
            }
        }

        private void UpdateRowGridView(OrderItem item)
        {
            foreach (DataGridViewRow row in orderItemGridView.Rows)
            {
                if ((string)row.Cells[1].Value == item.Product.Name)
                {
                    row.Cells[2].Value = item.Quantity;
                    row.Cells[4].Value = item.GetAmount();
                    break;
                }
            }
        }

        private void txtQuantity_ValueChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void orderItemGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (orderItemGridView.CurrentCell != null && orderItemGridView.CurrentCell.ColumnIndex == 2)
            {
                var sQuantity = (string)orderItemGridView.CurrentCell.Value;
                if (!IsValidNumber(sQuantity))
                {
                    MessageBox.Show("Số lượng phải là một số lớn hơn 0.");
                    return;
                }

                var row = orderItemGridView.Rows[orderItemGridView.CurrentCell.RowIndex];
                var product = GetProduct();

                var orderItem = _order.Items.First(i => i.Product.Id == product.Id);
                orderItem.Quantity = Int32.Parse(sQuantity);
                row.Cells[4].Value = orderItem.GetAmount();
                _order.CaculateTotalAmount();

                UpdateOrderTotalAmount();
            }
        }

        private void orderItemGridView_Click(object sender, EventArgs e)
        {
            if (orderItemGridView.CurrentCell.ColumnIndex == orderItemGridView.Columns["Action"].Index)
            {
                var confirm = MessageBox.Show("Bạn có thực sự muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    var product = GetProduct();
                    _order.RemoveItem(product.Id);
                    UpdateOrderTotalAmount();
                    orderItemGridView.Rows.RemoveAt(orderItemGridView.CurrentCell.RowIndex);
                }
            }
        }

        private void UpdateOrderTotalAmount()
        {
            lblOrderTotalValue.Text = string.Format("{0:n0}", _order.TotalAmount);
        }

        private Product GetProduct()
        {
            var row = orderItemGridView.Rows[orderItemGridView.CurrentCell.RowIndex];
            var productName = (string)row.Cells[1].Value;
            var product = _products.First(p => p.Name == productName);

            return product;
        }

        private bool IsValidNumber(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return false;
            }

            int num;

            if (int.TryParse(value, out num) && num > 0)
            {
                return true;
            }

            return false;
        }
    }
}
