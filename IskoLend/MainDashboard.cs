using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IskoLend
{
    public partial class MainDashboard : Form
    {
        public MainDashboard()
        {

            InitializeComponent();

            this.AutoScaleMode = AutoScaleMode.None;
            this.DoubleBuffered = true;



            tblBorrowSummary.Rows.Add("2025-002", "de Dela Cruz", "Laptop", "return", "returned");
            tblBorrowSummary.Rows.Add("2025-001", "ger Dela Cruz", "pc", "borrow", "completed");
            tblBorrowSummary.Rows.Add("2025-003", "san Dela Cruz", "Laptop", "borrow", "completed");
            tblBorrowSummary.Rows.Add("2025-001", "Juan Dela Cruz", "Laptop", "borrow", "completed");
            tblBorrowSummary.Rows.Add("2025-001", "Juan Dela Cruz", "Laptop", "borrow", "completed");
            tblBorrowSummary.Rows.Add("2025-001", "Juan Dela Cruz", "Laptop", "borrow", "completed");
            tblBorrowSummary.Rows.Add("2025-001", "Juan Dela Cruz", "Laptop", "borrow", "completed");

            tblBorrowRecord.Rows.Add("test", "test", "test", "test", "test","test");
            tblBorrowRecord.Rows.Add("test", "test", "test", "test", "test", "test");
            tblBorrowRecord.Rows.Add("test", "test", "test", "test", "test", "test");
            tblBorrowRecord.Rows.Add("test", "test", "test", "test", "test", "test");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbBorrowDate.Items.Add("Today");
            cmbBorrowDate.Items.Add("Yesterday");
            cmbBorrowDate.Items.Add("Last 7 Days");
            cmbBorrowDate.Items.Add("This Month");

            tblBorrowRecord.ClearSelection();
            tblBorrowSummary.ClearSelection();
        }

        private void btnBorrowDetails_Click(object sender, EventArgs e)
        {
            if (tblBorrowRecord.SelectedRows.Count > 0)
            {
                tblBorrowRecord.ClearSelection();
                BorrowDetails form = new BorrowDetails();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a row to view details", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            btnBorrowDetails_Click(sender, e);
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            BorrowItems form = new BorrowItems();
            form.ShowDialog();
        }

        private void CloseAllPanels()
        {
            pnlBorrowRecord.Visible = false;
            pnlDashboard.Visible = false;
            pnlSupplies.Visible = false;

        }
        private void label6_Click(object sender, EventArgs e)
        {
            btnBorrow_Click(sender, e);
        }


        private void btnDashboard_Click(object sender, EventArgs e)
        {
            CloseAllPanels();
            pnlDashboard.Visible = true;
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            CloseAllPanels();
            pnlBorrowRecord.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            btnTransactions_Click(sender, e);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            btnDashboard_Click(sender, e);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            btnDashboard_Click(sender, e);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            btnTransactions_Click(sender, e);
        }

        private void btnViewBorrows_Click(object sender, EventArgs e)
        {
            CloseAllPanels();
            pnlBorrowRecord.Visible = true;
        }

        private void Label26_Click(object sender, EventArgs e)
        {
            btnViewBorrows_Click(sender, e);
        }

        private void btnSupplies_Click(object sender, EventArgs e)
        {
            CloseAllPanels();
            pnlSupplies.Visible = true;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            btnSupplies_Click(sender, e);
        }

        
    }
}
