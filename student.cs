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
    public partial class student : Form
    {
        public student()
        {
            InitializeComponent();
        }

        private void student_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database2DataSet.Table2' table. You can move, or remove it, as needed.
            this.table2TableAdapter.Fill(this.database2DataSet.Table2);

        }
        private void button5_Click(object sender, EventArgs e)
        {
            table2BindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            table2BindingSource.AddNew();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            table2BindingSource.MoveNext();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            table2BindingSource.RemoveCurrent();
        }
        private void Save_Click(object sender, EventArgs e)
        {
            table2BindingSource.EndEdit();
            table2TableAdapter.Update(database2DataSet.Table2);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
