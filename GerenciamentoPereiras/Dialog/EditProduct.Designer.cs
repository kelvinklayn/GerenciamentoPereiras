namespace GerenciamentoPereiras.Dialog
{
    partial class EditProduct
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
            nameProductText = new TextBox();
            productNameLabel = new Label();
            productCategoryLabel = new Label();
            priceProductLabel = new Label();
            productCategoryCombo = new ComboBox();
            confirmButton = new Button();
            priceProductText = new MaskedTextBox();
            SuspendLayout();
            // 
            // nameProductText
            // 
            nameProductText.Location = new Point(43, 42);
            nameProductText.Margin = new Padding(5, 4, 5, 4);
            nameProductText.Name = "nameProductText";
            nameProductText.Size = new Size(309, 29);
            nameProductText.TabIndex = 0;
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new Point(21, 16);
            productNameLabel.Margin = new Padding(5, 0, 5, 0);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new Size(172, 22);
            productNameLabel.TabIndex = 3;
            productNameLabel.Text = "Nome do Produto";
            // 
            // productCategoryLabel
            // 
            productCategoryLabel.AutoSize = true;
            productCategoryLabel.Location = new Point(21, 87);
            productCategoryLabel.Name = "productCategoryLabel";
            productCategoryLabel.Size = new Size(209, 22);
            productCategoryLabel.TabIndex = 4;
            productCategoryLabel.Text = "Categoria do Produto";
            // 
            // priceProductLabel
            // 
            priceProductLabel.AutoSize = true;
            priceProductLabel.Location = new Point(21, 160);
            priceProductLabel.Name = "priceProductLabel";
            priceProductLabel.Size = new Size(65, 22);
            priceProductLabel.TabIndex = 5;
            priceProductLabel.Text = "Preço";
            // 
            // productCategoryCombo
            // 
            productCategoryCombo.FormattingEnabled = true;
            productCategoryCombo.Location = new Point(43, 112);
            productCategoryCombo.Name = "productCategoryCombo";
            productCategoryCombo.Size = new Size(132, 30);
            productCategoryCombo.TabIndex = 6;
            // 
            // confirmButton
            // 
            confirmButton.BackColor = Color.Black;
            confirmButton.ForeColor = Color.White;
            confirmButton.Location = new Point(204, 224);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(148, 33);
            confirmButton.TabIndex = 7;
            confirmButton.Text = "Confirmar";
            confirmButton.UseVisualStyleBackColor = false;
            confirmButton.Click += confirmButton_Click;
            // 
            // priceProductText
            // 
            priceProductText.Location = new Point(43, 185);
            priceProductText.Mask = "R$ 00.00";
            priceProductText.Name = "priceProductText";
            priceProductText.Size = new Size(132, 29);
            priceProductText.TabIndex = 8;
            // 
            // EditProduct
            // 
            AutoScaleDimensions = new SizeF(12F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(365, 268);
            Controls.Add(priceProductText);
            Controls.Add(confirmButton);
            Controls.Add(productCategoryCombo);
            Controls.Add(priceProductLabel);
            Controls.Add(productCategoryLabel);
            Controls.Add(productNameLabel);
            Controls.Add(nameProductText);
            Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(5, 4, 5, 4);
            Name = "EditProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Produto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameProductText;
        private Label productNameLabel;
        private Label productCategoryLabel;
        private Label priceProductLabel;
        private ComboBox productCategoryCombo;
        private Button confirmButton;
        private MaskedTextBox priceProductText;
    }
}