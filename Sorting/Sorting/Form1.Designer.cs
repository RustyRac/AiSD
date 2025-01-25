namespace Sorting
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(32, 30);
            button1.Name = "button1";
            button1.Size = new Size(165, 73);
            button1.TabIndex = 0;
            button1.Text = "Bubble Sort";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(432, 110);
            label1.Name = "label1";
            label1.Size = new Size(192, 25);
            label1.TabIndex = 1;
            label1.Text = "Wygenerowana Tablica";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(432, 135);
            label2.Name = "label2";
            label2.Size = new Size(27, 25);
            label2.TabIndex = 2;
            label2.Text = "[ ]";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(432, 210);
            label3.Name = "label3";
            label3.Size = new Size(172, 25);
            label3.TabIndex = 3;
            label3.Text = "Posortowana Tablica";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(432, 235);
            label4.Name = "label4";
            label4.Size = new Size(27, 25);
            label4.TabIndex = 4;
            label4.Text = "[ ]";
            // 
            // button2
            // 
            button2.Location = new Point(32, 107);
            button2.Name = "button2";
            button2.Size = new Size(165, 73);
            button2.TabIndex = 5;
            button2.Text = "Counting Sort";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(32, 186);
            button3.Name = "button3";
            button3.Size = new Size(165, 73);
            button3.TabIndex = 6;
            button3.Text = "Insertion Sort";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(32, 265);
            button4.Name = "button4";
            button4.Size = new Size(165, 73);
            button4.TabIndex = 7;
            button4.Text = "Merge Sort";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(32, 344);
            button5.Name = "button5";
            button5.Size = new Size(165, 73);
            button5.TabIndex = 8;
            button5.Text = "Quick Sort";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(432, 62);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(180, 31);
            numericUpDown1.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDown1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private NumericUpDown numericUpDown1;
    }
}
