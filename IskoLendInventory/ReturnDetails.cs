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
    public partial class ReturnDetails : Form
    {
        private readonly BorrowingRecordDataService _dsBR;
        private readonly string _borrowID;
        private readonly string _itemName;
        public ReturnDetails(BorrowingRecordDataService dsBR, string BorrowID, string ItemName)
        {

            InitializeComponent();
            _dsBR = dsBR;
            _borrowID = BorrowID;
            _itemName = ItemName;
            LoadTblReturnDetails();
        }
        public void LoadTblReturnDetails()
        {
            tblReturnDetails.DataSource = _dsBR.GetSelectedReturnDetail(_borrowID, _itemName);
        }


        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tblBorrowRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbBorrowDate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSearchBorrow_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }
    }
}
