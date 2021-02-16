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
    public partial class MainBackoffice : Form
    {
        public MainBackoffice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TruckForm truckForm = new TruckForm();
            truckForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TypeForm typeForm = new TypeForm();
            typeForm.ShowDialog();
        }
    }
}
