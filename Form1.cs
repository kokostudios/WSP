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
        
        // these fellas below change the size :)
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.Width = (int)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            this.Height = (int)numericUpDown2.Value;
        }

        // and these are just the other stuff like the about and reset button
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WSP by Koko Studios\nv1.0.2", "About", MessageBoxButtons.OK, MessageBoxIcon.Information); // about wsp, nothing important other than version info
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Width = 243; // resets the size to 243x164 which is the default size for WSP
            this.Height = 164;

            // these 2 lines change the value of the thingy so they show the original height instead of the modified height
            numericUpDown1.Value = this.Width;
            numericUpDown2.Value = this.Height;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}