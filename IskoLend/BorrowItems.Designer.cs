namespace IskoLend
{
    partial class BorrowItems
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
            this.label22 = new System.Windows.Forms.Label();
            this.roundedPanel23 = new IskoLend.RoundedPanel2();
            this.roundedPanel24 = new IskoLend.RoundedPanel2();
            this.btnAddItem = new IskoLend.RoundedPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tblItems = new System.Windows.Forms.DataGridView();
            this.SupplyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.roundedPanel21 = new IskoLend.RoundedPanel2();
            this.roundedPanel22 = new IskoLend.RoundedPanel2();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.btnSave = new IskoLend.RoundedPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.roundedPanel23.SuspendLayout();
            this.roundedPanel24.SuspendLayout();
            this.btnAddItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblItems)).BeginInit();
            this.roundedPanel21.SuspendLayout();
            this.roundedPanel22.SuspendLayout();
            this.btnSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Maroon;
            this.label22.Location = new System.Drawing.Point(12, 9);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(307, 47);
            this.label22.TabIndex = 50;
            this.label22.Text = "Record Borrow";
            // 
            // roundedPanel23
            // 
            this.roundedPanel23.BackColor = System.Drawing.SystemColors.ControlLight;
            this.roundedPanel23.Controls.Add(this.roundedPanel24);
            this.roundedPanel23.Location = new System.Drawing.Point(20, 215);
            this.roundedPanel23.Name = "roundedPanel23";
            this.roundedPanel23.Size = new System.Drawing.Size(499, 258);
            this.roundedPanel23.TabIndex = 55;
            // 
            // roundedPanel24
            // 
            this.roundedPanel24.BackColor = System.Drawing.SystemColors.Control;
            this.roundedPanel24.Controls.Add(this.btnAddItem);
            this.roundedPanel24.Controls.Add(this.tblItems);
            this.roundedPanel24.Controls.Add(this.label1);
            this.roundedPanel24.Location = new System.Drawing.Point(0, 3);
            this.roundedPanel24.Name = "roundedPanel24";
            this.roundedPanel24.Size = new System.Drawing.Size(496, 252);
            this.roundedPanel24.TabIndex = 55;
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.Orange;
            this.btnAddItem.Controls.Add(this.label2);
            this.btnAddItem.Location = new System.Drawing.Point(17, 205);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(121, 32);
            this.btnAddItem.TabIndex = 57;
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
            this.label2.Text = "+ Add Item";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tblItems
            // 
            this.tblItems.AllowUserToAddRows = false;
            this.tblItems.AllowUserToDeleteRows = false;
            this.tblItems.AllowUserToResizeColumns = false;
            this.tblItems.AllowUserToResizeRows = false;
            this.tblItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblItems.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tblItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblItems.ColumnHeadersHeight = 40;
            this.tblItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tblItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupplyID,
            this.Item,
            this.Quantity});
            this.tblItems.Enabled = false;
            this.tblItems.EnableHeadersVisualStyles = false;
            this.tblItems.GridColor = System.Drawing.Color.DimGray;
            this.tblItems.Location = new System.Drawing.Point(17, 43);
            this.tblItems.Name = "tblItems";
            this.tblItems.ReadOnly = true;
            this.tblItems.RowHeadersVisible = false;
            this.tblItems.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            this.tblItems.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.tblItems.RowTemplate.Height = 40;
            this.tblItems.Size = new System.Drawing.Size(461, 156);
            this.tblItems.TabIndex = 56;
            // 
            // SupplyID
            // 
            this.SupplyID.HeaderText = "SupplyID";
            this.SupplyID.MinimumWidth = 6;
            this.SupplyID.Name = "SupplyID";
            this.SupplyID.ReadOnly = true;
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.MinimumWidth = 6;
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 38);
            this.label1.TabIndex = 53;
            this.label1.Text = "Items";
            // 
            // roundedPanel21
            // 
            this.roundedPanel21.BackColor = System.Drawing.SystemColors.ControlLight;
            this.roundedPanel21.Controls.Add(this.roundedPanel22);
            this.roundedPanel21.Location = new System.Drawing.Point(17, 59);
            this.roundedPanel21.Name = "roundedPanel21";
            this.roundedPanel21.Size = new System.Drawing.Size(502, 150);
            this.roundedPanel21.TabIndex = 54;
            // 
            // roundedPanel22
            // 
            this.roundedPanel22.BackColor = System.Drawing.SystemColors.Control;
            this.roundedPanel22.Controls.Add(this.label6);
            this.roundedPanel22.Controls.Add(this.label5);
            this.roundedPanel22.Controls.Add(this.cmbDate);
            this.roundedPanel22.Controls.Add(this.label4);
            this.roundedPanel22.Controls.Add(this.label19);
            this.roundedPanel22.Controls.Add(this.txtStudentID);
            this.roundedPanel22.Controls.Add(this.label24);
            this.roundedPanel22.Location = new System.Drawing.Point(3, 3);
            this.roundedPanel22.Name = "roundedPanel22";
            this.roundedPanel22.Size = new System.Drawing.Size(496, 144);
            this.roundedPanel22.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(65, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 23);
            this.label6.TabIndex = 59;
            this.label6.Text = "*";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(104, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 23);
            this.label5.TabIndex = 58;
            this.label5.Text = "*";
            // 
            // cmbDate
            // 
            this.cmbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDate.Location = new System.Drawing.Point(143, 93);
            this.cmbDate.MaxDate = new System.DateTime(2039, 12, 31, 0, 0, 0, 0);
            this.cmbDate.MinDate = new System.DateTime(2026, 5, 24, 0, 0, 0, 0);
            this.cmbDate.Name = "cmbDate";
            this.cmbDate.Size = new System.Drawing.Size(335, 26);
            this.cmbDate.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(13, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 24);
            this.label4.TabIndex = 56;
            this.label4.Text = "Date";
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(13, 52);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(95, 24);
            this.label19.TabIndex = 55;
            this.label19.Text = "StudentID";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentID.Location = new System.Drawing.Point(143, 49);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(335, 26);
            this.txtStudentID.TabIndex = 54;
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Maroon;
            this.label24.Location = new System.Drawing.Point(12, 11);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(264, 38);
            this.label24.TabIndex = 53;
            this.label24.Text = "Borrow Information";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Orange;
            this.btnSave.Controls.Add(this.label3);
            this.btnSave.Location = new System.Drawing.Point(359, 479);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 32);
            this.btnSave.TabIndex = 58;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Save Borrow";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // BorrowItems
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(537, 519);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.roundedPanel23);
            this.Controls.Add(this.roundedPanel21);
            this.Controls.Add(this.label22);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BorrowItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.BorrowItems_Load);
            this.roundedPanel23.ResumeLayout(false);
            this.roundedPanel24.ResumeLayout(false);
            this.btnAddItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblItems)).EndInit();
            this.roundedPanel21.ResumeLayout(false);
            this.roundedPanel22.ResumeLayout(false);
            this.roundedPanel22.PerformLayout();
            this.btnSave.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private RoundedPanel2 roundedPanel21;
        private RoundedPanel2 roundedPanel22;
        private RoundedPanel2 roundedPanel23;
        private RoundedPanel2 roundedPanel24;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tblItems;
        private RoundedPanel btnAddItem;
        private System.Windows.Forms.Label label2;
        private RoundedPanel btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker cmbDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}