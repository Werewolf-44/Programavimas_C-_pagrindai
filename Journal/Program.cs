using System;
using System.Collections.Generic;
using System.Linq;

namespace Journal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            Student student1 = new Student("John", "Smith");
            Student student2 = new Student("Jane", "White");
            Student student3 = new Student("Michael", "Scott");

            students.Add(student1);
            students.Add(student2);
            students.Add(student3);

            Journal journal = new Journal(students);
            journal.SubmitGrades("Math", student1, new List<double> { 10, 30, 25 });
        }
    }

    class Journal
    {
        List<Student> Students;
        public Journal(List<Student> students)
        {
            Students = students;
        }

        public void SubmitGrades(string lecture, Student student, List<double> grades)
        {
            bool studentFound = false;
            foreach (Student s in Students)
            {
                if (s.Name == student.Name && s.LastName == student.LastName)
                {
                    studentFound = true;
                    bool lectureFound = false;
                    foreach (LectureGrades lg in s.Grades)
                    {
                        if (lg.Lecture == lecture)
                        {
                            lectureFound = true;
                            lg.Grades.AddRange(grades);
                            Console.WriteLine($"Added grades to existing grades for student {s.Name} {s.LastName} in lecture {lecture}");
                            break;
                        }
                    }
                    if (!lectureFound)
                    {
                        LectureGrades newLectureGrades = new LectureGrades(lecture, grades);
                        s.Grades.Add(newLectureGrades);
                        Console.WriteLine($"Added new grades for student {s.Name} {s.LastName} in lecture {lecture}");
                    }
                }
            }
            if (!studentFound)
            {
                Console.WriteLine("There is no such student");
            }
        }
    }

    class Student
    {
        public string Name;
        public string LastName;
        public List<LectureGrades> Grades;

        public Student(string name, string lastname)
        {
            Name = name;
            LastName = lastname;
            Grades = new List<LectureGrades>();
        }
    }

    class LectureGrades
    {
        public string Lecture;
        public List<double> Grades;
        public LectureGrades(string lecture, List<double> grades)
        {
            Lecture = lecture;
            Grades = grades;
        }

        public double Average()
        {
            return Grades.Average();
        }
    }
}
