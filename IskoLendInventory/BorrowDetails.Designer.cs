namespace IskoLendInventory
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label19 = new Label();
            label22 = new Label();
            tblBorrowDetail = new DataGridView();
            btnReturnDetails = new RoundedPanel();
            label1 = new Label();
            btnReturn = new RoundedPanel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)tblBorrowDetail).BeginInit();
            btnReturnDetails.SuspendLayout();
            btnReturn.SuspendLayout();
            SuspendLayout();
            // 
            // label19
            // 
            label19.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.Black;
            label19.Location = new Point(12, 62);
            label19.Name = "label19";
            label19.Size = new Size(436, 31);
            label19.TabIndex = 49;
            label19.Text = "Track individual borrowing details.";
            // 
            // label22
            // 
            label22.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.ForeColor = Color.Maroon;
            label22.Location = new Point(11, 26);
            label22.Name = "label22";
            label22.Size = new Size(307, 47);
            label22.TabIndex = 48;
            label22.Text = "Borrow Details";
            label22.Click += label22_Click;
            // 
            // tblBorrowDetail
            // 
            tblBorrowDetail.AllowUserToAddRows = false;
            tblBorrowDetail.AllowUserToDeleteRows = false;
            tblBorrowDetail.AllowUserToResizeColumns = false;
            tblBorrowDetail.AllowUserToResizeRows = false;
            tblBorrowDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tblBorrowDetail.BackgroundColor = SystemColors.Control;
            tblBorrowDetail.BorderStyle = BorderStyle.None;
            tblBorrowDetail.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Maroon;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Maroon;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tblBorrowDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tblBorrowDetail.ColumnHeadersHeight = 40;
            tblBorrowDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Moccasin;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            tblBorrowDetail.DefaultCellStyle = dataGridViewCellStyle2;
            tblBorrowDetail.EnableHeadersVisualStyles = false;
            tblBorrowDetail.GridColor = Color.DimGray;
            tblBorrowDetail.Location = new Point(11, 99);
            tblBorrowDetail.MultiSelect = false;
            tblBorrowDetail.Name = "tblBorrowDetail";
            tblBorrowDetail.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Maroon;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            tblBorrowDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            tblBorrowDetail.RowHeadersVisible = false;
            tblBorrowDetail.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.SelectionBackColor = Color.Moccasin;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            tblBorrowDetail.RowsDefaultCellStyle = dataGridViewCellStyle4;
            tblBorrowDetail.RowTemplate.Height = 40;
            tblBorrowDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tblBorrowDetail.Size = new Size(878, 372);
            tblBorrowDetail.TabIndex = 46;
            // 
            // btnReturnDetails
            // 
            btnReturnDetails.BackColor = Color.Orange;
            btnReturnDetails.Controls.Add(label1);
            btnReturnDetails.Location = new Point(524, 61);
            btnReturnDetails.Name = "btnReturnDetails";
            btnReturnDetails.Size = new Size(185, 32);
            btnReturnDetails.TabIndex = 52;
            btnReturnDetails.Click += btnReturnDetails_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 6);
            label1.Name = "label1";
            label1.Size = new Size(179, 22);
            label1.TabIndex = 12;
            label1.Text = "View Return Details";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.Orange;
            btnReturn.Controls.Add(label2);
            btnReturn.Location = new Point(729, 61);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(160, 32);
            btnReturn.TabIndex = 47;
            btnReturn.Click += btnReturnDetails_Click;
            btnReturn.Paint += btnReturn_Paint;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(16, 6);
            label2.Name = "label2";
            label2.Size = new Size(123, 22);
            label2.TabIndex = 12;
            label2.Text = "Return Item  +";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // BorrowDetails
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(900, 496);
            Controls.Add(btnReturnDetails);
            Controls.Add(label19);
            Controls.Add(label22);
            Controls.Add(btnReturn);
            Controls.Add(tblBorrowDetail);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "BorrowDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Load += BorrowDetails_Load;
            ((System.ComponentModel.ISupportInitialize)tblBorrowDetail).EndInit();
            btnReturnDetails.ResumeLayout(false);
            btnReturn.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private RoundedPanel btnReturn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tblBorrowDetail;
        private RoundedPanel btnReturnDetails;
        private System.Windows.Forms.Label label1;
    }
}