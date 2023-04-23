using GerenciamentoPereiras.Data;
using GerenciamentoPereiras.Models;
using System.Windows.Forms;

namespace GerenciamentoPereiras
{
    partial class MainScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            isActive = new Button();
            isActiveImg = new PictureBox();
            panelHeader = new Panel();
            labelHeader = new Label();
            panelOrderList = new Panel();
            productOrdersGrid = new DataGridView();
            labelOrderList = new Label();
            AddProductButton = new Button();
            orderPanel = new Panel();
            panel1 = new Panel();
            finishOrderButton = new Button();
            label1 = new Label();
            totalOrder = new TextBox();
            clientsPanel = new Panel();
            ordersButton = new Button();
            productsButton = new Button();
            addClient = new Button();
            clientList = new Panel();
            labelClientList = new Label();
            clientsList = new ListView();
            ((System.ComponentModel.ISupportInitialize)isActiveImg).BeginInit();
            panelHeader.SuspendLayout();
            panelOrderList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productOrdersGrid).BeginInit();
            orderPanel.SuspendLayout();
            panel1.SuspendLayout();
            clientsPanel.SuspendLayout();
            clientList.SuspendLayout();
            SuspendLayout();
            // 
            // isActive
            // 
            isActive.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            isActive.BackColor = Color.Black;
            isActive.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            isActive.ForeColor = Color.White;
            isActive.Location = new Point(24, 566);
            isActive.Name = "isActive";
            isActive.Size = new Size(116, 40);
            isActive.TabIndex = 2;
            isActive.Text = "Ligar Sistema";
            isActive.UseVisualStyleBackColor = false;
            isActive.Click += isActive_Click;
            // 
            // isActiveImg
            // 
            isActiveImg.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            isActiveImg.Location = new Point(146, 561);
            isActiveImg.Name = "isActiveImg";
            isActiveImg.Size = new Size(150, 51);
            isActiveImg.TabIndex = 7;
            isActiveImg.TabStop = false;
            // 
            // panelHeader
            // 
            panelHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelHeader.BorderStyle = BorderStyle.FixedSingle;
            panelHeader.Controls.Add(labelHeader);
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1184, 100);
            panelHeader.TabIndex = 1;
            // 
            // labelHeader
            // 
            labelHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelHeader.BackColor = Color.FromArgb(255, 128, 128);
            labelHeader.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelHeader.ForeColor = Color.Black;
            labelHeader.Location = new Point(-1, -1);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(1184, 98);
            labelHeader.TabIndex = 1;
            labelHeader.Text = "Pereira's\r\nLanches - Porções - Espetinhos";
            labelHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelOrderList
            // 
            panelOrderList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelOrderList.BorderStyle = BorderStyle.Fixed3D;
            panelOrderList.Controls.Add(productOrdersGrid);
            panelOrderList.Location = new Point(372, 144);
            panelOrderList.Margin = new Padding(10);
            panelOrderList.Name = "panelOrderList";
            panelOrderList.Padding = new Padding(4);
            panelOrderList.Size = new Size(781, 485);
            panelOrderList.TabIndex = 2;
            // 
            // productOrdersGrid
            // 
            productOrdersGrid.AllowUserToAddRows = false;
            productOrdersGrid.AllowUserToDeleteRows = false;
            productOrdersGrid.AllowUserToResizeColumns = false;
            productOrdersGrid.AllowUserToResizeRows = false;
            productOrdersGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            productOrdersGrid.BackgroundColor = Color.White;
            productOrdersGrid.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            productOrdersGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            productOrdersGrid.DefaultCellStyle = dataGridViewCellStyle1;
            productOrdersGrid.Location = new Point(-2, -2);
            productOrdersGrid.Name = "productOrdersGrid";
            productOrdersGrid.RowHeadersVisible = false;
            productOrdersGrid.RowTemplate.Height = 50;
            productOrdersGrid.Size = new Size(781, 485);
            productOrdersGrid.TabIndex = 3;
            productOrdersGrid.TabStop = false;
            // 
            // labelOrderList
            // 
            labelOrderList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelOrderList.BackColor = Color.Black;
            labelOrderList.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelOrderList.ForeColor = Color.White;
            labelOrderList.Location = new Point(10, 10);
            labelOrderList.Name = "labelOrderList";
            labelOrderList.Size = new Size(781, 21);
            labelOrderList.TabIndex = 2;
            labelOrderList.Text = "Comanda";
            labelOrderList.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddProductButton
            // 
            AddProductButton.Anchor = AnchorStyles.Bottom;
            AddProductButton.BackColor = Color.Black;
            AddProductButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddProductButton.ForeColor = Color.White;
            AddProductButton.Location = new Point(263, 16);
            AddProductButton.Margin = new Padding(0);
            AddProductButton.Name = "AddProductButton";
            AddProductButton.Size = new Size(214, 72);
            AddProductButton.TabIndex = 3;
            AddProductButton.Text = "Adicionar Produtos";
            AddProductButton.UseVisualStyleBackColor = false;
            AddProductButton.Visible = false;
            AddProductButton.Click += AddProductButton_Click;
            // 
            // orderPanel
            // 
            orderPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            orderPanel.Controls.Add(panel1);
            orderPanel.Controls.Add(labelOrderList);
            orderPanel.Location = new Point(362, 109);
            orderPanel.Name = "orderPanel";
            orderPanel.Size = new Size(810, 640);
            orderPanel.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(finishOrderButton);
            panel1.Controls.Add(AddProductButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(totalOrder);
            panel1.Location = new Point(10, 533);
            panel1.Name = "panel1";
            panel1.Size = new Size(781, 104);
            panel1.TabIndex = 2;
            // 
            // finishOrderButton
            // 
            finishOrderButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            finishOrderButton.BackColor = Color.Black;
            finishOrderButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            finishOrderButton.ForeColor = Color.White;
            finishOrderButton.Location = new Point(592, 44);
            finishOrderButton.Name = "finishOrderButton";
            finishOrderButton.Size = new Size(176, 60);
            finishOrderButton.TabIndex = 3;
            finishOrderButton.Text = "Finalizar";
            finishOrderButton.UseVisualStyleBackColor = false;
            finishOrderButton.Click += finishOrderButton_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(574, 3);
            label1.Name = "label1";
            label1.Size = new Size(50, 23);
            label1.TabIndex = 3;
            label1.Text = "Total";
            // 
            // totalOrder
            // 
            totalOrder.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            totalOrder.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            totalOrder.Location = new Point(630, 3);
            totalOrder.Name = "totalOrder";
            totalOrder.ReadOnly = true;
            totalOrder.Size = new Size(126, 35);
            totalOrder.TabIndex = 3;
            // 
            // clientsPanel
            // 
            clientsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            clientsPanel.Controls.Add(ordersButton);
            clientsPanel.Controls.Add(productsButton);
            clientsPanel.Controls.Add(addClient);
            clientsPanel.Controls.Add(isActive);
            clientsPanel.Controls.Add(clientList);
            clientsPanel.Controls.Add(isActiveImg);
            clientsPanel.Location = new Point(0, 109);
            clientsPanel.Name = "clientsPanel";
            clientsPanel.Size = new Size(356, 640);
            clientsPanel.TabIndex = 1;
            // 
            // ordersButton
            // 
            ordersButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ordersButton.BackColor = Color.Black;
            ordersButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ordersButton.ForeColor = Color.White;
            ordersButton.Location = new Point(12, 537);
            ordersButton.Name = "ordersButton";
            ordersButton.Size = new Size(128, 23);
            ordersButton.TabIndex = 9;
            ordersButton.Text = "Comandas";
            ordersButton.UseVisualStyleBackColor = false;
            ordersButton.Click += ordersButton_Click;
            // 
            // productsButton
            // 
            productsButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            productsButton.BackColor = Color.Black;
            productsButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            productsButton.ForeColor = Color.White;
            productsButton.Location = new Point(12, 511);
            productsButton.Name = "productsButton";
            productsButton.Size = new Size(128, 23);
            productsButton.TabIndex = 8;
            productsButton.Text = "Produtos";
            productsButton.UseVisualStyleBackColor = false;
            productsButton.Click += productsButton_Click;
            // 
            // addClient
            // 
            addClient.BackColor = Color.Black;
            addClient.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addClient.ForeColor = Color.White;
            addClient.Location = new Point(68, 3);
            addClient.Name = "addClient";
            addClient.Size = new Size(200, 44);
            addClient.TabIndex = 2;
            addClient.Text = "Adicionar Cliente";
            addClient.UseVisualStyleBackColor = false;
            addClient.Visible = false;
            addClient.Click += addClient_Click;
            // 
            // clientList
            // 
            clientList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            clientList.BackColor = Color.Transparent;
            clientList.Controls.Add(labelClientList);
            clientList.Controls.Add(clientsList);
            clientList.Location = new Point(12, 50);
            clientList.Name = "clientList";
            clientList.Size = new Size(329, 455);
            clientList.TabIndex = 2;
            // 
            // labelClientList
            // 
            labelClientList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelClientList.BackColor = Color.Black;
            labelClientList.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelClientList.ForeColor = Color.White;
            labelClientList.Location = new Point(13, 30);
            labelClientList.Name = "labelClientList";
            labelClientList.Size = new Size(302, 21);
            labelClientList.TabIndex = 3;
            labelClientList.Text = "Clientes";
            labelClientList.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // clientsList
            // 
            clientsList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            clientsList.BackColor = Color.White;
            clientsList.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            clientsList.FullRowSelect = true;
            clientsList.GridLines = true;
            clientsList.HeaderStyle = ColumnHeaderStyle.None;
            clientsList.Location = new Point(12, 55);
            clientsList.Margin = new Padding(15);
            clientsList.MultiSelect = false;
            clientsList.Name = "clientsList";
            clientsList.Size = new Size(303, 385);
            clientsList.TabIndex = 3;
            clientsList.UseCompatibleStateImageBehavior = false;
            clientsList.View = View.List;
            clientsList.SelectedIndexChanged += clientsList_SelectedIndexChanged;
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(1184, 761);
            Controls.Add(clientsPanel);
            Controls.Add(panelOrderList);
            Controls.Add(panelHeader);
            Controls.Add(orderPanel);
            Name = "MainScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciamento Pereira's";
            Load += Form1_Load;
            Shown += Form1_Shown;
            ((System.ComponentModel.ISupportInitialize)isActiveImg).EndInit();
            panelHeader.ResumeLayout(false);
            panelOrderList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)productOrdersGrid).EndInit();
            orderPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            clientsPanel.ResumeLayout(false);
            clientList.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelHeader;
        private Label labelHeader;
        private Panel panelOrderList;
        private Label labelOrderList;
        private Button AddProductButton;
        private Button isActive;
        private PictureBox isActiveImg;
        private Panel orderPanel;
        private Panel clientsPanel;
        private Panel panel1;
        private Label label1;
        private TextBox totalOrder;
        private Button finishOrderButton;
        private Button addClient;
        private Panel clientList;
        private Label labelClientList;
        private ListView clientsList;
        private DataGridView productOrdersGrid;
        private Button ordersButton;
        private Button productsButton;
    }
}