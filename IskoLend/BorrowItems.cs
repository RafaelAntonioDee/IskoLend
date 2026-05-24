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
    public partial class BorrowItems : Form
    {
        public BorrowItems()
        {
            InitializeComponent();
        }

        private void BorrowItems_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            tblItems.ClearSelection();

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            AddItem form = new AddItem();
            form.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            btnAddItem_Click(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtStudentID.Text != "")
            {
                if (cmbDate.Text.Length > 0)
                {
                    if (tblItems.Rows.Count > 0)
                    {
                        //add ka dito save function
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Please add atleast 1 item.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter Date.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please enter StudentID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
            btnSave_Click(sender, e);
        }
    }
}
