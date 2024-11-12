using c__Project;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.Design.AxImporter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace c__Project
{
    public partial class ExistingQuestion : BaseForm
    {
        public ExistingQuestion(string EditQuestion, TestJ t)
        {
            InitializeComponent();
            qd = EditQuestion;
            T = t;

        }
        public string qd { get; set; }
        public TestJ T { get; set; }
        private void ExistingQuestion_Load(object sender, EventArgs e)
        {
            string filePathQuestion = "question.json";
            string read = File.ReadAllText(filePathQuestion);
            List<QuestionJ> questions = JsonConvert.DeserializeObject<List<QuestionJ>>(read);
            // questions.Remove(questions.Find(item => item.DescriptionJ == qd && item.TestIdQuastionJ == T.TestIdJ));

            QuestionJ qs = questions.Find(item => item.DescriptionJ == qd && item.TestIdQuastionJ == T.TestIdJ);

            QuestionDescription.Text = qs.DescriptionJ;
            QuestionType.SelectedItem = qs.QuestionTypeJ;

            ////////////////////////////////////////////////////להוריד פסיק אחרון
            numericUpDown1.Value = qs.ScoreJ;
            string AllOptions = "";
            for (int i = 0; i < qs.OptionsJ.Count; i++)
            {
                AllOptions += qs.OptionsJ[i];
                AllOptions += ",";
            }
            textBox7.Text = AllOptions;


            string CorrectAnswer = "";
            for (int i = 0; i < qs.CorrectAnswerJ.Count; i++)
            {
                CorrectAnswer += qs.CorrectAnswerJ[i];
                CorrectAnswer += ",";
            }
            TheRealAnswer.Text = CorrectAnswer;

        }

        private void saveQuastion_Click(object sender, EventArgs e)
        {
            // וידוא של תיאור השאלה
            if (string.IsNullOrEmpty(QuestionDescription.Text))
            {
                MessageBox.Show("Please enter a question description");
                return;
            }

            // וידוא של סוג השאלה
            if (QuestionType.SelectedItem == null)
            {
                MessageBox.Show("Please select a question type");
                return;
            }

            // וידוא של אופציות התשובה
            string[] options = textBox7.Text.Split(',');
            if (options.Length < 2)
            {
                MessageBox.Show("Please enter at least 2 options for the answer");
                return;
            }

            // וידוא של התשובה עצמה
            string answer = TheRealAnswer.Text;
            switch (QuestionType.SelectedItem.ToString())
            {
                case "Yes/No":
                    if (answer != "Yes" && answer != "No")
                    {
                        MessageBox.Show("Please enter a valid answer (Yes or No)");
                        return;
                    }
                    break;
                case "Multiple Choice":
                    if (!options.Contains(answer))
                    {
                        MessageBox.Show("Please enter a valid answer from the options");
                        return;
                    }
                    break;
                    // ניתן להוסיף וידוא נוסף עבור סוגי שאלות נוספים
            }

            // וידוא של הניקוד
            int totalScore = 0;
            if (QuestionType.SelectedItem.ToString() == "Multiple Choice")
            {
                totalScore = 100 / options.Length;
            }
            else
            {
                totalScore = 100;
            }

            string filePathQuestion = "question.json";
            string read = File.ReadAllText(filePathQuestion);
            List<QuestionJ> questions = JsonConvert.DeserializeObject<List<QuestionJ>>(read);
            QuestionJ qs = questions.Find(item => item.DescriptionJ == qd && item.TestIdQuastionJ == T.TestIdJ);

            questions.Remove(questions.Find(item => item.DescriptionJ == qd && item.TestIdQuastionJ == T.TestIdJ));
            string updatedJson = JsonConvert.SerializeObject(questions);
            File.WriteAllText(filePathQuestion, updatedJson);

            qs.CorrectAnswerJ = TheRealAnswer.Text.Split(',').ToList();
            qs.DescriptionJ = QuestionDescription.Text;
            qs.OptionsJ = textBox7.Text.Split(',').ToList();
            qs.QuestionTypeJ = QuestionType.SelectedItem.ToString();
            qs.ScoreJ = Convert.ToInt32(numericUpDown1.Value);

            //qs.TestIdQuastionJ = TestIdQuastion;



            string filePath = "question.json";
            // נתיב לקובץ ה-JSON
            //string filePath = "question.json";

            // בדיקה האם הקובץ קיים
            if (!File.Exists(filePath))
            {
                // יצירת רשימה ריקה
                var newData = new List<QuestionJ>();

                // המרה של הרשימה למחרוזת JSON
                string jsonContent = JsonConvert.SerializeObject(newData);

                // שמירת המחרוזת בקובץ
                File.WriteAllText(filePath, jsonContent);
            }

            // קריאת התוכן של הקובץ
            string jsonContentExisting = File.ReadAllText(filePath);

            // פרקום את ה-JSON לרשימה של אובייקטי QuestionJ
            var existingData = JsonConvert.DeserializeObject<List<QuestionJ>>(jsonContentExisting);

            if (existingData == null)
                existingData = new List<QuestionJ>();
            existingData.Add(qs);

            // Serialize the updated data and
            //
            // save to file
            updatedJson = JsonConvert.SerializeObject(existingData);
            File.WriteAllText(filePath, updatedJson);


            // סיום יצירת השאלה
            MessageBox.Show("Question created successfully");

            ShowQuestionsToEdit sq = new ShowQuestionsToEdit(T);
            sq.Show();
            this.Hide();



        }

        private void UpdateScore_Click(object sender, EventArgs e)
        {
            progressBar2.Step += Convert.ToInt32(numericUpDown1.Value);
            progressBar2.PerformStep();
        }

        private void HomePage_Click(object sender, EventArgs e)
        {
            Teacher t = new Teacher();
            t.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (T.ScoreJ != 100)
            {
                T.isActiveJ = false;
                MessageBox.Show("You haven't scored 100 percent yet");


                Teacher t = new Teacher();
                t.Show();
                this.Hide();
            }
            else
            {
                T.isActiveJ = true;
                MessageBox.Show("The test was successfully saved");
            }
        }
    }

}


