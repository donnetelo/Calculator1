using System.Xml.XPath;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string storage;
        int option;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox.Text += "0";
            historyLabel.Text += "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void one_Click(object sender, EventArgs e)
        {
            textBox.Text += "1";
            historyLabel.Text += "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            textBox.Text += "2";
            historyLabel.Text += "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            textBox.Text += "3";
            historyLabel.Text += "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            textBox.Text += "4";    
            historyLabel.Text += "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            textBox.Text += "5";
            historyLabel.Text += "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            textBox.Text += "6";
            historyLabel.Text += "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            textBox.Text += "7";
            historyLabel.Text += "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            textBox.Text += "8";
            historyLabel.Text += "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            textBox.Text += "9";
            historyLabel.Text += "9";
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            historyLabel.Text = "";
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            storage = textBox.Text;
            option = 1;
            textBox.Text = string.Empty;
            historyLabel.Text += "+";
        }

        private void subtractionBtn_Click(object sender, EventArgs e)
        {
            storage = textBox.Text;
            option = 2;
            textBox.Text = string.Empty;
            historyLabel.Text += "-";
        }

        private void multiplBtn_Click(object sender, EventArgs e)
        {
            storage = textBox.Text;
            option = 3;
            textBox.Text = string.Empty;
            historyLabel.Text += "*";
        }

        private void divisionBtn_Click(object sender, EventArgs e)
        {
            storage = textBox.Text;
            option = 4;
            textBox.Text = string.Empty;
            historyLabel.Text += "/";
        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            switch (option)
            {
                case 1:
                    textBox.Text = (Convert.ToDouble(storage) + Convert.ToDouble(textBox.Text)).ToString();
                    break;
                case 2:
                    textBox.Text = (Convert.ToDouble(storage) - Convert.ToDouble(textBox.Text)).ToString();
                    break;
                case 3:
                    textBox.Text = (Convert.ToDouble(storage) * Convert.ToDouble(textBox.Text)).ToString();
                    break;
                case 4:
                    textBox.Text = (Convert.ToDouble(storage) / Convert.ToDouble(textBox.Text)).ToString();
                    break;
            }
            historyLabel.Text += "=" + textBox.Text;
        }

        private void dotBtn_Click(object sender, EventArgs e)
        {
            textBox.Text += ".";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


