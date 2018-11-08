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
    public partial class Verzweigungen : Form
    {
        public Verzweigungen()
        {
            InitializeComponent();
            label1.Text = "Willkommen zum schlechtesten Quiz," + Environment.NewLine + "welches jemals exestierte";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = "Next";
            int j = 0;
            

            
            switch (j)
            {
                case 1:
                        label1.Text = "Wie stark war die Hiroshima Bombe?";
                        listBox1.Items.Add("A Die Hiroshimabombe hatte 12 - 18 kT Sprengkraft");
                        listBox1.Items.Add("B Die Hiroshimabombe hatte 18 - 25 kT Sprengkraft");
                        listBox1.Items.Add("C Die Hiroshimabombe hatte 25 - 32 kT Sprengkraft");
                        listBox1.Items.Add("D Die Hiroshimabombe hatte 32 - 40 kT Sprengkraft");
                        j++;
                        break;

                case 2:
                        label1.Text = "In welchem Jahr haben die Sowjets die Welt 'beben' lassen?" + Environment.NewLine +"(Zar Bombe)";
                        listBox1.Items.Add("A Die Zar bombe wurde im Jahr 1972 abgeworfen");
                        listBox1.Items.Add("B Die Zar bombe wurde im Jahr 1961 abgeworfen");
                        listBox1.Items.Add("C Die Zar bombe wurde im Jahr 1953 abgeworfen");
                        listBox1.Items.Add("D Die Zar bombe wurde im Jahr 1985 abgeworfen");
                        break;
                    default:
                    break;
            
        }
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
