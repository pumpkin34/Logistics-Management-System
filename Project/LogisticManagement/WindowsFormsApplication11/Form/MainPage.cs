using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DriverForm driverForm = new DriverForm();
            driverForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.ShowDialog();
        }

        private void BackOffice_Click(object sender, EventArgs e)
        {
            MainBackoffice mainBackoffice = new MainBackoffice();
            mainBackoffice.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OperationForm operationForm = new OperationForm();
            operationForm.ShowDialog(); 
        }
    }
}
