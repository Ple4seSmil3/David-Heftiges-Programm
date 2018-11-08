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
    public partial class Schleifen : Form
    {
        public Schleifen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mesixnumber = Convert.ToInt32(textBox1.Text);
            for (int i = 0; i < mesixnumber; i++)
            {
                listBox1.Items.Add("Hey I'm Mister Meeseeks look at me!!!!");
                //mesixnumber = (int)progressBar1.Value;
                //System.Threading.Thread.Sleep(500);


            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
