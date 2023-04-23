using GerenciamentoPereiras.Data;
using GerenciamentoPereiras.Models;
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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        private Context context;
        private int selectedOrderGroup;
        private int selectedOrder;
        public decimal orderTotal { get; set; }

        private void Orders_Load(object sender, EventArgs e)
        {
            SetOrderGroup();
            createProductOrdersGridList();
            createOrderList();
        }

        private void SetOrderGroup()
        {
            this.Enabled = false;
            context = new Context();
            var ordersGroup = context.OrdersGroups.ToList();
            ordersGroupList.View = View.Details;
            ordersGroupList.Columns.Add("Código");
            ordersGroupList.Columns.Add("Data");
            int listViewSize = int.Parse(ordersList.Width.ToString());
            ordersGroupList.Columns[0].Width = 0;
            ordersGroupList.Columns[1].Width = listViewSize;
            ordersGroupList.Columns[0].TextAlign = HorizontalAlignment.Center;
            ordersGroupList.Columns[1].TextAlign = HorizontalAlignment.Center;
            ListViewItem listViewItem1;


            foreach (OrdersGroup order in ordersGroup)
            {
                listViewItem1 = new ListViewItem(new string[] { order.Id.ToString(), order.OrdersGroupDate.ToShortDateString().ToString() }, -1);
                ordersGroupList.Items.Add(listViewItem1);
            }
            this.Enabled = true;
        }

        private void ordersGroupList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ordersGroupList.SelectedItems.Count > 0)
            {
                selectedOrderGroup = int.Parse(ordersGroupList.SelectedItems[0].Text);
                setOrders();
            }
        }

        private void setOrders()
        {
            this.Enabled = false;
            ordersList.Items.Clear();
            orderGrid.Rows.Clear();
            var orders = context.Orders.Where(x => x.ordersGroupId == selectedOrderGroup).ToList();
            int listViewSize = int.Parse(ordersList.Width.ToString());
            ordersList.Columns[0].Width = 0;
            ordersList.Columns[1].Width = (int)listViewSize;
            ordersList.Columns[0].TextAlign = HorizontalAlignment.Center;
            ordersList.Columns[1].TextAlign = HorizontalAlignment.Center;
            ListViewItem listViewItem1;


            foreach (Order order in orders)
            {
                listViewItem1 = new ListViewItem(new string[] { order.Id.ToString(), order.Name }, -1);
                ordersList.Items.Add(listViewItem1);
            }
            this.Enabled = true;
        }

        private void createOrderList()
        {
            ordersList.View = View.Details;
            ordersList.Columns.Add("Código");
            ordersList.Columns.Add("Nome");
        }

        private void createProductOrdersGridList()
        {
            orderGrid.ColumnCount = 3;
            orderGrid.Columns[0].Name = "Nome";
            orderGrid.Columns[1].Name = "Quantidade";
            orderGrid.Columns[2].Name = "Preço Unitário";


            foreach (DataGridViewColumn col in orderGrid.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }

            foreach (DataGridViewRow row in orderGrid.Rows)
            {
                row.DefaultCellStyle.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
                row.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }


            orderGrid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            orderGrid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            orderGrid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            orderGrid.Columns[0].ReadOnly = true;
            orderGrid.Columns[1].ReadOnly = true;
            orderGrid.Columns[2].ReadOnly = true;


            foreach (DataGridViewColumn column in orderGrid.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            orderGrid.ColumnHeadersDefaultCellStyle.SelectionBackColor = orderGrid.ColumnHeadersDefaultCellStyle.BackColor;
        }


        private void ordersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ordersList.SelectedItems.Count > 0)
            {
                selectedOrder = int.Parse(ordersList.SelectedItems[0].Text);
                setProductOrders();
            }
        }

        private void setProductOrders()

        {
            this.Enabled = false;

            orderGrid.Rows.Clear();
            if (orderGrid.Columns.Count > 0)
            {

                List<ProductOrder> productOrders = context.ProductOrders.Where(x => x.OrderId == selectedOrder).ToList();

                decimal total = 0;


                foreach (ProductOrder productOrder in productOrders)
                {
                    var product = context.Products.Where(x => x.Id == productOrder.ProductId).Single();


                    var row1 = new DataGridViewRow();
                    row1.Cells.Add(new DataGridViewTextBoxCell { Value = product.Name });
                    row1.Cells.Add(new DataGridViewTextBoxCell { Value = productOrder.Amount.ToString() });
                    row1.Cells.Add(new DataGridViewTextBoxCell { Value = productOrder.ValuePerItem.ToString() });
                    orderGrid.Rows.Add(row1);

                    total += (decimal)(productOrder.Amount * productOrder.ValuePerItem);
                }
                orderTotal = total;

                totalOrder.Text = "R$  " + orderTotal.ToString();
            }
            if (orderGrid.Rows.Count > 0)
            {
                orderGrid.Rows[0].Selected = false;
            }
            this.Enabled = true;
        }
    }
}
