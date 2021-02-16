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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Customer.GetCustomer(null);
        }

        private void btnCustomerInsert_Click(object sender, EventArgs e)
        {
            Customer _c = new Customer();

            _c.CustomerName = txtCustomerName.Text;
            _c.CustomerSurname = txtCustomerSurname.Text;
            _c.CustomerPhone = txtCustomerPhone.Text;

            if (Customer.InsertCustomer(_c))
            {
                MessageBox.Show("Customer Inserted", "Info");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Customer.GetCustomer(null);
            }
            else
            {
                MessageBox.Show("Customer Not Inserted", "Info");
            }

            txtCustomerName.Text = "";
            txtCustomerSurname.Text = "";
            txtCustomerPhone.Text = "";

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Customer> customer = Customer.GetCustomer(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));

            txtCustomerName.Text = customer[0].CustomerName.ToString();
            txtCustomerSurname.Text = customer[0].CustomerSurname.ToString();
            txtCustomerPhone.Text = customer[0].CustomerPhone.ToString();
        }

        private void btnCustomerUpdate_Click(object sender, EventArgs e)
        {
            Customer _c = new Customer();

            _c.IdCustomer = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            _c.CustomerName = txtCustomerName.Text;
            _c.CustomerSurname = txtCustomerSurname.Text;
            _c.CustomerPhone = txtCustomerPhone.Text;


            if (Customer.UpdateCustomer(_c))
            {
                MessageBox.Show("Customer Updated", "Info");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Customer.GetCustomer(null);

                _c.IdCustomer = 0;
                _c.CustomerName = "";
                _c.CustomerSurname = "";
                _c.CustomerPhone = "";


            }
            else
            {
                MessageBox.Show("Customer Not Updated", "Info");
            }
        }

        private void reportToExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcelExporter excelExporter = new ExcelExporter();
            excelExporter.ExportFile(dataGridView1);
        }
    }
}
