namespace GerenciamentoPereiras.Dialog
{
    partial class AddProducts
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
            filterText = new TextBox();
            categoryCombo = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            productsGrid = new DataGridView();
            addProduct = new Button();
            ((System.ComponentModel.ISupportInitialize)productsGrid).BeginInit();
            SuspendLayout();
            // 
            // filterText
            // 
            filterText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            filterText.Location = new Point(31, 48);
            filterText.Name = "filterText";
            filterText.Size = new Size(242, 29);
            filterText.TabIndex = 0;
            // 
            // categoryCombo
            // 
            categoryCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryCombo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            categoryCombo.FormattingEnabled = true;
            categoryCombo.Location = new Point(602, 48);
            categoryCombo.Name = "categoryCombo";
            categoryCombo.Size = new Size(186, 23);
            categoryCombo.TabIndex = 1;
            categoryCombo.SelectedIndexChanged += categoryCombo_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(242, 23);
            label1.TabIndex = 2;
            label1.Text = "Digite o nome do Produto";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(567, 21);
            label3.Name = "label3";
            label3.Size = new Size(147, 23);
            label3.TabIndex = 4;
            label3.Text = "Categorias";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // productsGrid
            // 
            productsGrid.AllowUserToAddRows = false;
            productsGrid.AllowUserToDeleteRows = false;
            productsGrid.AllowUserToResizeColumns = false;
            productsGrid.AllowUserToResizeRows = false;
            productsGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            productsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productsGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            productsGrid.BackgroundColor = Color.White;
            productsGrid.CausesValidation = false;
            productsGrid.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            productsGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            productsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            productsGrid.DefaultCellStyle = dataGridViewCellStyle1;
            productsGrid.EnableHeadersVisualStyles = false;
            productsGrid.GridColor = Color.White;
            productsGrid.Location = new Point(12, 109);
            productsGrid.MultiSelect = false;
            productsGrid.Name = "productsGrid";
            productsGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            productsGrid.RowHeadersVisible = false;
            productsGrid.RowTemplate.Height = 25;
            productsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productsGrid.ShowEditingIcon = false;
            productsGrid.Size = new Size(776, 285);
            productsGrid.TabIndex = 5;
            // 
            // addProduct
            // 
            addProduct.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addProduct.BackColor = Color.Black;
            addProduct.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addProduct.ForeColor = Color.White;
            addProduct.Location = new Point(673, 400);
            addProduct.Name = "addProduct";
            addProduct.Size = new Size(115, 51);
            addProduct.TabIndex = 6;
            addProduct.Text = "Adicionar";
            addProduct.UseVisualStyleBackColor = false;
            addProduct.Click += addProduct_Click;
            // 
            // AddProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Red;
            ClientSize = new Size(800, 450);
            Controls.Add(addProduct);
            Controls.Add(productsGrid);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(categoryCombo);
            Controls.Add(filterText);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adicionar Produtos";
            ((System.ComponentModel.ISupportInitialize)productsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox filterText;
        private ComboBox categoryCombo;
        private Label label1;
        private Label label3;
        private DataGridView productsGrid;
        private Button addProduct;
    }
}