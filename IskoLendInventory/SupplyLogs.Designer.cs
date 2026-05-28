namespace IskoLendInventory
{
    partial class SupplyLogs
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
            cmbActionType = new ComboBox();
            txtSearchLog = new TextBox();
            label19 = new Label();
            label22 = new Label();
            cmbDate = new ComboBox();
            tblSupplyLogs = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)tblSupplyLogs).BeginInit();
            SuspendLayout();
            // 
            // cmbActionType
            // 
            cmbActionType.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbActionType.FormattingEnabled = true;
            cmbActionType.Location = new Point(376, 88);
            cmbActionType.Name = "cmbActionType";
            cmbActionType.Size = new Size(121, 24);
            cmbActionType.TabIndex = 50;
            // 
            // txtSearchLog
            // 
            txtSearchLog.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchLog.Location = new Point(12, 88);
            txtSearchLog.Name = "txtSearchLog";
            txtSearchLog.Size = new Size(358, 23);
            txtSearchLog.TabIndex = 49;
            // 
            // label19
            // 
            label19.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.Black;
            label19.Location = new Point(13, 47);
            label19.Name = "label19";
            label19.Size = new Size(436, 47);
            label19.TabIndex = 48;
            label19.Text = "Track facilitator changes on supplies.";
            // 
            // label22
            // 
            label22.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.ForeColor = Color.Maroon;
            label22.Location = new Point(12, 11);
            label22.Name = "label22";
            label22.Size = new Size(307, 47);
            label22.TabIndex = 47;
            label22.Text = "Supply Logs";
            // 
            // cmbDate
            // 
            cmbDate.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDate.FormattingEnabled = true;
            cmbDate.Location = new Point(503, 88);
            cmbDate.Name = "cmbDate";
            cmbDate.Size = new Size(121, 24);
            cmbDate.TabIndex = 51;
            // 
            // tblSupplyLogs
            // 
            tblSupplyLogs.AllowUserToAddRows = false;
            tblSupplyLogs.AllowUserToDeleteRows = false;
            tblSupplyLogs.AllowUserToResizeColumns = false;
            tblSupplyLogs.AllowUserToResizeRows = false;
            tblSupplyLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tblSupplyLogs.BackgroundColor = SystemColors.Control;
            tblSupplyLogs.BorderStyle = BorderStyle.None;
            tblSupplyLogs.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Maroon;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Maroon;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tblSupplyLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tblSupplyLogs.ColumnHeadersHeight = 40;
            tblSupplyLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Moccasin;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            tblSupplyLogs.DefaultCellStyle = dataGridViewCellStyle2;
            tblSupplyLogs.EnableHeadersVisualStyles = false;
            tblSupplyLogs.GridColor = Color.DimGray;
            tblSupplyLogs.Location = new Point(13, 122);
            tblSupplyLogs.MultiSelect = false;
            tblSupplyLogs.Name = "tblSupplyLogs";
            tblSupplyLogs.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Maroon;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            tblSupplyLogs.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            tblSupplyLogs.RowHeadersVisible = false;
            tblSupplyLogs.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.SelectionBackColor = Color.Moccasin;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            tblSupplyLogs.RowsDefaultCellStyle = dataGridViewCellStyle4;
            tblSupplyLogs.RowTemplate.Height = 40;
            tblSupplyLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tblSupplyLogs.Size = new Size(962, 415);
            tblSupplyLogs.TabIndex = 52;
            // 
            // SupplyLogs
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(987, 549);
            Controls.Add(tblSupplyLogs);
            Controls.Add(cmbDate);
            Controls.Add(cmbActionType);
            Controls.Add(txtSearchLog);
            Controls.Add(label19);
            Controls.Add(label22);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "SupplyLogs";
            StartPosition = FormStartPosition.CenterScreen;
            Load += SupplyLogs_Load;
            ((System.ComponentModel.ISupportInitialize)tblSupplyLogs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cmbActionType;
        private System.Windows.Forms.TextBox txtSearchLog;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cmbDate;
        private DataGridView tblSupplyLogs;
    }
}