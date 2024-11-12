using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c__Project
{
    public partial class FinishTExam : BaseForm
    {
        public FinishTExam(TestJ T, int score, List<bool> ifCorrect, List<List<string>> studentsAnswers, List<QuestionJ> questions)
        {
            InitializeComponent();
            t = T;
            score1 = score;
            IfCorrect = ifCorrect;
            questionsF = questions;
        }

        public TestJ t { get; private set; }
        public List<bool> IfCorrect { get; private set; }
        public List<List<string>> studentsAnswers { get; private set; }

        public List<QuestionJ> questionsF { get; set; }

        public int score1 { get; set; }
        private void FinishTExam_Load(object sender, EventArgs e)
        {
            if (t != null)
                label1.Text = "Final grade:" + score1;
            else
                label1.Visible = false;
           
            for (int i = 0; i < IfCorrect.Count(); i++)
            {
                if (IfCorrect[i] == false)
                {
                }
            }


        }

        private void label2_Click(object sender, EventArgs e) { }

        private void HomePage_Click_1(object sender, EventArgs e)
        {
            Teacher t = new Teacher();
            t.Show();
            this.Hide();
        }
  
    }
}



