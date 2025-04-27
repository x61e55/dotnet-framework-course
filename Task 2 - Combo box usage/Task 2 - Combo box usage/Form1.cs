namespace Task_2___Combo_box_usage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Show_Click(object sender, EventArgs e)
        {
            if (comboBox_Countries.SelectedItem == null)
            {
                MessageBox.Show("Please select a country");
                return;
            }
            if (radioButton_Check.Checked )
            {
                
                textBox_Output.Text = Convert.ToString(comboBox_Countries.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please check the checkbox");
                return;
            }
        }
    }
}
