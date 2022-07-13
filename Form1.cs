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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = textBox1.Text;
            String Email = textBox2.Text;
            String Password = textBox3.Text;

            if (username == "" && Email == "" && Password == "")
            {
                using (Dashboard das = new Dashboard())
                {
                    das.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Invalid user id or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

