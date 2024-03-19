using Microsoft.CSharp.RuntimeBinder;

namespace HelloCSharpWin
{
    public enum Operators { Add, Sub, Multi, Div }

    public partial class Calculator : Form
    {
        public int Result = 0;
        public bool isNewNum = true;
        public Operators Opt = Operators.Add;

        public Calculator()
        {
            InitializeComponent();

        }

        public void SetNum(string num)
        {
            if (isNewNum)
            {
                NumScreen.Text = num;
                isNewNum = false;
            }
            else
            {
                if (NumScreen.Text == "0")
                {
                    NumScreen.Text = num;
                }
                else
                {
                    NumScreen.Text = NumScreen.Text + num;
                }
            }
        }
        private void NumClear_Click(object sender, EventArgs e)
        {
            Result = 0;
            isNewNum = true;
            Opt = Operators.Add;

            NumScreen.Text = "0";
        }
        private void NumButton_Click(object sender, EventArgs e)
        {
            Button numButton = (Button)sender;
            SetNum(numButton.Text);
        }

        private void Operation_Click(object sender, EventArgs e)
        {

            if (isNewNum == false)
            {
                int num = int.Parse(NumScreen.Text);

                if (Opt == Operators.Add)
                    Result = Result + num;

                else if (Opt == Operators.Sub)
                    Result = Result - num;

                else if (Opt == Operators.Multi)
                {
                    if (Result == 0)
                    {
                        Result = num;
                    }
                    else if (Result != 0)
                        Result = Result * num;
                }

                else if (Opt == Operators.Div)
                    if (num == 0)
                        Result = 0;
                    else if (num != 0)
                    {
                        if (Result != 0)
                            Result = Result / num;
                        else if (Result == 0)
                            Result = num;
                    }

                NumScreen.Text = Result.ToString();
                isNewNum = true;
            }

            Button optButton = (Button)sender;
            if (optButton.Text == "+")
                Opt = Operators.Add;
            else if (optButton.Text == "-")
                Opt = Operators.Sub;
            else if (optButton.Text == "*")
                Opt = Operators.Multi;
            else if (optButton.Text == "/")
                Opt = Operators.Div;
        }
    }

}
