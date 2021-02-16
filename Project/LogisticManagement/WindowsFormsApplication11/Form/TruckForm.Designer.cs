namespace WindowsFormsApplication11
{
    partial class TruckForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.updatetruck = new System.Windows.Forms.Button();
            this.inserttruck = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.truckbad_plate = new System.Windows.Forms.TextBox();
            this.truck_plate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(399, 462);
            this.dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 26);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.updatetruck);
            this.groupBox1.Controls.Add(this.inserttruck);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.truckbad_plate);
            this.groupBox1.Controls.Add(this.truck_plate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(405, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 462);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Truck Details";
            // 
            // updatetruck
            // 
            this.updatetruck.Location = new System.Drawing.Point(70, 179);
            this.updatetruck.Name = "updatetruck";
            this.updatetruck.Size = new System.Drawing.Size(75, 23);
            this.updatetruck.TabIndex = 5;
            this.updatetruck.Text = "Update ";
            this.updatetruck.UseVisualStyleBackColor = true;
            this.updatetruck.Click += new System.EventHandler(this.update_truck_Click);
            // 
            // inserttruck
            // 
            this.inserttruck.Location = new System.Drawing.Point(151, 179);
            this.inserttruck.Name = "inserttruck";
            this.inserttruck.Size = new System.Drawing.Size(75, 23);
            this.inserttruck.TabIndex = 4;
            this.inserttruck.Text = "Insert";
            this.inserttruck.UseVisualStyleBackColor = true;
            this.inserttruck.Click += new System.EventHandler(this.inserttruck_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Truckbad Plate";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // truckbad_plate
            // 
            this.truckbad_plate.Location = new System.Drawing.Point(70, 134);
            this.truckbad_plate.Name = "truckbad_plate";
            this.truckbad_plate.Size = new System.Drawing.Size(156, 20);
            this.truckbad_plate.TabIndex = 2;
            this.truckbad_plate.TextChanged += new System.EventHandler(this.truckbad_plate_TextChanged);
            // 
            // truck_plate
            // 
            this.truck_plate.Location = new System.Drawing.Point(70, 83);
            this.truck_plate.Name = "truck_plate";
            this.truck_plate.Size = new System.Drawing.Size(156, 20);
            this.truck_plate.TabIndex = 1;
            this.truck_plate.TextChanged += new System.EventHandler(this.truck_plate_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Truck Plate";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TruckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(721, 462);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "TruckForm";
            this.Text = "TruckForm";
            this.Load += new System.EventHandler(this.TruckForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.Button updatetruck;
        private System.Windows.Forms.Button inserttruck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox truckbad_plate;
        private System.Windows.Forms.TextBox truck_plate;
        private System.Windows.Forms.Label label1;
    }
}