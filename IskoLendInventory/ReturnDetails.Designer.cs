namespace IskoLendInventory
{
    partial class ReturnDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tblReturnDetails = new System.Windows.Forms.DataGridView();
            this.ReturnDetailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supply = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FacilitatorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbReturnDate = new System.Windows.Forms.ComboBox();
            this.txtSearchBorrow = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblReturnDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // tblReturnDetails
            // 
            this.tblReturnDetails.AllowUserToAddRows = false;
            this.tblReturnDetails.AllowUserToDeleteRows = false;
            this.tblReturnDetails.AllowUserToResizeColumns = false;
            this.tblReturnDetails.AllowUserToResizeRows = false;
            this.tblReturnDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblReturnDetails.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tblReturnDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblReturnDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblReturnDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblReturnDetails.ColumnHeadersHeight = 40;
            this.tblReturnDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tblReturnDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReturnDetailID,
            this.Supply,
            this.FacilitatorID,
            this.ReturnQty,
            this.ReturnDate});
            this.tblReturnDetails.Enabled = false;
            this.tblReturnDetails.EnableHeadersVisualStyles = false;
            this.tblReturnDetails.GridColor = System.Drawing.Color.DimGray;
            this.tblReturnDetails.Location = new System.Drawing.Point(12, 124);
            this.tblReturnDetails.Name = "tblReturnDetails";
            this.tblReturnDetails.ReadOnly = true;
            this.tblReturnDetails.RowHeadersVisible = false;
            this.tblReturnDetails.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            this.tblReturnDetails.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.tblReturnDetails.RowTemplate.Height = 40;
            this.tblReturnDetails.Size = new System.Drawing.Size(676, 254);
            this.tblReturnDetails.TabIndex = 40;
            this.tblReturnDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblBorrowRecord_CellContentClick);
            // 
            // ReturnDetailID
            // 
            this.ReturnDetailID.FillWeight = 105F;
            this.ReturnDetailID.HeaderText = "ReturnDetailID";
            this.ReturnDetailID.MinimumWidth = 6;
            this.ReturnDetailID.Name = "ReturnDetailID";
            this.ReturnDetailID.ReadOnly = true;
            // 
            // Supply
            // 
            this.Supply.HeaderText = "Supply";
            this.Supply.MinimumWidth = 6;
            this.Supply.Name = "Supply";
            this.Supply.ReadOnly = true;
            // 
            // FacilitatorID
            // 
            this.FacilitatorID.FillWeight = 102F;
            this.FacilitatorID.HeaderText = "FacilitatorID";
            this.FacilitatorID.MinimumWidth = 6;
            this.FacilitatorID.Name = "FacilitatorID";
            this.FacilitatorID.ReadOnly = true;
            // 
            // ReturnQty
            // 
            this.ReturnQty.HeaderText = "ReturnQty";
            this.ReturnQty.MinimumWidth = 6;
            this.ReturnQty.Name = "ReturnQty";
            this.ReturnQty.ReadOnly = true;
            // 
            // ReturnDate
            // 
            this.ReturnDate.HeaderText = "ReturnDate";
            this.ReturnDate.MinimumWidth = 6;
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.ReadOnly = true;
            // 
            // cmbReturnDate
            // 
            this.cmbReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbReturnDate.FormattingEnabled = true;
            this.cmbReturnDate.Location = new System.Drawing.Point(376, 86);
            this.cmbReturnDate.Name = "cmbReturnDate";
            this.cmbReturnDate.Size = new System.Drawing.Size(176, 28);
            this.cmbReturnDate.TabIndex = 45;
            this.cmbReturnDate.SelectedIndexChanged += new System.EventHandler(this.cmbBorrowDate_SelectedIndexChanged);
            // 
            // txtSearchBorrow
            // 
            this.txtSearchBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBorrow.Location = new System.Drawing.Point(12, 86);
            this.txtSearchBorrow.Name = "txtSearchBorrow";
            this.txtSearchBorrow.Size = new System.Drawing.Size(358, 26);
            this.txtSearchBorrow.TabIndex = 44;
            this.txtSearchBorrow.TextChanged += new System.EventHandler(this.txtSearchBorrow_TextChanged);
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(13, 45);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(436, 47);
            this.label19.TabIndex = 43;
            this.label19.Text = "Track returning transactions.";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Maroon;
            this.label22.Location = new System.Drawing.Point(12, 9);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(307, 47);
            this.label22.TabIndex = 42;
            this.label22.Text = "Return Details";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // ReturnDetails
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(700, 390);
            this.Controls.Add(this.cmbReturnDate);
            this.Controls.Add(this.txtSearchBorrow);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.tblReturnDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ReturnDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ReturnDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblReturnDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView tblReturnDetails;
        private System.Windows.Forms.ComboBox cmbReturnDate;
        private System.Windows.Forms.TextBox txtSearchBorrow;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDetailID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supply;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacilitatorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
    }
}