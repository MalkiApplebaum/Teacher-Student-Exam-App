namespace c__Project
{
    partial class representQuestion
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
            Next = new Button();
            Previous = new Button();
            Description = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            Finish = new Button();
            Confirm = new Button();
            label1 = new Label();
            HomePage = new Button();
            SuspendLayout();
            // 
            // Next
            // 
            Next.Location = new Point(338, 219);
            Next.Margin = new Padding(3, 2, 3, 2);
            Next.Name = "Next";
            Next.Size = new Size(108, 29);
            Next.TabIndex = 0;
            Next.Text = "↪";
            Next.UseVisualStyleBackColor = true;
            Next.Click += Next_Click;
            // 
            // Previous
            // 
            Previous.Location = new Point(164, 219);
            Previous.Margin = new Padding(3, 2, 3, 2);
            Previous.Name = "Previous";
            Previous.Size = new Size(108, 29);
            Previous.TabIndex = 1;
            Previous.Text = "↩";
            Previous.UseVisualStyleBackColor = true;
            Previous.Click += Previous_Click;
            // 
            // Description
            // 
            Description.AutoSize = true;
            Description.Location = new Point(298, 9);
            Description.Name = "Description";
            Description.Size = new Size(67, 15);
            Description.TabIndex = 2;
            Description.Text = "Description";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(295, 34);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(295, 58);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(83, 19);
            checkBox2.TabIndex = 6;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(295, 82);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(83, 19);
            checkBox3.TabIndex = 7;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(295, 106);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(83, 19);
            checkBox4.TabIndex = 8;
            checkBox4.Text = "checkBox4";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // Finish
            // 
            Finish.Location = new Point(528, 226);
            Finish.Margin = new Padding(3, 2, 3, 2);
            Finish.Name = "Finish";
            Finish.Size = new Size(82, 22);
            Finish.TabIndex = 9;
            Finish.Text = "Finish";
            Finish.UseVisualStyleBackColor = true;
            Finish.Click += Finish_Click;
            // 
            // Confirm
            // 
            Confirm.Location = new Point(528, 196);
            Confirm.Margin = new Padding(3, 2, 3, 2);
            Confirm.Name = "Confirm";
            Confirm.Size = new Size(82, 22);
            Confirm.TabIndex = 10;
            Confirm.Text = "Confirm";
            Confirm.UseVisualStyleBackColor = true;
            Confirm.Click += Confirm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 68);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 11;
            label1.Text = "label1";
            label1.Click += label1_Click_1;
            // 
            // HomePage
            // 
            HomePage.Location = new Point(528, 82);
            HomePage.Name = "HomePage";
            HomePage.Size = new Size(97, 78);
            HomePage.TabIndex = 12;
            HomePage.Text = "Home Page";
            HomePage.UseVisualStyleBackColor = true;
            HomePage.Click += HomePage_Click_1;
            // 
            // representQuestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(HomePage);
            Controls.Add(label1);
            Controls.Add(Confirm);
            Controls.Add(Finish);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(Description);
            Controls.Add(Previous);
            Controls.Add(Next);
            Margin = new Padding(3, 2, 3, 2);
            Name = "representQuestion";
            Text = "presentQuestion";
            Load += representQuestion_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Button Next;
        private Button Previous;
        private Label Description;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private Button Finish;
        private Button Confirm;
        private Label label1;
        private Button HomePage;
    }
}