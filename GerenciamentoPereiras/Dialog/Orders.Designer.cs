namespace GerenciamentoPereiras.Dialog
{
    partial class Orders
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            ordersList = new ListView();
            orderGrid = new DataGridView();
            totalOrder = new TextBox();
            totalLabel = new Label();
            ordersGroupLabel = new Label();
            orderLabel = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            ordersGroupList = new ListView();
            ((System.ComponentModel.ISupportInitialize)orderGrid).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // ordersList
            // 
            ordersList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ordersList.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ordersList.FullRowSelect = true;
            ordersList.HeaderStyle = ColumnHeaderStyle.None;
            ordersList.Location = new Point(8, 62);
            ordersList.Margin = new Padding(4);
            ordersList.MultiSelect = false;
            ordersList.Name = "ordersList";
            ordersList.Size = new Size(276, 676);
            ordersList.TabIndex = 2;
            ordersList.UseCompatibleStateImageBehavior = false;
            ordersList.View = View.List;
            ordersList.SelectedIndexChanged += ordersList_SelectedIndexChanged;
            // 
            // orderGrid
            // 
            orderGrid.AllowUserToAddRows = false;
            orderGrid.AllowUserToDeleteRows = false;
            orderGrid.AllowUserToResizeColumns = false;
            orderGrid.AllowUserToResizeRows = false;
            orderGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            orderGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            orderGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            orderGrid.BackgroundColor = Color.White;
            orderGrid.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            orderGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            orderGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            orderGrid.DefaultCellStyle = dataGridViewCellStyle1;
            orderGrid.EnableHeadersVisualStyles = false;
            orderGrid.Location = new Point(28, 62);
            orderGrid.Margin = new Padding(4);
            orderGrid.MultiSelect = false;
            orderGrid.Name = "orderGrid";
            orderGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            orderGrid.RowHeadersVisible = false;
            orderGrid.RowTemplate.Height = 25;
            orderGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            orderGrid.Size = new Size(956, 633);
            orderGrid.TabIndex = 2;
            // 
            // totalOrder
            // 
            totalOrder.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            totalOrder.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            totalOrder.Location = new Point(857, 741);
            totalOrder.Margin = new Padding(4);
            totalOrder.Name = "totalOrder";
            totalOrder.Size = new Size(128, 26);
            totalOrder.TabIndex = 2;
            // 
            // totalLabel
            // 
            totalLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            totalLabel.AutoSize = true;
            totalLabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            totalLabel.ForeColor = Color.White;
            totalLabel.Location = new Point(809, 719);
            totalLabel.Margin = new Padding(4, 0, 4, 0);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(46, 19);
            totalLabel.TabIndex = 2;
            totalLabel.Text = "Total";
            // 
            // ordersGroupLabel
            // 
            ordersGroupLabel.Anchor = AnchorStyles.Top;
            ordersGroupLabel.AutoSize = true;
            ordersGroupLabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ordersGroupLabel.ForeColor = Color.White;
            ordersGroupLabel.Location = new Point(122, 32);
            ordersGroupLabel.Margin = new Padding(4, 0, 4, 0);
            ordersGroupLabel.Name = "ordersGroupLabel";
            ordersGroupLabel.Size = new Size(44, 19);
            ordersGroupLabel.TabIndex = 2;
            ordersGroupLabel.Text = "Data";
            // 
            // orderLabel
            // 
            orderLabel.Anchor = AnchorStyles.Top;
            orderLabel.AutoSize = true;
            orderLabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            orderLabel.ForeColor = Color.White;
            orderLabel.Location = new Point(82, 36);
            orderLabel.Margin = new Padding(4, 0, 4, 0);
            orderLabel.Name = "orderLabel";
            orderLabel.Size = new Size(92, 19);
            orderLabel.TabIndex = 2;
            orderLabel.Text = "Comandas";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(ordersGroupLabel);
            panel1.Controls.Add(ordersGroupList);
            panel1.Location = new Point(4, 4);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(332, 783);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(orderLabel);
            panel2.Controls.Add(ordersList);
            panel2.Location = new Point(352, 0);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(288, 787);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(totalLabel);
            panel3.Controls.Add(totalOrder);
            panel3.Controls.Add(orderGrid);
            panel3.Location = new Point(651, 0);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(998, 787);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.Red;
            panel4.Controls.Add(panel2);
            panel4.Controls.Add(panel3);
            panel4.Controls.Add(panel1);
            panel4.Location = new Point(2, 1);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(1649, 797);
            panel4.TabIndex = 0;
            // 
            // ordersGroupList
            // 
            ordersGroupList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ordersGroupList.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ordersGroupList.FullRowSelect = true;
            ordersGroupList.HeaderStyle = ColumnHeaderStyle.None;
            ordersGroupList.Location = new Point(4, 58);
            ordersGroupList.Margin = new Padding(4);
            ordersGroupList.MultiSelect = false;
            ordersGroupList.Name = "ordersGroupList";
            ordersGroupList.Size = new Size(323, 676);
            ordersGroupList.TabIndex = 2;
            ordersGroupList.UseCompatibleStateImageBehavior = false;
            ordersGroupList.View = View.List;
            ordersGroupList.SelectedIndexChanged += ordersGroupList_SelectedIndexChanged;
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1651, 796);
            Controls.Add(panel4);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "Orders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Comandas";
            Load += Orders_Load;
            ((System.ComponentModel.ISupportInitialize)orderGrid).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ListView ordersList;
        private TextBox totalOrder;
        private Label totalLabel;
        private Label ordersGroupLabel;
        private Label orderLabel;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private DataGridView orderGrid;
        private ListView ordersGroupList;
    }
}