namespace c__Project
{
    partial class Questions
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
            this.QuestionDescription = new System.Windows.Forms.TextBox();
            this.QuestionType = new System.Windows.Forms.ComboBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.TheRealAnswer = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.saveQuastion = new System.Windows.Forms.Button();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.UpdateScore = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.QuestionType1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HomePage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // QuestionDescription
            // 
            this.QuestionDescription.Location = new System.Drawing.Point(365, 125);
            this.QuestionDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.QuestionDescription.Name = "QuestionDescription";
            this.QuestionDescription.Size = new System.Drawing.Size(236, 27);
            this.QuestionDescription.TabIndex = 1;
            // 
            // QuestionType
            // 
            this.QuestionType.FormattingEnabled = true;
            this.QuestionType.Items.AddRange(new object[] {
            "yes/no",
            "AmericanQuestion",
            "MultipleChoice"});
            this.QuestionType.Location = new System.Drawing.Point(402, 195);
            this.QuestionType.Name = "QuestionType";
            this.QuestionType.Size = new System.Drawing.Size(133, 28);
            this.QuestionType.TabIndex = 7;
            this.QuestionType.Text = "QuestionType";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(302, 267);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(346, 27);
            this.textBox7.TabIndex = 15;
            // 
            // TheRealAnswer
            // 
            this.TheRealAnswer.Location = new System.Drawing.Point(402, 332);
            this.TheRealAnswer.Name = "TheRealAnswer";
            this.TheRealAnswer.Size = new System.Drawing.Size(133, 27);
            this.TheRealAnswer.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(722, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 89);
            this.button1.TabIndex = 19;
            this.button1.Text = "Finish";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveQuastion
            // 
            this.saveQuastion.BackColor = System.Drawing.Color.Green;
            this.saveQuastion.Location = new System.Drawing.Point(715, 267);
            this.saveQuastion.Name = "saveQuastion";
            this.saveQuastion.Size = new System.Drawing.Size(112, 105);
            this.saveQuastion.TabIndex = 20;
            this.saveQuastion.Text = "saveQuastion";
            this.saveQuastion.UseVisualStyleBackColor = false;
            this.saveQuastion.Click += new System.EventHandler(this.saveQuastion_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(37, 541);
            this.progressBar2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(825, 43);
            this.progressBar2.TabIndex = 22;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(125, 427);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(166, 27);
            this.numericUpDown1.TabIndex = 23;
            // 
            // UpdateScore
            // 
            this.UpdateScore.BackColor = System.Drawing.Color.Green;
            this.UpdateScore.Location = new System.Drawing.Point(125, 465);
            this.UpdateScore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UpdateScore.Name = "UpdateScore";
            this.UpdateScore.Size = new System.Drawing.Size(166, 31);
            this.UpdateScore.TabIndex = 24;
            this.UpdateScore.Text = "UpdateScore";
            this.UpdateScore.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(402, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Question Description:";
            // 
            // QuestionType1
            // 
            this.QuestionType1.AutoSize = true;
            this.QuestionType1.Location = new System.Drawing.Point(422, 172);
            this.QuestionType1.Name = "QuestionType1";
            this.QuestionType1.Size = new System.Drawing.Size(102, 20);
            this.QuestionType1.TabIndex = 26;
            this.QuestionType1.Text = "QuestionType:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(349, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Answer options Put a comma between each option:\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "TheRealAnswer:";
            // 
            // HomePage
            // 
            this.HomePage.Location = new System.Drawing.Point(721, 59);
            this.HomePage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HomePage.Name = "HomePage";
            this.HomePage.Size = new System.Drawing.Size(119, 139);
            this.HomePage.TabIndex = 29;
            this.HomePage.Text = "Home Page";
            this.HomePage.UseVisualStyleBackColor = true;
            // 
            // Questions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 600);
            this.Controls.Add(this.HomePage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.QuestionType1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpdateScore);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.saveQuastion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TheRealAnswer);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.QuestionType);
            this.Controls.Add(this.QuestionDescription);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Questions";
            this.Text = "Questions";
            this.Load += new System.EventHandler(this.Questions_Load_3);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox QuestionDescription;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private ComboBox QuestionType;
        private TextBox textBox7;
        private TextBox TheRealAnswer;
        private Button button1;
        private Button saveQuastion;
        private ProgressBar progressBar2;
        private NumericUpDown numericUpDown1;
        private Button UpdateScore;
        private Label label1;
        private Label QuestionType1;
        private Label label2;
        private Label label3;
        private Button HomePage;
    }
}