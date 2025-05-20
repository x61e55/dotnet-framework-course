namespace task_6___temperature_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Convert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_input.Text))
            {
                MessageBox.Show("Please populate the field");
                return;
            }
            if (comboBox_Input.SelectedItem == null || comboBox_Output.SelectedItem == null)
            {
                MessageBox.Show("Please select options");
                return;
            }

            string input = textBox_input.Text;
            double d1;

            if (double.TryParse(input, out d1)) 
            {
                d1 = double.Parse(input);
            }
            else
            {
                MessageBox.Show("Please provide a valid input");
                return;
            }

            double result;

            if (comboBox_Input.Text == "Celsius")
            {
                if (comboBox_Output.Text == "Fahrenheit")
                    result = (d1 * 9 / 5.0) + 32;
                else if (comboBox_Output.Text == "Kelvin")
                    result = d1 + 273.15;
                else
                    result = d1;
            }
            else if (comboBox_Input.Text == "Fahrenheit")
            {
                if (comboBox_Output.Text == "Celsius")
                    result = (d1 - 32) * 5 / 9.0;
                else if (comboBox_Output.Text == "Kelvin")
                    result = (d1 - 32) * 5 / 9.0 + 273.15;
                else
                    result = d1;
            }
            else
            {
                if (comboBox_Output.Text == "Celsius")
                    result = d1 - 273.15;
                else if (comboBox_Output.Text == "Fahrenheit")
                    result = (d1 - 273.15) * 9.0 / 5 + 32;
                else
                    result = d1;
            }



            textBox_Output.Text = Convert.ToString(result);
            if (comboBox_Output.Text == "Celsius")
                textBox_Output.Text += " C";
            else if (comboBox_Output.Text == "Fahrenheit")
                textBox_Output.Text += " F";
            else
                textBox_Output.Text += " K";
        }


    }
}
