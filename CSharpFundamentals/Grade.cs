using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals {
    class GradeBook {
        List<float> grades;

        public GradeBook() {
            grades = new List<float>();
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
    }
}