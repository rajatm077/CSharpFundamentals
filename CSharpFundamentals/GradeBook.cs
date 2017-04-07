using Grades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades {

    public class GradeBook {
        List<float> grades;
        string _name;

        public event NameChangedDelegate NameChanged;

        public string Name {
            get {
                return _name;
            }
            set {
                if (!String.IsNullOrEmpty(value)) {
                    if (_name != value) {
                        NameChangedEventArgs args = new NameChangedEventArgs();
                        args.ExistingName = _name;
                        args.NewName = value;                                                    
                        NameChanged(this, args); 
                    }
                    _name = value;
                }
            }
        }

        public GradeBook() {
            grades = new List<float>();
            _name = "Empty";
        }

        public void AddGrade(float grade) {
            grades.Add(grade);
        }

        public GradeStatistics ComputeStatistics() {
            GradeStatistics stats = new GradeStatistics();

            float sum = 0;

            foreach (float item in grades) {
                sum += item;
            }

            stats.AverageGrade = sum / grades.Count;
            grades.Sort();
            stats.LowestGrade = grades[0];
            stats.HighestGrade = grades[grades.Count - 1];

            return stats;
        }

        
        public void WriteGrade(TextWriter destination) {
            foreach (var grade in grades) {
                destination.WriteLine(grade);
            }
        }

        public override string ToString() {
            return "GradeBook.cs";
        }
    }
}