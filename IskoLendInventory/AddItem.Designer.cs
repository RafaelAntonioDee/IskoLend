namespace IskoLendInventory
{
    partial class AddItem
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
            label5 = new Label();
            label19 = new Label();
            btnAddItem = new RoundedPanel();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            txtQty = new TextBox();
            cmbItem = new ComboBox();
            cmbCategory = new ComboBox();
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
            label22.Size = new Size(269, 47);
            label22.TabIndex = 59;
            label22.Text = "Add Item";
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(85, 87);
            label5.Name = "label5";
            label5.Size = new Size(22, 23);
            label5.TabIndex = 63;
            label5.Text = "*";
            // 
            // label19
            // 
            label19.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.Black;
            label19.Location = new Point(12, 90);
            label19.Name = "label19";
            label19.Size = new Size(95, 24);
            label19.TabIndex = 61;
            label19.Text = "Item";
            // 
            // btnAddItem
            // 
            btnAddItem.BackColor = Color.Orange;
            btnAddItem.Controls.Add(label2);
            btnAddItem.Location = new Point(212, 158);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(91, 32);
            btnAddItem.TabIndex = 62;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 6);
            label2.Name = "label2";
            label2.Size = new Size(85, 22);
            label2.TabIndex = 12;
            label2.Text = "Add";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(85, 116);
            label1.Name = "label1";
            label1.Size = new Size(22, 23);
            label1.TabIndex = 66;
            label1.Text = "*";
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(12, 119);
            label3.Name = "label3";
            label3.Size = new Size(95, 24);
            label3.TabIndex = 65;
            label3.Text = "Quantity";
            // 
            // txtQty
            // 
            txtQty.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQty.Location = new Point(136, 116);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(167, 26);
            txtQty.TabIndex = 64;
            // 
            // cmbItem
            // 
            cmbItem.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbItem.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbItem.FormattingEnabled = true;
            cmbItem.Location = new Point(136, 82);
            cmbItem.Name = "cmbItem";
            cmbItem.Size = new Size(168, 28);
            cmbItem.TabIndex = 67;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(136, 48);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(168, 28);
            cmbCategory.TabIndex = 70;
            // 
            // label6
            // 
            label6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(12, 56);
            label6.Name = "label6";
            label6.Size = new Size(95, 24);
            label6.TabIndex = 68;
            label6.Text = "Category";
            // 
            // AddItem
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(316, 207);
            Controls.Add(cmbCategory);
            Controls.Add(label6);
            Controls.Add(cmbItem);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(txtQty);
            Controls.Add(label22);
            Controls.Add(label5);
            Controls.Add(label19);
            Controls.Add(btnAddItem);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AddItem";
            StartPosition = FormStartPosition.CenterScreen;
            Load += AddItem_Load;
            btnAddItem.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label19;
        private RoundedPanel btnAddItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.ComboBox cmbItem;
        private ComboBox cmbCategory;
        private Label label6;
    }
}