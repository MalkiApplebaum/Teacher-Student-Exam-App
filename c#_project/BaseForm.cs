using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Project
{
    public class BaseForm : Form
    {
        public BaseForm()
        {
            // הגדרת תמונת הרקע
            this.BackgroundImage = Image.FromFile("D:\\Users\\The user\\Desktop\\‏‏תיקיה חדשה\\c#_project\\c#_project\\Resources\\background.png");
            this.BackgroundImageLayout = ImageLayout.Stretch; // מתיחה להתאמה לגודל הפורם
        }
    }
}
