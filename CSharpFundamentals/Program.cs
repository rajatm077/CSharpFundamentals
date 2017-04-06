using System;
using System.Speech.Synthesis;

namespace CSharpFundamentals {
    public class Program {
        static void Main(string[] args) {
            //Console.WriteLine("Hours: ");
            //int hours = Convert.ToInt32(Console.ReadLine());
            //int hours = int.Parse(Console.ReadLine());
            //if (hours < 8) {
            //    Console.WriteLine("Sleep more!");
            //} else {
            //    Console.WriteLine("Lucky bastard..");
            //}

            GradeBook gradeBook = new GradeBook();
            gradeBook.AddGrade(90);
            gradeBook.AddGrade(97.9f);
            gradeBook.AddGrade(70.7f);

            //This class generates speech! cool!
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("Yo yo!"); 

            GradeStatistics stats = new GradeStatistics();
            stats = gradeBook.ComputeStatistics();
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.LowestGrade);
            Console.WriteLine(stats.AverageGrade);
        }
    }
}