using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace c__Project
{

    public partial class Questions : BaseForm
    {
        int Precents = 0;
        private string description;
        private string? questionType;
        private List<string> options;
        private List<string> correctAnswer;

        private object value;
        private int score;

        QuestionJ q = new QuestionJ();
        TestJ Test = new TestJ();
        public object questions { get; private set; }
        public int TestIdQuastion { get; private set; }

        public Questions(TestJ test)
        {
            InitializeComponent();
            TestIdQuastion = test.TestIdJ;

        }
        public Questions(string description, string? questionType, List<string> options, List<string> correctAnswer, object value, int score)
        {
            this.description = description;
            this.questionType = questionType;
            this.options = options;
            this.correctAnswer = correctAnswer;
            this.value = value;
            this.score = score;

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
       }
        private void Questions_Load(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void Questions_Load_1(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = QuestionType.SelectedItem.ToString();

            switch (selectedOption)
            {
                // yes/no

                case "MultipleChoice":

                    textBox7.Visible = true;
                    TheRealAnswer.Visible = true;
                    //TheRealAnswer1.Visible = true;

                    break;
                case "AmericanQuestion":

                    //textBox3.Visible = false;
                    //textBox4.Visible = true;
                    //textBox5.Visible = true;
                    //textBox6.Visible = true;
                    textBox7.Visible = true;
                    TheRealAnswer.Visible = true;
                    //TheRealAnswer1.Visible = false;

                    break;
                case "yes/no":


                    TheRealAnswer.Visible = true;
                    // textBox7.Text.Equals("yes,no");
                    textBox7.Visible = true;

                    break;

                default:
                    break;
            }
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private void TheRealAnswer_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Test.ScoreJ != 100)
            {
                Test.isActiveJ = false;
                MessageBox.Show("You haven't scored 100 percent yet");


                Teacher t = new Teacher();
                t.Show();
                this.Hide();
            }
            else
            {
                Test.isActiveJ = true;
                MessageBox.Show("The test was successfully saved");





                //string filePath = "tests.json";
                //// נתיב לקובץ ה-JSON
                ////string filePath = "question.json";

                //// בדיקה האם הקובץ קיים
                //if (!File.Exists(filePath))
                //{
                //    // יצירת רשימה ריקה
                //    var newData = new List<QuestionJ>();

                //    // המרה של הרשימה למחרוזת JSON
                //    string jsonContent = JsonConvert.SerializeObject(newData);

                //    // שמירת המחרוזת בקובץ
                //    File.WriteAllText(filePath, jsonContent);
                //}

                //// קריאת התוכן של הקובץ
                //string jsonContentExisting = File.ReadAllText(filePath);

                //// פרקום את ה-JSON לרשימה של אובייקטי QuestionJ
                //var existingData = JsonConvert.DeserializeObject<List<QuestionJ>>(jsonContentExisting);


                ////string filePath = "question.json";
                ////string read = File.ReadAllText(filePath);


                //// Deserialize the modified JSON data
                ////var existingData = JsonConvert.DeserializeObject<List<QuestionJ>>(jsonArray.ToString());
                //// var existingData = JsonConvert.DeserializeObject<List<QuestionJ>>(read);

                //if (existingData == null)
                //    existingData = new List<QuestionJ>();
                //existingData.Add(q);

                //// Serialize the updated data and
                ////
                //// save to file
       









                //string updatedJson = JsonConvert.SerializeObject(existingData);
                //File.WriteAllText(filePath, updatedJson);
                //Console.WriteLine("השאלה נוספה בהצלחה!");
                //Teacher t = new Teacher();
                //t.Show();
                //this.Hide();
                ////להעביר לדף סיום מבחן

            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }
        //private void saveQuastion_Click(object sender, EventArgs e, TestJ test)
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

            q.CorrectAnswerJ = TheRealAnswer.Text.Split(',').ToList();
            q.DescriptionJ = QuestionDescription.Text;
            q.OptionsJ = textBox7.Text.Split(',').ToList();
            q.QuestionTypeJ = QuestionType.SelectedItem.ToString();
            q.ScoreJ = Convert.ToInt32(numericUpDown1.Value);


            ////הוספת הניקוד לניקוד הכללי של המבחן


            //string filePathtest = "tests.json";

            //if (!File.Exists(filePathtest))
            //{
            //    var newtestlist = new List<TestJ>();
            //    string jsonContenttest = JsonConvert.SerializeObject(newtestlist);
            //    File.WriteAllText(filePathtest, jsonContenttest);
            //}

            //string jsonContentExistingtest = File.ReadAllText(filePathtest);

            //// פרקום את ה-JSON לרשימה של אובייקטי QuestionJ
            //var existingDatatest = JsonConvert.DeserializeObject<List<TestJ>>(jsonContentExistingtest);

            //Test.ScoreJ += Convert.ToInt32(numericUpDown1.Value);

            //if (existingDatatest == null)
            //    existingDatatest = new List<TestJ>();
            ////existingDatatest.Add(q);


            //// save to file
            //string updatedJsontest = JsonConvert.SerializeObject(existingDatatest);
            //File.WriteAllText(filePathtest, updatedJsontest);

            Test.ScoreJ += Convert.ToInt32(numericUpDown1.Value);
            q.TestIdQuastionJ = TestIdQuastion;


            //string filePath = "question.json";
            ////var list = new List<QuestionJ>();
            ////list.Add(q);
            //string read = File.ReadAllText(filePath);
            //// Deserialize the existing JSON content into a List of objects


            //var existingData = JsonConvert.DeserializeObject<List<QuestionJ>>(read);
            //if (existingData == null)
            //    existingData = new List<QuestionJ>();
            //// Add new data to the existing list
            //existingData.Add(q);
            //string json = JsonConvert.SerializeObject(existingData);
            //File.WriteAllText(filePath, json);
            //Console.WriteLine("Data has been written to data.json");

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


            //string filePath = "question.json";
            //string read = File.ReadAllText(filePath);


            // Deserialize the modified JSON data
            //var existingData = JsonConvert.DeserializeObject<List<QuestionJ>>(jsonArray.ToString());
            // var existingData = JsonConvert.DeserializeObject<List<QuestionJ>>(read);

            if (existingData == null)
                existingData = new List<QuestionJ>();
            existingData.Add(q);

            // Serialize the updated data and
            //
            // save to file
            string updatedJson = JsonConvert.SerializeObject(existingData);
            File.WriteAllText(filePath, updatedJson);
            Console.WriteLine("השאלה נוספה בהצלחה!");





            // סיום יצירת השאלה
            MessageBox.Show("Question created successfully");

            // Clear the fields
            QuestionDescription.Text = "";
            QuestionType.SelectedItem = null;
            textBox7.Text = "";
            TheRealAnswer.Text = "";
            numericUpDown1.Value = 0;
            q.TestIdQuastionJ = 0;

        }



        private void UpdateScore_Click(object sender, EventArgs e)
        {
            progressBar2.Step += Convert.ToInt32(numericUpDown1.Value);
            progressBar2.PerformStep();

        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Precents += Convert.ToInt32(numericUpDown1.Value);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TheRealAnswer_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void QuestionDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void QuestionType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void TheRealAnswer_TextChanged_2(object sender, EventArgs e)
        {
        }


        private void progressBar2_Click(object sender, EventArgs e)
        {
        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
        }


        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void QuestionType1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void Questions_Load_2(object sender, EventArgs e)
        {

        }

        private void HomePage_Click(object sender, EventArgs e)
        {
            Teacher t = new Teacher();
            t.Show();
            this.Hide();
        }

        private void Questions_Load_3(object sender, EventArgs e)
        {

        }
    }
}