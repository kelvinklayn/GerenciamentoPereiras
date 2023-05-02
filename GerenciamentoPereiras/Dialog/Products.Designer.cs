namespace GerenciamentoPereiras.Dialog
{
    partial class Products
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            categoryFilterCombo = new ComboBox();
            productFilterText = new TextBox();
            productFilterLabel = new Label();
            categoryFilterLabel = new Label();
            productsGrid = new DataGridView();
            productsLabel = new Label();
            newProductButton = new Button();
            ((System.ComponentModel.ISupportInitialize)productsGrid).BeginInit();
            SuspendLayout();
            // 
            // categoryFilterCombo
            // 
            categoryFilterCombo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            categoryFilterCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryFilterCombo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            categoryFilterCombo.FormattingEnabled = true;
            categoryFilterCombo.Location = new Point(610, 48);
            categoryFilterCombo.Name = "categoryFilterCombo";
            categoryFilterCombo.Size = new Size(176, 29);
            categoryFilterCombo.TabIndex = 0;
            categoryFilterCombo.SelectedIndexChanged += categoryFilterCombo_SelectedIndexChanged;
            // 
            // productFilterText
            // 
            productFilterText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            productFilterText.Location = new Point(12, 48);
            productFilterText.Name = "productFilterText";
            productFilterText.Size = new Size(154, 29);
            productFilterText.TabIndex = 1;
            // 
            // productFilterLabel
            // 
            productFilterLabel.AutoSize = true;
            productFilterLabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            productFilterLabel.Location = new Point(12, 23);
            productFilterLabel.Name = "productFilterLabel";
            productFilterLabel.Size = new Size(144, 19);
            productFilterLabel.TabIndex = 2;
            productFilterLabel.Text = "Nome do Produto";
            // 
            // categoryFilterLabel
            // 
            categoryFilterLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            categoryFilterLabel.AutoSize = true;
            categoryFilterLabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            categoryFilterLabel.Location = new Point(612, 23);
            categoryFilterLabel.Name = "categoryFilterLabel";
            categoryFilterLabel.Size = new Size(173, 19);
            categoryFilterLabel.TabIndex = 3;
            categoryFilterLabel.Text = "Categoria do Produto";
            // 
            // productsGrid
            // 
            productsGrid.AllowUserToAddRows = false;
            productsGrid.AllowUserToDeleteRows = false;
            productsGrid.AllowUserToResizeColumns = false;
            productsGrid.AllowUserToResizeRows = false;
            productsGrid.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            productsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productsGrid.BackgroundColor = Color.White;
            productsGrid.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            productsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            productsGrid.DefaultCellStyle = dataGridViewCellStyle1;
            productsGrid.Location = new Point(12, 107);
            productsGrid.MultiSelect = false;
            productsGrid.Name = "productsGrid";
            productsGrid.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            productsGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            productsGrid.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            productsGrid.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            productsGrid.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            productsGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Black;
            productsGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            productsGrid.RowTemplate.Height = 25;
            productsGrid.SelectionMode = DataGridViewSelectionMode.CellSelect;
            productsGrid.Size = new Size(774, 331);
            productsGrid.TabIndex = 4;
            productsGrid.CellClick += productsGrid_CellClick;
            // 
            // productsLabel
            // 
            productsLabel.Anchor = AnchorStyles.Top;
            productsLabel.AutoSize = true;
            productsLabel.Font = new Font("Arial Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            productsLabel.Location = new Point(323, 38);
            productsLabel.Name = "productsLabel";
            productsLabel.Size = new Size(150, 38);
            productsLabel.TabIndex = 5;
            productsLabel.Text = "Produtos";
            // 
            // newProductButton
            // 
            newProductButton.BackColor = Color.Black;
            newProductButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            newProductButton.ForeColor = Color.White;
            newProductButton.Location = new Point(192, 23);
            newProductButton.Name = "newProductButton";
            newProductButton.Size = new Size(86, 63);
            newProductButton.TabIndex = 6;
            newProductButton.Text = "Novo Produto";
            newProductButton.UseVisualStyleBackColor = false;
            newProductButton.Click += newProductButton_Click;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(800, 450);
            Controls.Add(newProductButton);
            Controls.Add(productsLabel);
            Controls.Add(productsGrid);
            Controls.Add(categoryFilterLabel);
            Controls.Add(productFilterLabel);
            Controls.Add(productFilterText);
            Controls.Add(categoryFilterCombo);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Products";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Produtos";
            Shown += products_Shown;
            ((System.ComponentModel.ISupportInitialize)productsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private ComboBox categoryFilterCombo;
        private TextBox productFilterText;
        private Label productFilterLabel;
        private Label categoryFilterLabel;
        private DataGridView productsGrid;
        private Label productsLabel;
        private Button newProductButton;
    }
}