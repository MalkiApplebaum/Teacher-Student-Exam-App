namespace c__Project
{
    partial class ExistingQuestion
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
            label3 = new Label();
            label2 = new Label();
            QuestionType1 = new Label();
            label1 = new Label();
            UpdateScore = new Button();
            numericUpDown1 = new NumericUpDown();
            progressBar2 = new ProgressBar();
            saveQuastion = new Button();
            button1 = new Button();
            TheRealAnswer = new TextBox();
            textBox7 = new TextBox();
            QuestionType = new ComboBox();
            QuestionDescription = new TextBox();
            HomePage = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(367, 200);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 41;
            label3.Text = "TheRealAnswer:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(271, 151);
            label2.Name = "label2";
            label2.Size = new Size(280, 15);
            label2.TabIndex = 40;
            label2.Text = "Answer options Put a comma between each option:\r\n";
            // 
            // QuestionType1
            // 
            QuestionType1.AutoSize = true;
            QuestionType1.Location = new Point(376, 97);
            QuestionType1.Name = "QuestionType1";
            QuestionType1.Size = new Size(82, 15);
            QuestionType1.TabIndex = 39;
            QuestionType1.Text = "QuestionType:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(359, 44);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 38;
            label1.Text = "Question Description:";
            // 
            // UpdateScore
            // 
            UpdateScore.BackColor = Color.Green;
            UpdateScore.Location = new Point(116, 317);
            UpdateScore.Name = "UpdateScore";
            UpdateScore.Size = new Size(145, 23);
            UpdateScore.TabIndex = 37;
            UpdateScore.Text = "UpdateScore";
            UpdateScore.UseVisualStyleBackColor = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(116, 288);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(145, 23);
            numericUpDown1.TabIndex = 36;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(39, 374);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(722, 32);
            progressBar2.TabIndex = 35;
            // 
            // saveQuastion
            // 
            saveQuastion.BackColor = Color.Green;
            saveQuastion.Location = new Point(633, 168);
            saveQuastion.Margin = new Padding(3, 2, 3, 2);
            saveQuastion.Name = "saveQuastion";
            saveQuastion.Size = new Size(98, 79);
            saveQuastion.TabIndex = 34;
            saveQuastion.Text = "saveQuastion";
            saveQuastion.UseVisualStyleBackColor = false;
            saveQuastion.Click += saveQuastion_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Location = new Point(639, 287);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 67);
            button1.TabIndex = 33;
            button1.Text = "Finish";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // TheRealAnswer
            // 
            TheRealAnswer.Location = new Point(359, 217);
            TheRealAnswer.Margin = new Padding(3, 2, 3, 2);
            TheRealAnswer.Name = "TheRealAnswer";
            TheRealAnswer.Size = new Size(117, 23);
            TheRealAnswer.TabIndex = 32;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(271, 168);
            textBox7.Margin = new Padding(3, 2, 3, 2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(303, 23);
            textBox7.TabIndex = 31;
            // 
            // QuestionType
            // 
            QuestionType.FormattingEnabled = true;
            QuestionType.Items.AddRange(new object[] { "yes/no", "AmericanQuestion", "MultipleChoice" });
            QuestionType.Location = new Point(359, 114);
            QuestionType.Margin = new Padding(3, 2, 3, 2);
            QuestionType.Name = "QuestionType";
            QuestionType.Size = new Size(117, 23);
            QuestionType.TabIndex = 30;
            QuestionType.Text = "QuestionType";
            // 
            // QuestionDescription
            // 
            QuestionDescription.Location = new Point(326, 62);
            QuestionDescription.Name = "QuestionDescription";
            QuestionDescription.Size = new Size(207, 23);
            QuestionDescription.TabIndex = 29;
            // 
            // HomePage
            // 
            HomePage.Location = new Point(642, 36);
            HomePage.Name = "HomePage";
            HomePage.Size = new Size(95, 86);
            HomePage.TabIndex = 42;
            HomePage.Text = "Home Page";
            HomePage.UseVisualStyleBackColor = true;
            HomePage.Click += HomePage_Click;
            // 
            // ExistingQuestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(HomePage);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(QuestionType1);
            Controls.Add(label1);
            Controls.Add(UpdateScore);
            Controls.Add(numericUpDown1);
            Controls.Add(progressBar2);
            Controls.Add(saveQuastion);
            Controls.Add(button1);
            Controls.Add(TheRealAnswer);
            Controls.Add(textBox7);
            Controls.Add(QuestionType);
            Controls.Add(QuestionDescription);
            Name = "ExistingQuestion";
            Text = "ExistingQuestion";
            Load += ExistingQuestion_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label QuestionType1;
        private Label label1;
        private Button UpdateScore;
        private NumericUpDown numericUpDown1;
        private ProgressBar progressBar2;
        private Button saveQuastion;
        private Button button1;
        private TextBox TheRealAnswer;
        private TextBox textBox7;
        private ComboBox QuestionType;
        private TextBox QuestionDescription;
        private Button HomePage;
    }
}