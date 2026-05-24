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
    public partial class AddFacilitator : Form
    {
        public AddFacilitator()
        {
            InitializeComponent();
        }

        private void AddFacilitator_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void btnAddFaci_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "")
            {
                MessageBox.Show("Please enter first name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtLastName.Text == "")
                {
                    MessageBox.Show("Please enter last name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (txtPosition.Text == "")
                    {
                        MessageBox.Show("Please enter position.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    { 
                        this.Close();
                    }
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            btnAddFaci_Click(sender, e);
        }
    }
}
