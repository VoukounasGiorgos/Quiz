using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Quiz
{
    public partial class Form1 : Form
    {
        int p1, p2, a1, a2, pol1, pol2, sap1, sap2, sap3, ap1, ap2, ap3, d1, d2, sap4, ap4;
        
        int timeleft = 60000;
        int timeneeded = 0; // metraei kai meta ti liksh 

        

        static public class praxeis
        {
          
           static public int result(int num1, int num2, string praxi)
            {
                int result = 0;
                if (praxi == "+")
                    result = num1 + num2;
                if (praxi == "-")
                    result = num1 - num2;
                if (praxi == "/")
                    result = num1 / num2;
                if (praxi == "*")
                    result = num1 * num2;
                return result;
            }
        }

        public class checkanswers     
        {
            int swstes = 0;
            public int numberofcorrect(int ap1, int sap1, int ap2, int sap2, int ap3, int sap3, int ap4, int sap4,  NumericUpDown nud0, NumericUpDown nud1, NumericUpDown nud2, NumericUpDown nud3)
            {
                if (ap1 == sap1)
                {
                    swstes++;

                }
                else
                {
                    nud0.Value = sap1;
                    nud0.BackColor = Color.Red;
                }
                if (ap2 == sap2)
                {
                    swstes++;
                }
                else
                {
                    nud1.Value = sap2;
                    nud1.BackColor = Color.Red;
                }
                if (ap3 == sap3)
                {
                    swstes++;
                }
                else
                {
                    nud2.Value = sap3;
                    nud2.BackColor = Color.Red;
                }
                if (ap4 == sap4)
                {
                    swstes++;
                }
                else
                {
                    nud3.Value = sap4;
                    nud3.BackColor = Color.Red;
                }
                return swstes;

            }



        }






       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            button2.Enabled = false;
            int[] numbers = new int[1000];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i;
            }
            Random rnd = new Random();
            p1 = rnd.Next(numbers[0], numbers[999]); ; // pros8esh prwtos 
            p2 = rnd.Next(numbers[0], numbers[999]); //pros8esh deuteros
            a1 = rnd.Next(numbers[0], numbers[999]); //afaiiretis
            a2 = rnd.Next(numbers[0], numbers[999]); //afaireteos
            pol1 = rnd.Next(numbers[0], numbers[999]); // pol/mo prwtos 
            pol2 = rnd.Next(numbers[0], numbers[999]); //pol/mo deuteros 
            d1 = rnd.Next(numbers[0], numbers[999]); //diaireths
            d2 = rnd.Next(numbers[0], numbers[999]); //diaireteos
            sap1 = praxeis.result(p1, p2, "+");                       //swsth
            sap2 = praxeis.result(a1, a2, "-");       //swsth
            sap3 = praxeis.result(pol1, pol2, "*");         //swsth
            sap4 = praxeis.result(d1, d2, "/");    //swsth
           

            label5.Text = Convert.ToString(p1);
            label7.Text = Convert.ToString(p2);
            label8.Text = Convert.ToString(a1);
            label10.Text = Convert.ToString(a2);
            label11.Text = Convert.ToString(pol1);
            label13.Text = Convert.ToString(pol2);
            label14.Text = Convert.ToString(d1);
            label16.Text = Convert.ToString(d2);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {

            button2.Enabled =true;
            button1.Enabled = false;
            pictureBox1.Visible = false;
            button1.BackColor = Color.Silver;
            if (!timer1.Enabled)
                timer1.Enabled = true;
            else
                timer1.Enabled = false;
            if (!timer2.Enabled)
                timer2.Enabled = true;
            else
                timer2.Enabled = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }
        public static void myarray()
        {
           
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            
        }

        int second_for_timer1 = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            if (timeleft > 0)
            {
                timeleft = timeleft - 1000;
                label18.Text = Convert.ToString(timeleft / 1000);
                timeneeded = 60 - timeleft/1000;

                if (timeleft > 30000)
                {
                    panel1.BackColor = Color.Green;
                }
                else if (timeleft > 10000)
                {
                    panel1.BackColor = Color.Orange;
                }
                else
                {
                    panel1.BackColor = Color.Red;
                }
            }
            if (second_for_timer1 == 60)
                timer1.Enabled = false;
            second_for_timer1 = second_for_timer1 + 1;
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            pictureBox2.Visible = false;
            ap1 = Convert.ToInt32(numericUpDown1.Value);
            ap2 = Convert.ToInt32(numericUpDown2.Value);
            ap3 = Convert.ToInt32(numericUpDown3.Value);
            ap4 = Convert.ToInt32(numericUpDown4.Value);
            timer1.Enabled = false;
            timer2.Enabled = false;
            checkanswers obj = new checkanswers();
            int correct = obj.numberofcorrect(ap1, sap1, ap2, sap2, ap3, sap3, ap4, sap4, numericUpDown1, numericUpDown2, numericUpDown3, numericUpDown4);
                      
            label20.Text = "Ο χρόνος που χρειάστηκες ειναι " + Convert.ToString(timeneeded) + " δευτερόλεπτα";
            label22.Text=  "Οι σωστές απαντήσεις στα 4 ειναι :" + correct.ToString();
            
            
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Press the start button to have fun!!!");
            MessageBox.Show("When you think you are ready press submit and see what you've done!");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            if (timer1.Enabled == false)
                timeneeded = timeneeded + 1;
        }

        private void deafultToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void coralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Coral;
        }

        private void tanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Tan;
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void copyrightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Dimitris Zerkelidis , Giorgos Voukounas, Anastasia Mpelia");
        }

        private void restartTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
    }
}
