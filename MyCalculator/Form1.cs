using System.Threading.Tasks;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int num1, num2, result;
        List<int> nums = new();
        List<String> options = new();
        string option;

        private void btn1_Click(object sender, EventArgs e)
        {
            txtTotal.Text += 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtTotal.Text += 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtTotal.Text += 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtTotal.Text += 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtTotal.Text += 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtTotal.Text += 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtTotal.Text += 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtTotal.Text += 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtTotal.Text += 9;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtTotal.Text += 0;
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = txtTotal.Text != String.Empty ? int.Parse(txtTotal.Text) : 0;
            txtTotal.Clear();
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = txtTotal.Text != String.Empty ? int.Parse(txtTotal.Text) : 0;
            txtTotal.Clear();
        }

        private void multiplyBtn_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = txtTotal.Text != String.Empty ? int.Parse(txtTotal.Text) : 0;
            txtTotal.Clear();
        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = txtTotal.Text != String.Empty ? int.Parse(txtTotal.Text) : 0;
            txtTotal.Clear();

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            txtTotal.Text = String.Empty;
        }

        private void equalsBtn_Click(object sender, EventArgs e)
        {
            num2 = txtTotal.Text != String.Empty ? int.Parse(txtTotal.Text) : 0;
            if (option.Equals("+")) { result = num1 + num2; }
            if (option.Equals("-")) { result = num1 - num2; }
            if (option.Equals("*")) { result = num1 * num2; }
            if (option.Equals("/")) { result = num1 / num2; }
            Console.WriteLine(int.MaxValue);
            txtTotal.Clear();
            txtTotal.Text += result;
        }
    }
}
