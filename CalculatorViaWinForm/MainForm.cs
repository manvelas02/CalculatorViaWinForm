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
    public partial class CalculatorWinForm : Form , ICalculatorOperation
    {
        public CalculatorWinForm()
        {
            InitializeComponent();
        }
        double fNum = 0;
        double sNum = 1;
        bool isChangedText = false;
        bool isOp = false;
        List<string> historyArr = new List<string>();
        private void IsTextChage(object button, EventArgs e)
        {
            isChangedText = true;
        }
        private void DontTypeTextBox(object button, KeyPressEventArgs e)
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
        private void InputNumber(object button, EventArgs e)
        {
            string buttonText = ((Button)button).Text;
            if (this.enterTextBox.Text.Length < 13)
            {
                if (buttonText == dotBtn.Text && this.enterTextBox.Text != "Error")
                {
                    if (!isChangedText)
                    {
                        this.enterTextBox.Text = "0";
                        this.enterTextBox.Text += dotBtn.Text;
                    }
                    if (!this.enterTextBox.Text.Contains(dotBtn.Text))
                    {
                        this.enterTextBox.Text += buttonText;
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
                            if (buttonText == dotBtn.Text)
                            {
                                if (!this.enterTextBox.Text.Contains(dotBtn.Text))
                                {
                                    this.enterTextBox.Text += buttonText;
                                }
                            }
                            else
                            {
                                this.enterTextBox.Text = buttonText;
                            }
                            isOp = false;
                        }
                        else if (IsOperation(finalLabel.Text) && isOp && !isChangedText)
                        {
                            this.enterTextBox.Text = "";
                            this.enterTextBox.Text += buttonText;
                            isOp = false;
                        }
                        else if (this.enterTextBox.Text == "0" || this.enterTextBox.Text == "Error")
                        {
                            this.enterTextBox.Text = buttonText;
                        }
                        else
                        {
                            this.enterTextBox.Text += buttonText;
                        }
                    }
                    else if (this.enterTextBox.Text == "0" || this.enterTextBox.Text == "Error")
                    {
                        this.enterTextBox.Text = buttonText;
                    }
                    else
                    {
                        this.enterTextBox.Text += buttonText;
                    }
                }
            }
            else if (this.enterTextBox.Text.Length > 13 && !isChangedText)
            {
                if (buttonText == dotBtn.Text && this.enterTextBox.Text != "Error")
                {
                    if (!isChangedText)
                    {
                        this.enterTextBox.Text = "0";
                        this.enterTextBox.Text += dotBtn.Text;
                    }
                    if (!this.enterTextBox.Text.Contains(dotBtn.Text))
                    {
                        this.enterTextBox.Text += buttonText;
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
                            if (buttonText == dotBtn.Text)
                            {
                                if (!this.enterTextBox.Text.Contains(dotBtn.Text))
                                {
                                    this.enterTextBox.Text += buttonText;
                                }
                            }
                            else
                            {
                                this.enterTextBox.Text = buttonText;
                            }
                            isOp = false;
                        }
                        else if (IsOperation(finalLabel.Text) && isOp && !isChangedText)
                        {
                            this.enterTextBox.Text = "";
                            this.enterTextBox.Text += buttonText;
                            isOp = false;
                        }
                        else if (this.enterTextBox.Text == "0" || this.enterTextBox.Text == "Error")
                        {
                            this.enterTextBox.Text = buttonText;
                        }
                        else
                        {
                            this.enterTextBox.Text += buttonText;
                        }
                    }
                    else if (this.enterTextBox.Text == "0" || this.enterTextBox.Text == "Error")
                    {
                        this.enterTextBox.Text = buttonText;
                    }
                    else
                    {
                        this.enterTextBox.Text += buttonText;
                    }
                }
            }
        }
        public string ChangeText(string buttonText, string source)
        {
            string tempStr = null;
            for (int i = 0; i < source.Length - 2; i++)
            {
                tempStr += source[i].ToString();
            }
            tempStr += buttonText + " ";
            return tempStr;
        }
        Func<double, double, string> lastOp;
        public void Operation(string operation, Func<double, double, string> op)
        {
            if (lastOp == null)
            {
                lastOp = op;
            }
            if (this.finalLabel.Text.Length < 32)
            {
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
                    else if (operation == inNumSecDeegreBtn.Text)
                    {
                        sNum = double.Parse(this.enterTextBox.Text);
                        this.finalLabel.Text += this.enterTextBox.Text + " ^ 2 " + equalBtn.Text + " ";
                        this.enterTextBox.Text = lastOp(sNum, sNum);
                        fNum = double.Parse(this.enterTextBox.Text);
                        isChangedText = false;
                        lastOp = null;
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
                        this.finalLabel.Text += tempStr + " " + operation + " ";
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
                    else if (operation == inNumSecDeegreBtn.Text)
                    {
                        sNum = double.Parse(this.enterTextBox.Text);
                        this.finalLabel.Text += this.enterTextBox.Text + " ^ 2 " + equalBtn.Text + " ";
                        this.enterTextBox.Text = lastOp(sNum, 2);
                        fNum = double.Parse(this.enterTextBox.Text);
                        lastOp = null;
                        isChangedText = false;
                        isOp = true;
                    }
                    else
                    {
                        sNum = double.Parse(this.enterTextBox.Text);
                        this.finalLabel.Text += this.enterTextBox.Text + " " + operation + " ";
                        this.enterTextBox.Text = lastOp(fNum, sNum);
                        fNum = double.Parse(lastOp(fNum, sNum));
                        lastOp = op;
                        isOp = true;
                        isChangedText = false;
                    }
                }
                else
                {
                    if (operation != inNumSecDeegreBtn.Text)
                    {
                        if (this.finalLabel.Text[this.finalLabel.Text.Length - 2].ToString() == equalBtn.Text)
                        {
                            fNum = double.Parse(this.enterTextBox.Text);
                            sNum = 1;
                            historyArr.Add(this.finalLabel.Text + this.enterTextBox.Text + "\n");
                            this.finalLabel.Text = this.enterTextBox.Text + " " + operation + " ";
                            lastOp = op;
                            isChangedText = false;
                        }
                        else
                        {

                            this.finalLabel.Text = ChangeText(operation, this.finalLabel.Text);
                            lastOp = op;
                            isChangedText = false;
                        }
                    }
                    else
                    {
                        if (this.finalLabel.Text[this.finalLabel.Text.Length - 2].ToString() == equalBtn.Text && lastOp != null)
                        {
                            this.finalLabel.Text = "";
                            sNum = double.Parse(this.enterTextBox.Text);
                            this.finalLabel.Text += this.enterTextBox.Text + " ^ 2 " + equalBtn.Text + " ";
                            this.enterTextBox.Text = lastOp(sNum, 2);
                            fNum = double.Parse(this.enterTextBox.Text);
                            isChangedText = false;
                            lastOp = null;
                            isOp = true;
                        }
                    }
                }
            }
            else
            {

                historyArr.Add(this.finalLabel.Text + this.enterTextBox.Text + "\n"); this.finalLabel.Text = lastOp(fNum, sNum) + " " + operation + " ";
                this.enterTextBox.Text = lastOp(fNum, sNum);
                fNum = double.Parse(lastOp(fNum, sNum));
                lastOp = op;
                isOp = true;
                isChangedText = false;
            }
        }

        private void Operations(object button, EventArgs e)
        {
            string buttonText = ((Button)button).Text;
            Calculator calculator = new Calculator();
            if (buttonText == plusBtn.Text)
            {
                Operation(buttonText, calculator.Plus);
            }
            else if (buttonText == minusBtn.Text)
            {
                Operation(buttonText, calculator.Minus);
            }
            else if (buttonText == multiplyBtn.Text)
            {
                Operation(buttonText, calculator.Multiply);
            }
            else if (buttonText == devideBtn.Text)
            {
                Operation(buttonText, calculator.Devide);
            }
            else if (buttonText == equalBtn.Text)
            {
                Operation(buttonText, lastOp);
            }
            else if (buttonText == inNumSecDeegreBtn.Text)
            {
                Operation(buttonText, calculator.SecondDeegre);
            }
            else if (buttonText == inNumAnyDeegreBtn.Text)
            {
                Operation(buttonText, calculator.AnyDeegre);
            }
            else if (buttonText == inNumSecRootBtn.Text)
            {
                Operation(buttonText, calculator.SecondRoot);
            }
            else if (buttonText == inNumAnyRootBtn.Text)
            {
                Operation(buttonText, calculator.AnyRoot);
            }
        }
        public void Clear(object button, EventArgs e)
        {
            string buttonText = ((Button)button).Text;
            if (!String.IsNullOrWhiteSpace(this.finalLabel.Text))
            {
                if (buttonText == clearAllBtn.Text ||
                   (buttonText == clearEntryBtn.Text &&
                   this.finalLabel.Text[this.finalLabel.Text.Length - 2].ToString()
                   == equalBtn.Text))
                {
                    fNum = 0;
                    sNum = 1;
                    this.finalLabel.Text = "";
                    this.enterTextBox.Text = "0";
                    lastOp = null;
                }
                else if (buttonText == clearEntryBtn.Text)
                {
                    sNum = 1;
                    this.enterTextBox.Text = "0";
                }
                else if (buttonText == removeBtn.Text)
                {
                    if (isChangedText)
                    {
                        string tempStr = null;
                        for (int i = 0; i < this.enterTextBox.Text.Length - 1; i++)
                        {
                            tempStr += this.enterTextBox.Text[i].ToString();
                        }
                        if (tempStr == null)
                        {
                            this.enterTextBox.Text = "0";
                        }
                        else
                        {
                            this.enterTextBox.Text = tempStr;
                        }
                    }
                    else
                    {
                        if (!String.IsNullOrWhiteSpace(this.finalLabel.Text))
                        {
                            if (this.finalLabel.Text[this.finalLabel.Text.Length - 2].ToString() == equalBtn.Text)
                            {
                                this.finalLabel.Text = "";
                            }
                        }
                        else
                        {
                            string tempStr = null;
                            for (int i = 0; i < this.enterTextBox.Text.Length - 1; i++)
                            {
                                tempStr += this.enterTextBox.Text[i].ToString();
                            }
                            if (tempStr == null)
                            {
                                this.enterTextBox.Text = "0";
                            }
                            else
                            {
                                this.enterTextBox.Text = tempStr;
                            }
                        }
                    }
                }
            }
            else if (buttonText == clearEntryBtn.Text)
            {
                sNum = 1;
                this.enterTextBox.Text = "0";
            }
            else if (buttonText == removeBtn.Text)
            {
                if (isChangedText)
                {
                    string tempStr = null;
                    for (int i = 0; i < this.enterTextBox.Text.Length - 1; i++)
                    {
                        tempStr += this.enterTextBox.Text[i].ToString();
                    }
                    if (tempStr == null)
                    {
                        this.enterTextBox.Text = "0";
                    }
                    else
                    {
                        this.enterTextBox.Text = tempStr;
                    }
                }
                else
                {
                    if (!String.IsNullOrWhiteSpace(this.finalLabel.Text))
                    {
                        if (this.finalLabel.Text[this.finalLabel.Text.Length - 2].ToString() == equalBtn.Text)
                        {
                            this.finalLabel.Text = "";
                        }
                    }
                    else
                    {
                        string tempStr = null;
                        for (int i = 0; i < this.enterTextBox.Text.Length - 1; i++)
                        {
                            tempStr += this.enterTextBox.Text[i].ToString();
                        }
                        if (tempStr == null)
                        {
                            this.enterTextBox.Text = "0";
                        }
                        else
                        {
                            this.enterTextBox.Text = tempStr;
                        }
                    }
                }
            }
        }

        public void ShowHistory(object button, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm();
            if (historyArr.Count <= 18)
            {
                for (int i = historyArr.Count - 1; i >= 0; i--)
                {
                    historyForm.historyLabel.Text += historyArr[i];
                }
            }
            else
            {
                for (int i = historyArr.Count - 1; i >= historyArr.Count - 17; i--)
                {
                    historyForm.historyLabel.Text += historyArr[i];
                }
            }
            historyForm.Show();
        }

    }
}