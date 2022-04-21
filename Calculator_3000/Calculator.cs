namespace Calculator_3000
{
    public partial class Calculator : Form
    {

        public Calculator()
        {
            InitializeComponent();
        }

        float FirstOperand;
        Operation operation;
        bool znak = true;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_1_Click(object sender, EventArgs e)
        {
            First_txt_Screen.Text = First_txt_Screen.Text + 1;
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            First_txt_Screen.Text = First_txt_Screen.Text + 2;
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            First_txt_Screen.Text = First_txt_Screen.Text + 3;
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            First_txt_Screen.Text = First_txt_Screen.Text + 4;
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            First_txt_Screen.Text = First_txt_Screen.Text + 5;
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            First_txt_Screen.Text = First_txt_Screen.Text + 6;
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            First_txt_Screen.Text = First_txt_Screen.Text + 7;
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            First_txt_Screen.Text = First_txt_Screen.Text + 8;
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            First_txt_Screen.Text = First_txt_Screen.Text + 9;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            First_txt_Screen.Text = First_txt_Screen.Text + 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            First_txt_Screen.Text = First_txt_Screen.Text + ",";
        }

        private void button_substract_Click(object sender, EventArgs e)
        {
            FirstOperand = float.Parse(First_txt_Screen.Text);
            First_txt_Screen.Clear();
            operation = Operation.Substract;
            Second_txt_Screen.Text = FirstOperand.ToString() + "-";
            znak = true;
        }

        private void button_multiple_Click(object sender, EventArgs e)
        {
            FirstOperand = float.Parse(First_txt_Screen.Text);
            First_txt_Screen.Clear();
            operation = Operation.Multiple;
            Second_txt_Screen.Text = FirstOperand.ToString() + "*";
            znak = true;
        }

        private void button_divide_Click(object sender, EventArgs e)
        {
            FirstOperand = float.Parse(First_txt_Screen.Text);
            First_txt_Screen.Clear();
            operation = Operation.Divide;
            Second_txt_Screen.Text = FirstOperand.ToString() + "/";
            znak = true;
        }

        private void ClearLastOperand()=>
            Second_txt_Screen.Text = String.Empty;

        private string FinalResult
        {
            get => First_txt_Screen.Text;
            set => First_txt_Screen.Text = value;
        }
            
        private void button_run_Click(object sender, EventArgs e)
        {
            FinalResult = Calculation.Run(FirstOperand, float.Parse(First_txt_Screen.Text), operation).ToString();
            ClearLastOperand();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            First_txt_Screen.Text = "";
            Second_txt_Screen.Text = "";
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            int lenght = First_txt_Screen.Text.Length - 1;
            string text = First_txt_Screen.Text;
            First_txt_Screen.Clear();
            for (int i = 0; i < lenght; i++)
            {
                First_txt_Screen.Text = First_txt_Screen.Text + text[i];
            }
        }

        private void button_znak_Click(object sender, EventArgs e)
        {
            if (znak == true)
            {
                First_txt_Screen.Text = "-" + First_txt_Screen.Text;
                znak = false;
            }
            else if (znak == false)
            {
                First_txt_Screen.Text = First_txt_Screen.Text.Replace("-", "");
                znak = true;
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            FirstOperand = float.Parse(First_txt_Screen.Text);
            First_txt_Screen.Clear();
            operation = Operation.Add;
            Second_txt_Screen.Text = FirstOperand.ToString() + "+";
            znak = true;
        }
    }
}