namespace Task_3___Grid_box_view_usage
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
            textBox_Name = new TextBox();
            label1 = new Label();
            Button_Add = new Button();
            label2 = new Label();
            textBox_ID = new TextBox();
            label3 = new Label();
            textBox_Dept = new TextBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(452, 174);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(241, 27);
            textBox_Name.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(396, 174);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // Button_Add
            // 
            Button_Add.Location = new Point(452, 397);
            Button_Add.Name = "Button_Add";
            Button_Add.Size = new Size(94, 49);
            Button_Add.TabIndex = 2;
            Button_Add.Text = "Add";
            Button_Add.UseVisualStyleBackColor = true;
            Button_Add.Click += Button_Add_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(396, 237);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 5;
            label2.Text = "ID";
            // 
            // textBox_ID
            // 
            textBox_ID.Location = new Point(452, 237);
            textBox_ID.Name = "textBox_ID";
            textBox_ID.Size = new Size(241, 27);
            textBox_ID.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(396, 305);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 7;
            label3.Text = "Dept";
            // 
            // textBox_Dept
            // 
            textBox_Dept.Location = new Point(452, 305);
            textBox_Dept.Name = "textBox_Dept";
            textBox_Dept.Size = new Size(241, 27);
            textBox_Dept.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(760, 174);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(427, 188);
            dataGridView1.TabIndex = 8;
            // 
            // Column1
            // 
            Column1.HeaderText = "Name";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "ID";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Dept";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1445, 749);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(textBox_Dept);
            Controls.Add(label2);
            Controls.Add(textBox_ID);
            Controls.Add(Button_Add);
            Controls.Add(label1);
            Controls.Add(textBox_Name);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Name;
        private Label label1;
        private Button Button_Add;
        private Label label2;
        private TextBox textBox_ID;
        private Label label3;
        private TextBox textBox_Dept;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}
