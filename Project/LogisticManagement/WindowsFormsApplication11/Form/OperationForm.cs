using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication11.Utility;

namespace WindowsFormsApplication11
{
    public partial class OperationForm : Form
    {
        public OperationForm()
        {
            InitializeComponent();
        }

        private void Operation_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Operation.GetOperation(null);
        }

        private bool checkFields()
        {
            if (txttype_id.Text == "")
            {
                MessageBox.Show("Please fill in a type id", "Info");
                txttype_id.Focus();
                return false;
            }
            else if (txtpackets_id.Text == "")
            {
                MessageBox.Show("Please fill in a packets id", "Info");
                txtpackets_id.Focus();
                return false;
            }
             else if (txtdriver_id.Text == "")
            {
                MessageBox.Show("Please fill in a driver id", "Info");
                txtdriver_id.Focus();
                return false;
            }
            else if (txtdestination.Text == "")
            {
                MessageBox.Show("Please fill in a destination", "Info");
                txtdestination.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void OperationForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Operation.GetOperation(null);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult yesNo = MessageBox.Show("Are you sure you want to delete?", "Warning", MessageBoxButtons.YesNo);

            if (yesNo == DialogResult.Yes)
            {
                int id = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                if (Operation.DeleteMainTableByID(id))
                {
                    MessageBox.Show("Operation Deleted", "Info");

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = Operation.GetOperation(null);
                }
                else
                {
                    MessageBox.Show("Operation Not Deleted", "Info");
                }
            }
            else { }
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkFields() == true)
                {
                    Operation _o = new Operation();
                    _o.DateStart = Convert.ToDateTime(dtp_start.Value.ToShortDateString());
                    _o.DateEnd = Convert.ToDateTime(dtp_end.Value.ToShortDateString());
                    _o.IDType = Convert.ToInt16(txttype_id.Text);
                    _o.IDPackets = Convert.ToInt16(txtpackets_id.Text);

                    if (txtdriver_id.Text == "")
                    {
                        _o.IDDriver = Convert.ToInt16(null);
                    }
                    else {
                        _o.IDDriver = Convert.ToInt16(txtdriver_id.Text);
                    }

                    _o.Destination = txtdestination.Text;


                    if (Operation.InsertOperation(_o))
                    {
                        MessageBox.Show("Operation Inserted", "Info");

                        txtdestination.Text = "";
                        txtdriver_id.Text = "";
                        txtpackets_id.Text = "";
                        txttype_id.Text = "";


                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = Operation.GetOperation(null);
                    }
                    else
                    {
                        MessageBox.Show("Operation Not Inserted", "Info");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Operation> operation = Operation.GetOperation(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));


            dtp_start.Text = operation[0].DateStart.ToString();
            dtp_end.Text = operation[0].DateEnd.ToString();
            txttype_id.Text = operation[0].IDType.ToString();
            txtpackets_id.Text = operation[0].IDPackets.ToString();
            txtdriver_id.Text = operation[0].IDDriver.ToString();
            txtdestination.Text = operation[0].Destination.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Operation _o = new Operation();

            _o.IdOperation = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            _o.DateStart = Convert.ToDateTime(dtp_start.Value.ToShortDateString());
            _o.DateEnd = Convert.ToDateTime(dtp_end.Value.ToShortDateString());
            _o.IDType = Convert.ToInt16(txttype_id.Text);
            _o.IDPackets = Convert.ToInt16( txtpackets_id.Text);
            _o.IDDriver = Convert.ToInt16( txtdriver_id.Text);
            _o.Destination = txtdestination.Text;

            if (Operation.UpdateOperation(_o))
            {
                MessageBox.Show("Operation Updated", "Info");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Operation.GetOperation(null);

                _o.IdOperation = 0;
                dtp_start.Text = DateTime.Now.ToShortDateString();
                dtp_end.Text = DateTime.Now.ToShortDateString();
                txtpackets_id.Text = "";
                txtdriver_id.Text = "";
                txtdestination.Text = "";
            }
            else
            {
                MessageBox.Show("Operation Not Updated", "Info");
            }
        }

        private void reportToExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcelExporter excelExporter = new ExcelExporter();
            excelExporter.ExportFile(dataGridView1);
        }
    }
}