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
            txtQuantity.Value = 0;
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
    }
}
