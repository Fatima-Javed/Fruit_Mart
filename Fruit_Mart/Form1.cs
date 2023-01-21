using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Fruit_Mart
{
    public partial class Form1 : Form
    {
        int totalprice = 0;
        int price;
        int p1, p2, p3, p4, p5, p6;
        int total_product;
        public Form1()
        {
            InitializeComponent();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                total_product++;
                numericUpDown1.Enabled = true;
                comboBox1.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                total_product++;
                numericUpDown2.Enabled = true;
                comboBox2.Enabled = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                total_product++;
                numericUpDown3.Enabled = true;
                comboBox3.Enabled = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                total_product++;
                numericUpDown4.Enabled = true;
                comboBox4.Enabled = true;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                total_product++;
                numericUpDown5.Enabled = true;
                comboBox5.Enabled = true;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                total_product++;
                numericUpDown6.Enabled = true;
                comboBox6.Enabled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime timeNow = DateTime.Now;
            textBox1.Text = timeNow.ToString();
            groupBox1.Visible = true;
            label31.Visible = true;
            label32.Visible = true;
            label33.Visible = true;


            if (checkBox1.Checked)
            {
                label11.Visible = true;
                label11.Text = "Apple";
                label12.Visible = true;
                label13.Visible = true;
                if (comboBox1.Text.ToString() == "High")
                {
                    price = 200;
                    label12.Text = numericUpDown1.Value.ToString();
                    p1 = (int)(numericUpDown1.Value * price);
                    label13.Text = p1.ToString();
                }
                else
                {

                    price = 150;
                    label12.Text = numericUpDown1.Value.ToString();
                    p1 = (int)(numericUpDown1.Value * price);
                    label13.Text = p1.ToString();
                }
                textBox2.Text = total_product.ToString();
                totalprice = p1+p2+p3+p4+p5+p6;
                textBox3.Text = totalprice.ToString();
            }

            if (checkBox2.Checked)
            {
                label14.Visible = true;
                label14.Text = "Orange";
                label15.Visible = true;
                label16.Visible = true;
                label16.Text = comboBox2.SelectedText;
                if (comboBox2.Text.ToString() == "High")
                {
                    price = 300;
                    label15.Text = numericUpDown2.Value.ToString();
                    p2 = (int)(numericUpDown2.Value * price);
                    label16.Text = p2.ToString();
                }
                else
                {

                    price = 200;
                    label15.Text = numericUpDown2.Value.ToString();
                    p2 = (int)(numericUpDown2.Value * price);
                    label16.Text = p2.ToString();
                }
                textBox2.Text = total_product.ToString();
                 totalprice = p1 + p2 + p3 + p4 + p5 + p6;
                textBox3.Text = totalprice.ToString();
            }

            if (checkBox3.Checked)
            {
                label17.Visible = true;
                label17.Text = "Mango";
                label18.Visible = true;
                label19.Visible = true;
                if (comboBox3.Text.ToString() == "High")
                {
                    price = 150;
                    label18.Text = numericUpDown3.Value.ToString();
                    p3 = (int)(numericUpDown3.Value * price);
                    label19.Text = p3.ToString();
                }
                else
                {

                    price = 120;
                    label18.Text = numericUpDown3.Value.ToString();
                    p3 = (int)(numericUpDown3.Value * price);
                    label19.Text = p3.ToString();
                }
                textBox2.Text = total_product.ToString();
                totalprice = p1 + p2 + p3 + p4 + p5 + p6;
                textBox3.Text = totalprice.ToString();
            }

            if (checkBox4.Checked)
            {
                label20.Visible = true;
                label20.Text = "Peach";
                label21.Visible = true;
                label22.Visible = true;
                if (comboBox4.Text.ToString() == "High")
                {
                    price = 250;
                    label21.Text = numericUpDown4.Value.ToString();
                    p4 = (int)(numericUpDown4.Value * price);
                    label22.Text = p4.ToString();
                }
                else
                {

                    price = 200;
                    label21.Text = numericUpDown4.Value.ToString();
                    p4 = (int)(numericUpDown4.Value * price);
                    label22.Text = p4.ToString();
                }
                textBox2.Text = total_product.ToString();
                totalprice = p1 + p2 + p3 + p4 + p5 + p6;
                textBox3.Text = totalprice.ToString();
            }

            if (checkBox5.Checked)
            {
                label23.Visible = true;
                label23.Text = "Pineapple";
                label24.Visible = true;
                label25.Visible = true;
                if (comboBox5.SelectedItem.ToString() == "High")
                {
                    price = 1000;
                    label24.Text = numericUpDown5.Value.ToString();
                    p5 = (int)(numericUpDown5.Value * price);
                    label25.Text = p5.ToString();
                }
                else
                {

                    price = 800;
                    label24.Text = numericUpDown5.Value.ToString();
                    p5 = (int)(numericUpDown5.Value * price);
                    label25.Text = p5.ToString();
                }
                textBox2.Text = total_product.ToString();
                totalprice = p1 + p2 + p3 + p4 + p5 + p6;
                textBox3.Text = totalprice.ToString();
            }

            if (checkBox6.Checked)
            {
                label26.Visible = true;
                label26.Text = "Strawberries";
                label27.Visible = true;
                label28.Visible = true;
                if (comboBox6.Text.ToString() == "High")
                {
                    price = 90;
                    label27.Text = numericUpDown6.Value.ToString();
                    p6 = (int)(numericUpDown6.Value * price);
                    label28.Text = p6.ToString();
                }
                else
                {

                    price = 60;
                    label27.Text = numericUpDown6.Value.ToString();
                    p6 = (int)(numericUpDown6.Value * price);
                    label28.Text = p6.ToString();
                }
                textBox2.Text = total_product.ToString();
                totalprice = p1 + p2 + p3 + p4 + p5 + p6;
                textBox3.Text = totalprice.ToString();
            }
       
            if (radioButton1.Checked== true)
                {
                    totalprice += 20;
                    textBox3.Text = totalprice.ToString();
                }
                }
        }
    }



