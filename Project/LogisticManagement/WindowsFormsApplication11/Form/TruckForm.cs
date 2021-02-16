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
    public partial class TruckForm : Form
    {
        public TruckForm()
        {
            InitializeComponent();
        }

        private void TruckForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Truck.GetTruck(null);
        }

        private void truck_plate_TextChanged(object sender, EventArgs e)
        {

        }

        private void inserttruck_Click(object sender, EventArgs e)
        {
            Truck _t = new Truck();

            _t.PlateTruck = truck_plate.Text;
            _t.PlateTruckBad = truckbad_plate .Text;
           


            if (Truck.InsertTruck(_t))
            {
                MessageBox.Show("Truck Inserted", "Info");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Truck.GetTruck(null);
            }
            else
            {
                MessageBox.Show("Truck Not Inserted", "Info");
            }

            truck_plate.Text = "";
            truckbad_plate.Text = "";
       
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void truckbad_plate_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void update_truck_Click(object sender, EventArgs e)
        {
            Truck _t = new Truck();

            _t.IdTruck = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            _t.PlateTruck = truck_plate.Text;
            _t.PlateTruckBad = truckbad_plate.Text;


            if (Truck.UpdateTruck(_t))
            {
                MessageBox.Show("Truck Updated", "Info");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Truck.GetTruck(null);

                _t.IdTruck = 0;
                truck_plate.Text = "";
                truckbad_plate.Text = "";
            }
            else
            {
                MessageBox.Show("Truck Not Updated", "Info");
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Truck> truck = Truck.GetTruck(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));

            truck_plate.Text = truck[0].PlateTruck.ToString();
            truckbad_plate.Text = truck[0].PlateTruckBad.ToString();
        }
    }
}
