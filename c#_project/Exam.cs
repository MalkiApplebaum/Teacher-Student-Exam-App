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

namespace c__Project
{
    public partial class Exam : BaseForm
    {
        public Exam()
        {
            InitializeComponent();
            tests = ReadTestFromJson();
        }
        public TestJ T { get; set; }
        public List<TestJ> tests { get; set; }

        private List<TestJ> ReadTestFromJson()
        {
            List<TestJ> tests = new List<TestJ>();

            try
            {
                string filePathTest = "tests.json";
                string read = File.ReadAllText(filePathTest);
                tests = JsonConvert.DeserializeObject<List<TestJ>>(read);
                var s = " ";
                tests.RemoveAll(test => test.isActiveJ != true);
                foreach (TestJ test in tests)
                    AllActiveTests.Items.Add(test.nameJ + s);
            }
            catch
            {
                MessageBox.Show("לא קיימים מבחנים במערכת");
            }
            return tests;
        }
        private void ChooseTest_Click(object sender, EventArgs e)
        {
            if (AllActiveTests.SelectedItem == null)
            {
                MessageBox.Show("no item was selected");
            }
            else
            {
                string TestToEdit = AllActiveTests.SelectedItem.ToString();
                foreach (var i in tests)
                {
                    if (TestToEdit == i.nameJ + " ")
                    {
                        T = i;
                        break;
                    }
                }
                representQuestion r = new representQuestion(T);
                r.Show();
                this.Hide();

            }
        }
        private void Exam_Load(object sender, EventArgs e) { }
        private void AllActiveTests_SelectedIndexChanged(object sender, EventArgs e) { }
        private void HomePage_Click(object sender, EventArgs e)
        {
            Teacher t = new Teacher();
            t.Show();
            this.Hide();
        }
    }
}
























//private void radioButton1_CheckedChanged(object sender, EventArgs e)
//{

//}


