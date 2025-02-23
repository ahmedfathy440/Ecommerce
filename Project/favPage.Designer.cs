namespace Project
{
    partial class favPage
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
            btn_add = new Button();
            dgv_Favourites = new DataGridView();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txt_product = new TextBox();
            btn_delete = new Button();
            label3 = new Label();
            l_hey = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_products).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Favourites).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgv_products
            // 
            dgv_products.BackgroundColor = SystemColors.ButtonHighlight;
            dgv_products.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_products.Location = new Point(11, 124);
            dgv_products.Name = "dgv_products";
            dgv_products.RowHeadersWidth = 51;
            dgv_products.Size = new Size(406, 299);
            dgv_products.TabIndex = 1;
            dgv_products.RowHeaderMouseDoubleClick += dgv_products_RowHeaderMouseDoubleClick;
            // 
            // btn_add
            // 
            btn_add.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_add.Location = new Point(305, 442);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(154, 48);
            btn_add.TabIndex = 3;
            btn_add.Text = "Add to Fav";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += button1_Click;
            // 
            // dgv_Favourites
            // 
            dgv_Favourites.BackgroundColor = SystemColors.ButtonHighlight;
            dgv_Favourites.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Favourites.Location = new Point(480, 124);
            dgv_Favourites.Name = "dgv_Favourites";
            dgv_Favourites.RowHeadersWidth = 51;
            dgv_Favourites.Size = new Size(374, 299);
            dgv_Favourites.TabIndex = 5;
            dgv_Favourites.RowHeaderMouseDoubleClick += dgv_Favourites_RowHeaderMouseDoubleClick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.left_chevron3;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(2, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 29);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(118, 65);
            label1.Name = "label1";
            label1.Size = new Size(162, 46);
            label1.TabIndex = 7;
            label1.Text = "Products";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(565, 65);
            label2.Name = "label2";
            label2.Size = new Size(209, 46);
            label2.TabIndex = 8;
            label2.Text = "My Favorite";
            // 
            // txt_product
            // 
            txt_product.Location = new Point(143, 452);
            txt_product.Name = "txt_product";
            txt_product.Size = new Size(137, 27);
            txt_product.TabIndex = 9;
            // 
            // btn_delete
            // 
            btn_delete.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_delete.Location = new Point(596, 442);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(120, 48);
            btn_delete.TabIndex = 10;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(11, 452);
            label3.Name = "label3";
            label3.Size = new Size(126, 25);
            label3.TabIndex = 11;
            label3.Text = "Product Name";
            // 
            // l_hey
            // 
            l_hey.AutoSize = true;
            l_hey.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_hey.Location = new Point(305, 19);
            l_hey.Name = "l_hey";
            l_hey.Size = new Size(138, 38);
            l_hey.TabIndex = 12;
            l_hey.Text = "Welcome";
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(879, 505);
            ControlBox = false;
            Controls.Add(l_hey);
            Controls.Add(label3);
            Controls.Add(btn_delete);
            Controls.Add(txt_product);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(dgv_Favourites);
            Controls.Add(btn_add);
            Controls.Add(dgv_products);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form7";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form7_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_products).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Favourites).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_products;
        private Button btn_add;
        private DataGridView dgv_Favourites;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txt_product;
        private Button btn_delete;
        private Label label3;
        private Label l_hey;
    }
}