
using Newtonsoft.Json;
using System.IO;

namespace c__Project
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            
            Application.Run(new Teacher());
            //string json = JsonConvert.SerializeObject(exam);
            //File.WriteAllText("exam.json", json);
        }
    }
}