using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IskoLendInventory
{
    public partial class SupplyLogs : Form
    {
        public SupplyLogs()
        {
            InitializeComponent();
        }

        private void SupplyLogs_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;

            cmbDate.Items.Add("Today");
            cmbDate.Items.Add("Yesterday");
            cmbDate.Items.Add("Last 7 Days");
            cmbDate.Items.Add("This Month");
        }
    }
}
