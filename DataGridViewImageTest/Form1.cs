using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewImageTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvImages.Columns.Add(new DataGridViewImageColumn());
            dgvImages.Rows.Add(3);
            DataGridViewImageCell cell = (DataGridViewImageCell)dgvImages.Rows[0].Cells[0];
            cell.Value = Properties.Resources.Low_16x;
            cell = (DataGridViewImageCell)dgvImages.Rows[1].Cells[0];
            cell.Value = Properties.Resources.Normal_16x;
            cell = (DataGridViewImageCell)dgvImages.Rows[2].Cells[0];
            cell.Value = Properties.Resources.High_16x;
        }
    }
}
