using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IskoLend
{
    public partial class BorrowDetails : Form
    {
        public BorrowDetails()
        {
            InitializeComponent();
            tblBorrowRecord.Rows.Add("test", "test", "test", "test", "test", "test");
            tblBorrowRecord.Rows.Add("test", "test", "test", "test", "test", "test");
            tblBorrowRecord.Rows.Add("test", "test", "test", "test", "test", "test");
            tblBorrowRecord.Rows.Add("test", "test", "test", "test", "test", "test");
        }

        private void BorrowDetails_Load(object sender, EventArgs e)
        {
            cmbBorrowDate.Items.Add("Today");
            cmbBorrowDate.Items.Add("Yesterday");
            cmbBorrowDate.Items.Add("Last 7 Days");
            cmbBorrowDate.Items.Add("This Month");

            MaximizeBox = false;

            
            tblBorrowRecord.ClearSelection();

        }
        private void btnReturnDetails_Click(object sender, EventArgs e)
        {
            if (tblBorrowRecord.SelectedRows.Count > 0)
            {
                tblBorrowRecord.ClearSelection();
                ReturnDetails form = new ReturnDetails();
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
            if (tblBorrowRecord.SelectedRows.Count > 0)
            {
                tblBorrowRecord.ClearSelection();
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
