using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;

namespace c__Project
{


    public partial class SelectTest : BaseForm
    {

        public SelectTest()
        {
            InitializeComponent();
            ReadTestFromJson();
        }
        private void ReadTestFromJson()
        {

            try
            {
                string filePathTest = "tests.json";
                string read = File.ReadAllText(filePathTest);
                var list1 = JsonConvert.DeserializeObject<List<TestJ>>(read);
                var s = " ";
                foreach (var i in list1)
                {
                    checkedListBox1.Items.Add(i.nameJ + s);
                }

            }
            catch
            {
                MessageBox.Show("לא קיימים מבחנים במערכת");

            }

        }


        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e) { }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }


        private void SelectTest_Load(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        //מחיקת מבחן

        {
            if (checkedListBox1.SelectedItem == null)
            {
                MessageBox.Show("no item was selected");
            }
            else
            {
                string testRemove = checkedListBox1.SelectedItem.ToString();
                string filePathTest = "tests.json";
                string readTest = File.ReadAllText(filePathTest);
                var existingTests = JsonConvert.DeserializeObject<List<TestJ>>(readTest);

                foreach (var i in existingTests)
                {

                    if (i.nameJ + " " == testRemove)
                    {
                        TestJ t = i;

                        int id = t.TestIdJ;


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

                        var existingData = JsonConvert.DeserializeObject<List<QuestionJ>>(readQuestoins);

                        JArray jsonArray1 = JArray.Parse(readQuestoins);
                        existingData = JsonConvert.DeserializeObject<List<QuestionJ>>(jsonArray1.ToString());
                        if (existingData == null)
                        {
                            existingData = new List<QuestionJ>();
                        }
                        

                        existingData.RemoveAll(x => x.TestIdQuastionJ == id);
                        string updatedJson = JsonConvert.SerializeObject(existingData);
                        File.WriteAllText(filePathquestion, updatedJson);

                        // מציאת המבחן ברשימת המבחנים לפי השם שנבחר
                        var testToRemove = existingTests.FirstOrDefault(t => t.nameJ + " " == testRemove);

                        // בדיקה אם המבחן נמצא ומחיקתו
                        if (testToRemove != null)
                        {
                            // מחיקת המבחן מרשימת המבחנים
                            existingTests.Remove(testToRemove);

            
                        }

                        // ממיר את רשימת המבחנים למחרוזת JSON
                        string updatedTestsJson = JsonConvert.SerializeObject(existingTests);

                        // שמירת המחרוזת JSON לקובץ
                        File.WriteAllText(filePathTest, updatedTestsJson);


                        MessageBox.Show("yeeeehhh");
                        checkedListBox1.Items.Clear();
                        ReadTestFromJson();
                        break;

                    }

                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        //עריכת מבחן
        {
            if (checkedListBox1.SelectedItem == null)
            {
                MessageBox.Show("select a test");
            }
            else
            {
                string testEdit = checkedListBox1.SelectedItem.ToString();


                string filePathTest = "tests.json";
                string readTest = File.ReadAllText(filePathTest);
                var existingTests = JsonConvert.DeserializeObject<List<TestJ>>(readTest);
                TestJ t = new TestJ();

                foreach (var i in existingTests)
                {

                    if (i.nameJ + " " == testEdit)
                    {
                        t = i;

                        break;
                    }
                }


                ShowQuestionsToEdit sq = new ShowQuestionsToEdit(t);
                sq.Show();
                this.Hide();
                // }


            }
        }

        private void HomePage_Click(object sender, EventArgs e)
        {
            Teacher t = new Teacher();
            t.Show();
            this.Hide();
        }

        private void SelectTest_Load_1(object sender, EventArgs e) { }
   
    }
}
