namespace IskoLendInventory
{
    partial class ReturnItems
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
            label5 = new Label();
            label19 = new Label();
            txtReturnQty = new TextBox();
            btnAddItem = new RoundedPanel();
            label2 = new Label();
            lblItemToReturn = new Label();
            btnLost = new RoundedPanel();
            label1 = new Label();
            btnAddItem.SuspendLayout();
            btnLost.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(154, 59);
            label5.Name = "label5";
            label5.Size = new Size(22, 23);
            label5.TabIndex = 62;
            label5.Text = "*";
            // 
            // label19
            // 
            label19.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.Black;
            label19.Location = new Point(15, 63);
            label19.Name = "label19";
            label19.Size = new Size(159, 24);
            label19.TabIndex = 60;
            label19.Text = "Return Quantity";
            // 
            // txtReturnQty
            // 
            txtReturnQty.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtReturnQty.Location = new Point(193, 60);
            txtReturnQty.Name = "txtReturnQty";
            txtReturnQty.Size = new Size(181, 23);
            txtReturnQty.TabIndex = 59;
            // 
            // btnAddItem
            // 
            btnAddItem.BackColor = Color.Orange;
            btnAddItem.Controls.Add(label2);
            btnAddItem.Location = new Point(253, 98);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(121, 32);
            btnAddItem.TabIndex = 61;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 6);
            label2.Name = "label2";
            label2.Size = new Size(115, 22);
            label2.TabIndex = 12;
            label2.Text = "Return";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // lblItemToReturn
            // 
            lblItemToReturn.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItemToReturn.ForeColor = Color.Maroon;
            lblItemToReturn.Location = new Point(14, 16);
            lblItemToReturn.Name = "lblItemToReturn";
            lblItemToReturn.Size = new Size(307, 47);
            lblItemToReturn.TabIndex = 63;
            lblItemToReturn.Text = "Return _____";
            // 
            // btnLost
            // 
            btnLost.BackColor = Color.Orange;
            btnLost.Controls.Add(label1);
            btnLost.Location = new Point(113, 99);
            btnLost.Name = "btnLost";
            btnLost.Size = new Size(121, 32);
            btnLost.TabIndex = 64;
            btnLost.Click += btnLost_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 6);
            label1.Name = "label1";
            label1.Size = new Size(115, 22);
            label1.TabIndex = 12;
            label1.Text = "Lost";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // ReturnItems
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(386, 142);
            Controls.Add(lblItemToReturn);
            Controls.Add(label5);
            Controls.Add(label19);
            Controls.Add(txtReturnQty);
            Controls.Add(btnLost);
            Controls.Add(btnAddItem);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "ReturnItems";
            StartPosition = FormStartPosition.CenterScreen;
            Load += ReturnItems_Load;
            btnAddItem.ResumeLayout(false);
            btnLost.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtReturnQty;
        private RoundedPanel btnAddItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblItemToReturn;
        private RoundedPanel btnLost;
        private Label label1;
    }
}