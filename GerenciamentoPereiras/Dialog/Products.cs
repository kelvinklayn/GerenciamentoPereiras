using GerenciamentoPereiras.Data;
using GerenciamentoPereiras.Models;
using GerenciamentoPereiras.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoPereiras.Dialog
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        public string textFilter = "";
        private Category categoryFilter = Category.Todas;
        Context context;


        protected override void OnLoad(EventArgs e)
        {
            categoryFilterCombo.DataSource = Enum.GetValues(typeof(Category));
            CreateProductsList();
            productFilterText.TextChanged += new EventHandler(productFilterText_textChanged);
            SetProducts();
            productsGrid.SelectionChanged += new EventHandler(productGrid_SelectionChanged);
        }

        private void productGrid_SelectionChanged(object sender, EventArgs e)

        {
            if (productsGrid.CurrentCell.ColumnIndex != 4)
            {
                productsGrid.CurrentCell.Selected = false;
            }

        }

        private void products_Shown(object sender, EventArgs e)
        {
            productFilterText.Select();
            productFilterText.Focus();
            productsGrid.Rows[0].Selected = false;
        }

        private void CreateProductsList()
        {
            productsGrid.ColumnCount = 5;
            productsGrid.Columns[0].Name = "Codigo do Produto";
            productsGrid.Columns[1].Name = "Nome do Produto";
            productsGrid.Columns[2].Name = "Categoria do Produto";
            productsGrid.Columns[3].Name = "Preço do Produto";

            productsGrid.Columns[0].ReadOnly = true;
            productsGrid.Columns[1].ReadOnly = true;
            productsGrid.Columns[2].ReadOnly = true;
            productsGrid.Columns[3].ReadOnly = true;
            productsGrid.Columns[4].ReadOnly = true;

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

            context = new Context();

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
                    DataGridViewRow row = new DataGridViewRow();

                    Bitmap Image1;
                    Image1 = new Bitmap(Properties.Resources.edit);

                    var img = new DataGridViewImageCell { Value = Image1 };

                    var row1 = new DataGridViewRow();
                    row1.Cells.Add(new DataGridViewTextBoxCell { Value = product.Id.ToString() });
                    row1.Cells.Add(new DataGridViewTextBoxCell { Value = product.Name });
                    row1.Cells.Add(new DataGridViewTextBoxCell { Value = product.Category.ToString() });
                    row1.Cells.Add(new DataGridViewTextBoxCell { Value = "R$ " + product.Price.ToString() });

                    row1.Cells.Add((DataGridViewImageCell)img);
                    row1.Height = 80;
                    productsGrid.Rows.Add(row1);
                }

                productsGrid.EnableHeadersVisualStyles = false;
                productsGrid.ColumnHeadersDefaultCellStyle.SelectionBackColor = productsGrid.ColumnHeadersDefaultCellStyle.BackColor;
            }

            if (productsGrid.Rows.Count > 0)
            {
                productsGrid.Rows[0].Cells[0].Selected = false;
            }

            this.Enabled = true;
        }

        private void productFilterText_textChanged(object sender, EventArgs e)
        {
            textFilter = productFilterText.Text;
            SetProducts();
        }

        private void categoryFilterCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (categoryFilterCombo.SelectedIndex)
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
            }
            SetProducts();
        }

        private void productsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == 4) && productsGrid.SelectedCells.Count > 0)
            {
                var rowIndex = e.RowIndex;
                productsGrid.Rows[0].Selected = false;
                int productId = int.Parse(productsGrid.Rows[rowIndex].Cells[0].Value.ToString());
                Product product = context.Products.Where(x => x.Id == productId).Single();
                EditProduct editProduct = new EditProduct(productId, product.Name, product.Category, product.Price);
                editProduct.Show();
                editProduct.FormClosed += new FormClosedEventHandler(editProduct_Closing);
            }
        }

        private void editProduct_Closing(object sender, FormClosedEventArgs e)
        {
            productsGrid.Rows.Clear();
            SetProducts();
        }
    }
}
