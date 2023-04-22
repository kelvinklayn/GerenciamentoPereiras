namespace GerenciamentoPereiras.Dialog
{
    partial class AddClients
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
            clientNameTextBox = new TextBox();
            clientNamelabel = new Label();
            confirmButton = new Button();
            OrderGroupNo = new Label();
            ordersGroupIdNo = new TextBox();
            SuspendLayout();
            // 
            // clientNameTextBox
            // 
            clientNameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            clientNameTextBox.Location = new Point(25, 35);
            clientNameTextBox.Name = "clientNameTextBox";
            clientNameTextBox.Size = new Size(200, 29);
            clientNameTextBox.TabIndex = 0;
            // 
            // clientNamelabel
            // 
            clientNamelabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            clientNamelabel.Location = new Point(25, 7);
            clientNamelabel.Name = "clientNamelabel";
            clientNamelabel.Size = new Size(206, 25);
            clientNamelabel.TabIndex = 1;
            clientNamelabel.Text = "Digite o nome do Cliente :";
            clientNamelabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // confirmButton
            // 
            confirmButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            confirmButton.BackColor = Color.Black;
            confirmButton.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            confirmButton.ForeColor = Color.White;
            confirmButton.Location = new Point(338, 56);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(104, 35);
            confirmButton.TabIndex = 2;
            confirmButton.Text = "Confirmar";
            confirmButton.UseVisualStyleBackColor = false;
            confirmButton.Click += confirmButton_Click;
            // 
            // OrderGroupNo
            // 
            OrderGroupNo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            OrderGroupNo.AutoSize = true;
            OrderGroupNo.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            OrderGroupNo.Location = new Point(259, 9);
            OrderGroupNo.Name = "OrderGroupNo";
            OrderGroupNo.Size = new Size(98, 15);
            OrderGroupNo.TabIndex = 3;
            OrderGroupNo.Text = "OrderGroupNo : ";
            // 
            // ordersGroupIdNo
            // 
            ordersGroupIdNo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ordersGroupIdNo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ordersGroupIdNo.Location = new Point(358, 9);
            ordersGroupIdNo.Name = "ordersGroupIdNo";
            ordersGroupIdNo.Size = new Size(79, 23);
            ordersGroupIdNo.TabIndex = 4;
            // 
            // AddClients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(443, 94);
            Controls.Add(ordersGroupIdNo);
            Controls.Add(OrderGroupNo);
            Controls.Add(confirmButton);
            Controls.Add(clientNamelabel);
            Controls.Add(clientNameTextBox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddClients";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adicionar Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox clientNameTextBox;
        private Label clientNamelabel;
        private Button confirmButton;
        private Label OrderGroupNo;
        private TextBox ordersGroupIdNo;
    }
}