namespace IskoLendInventory
{
    partial class AddFacilitator
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
            txtFirstName = new TextBox();
            btnAddFaci = new RoundedPanel();
            label6 = new Label();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            txtLastName = new TextBox();
            label5 = new Label();
            label19 = new Label();
            label22 = new Label();
            cmbPosition = new ComboBox();
            btnAddFaci.SuspendLayout();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(133, 50);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(170, 26);
            txtFirstName.TabIndex = 118;
            // 
            // btnAddFaci
            // 
            btnAddFaci.BackColor = Color.Orange;
            btnAddFaci.Controls.Add(label6);
            btnAddFaci.Location = new Point(212, 158);
            btnAddFaci.Name = "btnAddFaci";
            btnAddFaci.Size = new Size(91, 32);
            btnAddFaci.TabIndex = 114;
            btnAddFaci.Click += btnAddFaci_Click;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 6);
            label6.Name = "label6";
            label6.Size = new Size(85, 22);
            label6.TabIndex = 12;
            label6.Text = "Add";
            label6.TextAlign = ContentAlignment.TopCenter;
            label6.Click += label6_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(89, 114);
            label2.Name = "label2";
            label2.Size = new Size(22, 23);
            label2.TabIndex = 113;
            label2.Text = "*";
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(13, 117);
            label4.Name = "label4";
            label4.Size = new Size(95, 24);
            label4.TabIndex = 112;
            label4.Text = "Position";
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(105, 82);
            label1.Name = "label1";
            label1.Size = new Size(22, 23);
            label1.TabIndex = 110;
            label1.Text = "*";
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(13, 85);
            label3.Name = "label3";
            label3.Size = new Size(95, 24);
            label3.TabIndex = 109;
            label3.Text = "LastName";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(133, 82);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(170, 26);
            txtLastName.TabIndex = 108;
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(105, 52);
            label5.Name = "label5";
            label5.Size = new Size(22, 23);
            label5.TabIndex = 107;
            label5.Text = "*";
            // 
            // label19
            // 
            label19.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.Black;
            label19.Location = new Point(13, 56);
            label19.Name = "label19";
            label19.Size = new Size(98, 24);
            label19.TabIndex = 106;
            label19.Text = "FirstName";
            // 
            // label22
            // 
            label22.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.ForeColor = Color.Maroon;
            label22.Location = new Point(12, 9);
            label22.Name = "label22";
            label22.Size = new Size(307, 47);
            label22.TabIndex = 105;
            label22.Text = "Add Facilitator";
            // 
            // cmbPosition
            // 
            cmbPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPosition.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Location = new Point(133, 114);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(170, 28);
            cmbPosition.TabIndex = 119;
            // 
            // AddFacilitator
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(315, 202);
            Controls.Add(cmbPosition);
            Controls.Add(txtFirstName);
            Controls.Add(btnAddFaci);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(txtLastName);
            Controls.Add(label5);
            Controls.Add(label19);
            Controls.Add(label22);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AddFacilitator";
            StartPosition = FormStartPosition.CenterScreen;
            Load += AddFacilitator_Load;
            btnAddFaci.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private RoundedPanel btnAddFaci;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private ComboBox cmbPosition;
    }
}