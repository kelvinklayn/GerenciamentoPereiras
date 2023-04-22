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
    public partial class AddClients : Form
    {

        public AddClients(int ordersGroupNo)
        {
            InitializeComponent();
            ordersGroupId = ordersGroupNo;
            ordersGroupIdNo.Text = ordersGroupId.ToString();
        }

        public int ordersGroupId { get; set; }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            Context context = new Context();
            OrdersGroup ordersGroup = (OrdersGroup)context.OrdersGroups.Where(x => x.Id == ordersGroupId).First();
            Order order = new Order(clientNameTextBox.Text.ToString(), ordersGroupId, ordersGroup.OrdersGroupDate);
            context.Orders.Add(order);
            context.SaveChanges();
            this.Close();
        }
    }
}
