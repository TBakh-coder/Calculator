using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedemptionCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
       
        private void setValue(int value)
        {//I've used methods for this code due to decrease the length of codes 
            button_BackSpace.Enabled = true;
            if (textBox2.Text == "")
            {
                textBox1.Text = textBox1.Text + (value.ToString());
            }

            if (textBox2.Text != "")
            {
                textBox3.Text = textBox3.Text + (value.ToString());
            }
            if (label3.Visible == true)
            {
                label3.Visible = false;
            }
            if (textBox4.TextLength > 0)
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                label2.Visible = false;
                button11.Enabled = false;
                label3.Visible = false;
                //button_BackSpace.Enabled = false;
                textBox1.Text = (value.ToString());
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {//This section is for put % symbon on textbox 2
            textBox2.Text = "%";
            if (textBox1.TextLength == 0)
            {//in this cas if you will use that symbol without write any number you will get an error that is why I used that part for correction
                double i = 0;
                textBox1.Text = (i.ToString());
            }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox2.Text = "-";
            if (textBox1.TextLength == 0)
            {
                double i = 0;
                textBox1.Text = (i.ToString());
            }

        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox2.Text = "x²";
            if (textBox1.TextLength > 0)
            {//I've used 2 if in here due to answer, if I used one if and one else if then answer doesn't seem
                //you can try it ;)
                if (textBox2.Text == "x²" || textBox2.Text != "")
                {
                    string a;
                    a = textBox1.Text;
                    label2.Visible = true;
                    label2.Text = textBox1.Text + "²";
                }
                if (textBox2.Text == "x²")
                {
                    double c, a;
                    a = double.Parse(textBox1.Text);
                    c = a * a;
                    textBox4.Text = (c.ToString());
                }
                if (textBox3.TextLength > 0 )
                {
                    textBox3.Clear();
                }
            }

            if (textBox1.TextLength == 0)
            {//it is my easter egg for program if you didn't input something you will get a this text :)
                MessageBox.Show("C'mon you know it will be 0", "Seriously?");
                textBox2.Clear();
            }
            //as you may see I wrote here button 11 enabled is false because if you click square you will get an answer immediately that is why I disabled that button
            button11.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {     int a;
               a = 1;
              setValue(a); 
        }
         private void button2_Click(object sender, EventArgs e)
        {
        int b = 2;
            setValue(b);
         }

        private void button3_Click(object sender, EventArgs e)
        {
            int c = 3;
            setValue(c);
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            int d = 4;
            setValue(d);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int r = 5;
            setValue(r);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int f = 6;
            setValue(f);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            int g = 7;
            setValue(g);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int h = 8;
            setValue(h);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            int j = 9;
            setValue(j);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            int i = 0;
            setValue(i);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {//it is answer button code section as you may read I said in that code if text box 3 text lenght more that zero then activate answer button. too great right? :)
            if (textBox3.TextLength > 0)
            {
                button11.Enabled = true;
            }
         else
            {//in other cases answer button will be disabled
                button11.Enabled = false;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox2.Text = "+";
            button11.Enabled = true;

            if (textBox1.TextLength == 0)
            {
                MessageBox.Show("if you will add something zero it will be same number ", "Don't try to find error");
                textBox2.Clear();
                button11.Enabled = false;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox2.Text = "÷";
            button11.Enabled = true;
            if (textBox1.TextLength == 0)
            {
                double i = 0;
                textBox1.Text = (i.ToString());
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox2.Text = "x";
            if (textBox1.TextLength == 0)
            {
                double i = 0;
                textBox1.Text = (i.ToString());
            }
            //button11.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {

           //here is for opperations 
            if (textBox3.TextLength == 0)
            {
                button11.Enabled = false;
            }
            double a, b, c;

            if (textBox2.Text != "x²")
            {
                a = double.Parse(textBox1.Text);
                b = double.Parse(textBox3.Text);

                if (textBox2.Text == "÷")
                {
                    c = a / b;
                    textBox4.Text = (c.ToString());
                }
                if (textBox2.Text == "+")
                {
                    c = a + b;
                    textBox4.Text = (c.ToString());
                }
                if (textBox2.Text == "-")
                {
                    c = a - b;
                    textBox4.Text = (c.ToString());
                }
                if (textBox2.Text == "%")
                {
                    c = a % b;
                    textBox4.Text = (c.ToString());

                }
                if (textBox2.Text == "x")
                {
                    c = a * b;
                    textBox4.Text = (c.ToString());
                }

            }
            if (textBox2.Text == "x²")
            {
                a = int.Parse(textBox1.Text);
                c = a * a;
                textBox4.Text = (c.ToString());
            }
            if (textBox2.Text == "x^")
            {
                int fir, sec, res = 1;
                fir = Convert.ToInt32(textBox1.Text);
                sec = Convert.ToInt32(textBox3.Text);


                while (sec != 0)
                {
                    res *= fir;
                    --sec;
                }


                textBox4.Text = res.ToString();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {    //
            //Factorial part of code
           //
            if (textBox1.TextLength > 0)
            {
                textBox2.Text = "!";
                if (textBox2.Text == "!")
                {
                    label2.Text = textBox1.Text + "!";

                    label2.Visible = true;

                    double num = Convert.ToInt32(textBox1.Text);

                    double fact = 1;

                    for (double i = num; i > 0; i--)

                    {

                        fact = fact * i;

                    }

                    textBox4.Text = fact.ToString();
                }
                if (textBox1.TextLength == 0)
                {//Some easter eggs
                    MessageBox.Show("C'mon you know it will be 0", "Seriously?");
                    textBox2.Clear();
                }

            }

        }

        private void button15_Click(object sender, EventArgs e)
        {//C button for Removing everything
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            label2.Visible = false;
            button11.Enabled = false;
            label3.Visible = true;
            button_BackSpace.Enabled = false;
        }

        

        private void button20_Click(object sender, EventArgs e)
        {//here is for .(dot) so it looks like hardest part for me but actually it is too easy
            if (textBox4.TextLength > 0)
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                label2.Visible = false;
                button11.Enabled = false;
                label3.Visible = true;
                button_BackSpace.Enabled = false;
            }
            if (textBox2.Text == "")
            {
                textBox1.Text = textBox1.Text + ".";
            }
            if (textBox2.TextLength > 0)
            {
                textBox3.Text = textBox3.Text + ".";
            }

           else if (label3.Visible == true )
            {
                double i;
                i = 0;
                label3.Visible = false;
                textBox1.Text = (i.ToString()) + ".";
            }
            if (textBox1.Text == "0.")
            {//if there is 0. om textbox1 Back Space button will be enabled
                button_BackSpace.Enabled = true;
            }
            if (textBox3.Text == ".")
           {//in that case if you use . wihtout any number program will put 0 automaticly 
              double i;
                i = 0;
               textBox3.Text = (i.ToString()) + ".";
            }
        }


        private void Calculator_Load(object sender, EventArgs e)
        {

        }


        private void button17_Click(object sender, EventArgs e)
        {//here is Back Space button part. Actually it is so complicated but never mind I had to write these codes for error free and bug free
         
            
            if (textBox3.TextLength > 0 && textBox4.Text != "")
            {
                textBox3.Text = textBox3.Text.Substring(0, (textBox3.TextLength - 1));
                textBox4.Clear();
                

            }
           
            else if (textBox2.TextLength == 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, (textBox1.TextLength - 1));

            }

           else if (textBox3.Text == "")
            {

                textBox2.Text = textBox2.Text.Substring(0, (textBox2.TextLength - 1));
            }

            if (textBox2.Text == "")
            {
                button11.Enabled = false;
            }
            if (textBox1.Text == "")
            {
                button_BackSpace.Enabled = false;
            }
            if (label2.Visible == true)
            {

                label2.Visible = false;
            }
            if (textBox1.Text == "")
            {
                label3.Visible = true;
            }
            if (textBox1.Text == "0.")
            {
                button_BackSpace.Enabled = false;
                textBox1.Clear();
                label3.Visible = true;
            }




        }
        private void button24_Click(object sender, EventArgs e)
        {//This is close button
            this.Close();
        }

        private void button22_Click_1(object sender, EventArgs e)
        {//you will click Redemption Team section and you will see this things
            textBox5.Visible = true;
            button25.Visible = true;
            button23.Visible = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {//this is for Link on contact I don't know exactly why I was created that but it will helps to improve myself
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("mailto:baghaye1@stu.vistula.edu.pl");
        }
        private void timer2_Tick(object sender, EventArgs e)
        {//it is for Loading screen actually loading screen is not important but it will improve the apperance :)
            timer2.Stop();
            pictureBox1.Visible = false;

            FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void button23_Click_1(object sender, EventArgs e)
        {//if you will click close button on Redemption Team screen everything will be dispose
            textBox5.Visible = false;
            button23.Visible = false;
            button25.Visible = false;
        }

        private void button25_Click(object sender, EventArgs e)
        {//when you will open Redemption team textbox you will see Close Window button. It is for this button
            this.Close();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {//for Backspace button
            if (textBox1.TextLength == 0)
            {
                button_BackSpace.Enabled = false;
            }
        }

        private void button17_Click_1(object sender, EventArgs e)
        {//it is power button on calculator
            textBox2.Text = "x^";
            if (textBox1.TextLength == 0)
            {
                double i = 0;
                textBox1.Text = (i.ToString());
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
