using IskoLendDataManagement;
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
    public partial class BorrowDetails : Form
    {
        private readonly string _borrowID;
        private readonly BorrowingRecordDataService _dsBR;
        private readonly string _currFaci;
        public BorrowDetails(BorrowingRecordDataService dbBR, string BorrowID, string currFaci)
        {
            InitializeComponent();
            _borrowID = BorrowID;
            _dsBR = dbBR;
            _currFaci = currFaci;
            tblBorrowDetail.DataSource = dbBR.GetSelectedBorrowDetail(BorrowID);
        }

        private void BorrowDetails_Load(object sender, EventArgs e)
        {
            cmbBorrowDate.Items.Add("Today");
            cmbBorrowDate.Items.Add("Yesterday");
            cmbBorrowDate.Items.Add("Last 7 Days");
            cmbBorrowDate.Items.Add("This Month");

            MaximizeBox = false;

            
            tblBorrowDetail.ClearSelection();

        }
        private void btnReturnDetails_Click(object sender, EventArgs e)
        {
            if (tblBorrowDetail.SelectedRows.Count > 0)
            {
                DataGridViewRow row = tblBorrowDetail.SelectedRows[0];
                string? ItemName = row.Cells[0].Value.ToString();
                tblBorrowDetail.ClearSelection();
                ReturnDetails form = new ReturnDetails(_dsBR,_borrowID, ItemName);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a supply borrowed to view return details", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            btnReturnDetails_Click(sender, e);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (tblBorrowDetail.SelectedRows.Count > 0)
            {
                tblBorrowDetail.ClearSelection();
                ReturnItems form = new ReturnItems();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a supply to return ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            btnReturn_Click(sender, e);
        }

        private void btnReturn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }
    }
}
