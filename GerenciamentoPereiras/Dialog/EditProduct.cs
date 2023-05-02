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
    public partial class EditProduct : Form
    {
        public EditProduct(int productId, string productName, Category category, decimal productPrice)
        {
            InitializeComponent();
            idProduct = productId;

            nameProductText.Text = productName;
            priceProductText.Text = productPrice.ToString();
            productCategoryCombo.DataSource = Enum.GetValues(typeof(Category));
            productCategoryCombo.SelectedItem = category;
        }

        public EditProduct()
        {
            InitializeComponent();
            productCategoryCombo.DataSource = Enum.GetValues(typeof(Category));
        }

        public Context context = new Context();
        private int idProduct { get; set; }
        private string nameProduct { get; set; }

        private Category categoryProduct { get; set; }

        private decimal priceProduct { get; set; }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            nameProduct = nameProductText.Text;
            string price = (priceProductText.Text).Substring(3);
            priceProduct = decimal.Parse(price);
            categoryProduct = (Category)Enum.Parse(typeof(Category), productCategoryCombo.Text);

            if (idProduct != 0)
            {
                Product product = context.Products.Where(x => x.Id == idProduct).Single();
                product.Name = nameProduct;
                product.Price = priceProduct;
                product.Category = categoryProduct;
            }
            else
            {
                Product product = new Product(nameProduct, categoryProduct, priceProduct);
                context.Products.Add(product);
            }

            context.SaveChanges();
            this.Close();
        }
    }
}
