namespace Task_2___Combo_box_usage
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
            comboBox_Countries = new ComboBox();
            textBox_Output = new TextBox();
            button_Show = new Button();
            radioButton_Check = new RadioButton();
            label1 = new Label();
            SuspendLayout();
            // 
            // comboBox_Countries
            // 
            comboBox_Countries.FormattingEnabled = true;
            comboBox_Countries.Items.AddRange(new object[] { "Bangladesh", "India", "Pakistan", "USA", "UK", "CANADA" });
            comboBox_Countries.Location = new Point(483, 263);
            comboBox_Countries.Name = "comboBox_Countries";
            comboBox_Countries.Size = new Size(151, 28);
            comboBox_Countries.TabIndex = 0;
            // 
            // textBox_Output
            // 
            textBox_Output.Location = new Point(737, 264);
            textBox_Output.Name = "textBox_Output";
            textBox_Output.Size = new Size(191, 27);
            textBox_Output.TabIndex = 1;
            // 
            // button_Show
            // 
            button_Show.Location = new Point(483, 395);
            button_Show.Name = "button_Show";
            button_Show.Size = new Size(94, 29);
            button_Show.TabIndex = 2;
            button_Show.Text = "Show";
            button_Show.UseVisualStyleBackColor = true;
            button_Show.Click += button_Show_Click;
            // 
            // radioButton_Check
            // 
            radioButton_Check.AutoSize = true;
            radioButton_Check.Location = new Point(483, 329);
            radioButton_Check.Name = "radioButton_Check";
            radioButton_Check.Size = new Size(113, 24);
            radioButton_Check.TabIndex = 3;
            radioButton_Check.TabStop = true;
            radioButton_Check.Text = "Please check";
            radioButton_Check.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(359, 263);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 4;
            label1.Text = "Select Country";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1469, 731);
            Controls.Add(label1);
            Controls.Add(radioButton_Check);
            Controls.Add(button_Show);
            Controls.Add(textBox_Output);
            Controls.Add(comboBox_Countries);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox_Countries;
        private TextBox textBox_Output;
        private Button button_Show;
        private RadioButton radioButton_Check;
        private Label label1;
    }
}
