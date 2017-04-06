using System;
using System.Speech.Synthesis;

namespace Grades {
    public class Program {
        static void Main(string[] args) {
    
            GradeBook gradeBook = new GradeBook();
            gradeBook.AddGrade(90);
            gradeBook.AddGrade(97.9f);
            gradeBook.AddGrade(70.7f);

            //This class generates speech! cool!
            //SpeechSynthesizer synth = new SpeechSynthesizer();
            //synth.Speak("kashish chootiya hae!");
            
            //GradeStatistics stats = new GradeStatistics();
            //stats = gradeBook.ComputeStatistics();
            //Console.WriteLine(stats.HighestGrade);
            //Console.WriteLine(stats.LowestGrade);
            //Console.WriteLine(stats.AverageGrade);


            DateTime dt = new DateTime(2016, 4, 25);
            DateTime dt2 = dt.AddDays(1);
            Console.WriteLine(dt2);

            string name = " rajat ";
            name = name.Trim();
            Console.WriteLine(name);
        }
    }
}