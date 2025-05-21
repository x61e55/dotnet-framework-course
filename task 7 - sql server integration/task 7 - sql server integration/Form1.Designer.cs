namespace task_7___sql_server_integration
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
            label1 = new Label();
            radioButton1 = new RadioButton();
            textBox_Name = new TextBox();
            button_Preview = new Button();
            dataGridView_Output = new DataGridView();
            comboBox_Country = new ComboBox();
            label2 = new Label();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            button_Add = new Button();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox_Gender = new GroupBox();
            groupBox_Hobby = new GroupBox();
            groupBox_Status = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Output).BeginInit();
            groupBox_Gender.SuspendLayout();
            groupBox_Hobby.SuspendLayout();
            groupBox_Status.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 152);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(102, 26);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(63, 24);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(189, 152);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(187, 27);
            textBox_Name.TabIndex = 3;
            // 
            // button_Preview
            // 
            button_Preview.Location = new Point(202, 499);
            button_Preview.Name = "button_Preview";
            button_Preview.Size = new Size(94, 29);
            button_Preview.TabIndex = 4;
            button_Preview.Text = "preview";
            button_Preview.UseVisualStyleBackColor = true;
            button_Preview.Click += button_Preview_Click;
            // 
            // dataGridView_Output
            // 
            dataGridView_Output.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Output.Location = new Point(441, 152);
            dataGridView_Output.Name = "dataGridView_Output";
            dataGridView_Output.RowHeadersWidth = 51;
            dataGridView_Output.Size = new Size(663, 376);
            dataGridView_Output.TabIndex = 5;
            // 
            // comboBox_Country
            // 
            comboBox_Country.FormattingEnabled = true;
            comboBox_Country.Items.AddRange(new object[] { "Bangladesh", "India", "Pakistan", "Canada", "Australia", "Sweden", "Finland", "Japan" });
            comboBox_Country.Location = new Point(189, 200);
            comboBox_Country.Name = "comboBox_Country";
            comboBox_Country.Size = new Size(100, 28);
            comboBox_Country.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 200);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 7;
            label2.Text = "Country";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(193, 26);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(78, 24);
            radioButton2.TabIndex = 9;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(193, 28);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(83, 24);
            radioButton3.TabIndex = 11;
            radioButton3.TabStop = true;
            radioButton3.Text = "Painting";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(102, 28);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(85, 24);
            radioButton4.TabIndex = 10;
            radioButton4.TabStop = true;
            radioButton4.Text = "Reading";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // button_Add
            // 
            button_Add.Location = new Point(102, 499);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(94, 29);
            button_Add.TabIndex = 12;
            button_Add.Text = "add";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(193, 26);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(100, 24);
            radioButton5.TabIndex = 14;
            radioButton5.TabStop = true;
            radioButton5.Text = "Unmarried";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(102, 26);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(82, 24);
            radioButton6.TabIndex = 13;
            radioButton6.TabStop = true;
            radioButton6.Text = "Married";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 28);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 15;
            label3.Text = "Gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 28);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 16;
            label4.Text = "Hobby";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 28);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 17;
            label5.Text = "Status";
            // 
            // groupBox_Gender
            // 
            groupBox_Gender.Controls.Add(radioButton2);
            groupBox_Gender.Controls.Add(radioButton1);
            groupBox_Gender.Controls.Add(label3);
            groupBox_Gender.Location = new Point(102, 250);
            groupBox_Gender.Name = "groupBox_Gender";
            groupBox_Gender.Size = new Size(307, 72);
            groupBox_Gender.TabIndex = 18;
            groupBox_Gender.TabStop = false;
            // 
            // groupBox_Hobby
            // 
            groupBox_Hobby.Controls.Add(radioButton3);
            groupBox_Hobby.Controls.Add(radioButton4);
            groupBox_Hobby.Controls.Add(label4);
            groupBox_Hobby.Location = new Point(102, 328);
            groupBox_Hobby.Name = "groupBox_Hobby";
            groupBox_Hobby.Size = new Size(307, 72);
            groupBox_Hobby.TabIndex = 19;
            groupBox_Hobby.TabStop = false;
            // 
            // groupBox_Status
            // 
            groupBox_Status.Controls.Add(radioButton5);
            groupBox_Status.Controls.Add(radioButton6);
            groupBox_Status.Controls.Add(label5);
            groupBox_Status.Location = new Point(102, 406);
            groupBox_Status.Name = "groupBox_Status";
            groupBox_Status.Size = new Size(307, 72);
            groupBox_Status.TabIndex = 20;
            groupBox_Status.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1344, 736);
            Controls.Add(groupBox_Status);
            Controls.Add(groupBox_Hobby);
            Controls.Add(groupBox_Gender);
            Controls.Add(button_Add);
            Controls.Add(label2);
            Controls.Add(comboBox_Country);
            Controls.Add(dataGridView_Output);
            Controls.Add(button_Preview);
            Controls.Add(textBox_Name);
            Controls.Add(label1);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView_Output).EndInit();
            groupBox_Gender.ResumeLayout(false);
            groupBox_Gender.PerformLayout();
            groupBox_Hobby.ResumeLayout(false);
            groupBox_Hobby.PerformLayout();
            groupBox_Status.ResumeLayout(false);
            groupBox_Status.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton radioButton1;
        private TextBox textBox_Name;
        private Button button_Preview;
        private DataGridView dataGridView_Output;
        private ComboBox comboBox_Country;
        private Label label2;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Button button_Add;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox groupBox_Gender;
        private GroupBox groupBox_Hobby;
        private GroupBox groupBox_Status;
    }
}
