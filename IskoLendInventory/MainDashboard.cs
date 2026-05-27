using IskoLendDataManagement;
using IskoLendModel;
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
        FacilitatorsDataService dsFaci = new FacilitatorsDataService();
        SupplyDataService dsSup = new SupplyDataService();


        public MainDashboard()
        {

            InitializeComponent();
            InitCategoryComboPlaceholder();
            cmbFacilitator.DropDown += cmbFacilitator_DropDown;
            this.AutoScaleMode = AutoScaleMode.None;
            this.DoubleBuffered = true;
            cmbBorrowStatus.DropDown += cmbBorrowStatus_DropDown;

            LoadFacilitatorRecords();
            LoadBorrowingRecords();
            LoadBorrowSummary();
            LoadSupplies();


        }



        private void Form1_Load(object sender, EventArgs e)
        {
            cmbBorrowDate.Items.Clear();
            cmbBorrowDate.Items.Add("Date");
            cmbBorrowDate.Items.Add("Today");
            cmbBorrowDate.Items.Add("Yesterday");
            cmbBorrowDate.Items.Add("Last 7 Days");
            cmbBorrowDate.Items.Add("This Month");

            cmbBorrowDate.SelectedIndex = 0;

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
                currFaci = lblFacilitatorID.Text;
                if (!string.IsNullOrEmpty(currFaci))
                {
                    DataGridViewRow row = tblBorrowRecord.SelectedRows[0];
                    string? BorrowID = Convert.ToString(row.Cells[0].Value);
                    tblBorrowRecord.ClearSelection();
                    BorrowDetails form = new BorrowDetails(dsBR, BorrowID, currFaci);
                    form.ShowDialog();
                    LoadBorrowingRecords();
                    LoadBorrowSummary();
                }
                else
                {
                    MessageBox.Show("Please Select Your Facilitator ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

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
            //dsDB.FacilitatorOff(currFaci);
            lblFacilitatorID.Text = dsDB.GetFacilitatorID(cmbFacilitator.Text);
            currFaci = lblFacilitatorID.Text;
            //dsDB.FacilitatorOn(currFaci);
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

            var stat = new DataTable();
            stat.Columns.Add("StatusID", typeof(string));
            stat.Rows.Add("Status");

            cmbBorrowStatus.DataSource = null;
            cmbBorrowStatus.DisplayMember = "StatusID";
            cmbBorrowStatus.ValueMember = "StatusID";
            cmbBorrowStatus.DataSource = stat;

            cmbBorrowStatus.SelectedIndex = 0;

        }
        private void LoadFacilitatorsToCombo()
        {
            var faci = dsFaci.GetActiveFacilitators();

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
        private void LoadSupplies()
        {
            tblSupplies.DataSource = dsSup.GetAllSupplies();
        }
        private void LoadFacilitatorRecords()
        {
            tblFacilitators.DataSource = dsFaci.GetAllFacilitatorRecord();
            tblFacilitators.Columns["Position"].FillWeight = 200;
        }
        private void btnBorrow_Click(object sender, EventArgs e)
        {
            currFaci = lblFacilitatorID.Text;
            if (!string.IsNullOrEmpty(currFaci))
            {
                BorrowItems form = new BorrowItems(dsBR, currFaci);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadBorrowingRecords();
                    LoadBorrowSummary();
                }
            }
            else
            {
                MessageBox.Show("Please Select Your Facilitator ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
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
            currFaci = lblFacilitatorID.Text;
            if (!string.IsNullOrEmpty(currFaci))
            {
                AddSupply form = new AddSupply(dsSup, currFaci);
                form.ShowDialog();

                tblSupplies.ClearSelection();
                LoadSupplies();
            }
            else
            {
                MessageBox.Show("Please Select Your Facilitator ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (tblSupplies.SelectedRows.Count > 0)
            {
                currFaci = lblFacilitatorID.Text;
                if (!string.IsNullOrEmpty(currFaci))
                {
                    DataGridViewRow row = tblSupplies.SelectedRows[0];
                    string? SupplyID = Convert.ToString(row.Cells[0].Value);
                    EditSupply form = new EditSupply(dsSup, SupplyID);
                    form.ShowDialog();
                    LoadSupplies();
                    tblSupplies.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Please Select Your Facilitator ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

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
                currFaci = lblFacilitatorID.Text;
                if (!string.IsNullOrEmpty(currFaci))
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to remove this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        DataGridViewRow row = tblSupplies.SelectedRows[0];
                        string? SupplyID = Convert.ToString(row.Cells[0].Value);
                        dsSup.RemoveSupply(SupplyID);
                        LoadSupplies();
                        tblSupplies.ClearSelection();
                    }
                    else
                    {
                        // cancelled
                    }
                }
                else
                {
                    MessageBox.Show("Please Select Your Facilitator ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
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


            AddFacilitator form = new AddFacilitator(dsFaci);
            form.ShowDialog();

            tblFacilitators.ClearSelection();
            LoadFacilitatorRecords();

        }

        private void btnEditFaci_Click(object sender, EventArgs e)
        {

            if (tblFacilitators.SelectedRows.Count > 0)
            {
                DataGridViewRow row = tblFacilitators.SelectedRows[0];
                string? FacilitatorID = Convert.ToString(row.Cells[0].Value);
                EditFacilitator form = new EditFacilitator(dsFaci, FacilitatorID);
                form.ShowDialog();
                LoadFacilitatorRecords();
                tblFacilitators.ClearSelection();

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


                DialogResult result = MessageBox.Show("Are you sure you want to remove this facilitator?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DataGridViewRow row = tblFacilitators.SelectedRows[0];
                    string? FacilitatorID = Convert.ToString(row.Cells[0].Value);
                    dsFaci.RemoveFacilitator(FacilitatorID);
                    LoadFacilitatorRecords();
                    tblFacilitators.ClearSelection();
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
            DialogResult result = MessageBox.Show("Are you sure you want to exit the system", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                currFaci = lblFacilitatorID.Text;
                //dsDB.FacilitatorOff(currFaci);
                Dispose();
            }

        }

        private void cmbBorrowDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFilteredBorrowingRecords();
        }

        private void cmbBorrowStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadFilteredBorrowingRecords();
        }

        private void txtSearchBorrow_TextChanged(object sender, EventArgs e)
        {
            LoadFilteredBorrowingRecords();
        }
        private void LoadFilteredBorrowingRecords()
        {
            tblBorrowRecord.DataSource = dsBR.FilteredBorrowingRecord(txtSearchBorrow.Text, cmbBorrowDate.SelectedText, cmbBorrowStatus.SelectedText);
        }

        private void cmbBorrowStatus_DropDown(object sender, EventArgs e)
        {
            LoadCmbBorrowStatus(sender, e);
        }

        private void LoadCmbBorrowStatus(object sender, EventArgs e)
        {
            var stat = dsBR.GetAllStatusID();

            var row = stat.NewRow();
            row["StatusID"] = "Status";
            stat.Rows.InsertAt(row, 0);

            cmbBorrowStatus.DataSource = null;
            cmbBorrowStatus.DisplayMember = "StatusID";
            cmbBorrowStatus.ValueMember = "StatusID";
            cmbBorrowStatus.DataSource = stat;

            cmbBorrowStatus.SelectedIndex = 0;
        }
    }
}
