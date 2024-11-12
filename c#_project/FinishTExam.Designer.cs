namespace c__Project
{
    partial class FinishTExam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            allwronganswers = new Label();
            label2 = new Label();
            yourAanswer = new Label();
            label3 = new Label();
            correctAnswer = new Label();
            label4 = new Label();
            HomePage = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(293, 9);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // allwronganswers
            // 
            allwronganswers.AutoSize = true;
            allwronganswers.Location = new Point(227, 56);
            allwronganswers.Name = "allwronganswers";
            allwronganswers.Size = new Size(104, 15);
            allwronganswers.TabIndex = 1;
            allwronganswers.Text = "all wrong answers:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(337, 56);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // yourAanswer
            // 
            yourAanswer.AutoSize = true;
            yourAanswer.Location = new Point(227, 82);
            yourAanswer.Name = "yourAanswer";
            yourAanswer.Size = new Size(74, 15);
            yourAanswer.TabIndex = 3;
            yourAanswer.Text = "your answer:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(337, 82);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 4;
            label3.Text = "label3";
            // 
            // correctAnswer
            // 
            correctAnswer.AutoSize = true;
            correctAnswer.Location = new Point(227, 111);
            correctAnswer.Name = "correctAnswer";
            correctAnswer.Size = new Size(87, 15);
            correctAnswer.TabIndex = 5;
            correctAnswer.Text = "correct answer:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(337, 111);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 6;
            label4.Text = "label4";
            // 
            // HomePage
            // 
            HomePage.Location = new Point(573, 227);
            HomePage.Name = "HomePage";
            HomePage.Size = new Size(88, 85);
            HomePage.TabIndex = 7;
            HomePage.Text = "Home Page";
            HomePage.UseVisualStyleBackColor = true;
            HomePage.Click += HomePage_Click_1;
            // 
            // FinishTExam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(HomePage);
            Controls.Add(label4);
            Controls.Add(correctAnswer);
            Controls.Add(label3);
            Controls.Add(yourAanswer);
            Controls.Add(label2);
            Controls.Add(allwronganswers);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FinishTExam";
            Text = "FinishTExam";
            Load += FinishTExam_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label allwronganswers;
        private Label label2;
        private Label label3;
        private Label yourAanswer;
        private Label correctAnswer;
        private Label label4;
        private Button HomePage;
    }
}