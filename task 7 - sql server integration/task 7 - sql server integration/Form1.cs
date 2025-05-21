using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace task_7___sql_server_integration
{

    public partial class Form1 : Form
    {
        private readonly string connectionString = "Data Source=test\\SQLEXPRESS;Initial Catalog=edge_db;Integrated Security=True;Trust Server Certificate=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {

            // data input error check
            if (string.IsNullOrEmpty(textBox_Name.Text))
            {
                MessageBox.Show("Please enter your name");
                return;
            }

            if (comboBox_Country.SelectedItem == null)
            {
                MessageBox.Show("Please select your country");
                return;
            }


            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Please select gender");
                return;
            }

            if (!radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("Please select hobby");
                return;
            }
            if (!radioButton5.Checked && !radioButton6.Checked)
            {
                MessageBox.Show("Please select status");
                return;
            }

            string name = textBox_Name.Text;
            string country = comboBox_Country.SelectedItem.ToString();
            string gender = (radioButton1.Checked ? radioButton1.Text.ToUpper() : radioButton2.Text.ToUpper());
            string hobby = (radioButton3.Checked ? radioButton3.Text : radioButton4.Text);
            string status = (radioButton5.Checked ? radioButton5.Text.ToUpper() : radioButton6.Text.ToUpper());

            //dataGridView_Output.Rows.Add(name, country, gender, hobby, status);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO customers (NAME, COUNTRY, GENDER, HOBBY, STATUS) " +
                               "VALUES (@Name, @Country, @Gender, @Hobby, @Status)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Country", country);
                    command.Parameters.AddWithValue("@Gender", gender);
                    command.Parameters.AddWithValue("@Hobby", hobby);
                    command.Parameters.AddWithValue("@Status", status);

                    command.ExecuteNonQuery();
                }
            }

        }

        private void button_Preview_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM customers";

            DataTable table = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                conn.Open();
                adapter.Fill(table);
            }
            dataGridView_Output.DataSource = table;
        }
    }
}
