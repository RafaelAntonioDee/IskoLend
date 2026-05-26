using IskoLendDataManagement;
using IskoLendModel;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace IskoLendInventory
{
    public partial class ReturnItems : Form
    {
        private int Quantity;
        private readonly BorrowingRecordDataService _dsBR;
        private readonly ReturnDetail _returnDetail;
        public ReturnItems(BorrowingRecordDataService dsbr, ReturnDetail ReturnDetail)
        {
            InitializeComponent();

            _dsBR = dsbr;
            _returnDetail = ReturnDetail;
            lblItemToReturn.Text = $"Return {_dsBR.GetSupplyName(_returnDetail.R_SupplyID)}";
        }

        private void ReturnItems_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtReturnQty.Text, out int qty) || qty <= 0)
            {
                MessageBox.Show("Please enter a valid quantity (> 0).",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int remaining = _dsBR.GetRemaining(_returnDetail.R_BorrowID, _returnDetail.R_SupplyID);

            if (qty > remaining)
            {
                MessageBox.Show($"Return quantity cannot be greater than remaining. Remaining: {remaining}.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _returnDetail.ReturnedQty = qty;
                _returnDetail.ReturnDate = DateTime.Now;

                _dsBR.AddReturnDetail(_returnDetail);

                MessageBox.Show("Item returned successfully.",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK; // only on success
                this.Close();
            }
            catch (InvalidOperationException ex)
            {
                // This catches: Remaining is negative..., or any business-rule InvalidOperationException you throw
                MessageBox.Show(ex.Message, "Invalid Return", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            btnAddItem_Click(sender, e);
        }

        private void btnLost_Click(object sender, EventArgs e)
        {

        }
    }
}
