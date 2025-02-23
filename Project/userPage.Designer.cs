namespace Project
{
    partial class userPage
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
            dgv_users = new DataGridView();
            btn_delete = new Button();
            btn_update = new Button();
            btn_add = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_name = new TextBox();
            txt_email = new TextBox();
            txt_password = new TextBox();
            nud_age = new NumericUpDown();
            cb_role = new ComboBox();
            label5 = new Label();
            txt_address = new TextBox();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgv_users).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_age).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgv_users
            // 
            dgv_users.BackgroundColor = SystemColors.ButtonHighlight;
            dgv_users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_users.Location = new Point(6, 41);
            dgv_users.Name = "dgv_users";
            dgv_users.RowHeadersWidth = 51;
            dgv_users.Size = new Size(813, 298);
            dgv_users.TabIndex = 1;
            dgv_users.RowHeaderMouseDoubleClick += dgv_users_RowHeaderMouseDoubleClick;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(703, 456);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 29);
            btn_delete.TabIndex = 9;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(703, 410);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(94, 29);
            btn_update.TabIndex = 8;
            btn_update.Text = "Update User";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(703, 359);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 7;
            btn_add.Text = "Add User";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 363);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 5;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(233, 449);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 6;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 449);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 7;
            label3.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(242, 367);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 8;
            label4.Text = "Email";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(94, 360);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(125, 27);
            txt_name.TabIndex = 1;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(309, 361);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(125, 27);
            txt_email.TabIndex = 3;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(309, 446);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(125, 27);
            txt_password.TabIndex = 4;
            // 
            // nud_age
            // 
            nud_age.Location = new Point(94, 442);
            nud_age.Name = "nud_age";
            nud_age.Size = new Size(125, 27);
            nud_age.TabIndex = 2;
            // 
            // cb_role
            // 
            cb_role.FormattingEnabled = true;
            cb_role.Items.AddRange(new object[] { "Admin", "User" });
            cb_role.Location = new Point(548, 361);
            cb_role.Name = "cb_role";
            cb_role.Size = new Size(125, 28);
            cb_role.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(458, 367);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 14;
            label5.Text = "Role";
            // 
            // txt_address
            // 
            txt_address.Location = new Point(548, 442);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(125, 27);
            txt_address.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(458, 446);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 16;
            label6.Text = "Address";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.left_chevron2;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(-4, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 36);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(827, 490);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(txt_address);
            Controls.Add(label5);
            Controls.Add(cb_role);
            Controls.Add(nud_age);
            Controls.Add(txt_password);
            Controls.Add(txt_email);
            Controls.Add(txt_name);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_add);
            Controls.Add(btn_update);
            Controls.Add(btn_delete);
            Controls.Add(dgv_users);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_users).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_age).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_users;
        private Button btn_delete;
        private Button btn_update;
        private Button btn_add;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_name;
        private TextBox txt_email;
        private TextBox txt_password;
        private NumericUpDown nud_age;
        private ComboBox cb_role;
        private Label label5;
        private TextBox txt_address;
        private Label label6;
        private PictureBox pictureBox1;
    }
}