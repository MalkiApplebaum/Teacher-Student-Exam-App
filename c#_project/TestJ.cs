
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Project
{
   
    public class TestJ
    {
       // public List<QuestionJ> questionsJ { get; set; }
        public string nameJ { get; set; }
        public Boolean isActiveJ { get; set; }

        public int TestIdJ { get; set; }

        public int  ScoreJ { get; set; }

    public TestJ()
        {
            nameJ = "";
            isActiveJ = false;
            //TestIdJ = Guid.NewGuid().GetHashCode();
            TestIdJ = Guid.NewGuid().GetHashCode();
            ScoreJ = 0;

        }
    }

}
