namespace Assignment_4._1._2
{
    public partial class Form1 : Form
    {
        private ICalculator calculator;
        public Form1()
        {
            InitializeComponent();
            calculator = new SimpleCalculator();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtboxFirstNumber.Focus();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtboxFirstNumber.Text);
            double num2 = Convert.ToDouble(txtboxSecondNumber.Text);
            double result = calculator.Add(num1, num2);
            txtboxResult.Text = result.ToString("0.00");
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtboxFirstNumber.Text);
            double num2 = Convert.ToDouble(txtboxSecondNumber.Text);
            double result = calculator.Subtract(num1, num2);
            txtboxResult.Text = result.ToString("0.00");
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtboxFirstNumber.Text);
            double num2 = Convert.ToDouble(txtboxSecondNumber.Text);
            double result = calculator.Multiply(num1, num2);
            txtboxResult.Text = result.ToString("0.00");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtboxFirstNumber.Text);
            double num2 = Convert.ToDouble(txtboxSecondNumber.Text);
            try
            {
                double result = calculator.Divide(num1, num2);
                txtboxResult.Text = result.ToString("0.00");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Division Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtboxFirstNumber.Clear();
            txtboxSecondNumber.Clear();
            txtboxResult.Clear();
            txtboxFirstNumber.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", 
                "Confirm Exit", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
    public interface ICalculator
    {
        double Add(double a, double b);
        double Subtract(double a, double b);
        double Multiply(double a, double b);
        double Divide(double a, double b);
    }
    public class SimpleCalculator : ICalculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
                throw new ArgumentException("Denominator cannot be zero.");
            return a / b;
        }
    }
}
