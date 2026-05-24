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
    public partial class EditFacilitator : Form
    {
        public EditFacilitator()
        {
            InitializeComponent();
        }

        private void EditFacilitator_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;

            cmbActive.Items.Add("True");
            cmbActive.Items.Add("False");
        }

        private void btnEditFaci_Click(object sender, EventArgs e)
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
                        if (cmbActive.Text == "")
                        {
                            MessageBox.Show("Please state if the facilitator is active.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            btnEditFaci_Click(sender, e);
        }
    }
}
