using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace c__Project
{
    public partial class question : BaseForm
    {

        TestJ Test = new TestJ();
        public List<Questions> questions;
        public question()
        {
            InitializeComponent();
            questions = new List<Questions>();
        }
        private void TestName_TextChanged(object sender, EventArgs e) { }
        private void button1_Click_1(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void button2_Click(object sender, EventArgs e)
        {
            Test.nameJ = TestName.Text;

            Teacher.tests.Add(Test);
            Questions q = new Questions(Test);
            q.Show();
            this.Hide();

            if (Test.nameJ == "")
            {
                MessageBox.Show("A name must be entered in the test");
            }
            else
            {
                //string filePathTest = "D:\\Users\\The user\\Desktop\\c#_project\\tests.json";
                string filePathTest = "tests.json";

                // בדיקה האם הקובץ קיים
                if (!File.Exists(filePathTest))
                {
                    // יצירת רשימה ריקה
                    var newData = new List<TestJ>();

                    // המרה של הרשימה למחרוזת JSON
                    string jsonContent = JsonConvert.SerializeObject(newData);

                    // שמירת המחרוזת בקובץ
                    File.WriteAllText(filePathTest, jsonContent);
                }

                // קריאת התוכן של הקובץ
                string jsonContentExisting = File.ReadAllText(filePathTest);

                // פרקום את ה-JSON לרשימה של אובייקטי TestJ
                var existingData = JsonConvert.DeserializeObject<List<TestJ>>(jsonContentExisting);

                if (string.IsNullOrEmpty(jsonContentExisting))
                {
                    existingData = new List<TestJ>();
                }
                else
                {
                    JArray jsonArray1 = JArray.Parse(jsonContentExisting);
                    existingData = JsonConvert.DeserializeObject<List<TestJ>>(jsonArray1.ToString());
                    if (existingData == null)
                    {
                        existingData = new List<TestJ>();
                    }
                }

                // הוספת הנתונים החדשים לרשימה הקיימת
                existingData.Add(Test);

                string updatedJson1 = JsonConvert.SerializeObject(existingData);
                File.WriteAllText(filePathTest, updatedJson1);
                Console.WriteLine("המבחן נוסף בהצלחה!");



                // סיום יצירת המבחן
                MessageBox.Show("Test created successfully");

                // Clear the fields
                TestName.Text = "";
            }

        }

        private void TestName_TextChanged_1(object sender, EventArgs e) { }

        private void HomePage_Click(object sender, EventArgs e)
        {
            Teacher t = new Teacher();
            t.Show();
            this.Hide();
        }

        private void question_Load(object sender, EventArgs e) { }
    }
}