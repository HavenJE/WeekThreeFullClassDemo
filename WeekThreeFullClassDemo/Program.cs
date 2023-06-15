// 3.9 Overloading operators

// Watch the following video for a complete program example to create a user-defined class with all important components
// including data fields, properties, constructors, methods in class and how to write an application that uses the
// user-defined class.

using WeekThreeFullClassDemo;

class Program
{
    static void Main()
    {
        // create student object (name of class, name of object is lowercase) 
        StudentApplicationDemo student1 = new StudentApplicationDemo();
        // to check the student attributes values
        Console.WriteLine("Student ID is: {0}, and name is: {1}. Course name is {2}", student1.StudentID, student1.StudentName, student1.CourseName );
        // The above line will display "Student ID is: 0, and name is: . Course name is" because we have not assign the values for this data field

        // To assign the values for the data fields, we do: 
        student1.StudentID = 123;
        student1.CourseName = "Haven";
        student1.CourseName = "Object oriented programming";

        // To use constructor to create object 
        StudentApplicationDemo student2 = new StudentApplicationDemo(111, "Lisa", "Business design & Analysis");
        StudentApplicationDemo student3 = new StudentApplicationDemo(222, "Sam", " "); // even when courseName is left empty, it will be filled by (courseName = "Data Analysis";) that has been set in the StudentApplicationDemo constructor.
        // Console.WriteLine("Student1 ID is: {0}, and name is: {1}. Course name is {2}", student1.StudentID, student1.StudentName, student1.CourseName);
        // Console.WriteLine("Student2 ID is: {0}, and name is: {1}. Course name is {2}", student2.StudentID, student2.StudentName, student2.CourseName);
        // Console.WriteLine("Student3 ID is: {0}, and name is: {1}. Course name is {2}", student3.StudentID, student3.StudentName, student3.CourseName);

        Console.WriteLine("Student 1 information:");
        student1.DisplayInformation();

        Console.WriteLine("Student 2 information:");
        student2.DisplayInformation();

        Console.WriteLine("Student 3 information:");
        student3.DisplayInformation();
    }
}