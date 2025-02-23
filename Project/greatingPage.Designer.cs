namespace Project
{
    partial class greatingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(greatingPage));
            btn_login = new Button();
            btn_register = new Button();
            label1 = new Label();
            p_exit = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)p_exit).BeginInit();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.Chocolate;
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_login.Location = new Point(70, 276);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(141, 58);
            btn_login.TabIndex = 1;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // btn_register
            // 
            btn_register.BackColor = Color.Chocolate;
            btn_register.FlatAppearance.BorderSize = 0;
            btn_register.FlatStyle = FlatStyle.Flat;
            btn_register.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_register.Location = new Point(41, 400);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(198, 58);
            btn_register.TabIndex = 2;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 51);
            label1.Name = "label1";
            label1.Padding = new Padding(10);
            label1.Size = new Size(271, 170);
            label1.TabIndex = 4;
            label1.Text = "Hey there! \r\nGlad to have \r\nyou with us.";
            // 
            // p_exit
            // 
            p_exit.BackgroundImage = (Image)resources.GetObject("p_exit.BackgroundImage");
            p_exit.BackgroundImageLayout = ImageLayout.Zoom;
            p_exit.Location = new Point(751, -3);
            p_exit.Name = "p_exit";
            p_exit.Size = new Size(38, 34);
            p_exit.TabIndex = 5;
            p_exit.TabStop = false;
            p_exit.Click += p_exit_Click;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.GradientInactiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 492);
            ControlBox = false;
            Controls.Add(p_exit);
            Controls.Add(label1);
            Controls.Add(btn_register);
            Controls.Add(btn_login);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form8";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form8_Load;
            ((System.ComponentModel.ISupportInitialize)p_exit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_login;
        private Button btn_register;
        private Label label1;
        private PictureBox p_exit;
    }
}