
namespace CalculatorViaWinForm
{
    partial class CalculatorWinForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.removeBtn = new System.Windows.Forms.Button();
            this.equalBtn = new System.Windows.Forms.Button();
            this.minusBtn = new System.Windows.Forms.Button();
            this.dotBtn = new System.Windows.Forms.Button();
            this.zeroBtn = new System.Windows.Forms.Button();
            this.plusBtn = new System.Windows.Forms.Button();
            this.nineBtn = new System.Windows.Forms.Button();
            this.eightBtn = new System.Windows.Forms.Button();
            this.sevenBtn = new System.Windows.Forms.Button();
            this.clearAllBtn = new System.Windows.Forms.Button();
            this.multiplyBtn = new System.Windows.Forms.Button();
            this.sixBtn = new System.Windows.Forms.Button();
            this.fiveBtn = new System.Windows.Forms.Button();
            this.fourBtn = new System.Windows.Forms.Button();
            this.clearEntryBtn = new System.Windows.Forms.Button();
            this.devideBtn = new System.Windows.Forms.Button();
            this.threeBtn = new System.Windows.Forms.Button();
            this.twoBtn = new System.Windows.Forms.Button();
            this.oneBtn = new System.Windows.Forms.Button();
            this.enterTextBox = new System.Windows.Forms.TextBox();
            this.finalLabel = new System.Windows.Forms.Label();
            this.historyBtn = new System.Windows.Forms.Button();
            this.inNumSecDeegreBtn = new System.Windows.Forms.Button();
            this.inNumAnyDeegreBtn = new System.Windows.Forms.Button();
            this.inNumSecRootBtn = new System.Windows.Forms.Button();
            this.inNumAnyRootBtn = new System.Windows.Forms.Button();
            this.buttonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.inNumSecDeegreBtn);
            this.buttonsPanel.Controls.Add(this.inNumAnyDeegreBtn);
            this.buttonsPanel.Controls.Add(this.inNumSecRootBtn);
            this.buttonsPanel.Controls.Add(this.inNumAnyRootBtn);
            this.buttonsPanel.Controls.Add(this.historyBtn);
            this.buttonsPanel.Controls.Add(this.removeBtn);
            this.buttonsPanel.Controls.Add(this.equalBtn);
            this.buttonsPanel.Controls.Add(this.minusBtn);
            this.buttonsPanel.Controls.Add(this.dotBtn);
            this.buttonsPanel.Controls.Add(this.zeroBtn);
            this.buttonsPanel.Controls.Add(this.plusBtn);
            this.buttonsPanel.Controls.Add(this.nineBtn);
            this.buttonsPanel.Controls.Add(this.eightBtn);
            this.buttonsPanel.Controls.Add(this.sevenBtn);
            this.buttonsPanel.Controls.Add(this.clearAllBtn);
            this.buttonsPanel.Controls.Add(this.multiplyBtn);
            this.buttonsPanel.Controls.Add(this.sixBtn);
            this.buttonsPanel.Controls.Add(this.fiveBtn);
            this.buttonsPanel.Controls.Add(this.fourBtn);
            this.buttonsPanel.Controls.Add(this.clearEntryBtn);
            this.buttonsPanel.Controls.Add(this.devideBtn);
            this.buttonsPanel.Controls.Add(this.threeBtn);
            this.buttonsPanel.Controls.Add(this.twoBtn);
            this.buttonsPanel.Controls.Add(this.oneBtn);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonsPanel.Location = new System.Drawing.Point(0, 123);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(518, 139);
            this.buttonsPanel.TabIndex = 0;
            // 
            // removeBtn
            // 
            this.removeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.Location = new System.Drawing.Point(369, 0);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(76, 37);
            this.removeBtn.TabIndex = 18;
            this.removeBtn.Text = "<-";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.Clear);
            // 
            // equalBtn
            // 
            this.equalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalBtn.Location = new System.Drawing.Point(369, 101);
            this.equalBtn.Name = "equalBtn";
            this.equalBtn.Size = new System.Drawing.Size(76, 37);
            this.equalBtn.TabIndex = 17;
            this.equalBtn.Text = "=";
            this.equalBtn.UseVisualStyleBackColor = true;
            this.equalBtn.Click += new System.EventHandler(this.Operations);
            // 
            // minusBtn
            // 
            this.minusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusBtn.Location = new System.Drawing.Point(221, 101);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(76, 37);
            this.minusBtn.TabIndex = 16;
            this.minusBtn.Text = "-";
            this.minusBtn.UseVisualStyleBackColor = true;
            this.minusBtn.Click += new System.EventHandler(this.Operations);
            // 
            // dotBtn
            // 
            this.dotBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dotBtn.Location = new System.Drawing.Point(147, 101);
            this.dotBtn.Name = "dotBtn";
            this.dotBtn.Size = new System.Drawing.Size(76, 37);
            this.dotBtn.TabIndex = 15;
            this.dotBtn.Text = ".";
            this.dotBtn.UseVisualStyleBackColor = true;
            this.dotBtn.Click += new System.EventHandler(this.InputNumber);
            // 
            // zeroBtn
            // 
            this.zeroBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroBtn.Location = new System.Drawing.Point(0, 99);
            this.zeroBtn.Name = "zeroBtn";
            this.zeroBtn.Size = new System.Drawing.Size(149, 37);
            this.zeroBtn.TabIndex = 14;
            this.zeroBtn.Text = "0";
            this.zeroBtn.UseVisualStyleBackColor = true;
            this.zeroBtn.Click += new System.EventHandler(this.InputNumber);
            // 
            // plusBtn
            // 
            this.plusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusBtn.Location = new System.Drawing.Point(221, 68);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(76, 37);
            this.plusBtn.TabIndex = 13;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = true;
            this.plusBtn.Click += new System.EventHandler(this.Operations);
            // 
            // nineBtn
            // 
            this.nineBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nineBtn.Location = new System.Drawing.Point(147, 0);
            this.nineBtn.Name = "nineBtn";
            this.nineBtn.Size = new System.Drawing.Size(76, 37);
            this.nineBtn.TabIndex = 12;
            this.nineBtn.Text = "9";
            this.nineBtn.UseVisualStyleBackColor = true;
            this.nineBtn.Click += new System.EventHandler(this.InputNumber);
            // 
            // eightBtn
            // 
            this.eightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eightBtn.Location = new System.Drawing.Point(73, 0);
            this.eightBtn.Name = "eightBtn";
            this.eightBtn.Size = new System.Drawing.Size(76, 37);
            this.eightBtn.TabIndex = 11;
            this.eightBtn.Text = "8";
            this.eightBtn.UseVisualStyleBackColor = true;
            this.eightBtn.Click += new System.EventHandler(this.InputNumber);
            // 
            // sevenBtn
            // 
            this.sevenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sevenBtn.Location = new System.Drawing.Point(0, 0);
            this.sevenBtn.Name = "sevenBtn";
            this.sevenBtn.Size = new System.Drawing.Size(76, 37);
            this.sevenBtn.TabIndex = 10;
            this.sevenBtn.Text = "7";
            this.sevenBtn.UseVisualStyleBackColor = true;
            this.sevenBtn.Click += new System.EventHandler(this.InputNumber);
            // 
            // clearAllBtn
            // 
            this.clearAllBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearAllBtn.Location = new System.Drawing.Point(369, 68);
            this.clearAllBtn.Name = "clearAllBtn";
            this.clearAllBtn.Size = new System.Drawing.Size(76, 37);
            this.clearAllBtn.TabIndex = 9;
            this.clearAllBtn.Text = "C";
            this.clearAllBtn.UseVisualStyleBackColor = true;
            this.clearAllBtn.Click += new System.EventHandler(this.Clear);
            // 
            // multiplyBtn
            // 
            this.multiplyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplyBtn.Location = new System.Drawing.Point(221, 34);
            this.multiplyBtn.Name = "multiplyBtn";
            this.multiplyBtn.Size = new System.Drawing.Size(76, 37);
            this.multiplyBtn.TabIndex = 8;
            this.multiplyBtn.Text = "X";
            this.multiplyBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.multiplyBtn.UseVisualStyleBackColor = true;
            this.multiplyBtn.Click += new System.EventHandler(this.Operations);
            // 
            // sixBtn
            // 
            this.sixBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixBtn.Location = new System.Drawing.Point(148, 34);
            this.sixBtn.Name = "sixBtn";
            this.sixBtn.Size = new System.Drawing.Size(76, 37);
            this.sixBtn.TabIndex = 7;
            this.sixBtn.Text = "6";
            this.sixBtn.UseVisualStyleBackColor = true;
            this.sixBtn.Click += new System.EventHandler(this.InputNumber);
            // 
            // fiveBtn
            // 
            this.fiveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveBtn.Location = new System.Drawing.Point(73, 34);
            this.fiveBtn.Name = "fiveBtn";
            this.fiveBtn.Size = new System.Drawing.Size(76, 37);
            this.fiveBtn.TabIndex = 6;
            this.fiveBtn.Text = "5";
            this.fiveBtn.UseVisualStyleBackColor = true;
            this.fiveBtn.Click += new System.EventHandler(this.InputNumber);
            // 
            // fourBtn
            // 
            this.fourBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourBtn.Location = new System.Drawing.Point(0, 34);
            this.fourBtn.Name = "fourBtn";
            this.fourBtn.Size = new System.Drawing.Size(76, 37);
            this.fourBtn.TabIndex = 5;
            this.fourBtn.Text = "4";
            this.fourBtn.UseVisualStyleBackColor = true;
            this.fourBtn.Click += new System.EventHandler(this.InputNumber);
            // 
            // clearEntryBtn
            // 
            this.clearEntryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearEntryBtn.Location = new System.Drawing.Point(369, 34);
            this.clearEntryBtn.Name = "clearEntryBtn";
            this.clearEntryBtn.Size = new System.Drawing.Size(76, 37);
            this.clearEntryBtn.TabIndex = 4;
            this.clearEntryBtn.Text = "CE";
            this.clearEntryBtn.UseVisualStyleBackColor = true;
            this.clearEntryBtn.Click += new System.EventHandler(this.Clear);
            // 
            // devideBtn
            // 
            this.devideBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devideBtn.Location = new System.Drawing.Point(221, 0);
            this.devideBtn.Name = "devideBtn";
            this.devideBtn.Size = new System.Drawing.Size(76, 37);
            this.devideBtn.TabIndex = 3;
            this.devideBtn.Text = "/";
            this.devideBtn.UseVisualStyleBackColor = true;
            this.devideBtn.Click += new System.EventHandler(this.Operations);
            // 
            // threeBtn
            // 
            this.threeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeBtn.Location = new System.Drawing.Point(146, 68);
            this.threeBtn.Name = "threeBtn";
            this.threeBtn.Size = new System.Drawing.Size(77, 37);
            this.threeBtn.TabIndex = 2;
            this.threeBtn.Text = "3";
            this.threeBtn.UseVisualStyleBackColor = true;
            this.threeBtn.Click += new System.EventHandler(this.InputNumber);
            // 
            // twoBtn
            // 
            this.twoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoBtn.Location = new System.Drawing.Point(73, 68);
            this.twoBtn.Name = "twoBtn";
            this.twoBtn.Size = new System.Drawing.Size(76, 37);
            this.twoBtn.TabIndex = 1;
            this.twoBtn.Text = "2";
            this.twoBtn.UseVisualStyleBackColor = true;
            this.twoBtn.Click += new System.EventHandler(this.InputNumber);
            // 
            // oneBtn
            // 
            this.oneBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneBtn.Location = new System.Drawing.Point(0, 68);
            this.oneBtn.Name = "oneBtn";
            this.oneBtn.Size = new System.Drawing.Size(76, 37);
            this.oneBtn.TabIndex = 0;
            this.oneBtn.Text = "1";
            this.oneBtn.UseVisualStyleBackColor = true;
            this.oneBtn.Click += new System.EventHandler(this.InputNumber);
            // 
            // enterTextBox
            // 
            this.enterTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.enterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterTextBox.Location = new System.Drawing.Point(0, 61);
            this.enterTextBox.Multiline = true;
            this.enterTextBox.Name = "enterTextBox";
            this.enterTextBox.Size = new System.Drawing.Size(518, 62);
            this.enterTextBox.TabIndex = 1;
            this.enterTextBox.Text = "0";
            this.enterTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.enterTextBox.TextChanged += new System.EventHandler(this.IsTextChage);
            this.enterTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DontTypeTextBox);
            // 
            // finalLabel
            // 
            this.finalLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.finalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalLabel.Location = new System.Drawing.Point(0, 0);
            this.finalLabel.Name = "finalLabel";
            this.finalLabel.Size = new System.Drawing.Size(518, 61);
            this.finalLabel.TabIndex = 2;
            this.finalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // historyBtn
            // 
            this.historyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyBtn.Location = new System.Drawing.Point(442, 0);
            this.historyBtn.Name = "historyBtn";
            this.historyBtn.Size = new System.Drawing.Size(76, 136);
            this.historyBtn.TabIndex = 19;
            this.historyBtn.Text = "History";
            this.historyBtn.UseVisualStyleBackColor = true;
            this.historyBtn.Click += new System.EventHandler(this.ShowHistory);
            // 
            // inNumSecDeegreBtn
            // 
            this.inNumSecDeegreBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inNumSecDeegreBtn.Location = new System.Drawing.Point(295, 100);
            this.inNumSecDeegreBtn.Name = "inNumSecDeegreBtn";
            this.inNumSecDeegreBtn.Size = new System.Drawing.Size(76, 37);
            this.inNumSecDeegreBtn.TabIndex = 23;
            this.inNumSecDeegreBtn.Text = "x^2";
            this.inNumSecDeegreBtn.UseVisualStyleBackColor = true;
            this.inNumSecDeegreBtn.Click += new System.EventHandler(this.Operations);
            // 
            // inNumAnyDeegreBtn
            // 
            this.inNumAnyDeegreBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inNumAnyDeegreBtn.Location = new System.Drawing.Point(295, 67);
            this.inNumAnyDeegreBtn.Name = "inNumAnyDeegreBtn";
            this.inNumAnyDeegreBtn.Size = new System.Drawing.Size(76, 37);
            this.inNumAnyDeegreBtn.TabIndex = 22;
            this.inNumAnyDeegreBtn.Text = "x^y";
            this.inNumAnyDeegreBtn.UseVisualStyleBackColor = true;
            // 
            // inNumSecRootBtn
            // 
            this.inNumSecRootBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inNumSecRootBtn.Location = new System.Drawing.Point(295, 33);
            this.inNumSecRootBtn.Name = "inNumSecRootBtn";
            this.inNumSecRootBtn.Size = new System.Drawing.Size(76, 37);
            this.inNumSecRootBtn.TabIndex = 21;
            this.inNumSecRootBtn.Text = "√x";
            this.inNumSecRootBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.inNumSecRootBtn.UseVisualStyleBackColor = true;
            // 
            // inNumAnyRootBtn
            // 
            this.inNumAnyRootBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inNumAnyRootBtn.Location = new System.Drawing.Point(295, -1);
            this.inNumAnyRootBtn.Name = "inNumAnyRootBtn";
            this.inNumAnyRootBtn.Size = new System.Drawing.Size(76, 37);
            this.inNumAnyRootBtn.TabIndex = 20;
            this.inNumAnyRootBtn.Text = "y√x";
            this.inNumAnyRootBtn.UseVisualStyleBackColor = true;
            // 
            // CalculatorWinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 262);
            this.Controls.Add(this.finalLabel);
            this.Controls.Add(this.enterTextBox);
            this.Controls.Add(this.buttonsPanel);
            this.MaximizeBox = false;
            this.Name = "CalculatorWinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.buttonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Button equalBtn;
        private System.Windows.Forms.Button minusBtn;
        private System.Windows.Forms.Button dotBtn;
        private System.Windows.Forms.Button zeroBtn;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Button nineBtn;
        private System.Windows.Forms.Button eightBtn;
        private System.Windows.Forms.Button sevenBtn;
        private System.Windows.Forms.Button clearAllBtn;
        private System.Windows.Forms.Button multiplyBtn;
        private System.Windows.Forms.Button sixBtn;
        private System.Windows.Forms.Button fiveBtn;
        private System.Windows.Forms.Button fourBtn;
        private System.Windows.Forms.Button clearEntryBtn;
        private System.Windows.Forms.Button devideBtn;
        private System.Windows.Forms.Button threeBtn;
        private System.Windows.Forms.Button twoBtn;
        private System.Windows.Forms.Button oneBtn;
        private System.Windows.Forms.TextBox enterTextBox;
        private System.Windows.Forms.Label finalLabel;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button historyBtn;
        private System.Windows.Forms.Button inNumSecDeegreBtn;
        private System.Windows.Forms.Button inNumAnyDeegreBtn;
        private System.Windows.Forms.Button inNumSecRootBtn;
        private System.Windows.Forms.Button inNumAnyRootBtn;
    }
}

