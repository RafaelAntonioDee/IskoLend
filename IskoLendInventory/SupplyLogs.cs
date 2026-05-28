using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IskoLendDataManagement;

namespace IskoLendInventory
{
    public partial class SupplyLogs : Form
    {
        private readonly SupplyDataService _dsSup;

        public SupplyLogs(SupplyDataService dsSup)
        {
            InitializeComponent();


            _dsSup = dsSup;

        }

        private void SupplyLogs_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;

            cmbDate.Items.Clear();
            cmbDate.Items.Add("Date");
            cmbDate.Items.Add("Today");
            cmbDate.Items.Add("Yesterday");
            cmbDate.Items.Add("Last 7 Days");
            cmbDate.Items.Add("This Month");

            cmbDate.SelectedIndex = 0;

            cmbActionType.Items.Clear();
            cmbActionType.Items.Add("Type");
            cmbActionType.Items.Add("Borrow");
            cmbActionType.Items.Add("Return");
            cmbActionType.Items.Add("Add");
            cmbActionType.Items.Add("Edit");

            cmbActionType.SelectedIndex = 0;

            LoadTblSupplyLogs();

        }

        private void LoadTblSupplyLogs()
        {
            tblSupplyLogs.DataSource = _dsSup.GetSupplyLogs();
            tblSupplyLogs.Columns["Date"].FillWeight = 150;
            tblSupplyLogs.Columns["Facilitator"].FillWeight = 200;
            tblSupplyLogs.ClearSelection();
        }

        private void cmbDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearchLog_TextChanged(sender, e);
        }

        private void cmbActionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearchLog_TextChanged(sender, e);
        }

        private void txtSearchLog_TextChanged(object sender, EventArgs e)
        {
            tblSupplyLogs.DataSource = _dsSup.FilterSupplyLogs(txtSearchLog.Text, cmbActionType.Text, cmbDate.Text);
        }

    }
}
