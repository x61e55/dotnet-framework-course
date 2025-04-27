namespace Task_1___basic_arithmatic_operations
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
            textBox_Num1 = new TextBox();
            Num1 = new Label();
            radioButton_Sum = new RadioButton();
            button1 = new Button();
            label2 = new Label();
            textBox_Num2 = new TextBox();
            label3 = new Label();
            textBox_Result = new TextBox();
            radioButton_Sub = new RadioButton();
            radioButton_Mul = new RadioButton();
            radioButton_Div = new RadioButton();
            SuspendLayout();
            // 
            // textBox_Num1
            // 
            textBox_Num1.Location = new Point(598, 208);
            textBox_Num1.Name = "textBox_Num1";
            textBox_Num1.Size = new Size(178, 27);
            textBox_Num1.TabIndex = 0;
            // 
            // Num1
            // 
            Num1.AutoSize = true;
            Num1.Location = new Point(521, 208);
            Num1.Name = "Num1";
            Num1.Size = new Size(49, 20);
            Num1.TabIndex = 1;
            Num1.Text = "Num1";
            // 
            // radioButton_Sum
            // 
            radioButton_Sum.AutoSize = true;
            radioButton_Sum.Location = new Point(521, 352);
            radioButton_Sum.Name = "radioButton_Sum";
            radioButton_Sum.Size = new Size(106, 24);
            radioButton_Sum.TabIndex = 2;
            radioButton_Sum.TabStop = true;
            radioButton_Sum.Text = "Summation";
            radioButton_Sum.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(598, 427);
            button1.Name = "button1";
            button1.Size = new Size(94, 58);
            button1.TabIndex = 3;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(521, 282);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 5;
            label2.Text = "Num2";
            // 
            // textBox_Num2
            // 
            textBox_Num2.Location = new Point(598, 282);
            textBox_Num2.Name = "textBox_Num2";
            textBox_Num2.Size = new Size(178, 27);
            textBox_Num2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(842, 248);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 7;
            label3.Text = "Result";
            // 
            // textBox_Result
            // 
            textBox_Result.Location = new Point(919, 248);
            textBox_Result.Name = "textBox_Result";
            textBox_Result.Size = new Size(178, 27);
            textBox_Result.TabIndex = 6;
            // 
            // radioButton_Sub
            // 
            radioButton_Sub.AutoSize = true;
            radioButton_Sub.Location = new Point(645, 352);
            radioButton_Sub.Name = "radioButton_Sub";
            radioButton_Sub.Size = new Size(112, 24);
            radioButton_Sub.TabIndex = 8;
            radioButton_Sub.TabStop = true;
            radioButton_Sub.Text = "Substraction";
            radioButton_Sub.UseVisualStyleBackColor = true;
            // 
            // radioButton_Mul
            // 
            radioButton_Mul.AutoSize = true;
            radioButton_Mul.Location = new Point(786, 352);
            radioButton_Mul.Name = "radioButton_Mul";
            radioButton_Mul.Size = new Size(122, 24);
            radioButton_Mul.TabIndex = 9;
            radioButton_Mul.TabStop = true;
            radioButton_Mul.Text = "Multiplication";
            radioButton_Mul.UseVisualStyleBackColor = true;
            // 
            // radioButton_Div
            // 
            radioButton_Div.AutoSize = true;
            radioButton_Div.Location = new Point(925, 352);
            radioButton_Div.Name = "radioButton_Div";
            radioButton_Div.Size = new Size(81, 24);
            radioButton_Div.TabIndex = 10;
            radioButton_Div.TabStop = true;
            radioButton_Div.Text = "division";
            radioButton_Div.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1585, 694);
            Controls.Add(radioButton_Div);
            Controls.Add(radioButton_Mul);
            Controls.Add(radioButton_Sub);
            Controls.Add(label3);
            Controls.Add(textBox_Result);
            Controls.Add(label2);
            Controls.Add(textBox_Num2);
            Controls.Add(button1);
            Controls.Add(radioButton_Sum);
            Controls.Add(Num1);
            Controls.Add(textBox_Num1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Num1;
        private Label Num1;
        private RadioButton radioButton_Sum;
        private Button button1;
        private Label label2;
        private TextBox textBox_Num2;
        private Label label3;
        private TextBox textBox_Result;
        private RadioButton radioButton_Sub;
        private RadioButton radioButton_Mul;
        private RadioButton radioButton_Div;
    }
}
