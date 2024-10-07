namespace QuanLyQuanCF
{
    partial class FLogin
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
            panel1 = new Panel();
            TxbUsername_Login = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            TxbPassWord_Login = new TextBox();
            label2 = new Label();
            BtnLogin_Click = new Button();
            BtnExit_Click = new Button();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(TxbUsername_Login);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(490, 65);
            panel1.TabIndex = 0;
            // 
            // TxbUsername_Login
            // 
            TxbUsername_Login.Location = new Point(164, 26);
            TxbUsername_Login.Name = "TxbUsername_Login";
            TxbUsername_Login.Size = new Size(312, 23);
            TxbUsername_Login.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 24);
            label1.Name = "label1";
            label1.Size = new Size(159, 25);
            label1.TabIndex = 0;
            label1.Text = "Tên Đăng Nhập :";
            // 
            // panel2
            // 
            panel2.Controls.Add(TxbPassWord_Login);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(3, 98);
            panel2.Name = "panel2";
            panel2.Size = new Size(490, 65);
            panel2.TabIndex = 1;
            // 
            // TxbPassWord_Login
            // 
            TxbPassWord_Login.Location = new Point(164, 22);
            TxbPassWord_Login.Name = "TxbPassWord_Login";
            TxbPassWord_Login.Size = new Size(312, 23);
            TxbPassWord_Login.TabIndex = 2;
            TxbPassWord_Login.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 22);
            label2.Name = "label2";
            label2.Size = new Size(107, 25);
            label2.TabIndex = 1;
            label2.Text = "Mật Khẩu :";
            // 
            // BtnLogin_Click
            // 
            BtnLogin_Click.Location = new Point(322, 169);
            BtnLogin_Click.Name = "BtnLogin_Click";
            BtnLogin_Click.Size = new Size(75, 23);
            BtnLogin_Click.TabIndex = 3;
            BtnLogin_Click.Text = "Đăng Nhập";
            BtnLogin_Click.UseVisualStyleBackColor = true;
            BtnLogin_Click.Click += BtnLogin_Click_Click;
            // 
            // BtnExit_Click
            // 
            BtnExit_Click.Location = new Point(418, 169);
            BtnExit_Click.Name = "BtnExit_Click";
            BtnExit_Click.Size = new Size(75, 23);
            BtnExit_Click.TabIndex = 4;
            BtnExit_Click.Text = "Thoát";
            BtnExit_Click.UseVisualStyleBackColor = true;
            BtnExit_Click.Click += BtnExit_Click_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(BtnExit_Click);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(BtnLogin_Click);
            panel3.Location = new Point(12, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(508, 202);
            panel3.TabIndex = 4;
            // 
            // FLogin
            // 
            AcceptButton = BtnLogin_Click;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = BtnExit_Click;
            ClientSize = new Size(524, 216);
            Controls.Add(panel3);
            Name = "FLogin";
            Text = "Đăng nhập";
            FormClosing += FLogin_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox TxbUsername_Login;
        private Label label1;
        private Panel panel2;
        private TextBox TxbPassWord_Login;
        private Label label2;
        private Button BtnLogin_Click;
        private Button BtnExit_Click;
        private Panel panel3;
    }
}
