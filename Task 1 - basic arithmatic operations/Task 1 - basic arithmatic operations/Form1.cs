namespace Task_1___basic_arithmatic_operations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox_Num1.Text) || string.IsNullOrEmpty(textBox_Num2.Text))
            {
                MessageBox.Show("Please populate all the fields");
                return;
            }

            int n1 = Convert.ToInt32(textBox_Num1.Text);
            int n2 = Convert.ToInt32(textBox_Num2.Text);

            int result;

            if (radioButton_Sum.Checked)
            {
                result = n1 + n2;
            }
            else if (radioButton_Sub.Checked)
            {
                result = n1 - n2;
            }
            else if (radioButton_Mul.Checked)
            {
                result = n1 * n2;
            }
            else if (radioButton_Div.Checked)
            {
                result = n1 / n2;
            }
            else
            {
                MessageBox.Show("Please select an operation to perform");
                return;
            }

            textBox_Result.Text = Convert.ToString(result);


        }
    }
}
