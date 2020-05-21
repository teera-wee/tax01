using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double salary = 0, total = 0, discount = 0, vat = 0, baby = 0, discount15 = 0, tan = 0;
        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        { //ตัวเองและครอบครัว
            salary = double.Parse(textBox1.Text);
            discount15 = salary * 0.15;
            if (textBox6.Text == "")
            {
                baby = 0;
            }
            else
            {
                baby = double.Parse(textBox6.Text);
            }
            discount = 60000;
            if (radioButton1.Checked) discount += 0;
            if (radioButton2.Checked) discount += 60000;
            if (radioButton3.Checked) discount += 0;
            if (checkBox9.Checked) discount += 0;
            if (checkBox8.Checked) discount += 0;
            if (radioButton13.Checked) discount += 0;
            if (checkBox1.Checked) discount += 30000;
            if (checkBox2.Checked) discount += 30000;
            if (checkBox3.Checked) discount += 30000;
            if (checkBox4.Checked) discount += 30000;
            if (checkBox5.Checked) discount += (int)numericUpDown1.Value * 30000;
            if (checkBox6.Checked) discount += (int)numericUpDown1.Value * 60000;
            if (checkBox7.Checked) discount += (int)numericUpDown1.Value * 60000;
            //เงินออมและการลงทุน
            if (checkBox10.Checked) discount += (int)numericUpDown4.Value;
            if (((int)numericUpDown5.Value + (int)numericUpDown6.Value >= 100000))
            { 
                if ((checkBox11.Checked) || (checkBox12.Checked))
                discount += 100000; 
            }
            else
            {
                if (checkBox11.Checked) discount += (int)numericUpDown5.Value;
                if (checkBox12.Checked) discount += (int)numericUpDown6.Value;
            }
            if (checkBox13.Checked) discount += (int)numericUpDown7.Value;
            if (checkBox14.Checked) discount += (int)numericUpDown8.Value;
            if ((checkBox15.Checked) && ((int)numericUpDown9.Value <= discount15))
            {
                tan += (int)numericUpDown9.Value;
            }
            else if ((checkBox15.Checked) && ((int)numericUpDown9.Value > discount15))
            {
                tan += discount15;
            }
            if ((checkBox16.Checked) && ((int)numericUpDown10.Value <= 10000))
            {
                tan += (int)numericUpDown10.Value;
            }
            else
            {
                if ((checkBox16.Checked) && ((int)numericUpDown10.Value <= 500000) && ((int)numericUpDown10.Value <= discount15))
                {
                    tan += (int)numericUpDown10.Value;
                }
                else if ((checkBox16.Checked) && ((int)numericUpDown10.Value <= 500000) && ((int)numericUpDown10.Value >= discount15))
                {
                    tan += discount15;
                }
                else if ((checkBox16.Checked) && ((int)numericUpDown10.Value > 500000) && ((int)numericUpDown10.Value < discount15))
                {
                    tan += 500000;
                }
            } 
            if ((checkBox17.Checked) && ((int)numericUpDown11.Value <= discount15))
            {
                tan += (int)numericUpDown11.Value;
            }
            if (checkBox18.Checked) discount += (int)numericUpDown12.Value;
            if ((checkBox19.Checked) && ((int)numericUpDown13.Value <= discount15))
            {
                tan += (int)numericUpDown13.Value;
            }
            if ((checkBox20.Checked) && ((int)numericUpDown14.Value <= discount15))
            {
                discount += (int)numericUpDown14.Value;
            }
            //อสังหาริมทรัพย์
            if (checkBox21.Checked) discount += (int)numericUpDown15.Value;
            if (checkBox22.Checked) discount += (int)numericUpDown16.Value * 0.04;
            if (checkBox23.Checked) discount += (int)numericUpDown17.Value * 0.04;
            //เงินบริจาค
            if (checkBox24.Checked) discount += (int)numericUpDown18.Value * 2;
            if (checkBox25.Checked) discount += (int)numericUpDown19.Value;
            if (checkBox26.Checked) discount += (int)numericUpDown20.Value;
            if (checkBox27.Checked) discount += (int)numericUpDown21.Value * 2;
            if (checkBox28.Checked) discount += (int)numericUpDown22.Value * 2;
            if (checkBox29.Checked) discount += (int)numericUpDown23.Value * 2;
            if (checkBox30.Checked) discount += (int)numericUpDown24.Value;
            //มาตราการกระตุ้นเศรษฐกิจ
            if (checkBox31.Checked) discount += (int)numericUpDown25.Value;
            if (checkBox32.Checked) discount += (int)numericUpDown26.Value;
            if (checkBox33.Checked) discount += (int)numericUpDown27.Value;
            if (checkBox34.Checked) discount += (int)numericUpDown28.Value;
            if (checkBox35.Checked) discount += (int)numericUpDown29.Value;
            if (checkBox36.Checked) discount += (int)numericUpDown30.Value;

            if (tan > 500000) tan = 500000;
            discount = discount + baby + tan;
            textBox3.Text = discount.ToString("#,##0.00");
            textBox5.Text = total.ToString("#,##0.00");
        }
        //ตัวเองและครอบครัว
        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        //เงินออมและการลงทุน
        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        //อสังหาริมทรัพย์
        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        //เงินบริจาค
        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        private void checkBox27_CheckedChanged_1(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        private void checkBox28_CheckedChanged_1(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        private void checkBox29_CheckedChanged_1(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        private void checkBox30_CheckedChanged_1(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        //มาตราการกระตุ้นเศรษฐกิจของรัฐ
        private void checkBox31_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        private void checkBox32_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        private void checkBox33_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        private void checkBox34_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        private void checkBox35_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        private void checkBox36_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        //ตัวเองและครอบครัว
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        //เงินออมและการลงทุน
        private void numericUpDown4_ValueChanged_1(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        private void numericUpDown5_ValueChanged_1(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        private void numericUpDown6_ValueChanged_1(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        private void numericUpDown7_ValueChanged_1(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        private void numericUpDown8_ValueChanged_1(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        private void numericUpDown9_ValueChanged_1(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        private void numericUpDown10_ValueChanged_1(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        private void numericUpDown11_ValueChanged_1(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        private void numericUpDown12_ValueChanged_1(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        private void numericUpDown13_ValueChanged_1(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        private void numericUpDown14_ValueChanged_1(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        //อสังหาริมทรัพย์
        private void numericUpDown15_ValueChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        private void numericUpDown16_ValueChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        private void numericUpDown17_ValueChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        //เงินบริจาค
        private void numericUpDown18_ValueChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        private void numericUpDown19_ValueChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        private void numericUpDown20_ValueChanged_1(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        private void numericUpDown21_ValueChanged_1(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        private void numericUpDown22_ValueChanged_1(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        private void numericUpDown23_ValueChanged_1(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        private void numericUpDown24_ValueChanged_1(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        //มาตราการกระตุ้นเศรษฐกิจของรัฐ
        private void numericUpDown25_ValueChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        private void numericUpDown26_ValueChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        private void numericUpDown27_ValueChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        private void numericUpDown28_ValueChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        private void numericUpDown29_ValueChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        private void numericUpDown30_ValueChanged(object sender, EventArgs e)
        {
            radioButton1_CheckedChanged_1(sender, e);
        }
        //ปุ่มคำนวณ
        private void button1_Click(object sender, EventArgs e)
        {
            salary = double.Parse(textBox1.Text);
            total = salary - discount;
            if (total >= 5000001)
            {
                vat = total * 35 / 100;
            }
            else if (total >= 2000001 && total <= 5000000)
            {
                vat = total * 30 / 100;
            }
            else if (total >= 1000001 && total <= 2000000)
            {
                vat = total * 25 / 100;
            }
            else if (total >= 750001 && total <= 1000000)
            {
                vat = total * 20 / 100;
            }
            else if (total >= 500001 && total <= 750000)
            {
                vat = total * 15 / 100;
            }
            else if (total >= 300001 && total <= 500000)
            {
                vat = total * 10 / 100;
            }
            else if (total >= 150001 && total <= 300000)
            {
                vat = total * 5 / 100;
            }
            else if (total <= 150000)
            {
                vat = 0;
            }

            if (total < 0)
            {
                total = 0;
            }

            textBox4.Text = vat.ToString("#,##0.00");
            textBox5.Text = total.ToString("#,##0.00");
            textBox6.Text = baby.ToString("#,##0.00");
        }
        //เคลียร์ข้อมูล
        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox1.Text = "0.00";
            textBox3.Text = "0.00";
            textBox4.Text = "0.00";
            textBox5.Text = "0.00";
            textBox6.Text = "0.00";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton13.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
            checkBox19.Checked = false;
            checkBox20.Checked = false;
            checkBox21.Checked = false;
            checkBox22.Checked = false;
            checkBox23.Checked = false;
            checkBox24.Checked = false;
            checkBox25.Checked = false;
            checkBox26.Checked = false;
            checkBox27.Checked = false;
            checkBox28.Checked = false;
            checkBox29.Checked = false;
            checkBox30.Checked = false;
            checkBox31.Checked = false;
            checkBox32.Checked = false;
            checkBox33.Checked = false;
            checkBox34.Checked = false;
            checkBox35.Checked = false;
            checkBox36.Checked = false;
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 0;
            numericUpDown6.Value = 0;
            numericUpDown7.Value = 0;
            numericUpDown8.Value = 0;
            numericUpDown9.Value = 0;
            numericUpDown10.Value = 0;
            numericUpDown11.Value = 0;
            numericUpDown12.Value = 0;
            numericUpDown13.Value = 0;
            numericUpDown14.Value = 0;
            numericUpDown15.Value = 0;
            numericUpDown16.Value = 0;
            numericUpDown17.Value = 0;
            numericUpDown18.Value = 0;
            numericUpDown19.Value = 0;
            numericUpDown20.Value = 0;
            numericUpDown21.Value = 0;
            numericUpDown22.Value = 0;
            numericUpDown23.Value = 0;
            numericUpDown24.Value = 0;
            numericUpDown25.Value = 0;
            numericUpDown26.Value = 0;
            numericUpDown27.Value = 0;
            numericUpDown28.Value = 0;
            numericUpDown29.Value = 0;
            numericUpDown30.Value = 0;
        }
        //กรอกได้แต่ตัวเลข
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("กรุณากรอกเป็นตัวเลขจ้าา");
            }
        }
        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("กรุณากรอกเป็นตัวเลขจ้าา");
            }
        }
        //กรอกได้แต่ตัวอักษร
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("กรุณากรอกเป็นตัวอักษรจ้าา");
            }
        }
        //ออกจากโปรแกรม
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }
        private void label57_Click(object sender, EventArgs e)
        {

        }
        private void textBox31_TextChanged(object sender, EventArgs e)
        {

        }
        private void label56_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

    }
}
