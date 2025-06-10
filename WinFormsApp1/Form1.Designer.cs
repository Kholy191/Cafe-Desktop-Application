namespace WinFormsApp1
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            bindingSource1 = new BindingSource(components);
            OrdersBtn = new Button();
            label2 = new Label();
            DeleteProductBtn = new Button();
            AddProductBtn = new Button();
            Deletebtn = new Button();
            Addbtn = new Button();
            dataGridView2 = new DataGridView();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // OrdersBtn
            // 
            OrdersBtn.BackColor = SystemColors.MenuHighlight;
            OrdersBtn.Font = new Font("Segoe UI", 20F);
            OrdersBtn.ForeColor = SystemColors.ButtonFace;
            OrdersBtn.Location = new Point(487, 345);
            OrdersBtn.Name = "OrdersBtn";
            OrdersBtn.Size = new Size(173, 68);
            OrdersBtn.TabIndex = 17;
            OrdersBtn.Text = "Orders";
            OrdersBtn.UseVisualStyleBackColor = false;
            OrdersBtn.Click += OrdersBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(458, 37);
            label2.Name = "label2";
            label2.Size = new Size(85, 37);
            label2.TabIndex = 16;
            label2.Text = "Order";
            // 
            // DeleteProductBtn
            // 
            DeleteProductBtn.BackColor = Color.Firebrick;
            DeleteProductBtn.ForeColor = SystemColors.ButtonFace;
            DeleteProductBtn.Location = new Point(604, 285);
            DeleteProductBtn.Name = "DeleteProductBtn";
            DeleteProductBtn.Size = new Size(142, 43);
            DeleteProductBtn.TabIndex = 15;
            DeleteProductBtn.Text = "Delete Product";
            DeleteProductBtn.UseVisualStyleBackColor = false;
            // 
            // AddProductBtn
            // 
            AddProductBtn.BackColor = SystemColors.ActiveCaption;
            AddProductBtn.Location = new Point(401, 285);
            AddProductBtn.Name = "AddProductBtn";
            AddProductBtn.Size = new Size(142, 43);
            AddProductBtn.TabIndex = 14;
            AddProductBtn.Text = "Add Product";
            AddProductBtn.UseVisualStyleBackColor = false;
            AddProductBtn.Click += AddProductBtn_Click;
            // 
            // Deletebtn
            // 
            Deletebtn.BackColor = Color.Red;
            Deletebtn.ForeColor = SystemColors.ButtonFace;
            Deletebtn.Location = new Point(604, 225);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(142, 36);
            Deletebtn.TabIndex = 13;
            Deletebtn.Text = "Delete From Order";
            Deletebtn.UseVisualStyleBackColor = false;
            // 
            // Addbtn
            // 
            Addbtn.BackColor = Color.Green;
            Addbtn.Location = new Point(401, 225);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(142, 36);
            Addbtn.TabIndex = 12;
            Addbtn.Text = "Add to Order";
            Addbtn.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(461, 77);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(226, 103);
            dataGridView2.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(54, 37);
            label1.Name = "label1";
            label1.Size = new Size(120, 37);
            label1.TabIndex = 10;
            label1.Text = "Products";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(54, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(294, 286);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(OrdersBtn);
            Controls.Add(label2);
            Controls.Add(DeleteProductBtn);
            Controls.Add(AddProductBtn);
            Controls.Add(Deletebtn);
            Controls.Add(Addbtn);
            Controls.Add(dataGridView2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bindingSource1;
        private Button OrdersBtn;
        private Label label2;
        private Button DeleteProductBtn;
        private Button AddProductBtn;
        private Button Deletebtn;
        private Button Addbtn;
        private DataGridView dataGridView2;
        private Label label1;
        private DataGridView dataGridView1;
    }
}
