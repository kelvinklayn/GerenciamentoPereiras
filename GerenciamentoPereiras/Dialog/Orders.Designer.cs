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
            ordersGroupList = new ListView();
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
            ((System.ComponentModel.ISupportInitialize)orderGrid).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // ordersGroupList
            // 
            ordersGroupList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ordersGroupList.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ordersGroupList.FullRowSelect = true;
            ordersGroupList.Location = new Point(3, 49);
            ordersGroupList.MultiSelect = false;
            ordersGroupList.Name = "ordersGroupList";
            ordersGroupList.Size = new Size(252, 624);
            ordersGroupList.TabIndex = 2;
            ordersGroupList.UseCompatibleStateImageBehavior = false;
            ordersGroupList.View = View.List;
            ordersGroupList.SelectedIndexChanged += ordersGroupList_SelectedIndexChanged;
            // 
            // ordersList
            // 
            ordersList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ordersList.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ordersList.FullRowSelect = true;
            ordersList.Location = new Point(6, 52);
            ordersList.MultiSelect = false;
            ordersList.Name = "ordersList";
            ordersList.Size = new Size(215, 624);
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
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            orderGrid.DefaultCellStyle = dataGridViewCellStyle1;
            orderGrid.EnableHeadersVisualStyles = false;
            orderGrid.Location = new Point(22, 52);
            orderGrid.MultiSelect = false;
            orderGrid.Name = "orderGrid";
            orderGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            orderGrid.RowHeadersVisible = false;
            orderGrid.RowTemplate.Height = 25;
            orderGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            orderGrid.Size = new Size(743, 564);
            orderGrid.TabIndex = 2;
            // 
            // totalOrder
            // 
            totalOrder.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            totalOrder.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            totalOrder.Location = new Point(660, 643);
            totalOrder.Name = "totalOrder";
            totalOrder.Size = new Size(100, 26);
            totalOrder.TabIndex = 2;
            // 
            // totalLabel
            // 
            totalLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            totalLabel.AutoSize = true;
            totalLabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            totalLabel.ForeColor = Color.White;
            totalLabel.Location = new Point(618, 619);
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
            ordersGroupLabel.Location = new Point(96, 10);
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
            orderLabel.Location = new Point(69, 13);
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
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(258, 689);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(orderLabel);
            panel2.Controls.Add(ordersList);
            panel2.Location = new Point(267, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(224, 692);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(totalLabel);
            panel3.Controls.Add(totalOrder);
            panel3.Controls.Add(orderGrid);
            panel3.Location = new Point(494, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(776, 692);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.Red;
            panel4.Controls.Add(panel2);
            panel4.Controls.Add(panel3);
            panel4.Controls.Add(panel1);
            panel4.Location = new Point(12, 9);
            panel4.Name = "panel4";
            panel4.Size = new Size(1270, 700);
            panel4.TabIndex = 0;
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 707);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
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

        private ListView ordersGroupList;
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
    }
}