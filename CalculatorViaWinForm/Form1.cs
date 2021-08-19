using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorViaWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int dotCount = 0;
        double fNum = 0;
        double sNum = 1;
        bool isChangedText = false;
        bool isOp = false;

        private void IsTextChage(object sender, EventArgs e)
        {
            isChangedText = true;
        }
        private void DontTypeTextBox(object sender, KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        public bool IsOperation(string source)
        {
            bool res = false;
            int opIndex;
            if (source.Length == 0)
            {
                return res;
            }
            else
            {
                opIndex = source.Length - 2;
            }
            if (source[opIndex].ToString() == plusBtn.Text || 
                source[opIndex].ToString() == minusBtn.Text || 
                source[opIndex].ToString() == devideBtn.Text || 
                source[opIndex].ToString() == multiplyBtn.Text || 
                source[opIndex].ToString() == equalBtn.Text)
            {
                res = true;
            }
            return res;
        }

        private void InputNumber(object sender,EventArgs e)
        {
            if (this.enterTextBox.Text.Length < 13)
            {
                string senderText = ((Button)sender).Text;
                if (senderText == dotBtn.Text)
                {
                    if (dotCount < 1)
                    {
                        this.enterTextBox.Text += senderText;
                        dotCount++;
                    }
                }
                else
                {
                    if (!String.IsNullOrWhiteSpace(this.finalLabel.Text))
                    {
                        if (this.finalLabel.Text[this.finalLabel.Text.Length - 2].ToString()
                        == equalBtn.Text)
                        {
                            Clear((object)clearAllBtn, e);
                            this.enterTextBox.Text += senderText;
                            dotCount = 0;
                            isOp = false;
                        }

                        else if (IsOperation(finalLabel.Text) && isOp)
                        {
                            this.enterTextBox.Text = "";
                            this.enterTextBox.Text += senderText;
                            dotCount = 0;
                            isOp = false;
                        }
                        else if (this.enterTextBox.Text == "0")
                        {
                            this.enterTextBox.Text = senderText;
                        }
                        else
                        {
                            this.enterTextBox.Text += senderText;
                        }
                    }
                    else if (this.enterTextBox.Text == "0")
                    {
                        this.enterTextBox.Text = senderText;
                    }
                    else
                    {
                        this.enterTextBox.Text += senderText;
                    }
                }
            }
        }

        public string ChangeText(string senderText,string source)
        {
            string tempStr = null;
            for (int i = 0; i < source.Length - 2; i++)
            {
                tempStr += source[i].ToString();
            }
            tempStr += senderText + " ";
            return tempStr;
        }

        Func<double, double, string> lastOp;

        private void Operation(string operation,Func<double,double,string> op)
        {
            if (lastOp == null)
            {
                lastOp = op;
            }
            if (String.IsNullOrWhiteSpace(this.finalLabel.Text))
            {
                if (this.enterTextBox.Text[this.enterTextBox.Text.Length - 1].ToString()
                    == dotBtn.Text)
                {
                    string tempStr = null;
                    for (int i = 0; i < this.enterTextBox.Text.Length - 1; i++)
                    {
                        tempStr += this.enterTextBox.Text[i].ToString();
                    }
                    this.enterTextBox.Text = tempStr;
                    fNum = double.Parse(tempStr);
                    this.finalLabel.Text += tempStr + " " + operation + " ";
                    isChangedText = false;
                    isOp = true;
                }
                else
                {
                    fNum = double.Parse(this.enterTextBox.Text);
                    this.finalLabel.Text += this.enterTextBox.Text + " " + operation + " ";
                    isChangedText = false;
                    isOp = true;
                }
            }
            if (isChangedText)
            {
                if (this.enterTextBox.Text[this.enterTextBox.Text.Length - 1].ToString()
                    == dotBtn.Text)
                {
                    string tempStr = null;
                    for (int i = 0; i < this.enterTextBox.Text.Length - 1; i++)
                    {
                        tempStr += this.enterTextBox.Text[i].ToString();
                    }
                    sNum = double.Parse(tempStr);
                    this.finalLabel.Text += tempStr + " " + operation + " " ;
                    this.enterTextBox.Text = lastOp(fNum, sNum);
                    fNum = double.Parse(this.enterTextBox.Text);
                    lastOp = op;
                    isOp = true;
                    isChangedText = false;
                }
                else if (operation == equalBtn.Text)
                {
                    sNum = double.Parse(this.enterTextBox.Text);
                    this.finalLabel.Text += this.enterTextBox.Text + " " + operation + " ";
                    this.enterTextBox.Text = lastOp(fNum, sNum);
                    if (this.enterTextBox.Text == "Error")
                    {
                        fNum = 0;
                    }
                    else
                    {
                        fNum = double.Parse(this.enterTextBox.Text);
                    }
                    lastOp = op;
                    isOp = true;
                    isChangedText = false;
                }
                else
                {
                    sNum = double.Parse(this.enterTextBox.Text);
                    this.finalLabel.Text += this.enterTextBox.Text + " " + operation + " ";
                    this.enterTextBox.Text = lastOp(fNum, sNum);
                    fNum = double.Parse(lastOp(fNum, sNum));
                    lastOp = op;
                    isOp = true;
                }
            }
            else
            {
                this.finalLabel.Text = ChangeText(operation, this.finalLabel.Text);
                lastOp = op;
            }
            
        }

        private void Operations(object sender, EventArgs e)
        {
            string senderText = ((Button)sender).Text;
            Calculator calculator = new Calculator();
            if (senderText == plusBtn.Text)
            {
                Operation(senderText, calculator.Plus);
            }
            else if (senderText == minusBtn.Text)
            {
                Operation(senderText, calculator.Minus);
            }
            else if (senderText == multiplyBtn.Text)
            {
                Operation(senderText, calculator.Multiply);
            }
            else if (senderText == devideBtn.Text)
            {
                Operation(senderText, calculator.Devide);
            }
            else if (senderText == equalBtn.Text)
            {
                Operation(senderText, lastOp);
            }
        }

        public void Clear(object sender,EventArgs e)
        {
            string senderText = ((Button)sender).Text;

            if (!String.IsNullOrWhiteSpace(this.finalLabel.Text))
            {
                if (senderText == clearAllBtn.Text ||
                   (senderText == clearEntryBtn.Text &&
                   this.finalLabel.Text[this.finalLabel.Text.Length - 2].ToString()
                   == equalBtn.Text))
                {
                    fNum = 0;
                    sNum = 1;
                    this.finalLabel.Text = "";
                    this.enterTextBox.Text = "0";
                }
            }
            else if (senderText == clearEntryBtn.Text)
            {
                sNum = 1;
                this.enterTextBox.Text = "0";
            }
            else if (senderText == removeBtn.Text && isChangedText)
            {
                string tempStr = null;
                for (int i = 0; i < this.enterTextBox.Text.Length - 1; i++)
                {
                    tempStr += this.enterTextBox.Text[i].ToString();
                }
                this.enterTextBox.Text = tempStr;
            }
            else if (senderText == removeBtn.Text && !isChangedText && this.finalLabel.Text[this.finalLabel.Text.Length - 2].ToString() == equalBtn.Text)
            {
                this.finalLabel.Text = "";
            }
        }

    }
    public class Calculator
    {
        public string Plus(double fNum,double sNum)
        {
            return (fNum + sNum).ToString();
        }
        public string Minus(double fNum,double sNum)
        {
            return (fNum - sNum).ToString();
        }
        public string Devide(double fNum,double sNum)
        {
            if (sNum == 0)
            {
                return "Error";
            }
            return (fNum / sNum).ToString();
        }
        public string Multiply(double fNum,double sNum)
        {
            return (fNum * sNum).ToString();
        }
    }
}
