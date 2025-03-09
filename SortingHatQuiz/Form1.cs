using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace SortingHatQuiz
{
    public partial class Form1 : Form
    {
        public Image[] imagini = new Image[14];
        public Label[] progres = new Label[14];
        public List<string> intrebari = new List<string>();
        public int i = -1, k = 0;
        public int nr;
        public static int total = 0;

        public static int gryffindor = 0;
        public static int slytherin = 0;
        public static int hufflepuff = 0;
        public static int ravenclaw = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            this.BackgroundImage = Properties.Resources.Background;
            StreamReader f = new StreamReader("SortingHat.txt");
            string s = f.ReadLine();
            while (s!=null)
            {
                intrebari.Add(s);
                s = f.ReadLine();
            }
            //imagini in vector
            imagini[1] = Properties.Resources._1Pic;
            imagini[2] = Properties.Resources._2Pic;
            imagini[3] = Properties.Resources._3Pic;
            imagini[4] = Properties.Resources._4Pic;
            imagini[5] = Properties.Resources._5Pic;
            imagini[6] = Properties.Resources._6Pic;
            imagini[7] = Properties.Resources._7Pic;
            imagini[8] = Properties.Resources._8Pic;
            imagini[9] = Properties.Resources._9Pic;
            imagini[10] = Properties.Resources._10Pic;
            imagini[11] = Properties.Resources._11Pic;
            imagini[12] = Properties.Resources._12Pic;
            imagini[13] = Properties.Resources._13Pic;
            pictureBox1.Image = Properties.Resources.Sorted;

            //progres cu vectori de labeluri
            for (int i = 0; i < 13; i++)
            {
                progres[i] = new Label();
                progres[i].Width = 50;
                progres[i].Height = 50;
                progres[i].BackColor = Color.MidnightBlue;
                progres[i].Top = 40 + (12 - i) * 37;
                progres[i].Left = 1080;
                progres[i].Font = new Font("Book Antiqua", 16, FontStyle.Bold);
                progres[i].ForeColor = Color.White;
                progres[i].BorderStyle = BorderStyle.Fixed3D;
                progres[i].TextAlign = ContentAlignment.MiddleCenter;
                Controls.Add(progres[i]);
            }

            progres[0].Text = "1";
            progres[1].Text = "2";
            progres[2].Text = "3";
            progres[3].Text = "4";
            progres[4].Text = "5";
            progres[5].Text = "6";
            progres[6].Text = "7";
            progres[7].Text = "8";
            progres[8].Text = "9";
            progres[9].Text = "10";
            progres[10].Text = "11";
            progres[11].Text = "12";
            progres[12].Text = "13";



        }
        private void Incarcare()
        {
            richTextBox1.Text = intrebari[++i];
            radioButton1.Text = intrebari[++i];
            radioButton2.Text = intrebari[++i];
            radioButton3.Text = intrebari[++i];
            radioButton4.Text = intrebari[++i];
            pictureBox1.Image = imagini[++k];
        }
        public void IncarcareRaspunsuri()
        {
            if (radioButton1.Checked == true)
                gryffindor += 1;
            if (radioButton2.Checked == true)
                slytherin += 1;
            if (radioButton3.Checked == true)
                hufflepuff += 1;
            if (radioButton4.Checked == true)
                ravenclaw += 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            groupBox1.Visible = true;


            if (k > 12)
            {
                Form2 g = new Form2();
                g.Show();
                Hide();
            }
            else
            {
                IncarcareRaspunsuri();
                Incarcare();
                buttonStart.Text = "Next";
                if (k>1)
                progres[k - 2].BackColor = Color.SlateGray;
               
            }
            
            
        }
        

    }
}
