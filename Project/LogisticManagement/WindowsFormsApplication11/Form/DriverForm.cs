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
    public partial class DriverForm : Form
    {
        public DriverForm()
        {
            InitializeComponent();
        }

        private void SampleForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Driver.GetDriver(null);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Driver _d = new Driver();

            _d.DriverName = txtName.Text;
            _d.DriverSurname = txtSurname.Text;
            _d.DriverPhone = txtPhone.Text;
            _d.DriverStatus = rbActive.Checked ? true : false;


            if (Driver.InsertDriver(_d))
            {
                MessageBox.Show("Driver Inserted", "Info");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Driver.GetDriver(null);
            }
            else
            {
                MessageBox.Show("Driver Inserted", "Info");
            }

            txtName.Text = "";
            txtSurname.Text = "";
            txtPhone.Text = "";
            rbActive.Checked = false;
            rbDeactive.Checked = false;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Driver> driver = Driver.GetDriver(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
            

            txtName.Text = driver[0].DriverName.ToString();
            txtSurname.Text = driver[0].DriverSurname.ToString();
            txtPhone.Text = driver[0].DriverPhone.ToString();

            bool AorD = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[4].Value);
            if (AorD == true)
            {
                rbDeactive.Checked = false;
                rbActive.Checked = true;
            }
            else {
                rbDeactive.Checked = true;
                rbActive.Checked = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Driver _d = new Driver();

            _d.IdDriver = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            _d.DriverName = txtName.Text;
            _d.DriverSurname = txtSurname.Text;
            _d.DriverPhone = txtPhone.Text;
            _d.DriverStatus = rbActive.Checked ? true : false;

            if (Driver.UpdateDriver(_d))
            {
                MessageBox.Show("Driver Updated", "Info");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Driver.GetDriver(null);

                _d.IdDriver = 0;
                txtName.Text = "";
                txtSurname.Text = "";
                txtPhone.Text = "";
                rbActive.Checked = false;
                rbDeactive.Checked = false;
            }
            else
            {
                MessageBox.Show("Driver Not Updated", "Info");
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcelExporter excelExporter = new ExcelExporter();
            excelExporter.ExportFile(dataGridView1);
        }
    }
}
