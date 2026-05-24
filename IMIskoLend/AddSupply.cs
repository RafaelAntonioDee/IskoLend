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

namespace IskoLend
{
    public partial class AddSupply : Form
    {
        private int Quantity;
        private string Category;
        private string Item;

        public AddSupply()
        {
            InitializeComponent();
        }

        private void AddSupply_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;

        }

        private void btnAddItem_Click(object sender, EventArgs e)
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
            btnAddItem_Click(sender, e);
        }
    }
}
