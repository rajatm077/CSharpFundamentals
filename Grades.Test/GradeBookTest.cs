using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grades;

namespace Grades.Test {
    [TestClass]
    public class GradeBookTest {
        [TestMethod]
        public void ComputeHighestGrade() {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(80);
            GradeStatistics stats = book.ComputeStatistics();
            Assert.AreEqual(80, stats.HighestGrade);
        }

        [TestMethod]
        public void ComputeAverageGrade() {
            
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(30.5f);
            book.AddGrade(80);
            GradeStatistics stats = book.ComputeStatistics();
            Assert.AreEqual(39.9, stats.AverageGrade, 0.5);
        }

        [TestMethod]
        public void StringComparisons() {
            // string is a reference type!
            // string is created in heap and s1 is assigned to new memory location.
            string s1 = "Rajat";
            string s2 = s1;
            s1 = "Raj";
            Assert.AreNotEqual(s1, s2);

        }
        [TestMethod]
        public void StringComparisons2() {
            // string is a reference type!
            // string is created in heap and s1 is assigned to new memory location.
            string s1 = "Rajat";
            string s2 = "rAjAT";
            bool areEqual = String.Equals(s1, s2, StringComparison.InvariantCultureIgnoreCase);
            Assert.AreNotEqual(s1, s2);
        }

        [TestMethod]
        public void ReferenceComparison() {
            GradeBook g = new GradeBook();
            g.AddGrade(10);
            checkReference(g);
            GradeStatistics stats = g.ComputeStatistics();
            Assert.AreEqual(20, stats.HighestGrade);
            
        }

        private void checkReference(GradeBook g) {
            g.AddGrade(20);
        }
    }
}
