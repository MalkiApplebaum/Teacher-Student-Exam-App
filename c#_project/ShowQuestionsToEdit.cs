using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace c__Project
{

    public partial class ShowQuestionsToEdit : BaseForm
    {
        public ShowQuestionsToEdit(TestJ t)
        {
            InitializeComponent();
            ReadQuestionsFromJson(t);
            T = t;

        }
        public TestJ T { get; set; }
        private void ReadQuestionsFromJson(TestJ t)
        {
            try
            {
                string filePathQ = "tests.json";
                string readQ = File.ReadAllText(filePathQ);
                var listQ = JsonConvert.DeserializeObject<List<TestJ>>(readQ);
                //new FormSetExistTest().ShowDialog();
                var s = " ";
                foreach (var i in listQ)
                {

                    if (i.nameJ == t.nameJ)
                    {
                        TestJ T = i;

                        int id = T.TestIdJ;

                        string filePathquestion = "question.json";
                        // בדיקה האם הקובץ קיים
                        if (!File.Exists(filePathquestion))
                        {
                            // יצירת רשימה ריקה
                            var newData = new List<TestJ>();

                            // המרה של הרשימה למחרוזת JSON
                            string jsonContent = JsonConvert.SerializeObject(newData);

                            // שמירת המחרוזת בקובץ
                            File.WriteAllText(filePathquestion, jsonContent);
                        }

                        // קריאת התוכן של הקובץ
                        string readQuestoins = File.ReadAllText(filePathquestion);

                        // פרקום את ה-JSON לרשימה של אובייקטי TestJ
                        var existingData = JsonConvert.DeserializeObject<List<QuestionJ>>(readQuestoins);


                        JArray jsonArray1 = JArray.Parse(readQuestoins);
                        existingData = JsonConvert.DeserializeObject<List<QuestionJ>>(jsonArray1.ToString());
                        if (existingData == null)
                        {
                            existingData = new List<QuestionJ>();
                        }

                        foreach (var x in existingData)
                        {
                            if (x.TestIdQuastionJ == id)
                            {
                                listBox1.Items.Add(x.DescriptionJ);
                            }
                        }
                       ;

                    }
                }
            }
            catch
            {
                MessageBox.Show("not existing any questions");

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }


        private void button1_Click(object sender, EventArgs e) { }

        private void AddQuestion_Click(object sender, EventArgs e)
        {

            Questions q = new Questions(T);
            q.Show();
            this.Hide();
        }

        private void RemoveQuestion_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("no item was selected");
            }
            else
            {

                string questionRemove = listBox1.SelectedItem.ToString();
                string filePathQuestion = "question.json";
                string read = File.ReadAllText(filePathQuestion);
                List<QuestionJ> questions = JsonConvert.DeserializeObject<List<QuestionJ>>(read);
                questions.Remove(questions.Find(item => item.DescriptionJ == questionRemove && item.TestIdQuastionJ == T.TestIdJ));
                string jsonContent = JsonConvert.SerializeObject(questions);

                // שמירת המחרוזת בקובץ
                File.WriteAllText(filePathQuestion, jsonContent);
                listBox1.Items.Clear();
                ReadQuestionsFromJson(T);
            }

        }

        private void EditQuestion_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("no item was selected");
            }
            else
            {
                string questionToEdit = listBox1.SelectedItem.ToString();

                ExistingQuestion eq = new ExistingQuestion(questionToEdit, T);
                eq.Show();
                this.Hide();

            }

        }
        private void HomePage_Click(object sender, EventArgs e)
        {
            Teacher t = new Teacher();
            t.Show();
            this.Hide();

        }

        private void ShowQuestionsToEdit_Load(object sender, EventArgs e) { }
  
    }
}


