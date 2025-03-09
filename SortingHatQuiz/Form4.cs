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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public Image[] despre = new Image[5];
        private void Form4_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Background;
            despre[1] = Properties.Resources.AbtGryf;
            despre[2] = Properties.Resources.AbtSlyth;
            despre[3] = Properties.Resources.AbtHuff;
            despre[4] = Properties.Resources.AbtRaven;
                pictureBox1.Image = despre[Form2.rez];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 g = new Form2();
            g.Show();
            Hide();
        }
    }
}
