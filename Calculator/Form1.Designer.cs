namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox = new TextBox();
            zero = new Button();
            one = new Button();
            two = new Button();
            three = new Button();
            four = new Button();
            five = new Button();
            six = new Button();
            seven = new Button();
            eight = new Button();
            nine = new Button();
            clearBtn = new Button();
            dotBtn = new Button();
            addBtn = new Button();
            subtractionBtn = new Button();
            multiplBtn = new Button();
            divisionBtn = new Button();
            equalBtn = new Button();
            historyLabel = new Label();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.BackColor = SystemColors.ControlLightLight;
            textBox.Font = new Font("Segoe UI", 15F);
            textBox.ForeColor = Color.Orange;
            textBox.Location = new Point(12, 23);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Size = new Size(321, 140);
            textBox.TabIndex = 0;
            textBox.TextAlign = HorizontalAlignment.Right;
            textBox.TextChanged += textBox1_TextChanged;
            // 
            // zero
            // 
            zero.BackColor = Color.Orange;
            zero.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            zero.Location = new Point(12, 436);
            zero.Name = "zero";
            zero.Size = new Size(125, 42);
            zero.TabIndex = 1;
            zero.Text = "0";
            zero.UseVisualStyleBackColor = false;
            zero.Click += button1_Click;
            // 
            // one
            // 
            one.BackColor = Color.Orange;
            one.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            one.Location = new Point(12, 383);
            one.Name = "one";
            one.Size = new Size(65, 47);
            one.TabIndex = 2;
            one.Text = "1";
            one.UseVisualStyleBackColor = false;
            one.Click += one_Click;
            // 
            // two
            // 
            two.BackColor = Color.Orange;
            two.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            two.Location = new Point(83, 383);
            two.Name = "two";
            two.Size = new Size(65, 47);
            two.TabIndex = 3;
            two.Text = "2";
            two.UseVisualStyleBackColor = false;
            two.Click += two_Click;
            // 
            // three
            // 
            three.BackColor = Color.Orange;
            three.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            three.Location = new Point(154, 383);
            three.Name = "three";
            three.Size = new Size(65, 47);
            three.TabIndex = 4;
            three.Text = "3";
            three.UseVisualStyleBackColor = false;
            three.Click += three_Click;
            // 
            // four
            // 
            four.BackColor = Color.Orange;
            four.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            four.Location = new Point(12, 330);
            four.Name = "four";
            four.Size = new Size(65, 47);
            four.TabIndex = 5;
            four.Text = "4";
            four.UseVisualStyleBackColor = false;
            four.Click += four_Click;
            // 
            // five
            // 
            five.BackColor = Color.Orange;
            five.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            five.Location = new Point(83, 330);
            five.Name = "five";
            five.Size = new Size(65, 47);
            five.TabIndex = 6;
            five.Text = "5";
            five.UseVisualStyleBackColor = false;
            five.Click += five_Click;
            // 
            // six
            // 
            six.BackColor = Color.Orange;
            six.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            six.Location = new Point(154, 330);
            six.Name = "six";
            six.Size = new Size(65, 47);
            six.TabIndex = 7;
            six.Text = "6";
            six.UseVisualStyleBackColor = false;
            six.Click += six_Click;
            // 
            // seven
            // 
            seven.BackColor = Color.Orange;
            seven.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            seven.Location = new Point(12, 277);
            seven.Name = "seven";
            seven.Size = new Size(65, 47);
            seven.TabIndex = 8;
            seven.Text = "7";
            seven.UseVisualStyleBackColor = false;
            seven.Click += seven_Click;
            // 
            // eight
            // 
            eight.BackColor = Color.Orange;
            eight.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            eight.Location = new Point(83, 277);
            eight.Name = "eight";
            eight.Size = new Size(65, 47);
            eight.TabIndex = 9;
            eight.Text = "8";
            eight.UseVisualStyleBackColor = false;
            eight.Click += eight_Click;
            // 
            // nine
            // 
            nine.BackColor = Color.Orange;
            nine.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nine.Location = new Point(154, 277);
            nine.Name = "nine";
            nine.Size = new Size(65, 47);
            nine.TabIndex = 10;
            nine.Text = "9";
            nine.UseVisualStyleBackColor = false;
            nine.Click += nine_Click;
            // 
            // clearBtn
            // 
            clearBtn.BackColor = Color.Orange;
            clearBtn.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearBtn.Location = new Point(12, 214);
            clearBtn.Name = "clearBtn";
            clearBtn.RightToLeft = RightToLeft.No;
            clearBtn.Size = new Size(207, 57);
            clearBtn.TabIndex = 11;
            clearBtn.Text = "C";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click;
            // 
            // dotBtn
            // 
            dotBtn.BackColor = Color.Orange;
            dotBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dotBtn.Location = new Point(143, 436);
            dotBtn.Name = "dotBtn";
            dotBtn.Size = new Size(76, 42);
            dotBtn.TabIndex = 12;
            dotBtn.Text = ".";
            dotBtn.UseVisualStyleBackColor = false;
            dotBtn.Click += dotBtn_Click;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.Orange;
            addBtn.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addBtn.Location = new Point(225, 214);
            addBtn.Name = "addBtn";
            addBtn.RightToLeft = RightToLeft.No;
            addBtn.Size = new Size(108, 57);
            addBtn.TabIndex = 13;
            addBtn.Text = "+";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // subtractionBtn
            // 
            subtractionBtn.BackColor = Color.Orange;
            subtractionBtn.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subtractionBtn.Location = new Point(225, 277);
            subtractionBtn.Name = "subtractionBtn";
            subtractionBtn.RightToLeft = RightToLeft.No;
            subtractionBtn.Size = new Size(108, 47);
            subtractionBtn.TabIndex = 14;
            subtractionBtn.Text = "-";
            subtractionBtn.UseVisualStyleBackColor = false;
            subtractionBtn.Click += subtractionBtn_Click;
            // 
            // multiplBtn
            // 
            multiplBtn.BackColor = Color.Orange;
            multiplBtn.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            multiplBtn.Location = new Point(225, 332);
            multiplBtn.Name = "multiplBtn";
            multiplBtn.RightToLeft = RightToLeft.No;
            multiplBtn.Size = new Size(108, 45);
            multiplBtn.TabIndex = 15;
            multiplBtn.Text = "*";
            multiplBtn.UseVisualStyleBackColor = false;
            multiplBtn.Click += multiplBtn_Click;
            // 
            // divisionBtn
            // 
            divisionBtn.BackColor = Color.Orange;
            divisionBtn.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            divisionBtn.Location = new Point(225, 383);
            divisionBtn.Name = "divisionBtn";
            divisionBtn.RightToLeft = RightToLeft.No;
            divisionBtn.Size = new Size(108, 47);
            divisionBtn.TabIndex = 16;
            divisionBtn.Text = "/";
            divisionBtn.UseVisualStyleBackColor = false;
            divisionBtn.Click += divisionBtn_Click;
            // 
            // equalBtn
            // 
            equalBtn.BackColor = Color.Orange;
            equalBtn.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            equalBtn.Location = new Point(225, 431);
            equalBtn.Name = "equalBtn";
            equalBtn.RightToLeft = RightToLeft.No;
            equalBtn.Size = new Size(108, 47);
            equalBtn.TabIndex = 17;
            equalBtn.Text = "=";
            equalBtn.UseVisualStyleBackColor = false;
            equalBtn.Click += equalBtn_Click;
            // 
            // historyLabel
            // 
            historyLabel.BackColor = SystemColors.ActiveBorder;
            historyLabel.ForeColor = Color.Orange;
            historyLabel.Location = new Point(21, 37);
            historyLabel.Name = "historyLabel";
            historyLabel.Size = new Size(180, 21);
            historyLabel.TabIndex = 18;
            historyLabel.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(345, 492);
            Controls.Add(historyLabel);
            Controls.Add(equalBtn);
            Controls.Add(divisionBtn);
            Controls.Add(multiplBtn);
            Controls.Add(subtractionBtn);
            Controls.Add(addBtn);
            Controls.Add(dotBtn);
            Controls.Add(clearBtn);
            Controls.Add(nine);
            Controls.Add(eight);
            Controls.Add(seven);
            Controls.Add(six);
            Controls.Add(five);
            Controls.Add(four);
            Controls.Add(three);
            Controls.Add(two);
            Controls.Add(one);
            Controls.Add(zero);
            Controls.Add(textBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox;
        private Button zero;
        private Button one;
        private Button two;
        private Button three;
        private Button four;
        private Button five;
        private Button six;
        private Button seven;
        private Button eight;
        private Button nine;
        private Button clearBtn;
        private Button dotBtn;
        private Button addBtn;
        private Button subtractionBtn;
        private Button multiplBtn;
        private Button divisionBtn;
        private Button equalBtn;
        private Label historyLabel;
    }
}
