using GerenciamentoPereiras.Data;
using GerenciamentoPereiras.Dialog;
using GerenciamentoPereiras.Models;


namespace GerenciamentoPereiras
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();

        }

        private decimal orderTotal { get; set; }
        private OrdersGroup ordersGroup;
        private int selectedOrderId;
        private bool isSystemActive = false;
        Context context = new Context();


        private void Form1_Load(object sender, EventArgs e)
        {
            isActiveImg.Image = Properties.Resources.switch_off;
            productOrdersGrid.Resize += new EventHandler(productOrdersListView_Resize);
            clientsList.Resize += new EventHandler(clientsList_Resize);
            SetClients();
            createProductOrdersGridList();
            setProductOrders();
            productOrdersGrid.SelectionChanged += new EventHandler(productOrdersGrid_SelectionChanged);
            productOrdersGrid.CellClick += new DataGridViewCellEventHandler(productOrdersGrid_cellClicked);
            clientsList.SelectedIndexChanged += new EventHandler(clientsList_SelectedIndexChanged);

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            clientsList.Select();
            clientsList.Focus();
            if (productOrdersGrid.Rows.Count > 0)
            {
                productOrdersGrid.Rows[0].Selected = false;
            }
        }

        private void productOrdersGrid_cellClicked(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == 2 || e.ColumnIndex == 4 || e.ColumnIndex == 6) && e.RowIndex >= 0)
            {
                int seletedProductId = int.Parse(productOrdersGrid[0, e.RowIndex].Value.ToString());
                var selectedProductOrder = context.ProductOrders.Where(x => x.OrderId == selectedOrderId && x.Id == seletedProductId).Single();
                if (e.ColumnIndex == 2)
                {
                    if (selectedProductOrder.Amount > 1)
                    {
                        selectedProductOrder.Amount--;
                    }

                }
                else if (e.ColumnIndex == 4)
                {
                    selectedProductOrder.Amount++;
                }
                else
                {
                    context.ProductOrders.Remove(selectedProductOrder);
                }
                context.SaveChanges();
                productOrdersGrid.Rows.Clear();
                setProductOrders();
            }

        }

        private void productOrdersGrid_SelectionChanged(object sender, EventArgs e)

        {
            if (productOrdersGrid.CurrentCell.ColumnIndex != 2 && productOrdersGrid.CurrentCell.ColumnIndex != 4 && productOrdersGrid.CurrentCell.ColumnIndex != 6)
            {
                productOrdersGrid.CurrentCell.Selected = false;
            }

        }

        private void SetClients()
        {
            this.Enabled = false;
            var orders = context.Orders.Where(x => x.IsOpen == true).ToList();
            clientsList.View = View.Details;
            clientsList.Columns.Add("Código");
            clientsList.Columns.Add("Nome");
            int listViewSize = int.Parse(clientsList.Width.ToString());
            clientsList.Columns[0].Width = 0;
            clientsList.Columns[1].Width = listViewSize;
            clientsList.Columns[0].TextAlign = HorizontalAlignment.Center;
            clientsList.Columns[1].TextAlign = HorizontalAlignment.Center;
            ListViewItem listViewItem1;


            foreach (Order order in orders)
            {
                listViewItem1 = new ListViewItem(new string[] { order.Id.ToString(), order.Name }, -1);
                clientsList.Items.Add(listViewItem1);
            }
            var totalClients = clientsList.Items.Count;
            if (totalClients > 0)
            {
                clientsList.Items[totalClients - 1].Selected = true;
            }
            this.Enabled = true;
        }

        private void productOrdersListView_Resize(object sender, EventArgs e)
        {
            int listViewSize = int.Parse(productOrdersGrid.Width.ToString());
            productOrdersGrid.Columns[1].Width = (int)(listViewSize * 0.55);
            productOrdersGrid.Columns[2].Width = (int)(listViewSize * 0.05);
            productOrdersGrid.Columns[3].Width = (int)(listViewSize * 0.1);
            productOrdersGrid.Columns[4].Width = (int)(listViewSize * 0.05);
            productOrdersGrid.Columns[5].Width = (int)(listViewSize * 0.15);
            productOrdersGrid.Columns[6].Width = (int)(listViewSize * 0.1);

        }

        private void clientsList_Resize(object sender, EventArgs e)
        {
            int listViewSize = int.Parse(clientsList.Width.ToString());
            clientsList.Columns[1].Width = listViewSize;

        }

        private void createProductOrdersGridList()
        {
            productOrdersGrid.ColumnCount = 7;
            productOrdersGrid.Columns[0].Name = "Codigo";
            productOrdersGrid.Columns[1].Name = "Nome";
            productOrdersGrid.Columns[2].Name = "";
            productOrdersGrid.Columns[3].Name = "Quantidade";
            productOrdersGrid.Columns[4].Name = "";
            productOrdersGrid.Columns[5].Name = "Preço Unitário";


            foreach (DataGridViewColumn col in productOrdersGrid.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }

            foreach (DataGridViewRow row in productOrdersGrid.Rows)
            {
                row.DefaultCellStyle.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
                row.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }

            int listViewSize = int.Parse(productOrdersGrid.Width.ToString());
            productOrdersGrid.Columns[0].Visible = false;
            productOrdersGrid.Columns[1].Width = (int)(listViewSize * 0.55);
            productOrdersGrid.Columns[2].Width = (int)(listViewSize * 0.05);
            productOrdersGrid.Columns[3].Width = (int)(listViewSize * 0.1);
            productOrdersGrid.Columns[4].Width = (int)(listViewSize * 0.05);
            productOrdersGrid.Columns[5].Width = (int)(listViewSize * 0.15);
            productOrdersGrid.Columns[6].Width = (int)(listViewSize * 0.1);


            productOrdersGrid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            productOrdersGrid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            productOrdersGrid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            productOrdersGrid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            productOrdersGrid.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            productOrdersGrid.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            productOrdersGrid.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            productOrdersGrid.Columns[0].ReadOnly = true;
            productOrdersGrid.Columns[1].ReadOnly = true;
            productOrdersGrid.Columns[2].ReadOnly = true;
            productOrdersGrid.Columns[3].ReadOnly = true;
            productOrdersGrid.Columns[4].ReadOnly = true;
            productOrdersGrid.Columns[5].ReadOnly = true;
            productOrdersGrid.Columns[6].ReadOnly = true;


            foreach (DataGridViewColumn column in productOrdersGrid.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void setProductOrders()

        {
            this.Enabled = false;

            if (productOrdersGrid.Columns.Count > 0)
            {

                List<ProductOrder> productOrders = context.ProductOrders.Where(x => x.OrderId == selectedOrderId).ToList();

                var products = context.Products.ToList();

                decimal total = 0;


                foreach (ProductOrder productOrder in productOrders)
                {
                    var product = products.Where(x => x.Id == productOrder.ProductId).FirstOrDefault();


                    DataGridViewRow row = new DataGridViewRow();

                    Bitmap Image1;
                    Image1 = new Bitmap(Properties.Resources.bin);

                    var img = new DataGridViewImageCell { Value = Image1 };

                    var row1 = new DataGridViewRow();
                    row1.Cells.Add(new DataGridViewTextBoxCell { Value = productOrder.Id.ToString() });
                    row1.Cells.Add(new DataGridViewTextBoxCell { Value = product.Name });
                    row1.Cells.Add(new DataGridViewTextBoxCell { Value = "-" });
                    row1.Cells.Add(new DataGridViewTextBoxCell { Value = productOrder.Amount.ToString() });
                    row1.Cells.Add(new DataGridViewTextBoxCell { Value = "+" });
                    row1.Cells.Add(new DataGridViewTextBoxCell { Value = productOrder.ValuePerItem.ToString() });
                    row1.Cells.Add((DataGridViewImageCell)img);
                    row1.Height = 80;
                    productOrdersGrid.Rows.Add(row1);

                    total += (decimal)(productOrder.Amount * productOrder.ValuePerItem);
                }
                orderTotal = total;

                totalOrder.Text = "R$  " + orderTotal.ToString();
            }
            this.Enabled = true;
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            AddClients AddClients;
            AddClients = new AddClients(ordersGroup.Id);
            AddClients.FormClosed += new FormClosedEventHandler(AddClients_Closed);
            AddClients.Show();
        }

        private void AddClients_Closed(object sender, FormClosedEventArgs e)
        {
            clientsList.Clear();
            SetClients();
            ChangeProductsOrderGrid();
        }


        private void productsButton_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.Show();
        }

        private AddProducts AddProducts;

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            string selectedItemText = (clientsList.SelectedItems[0].Text);
            selectedOrderId = Int32.Parse(selectedItemText);

            AddProducts = new AddProducts(selectedOrderId);
            AddProducts.FormClosed += new FormClosedEventHandler(addProduct_closed);
            AddProducts.Show();
        }

        private void addProduct_closed(object sender, FormClosedEventArgs e)
        {
            productOrdersGrid.Rows.Clear();
            setProductOrders();
        }

        private void isActive_Click(object sender, EventArgs e)
        {
            isSystemActive = !isSystemActive;
            LoadNewPict();
            isAddClientEnable();
        }

        private void isAddClientEnable()
        {
            addClient.Visible = isSystemActive;
            AddProductButton.Visible = isSystemActive;
        }

        private void LoadNewPict()
        {
            if (isSystemActive)
            {
                isActiveImg.Image = Properties.Resources.switch_on;
                ordersGroup = new OrdersGroup();
                context.OrdersGroups.Add(ordersGroup);
                context.SaveChanges();
                return;
            }
            isActiveImg.Image = Properties.Resources.switch_off;
        }

        private void finishOrderButton_Click(object sender, EventArgs e)
        {
            Order finishedOrder = (Order)context.Orders.Where(x => x.Id == selectedOrderId).First();
            finishedOrder.IsOpen = false;
            context.SaveChanges();
            clientsList.Clear();
            SetClients();
            ChangeProductsOrderGrid();

        }

        private void clientsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeProductsOrderGrid();
        }

        private void ChangeProductsOrderGrid()
        {
            if (clientsList.SelectedItems.Count > 0)
            {
                var selectedItemText = clientsList.SelectedItems[0].Text;
                selectedOrderId = Int32.Parse(selectedItemText);
                productOrdersGrid.Rows.Clear();
                setProductOrders();
            }
        }

        private void ordersButton_Click(object sender, EventArgs e)
        {
            Orders orders = new();
            orders.Show();
        }
    }
}