namespace c__Project
{
    partial class Exam
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
            AllActiveTests = new ListBox();
            ChooseTest = new Button();
            HomePage = new Button();
            SuspendLayout();
            // 
            // AllActiveTests
            // 
            AllActiveTests.FormattingEnabled = true;
            AllActiveTests.ItemHeight = 15;
            AllActiveTests.Location = new Point(259, 38);
            AllActiveTests.Margin = new Padding(3, 2, 3, 2);
            AllActiveTests.Name = "AllActiveTests";
            AllActiveTests.Size = new Size(143, 229);
            AllActiveTests.TabIndex = 0;
            AllActiveTests.SelectedIndexChanged += AllActiveTests_SelectedIndexChanged;
            // 
            // ChooseTest
            // 
            ChooseTest.Location = new Point(259, 270);
            ChooseTest.Margin = new Padding(3, 2, 3, 2);
            ChooseTest.Name = "ChooseTest";
            ChooseTest.Size = new Size(140, 20);
            ChooseTest.TabIndex = 1;
            ChooseTest.Text = "Choose Test";
            ChooseTest.UseVisualStyleBackColor = true;
            ChooseTest.Click += ChooseTest_Click;
            // 
            // HomePage
            // 
            HomePage.Location = new Point(535, 214);
            HomePage.Name = "HomePage";
            HomePage.Size = new Size(94, 82);
            HomePage.TabIndex = 2;
            HomePage.Text = "Home Page";
            HomePage.UseVisualStyleBackColor = true;
            HomePage.Click += HomePage_Click;
            // 
            // Exam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(HomePage);
            Controls.Add(ChooseTest);
            Controls.Add(AllActiveTests);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Exam";
            Text = "Exam";
            Load += Exam_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox AllActiveTests;
        private Button ChooseTest;
        private Button HomePage;
    }
}