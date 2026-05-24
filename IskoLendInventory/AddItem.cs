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
    public partial class AddItem : Form
    {
        private int Quantity;
        private String Item;

        public AddItem()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (cmbItem.SelectedIndex == 0)
            {
                MessageBox.Show("Please enter an item.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtQty.Text == "")
            {
                MessageBox.Show("Please enter quantity.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                if (!int.TryParse(txtQty.Text, out Quantity))
                {
                    MessageBox.Show("Please enter a valid quantity.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Item = cmbItem.Text;
                    this.Close();
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            btnAddItem_Click(sender, e);
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }
    }
}
