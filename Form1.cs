using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSP_by_Koko_Studios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.Width = (int)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            this.Height = (int)numericUpDown2.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WSP by Koko Studios\nv1.0.1", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
