namespace QuanLyQuanCF
{
    partial class FTableManager
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
            menuStrip1 = new MenuStrip();
            adminToolStripMenuItem = new ToolStripMenuItem();
            thôngTinTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            tàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            LSVbill = new ListView();
            panel3 = new Panel();
            CbSwitchTable = new ComboBox();
            BtnSwitchTable = new Button();
            NmDisCount = new NumericUpDown();
            BtnDisCount = new Button();
            panel4 = new Panel();
            NmFoodCount = new NumericUpDown();
            BtnAddFood = new Button();
            CBFood = new ComboBox();
            CBCategory = new ComboBox();
            FlpTable = new FlowLayoutPanel();
            BtnPay = new Button();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NmDisCount).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NmFoodCount).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, thôngTinTàiKhoảnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(55, 20);
            adminToolStripMenuItem.Text = "Admin";
            adminToolStripMenuItem.Click += adminToolStripMenuItem_Click;
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tàiKhoảnToolStripMenuItem, đăngXuấtToolStripMenuItem });
            thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            thôngTinTàiKhoảnToolStripMenuItem.Size = new Size(122, 20);
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            tàiKhoảnToolStripMenuItem.Size = new Size(180, 22);
            tàiKhoảnToolStripMenuItem.Text = "Thông tin cá nhân";
            tàiKhoảnToolStripMenuItem.Click += tàiKhoảnToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(180, 22);
            đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(LSVbill);
            panel2.Location = new Point(470, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(318, 276);
            panel2.TabIndex = 1;
            // 
            // LSVbill
            // 
            LSVbill.Location = new Point(3, 3);
            LSVbill.Name = "LSVbill";
            LSVbill.Size = new Size(312, 270);
            LSVbill.TabIndex = 0;
            LSVbill.UseCompatibleStateImageBehavior = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(CbSwitchTable);
            panel3.Controls.Add(BtnSwitchTable);
            panel3.Controls.Add(NmDisCount);
            panel3.Controls.Add(BtnDisCount);
            panel3.Location = new Point(470, 382);
            panel3.Name = "panel3";
            panel3.Size = new Size(318, 56);
            panel3.TabIndex = 2;
            // 
            // CbSwitchTable
            // 
            CbSwitchTable.FormattingEnabled = true;
            CbSwitchTable.Location = new Point(4, 31);
            CbSwitchTable.Name = "CbSwitchTable";
            CbSwitchTable.Size = new Size(92, 23);
            CbSwitchTable.TabIndex = 8;
            // 
            // BtnSwitchTable
            // 
            BtnSwitchTable.Font = new Font("Segoe UI", 8F);
            BtnSwitchTable.Location = new Point(3, 4);
            BtnSwitchTable.Name = "BtnSwitchTable";
            BtnSwitchTable.Size = new Size(93, 26);
            BtnSwitchTable.TabIndex = 7;
            BtnSwitchTable.Text = "Chuyển bàn";
            BtnSwitchTable.UseVisualStyleBackColor = true;
            // 
            // NmDisCount
            // 
            NmDisCount.Location = new Point(148, 30);
            NmDisCount.Name = "NmDisCount";
            NmDisCount.Size = new Size(75, 23);
            NmDisCount.TabIndex = 6;
            NmDisCount.TextAlign = HorizontalAlignment.Center;
            // 
            // BtnDisCount
            // 
            BtnDisCount.Font = new Font("Segoe UI", 8F);
            BtnDisCount.Location = new Point(148, 4);
            BtnDisCount.Name = "BtnDisCount";
            BtnDisCount.Size = new Size(75, 26);
            BtnDisCount.TabIndex = 5;
            BtnDisCount.Text = "Giảm giá";
            BtnDisCount.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(NmFoodCount);
            panel4.Controls.Add(BtnAddFood);
            panel4.Controls.Add(CBFood);
            panel4.Controls.Add(CBCategory);
            panel4.Location = new Point(470, 39);
            panel4.Name = "panel4";
            panel4.Size = new Size(318, 57);
            panel4.TabIndex = 3;
            // 
            // NmFoodCount
            // 
            NmFoodCount.Location = new Point(264, 17);
            NmFoodCount.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            NmFoodCount.Name = "NmFoodCount";
            NmFoodCount.Size = new Size(51, 23);
            NmFoodCount.TabIndex = 3;
            NmFoodCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // BtnAddFood
            // 
            BtnAddFood.Location = new Point(185, 17);
            BtnAddFood.Name = "BtnAddFood";
            BtnAddFood.Size = new Size(76, 23);
            BtnAddFood.TabIndex = 2;
            BtnAddFood.Text = "Thêm Món";
            BtnAddFood.UseVisualStyleBackColor = true;
            // 
            // CBFood
            // 
            CBFood.FormattingEnabled = true;
            CBFood.Location = new Point(0, 32);
            CBFood.Name = "CBFood";
            CBFood.Size = new Size(179, 23);
            CBFood.TabIndex = 1;
            // 
            // CBCategory
            // 
            CBCategory.FormattingEnabled = true;
            CBCategory.Location = new Point(0, 3);
            CBCategory.Name = "CBCategory";
            CBCategory.Size = new Size(179, 23);
            CBCategory.TabIndex = 0;
            // 
            // FlpTable
            // 
            FlpTable.Location = new Point(12, 39);
            FlpTable.Name = "FlpTable";
            FlpTable.Size = new Size(452, 399);
            FlpTable.TabIndex = 4;
            // 
            // BtnPay
            // 
            BtnPay.Location = new Point(699, 386);
            BtnPay.Name = "BtnPay";
            BtnPay.Size = new Size(86, 49);
            BtnPay.TabIndex = 0;
            BtnPay.Text = "Thanh Toán";
            BtnPay.UseVisualStyleBackColor = true;
            // 
            // FTableManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnPay);
            Controls.Add(FlpTable);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FTableManager";
            Text = "FTableManager";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)NmDisCount).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)NmFoodCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private Panel panel2;
        private ListView LSVbill;
        private Panel panel3;
        private Panel panel4;
        private ComboBox CBCategory;
        private Button BtnAddFood;
        private ComboBox CBFood;
        private NumericUpDown NmFoodCount;
        private NumericUpDown NmDisCount;
        private Button BtnDisCount;
        private FlowLayoutPanel FlpTable;
        private Button BtnPay;
        private ComboBox CbSwitchTable;
        private Button BtnSwitchTable;
    }
}