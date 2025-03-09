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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Background;
            label1.Text = "Gryffindor:";
            label2.Text = "Slytherin:";
            label3.Text = "Hufflepuff:";
            label4.Text = "Ravenclaw:";

            label5.Text = Form1.gryffindor.ToString();
            label6.Text = Form1.slytherin.ToString();
            label7.Text = Form1.hufflepuff.ToString();
            label8.Text = Form1.ravenclaw.ToString();

        }

        private void buttonSClose_Click(object sender, EventArgs e)
        {
            Form2 g = new Form2();
            g.Show();
            Hide();
        }
    }
}
