using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingHatQuiz
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Image[] casele = new Image[5];
        public static int rez = 0;
        private void Form2_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Background;
            casele[1] = Properties.Resources.Gryffindor;
            casele[2] = Properties.Resources.Slytherin;
            casele[3] = Properties.Resources.Hufflepuff;
            casele[4] = Properties.Resources.Ravenclaw;
            if (Form1.gryffindor > Form1.slytherin && Form1.gryffindor > Form1.hufflepuff && Form1.gryffindor > Form1.ravenclaw)
            {
                label1.Text = "GRIFFYINDOR!!!!";
                pictureBox1.Image = casele[1];
                rez = 1;
            }
                
            if (Form1.slytherin > Form1.gryffindor && Form1.slytherin > Form1.hufflepuff && Form1.slytherin > Form1.ravenclaw)
            {
                label1.Text = "SLYTHERIN!!!!";
                pictureBox1.Image = casele[2];
                rez = 2;
                
            }
                
            if (Form1.hufflepuff > Form1.gryffindor && Form1.hufflepuff> Form1.slytherin && Form1.hufflepuff > Form1.ravenclaw)
            {
                label1.Text = "HUFFLEPUFF!!!!";
                pictureBox1.Image = casele[3];
                rez = 3;
                
            }
               
            if (Form1.ravenclaw > Form1.gryffindor && Form1.ravenclaw > Form1.slytherin && Form1.ravenclaw > Form1.hufflepuff)
            {
                label1.Text = "RAVENCLAW!!!!";
                pictureBox1.Image = casele[4];
                rez = 4;
                
            }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 g = new Form3();
            g.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 g = new Form4();
            g.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
