namespace task_5___advanced_data_grid_view
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox_ID = new TextBox();
            label1 = new Label();
            radioButton_Male = new RadioButton();
            button_Submit = new Button();
            dataGridView_Output = new DataGridView();
            Column_ID = new DataGridViewTextBoxColumn();
            Column_Name = new DataGridViewTextBoxColumn();
            Column_Dept = new DataGridViewTextBoxColumn();
            Column_CGPA = new DataGridViewTextBoxColumn();
            Column_Gender = new DataGridViewTextBoxColumn();
            Column_Balance = new DataGridViewTextBoxColumn();
            label2 = new Label();
            textBox_Name = new TextBox();
            label3 = new Label();
            textBox_CGPA = new TextBox();
            label4 = new Label();
            textBox_Dept = new TextBox();
            radioButton_Female = new RadioButton();
            label5 = new Label();
            textBox_Balance = new TextBox();
            comboBox_Dept = new ComboBox();
            button_Show = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Output).BeginInit();
            SuspendLayout();
            // 
            // textBox_ID
            // 
            textBox_ID.Location = new Point(234, 85);
            textBox_ID.Name = "textBox_ID";
            textBox_ID.Size = new Size(268, 27);
            textBox_ID.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(167, 85);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 1;
            label1.Text = "ID";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // radioButton_Male
            // 
            radioButton_Male.AutoSize = true;
            radioButton_Male.Location = new Point(167, 260);
            radioButton_Male.Name = "radioButton_Male";
            radioButton_Male.Size = new Size(63, 24);
            radioButton_Male.TabIndex = 2;
            radioButton_Male.TabStop = true;
            radioButton_Male.Text = "Male";
            radioButton_Male.UseVisualStyleBackColor = true;
            // 
            // button_Submit
            // 
            button_Submit.Location = new Point(167, 364);
            button_Submit.Name = "button_Submit";
            button_Submit.Size = new Size(94, 53);
            button_Submit.TabIndex = 3;
            button_Submit.Text = "Submit";
            button_Submit.UseVisualStyleBackColor = true;
            button_Submit.Click += button_Submit_Click;
            // 
            // dataGridView_Output
            // 
            dataGridView_Output.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Output.Columns.AddRange(new DataGridViewColumn[] { Column_ID, Column_Name, Column_Dept, Column_CGPA, Column_Gender, Column_Balance });
            dataGridView_Output.Location = new Point(556, 85);
            dataGridView_Output.Name = "dataGridView_Output";
            dataGridView_Output.RowHeadersWidth = 51;
            dataGridView_Output.Size = new Size(598, 269);
            dataGridView_Output.TabIndex = 4;
            // 
            // Column_ID
            // 
            Column_ID.HeaderText = "ID";
            Column_ID.MinimumWidth = 6;
            Column_ID.Name = "Column_ID";
            Column_ID.Width = 125;
            // 
            // Column_Name
            // 
            Column_Name.HeaderText = "Name";
            Column_Name.MinimumWidth = 6;
            Column_Name.Name = "Column_Name";
            Column_Name.Width = 125;
            // 
            // Column_Dept
            // 
            Column_Dept.HeaderText = "Dept";
            Column_Dept.MinimumWidth = 6;
            Column_Dept.Name = "Column_Dept";
            Column_Dept.Width = 125;
            // 
            // Column_CGPA
            // 
            Column_CGPA.HeaderText = "CGPA";
            Column_CGPA.MinimumWidth = 6;
            Column_CGPA.Name = "Column_CGPA";
            Column_CGPA.Width = 125;
            // 
            // Column_Gender
            // 
            Column_Gender.HeaderText = "Gender";
            Column_Gender.MinimumWidth = 6;
            Column_Gender.Name = "Column_Gender";
            Column_Gender.Width = 125;
            // 
            // Column_Balance
            // 
            Column_Balance.HeaderText = "Balance";
            Column_Balance.MinimumWidth = 6;
            Column_Balance.Name = "Column_Balance";
            Column_Balance.Width = 125;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(167, 127);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 6;
            label2.Text = "Name";
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(235, 127);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(268, 27);
            textBox_Name.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(167, 216);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 10;
            label3.Text = "CGPA";
            // 
            // textBox_CGPA
            // 
            textBox_CGPA.Location = new Point(234, 216);
            textBox_CGPA.Name = "textBox_CGPA";
            textBox_CGPA.Size = new Size(268, 27);
            textBox_CGPA.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(167, 174);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 8;
            label4.Text = "Dept";
            // 
            // textBox_Dept
            // 
            textBox_Dept.Location = new Point(234, 174);
            textBox_Dept.Name = "textBox_Dept";
            textBox_Dept.Size = new Size(268, 27);
            textBox_Dept.TabIndex = 7;
            // 
            // radioButton_Female
            // 
            radioButton_Female.AutoSize = true;
            radioButton_Female.Location = new Point(236, 260);
            radioButton_Female.Name = "radioButton_Female";
            radioButton_Female.Size = new Size(78, 24);
            radioButton_Female.TabIndex = 11;
            radioButton_Female.TabStop = true;
            radioButton_Female.Text = "Female";
            radioButton_Female.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(167, 305);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 13;
            label5.Text = "Balance";
            // 
            // textBox_Balance
            // 
            textBox_Balance.Location = new Point(234, 305);
            textBox_Balance.Name = "textBox_Balance";
            textBox_Balance.Size = new Size(268, 27);
            textBox_Balance.TabIndex = 12;
            // 
            // comboBox_Dept
            // 
            comboBox_Dept.FormattingEnabled = true;
            comboBox_Dept.Items.AddRange(new object[] { "null" });
            comboBox_Dept.Location = new Point(556, 402);
            comboBox_Dept.Name = "comboBox_Dept";
            comboBox_Dept.Size = new Size(230, 28);
            comboBox_Dept.TabIndex = 14;
            // 
            // button_Show
            // 
            button_Show.Location = new Point(808, 402);
            button_Show.Name = "button_Show";
            button_Show.Size = new Size(94, 53);
            button_Show.TabIndex = 15;
            button_Show.Text = "Show";
            button_Show.UseVisualStyleBackColor = true;
            button_Show.Click += button_Show_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1260, 608);
            Controls.Add(button_Show);
            Controls.Add(comboBox_Dept);
            Controls.Add(label5);
            Controls.Add(textBox_Balance);
            Controls.Add(radioButton_Female);
            Controls.Add(label3);
            Controls.Add(textBox_CGPA);
            Controls.Add(label4);
            Controls.Add(textBox_Dept);
            Controls.Add(label2);
            Controls.Add(textBox_Name);
            Controls.Add(dataGridView_Output);
            Controls.Add(button_Submit);
            Controls.Add(radioButton_Male);
            Controls.Add(label1);
            Controls.Add(textBox_ID);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView_Output).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_ID;
        private Label label1;
        private RadioButton radioButton_Male;
        private Button button_Submit;
        private DataGridView dataGridView_Output;
        private Label label2;
        private TextBox textBox_Name;
        private DataGridViewTextBoxColumn Column_ID;
        private DataGridViewTextBoxColumn Column_Name;
        private DataGridViewTextBoxColumn Column_Dept;
        private DataGridViewTextBoxColumn Column_CGPA;
        private DataGridViewTextBoxColumn Column_Gender;
        private DataGridViewTextBoxColumn Column_Balance;
        private Label label3;
        private TextBox textBox_CGPA;
        private Label label4;
        private TextBox textBox_Dept;
        private RadioButton radioButton_Female;
        private Label label5;
        private TextBox textBox_Balance;
        private ComboBox comboBox_Dept;
        private Button button_Show;
    }
}
