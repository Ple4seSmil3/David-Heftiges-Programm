using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heftiges_Programm
{
    public partial class Meth : Form
    {
        public Meth()
        {
            InitializeComponent();
        }

        double x,y,z;


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                x = Convert.ToDouble(textBox1.Text);
                y = Convert.ToDouble(textBox2.Text);
                z = Math.Max(x, y);
                if (x == z)
                {
                    this.textBox1.BackColor = System.Drawing.Color.Lime;
                    this.textBox2.BackColor = System.Drawing.Color.Red;
                }
                else if (y == z)
                {
                    this.textBox2.BackColor = System.Drawing.Color.Lime;
                    this.textBox1.BackColor = System.Drawing.Color.Red;
                }
            }
            catch
            {               
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                x = Convert.ToDouble(textBox1.Text);
                y = Convert.ToDouble(textBox2.Text);
                z = Math.Max(x, y);
                if (x == z)
                {
                    this.textBox1.BackColor = System.Drawing.Color.Lime;
                    this.textBox2.BackColor = System.Drawing.Color.Red;
                }
                else if (y == z)
                {
                    this.textBox2.BackColor = System.Drawing.Color.Lime;
                    this.textBox1.BackColor = System.Drawing.Color.Red;
                }
            }
            catch
            {
            }
        }
    }
}
