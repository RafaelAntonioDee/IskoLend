namespace IskoLendInventory
{
    partial class AddSupply
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
            label22 = new Label();
            cmbCategory = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            txtItemName = new TextBox();
            label5 = new Label();
            label19 = new Label();
            label2 = new Label();
            label4 = new Label();
            txtQty = new TextBox();
            btnAddItem = new RoundedPanel();
            label6 = new Label();
            btnAddItem.SuspendLayout();
            SuspendLayout();
            // 
            // label22
            // 
            label22.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.ForeColor = Color.Maroon;
            label22.Location = new Point(12, 9);
            label22.Name = "label22";
            label22.Size = new Size(307, 47);
            label22.TabIndex = 51;
            label22.Text = "Add Supply";
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(133, 48);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(170, 28);
            cmbCategory.TabIndex = 73;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(54, 82);
            label1.Name = "label1";
            label1.Size = new Size(22, 23);
            label1.TabIndex = 72;
            label1.Text = "*";
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(13, 85);
            label3.Name = "label3";
            label3.Size = new Size(95, 24);
            label3.TabIndex = 71;
            label3.Text = "Item";
            // 
            // txtItemName
            // 
            txtItemName.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtItemName.Location = new Point(133, 82);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(170, 26);
            txtItemName.TabIndex = 70;
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(96, 52);
            label5.Name = "label5";
            label5.Size = new Size(22, 23);
            label5.TabIndex = 69;
            label5.Text = "*";
            // 
            // label19
            // 
            label19.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.Black;
            label19.Location = new Point(13, 56);
            label19.Name = "label19";
            label19.Size = new Size(95, 24);
            label19.TabIndex = 68;
            label19.Text = "Category";
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(89, 114);
            label2.Name = "label2";
            label2.Size = new Size(22, 23);
            label2.TabIndex = 76;
            label2.Text = "*";
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(13, 117);
            label4.Name = "label4";
            label4.Size = new Size(95, 24);
            label4.TabIndex = 75;
            label4.Text = "Quantity";
            // 
            // txtQty
            // 
            txtQty.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQty.Location = new Point(133, 114);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(170, 26);
            txtQty.TabIndex = 74;
            // 
            // btnAddItem
            // 
            btnAddItem.BackColor = Color.Orange;
            btnAddItem.Controls.Add(label6);
            btnAddItem.Location = new Point(212, 147);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(91, 32);
            btnAddItem.TabIndex = 77;
            btnAddItem.Click += btnAddItem_Click;
            btnAddItem.Paint += btnAddItem_Paint;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 6);
            label6.Name = "label6";
            label6.Size = new Size(85, 22);
            label6.TabIndex = 12;
            label6.Text = "Add";
            label6.TextAlign = ContentAlignment.TopCenter;
            label6.Click += label6_Click;
            // 
            // AddSupply
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(315, 191);
            Controls.Add(btnAddItem);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(txtQty);
            Controls.Add(cmbCategory);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(txtItemName);
            Controls.Add(label5);
            Controls.Add(label19);
            Controls.Add(label22);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AddSupply";
            StartPosition = FormStartPosition.CenterScreen;
            Load += AddSupply_Load;
            btnAddItem.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQty;
        private RoundedPanel btnAddItem;
        private System.Windows.Forms.Label label6;
    }
}