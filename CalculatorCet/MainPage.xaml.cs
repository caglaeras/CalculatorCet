namespace CalculatorCet
{
    public partial class MainPage : ContentPage
    {



        public MainPage()
        {
            InitializeComponent();
        }


        double FirstNumber;
        bool isFirstNumberAfterOperator = true;
        Operator PreviousOperator = Operator.None;

        double memoryValue = 0;


        private void SubtractButton_Clicked(object sender, EventArgs e)
        {
            DoCalculation();
            PreviousOperator = Operator.Subtract;

        }

        private void MultiplyButton_Clicked(object sender, EventArgs e)
        {
            DoCalculation();
            PreviousOperator = Operator.Multiply;
        }

        private void DivideButton_Clicked(object sender, EventArgs e)
        {
            DoCalculation();
            PreviousOperator = Operator.Divide;

        }

        private void AddButton_Clicked(object sender, EventArgs e)
        {

            DoCalculation();
            PreviousOperator = Operator.Add;

        }
        private void EqualButton_Clicked(object sender, EventArgs e)
        {

            DoCalculation();
            PreviousOperator = Operator.None;

        }

        void DoCalculation()
        {

            switch (PreviousOperator)
            {
                case Operator.None:
                    FirstNumber = Double.Parse(Display.Text);
                    break;
                case Operator.Add:
                    FirstNumber = FirstNumber + Double.Parse(Display.Text);
                    break;
                case Operator.Subtract:
                    FirstNumber = FirstNumber - Double.Parse(Display.Text);

                    break;
                case Operator.Multiply:
                    FirstNumber = FirstNumber * Double.Parse(Display.Text);

                    break;
                case Operator.Divide:
                    FirstNumber = FirstNumber / Double.Parse(Display.Text);

                    break;

            }
            isFirstNumberAfterOperator = true;
            Display.Text = FirstNumber.ToString();
        }

        private void Digit_Clicked(object sender, EventArgs e)
        {
            Button digitButton = sender as Button;
            if (isFirstNumberAfterOperator)
            {
                Display.Text = digitButton.Text;
                isFirstNumberAfterOperator = false;

            }
            else
            {
                Display.Text += digitButton.Text;
            }

        }

        private void CEButton_Clicked(object sender, EventArgs e)
        {
            Display.Text = "0";
            isFirstNumberAfterOperator = true;
        }

        private void CButton_Clicked(object sender, EventArgs e)
        {
            Display.Text = "0";
            FirstNumber = 0;
            PreviousOperator = Operator.None;
            isFirstNumberAfterOperator = true;
        }

        private void MplusButton_Clicked(object sender, EventArgs e)
        {
            if (double.TryParse(Display.Text, out double currentValue))
            {
                memoryValue += currentValue;
                Display.Text = memoryValue.ToString();
            }
        }

        private void MSButton_Clicked(object sender, EventArgs e)
        {
            if (double.TryParse(Display.Text, out double currentValue))
            {
                memoryValue = currentValue;
                Display.Text = "Stored";
            }
        }

        private void MminusButton_Clicked(object sender, EventArgs e)
        {
            if (double.TryParse(Display.Text, out double currentValue))
            {
                memoryValue -= currentValue;
                Display.Text = memoryValue.ToString();
            }
        }

        private void comaButton_Clicked(object sender, EventArgs e)
        {
            string decimalSeparator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;

            if (!Display.Text.Contains(decimalSeparator))
            {
                Display.Text += decimalSeparator;
            }
        }

        private void DeleteButton_Clicked(object sender, EventArgs e)
        {
            if (Display.Text.Length > 1)
            {
                Display.Text = Display.Text.Substring(0, Display.Text.Length - 1);
            }
            else
            {
                Display.Text = "0";
            }
        }

        private void MemoryClearButton_Clicked(object sender, EventArgs e)
        {
            memoryValue = 0;
            Display.Text = "Memory Cleared";
        }

        private void MemoryRecallButton_Clicked(object sender, EventArgs e)
        {
            Display.Text = memoryValue.ToString();
        }

        private void EqualButton_Clicked(object sender, EventArgs e)
        {
            DoCalculation();
            PreviousOperator = Operator.None;

        }

        private void CEButton_Clicked(object sender, EventArgs e)
        {
            Display.Text = "0";
            isFirstNumberAfterOperator = true;
        }

        private void CButton_Clicked(object sender, EventArgs e)
        {
            Display.Text = "0";
            FirstNumber = 0;
            PreviousOperator= Operator.None;
            isFirstNumberAfterOperator = true;
        }
    }

}