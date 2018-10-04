using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoRafa
{

    
    public partial class Form1 : Form
    {
        bool comendo = true;
        bool esperando = true;
        bool dormindo = true;
        public Form1()
        {
           
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
            pictureBox1.Image = Properties.Resources.comendo;
            button1.Text = "comendo";
            pictureBox1.Image = Properties.Resources.esperando;
            button1.Text = "esperando";
            pictureBox1.Image = Properties.Resources.dormindo;
            button1.Text = "dormindo";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.comendo;
            button2.Text = "comendo";
            pictureBox2.Image = Properties.Resources.esperando;
            button2.Text = "esperando";
            pictureBox2.Image = Properties.Resources.dormindo;
            button2.Text = "dormindo";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.comendo;
            button3.Text = "comendo";
            pictureBox3.Image = Properties.Resources.esperando;
            button3.Text = "esperando";
            pictureBox3.Image = Properties.Resources.dormindo;
            button3.Text = "dormindo";
        }
    }
}
