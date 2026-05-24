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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbActionType = new System.Windows.Forms.ComboBox();
            this.txtSearchLog = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tblSupplyLogs = new System.Windows.Forms.DataGridView();
            this.Supply = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Facilitator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbDate = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblSupplyLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbActionType
            // 
            this.cmbActionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbActionType.FormattingEnabled = true;
            this.cmbActionType.Location = new System.Drawing.Point(376, 88);
            this.cmbActionType.Name = "cmbActionType";
            this.cmbActionType.Size = new System.Drawing.Size(121, 28);
            this.cmbActionType.TabIndex = 50;
            // 
            // txtSearchLog
            // 
            this.txtSearchLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchLog.Location = new System.Drawing.Point(12, 88);
            this.txtSearchLog.Name = "txtSearchLog";
            this.txtSearchLog.Size = new System.Drawing.Size(358, 26);
            this.txtSearchLog.TabIndex = 49;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(13, 47);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(436, 47);
            this.label19.TabIndex = 48;
            this.label19.Text = "Track facilitator changes on supplies.";
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Maroon;
            this.label22.Location = new System.Drawing.Point(12, 11);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(307, 47);
            this.label22.TabIndex = 47;
            this.label22.Text = "Supply Logs";
            // 
            // tblSupplyLogs
            // 
            this.tblSupplyLogs.AllowUserToAddRows = false;
            this.tblSupplyLogs.AllowUserToDeleteRows = false;
            this.tblSupplyLogs.AllowUserToResizeColumns = false;
            this.tblSupplyLogs.AllowUserToResizeRows = false;
            this.tblSupplyLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblSupplyLogs.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tblSupplyLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblSupplyLogs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblSupplyLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tblSupplyLogs.ColumnHeadersHeight = 40;
            this.tblSupplyLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tblSupplyLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Supply,
            this.Facilitator,
            this.ActionType,
            this.QtyStatus,
            this.Date});
            this.tblSupplyLogs.Enabled = false;
            this.tblSupplyLogs.EnableHeadersVisualStyles = false;
            this.tblSupplyLogs.GridColor = System.Drawing.Color.DimGray;
            this.tblSupplyLogs.Location = new System.Drawing.Point(12, 126);
            this.tblSupplyLogs.Name = "tblSupplyLogs";
            this.tblSupplyLogs.ReadOnly = true;
            this.tblSupplyLogs.RowHeadersVisible = false;
            this.tblSupplyLogs.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            this.tblSupplyLogs.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tblSupplyLogs.RowTemplate.Height = 40;
            this.tblSupplyLogs.Size = new System.Drawing.Size(746, 323);
            this.tblSupplyLogs.TabIndex = 46;
            // 
            // Supply
            // 
            this.Supply.HeaderText = "Supply";
            this.Supply.MinimumWidth = 6;
            this.Supply.Name = "Supply";
            this.Supply.ReadOnly = true;
            // 
            // Facilitator
            // 
            this.Facilitator.FillWeight = 102F;
            this.Facilitator.HeaderText = "Facilitator";
            this.Facilitator.MinimumWidth = 6;
            this.Facilitator.Name = "Facilitator";
            this.Facilitator.ReadOnly = true;
            // 
            // ActionType
            // 
            this.ActionType.FillWeight = 105F;
            this.ActionType.HeaderText = "Action Type";
            this.ActionType.MinimumWidth = 6;
            this.ActionType.Name = "ActionType";
            this.ActionType.ReadOnly = true;
            // 
            // QtyStatus
            // 
            this.QtyStatus.HeaderText = "Quantity Status";
            this.QtyStatus.MinimumWidth = 6;
            this.QtyStatus.Name = "QtyStatus";
            this.QtyStatus.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // cmbDate
            // 
            this.cmbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDate.FormattingEnabled = true;
            this.cmbDate.Location = new System.Drawing.Point(503, 88);
            this.cmbDate.Name = "cmbDate";
            this.cmbDate.Size = new System.Drawing.Size(121, 28);
            this.cmbDate.TabIndex = 51;
            // 
            // SupplyLogs
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(770, 461);
            this.Controls.Add(this.cmbDate);
            this.Controls.Add(this.cmbActionType);
            this.Controls.Add(this.txtSearchLog);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.tblSupplyLogs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SupplyLogs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SupplyLogs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblSupplyLogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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