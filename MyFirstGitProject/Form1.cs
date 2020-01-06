using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstGitProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.panel1.BackColor == Color.Green)
            {
                this.panel1.BackColor = Color.MediumAquamarine;
            }
            else
            {
                this.panel1.BackColor = Color.Green;
            }


        }
    }
}
