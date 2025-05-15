namespace task_5___advanced_data_grid_view
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            // null field check
            if (string.IsNullOrEmpty(textBox_Balance.Text))
            {
                MessageBox.Show("Please populate all the fields");
                return;
            }
            if (string.IsNullOrEmpty(textBox_CGPA.Text))
            {
                MessageBox.Show("Please populate all the fields");
                return;
            }
            if (string.IsNullOrEmpty(textBox_Dept.Text))
            {
                MessageBox.Show("Please populate all the fields");
                return;
            }
            if (string.IsNullOrEmpty(textBox_ID.Text))
            {
                MessageBox.Show("Please populate all the fields");
                return;
            }
            if (string.IsNullOrEmpty(textBox_Name.Text))
            {
                MessageBox.Show("Please populate all the fields");
                return;
            }
            if (!radioButton_Female.Checked && !radioButton_Male.Checked)
            {
                MessageBox.Show("Please select your gender");
                return;
            }

            // adding data to grid view
            dataGridView_Output.Rows.Add(
                    textBox_ID.Text,
                    textBox_Name.Text,
                    textBox_Dept.Text,
                    textBox_CGPA.Text,
                    (radioButton_Male.Checked ? radioButton_Male.Text : radioButton_Female.Text),
                    textBox_Balance.Text
            );

            // adding items to combo box
            if (!comboBox_Dept.Items.Contains(textBox_Dept.Text.ToUpper()))
                comboBox_Dept.Items.Add(textBox_Dept.Text.ToUpper());


        }

        private void button_Show_Click(object sender, EventArgs e)
        {
            string selected = comboBox_Dept.Text;
            if (string.IsNullOrEmpty(selected))
            {
                MessageBox.Show("Please select a query");
                return;
            }

            FilterRows(selected);
        }

        private void FilterRows(string s)
        {
            if (dataGridView_Output.Rows.Count == 0)
            {
                MessageBox.Show("Empty Table");
                return;
            }
            foreach (DataGridViewRow row in dataGridView_Output.Rows)
            {
                //if (row.IsNewRow)
                //    continue;
                row.Visible = true;
            }

            if (s == "null")
                return;

            foreach (DataGridViewRow row in dataGridView_Output.Rows)
            {
                if (row.IsNewRow)
                    continue;
                if (row.Cells[2].Value.ToString() != s)
                    row.Visible = false;
            }
        }
    }
}
