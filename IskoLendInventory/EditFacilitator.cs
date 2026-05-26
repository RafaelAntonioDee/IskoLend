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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace IskoLendInventory
{
    public partial class EditFacilitator : Form
    {
        private readonly string _FaciID;
        private readonly FacilitatorsDataService _dsFaci;

        public EditFacilitator(FacilitatorsDataService dsFaci, string FacilitatorID)
        {
            InitializeComponent();
            _FaciID = FacilitatorID;
            _dsFaci = dsFaci;
        }

        private void EditFacilitator_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;

            cmbActive.Items.Add("True");
            cmbActive.Items.Add("False");

            Facilitator faci = _dsFaci.getFacilitator(_FaciID);

            LoadPositionsToCombo();

            cmbPosition.SelectedIndex = cmbPosition.FindStringExact(_dsFaci.getDesignation(faci.DesignationID)); 
            txtFirstName.Text = faci.FirstName;
            txtLastName.Text = faci.LastName;
            cmbActive.SelectedItem = faci.IsActive.ToString();
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
                    if (cmbPosition.Text == "")
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
                            Facilitator facilitator = new Facilitator
                            {
                                FacilitatorID = _FaciID,
                                DesignationID = _dsFaci.getDesignationID(cmbPosition.Text),
                                FirstName = txtFirstName.Text,
                                LastName = txtLastName.Text,
                                IsActive = Boolean.Parse(cmbActive.Text)
                            };

                            _dsFaci.UpdateFacilitator(facilitator);

                            this.DialogResult = DialogResult.OK;


                            this.Close();
                        }
                    }
                }
            }
        }
        private void LoadPositionsToCombo()
        {
            var dt = _dsFaci.GetPositionsAvailable();

            cmbPosition.DataSource = null;
            cmbPosition.DisplayMember = "Position";
            cmbPosition.ValueMember = "DesignationID";
            cmbPosition.DataSource = dt;

            cmbPosition.SelectedIndex = 0;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            btnEditFaci_Click(sender, e);
        }


    }
}
