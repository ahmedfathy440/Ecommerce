namespace Project
{
    partial class register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register));
            btn_ok = new Button();
            txt_username = new TextBox();
            txt_password = new TextBox();
            txt_email = new TextBox();
            txt_address = new TextBox();
            cb_role = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            nud_age = new NumericUpDown();
            checkBox1 = new CheckBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)nud_age).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btn_ok
            // 
            btn_ok.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ok.Location = new Point(337, 413);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(176, 61);
            btn_ok.TabIndex = 8;
            btn_ok.Text = "Register";
            btn_ok.UseVisualStyleBackColor = true;
            btn_ok.UseWaitCursor = true;
            btn_ok.Click += btn_ok_Click;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(390, 34);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(257, 27);
            txt_username.TabIndex = 1;
            txt_username.UseWaitCursor = true;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(390, 267);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(257, 27);
            txt_password.TabIndex = 5;
            txt_password.UseWaitCursor = true;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(390, 216);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(257, 27);
            txt_email.TabIndex = 4;
            txt_email.UseWaitCursor = true;
            // 
            // txt_address
            // 
            txt_address.Location = new Point(390, 92);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(257, 27);
            txt_address.TabIndex = 2;
            txt_address.UseWaitCursor = true;
            // 
            // cb_role
            // 
            cb_role.DisplayMember = "0";
            cb_role.FormattingEnabled = true;
            cb_role.Items.AddRange(new object[] { "Admin", "User" });
            cb_role.Location = new Point(390, 358);
            cb_role.Name = "cb_role";
            cb_role.Size = new Size(257, 28);
            cb_role.TabIndex = 7;
            cb_role.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(205, 23);
            label1.Name = "label1";
            label1.Size = new Size(158, 38);
            label1.TabIndex = 7;
            label1.Text = "User Name";
            label1.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            label2.Location = new Point(214, 205);
            label2.Name = "label2";
            label2.Size = new Size(86, 38);
            label2.TabIndex = 8;
            label2.Text = "Email";
            label2.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            label3.Location = new Point(214, 143);
            label3.Name = "label3";
            label3.Size = new Size(68, 38);
            label3.TabIndex = 9;
            label3.Text = "Age";
            label3.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            label4.Location = new Point(214, 347);
            label4.Name = "label4";
            label4.Size = new Size(72, 38);
            label4.TabIndex = 10;
            label4.Text = "Role";
            label4.UseWaitCursor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(214, 92);
            label5.Name = "label5";
            label5.Size = new Size(119, 38);
            label5.TabIndex = 11;
            label5.Text = "Address";
            label5.UseWaitCursor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            label6.Location = new Point(214, 256);
            label6.Name = "label6";
            label6.Size = new Size(136, 38);
            label6.TabIndex = 12;
            label6.Text = "Password";
            label6.UseWaitCursor = true;
            // 
            // nud_age
            // 
            nud_age.Location = new Point(390, 154);
            nud_age.Minimum = new decimal(new int[] { 20, 0, 0, 0 });
            nud_age.Name = "nud_age";
            nud_age.Size = new Size(257, 27);
            nud_age.TabIndex = 3;
            nud_age.UseWaitCursor = true;
            nud_age.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(391, 307);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 24);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.UseWaitCursor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(-4, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 38);
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            pictureBox2.UseWaitCursor = true;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(827, 490);
            ControlBox = false;
            Controls.Add(pictureBox2);
            Controls.Add(checkBox1);
            Controls.Add(nud_age);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cb_role);
            Controls.Add(txt_address);
            Controls.Add(txt_email);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(btn_ok);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            UseWaitCursor = true;
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)nud_age).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_ok;
        private TextBox txt_username;
        private TextBox txt_password;
        private TextBox txt_email;
        private TextBox txt_address;
        private ComboBox cb_role;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private NumericUpDown nud_age;
        private CheckBox checkBox1;
        private PictureBox pictureBox2;
    }
}