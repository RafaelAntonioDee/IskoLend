namespace IskoLendInventory
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label22 = new Label();
            roundedPanel23 = new RoundedPanel2();
            roundedPanel24 = new RoundedPanel2();
            btnAddItem = new RoundedPanel();
            label2 = new Label();
            tblItems = new DataGridView();
            label1 = new Label();
            roundedPanel21 = new RoundedPanel2();
            roundedPanel22 = new RoundedPanel2();
            txtDateTime = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label19 = new Label();
            txtStudentID = new TextBox();
            label24 = new Label();
            btnSave = new RoundedPanel();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            roundedPanel23.SuspendLayout();
            roundedPanel24.SuspendLayout();
            btnAddItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tblItems).BeginInit();
            roundedPanel21.SuspendLayout();
            roundedPanel22.SuspendLayout();
            btnSave.SuspendLayout();
            SuspendLayout();
            // 
            // label22
            // 
            label22.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.ForeColor = Color.Maroon;
            label22.Location = new Point(12, 9);
            label22.Name = "label22";
            label22.Size = new Size(307, 47);
            label22.TabIndex = 50;
            label22.Text = "Record Borrow";
            // 
            // roundedPanel23
            // 
            roundedPanel23.BackColor = SystemColors.ControlLight;
            roundedPanel23.Controls.Add(roundedPanel24);
            roundedPanel23.Location = new Point(20, 215);
            roundedPanel23.Name = "roundedPanel23";
            roundedPanel23.Size = new Size(499, 258);
            roundedPanel23.TabIndex = 55;
            // 
            // roundedPanel24
            // 
            roundedPanel24.BackColor = SystemColors.Control;
            roundedPanel24.Controls.Add(btnAddItem);
            roundedPanel24.Controls.Add(tblItems);
            roundedPanel24.Controls.Add(label1);
            roundedPanel24.Location = new Point(0, 3);
            roundedPanel24.Name = "roundedPanel24";
            roundedPanel24.Size = new Size(496, 252);
            roundedPanel24.TabIndex = 55;
            // 
            // btnAddItem
            // 
            btnAddItem.BackColor = Color.Orange;
            btnAddItem.Controls.Add(label2);
            btnAddItem.Location = new Point(17, 205);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(121, 32);
            btnAddItem.TabIndex = 57;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 6);
            label2.Name = "label2";
            label2.Size = new Size(115, 22);
            label2.TabIndex = 12;
            label2.Text = "+ Add Item";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // tblItems
            // 
            tblItems.AllowUserToAddRows = false;
            tblItems.AllowUserToResizeColumns = false;
            tblItems.AllowUserToResizeRows = false;
            tblItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tblItems.BackgroundColor = SystemColors.Control;
            tblItems.BorderStyle = BorderStyle.None;
            tblItems.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Maroon;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Maroon;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Highlight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tblItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tblItems.ColumnHeadersHeight = 40;
            tblItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            tblItems.EnableHeadersVisualStyles = false;
            tblItems.GridColor = Color.DimGray;
            tblItems.Location = new Point(17, 43);
            tblItems.Name = "tblItems";
            tblItems.ReadOnly = true;
            tblItems.RowHeadersVisible = false;
            tblItems.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Moccasin;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            tblItems.RowsDefaultCellStyle = dataGridViewCellStyle2;
            tblItems.RowTemplate.Height = 40;
            tblItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tblItems.Size = new Size(461, 156);
            tblItems.TabIndex = 56;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(264, 38);
            label1.TabIndex = 53;
            label1.Text = "Items";
            // 
            // roundedPanel21
            // 
            roundedPanel21.BackColor = SystemColors.ControlLight;
            roundedPanel21.Controls.Add(roundedPanel22);
            roundedPanel21.Location = new Point(17, 59);
            roundedPanel21.Name = "roundedPanel21";
            roundedPanel21.Size = new Size(502, 150);
            roundedPanel21.TabIndex = 54;
            // 
            // roundedPanel22
            // 
            roundedPanel22.BackColor = SystemColors.Control;
            roundedPanel22.Controls.Add(txtDateTime);
            roundedPanel22.Controls.Add(label5);
            roundedPanel22.Controls.Add(label4);
            roundedPanel22.Controls.Add(label19);
            roundedPanel22.Controls.Add(txtStudentID);
            roundedPanel22.Controls.Add(label24);
            roundedPanel22.Location = new Point(3, 3);
            roundedPanel22.Name = "roundedPanel22";
            roundedPanel22.Size = new Size(496, 144);
            roundedPanel22.TabIndex = 55;
            // 
            // txtDateTime
            // 
            txtDateTime.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDateTime.Location = new Point(143, 92);
            txtDateTime.Name = "txtDateTime";
            txtDateTime.ReadOnly = true;
            txtDateTime.Size = new Size(335, 26);
            txtDateTime.TabIndex = 59;
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(104, 48);
            label5.Name = "label5";
            label5.Size = new Size(22, 23);
            label5.TabIndex = 58;
            label5.Text = "*";
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(13, 95);
            label4.Name = "label4";
            label4.Size = new Size(113, 24);
            label4.TabIndex = 56;
            label4.Text = "Date / Time";
            // 
            // label19
            // 
            label19.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.Black;
            label19.Location = new Point(13, 52);
            label19.Name = "label19";
            label19.Size = new Size(95, 24);
            label19.TabIndex = 55;
            label19.Text = "StudentID";
            // 
            // txtStudentID
            // 
            txtStudentID.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStudentID.Location = new Point(143, 49);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(335, 26);
            txtStudentID.TabIndex = 54;
            // 
            // label24
            // 
            label24.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.ForeColor = Color.Maroon;
            label24.Location = new Point(12, 11);
            label24.Name = "label24";
            label24.Size = new Size(264, 38);
            label24.TabIndex = 53;
            label24.Text = "Borrow Information";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Orange;
            btnSave.Controls.Add(label3);
            btnSave.Location = new Point(359, 479);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(160, 32);
            btnSave.TabIndex = 58;
            btnSave.Click += btnSave_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(16, 6);
            label3.Name = "label3";
            label3.Size = new Size(123, 22);
            label3.TabIndex = 12;
            label3.Text = "Save Borrow";
            label3.TextAlign = ContentAlignment.TopCenter;
            label3.Click += label3_Click;
            // 
            // BorrowItems
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(537, 519);
            Controls.Add(btnSave);
            Controls.Add(roundedPanel23);
            Controls.Add(roundedPanel21);
            Controls.Add(label22);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "BorrowItems";
            StartPosition = FormStartPosition.CenterScreen;
            Load += BorrowItems_Load;
            roundedPanel23.ResumeLayout(false);
            roundedPanel24.ResumeLayout(false);
            btnAddItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tblItems).EndInit();
            roundedPanel21.ResumeLayout(false);
            roundedPanel22.ResumeLayout(false);
            roundedPanel22.PerformLayout();
            btnSave.ResumeLayout(false);
            ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private TextBox txtDateTime;
        private System.Windows.Forms.Timer timer1;
    }
}