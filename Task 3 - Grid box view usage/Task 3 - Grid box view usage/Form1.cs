namespace Task_3___Grid_box_view_usage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Name.Text) || string.IsNullOrEmpty(textBox_ID.Text) || string.IsNullOrEmpty(textBox_Dept.Text))
            {
                MessageBox.Show("Please populate all the fields");
                return;
            }
            dataGridView1.Rows.Add(textBox_Name.Text, textBox_ID.Text, textBox_Dept.Text);
        }
    }
}
