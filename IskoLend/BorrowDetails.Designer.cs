namespace IskoLend
{
    partial class BorrowDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbBorrowDate = new System.Windows.Forms.ComboBox();
            this.txtSearchBorrow = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tblBorrowRecord = new System.Windows.Forms.DataGridView();
            this.Supply = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BorrowedQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReturnDetails = new IskoLend.RoundedPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReturn = new IskoLend.RoundedPanel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblBorrowRecord)).BeginInit();
            this.btnReturnDetails.SuspendLayout();
            this.btnReturn.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbBorrowDate
            // 
            this.cmbBorrowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBorrowDate.FormattingEnabled = true;
            this.cmbBorrowDate.Location = new System.Drawing.Point(324, 103);
            this.cmbBorrowDate.Name = "cmbBorrowDate";
            this.cmbBorrowDate.Size = new System.Drawing.Size(150, 28);
            this.cmbBorrowDate.TabIndex = 51;
            // 
            // txtSearchBorrow
            // 
            this.txtSearchBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBorrow.Location = new System.Drawing.Point(11, 103);
            this.txtSearchBorrow.Name = "txtSearchBorrow";
            this.txtSearchBorrow.Size = new System.Drawing.Size(307, 26);
            this.txtSearchBorrow.TabIndex = 50;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(12, 62);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(436, 47);
            this.label19.TabIndex = 49;
            this.label19.Text = "Track individual borrowing details.";
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Maroon;
            this.label22.Location = new System.Drawing.Point(11, 26);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(307, 47);
            this.label22.TabIndex = 48;
            this.label22.Text = "Borrow Details";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // tblBorrowRecord
            // 
            this.tblBorrowRecord.AllowUserToAddRows = false;
            this.tblBorrowRecord.AllowUserToDeleteRows = false;
            this.tblBorrowRecord.AllowUserToResizeColumns = false;
            this.tblBorrowRecord.AllowUserToResizeRows = false;
            this.tblBorrowRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblBorrowRecord.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tblBorrowRecord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblBorrowRecord.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblBorrowRecord.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblBorrowRecord.ColumnHeadersHeight = 40;
            this.tblBorrowRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tblBorrowRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Supply,
            this.BorrowedQty,
            this.ReturnStatus});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblBorrowRecord.DefaultCellStyle = dataGridViewCellStyle2;
            this.tblBorrowRecord.EnableHeadersVisualStyles = false;
            this.tblBorrowRecord.GridColor = System.Drawing.Color.DimGray;
            this.tblBorrowRecord.Location = new System.Drawing.Point(11, 141);
            this.tblBorrowRecord.MultiSelect = false;
            this.tblBorrowRecord.Name = "tblBorrowRecord";
            this.tblBorrowRecord.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblBorrowRecord.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tblBorrowRecord.RowHeadersVisible = false;
            this.tblBorrowRecord.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.tblBorrowRecord.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tblBorrowRecord.RowTemplate.Height = 40;
            this.tblBorrowRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblBorrowRecord.Size = new System.Drawing.Size(878, 330);
            this.tblBorrowRecord.TabIndex = 46;
            // 
            // Supply
            // 
            this.Supply.HeaderText = "Supply";
            this.Supply.MinimumWidth = 6;
            this.Supply.Name = "Supply";
            this.Supply.ReadOnly = true;
            // 
            // BorrowedQty
            // 
            this.BorrowedQty.HeaderText = "BorrowedQty";
            this.BorrowedQty.MinimumWidth = 6;
            this.BorrowedQty.Name = "BorrowedQty";
            this.BorrowedQty.ReadOnly = true;
            // 
            // ReturnStatus
            // 
            this.ReturnStatus.HeaderText = "ReturnStatus";
            this.ReturnStatus.MinimumWidth = 6;
            this.ReturnStatus.Name = "ReturnStatus";
            this.ReturnStatus.ReadOnly = true;
            // 
            // btnReturnDetails
            // 
            this.btnReturnDetails.BackColor = System.Drawing.Color.Orange;
            this.btnReturnDetails.Controls.Add(this.label1);
            this.btnReturnDetails.Location = new System.Drawing.Point(538, 103);
            this.btnReturnDetails.Name = "btnReturnDetails";
            this.btnReturnDetails.Size = new System.Drawing.Size(185, 32);
            this.btnReturnDetails.TabIndex = 52;
            this.btnReturnDetails.Click += new System.EventHandler(this.btnReturnDetails_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "View Return Details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Orange;
            this.btnReturn.Controls.Add(this.label2);
            this.btnReturn.Location = new System.Drawing.Point(729, 103);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(160, 32);
            this.btnReturn.TabIndex = 47;
            this.btnReturn.Click += new System.EventHandler(this.btnReturnDetails_Click);
            this.btnReturn.Paint += new System.Windows.Forms.PaintEventHandler(this.btnReturn_Paint);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Return Item  +";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BorrowDetails
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(900, 496);
            this.Controls.Add(this.btnReturnDetails);
            this.Controls.Add(this.cmbBorrowDate);
            this.Controls.Add(this.txtSearchBorrow);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.tblBorrowRecord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BorrowDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.BorrowDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblBorrowRecord)).EndInit();
            this.btnReturnDetails.ResumeLayout(false);
            this.btnReturn.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBorrowDate;
        private System.Windows.Forms.TextBox txtSearchBorrow;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private RoundedPanel btnReturn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tblBorrowRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supply;
        private System.Windows.Forms.DataGridViewTextBoxColumn BorrowedQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnStatus;
        private RoundedPanel btnReturnDetails;
        private System.Windows.Forms.Label label1;
    }
}