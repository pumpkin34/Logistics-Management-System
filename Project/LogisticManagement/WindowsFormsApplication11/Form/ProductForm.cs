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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Product.GetProduct(null);
            dataGridView1.Columns.RemoveAt(2);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Product> product = Product.GetProduct(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));

            txtNumberofPeaces.Text = product[0].NumberOfPeaces.ToString();
            txtSizeofPeaces.Text = product[0].SizeOfPeaces.ToString();
            txtIdCustomer.Text = product[0].IdCustomer.ToString();
            txtTotalWeight.Text = product[0].TotalWeight.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Product _p = new Product();

            _p.IdPackets = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            _p.NumberOfPeaces = txtNumberofPeaces.Text;
            _p.IdCustomer = Convert.ToInt16(txtIdCustomer.Text);
            _p.SizeOfPeaces = txtSizeofPeaces.Text + " " + txtM3.Text;
            _p.TotalWeight = txtTotalWeight.Text + " " + txtKg.Text;

            if (Product.UpdateProduct(_p))
            {
                MessageBox.Show("Product Updated", "Info");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Product.GetProduct(null);
                dataGridView1.Columns.RemoveAt(2);

                _p.IdPackets = 0;
                txtTotalWeight.Text = "";
                txtSizeofPeaces.Text = "";
                txtNumberofPeaces.Text = "";
                txtIdCustomer.Text = "";
            }
            else
            {
                MessageBox.Show("Product Not Updated", "Info");
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Product _p = new Product();

            _p.NumberOfPeaces = txtNumberofPeaces.Text;
            _p.IdCustomer = Convert.ToInt16(txtIdCustomer.Text);
            _p.SizeOfPeaces = txtSizeofPeaces.Text + " " + txtM3.Text;
            _p.TotalWeight = txtTotalWeight.Text + " " + txtKg.Text;



            if (Product.InsertProduct(_p))
            {
                MessageBox.Show("Product Inserted", "Info");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Product.GetProduct(null);
            }
            else
            {
                MessageBox.Show("Product Not Inserted", "Info");
            }
            txtSizeofPeaces.Text = "";
            txtIdCustomer.Text = "";
            txtSizeofPeaces.Text = "";
            txtTotalWeight.Text = "";
        }

        private void reportToExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcelExporter excelExporter = new ExcelExporter();
            excelExporter.ExportFile(dataGridView1);
        }
    }
}
