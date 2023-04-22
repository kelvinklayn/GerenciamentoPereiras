namespace GerenciamentoPereiras.Dialog
{
    partial class AmountDialogProduct
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
            label1 = new Label();
            amountProductSelector = new NumericUpDown();
            buttonCancel = new Button();
            buttonOk = new Button();
            ((System.ComponentModel.ISupportInitialize)amountProductSelector).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(36, 38);
            label1.Name = "label1";
            label1.Size = new Size(319, 84);
            label1.TabIndex = 0;
            label1.Text = "Qual a quantidade que deseja adicionar ?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // amountProductSelector
            // 
            amountProductSelector.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            amountProductSelector.Location = new Point(161, 125);
            amountProductSelector.Name = "amountProductSelector";
            amountProductSelector.Size = new Size(76, 35);
            amountProductSelector.TabIndex = 1;
            amountProductSelector.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.Black;
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(161, 175);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(99, 32);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = false;
            // 
            // buttonOk
            // 
            buttonOk.BackColor = Color.Black;
            buttonOk.DialogResult = DialogResult.OK;
            buttonOk.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonOk.ForeColor = Color.White;
            buttonOk.Location = new Point(266, 175);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(108, 32);
            buttonOk.TabIndex = 3;
            buttonOk.Text = "Confirmar";
            buttonOk.UseVisualStyleBackColor = false;
            buttonOk.Click += buttonOk_Click;
            // 
            // AmountDialogProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(386, 219);
            Controls.Add(buttonOk);
            Controls.Add(buttonCancel);
            Controls.Add(amountProductSelector);
            Controls.Add(label1);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AmountDialogProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AmountDialogProduct";
            ((System.ComponentModel.ISupportInitialize)amountProductSelector).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private NumericUpDown amountProductSelector;
        private Button buttonCancel;
        private Button buttonOk;
    }
}