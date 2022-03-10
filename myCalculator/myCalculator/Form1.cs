namespace myCalculator
{
    public partial class Form1 : Form
    {
        bool firstInput = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            if (firstInput)
            {
                inputBox.Text = "";
                firstInput = false;
            }
            inputBox.Text = inputBox.Text + "9";
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            if (firstInput)
            {
                inputBox.Text = "";
                firstInput = false;
            }
            inputBox.Text = inputBox.Text + "8";

        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            if (firstInput)
            {
                inputBox.Text = "";
                firstInput = false;
            }
            inputBox.Text = inputBox.Text + "7";

        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            if (firstInput)
            {
                inputBox.Text = "";
                firstInput = false;
            }
            inputBox.Text = inputBox.Text + "6";

        }
        private void fiveButton_Click(object sender, EventArgs e)
        {
            if (firstInput)
            {
                inputBox.Text = "";
                firstInput = false;
            }
            inputBox.Text = inputBox.Text + "5";
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            if (firstInput)
            {
                inputBox.Text = "";
                firstInput = false;
            }
            inputBox.Text = inputBox.Text + "4";
        }


        private void threeButton_Click(object sender, EventArgs e)
        {
            if (firstInput)
            {
                inputBox.Text = "";
                firstInput = false;
            }
            inputBox.Text = inputBox.Text + "3";

        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            if (firstInput)
            {
                inputBox.Text = "";
                firstInput = false;
            }
            inputBox.Text = inputBox.Text + "2";
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            if (firstInput)
            {
                inputBox.Text = "";
                firstInput = false;
            }
            inputBox.Text = inputBox.Text + "1";
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            if (firstInput)
            {
                inputBox.Text = "";
                firstInput = false;
            }
            inputBox.Text = inputBox.Text + "0";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void delButton_Click(object sender, EventArgs e)
        {
            if (inputBox.Text.Length != 0)
            {
                inputBox.Text = inputBox.Text.Substring(0, inputBox.Text.Length - 1);
            }
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            if (firstInput)
            {
                inputBox.Text = "";
                firstInput = false;
            }
            inputBox.Text = inputBox.Text + "*";

        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            if (firstInput)
            {
                inputBox.Text = "";
                firstInput = false;
            }
            inputBox.Text = inputBox.Text + "/";

        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            if (firstInput)
            {
                inputBox.Text = "";
                firstInput = false;
            }
            inputBox.Text = inputBox.Text + "+";

        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            if (firstInput)
            {
                inputBox.Text = "";
                firstInput = false;
            }
            inputBox.Text = inputBox.Text + "-";

        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            double answer = 90;
            string operations = inputBox.Text;
            int i = inputBox.Text.IndexOf("*");
            firstInput = true;
            inputBox.Text = getAnswer(operations);
        }

        private string getAnswer(string operations)
        {
            int mult_index = operations.IndexOf("*");
            int divide_index = operations.IndexOf('/');
            int plus_index = operations.IndexOf('+');
            int minus_index = operations.IndexOf('-');

            if (mult_index == -1 && divide_index == -1 && plus_index == -1 && minus_index == -1)
            {
                return operations;
            }
            else
            {
                string s1="";
                string s2="";
                int subIndex1=0;
                int subIndex2=0;
                if (mult_index != -1)
                {
                    
                    setInfo(ref s1,ref s2, ref subIndex1, ref subIndex2, mult_index, operations);

                    string left = s1.Substring(0, subIndex1);
                    string right = s2.Substring(subIndex2, s2.Length - subIndex2);
                    double num1 = Convert.ToDouble(operations.Substring(subIndex1, mult_index-subIndex1));
                    double num2 = Convert.ToDouble(operations.Substring(mult_index + 1, subIndex2));
                    return getAnswer(left +(num1*num2).ToString() + right );
                }
                else if (divide_index != -1) {
                    setInfo(ref s1, ref s2, ref subIndex1, ref subIndex2, divide_index, operations);

                    string left = s1.Substring(0, subIndex1);
                    string right = s2.Substring(subIndex2, s2.Length - subIndex2);
                    double num1 = Convert.ToDouble(operations.Substring(subIndex1, divide_index - subIndex1));
                    double num2 = Convert.ToDouble(operations.Substring(divide_index + 1, subIndex2));
                    return getAnswer(left + (num1 / num2).ToString() + right);
                }
                else if (plus_index != -1) {
                    setInfo(ref s1, ref s2, ref subIndex1, ref subIndex2, plus_index, operations);

                    string left = s1.Substring(0, subIndex1);
                    string right = s2.Substring(subIndex2, s2.Length - subIndex2);
                    double num1 = Convert.ToDouble(operations.Substring(subIndex1, plus_index-subIndex1));
                    double num2 = Convert.ToDouble(operations.Substring(plus_index + 1, subIndex2 ));
                    return getAnswer(left + (num1 + num2).ToString() + right);
                }
                else
                {
                    setInfo(ref s1, ref s2, ref subIndex1, ref subIndex2, minus_index, operations);

                    string left = s1.Substring(0, subIndex1);
                    string right = s2.Substring(subIndex2, s2.Length - subIndex2);
                    double num1 = Convert.ToDouble(operations.Substring(subIndex1, minus_index - subIndex1));
                    double num2 = Convert.ToDouble(operations.Substring(minus_index + 1, subIndex2));
                    return getAnswer(left + (num1 - num2).ToString() + right);
                }
            }
        }

        private void setInfo(ref string s1, ref string s2, ref int subIndex1, ref int subIndex2, int index, string operations)
        {
            
               s1 = operations.Substring(0, index);
               s2 = operations.Substring(index + 1, operations.Length - index - 1);
               subIndex1 = s1.Length - 1;
               subIndex2 = 0;
               for (int i = s1.Length - 1; i >= 0; i--)
               {
                if (s1[i] == '+' || s1[i] == '-' || s1[i] == '/' || s1[i] == '*')
                {
                    subIndex1 = i;
                    break;
                }
                else {
                    subIndex1 = i;
                }
                }

                for (int i = 0; i <= s2.Length; i++)
                {
                if (i != s2.Length)
                {
                    if (s2[i] == '+' || s2[i] == '-' || s2[i] == '/' || s2[i] == '*')
                    {
                        subIndex2 = i;
                        break;
                    }
                    else
                    {
                        subIndex2 = i;
                    }
                }
                else
                {
                    subIndex2 = i;
                }
                    
                }
            

        }
    }
}