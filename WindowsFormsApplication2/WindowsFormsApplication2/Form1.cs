using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string butname = "1";
            buttonSelect(butname);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string butname = "2";
            buttonSelect(butname);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string butname = "3";
            buttonSelect(butname);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string butname = "4";
            buttonSelect(butname);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string butname = "5";
            buttonSelect(butname);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string butname = "6";
            buttonSelect(butname);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string butname = "7";
            buttonSelect(butname);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string butname = "8";
            buttonSelect(butname);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string butname = "9";
            buttonSelect(butname);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string butname = "0";
            buttonSelect(butname);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string m = textBox1.Text;
            string d = "";
            if (textBox1.Text.Length > 1)
            {
                for (int i = 0; i < m.Length - 1; i++)
                {
                    d = d + m[i];
                    textBox1.Text = d;
                }
            }
            else if (textBox1.Text.Length == 1)
            {
                m = "";
                textBox1.Text = m;
            }
        }

        public void buttonSelect(string button)
        {
            if (textBox1.Text != "")
                textBox1.Text = textBox1.Text + button;
            else
                textBox1.Text = button;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                string number = textBox1.Text;
            //int nub = Int32.Parse(number);
            
            

            var num_list = new List<object> {
                "zero",
                "one",
                "two",
                "three",
                "four",
                "five",
                "six",
                "seven",
                "eight",
                "nine"
            };
            var pnum_list = new List<object> {
                "ten",
                "eleven",
                "twelve",
                "thirteen",
                "fourteen",
                "fithteen",
                "sixteen",
                "seventeen",
                "eighteen",
                "nineteen"
            };
            var tens_list = new List<object> {
                "ten",
                "twenty",
                "thirty",
                "forty",
                "fifty",
                "sixty",
                "seventy",
                "eighty",
                "ninety"
            };
            var size_list = new List<object> {
                "hundred and",
                "",
                "",
                "",
                "thousand",
                "",
                "",
                "million,",
                "",
                "",
                "billion,",
                "",
                "",
                "trillion,"
            };
            var x_list = "";
            var x_str = number;
            var num_count = x_str.Count();

            
            while (num_count > 0) {
                if ((num_count == 4 || num_count == 7 || num_count == 10 || num_count == 13) && x_str.Count() == num_count) {
                    x_list += num_list[Int32.Parse(x_str[x_str.Count() - num_count].ToString())] + " " + size_list[num_count] + " ";
                    num_count -= 1;
                }
                else if ((num_count == 3 || num_count == 6 || num_count == 9 || num_count == 12 || num_count == 15) && Int32.Parse(x_str[x_str.Count() - num_count].ToString()) > 0)
                {
                    x_list += num_list[Int32.Parse(x_str[x_str.Count() - num_count].ToString())] + " " + size_list[0] + " ";
                    num_count -= 1;
                }
                else if (num_count == 3 && Int32.Parse(x_str[x_str.Count() - num_count].ToString()) == 0)
                {
                    x_list += "and ";
                    num_count -= 1;
                }
                else if ((num_count == 2 || num_count == 5 || num_count == 8 || num_count == 11 || num_count == 14) && Int32.Parse(x_str[x_str.Count() - num_count].ToString()) > 0)
                {
                    if (Int32.Parse(x_str[x_str.Count() - num_count].ToString()) == 1)
                    {
                        x_list += pnum_list[Int32.Parse(x_str[x_str.Count() - num_count + 1].ToString())] + " ";
                        num_count -= 2;
                        if (num_count > 0) {
                            x_list += size_list[num_count + 1] + " ";
                        }
                    } else {
                        x_list += tens_list[Int32.Parse(x_str[x_str.Count() - num_count].ToString()) - 1];
                        num_count -= 1;
                        if (Int32.Parse(x_str[x_str.Count() - num_count].ToString()) == 0)
                        {
                            x_list += " ";
                            num_count -= 1;
                        } else if (num_count > 0) {
                            x_list += " " + num_list[Int32.Parse(x_str[x_str.Count() - num_count].ToString())] + " ";
                            num_count -= 1;
                        }
                        if (num_count > 0) {
                            x_list += size_list[num_count + 1] + " ";
                        }
                    }
                } else if (x_str.Count() == 1) {
                    x_list = num_list[Int32.Parse(x_str[x_str.Count() - num_count].ToString())].ToString();
                    num_count -= 1;
                }
                else if (Int32.Parse(x_str[x_str.Count() - num_count].ToString()) == 0)
                {
                    num_count -= 1;
                }
            }
            x_list = x_list + ".";
            x_list = x_list[0].ToString().ToUpper() + x_list.Substring(2);
            x_list = x_list.Replace( "thousand,", "thousand and");


            textBox2.Text = x_list.ToString();
            

            }
            catch (Exception ex)
            {
                textBox2.Text = ex.Message;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        }
    }

