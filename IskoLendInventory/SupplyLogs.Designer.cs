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
            cmbActionType = new ComboBox();
            txtSearchLog = new TextBox();
            label19 = new Label();
            label22 = new Label();
            tblSupplyLogs = new DataGridView();
            Supply = new DataGridViewTextBoxColumn();
            Facilitator = new DataGridViewTextBoxColumn();
            ActionType = new DataGridViewTextBoxColumn();
            QtyStatus = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            cmbDate = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)tblSupplyLogs).BeginInit();
            SuspendLayout();
            // 
            // cmbActionType
            // 
            cmbActionType.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbActionType.FormattingEnabled = true;
            cmbActionType.Location = new Point(376, 88);
            cmbActionType.Name = "cmbActionType";
            cmbActionType.Size = new Size(121, 28);
            cmbActionType.TabIndex = 50;
            // 
            // txtSearchLog
            // 
            txtSearchLog.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchLog.Location = new Point(12, 88);
            txtSearchLog.Name = "txtSearchLog";
            txtSearchLog.Size = new Size(358, 26);
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
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Highlight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tblSupplyLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tblSupplyLogs.ColumnHeadersHeight = 40;
            tblSupplyLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            tblSupplyLogs.Columns.AddRange(new DataGridViewColumn[] { Supply, Facilitator, ActionType, QtyStatus, Date });
            tblSupplyLogs.Enabled = false;
            tblSupplyLogs.EnableHeadersVisualStyles = false;
            tblSupplyLogs.GridColor = Color.DimGray;
            tblSupplyLogs.Location = new Point(12, 126);
            tblSupplyLogs.Name = "tblSupplyLogs";
            tblSupplyLogs.ReadOnly = true;
            tblSupplyLogs.RowHeadersVisible = false;
            tblSupplyLogs.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            tblSupplyLogs.RowsDefaultCellStyle = dataGridViewCellStyle2;
            tblSupplyLogs.RowTemplate.Height = 40;
            tblSupplyLogs.Size = new Size(746, 323);
            tblSupplyLogs.TabIndex = 46;
            // 
            // Supply
            // 
            Supply.HeaderText = "Supply";
            Supply.MinimumWidth = 6;
            Supply.Name = "Supply";
            Supply.ReadOnly = true;
            // 
            // Facilitator
            // 
            Facilitator.FillWeight = 102F;
            Facilitator.HeaderText = "Facilitator";
            Facilitator.MinimumWidth = 6;
            Facilitator.Name = "Facilitator";
            Facilitator.ReadOnly = true;
            // 
            // ActionType
            // 
            ActionType.FillWeight = 105F;
            ActionType.HeaderText = "Action Type";
            ActionType.MinimumWidth = 6;
            ActionType.Name = "ActionType";
            ActionType.ReadOnly = true;
            // 
            // QtyStatus
            // 
            QtyStatus.HeaderText = "Quantity Status";
            QtyStatus.MinimumWidth = 6;
            QtyStatus.Name = "QtyStatus";
            QtyStatus.ReadOnly = true;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.ReadOnly = true;
            // 
            // cmbDate
            // 
            cmbDate.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDate.FormattingEnabled = true;
            cmbDate.Location = new Point(503, 88);
            cmbDate.Name = "cmbDate";
            cmbDate.Size = new Size(121, 28);
            cmbDate.TabIndex = 51;
            // 
            // SupplyLogs
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(770, 461);
            Controls.Add(cmbDate);
            Controls.Add(cmbActionType);
            Controls.Add(txtSearchLog);
            Controls.Add(label19);
            Controls.Add(label22);
            Controls.Add(tblSupplyLogs);
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
        private System.Windows.Forms.DataGridView tblSupplyLogs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supply;
        private System.Windows.Forms.DataGridViewTextBoxColumn Facilitator;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtyStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.ComboBox cmbDate;
    }
}