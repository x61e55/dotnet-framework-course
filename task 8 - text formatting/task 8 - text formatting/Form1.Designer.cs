namespace task_8___text_formatting
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
            richTextBox_Msg = new RichTextBox();
            textBox_Name = new TextBox();
            label1 = new Label();
            button_Display = new Button();
            label2 = new Label();
            checkBox_Bold = new CheckBox();
            checkBox_Italic = new CheckBox();
            checkBox_Underline = new CheckBox();
            radioButton_Red = new RadioButton();
            radioButton_Green = new RadioButton();
            radioButton_Blue = new RadioButton();
            label_Name = new Label();
            label_Message = new Label();
            SuspendLayout();
            // 
            // richTextBox_Msg
            // 
            richTextBox_Msg.Location = new Point(473, 213);
            richTextBox_Msg.Name = "richTextBox_Msg";
            richTextBox_Msg.Size = new Size(190, 120);
            richTextBox_Msg.TabIndex = 0;
            richTextBox_Msg.Text = "";
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(473, 165);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(190, 27);
            textBox_Name.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(384, 165);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // button_Display
            // 
            button_Display.Location = new Point(384, 430);
            button_Display.Name = "button_Display";
            button_Display.Size = new Size(94, 49);
            button_Display.TabIndex = 3;
            button_Display.Text = "Display";
            button_Display.UseVisualStyleBackColor = true;
            button_Display.Click += button_Display_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(384, 216);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 4;
            label2.Text = "Message";
            // 
            // checkBox_Bold
            // 
            checkBox_Bold.AutoSize = true;
            checkBox_Bold.Location = new Point(384, 356);
            checkBox_Bold.Name = "checkBox_Bold";
            checkBox_Bold.Size = new Size(62, 24);
            checkBox_Bold.TabIndex = 5;
            checkBox_Bold.Text = "Bold";
            checkBox_Bold.UseVisualStyleBackColor = true;
            // 
            // checkBox_Italic
            // 
            checkBox_Italic.AutoSize = true;
            checkBox_Italic.Location = new Point(473, 356);
            checkBox_Italic.Name = "checkBox_Italic";
            checkBox_Italic.Size = new Size(63, 24);
            checkBox_Italic.TabIndex = 6;
            checkBox_Italic.Text = "Italic";
            checkBox_Italic.UseVisualStyleBackColor = true;
            // 
            // checkBox_Underline
            // 
            checkBox_Underline.AutoSize = true;
            checkBox_Underline.Location = new Point(558, 356);
            checkBox_Underline.Name = "checkBox_Underline";
            checkBox_Underline.Size = new Size(95, 24);
            checkBox_Underline.TabIndex = 7;
            checkBox_Underline.Text = "Underline";
            checkBox_Underline.UseVisualStyleBackColor = true;
            // 
            // radioButton_Red
            // 
            radioButton_Red.AutoSize = true;
            radioButton_Red.Location = new Point(384, 386);
            radioButton_Red.Name = "radioButton_Red";
            radioButton_Red.Size = new Size(56, 24);
            radioButton_Red.TabIndex = 8;
            radioButton_Red.Text = "Red";
            radioButton_Red.UseVisualStyleBackColor = true;
            // 
            // radioButton_Green
            // 
            radioButton_Green.AutoSize = true;
            radioButton_Green.Location = new Point(446, 386);
            radioButton_Green.Name = "radioButton_Green";
            radioButton_Green.Size = new Size(69, 24);
            radioButton_Green.TabIndex = 9;
            radioButton_Green.Text = "Green";
            radioButton_Green.UseVisualStyleBackColor = true;
            // 
            // radioButton_Blue
            // 
            radioButton_Blue.AutoSize = true;
            radioButton_Blue.Location = new Point(521, 386);
            radioButton_Blue.Name = "radioButton_Blue";
            radioButton_Blue.Size = new Size(59, 24);
            radioButton_Blue.TabIndex = 10;
            radioButton_Blue.Text = "Blue";
            radioButton_Blue.UseVisualStyleBackColor = true;
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Location = new Point(384, 503);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(0, 20);
            label_Name.TabIndex = 11;
            // 
            // label_Message
            // 
            label_Message.AutoSize = true;
            label_Message.Location = new Point(163, 554);
            label_Message.Name = "label_Message";
            label_Message.Size = new Size(0, 20);
            label_Message.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 705);
            Controls.Add(label_Message);
            Controls.Add(label_Name);
            Controls.Add(radioButton_Blue);
            Controls.Add(radioButton_Green);
            Controls.Add(radioButton_Red);
            Controls.Add(checkBox_Underline);
            Controls.Add(checkBox_Italic);
            Controls.Add(checkBox_Bold);
            Controls.Add(label2);
            Controls.Add(button_Display);
            Controls.Add(label1);
            Controls.Add(textBox_Name);
            Controls.Add(richTextBox_Msg);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox_Msg;
        private TextBox textBox_Name;
        private Label label1;
        private Button button_Display;
        private Label label2;
        private CheckBox checkBox_Bold;
        private CheckBox checkBox_Italic;
        private CheckBox checkBox_Underline;
        private RadioButton radioButton_Red;
        private RadioButton radioButton_Green;
        private RadioButton radioButton_Blue;
        private Label label_Name;
        private Label label_Message;
    }
}
