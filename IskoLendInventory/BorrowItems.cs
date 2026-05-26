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
        private readonly string _currFaci;
        private DataTable dt;
        public BorrowItems(BorrowingRecordDataService dsBR, string currFaci)
        
        {
            _currFaci = currFaci;
            _dsBR = dsBR;
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            timer1.Start();


            txtDateTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
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
        private void timer1_Tick(object? sender, EventArgs e)
        {
            txtDateTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
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
                    if(!string.IsNullOrEmpty(_currFaci))
                    {
                        DataTable supplies = (DataTable)tblItems.DataSource;
                        record = new BorrowingRecord
                        {
                            StudentID = StudentID,
                            FacilitatorID = _currFaci,
                            StatusID = "S001",
                            DateCompleted = null,
                            BorrowID = _dsBR.GenerateBorrowID(),
                            BorrowedDate = DateTime.Now
                        };
                        _dsBR.AddBorrowingRecord(record);
                        _dsBR.SaveBorrowItems(supplies, record.BorrowID);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Please Select Your Facilitator ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    
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
