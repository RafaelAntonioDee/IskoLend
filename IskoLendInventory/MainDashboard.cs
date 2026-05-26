using IskoLendDataManagement;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace IskoLendInventory
{
    public partial class MainDashboard : Form
    {
        public string currFaci;
        DashboardDataService dsDB = new DashboardDataService();
        BorrowingRecordDataService dsBR = new BorrowingRecordDataService();
        public MainDashboard()
        {

            InitializeComponent();
            InitCategoryComboPlaceholder();
            cmbFacilitator.DropDown += cmbFacilitator_DropDown;
            this.AutoScaleMode = AutoScaleMode.None;
            this.DoubleBuffered = true;

            LoadBorrowingRecords();
            LoadBorrowSummary();

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
                DataGridViewRow row = tblBorrowRecord.SelectedRows[0];
                string? BorrowID = Convert.ToString(row.Cells[0].Value);
                tblBorrowRecord.ClearSelection();
                BorrowDetails form = new BorrowDetails(dsBR, BorrowID, currFaci);
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
        private void cmbFacilitator_SelectedIndexChanged(object sender, EventArgs e)
        {
            currFaci = lblFacilitatorID.Text;
            dsDB.FacilitatorOff(currFaci);
            lblFacilitatorID.Text = dsDB.GetFacilitatorID(cmbFacilitator.Text);
            currFaci = lblFacilitatorID.Text;
            dsDB.FacilitatorOn(currFaci);
        }
        
        private void InitCategoryComboPlaceholder()
        {
            var faci = new DataTable();
            faci.Columns.Add("FacilitatorName", typeof(string));
            faci.Rows.Add("Facilitators");

            cmbFacilitator.DisplayMember = "FacilitatorName";
            cmbFacilitator.ValueMember = "FacilitatorName";
            cmbFacilitator.DataSource = faci;

            cmbFacilitator.SelectedIndex = 0;
        }
        private void LoadFacilitatorsToCombo()
        {
            var faci = dsDB.GetFacilitators();

            var row = faci.NewRow();
            row["FacilitatorName"] = "Facilitators";
            faci.Rows.InsertAt(row, 0);

            cmbFacilitator.DataSource = null;
            cmbFacilitator.DisplayMember = "FacilitatorName";
            cmbFacilitator.ValueMember = "FacilitatorName";
            cmbFacilitator.DataSource = faci;

            cmbFacilitator.SelectedIndex = 0;
        }


        private void cmbFacilitator_DropDown(object sender, EventArgs e)
        {
            LoadFacilitatorsToCombo();
        }
        private void LoadBorrowingRecords()
        {
            tblBorrowRecord.DataSource = dsBR.GetAllBorrowingRecord();
        }
        private void btnBorrow_Click(object sender, EventArgs e)
        {
            BorrowItems form = new BorrowItems(dsBR,currFaci);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadBorrowingRecords();
            }
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

        private void LoadBorrowSummary()
        {
            tblBorrowSummary.DataSource = dsDB.GetAllSummary();
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            CloseAllPanels();

            pnlDashboard.Visible = true;
            LoadBorrowSummary();
            tblBorrowSummary.ClearSelection();

        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            CloseAllPanels();

            pnlBorrowRecord.Visible = true;

            tblBorrowRecord.ClearSelection();

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

            tblBorrowRecord.ClearSelection();
        }

        private void Label26_Click(object sender, EventArgs e)
        {
            btnViewBorrows_Click(sender, e);
        }

        private void btnSupplies_Click(object sender, EventArgs e)
        {

            CloseAllPanels();
            pnlSupplies.Visible = true;

            tblSupplies.ClearSelection();

        }

        private void label8_Click(object sender, EventArgs e)
        {
            btnSupplies_Click(sender, e);
        }

        private void btnViewLogs_Click(object sender, EventArgs e)
        {

            SupplyLogs form = new SupplyLogs();
            form.ShowDialog();

            tblSupplies.ClearSelection();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            AddSupply form = new AddSupply();
            form.ShowDialog();

            tblSupplies.ClearSelection();

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

                DialogResult result = MessageBox.Show("Are you sure you want to remove this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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


            AddFacilitator form = new AddFacilitator();
            form.ShowDialog();

            tblFacilitators.ClearSelection();
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
            tblFacilitators.ClearSelection();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            btnSupplies_Click(sender, e);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            btnFacilitators_Click(sender, e);
        }

        private void label30_Click(object sender, EventArgs e)
        {
            btnExit_Click_1(sender, e);
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            currFaci = lblFacilitatorID.Text;
            dsDB.FacilitatorOff(currFaci);
            Dispose();
        }

        
    }
}
