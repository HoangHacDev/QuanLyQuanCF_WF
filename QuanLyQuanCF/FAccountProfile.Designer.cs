namespace QuanLyQuanCF
{
    partial class FAccountProfile
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            TxbUserName = new TextBox();
            panel3 = new Panel();
            TxbDisplayName = new TextBox();
            label2 = new Label();
            panel4 = new Panel();
            TxbPassWord = new TextBox();
            label3 = new Label();
            panel5 = new Panel();
            TxbNewPass = new TextBox();
            label4 = new Label();
            panel6 = new Panel();
            TxbPassWAgain = new TextBox();
            label5 = new Label();
            BtnExitAccUser = new Button();
            BtnUpdateUser = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnUpdateUser);
            panel1.Controls.Add(BtnExitAccUser);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(508, 384);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(4, 20);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập :";
            // 
            // panel2
            // 
            panel2.Controls.Add(TxbUserName);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(15, 14);
            panel2.Name = "panel2";
            panel2.Size = new Size(477, 60);
            panel2.TabIndex = 1;
            // 
            // TxbUserName
            // 
            TxbUserName.Location = new Point(130, 20);
            TxbUserName.Name = "TxbUserName";
            TxbUserName.ReadOnly = true;
            TxbUserName.Size = new Size(324, 23);
            TxbUserName.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(TxbDisplayName);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(15, 80);
            panel3.Name = "panel3";
            panel3.Size = new Size(477, 60);
            panel3.TabIndex = 2;
            // 
            // TxbDisplayName
            // 
            TxbDisplayName.Location = new Point(130, 20);
            TxbDisplayName.Name = "TxbDisplayName";
            TxbDisplayName.Size = new Size(324, 23);
            TxbDisplayName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(4, 20);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 0;
            label2.Text = "Tên hiển thị :";
            // 
            // panel4
            // 
            panel4.Controls.Add(TxbPassWord);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(15, 146);
            panel4.Name = "panel4";
            panel4.Size = new Size(477, 60);
            panel4.TabIndex = 2;
            // 
            // TxbPassWord
            // 
            TxbPassWord.Location = new Point(130, 20);
            TxbPassWord.Name = "TxbPassWord";
            TxbPassWord.Size = new Size(324, 23);
            TxbPassWord.TabIndex = 1;
            TxbPassWord.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(4, 20);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 0;
            label3.Text = "Mật khẩu :";
            // 
            // panel5
            // 
            panel5.Controls.Add(TxbNewPass);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(15, 212);
            panel5.Name = "panel5";
            panel5.Size = new Size(477, 60);
            panel5.TabIndex = 3;
            // 
            // TxbNewPass
            // 
            TxbNewPass.Location = new Point(130, 20);
            TxbNewPass.Name = "TxbNewPass";
            TxbNewPass.Size = new Size(324, 23);
            TxbNewPass.TabIndex = 1;
            TxbNewPass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(4, 20);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 0;
            label4.Text = "Mật khẩu mới :";
            // 
            // panel6
            // 
            panel6.Controls.Add(TxbPassWAgain);
            panel6.Controls.Add(label5);
            panel6.Location = new Point(15, 278);
            panel6.Name = "panel6";
            panel6.Size = new Size(477, 60);
            panel6.TabIndex = 4;
            // 
            // TxbPassWAgain
            // 
            TxbPassWAgain.Location = new Point(130, 20);
            TxbPassWAgain.Name = "TxbPassWAgain";
            TxbPassWAgain.Size = new Size(324, 23);
            TxbPassWAgain.TabIndex = 1;
            TxbPassWAgain.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(4, 20);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 0;
            label5.Text = "Nhập lại MK :";
            // 
            // BtnExitAccUser
            // 
            BtnExitAccUser.Location = new Point(417, 351);
            BtnExitAccUser.Name = "BtnExitAccUser";
            BtnExitAccUser.Size = new Size(75, 23);
            BtnExitAccUser.TabIndex = 5;
            BtnExitAccUser.Text = "Thoát";
            BtnExitAccUser.UseVisualStyleBackColor = true;
            BtnExitAccUser.Click += BtnExitAccUser_Click;
            // 
            // BtnUpdateUser
            // 
            BtnUpdateUser.Location = new Point(316, 351);
            BtnUpdateUser.Name = "BtnUpdateUser";
            BtnUpdateUser.Size = new Size(75, 23);
            BtnUpdateUser.TabIndex = 6;
            BtnUpdateUser.Text = "Cập nhật";
            BtnUpdateUser.UseVisualStyleBackColor = true;
            // 
            // FAccountProfile
            // 
            AcceptButton = BtnUpdateUser;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = BtnExitAccUser;
            ClientSize = new Size(532, 408);
            Controls.Add(panel1);
            Name = "FAccountProfile";
            Text = "Thông tin tài khoản";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private TextBox TxbPassWord;
        private Label label3;
        private Panel panel3;
        private TextBox TxbDisplayName;
        private Label label2;
        private Panel panel2;
        private TextBox TxbUserName;
        private Label label1;
        private Panel panel6;
        private TextBox TxbPassWAgain;
        private Label label5;
        private Panel panel5;
        private TextBox TxbNewPass;
        private Label label4;
        private Button BtnUpdateUser;
        private Button BtnExitAccUser;
    }
}