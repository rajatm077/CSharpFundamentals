using System;
using System.IO;
using System.Speech.Synthesis;

namespace Grades {
    public class Program {
        static void Main(string[] args) {
            
            GradeBook gradeBook = new GradeBook();
            gradeBook.NameChanged += OnNameChanged;
            gradeBook.NameChanged += OnSecondNameChanged;
            gradeBook.AddGrade(10);
            gradeBook.AddGrade(27.9f);
            gradeBook.AddGrade(40.7f);
            gradeBook.Name = "Rajat's book";

            //This class generates speech! cool!
            //SpeechSynthesizer synth = new SpeechSynthesizer();
            //synth.Speak("yo yo!");

            GradeStatistics stats = new GradeStatistics();
            stats = gradeBook.ComputeStatistics();
            using (StreamWriter outputFile = File.CreateText("grades.txt")) {
                gradeBook.WriteGrade(outputFile);
            }       

            //DateTime dt = new DateTime(2016, 4, 25);
            //DateTime dt2 = dt.AddDays(1);
            //Console.WriteLine(dt2);

            //string name = " rajat ";
            //name = name.Trim();
            //Console.WriteLine(name);

            //byte[] bytes = BitConverter.GetBytes(1);
            //foreach (var item in bytes) {
            //    Console.Write("0x{0:X2} ", item);
            //}
        }

        
        static void OnNameChanged(object sender, NameChangedEventArgs args) {
            Console.WriteLine($"Name changed from {args.ExistingName} to {args.NewName} by {sender.ToString()}");
        }

        static void OnSecondNameChanged(object sender, NameChangedEventArgs args) {
            Console.WriteLine($"Name changed second time from {args.ExistingName} to {args.NewName} by {sender.ToString()}");
        }
        

    }
}