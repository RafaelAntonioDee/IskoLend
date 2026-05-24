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
            this.label5 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtReturnQty = new System.Windows.Forms.TextBox();
            this.btnAddItem = new IskoLendInventory.RoundedPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblItemToReturn = new System.Windows.Forms.Label();
            this.btnAddItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(154, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 23);
            this.label5.TabIndex = 62;
            this.label5.Text = "*";
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(15, 63);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(159, 24);
            this.label19.TabIndex = 60;
            this.label19.Text = "Return Quantity";
            // 
            // txtReturnQty
            // 
            this.txtReturnQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturnQty.Location = new System.Drawing.Point(193, 60);
            this.txtReturnQty.Name = "txtReturnQty";
            this.txtReturnQty.Size = new System.Drawing.Size(181, 26);
            this.txtReturnQty.TabIndex = 59;
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.Orange;
            this.btnAddItem.Controls.Add(this.label2);
            this.btnAddItem.Location = new System.Drawing.Point(253, 98);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(121, 32);
            this.btnAddItem.TabIndex = 61;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Return";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblItemToReturn
            // 
            this.lblItemToReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemToReturn.ForeColor = System.Drawing.Color.Maroon;
            this.lblItemToReturn.Location = new System.Drawing.Point(14, 16);
            this.lblItemToReturn.Name = "lblItemToReturn";
            this.lblItemToReturn.Size = new System.Drawing.Size(307, 47);
            this.lblItemToReturn.TabIndex = 63;
            this.lblItemToReturn.Text = "Return _____";
            // 
            // ReturnItems
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(386, 142);
            this.Controls.Add(this.lblItemToReturn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtReturnQty);
            this.Controls.Add(this.btnAddItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ReturnItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ReturnItems_Load);
            this.btnAddItem.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtReturnQty;
        private RoundedPanel btnAddItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblItemToReturn;
    }
}