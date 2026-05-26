namespace IskoLendInventory
{
    partial class EditFacilitator
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
            btnEditFaci = new RoundedPanel();
            label6 = new Label();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            txtLastName = new TextBox();
            label5 = new Label();
            label19 = new Label();
            label22 = new Label();
            label7 = new Label();
            label8 = new Label();
            cmbActive = new ComboBox();
            txtFirstName = new TextBox();
            cmbPosition = new ComboBox();
            btnEditFaci.SuspendLayout();
            SuspendLayout();
            // 
            // btnEditFaci
            // 
            btnEditFaci.BackColor = Color.Orange;
            btnEditFaci.Controls.Add(label6);
            btnEditFaci.Location = new Point(212, 188);
            btnEditFaci.Name = "btnEditFaci";
            btnEditFaci.Size = new Size(91, 32);
            btnEditFaci.TabIndex = 99;
            btnEditFaci.Click += btnEditFaci_Click;
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
            label6.Text = "Edit";
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
            label2.TabIndex = 98;
            label2.Text = "*";
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(13, 117);
            label4.Name = "label4";
            label4.Size = new Size(95, 24);
            label4.TabIndex = 97;
            label4.Text = "Position";
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(105, 82);
            label1.Name = "label1";
            label1.Size = new Size(22, 23);
            label1.TabIndex = 94;
            label1.Text = "*";
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(13, 85);
            label3.Name = "label3";
            label3.Size = new Size(95, 24);
            label3.TabIndex = 93;
            label3.Text = "LastName";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(133, 82);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(170, 26);
            txtLastName.TabIndex = 92;
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(105, 52);
            label5.Name = "label5";
            label5.Size = new Size(22, 23);
            label5.TabIndex = 91;
            label5.Text = "*";
            // 
            // label19
            // 
            label19.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.Black;
            label19.Location = new Point(13, 56);
            label19.Name = "label19";
            label19.Size = new Size(98, 24);
            label19.TabIndex = 90;
            label19.Text = "FirstName";
            // 
            // label22
            // 
            label22.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.ForeColor = Color.Maroon;
            label22.Location = new Point(12, 9);
            label22.Name = "label22";
            label22.Size = new Size(307, 47);
            label22.TabIndex = 89;
            label22.Text = "Edit Facilitator";
            // 
            // label7
            // 
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Maroon;
            label7.Location = new Point(89, 146);
            label7.Name = "label7";
            label7.Size = new Size(22, 23);
            label7.TabIndex = 102;
            label7.Text = "*";
            // 
            // label8
            // 
            label8.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(13, 149);
            label8.Name = "label8";
            label8.Size = new Size(95, 24);
            label8.TabIndex = 101;
            label8.Text = "isActive";
            // 
            // cmbActive
            // 
            cmbActive.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbActive.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbActive.FormattingEnabled = true;
            cmbActive.Location = new Point(133, 146);
            cmbActive.Name = "cmbActive";
            cmbActive.Size = new Size(170, 28);
            cmbActive.TabIndex = 103;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(133, 50);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(170, 26);
            txtFirstName.TabIndex = 104;
            // 
            // cmbPosition
            // 
            cmbPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPosition.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Location = new Point(133, 113);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(170, 28);
            cmbPosition.TabIndex = 105;
            // 
            // EditFacilitator
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(315, 232);
            Controls.Add(cmbPosition);
            Controls.Add(txtFirstName);
            Controls.Add(cmbActive);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(btnEditFaci);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(txtLastName);
            Controls.Add(label5);
            Controls.Add(label19);
            Controls.Add(label22);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "EditFacilitator";
            StartPosition = FormStartPosition.CenterScreen;
            Load += EditFacilitator_Load;
            btnEditFaci.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RoundedPanel btnEditFaci;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbActive;
        private System.Windows.Forms.TextBox txtFirstName;
        private ComboBox cmbPosition;
    }
}