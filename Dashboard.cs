using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace school_system
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void admission_Click(object sender, EventArgs e)
        {
            student na = new student();
            na.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            examination na = new examination();
            na.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
