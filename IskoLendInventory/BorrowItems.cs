using IskoLendDataManagement;
using IskoLendModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IskoLendInventory
{
    public partial class BorrowItems : Form
    {
        private readonly BorrowingRecordDataService _dsBR;
        private DataTable dt;
        public BorrowItems(BorrowingRecordDataService dsBR)
        {
            _dsBR = dsBR;
            InitializeComponent();
            
        }

        private void BorrowItems_Load(object sender, EventArgs e)
        {
           
            MaximizeBox = false;
            tblItems.ClearSelection();
            dt = new DataTable();
            dt.Columns.Add("SupplyID", typeof(string));
            dt.Columns.Add("Item", typeof(string));
            dt.Columns.Add("Qty", typeof(int));

            tblItems.DataSource = dt;
        }
        

        private void btnAddItem_Click(object sender, EventArgs e)
        {

            
            AddItem form = new AddItem(_dsBR, dt);
            form.ShowDialog();

            tblItems.ClearSelection();
            tblItems.CurrentCell = null;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            btnAddItem_Click(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<BorrowingDetails> details = new List<BorrowingDetails>();
            BorrowingRecord record;
            string StudentID = txtStudentID.Text;
            if (!(string.IsNullOrEmpty(StudentID))&& _dsBR.isStudent(StudentID))
            {
                    if (tblItems.Rows.Count > 0)
                    {
                        //record = new BorrowingRecord
                        //{
                        //    StudentID = StudentID,
                        //    FacilitatorID = "F001",//FOR EDIT LATER
                        //    StatusID = "S001",
                        //    DateCompleted = null,
                        //    BorrowID = _dsBR.GenerateBorrowID()

                        //};
                        DateTime BorrowDate = DateTime.Now;

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Please add atleast 1 item.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
