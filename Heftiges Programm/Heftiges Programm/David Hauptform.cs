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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void variablenAMKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Variablen VariKappa = new Variablen();
            VariKappa.MdiParent = this;
            VariKappa.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void schleifenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Schleifen schleifi = new Schleifen();
            schleifi.MdiParent = this;
            schleifi.Show();
        }

        private void verzweigungenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Verzweigungen zweig = new Verzweigungen();
            zweig.MdiParent = this;
            zweig.Show();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Test testblatt = new Test();
            testblatt.MdiParent = this;
            testblatt.Show();
        }

        private void methToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Meth funktionen = new Meth();
            funktionen.MdiParent = this;
            funktionen.Show();
        }
    }
}
