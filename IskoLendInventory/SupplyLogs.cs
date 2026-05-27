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

            cmbDate.Items.Add("Today");
            cmbDate.Items.Add("Yesterday");
            cmbDate.Items.Add("Last 7 Days");
            cmbDate.Items.Add("This Month");

            LoadTblSupplyLogs();

        }

        private void LoadTblSupplyLogs()
        {
            tblSupplyLogs.DataSource = _dsSup.GetSupplyLogs();
            tblSupplyLogs.Columns["Date"].FillWeight = 150;
            tblSupplyLogs.Columns["Facilitator"].FillWeight = 200;
            tblSupplyLogs.ClearSelection();
        }
    }
}
