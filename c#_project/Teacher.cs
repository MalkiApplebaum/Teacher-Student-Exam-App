namespace c__Project
{
    public partial class Teacher : BaseForm
    {
        public static List<TestJ> tests = new List<TestJ>();
        public Teacher()
        {
            InitializeComponent();

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Edit_Test et = new Edit_Test();
            et.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Exam E = new Exam();
            E.Show();
            this.Hide();
        }
        private void Form1_Load(object sender, EventArgs e) { }
        private void Teacher_Load(object sender, EventArgs e) { }
 
    }
}