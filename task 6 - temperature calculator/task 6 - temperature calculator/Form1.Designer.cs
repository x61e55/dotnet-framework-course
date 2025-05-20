namespace task_6___temperature_calculator
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
            textBox_input = new TextBox();
            comboBox_Input = new ComboBox();
            button_Convert = new Button();
            comboBox_Output = new ComboBox();
            textBox_Output = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBox_input
            // 
            textBox_input.Location = new Point(346, 198);
            textBox_input.Name = "textBox_input";
            textBox_input.Size = new Size(151, 27);
            textBox_input.TabIndex = 0;
            // 
            // comboBox_Input
            // 
            comboBox_Input.FormattingEnabled = true;
            comboBox_Input.Items.AddRange(new object[] { "Celsius", "Fahrenheit", "Kelvin" });
            comboBox_Input.Location = new Point(346, 253);
            comboBox_Input.Name = "comboBox_Input";
            comboBox_Input.Size = new Size(151, 28);
            comboBox_Input.TabIndex = 1;
            // 
            // button_Convert
            // 
            button_Convert.Location = new Point(512, 340);
            button_Convert.Name = "button_Convert";
            button_Convert.Size = new Size(94, 59);
            button_Convert.TabIndex = 2;
            button_Convert.Text = "Convert";
            button_Convert.UseVisualStyleBackColor = true;
            button_Convert.Click += button_Convert_Click;
            // 
            // comboBox_Output
            // 
            comboBox_Output.FormattingEnabled = true;
            comboBox_Output.Items.AddRange(new object[] { "Celsius", "Fahrenheit", "Kelvin" });
            comboBox_Output.Location = new Point(621, 253);
            comboBox_Output.Name = "comboBox_Output";
            comboBox_Output.Size = new Size(151, 28);
            comboBox_Output.TabIndex = 4;
            // 
            // textBox_Output
            // 
            textBox_Output.Location = new Point(620, 198);
            textBox_Output.Name = "textBox_Output";
            textBox_Output.Size = new Size(151, 27);
            textBox_Output.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(346, 158);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 5;
            label1.Text = "Input";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(620, 158);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 6;
            label2.Text = "Output";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 594);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox_Output);
            Controls.Add(textBox_Output);
            Controls.Add(button_Convert);
            Controls.Add(comboBox_Input);
            Controls.Add(textBox_input);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_input;
        private ComboBox comboBox_Input;
        private Button button_Convert;
        private ComboBox comboBox_Output;
        private TextBox textBox_Output;
        private Label label1;
        private Label label2;
    }
}
