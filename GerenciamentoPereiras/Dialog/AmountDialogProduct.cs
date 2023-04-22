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
    public partial class AmountDialogProduct : Form
    {
        public AmountDialogProduct()
        {
            InitializeComponent();
        }

        public int productAmount { get; set; }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            productAmount = int.Parse(amountProductSelector.Value.ToString());
        }
    }
}
