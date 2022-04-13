using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Linq;
using System.Text;

namespace Calculatrice
{  
    public partial class mainPage : Form
    {
        int countPoint = 0, countPlusMinus = 0, countOperation = 0;
        private bool btnPointCliked = false;
        private bool btnPlusCliked = false;
        private bool btnMinusCliked = false;
        private bool btnMultiCliked = false;
        private bool BtnDivClicked = false;
        float num, total;


        public mainPage()
        {
            InitializeComponent();
        }
        //Button 0 to 9 call fonction numbers
        //-------------------------------------------------------
        private void btn0_Click(object sender, EventArgs e)
        {
            numbers("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            numbers("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            numbers("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            numbers("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            numbers("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            numbers("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            numbers("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            numbers("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            numbers("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            numbers("9");
        }
        //-------------------------------------------------------

        //Button dot -> . 
        private void btnPoint_Click(object sender, EventArgs e)
        {
            btnPointCliked = true;         

            if (countPoint < 1) 
            {
                lblNum.Text += ".";
            }
            countPoint++;
        }

        //Button = 
        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch (countOperation) 
            {
                case 1:
                    total = num / float.Parse(lblNum.Text);
                    lblNum.Text = total.ToString();
                    BtnDivClicked = false;
                    break;

                case 2:
                    total = num * float.Parse(lblNum.Text);
                    lblNum.Text = total.ToString();
                    btnMultiCliked = false;
                    break;

                case 3:
                    total = num - float.Parse(lblNum.Text);
                    lblNum.Text = total.ToString();
                    btnMinusCliked = false;
                    break;
                    
                case 4:
                    total = num + float.Parse(lblNum.Text);
                    lblNum.Text = total.ToString();
                    btnPlusCliked = false;
                    break;

                default:
                    break;
            }
        }

        //Button +
        private void btnPlus_Click(object sender, EventArgs e)
        {           
            btnPlusCliked = true;
            string temp = lblNum.Text;
            btnPointCliked = false;
            num = float.Parse(temp);            
            countOperation = 4;

        }

        //Button -
        private void btnMinus_Click(object sender, EventArgs e)
        {
            btnMinusCliked = true;
            btnPointCliked = false;
            string temp = lblNum.Text;
            num = float.Parse(temp);
            countOperation = 3;
        }

        //Button *
        private void btnMulti_Click(object sender, EventArgs e)
        {
            btnMultiCliked = true;
            btnPointCliked = false;
            string temp = lblNum.Text;
            num = float.Parse(temp);
            countOperation = 2;
        }

        //Button /
        private void btnDiv_Click(object sender, EventArgs e)
        {
            BtnDivClicked = true;
            btnPointCliked = false;
            string temp = lblNum.Text;
            num = float.Parse(temp);
            countOperation = 1;
        }

        //Button AC
        private void btnAc_Click(object sender, EventArgs e)
        {
            lblNum.Text = "0";
            countPoint = 0;
            countOperation = 0;
        }

        //Button +/-
        private void btnPlusAndMinus_Click(object sender, EventArgs e)
        {
            countPlusMinus++;
            string lines = lblNum.Text;
            string[] line = lines.Split('-');
            
            if (countPlusMinus % 2 == 0)
            {
                lblNum.Text = line[1];
            }
            else 
            {
                string temp = "-" + lblNum.Text;
                lblNum.Text = temp;
            }
        }

        //Button %
        private void btnPourcentage_Click(object sender, EventArgs e)
        {
            string temp = lblNum.Text;
            float pour = float.Parse(temp);
            float total = pour / 100;
            lblNum.Text = total.ToString();
        }

        //Label that show to the user, the number click
        private void lblNum_Click(object sender, EventArgs e)
        {
            string temp = lblNum.Text;
            temp = temp.Remove(temp.Length - 1);

            if(temp.Length == 0)
                lblNum.Text = "0";
            else
                lblNum.Text = temp;
        }

        //Function numbers
        private void numbers(string num) 
        {
            string tempNum = lblNum.Text;
            if (btnPlusCliked || btnMinusCliked || btnMultiCliked || BtnDivClicked)
            {
                lblNum.Text = num;
                btnPlusCliked = false;
                btnMinusCliked = false;
                btnMultiCliked = false;
                BtnDivClicked = false;
            }
            else
            {
                if (tempNum.Length >= 1 && tempNum != "0")
                    lblNum.Text += num;
                else
                    lblNum.Text = num;
            }
        }
    }
}