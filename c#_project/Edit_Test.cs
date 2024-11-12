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

namespace c__Project
{
    public partial class Edit_Test : BaseForm
    {
        public Edit_Test()
        {
            InitializeComponent();
        }
        private void button2_Click_2(object sender, EventArgs e)
        {
            question nt = new question();
            nt.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SelectTest st = new SelectTest();
            st.Show();
            this.Hide();
        }

        private void HomePage_Click(object sender, EventArgs e)
        {
            Teacher t = new Teacher();
            t.Show();
            this.Hide();
        }

        private void Edit_Test_Load(object sender, EventArgs e) { }
  
    }
}

