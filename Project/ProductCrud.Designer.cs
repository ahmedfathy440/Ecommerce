namespace Project
{
    partial class ProductCrud
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
            dgv_products = new DataGridView();
            txt_productName = new TextBox();
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            nud_price = new NumericUpDown();
            nud_id = new NumericUpDown();
            cb_categories = new ComboBox();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgv_products).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_price).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_id).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgv_products
            // 
            dgv_products.BackgroundColor = SystemColors.ButtonHighlight;
            dgv_products.BorderStyle = BorderStyle.Fixed3D;
            dgv_products.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_products.Location = new Point(5, 32);
            dgv_products.Name = "dgv_products";
            dgv_products.RowHeadersWidth = 51;
            dgv_products.Size = new Size(632, 318);
            dgv_products.TabIndex = 0;
            dgv_products.CellContentClick += dgv_products_CellContentClick;
            dgv_products.RowHeaderMouseDoubleClick += dgv_products_RowHeaderMouseDoubleClick;
            // 
            // txt_productName
            // 
            txt_productName.Location = new Point(159, 382);
            txt_productName.Name = "txt_productName";
            txt_productName.Size = new Size(178, 27);
            txt_productName.TabIndex = 1;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(659, 64);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(156, 56);
            btn_add.TabIndex = 4;
            btn_add.Text = "Add Product";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += button1_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(659, 176);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(156, 56);
            btn_update.TabIndex = 4;
            btn_update.Text = "Update Product";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += button2_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(659, 294);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(156, 56);
            btn_delete.TabIndex = 5;
            btn_delete.Text = "Delete Product";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.Location = new Point(5, 380);
            label1.Name = "label1";
            label1.Size = new Size(126, 25);
            label1.TabIndex = 8;
            label1.Text = "Product Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.Location = new Point(12, 443);
            label2.Name = "label2";
            label2.Size = new Size(116, 25);
            label2.TabIndex = 9;
            label2.Text = "Product Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.Location = new Point(393, 380);
            label3.Name = "label3";
            label3.Size = new Size(96, 25);
            label3.TabIndex = 10;
            label3.Text = "Product_id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F);
            label4.Location = new Point(400, 442);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 11;
            label4.Text = "Category ";
            // 
            // nud_price
            // 
            nud_price.Location = new Point(159, 442);
            nud_price.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nud_price.Name = "nud_price";
            nud_price.Size = new Size(178, 27);
            nud_price.TabIndex = 2;
            // 
            // nud_id
            // 
            nud_id.Location = new Point(514, 382);
            nud_id.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nud_id.Name = "nud_id";
            nud_id.Size = new Size(183, 27);
            nud_id.TabIndex = 14;
            // 
            // cb_categories
            // 
            cb_categories.FormattingEnabled = true;
            cb_categories.Location = new Point(514, 444);
            cb_categories.Name = "cb_categories";
            cb_categories.Size = new Size(183, 28);
            cb_categories.TabIndex = 3;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(12, 9);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 20);
            linkLabel1.TabIndex = 16;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.left_chevron;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(-6, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 30);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(827, 490);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel1);
            Controls.Add(cb_categories);
            Controls.Add(nud_id);
            Controls.Add(nud_price);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(txt_productName);
            Controls.Add(dgv_products);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_products).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_price).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_id).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_products;
        private TextBox txt_productName;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown nud_price;
        private NumericUpDown nud_id;
        private ComboBox cb_categories;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
    }
}