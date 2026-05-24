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

        public ReturnItems()
        {
            InitializeComponent();
        }

        private void ReturnItems_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtReturnQty.Text, out Quantity))
            {
                MessageBox.Show("Please enter a valid quantity.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            btnAddItem_Click(sender, e);
        }
    }
}
