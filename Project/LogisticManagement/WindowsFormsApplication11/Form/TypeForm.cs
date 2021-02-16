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
    public partial class TypeForm : Form
    {
        public TypeForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TypeForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Type.GetType(null);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Type> type = Type.GetType(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));

            txtNameType.Text = type[0].NameType.ToString();
            txtCodeType.Text = type[0].CodeType.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Type _t = new Type();

            _t.IdType = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            _t.NameType = txtNameType.Text;
            _t.CodeType = txtCodeType.Text;


            if (Type.UpdateType(_t))
            {
                MessageBox.Show("Type Updated", "Info");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Type.GetType(null);

                _t.IdType = 0;
                txtNameType.Text = "";
                txtCodeType.Text = "";
            }
            else
            {
                MessageBox.Show("Type Not Updated", "Info");
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Type _t = new Type();

            _t.NameType = txtNameType.Text;
            _t.CodeType = txtCodeType.Text;



            if (Type.InsertType(_t))
            {
                MessageBox.Show("Type Inserted", "Info");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Type.GetType(null);
            }
            else
            {
                MessageBox.Show("Type Not Inserted", "Info");
            }

            txtNameType.Text = "";
            txtCodeType.Text = "";

        }

    }
}

