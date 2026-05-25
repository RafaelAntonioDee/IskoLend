using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IskoLendDataManagement;

namespace IskoLendInventory
{
    public partial class AddItem : Form
    {
        private int Quantity;
        private String Item;
        private readonly BorrowingRecordDataService _dsBR;
        private readonly DataTable _borrowItems;

        public AddItem(BorrowingRecordDataService dsBR, DataTable dt)
        {
            
            InitializeComponent();
            _dsBR = dsBR;
            InitItemComboPlaceholder();
            cmbItem.DropDown += cmbItem_DropDown;
            _borrowItems = dt;
        }
        private void cmbItem_DropDown(object sender, EventArgs e)
        {
            LoadItemsToCombo();
        }
        private void LoadItemsToCombo()
        {   //
            //if(cmbCategory.SelectedIndex == 0)
            var dt = _dsBR.GetItems();

            //else {
            //      var dt = _dsBR.getItems(cmbCategory.SelectedIndex)
            //}

            var row = dt.NewRow();
            row["ItemName"] = "Select Item";
            dt.Rows.InsertAt(row, 0);

            cmbItem.DataSource = null;          
            cmbItem.DisplayMember = "ItemName";
            cmbItem.ValueMember = "ItemName";   
            cmbItem.DataSource = dt;

            cmbItem.SelectedIndex = 0;
        }
        //private void cmbCategory_DropDown(object sender, EventArgs e)
        //{
        //    LoadCategoriesToCombo();
        //}
        //private void LoadCategoriesToCombo()
        //{  
        //    var dt = _dsBR.getCategories();

        //    

        //    var row = dt.NewRow();
        //    row["CategoryName"] = "Select Category";
        //    dt.Rows.InsertAt(row, 0);

        //    cmbCategory.DataSource = null;
        //    cmbCategory.DisplayMember = "CategoryName";
        //    cmbCategory.ValueMember = "CategoryName";
        //    cmbCategory.DataSource = dt;

        //    cmbCategory.SelectedIndex = 0;
        //}
        private void InitItemComboPlaceholder()
        {
            //Gawa ka rin neto sa Category Dee
            var dt = new DataTable();
            dt.Columns.Add("ItemName", typeof(string));
            dt.Rows.Add("Select Item");

            cmbItem.DisplayMember = "ItemName";
            cmbItem.ValueMember = "ItemName";
            cmbItem.DataSource = dt;

            cmbItem.SelectedIndex = 0;
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
                    int Qty = Convert.ToInt32(txtQty.Text);
                    string Item = cmbItem.Text;

                    var addedRow = _dsBR.AddItem(_borrowItems, Item, Qty);
                    if (addedRow == null)
                    {
                        MessageBox.Show("Not enough stock for that quantity.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // don't close
                    }
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
