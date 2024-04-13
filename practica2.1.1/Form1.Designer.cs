namespace practica2._1._1
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
            NTextBox = new TextBox();
            MTextBox = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            ResultTextBox = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // NTextBox
            // 
            NTextBox.Location = new Point(76, 134);
            NTextBox.Name = "NTextBox";
            NTextBox.Size = new Size(125, 27);
            NTextBox.TabIndex = 0;
            NTextBox.TextChanged += textBox1_TextChanged;
            // 
            // MTextBox
            // 
            MTextBox.Location = new Point(76, 182);
            MTextBox.Name = "MTextBox";
            MTextBox.Size = new Size(125, 27);
            MTextBox.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(90, 238);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "go";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 137);
            label1.Name = "label1";
            label1.Size = new Size(20, 20);
            label1.TabIndex = 3;
            label1.Text = "N";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 185);
            label2.Name = "label2";
            label2.Size = new Size(22, 20);
            label2.TabIndex = 4;
            label2.Text = "M";
            // 
            // ResultTextBox
            // 
            ResultTextBox.Location = new Point(300, 134);
            ResultTextBox.Name = "ResultTextBox";
            ResultTextBox.Size = new Size(488, 27);
            ResultTextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(228, 141);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 6;
            label3.Text = "result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(ResultTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(MTextBox);
            Controls.Add(NTextBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NTextBox;
        private TextBox MTextBox;
        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox ResultTextBox;
        private Label label3;
    }
}
