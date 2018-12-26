using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeBook
    {

        public GradeBook()
        {
            grades = new List<float>();
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();

            float sum = 0;
            foreach (float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }
            stats.AverageGrade = sum / grades.Count; //nincs lekezelve a 0
            return stats;
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        private List<float> grades = new List<float>();
    }
}

//a fájl neve az lesz, ami a classnak a neve
//members of the ...class: amik a class ...{} -on belül vannak
//class members: lehetnek state-k = amiket kap -> pl az AddGrade
    //és lehetnek behavior
//a grade az a scoped to the method, mert csak ott érhető el
//a field az a grades lesz