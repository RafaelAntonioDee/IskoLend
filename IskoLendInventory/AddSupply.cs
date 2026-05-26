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
    public partial class AddSupply : Form
    {
        private int Quantity;
        private string Category;
        private string Item;

        private readonly SupplyDataService _dsSup;
        private readonly string _currFaci;

        public AddSupply(SupplyDataService dsSup, string faciID)
        {
            InitializeComponent();
            _dsSup = dsSup;
            _currFaci = faciID;
        }

        private void AddSupply_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            LoadFacilitatorsToCombo();
        }
        private void LoadFacilitatorsToCombo()
        {
            var sup = _dsSup.GetAllCategories();

            var row = sup.NewRow();
            row["CategoryName"] = "Categories";
            sup.Rows.InsertAt(row, 0);

            cmbCategory.DataSource = null;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryName";
            cmbCategory.DataSource = sup;

            cmbCategory.SelectedIndex = 0;
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

                    Supply newSupply = new Supply
                    {
                        SupplyID = _dsSup.GenerateSupplyID(),
                        CategoryID = _dsSup.getCategoryID(cmbCategory.Text),
                        SupplyName = txtItemName.Text,
                        Quantity = int.Parse(txtQty.Text)
                    };
                    _dsSup.AddSupply(newSupply);


                    //Logs newLog = new Logs
                    //{
                    //    LogID = _dsSup.GenerateLogID(),
                    //    SupplyID = newSupply.SupplyID,
                    //    FacilitatorID = _currFaci,
                    //    Action = "Add",
                    //    QuantityStatus = "+ "+ newSupply.Quantity,
                    //    ActionDate = DateTime.Parse( DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
                    //};
                  
                    //_dsSup.AddSupLog(newLog);


                    this.DialogResult = DialogResult.OK;
                    this.Close();


                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            btnAddItem_Click(sender, e);
        }

        private void btnAddItem_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
