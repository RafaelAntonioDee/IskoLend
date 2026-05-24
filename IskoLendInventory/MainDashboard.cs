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
using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IskoLendInventory
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

            tblSupplies.Rows.Add("test", "test", "test", "test", "test", "test");
            tblSupplies.Rows.Add("test", "test", "test", "test", "test", "test");
            tblSupplies.Rows.Add("test", "test", "test", "test", "test", "test");
            tblSupplies.Rows.Add("test", "test", "test", "test", "test", "test");

            tblFacilitators.Rows.Add("test", "test", "test", "test", true);
            tblFacilitators.Rows.Add("test", "test", "test", "test", true);
            tblFacilitators.Rows.Add("test", "test", "test", "test", false);
            tblFacilitators.Rows.Add("test", "test", "test", "test", false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbBorrowDate.Items.Add("Today");
            cmbBorrowDate.Items.Add("Yesterday");
            cmbBorrowDate.Items.Add("Last 7 Days");
            cmbBorrowDate.Items.Add("This Month");

            cmbActive.Items.Add("Active");
            cmbActive.Items.Add("Inactive");

            tblBorrowRecord.ClearSelection();
            tblBorrowSummary.ClearSelection();
            tblSupplies.ClearSelection();
            tblFacilitators.ClearSelection();
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
            pnlFacilitators.Visible = false;

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

        private void btnViewLogs_Click(object sender, EventArgs e)
        {
            tblSupplies.ClearSelection();

            SupplyLogs form = new SupplyLogs();
            form.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tblSupplies.ClearSelection();

            AddSupply form = new AddSupply();
            form.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (tblSupplies.SelectedRows.Count > 0)
            {
                tblSupplies.ClearSelection();
                EditSupply form = new EditSupply();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a supply to edit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }  
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (tblSupplies.SelectedRows.Count > 0)
            {
                tblSupplies.ClearSelection();

                DialogResult result = MessageBox.Show("Are you sure you want to remove this item?","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // proceed
                }
                else
                {
                    // cancelled
                }
            }
            else
            {
                MessageBox.Show("Please select a supply to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            btnViewLogs_Click(sender, e);
        }

        private void label29_Click(object sender, EventArgs e)
        {
            btnAdd_Click(sender, e);
        }

        private void lbl28_Click(object sender, EventArgs e)
        {
            btnEdit_Click(sender, e);
        }

        private void lbl29_Click(object sender, EventArgs e)
        {
            btnRemove_Click(sender, e);
        }

        private void btnAddFaci_Click(object sender, EventArgs e)
        {
            tblFacilitators.ClearSelection();

            AddFacilitator form = new AddFacilitator();
            form.ShowDialog();
        }

        private void btnEditFaci_Click(object sender, EventArgs e)
        {

            if (tblFacilitators.SelectedRows.Count > 0)
            {
                tblFacilitators.ClearSelection();

                EditFacilitator form = new EditFacilitator();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select which facilitator to edit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRemoveFaci_Click(object sender, EventArgs e)
        {

            if (tblFacilitators.SelectedRows.Count > 0)
            {

                tblFacilitators.ClearSelection();

                DialogResult result = MessageBox.Show("Are you sure you want to remove this facilitator?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // proceed
                }
                else
                {
                    // cancelled
                }
            }
            else
            {
                MessageBox.Show("Please select which facilitator to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {
            btnAddFaci_Click(sender, e);
        }

        private void label28_Click(object sender, EventArgs e)
        {
            btnEditFaci_Click(sender, e);
        }

        private void label31_Click(object sender, EventArgs e)
        {
            btnRemoveFaci_Click(sender, e);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            btnFacilitators_Click(sender, e);
        }

        private void btnFacilitators_Click(object sender, EventArgs e)
        {
            CloseAllPanels();
            pnlFacilitators.Visible = true;
        }


    }
}
