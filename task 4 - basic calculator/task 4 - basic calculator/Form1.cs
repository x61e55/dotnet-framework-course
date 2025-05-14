namespace task_4___basic_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double resultVal = 0;
        string operation = "";
        bool operationPerformed = false;

        private void num_Click(object sender, EventArgs e)
        {
            if (textBox_Display.Text == "0" || operationPerformed)
            {
                textBox_Display.Clear();
            }

            if (operation.Length == 0 && operationPerformed)
            {
                label_Display.Text = "";
            }

            if (operation.Length == 0)
            operationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox_Display.Text.Contains("."))
                    return;
                textBox_Display.Text += button.Text;
                label_Display.Text += button.Text;
            }
            else
            {
                textBox_Display.Text += button.Text;
                label_Display.Text += button.Text;
            }
        }

        private void operation_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            resultVal = double.Parse(textBox_Display.Text);
            operationPerformed = true;
            label_Display.Text += operation;
        }

        private void button_Equal_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBox_Display.Text = Convert.ToString(resultVal + double.Parse(textBox_Display.Text));
                    break;
                case "-":
                    textBox_Display.Text = Convert.ToString(resultVal - double.Parse(textBox_Display.Text));
                    break;
                case "*":
                    textBox_Display.Text = Convert.ToString(resultVal * double.Parse(textBox_Display.Text));
                    break;
                case "/":
                    textBox_Display.Text = Convert.ToString(resultVal / double.Parse(textBox_Display.Text));
                    break;
                case "%":
                    textBox_Display.Text = Convert.ToString(resultVal % double.Parse(textBox_Display.Text));
                    break;
                default:
                    break;
            }
            operation = "";
            resultVal = double.Parse(textBox_Display.Text);
            label_Display.Text = "";
            label_Display.Text += textBox_Display.Text;
        }

        private void button_Click_Click(object sender, EventArgs e)
        {
            resultVal = 0;
            textBox_Display.Text = "0";
            label_Display.Text = "0";
            operation = "";
        }

        private void button_Clear_Entry_Click(object sender, EventArgs e)
        {
            textBox_Display.Text = "0";
            label_Display.Text = "0";
            operation = "";
        }
    }
}
