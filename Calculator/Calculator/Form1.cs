namespace Calculator
{
    public partial class Form1 : Form
    {

        public Number access = new Number();
        public Numbers add = new Numbers();
        public Form1()
        {
            InitializeComponent();
        }

        private void Multiply(object sender, EventArgs e)
        {
            Display.Text += "x";
        }

        private void Eight(object sender, EventArgs e)
        {
            Display.Text += "8";
            access.number = 8;

            add.numbers.Add(access.number);
        }

        private void Seven(object sender, EventArgs e)
        {
            Display.Text += "7";
            access.number = 7;

            add.numbers.Add(access.number);
        }

        private void End(object sender, EventArgs e)
        {
            int result = EndTest(Display.Text);
            Display.Text = result.ToString();

        }

        public int EndTest(string displayCont)
        {
            if (displayCont.Contains("x"))
            {
                int result = add.numbers[0] * add.numbers[1];
                return result;
            }
            else if (displayCont.Contains("+"))
            {
                int result = add.numbers[0] + add.numbers[1];
                return result;
            }
            else if (displayCont.Contains("/"))
            {
                int result = add.numbers[0] / add.numbers[1];
                return result;
            }
            else if (displayCont.Contains("-"))
            {
                int result = add.numbers[0] - add.numbers[1];
                return result;
            }
            else
            {
                return 0;
            }

        }

        private void Nine(object sender, EventArgs e)
        {
            Display.Text += "9";
            access.number = 9;
        }

        private void Four(object sender, EventArgs e)
        {
            Display.Text += "4";
            access.number = 4;
        }

        private void Five(object sender, EventArgs e)
        {
            Display.Text += "5";
            access.number = 5;
        }

        private void Six(object sender, EventArgs e)
        {
            Display.Text += "6";
            access.number = 6;
        }

        private void One(object sender, EventArgs e)
        {
            Display.Text += "1";
            access.number = 1;
        }

        private void Two(object sender, EventArgs e)
        {
            Display.Text += "2";
            access.number = 2;
        }

        private void Three(object sender, EventArgs e)
        {
            Display.Text += "3";
            access.number = 3;
        }

        private void Zero(object sender, EventArgs e)
        {
            Display.Text += "0";
            access.number = 0;
        }

        private void Dote(object sender, EventArgs e)
        {

        }

        private void Addition(object sender, EventArgs e)
        {
            Display.Text += "+";
        }

        private void Subtarction(object sender, EventArgs e)
        {
            Display.Text += "-";
        }

        private void Division(object sender, EventArgs e)
        {
            Display.Text += "/";
        }

        private void DeleteLast(object sender, EventArgs e)
        {

        }

        private void DeleteAll(object sender, EventArgs e)
        {
            access.number = 0;
            add.numbers.Clear();

            Display.Text = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
