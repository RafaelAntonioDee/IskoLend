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
    public partial class EditSupply : Form
    {
        private int Quantity;
        private string Category;
        private string Item;

        public EditSupply()
        {
            InitializeComponent();
        }

        private void EditSupply_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;

        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedIndex == 0)
            {
                MessageBox.Show("Please enter item category.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtItemName.Text == "")
            {
                MessageBox.Show("Please enter an item.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!int.TryParse(txtQty.Text, out Quantity))
                {
                    MessageBox.Show("Please enter a valid quantity.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Item = txtItemName.Text;
                    Category = cmbCategory.Text;
                    this.Close();
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            btnEditItem_Click(sender, e);
        }
    }
}
