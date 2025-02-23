namespace Project
{
    partial class categoryPage
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
            dgv_categories = new DataGridView();
            txt_name = new TextBox();
            nud_id = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            btn_users = new Button();
            btn_products = new Button();
            pictureBox1 = new PictureBox();
            l_hey = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_categories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_id).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgv_categories
            // 
            dgv_categories.BackgroundColor = SystemColors.ButtonHighlight;
            dgv_categories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_categories.Location = new Point(12, 78);
            dgv_categories.Name = "dgv_categories";
            dgv_categories.RowHeadersWidth = 51;
            dgv_categories.Size = new Size(361, 333);
            dgv_categories.TabIndex = 0;
            dgv_categories.RowHeaderMouseDoubleClick += dgv_categories_RowHeaderMouseDoubleClick;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(598, 112);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(190, 27);
            txt_name.TabIndex = 1;
            // 
            // nud_id
            // 
            nud_id.Enabled = false;
            nud_id.Location = new Point(598, 169);
            nud_id.Name = "nud_id";
            nud_id.Size = new Size(190, 27);
            nud_id.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label1.Location = new Point(394, 108);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(178, 31);
            label1.TabIndex = 3;
            label1.Text = "Category Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label2.Location = new Point(394, 169);
            label2.Name = "label2";
            label2.Size = new Size(136, 31);
            label2.TabIndex = 4;
            label2.Text = "Category id";
            // 
            // btn_add
            // 
            btn_add.Location = new Point(394, 245);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(151, 44);
            btn_add.TabIndex = 2;
            btn_add.Text = "Add Category";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += button1_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(664, 245);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(151, 44);
            btn_update.TabIndex = 3;
            btn_update.Text = "Update Category";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(518, 317);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(151, 44);
            btn_delete.TabIndex = 4;
            btn_delete.Text = "Delete Category";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_users
            // 
            btn_users.Location = new Point(506, 432);
            btn_users.Name = "btn_users";
            btn_users.Size = new Size(194, 46);
            btn_users.TabIndex = 5;
            btn_users.Text = "Users Page";
            btn_users.UseVisualStyleBackColor = true;
            btn_users.Click += button4_Click;
            // 
            // btn_products
            // 
            btn_products.Location = new Point(148, 432);
            btn_products.Name = "btn_products";
            btn_products.Size = new Size(194, 46);
            btn_products.TabIndex = 5;
            btn_products.Text = "Products Page";
            btn_products.UseVisualStyleBackColor = true;
            btn_products.Click += button5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.left_chevron1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(-2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 27);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // l_hey
            // 
            l_hey.AutoSize = true;
            l_hey.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            l_hey.Location = new Point(178, 18);
            l_hey.Name = "l_hey";
            l_hey.Size = new Size(147, 41);
            l_hey.TabIndex = 12;
            l_hey.Text = "Welcome";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(827, 490);
            ControlBox = false;
            Controls.Add(l_hey);
            Controls.Add(pictureBox1);
            Controls.Add(btn_products);
            Controls.Add(btn_users);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nud_id);
            Controls.Add(txt_name);
            Controls.Add(dgv_categories);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_categories).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_id).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_categories;
        private TextBox txt_name;
        private NumericUpDown nud_id;
        private Label label1;
        private Label label2;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
        private Button btn_users;
        private Button btn_products;
        private PictureBox pictureBox1;
        private Label l_hey;
    }
}