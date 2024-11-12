namespace c__Project
{
    partial class question
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
            TestName = new TextBox();
            button2 = new Button();
            label2 = new Label();
            HomePage = new Button();
            SuspendLayout();
            // 
            // TestName
            // 
            TestName.Location = new Point(282, 233);
            TestName.Margin = new Padding(3, 4, 3, 4);
            TestName.Name = "TestName";
            TestName.Size = new Size(277, 27);
            TestName.TabIndex = 0;
            TestName.Text = "testName:";
            TestName.TextChanged += TestName_TextChanged_1;
            // 
            // button2
            // 
            button2.Location = new Point(282, 272);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(278, 33);
            button2.TabIndex = 2;
            button2.Text = "Create Questions";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(194, 133);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 4;
            // 
            // HomePage
            // 
            HomePage.Location = new Point(709, 419);
            HomePage.Margin = new Padding(3, 4, 3, 4);
            HomePage.Name = "HomePage";
            HomePage.Size = new Size(117, 131);
            HomePage.TabIndex = 5;
            HomePage.Text = "Home Page";
            HomePage.UseVisualStyleBackColor = true;
            HomePage.Click += HomePage_Click;
            // 
            // question
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(HomePage);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(TestName);
            Margin = new Padding(3, 4, 3, 4);
            Name = "question";
            Text = "NewTest";
            Load += question_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TestName;
        private Button button2;
        private Label label2;
        private Button HomePage;
    }
}