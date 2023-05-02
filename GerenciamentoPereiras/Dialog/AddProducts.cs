using GerenciamentoPereiras.Data;
using GerenciamentoPereiras.Models;
using GerenciamentoPereiras.Utils;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GerenciamentoPereiras.Dialog
{
    public partial class AddProducts : Form
    {
        public AddProducts(int orderIdNo)
        {
            InitializeComponent();
            orderId = orderIdNo;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            categoryCombo.DataSource = Enum.GetValues(typeof(Category));
            CreateProductsList();
            SetProducts();
            productsGrid.SelectionChanged += new EventHandler(
            productsGrid_SelectionChanged);
            filterText.TextChanged += new EventHandler(filterText_textChanged);

        }

        Context context = new Context();

        private int orderId { get; set; }

        private int amount { get; set; }

        private Category categoryFilter = Category.Todas;

        private string textFilter = "";

        private int selectedProductId;

        private void CreateProductsList()
        {
            productsGrid.ColumnCount = 4;
            productsGrid.Columns[0].Name = "Codigo do Produto";
            productsGrid.Columns[0].Visible = false;
            productsGrid.Columns[1].Name = "Nome do Produto";
            productsGrid.Columns[2].Name = "Categoria do Produto";
            productsGrid.Columns[3].Name = "Preço do Produto";

            productsGrid.Columns[0].ReadOnly = true;
            productsGrid.Columns[1].ReadOnly = true;
            productsGrid.Columns[2].ReadOnly = true;
            productsGrid.Columns[3].ReadOnly = true;

            productsGrid.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            productsGrid.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            productsGrid.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            productsGrid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            productsGrid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            productsGrid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn column in productsGrid.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void SetProducts()
        {
            this.Enabled = false;

            if (productsGrid.Columns.Count > 0)
            {
                productsGrid.Rows.Clear();
                List<Product> products = new List<Product>();

                if (!(textFilter.Length > 0))
                {
                    if (categoryFilter == Category.Todas)
                    {
                        products = context.Products.ToList();
                    }
                    else
                    {
                        products = context.Products.Where(x => x.Category == categoryFilter).ToList();
                    }
                }
                else
                {
                    if (categoryFilter == Category.Todas)
                    {
                        products = context.Products.Where(x => x.Name.ToLower().Contains(textFilter.ToLower())).ToList();
                    }
                    else
                    {
                        products = context.Products.Where(x => x.Category == categoryFilter && x.Name.ToLower().Contains(textFilter.ToLower())).ToList();
                    }

                }

                foreach (var product in products)
                {
                    string[] row = new string[] { product.Id.ToString(), product.Name, product.Category.ToString(), "R$ " + product.Price.ToString() };
                    productsGrid.Rows.Add(row);
                }

                productsGrid.EnableHeadersVisualStyles = false;
                productsGrid.ColumnHeadersDefaultCellStyle.SelectionBackColor = productsGrid.ColumnHeadersDefaultCellStyle.BackColor;
                if (productsGrid.SelectedRows.Count > 0)
                {
                    selectedProductId = int.Parse((productsGrid.SelectedRows[0].Cells[0].Value).ToString());
                }
            }

            this.Enabled = true;
        }

        private void filterText_textChanged(object sender, EventArgs e)
        {
            textFilter = filterText.Text;
            SetProducts();
        }

        private void addProduct_Click(object sender, EventArgs e)
        {

            using (var amountDialogProduct = new AmountDialogProduct())
            {
                var result = amountDialogProduct.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var product = context.Products.Where(x => x.Id == selectedProductId).Single();
                    var order = context.Orders.Where(x => x.Id == orderId).Single();
                    amount = amountDialogProduct.productAmount;
                    ProductOrder productOrder = new ProductOrder(selectedProductId, order.Id, amount, product.Price, order.CreatedAt);
                    context.ProductOrders.Add(productOrder);
                    context.SaveChanges();
                }

            }

        }

        private void productsGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (productsGrid.SelectedRows.Count > 0)
            {
                selectedProductId = int.Parse(productsGrid.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void categoryCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (categoryCombo.SelectedIndex)
            {
                case 0:
                    categoryFilter = Category.Todas;
                    break;
                case 1:
                    categoryFilter = Category.Lanche;
                    break;
                case 2:
                    categoryFilter = Category.Bebida;
                    break;
                case 3:
                    categoryFilter = Category.Suco;
                    break;
                case 4:
                    categoryFilter = Category.Porção;
                    break;
                case 5:
                    categoryFilter = Category.Adicional;
                    break;
            }
            SetProducts();
        }
    }
}
