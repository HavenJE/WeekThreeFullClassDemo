using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekThreeFullClassDemo
{
    internal class StudentApplicationDemo
    {
        // Data fields or attributes
        private int studentID;
        private string studentName;
        private string courseName;

        // Properties 
        public int StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }

        public string StudentName
        {
            get { return courseName; }
            set { courseName = value; }
        }

        public string CourseName
        { 
            get { return courseName; }
            set { if (value.Length > 30) 
                    Console.WriteLine("Course name is too long!");
                else
                courseName = value;
                }
        }

        // Constructor - a name to create object, starting with public + name of class 
        public StudentApplicationDemo()
        {
            // this constructor is to eliminate the error on the constructor StudentApplicationDemo made over Program.cs
        }
        public StudentApplicationDemo(int id, string name, string course)
        {
            // Inside constructor body, we assign the attributes to the data types 
            studentID = id;
            studentName = name;
            courseName = "Data Analysis";
        }

        // Methods
        // We create methods to display information of the object 
        public void DisplayInformation()
        {
            Console.WriteLine("Student ID is: {0}, Student name is: {1}, Course name is: {2}", studentID, StudentName, CourseName);
        }
    }
}
