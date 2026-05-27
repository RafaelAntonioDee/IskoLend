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
    public partial class EditSupply : Form
    {
        private int Quantity;
        private string Category;
        private string Item;

        private readonly SupplyDataService _dsSup;
        private readonly string _SupID;
        private readonly string _currFaci;

        public EditSupply(SupplyDataService dsSup, string SupplyID, string currFaci)
        {
            _currFaci = currFaci;
            InitializeComponent();
            _dsSup = dsSup;
            _SupID = SupplyID;
        }

        private void EditSupply_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;

            Supply sup = _dsSup.getSupplyByID(_SupID);

            LoadCategoriesToCombo();

            cmbCategory.SelectedIndex = cmbCategory.FindStringExact(_dsSup.getCategory(sup.CategoryID));
            txtItemName.Text = sup.SupplyName;
            txtQty.Text = sup.Quantity.ToString();
        }
        private void LoadCategoriesToCombo()
        {
            var dt = _dsSup.GetAllCategories();

            cmbCategory.DataSource = null;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryID";
            cmbCategory.DataSource = dt;

            cmbCategory.SelectedIndex = 0;
        }
        private void btnEditItem_Click(object sender, EventArgs e)
        {
            if (cmbCategory.Text == "")
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
                    Supply sup = new Supply
                    {
                        SupplyID = _SupID,
                        CategoryID = _dsSup.getCategoryID(cmbCategory.Text),
                        SupplyName = txtItemName.Text,
                        Quantity = int.Parse(txtQty.Text)
                    };

                    _dsSup.UpdateSupply(sup, _currFaci);

                    this.DialogResult = DialogResult.OK;


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
