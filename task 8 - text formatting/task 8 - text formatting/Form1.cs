namespace task_8___text_formatting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Display_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Name.Text) || string.IsNullOrEmpty(richTextBox_Msg.Text))
            {
                MessageBox.Show("Please populate all the fields");
                return;
            }

            label_Name.Text = textBox_Name.Text;
            label_Message.Text = richTextBox_Msg.Text;

            if (radioButton_Red.Checked )
            {
                label_Name.ForeColor = Color.Red;
                label_Message.ForeColor = Color.Red;
            }
            else if (radioButton_Green.Checked)
            {
                label_Name.ForeColor = Color.Green;
                label_Message.ForeColor = Color.Green;
            }
            else if (radioButton_Blue.Checked)
            {
                label_Name.ForeColor = Color.Blue;
                label_Message.ForeColor = Color.Blue;
            }

            FontStyle style = FontStyle.Regular;

            if (checkBox_Bold.Checked)
                style |= FontStyle.Bold;

            if (checkBox_Italic.Checked)
                style |= FontStyle.Italic;

            if (checkBox_Underline.Checked)
                style |= FontStyle.Underline;

            label_Name.Font = new Font("Calibri", 20, style);
            label_Message.Font = new Font("Calibri", 20, style);
        }
    }
}
