using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IskoLendDataManagement;
using IskoLendModel;

namespace IskoLendInventory
{
    public partial class AddFacilitator : Form
    {
        private readonly FacilitatorsDataService _dsFaci;

        public AddFacilitator(FacilitatorsDataService dsFaci)
        {
            InitializeComponent();
            _dsFaci = dsFaci;
            LoadPositionsToCombo();

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
                    if (cmbPosition.SelectedIndex == 0)
                    {
                        MessageBox.Show("Please enter position.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        Facilitator newfaci = new Facilitator
                        {
                            FacilitatorID = _dsFaci.GenerateFaciID(),
                            FirstName = txtFirstName.Text,
                            LastName = txtLastName.Text,
                            DesignationID = _dsFaci.getDesignationID(cmbPosition.Text),
                            IsActive = true
                        };
                        _dsFaci.AddFacilitator(newfaci);
                        this.DialogResult = DialogResult.OK;

                        this.Close();
                    }
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            btnAddFaci_Click(sender, e);
        }
        private void LoadPositionsToCombo()
        {
            var dt = _dsFaci.GetPositionsAvailable();

            var row = dt.NewRow();
            row["Position"] = "Position";
            dt.Rows.InsertAt(row, 0);

            cmbPosition.DataSource = null;
            cmbPosition.DisplayMember = "Position";
            cmbPosition.ValueMember = "DesignationID";
            cmbPosition.DataSource = dt;

            cmbPosition.SelectedIndex = 0;
        }
    }
}
