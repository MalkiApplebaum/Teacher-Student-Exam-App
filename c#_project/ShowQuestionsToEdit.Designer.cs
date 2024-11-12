namespace c__Project
{
    partial class ShowQuestionsToEdit
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
            listBox1 = new ListBox();
            RemoveQuestion = new Button();
            EditQuestion = new Button();
            AddQuestion = new Button();
            HomePage = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(64, 35);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(172, 244);
            listBox1.TabIndex = 1;
            // 
            // RemoveQuestion
            // 
            RemoveQuestion.Location = new Point(64, 288);
            RemoveQuestion.Margin = new Padding(3, 4, 3, 4);
            RemoveQuestion.Name = "RemoveQuestion";
            RemoveQuestion.Size = new Size(173, 29);
            RemoveQuestion.TabIndex = 2;
            RemoveQuestion.Text = "RemoveQuestion";
            RemoveQuestion.UseVisualStyleBackColor = true;
            // 
            // EditQuestion
            // 
            EditQuestion.Location = new Point(64, 325);
            EditQuestion.Margin = new Padding(3, 4, 3, 4);
            EditQuestion.Name = "EditQuestion";
            EditQuestion.Size = new Size(173, 31);
            EditQuestion.TabIndex = 3;
            EditQuestion.Text = "Edit Question";
            EditQuestion.UseVisualStyleBackColor = true;
            EditQuestion.Click += EditQuestion_Click;
            // 
            // AddQuestion
            // 
            AddQuestion.Location = new Point(64, 364);
            AddQuestion.Margin = new Padding(3, 4, 3, 4);
            AddQuestion.Name = "AddQuestion";
            AddQuestion.Size = new Size(173, 32);
            AddQuestion.TabIndex = 4;
            AddQuestion.Text = "AddQuestion";
            AddQuestion.UseVisualStyleBackColor = true;
            AddQuestion.Click += AddQuestion_Click;
            // 
            // HomePage
            // 
            HomePage.Location = new Point(626, 307);
            HomePage.Margin = new Padding(3, 4, 3, 4);
            HomePage.Name = "HomePage";
            HomePage.Size = new Size(119, 89);
            HomePage.TabIndex = 5;
            HomePage.Text = "Home Page";
            HomePage.UseVisualStyleBackColor = true;
            // 
            // ShowQuestionsToEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(HomePage);
            Controls.Add(AddQuestion);
            Controls.Add(EditQuestion);
            Controls.Add(RemoveQuestion);
            Controls.Add(listBox1);
            Name = "ShowQuestionsToEdit";
            Text = "ShowQuestionsToEdit";
            Load += ShowQuestionsToEdit_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button RemoveQuestion;
        private Button EditQuestion;
        private Button AddQuestion;
        private Button HomePage;
    }
}