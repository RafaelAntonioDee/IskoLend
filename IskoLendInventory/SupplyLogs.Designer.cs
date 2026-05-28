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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
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
            cmbActionType.Size = new Size(121, 28);
            cmbActionType.TabIndex = 50;
            cmbActionType.SelectedIndexChanged += cmbActionType_SelectedIndexChanged;
            // 
            // txtSearchLog
            // 
            txtSearchLog.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchLog.Location = new Point(12, 88);
            txtSearchLog.Name = "txtSearchLog";
            txtSearchLog.Size = new Size(358, 26);
            txtSearchLog.TabIndex = 49;
            txtSearchLog.TextChanged += txtSearchLog_TextChanged;
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
            cmbDate.Size = new Size(121, 28);
            cmbDate.TabIndex = 51;
            cmbDate.SelectedIndexChanged += cmbDate_SelectedIndexChanged;
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
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.Maroon;
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = Color.White;
            dataGridViewCellStyle9.SelectionBackColor = Color.Maroon;
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            tblSupplyLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            tblSupplyLogs.ColumnHeadersHeight = 40;
            tblSupplyLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = Color.Moccasin;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            tblSupplyLogs.DefaultCellStyle = dataGridViewCellStyle10;
            tblSupplyLogs.EnableHeadersVisualStyles = false;
            tblSupplyLogs.GridColor = Color.DimGray;
            tblSupplyLogs.Location = new Point(13, 122);
            tblSupplyLogs.MultiSelect = false;
            tblSupplyLogs.Name = "tblSupplyLogs";
            tblSupplyLogs.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Control;
            dataGridViewCellStyle11.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = Color.Maroon;
            dataGridViewCellStyle11.SelectionForeColor = Color.White;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            tblSupplyLogs.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            tblSupplyLogs.RowHeadersVisible = false;
            tblSupplyLogs.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = SystemColors.Control;
            dataGridViewCellStyle12.SelectionBackColor = Color.Moccasin;
            dataGridViewCellStyle12.SelectionForeColor = Color.Black;
            tblSupplyLogs.RowsDefaultCellStyle = dataGridViewCellStyle12;
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