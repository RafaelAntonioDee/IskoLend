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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tblReturnDetails = new DataGridView();
            cmbReturnDate = new ComboBox();
            txtSearchBorrow = new TextBox();
            label19 = new Label();
            label22 = new Label();
            ((System.ComponentModel.ISupportInitialize)tblReturnDetails).BeginInit();
            SuspendLayout();
            // 
            // tblReturnDetails
            // 
            tblReturnDetails.AllowUserToAddRows = false;
            tblReturnDetails.AllowUserToDeleteRows = false;
            tblReturnDetails.AllowUserToResizeColumns = false;
            tblReturnDetails.AllowUserToResizeRows = false;
            tblReturnDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tblReturnDetails.BackgroundColor = SystemColors.Control;
            tblReturnDetails.BorderStyle = BorderStyle.None;
            tblReturnDetails.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Maroon;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Highlight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tblReturnDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tblReturnDetails.ColumnHeadersHeight = 40;
            tblReturnDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            tblReturnDetails.Enabled = false;
            tblReturnDetails.EnableHeadersVisualStyles = false;
            tblReturnDetails.GridColor = Color.DimGray;
            tblReturnDetails.Location = new Point(12, 124);
            tblReturnDetails.Name = "tblReturnDetails";
            tblReturnDetails.ReadOnly = true;
            tblReturnDetails.RowHeadersVisible = false;
            tblReturnDetails.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            tblReturnDetails.RowsDefaultCellStyle = dataGridViewCellStyle2;
            tblReturnDetails.RowTemplate.Height = 40;
            tblReturnDetails.Size = new Size(676, 254);
            tblReturnDetails.TabIndex = 40;
            tblReturnDetails.CellContentClick += tblBorrowRecord_CellContentClick;
            // 
            // cmbReturnDate
            // 
            cmbReturnDate.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbReturnDate.FormattingEnabled = true;
            cmbReturnDate.Location = new Point(376, 86);
            cmbReturnDate.Name = "cmbReturnDate";
            cmbReturnDate.Size = new Size(176, 24);
            cmbReturnDate.TabIndex = 45;
            cmbReturnDate.SelectedIndexChanged += cmbBorrowDate_SelectedIndexChanged;
            // 
            // txtSearchBorrow
            // 
            txtSearchBorrow.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchBorrow.Location = new Point(12, 86);
            txtSearchBorrow.Name = "txtSearchBorrow";
            txtSearchBorrow.Size = new Size(358, 23);
            txtSearchBorrow.TabIndex = 44;
            txtSearchBorrow.TextChanged += txtSearchBorrow_TextChanged;
            // 
            // label19
            // 
            label19.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.Black;
            label19.Location = new Point(13, 45);
            label19.Name = "label19";
            label19.Size = new Size(436, 47);
            label19.TabIndex = 43;
            label19.Text = "Track returning transactions.";
            label19.Click += label19_Click;
            // 
            // label22
            // 
            label22.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.ForeColor = Color.Maroon;
            label22.Location = new Point(12, 9);
            label22.Name = "label22";
            label22.Size = new Size(307, 47);
            label22.TabIndex = 42;
            label22.Text = "Return Details";
            label22.Click += label22_Click;
            // 
            // ReturnDetails
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(700, 390);
            Controls.Add(cmbReturnDate);
            Controls.Add(txtSearchBorrow);
            Controls.Add(label19);
            Controls.Add(label22);
            Controls.Add(tblReturnDetails);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "ReturnDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Load += ReturnDetails_Load;
            ((System.ComponentModel.ISupportInitialize)tblReturnDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView tblReturnDetails;
        private System.Windows.Forms.ComboBox cmbReturnDate;
        private System.Windows.Forms.TextBox txtSearchBorrow;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
    }
}