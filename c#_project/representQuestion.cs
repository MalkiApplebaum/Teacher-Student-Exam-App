using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace c__Project
{
    public partial class representQuestion : BaseForm
    {
        public int index { get; set; }
        public TestJ T { get; private set; }
        public List<QuestionJ> questions { get; set; }
        public QuestionJ q { get; set; }
        public int countAnswers { get; set; }
        public List<bool> ifCorrect { get; set; } = new List<bool>();
        public bool finish { get; set; }
        public List<string> studentsAnswer { get; set; }

        public int score { get; set; }
        public List<List<string>> studentsAnswers { get; set; } = new List<List<string>>();//   save students answers
        public representQuestion(TestJ t)
        {
            InitializeComponent();
            questions = ReadQuestionOfTestFromJson(t);
            index = 0;
            T = t;
            countAnswers = 0;
            ifCorrect = Enumerable.Repeat(false, questions.Count()).ToList();
            //List<bool> ifCorrect = new List<bool>();

            finish = false;
            // studentsAnswer = null;
            score = 0;


            studentsAnswers = new List<List<string>>();
            for (int i = 0; i < questions.Count(); i++)
            {
                var l = new List<string> { "", "", "", "" };

                studentsAnswers.Add(l);
            }
        }




        private List<QuestionJ> ReadQuestionOfTestFromJson(TestJ t)
        {
            List<QuestionJ> questions = new List<QuestionJ>();

            try
            {
                string filePathquestion = "question.json";
                string read = File.ReadAllText(filePathquestion);
                questions = JsonConvert.DeserializeObject<List<QuestionJ>>(read);
            }
            catch
            {
                MessageBox.Show("לא קיימות שאלות למבחן זה");
            }
            questions.RemoveAll(questionr => questionr.TestIdQuastionJ != t.TestIdJ);

            return questions;
        }



        private void Previous_Click(object sender, EventArgs e)
        {

            if (index == 0 || questions.Count() == 0)
            {
                MessageBox.Show("Invalid");
            }
            else
            {
                index--;
                q = questions[index];
                Description.Text = q.DescriptionJ.ToString();
                string selectedOption = q.QuestionTypeJ.ToString();

                switch (selectedOption)
                {
                    // yes/no

                    case "MultipleChoice":
                        checkBox1.Visible = true;
                        checkBox1.Text = q.OptionsJ[0].ToString();
                        checkBox2.Visible = true;
                        checkBox2.Text = q.OptionsJ[1].ToString();
                        checkBox3.Visible = true;
                        checkBox3.Text = q.OptionsJ[2].ToString();
                        checkBox4.Visible = true;
                        checkBox4.Text = q.OptionsJ[3].ToString();



                        break;
                    case "AmericanQuestion":
                        checkBox1.Visible = true;
                        checkBox1.Text = q.OptionsJ[0].ToString();
                        checkBox2.Visible = true;
                        checkBox2.Text = q.OptionsJ[1].ToString();
                        checkBox3.Visible = true;
                        checkBox3.Text = q.OptionsJ[2].ToString();
                        checkBox4.Visible = true;
                        checkBox4.Text = q.OptionsJ[3].ToString();

                        break;
                    case "yes/no":

                        checkBox1.Visible = true;
                        checkBox1.Text = q.OptionsJ[0].ToString();
                        checkBox2.Visible = true;
                        checkBox2.Text = q.OptionsJ[1].ToString();
                        checkBox3.Visible = false;
                        checkBox4.Visible = false;

                        break;

                    default:
                        break;
                }

            }
        }

        private void Next_Click(object sender, EventArgs e)
        {

            if (index + 1 == questions.Count() || questions.Count() == 0)
            {
                MessageBox.Show("Invalid");

            }
            else
            {
                index++;
                q = questions[index];
                Description.Text = q.DescriptionJ.ToString();
                string selectedOption = q.QuestionTypeJ.ToString();

                switch (selectedOption)
                {
                    // yes/no

                    case "MultipleChoice":
                        checkBox1.Visible = true;
                        checkBox1.Text = q.OptionsJ[0].ToString();
                        checkBox2.Visible = true;
                        checkBox2.Text = q.OptionsJ[1].ToString();
                        checkBox3.Visible = true;
                        checkBox3.Text = q.OptionsJ[2].ToString();
                        checkBox4.Visible = true;
                        checkBox4.Text = q.OptionsJ[3].ToString();



                        break;
                    case "AmericanQuestion":
                        checkBox1.Visible = true;
                        checkBox1.Text = q.OptionsJ[0].ToString();
                        checkBox2.Visible = true;
                        checkBox2.Text = q.OptionsJ[1].ToString();
                        checkBox3.Visible = true;
                        checkBox3.Text = q.OptionsJ[2].ToString();
                        checkBox4.Visible = true;
                        checkBox4.Text = q.OptionsJ[3].ToString();

                        break;
                    case "yes/no":

                        checkBox1.Visible = true;
                        checkBox1.Text = q.OptionsJ[0].ToString();
                        checkBox2.Visible = true;
                        checkBox2.Text = q.OptionsJ[1].ToString();
                        checkBox3.Visible = false;
                        checkBox4.Visible = false;

                        break;

                    default:
                        break;
                }

            }
        }

        private void Description_Click(object sender, EventArgs e) { }

        private void representQuestion_Load_1(object sender, EventArgs e)
        {
            if (questions.Count() == 0)
            {
                MessageBox.Show("There are no questions in the test");
                return;
            }
            else
            {
                q = questions[index];
                Description.Text = q.DescriptionJ.ToString();
                int numoptions = q.OptionsJ.Count();


                string selectedOption = q.QuestionTypeJ.ToString();

                switch (selectedOption)
                {
                    // yes/no

                    case "MultipleChoice":
                        checkBox1.Visible = true;
                        checkBox1.Text = q.OptionsJ[0].ToString();
                        checkBox2.Visible = true;
                        checkBox2.Text = q.OptionsJ[1].ToString();
                        checkBox3.Visible = true;
                        checkBox3.Text = q.OptionsJ[2].ToString();
                        checkBox4.Visible = true;
                        checkBox4.Text = q.OptionsJ[3].ToString();



                        break;
                    case "AmericanQuestion":
                        checkBox1.Visible = true;
                        checkBox1.Text = q.OptionsJ[0].ToString();
                        checkBox2.Visible = true;
                        checkBox2.Text = q.OptionsJ[1].ToString();
                        checkBox3.Visible = true;
                        checkBox3.Text = q.OptionsJ[2].ToString();
                        checkBox4.Visible = true;
                        checkBox4.Text = q.OptionsJ[3].ToString();

                        break;
                    case "yes/no":

                        checkBox1.Visible = true;
                        checkBox1.Text = q.OptionsJ[0].ToString();
                        checkBox2.Visible = true;
                        checkBox2.Text = q.OptionsJ[1].ToString();
                        checkBox3.Visible = false;
                        checkBox4.Visible = false;

                        break;

                    default:
                        break;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
    

        private void Finish_Click(object sender, EventArgs e)
        {
            if ((questions.Count() - countAnswers) == 0)
            {
                FinishTExam f = new FinishTExam(T, score, ifCorrect, studentsAnswers, questions);
                f.Show();
                this.Hide();
            }
            if (finish == false)
            {
                if (countAnswers != questions.Count())
                {
                    MessageBox.Show("Do you want to finish? you  did not answered on: " + (questions.Count() - countAnswers) + " questions yet");
                    finish = true;
                }
            }
            else
            {
                FinishTExam f = new FinishTExam(T, score, ifCorrect, studentsAnswers, questions);
                f.Show();
                this.Hide();
                finish = false;

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) { }
   

        private void HomePage_Click(object sender, EventArgs e)
        {
            Teacher t = new Teacher();
            t.Show();
            this.Hide();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            int mulChoiceIndex = 0;
            if (checkBox1.Checked)
            {
                if (checkBox1.Text == questions[index].CorrectAnswerJ[0].ToString())
                //if (checkBox1.Text == q.CorrectAnswerJ.ToString())
                {
                    score += q.ScoreJ;
                    ifCorrect[index] = true;

                }
                //studentsAnswers[index] = checkBox1.Text;
                studentsAnswers[index][mulChoiceIndex] = checkBox1.Text;
                mulChoiceIndex++;

            }


            else if (checkBox2.Checked)
            {
                if (checkBox2.Text == questions[index].CorrectAnswerJ[0].ToString())
                {
                    score += q.ScoreJ;
                    ifCorrect[index] = true;
                    studentsAnswer[index] = q.DescriptionJ.ToString();
                }
                studentsAnswers[index][mulChoiceIndex] = checkBox2.Text;
                mulChoiceIndex++;
            }

            else if (checkBox3.Checked)
            {
                if (checkBox3.Text == questions[index].CorrectAnswerJ[0].ToString())
                {
                    score += q.ScoreJ;
                    ifCorrect[index] = true;
                    studentsAnswer[index] = q.DescriptionJ.ToString();

                }
                studentsAnswers[index][mulChoiceIndex] = checkBox3.Text;
                mulChoiceIndex++;
            }

            else if (checkBox4.Checked)
            {
                if (checkBox4.Text == questions[index].CorrectAnswerJ[0].ToString())
                {
                    score += q.ScoreJ;
                    ifCorrect[index] = true;
                    studentsAnswer[index] = q.DescriptionJ.ToString();
                }
                studentsAnswers[index][mulChoiceIndex] = checkBox4.Text;
                mulChoiceIndex++;
            }
            else
            {
                ifCorrect[index] = false;
                if (studentsAnswer != null) { studentsAnswer[index] = q.DescriptionJ.ToString(); }
                else { MessageBox.Show("check"); }
            }

            countAnswers++;
            label1.Text = countAnswers.ToString();
            if (index + 1 == questions.Count() || questions.Count() == 0)
            {
                FinishTExam f = new FinishTExam(T, score, ifCorrect, studentsAnswers, questions);
                f.Show();
                this.Hide();
            }
            else
            {
                index++;
                q = questions[index];
                Description.Text = q.DescriptionJ.ToString();
                string selectedOption = q.QuestionTypeJ.ToString();

                switch (selectedOption)
                {
                    case "MultipleChoice":
                        checkBox1.Visible = true;
                        checkBox1.Text = q.OptionsJ[0].ToString();
                        checkBox2.Visible = true;
                        checkBox2.Text = q.OptionsJ[1].ToString();
                        checkBox3.Visible = true;
                        checkBox3.Text = q.OptionsJ[2].ToString();
                        checkBox4.Visible = true;
                        checkBox4.Text = q.OptionsJ[3].ToString();



                        break;
                    case "AmericanQuestion":
                        checkBox1.Visible = true;
                        checkBox1.Text = q.OptionsJ[0].ToString();
                        checkBox2.Visible = true;
                        checkBox2.Text = q.OptionsJ[1].ToString();
                        checkBox3.Visible = true;
                        checkBox3.Text = q.OptionsJ[2].ToString();
                        checkBox4.Visible = true;
                        checkBox4.Text = q.OptionsJ[3].ToString();

                        break;
                    case "yes/no":

                        checkBox1.Visible = true;
                        checkBox1.Text = q.OptionsJ[0].ToString();
                        checkBox2.Visible = true;
                        checkBox2.Text = q.OptionsJ[1].ToString();
                        checkBox3.Visible = false;
                        checkBox4.Visible = false;

                        break;

                    default:
                        break;
                }

            }
        }

        private void HomePage_Click_1(object sender, EventArgs e)
        {
            Teacher t = new Teacher();
            t.Show();
            this.Hide();
        }

        private void label1_Click_1(object sender, EventArgs e) { }      
    }

}







