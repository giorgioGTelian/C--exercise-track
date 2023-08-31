using System;

public class Program
{
    public static void Main()
    {
        string studentName = "Sophia Johnson";
        string course1Name = "English 101";
        string course2Name = "Algebra 101";
        string course3Name = "Biology 101";
        string course4Name = "Computer Science I";
        string course5Name = "Psychology 101";

        int course1Credit = 3;
        int course2Credit = 3;
        int course3Credit = 4;
        int course4Credit = 4;
        int course5Credit = 3;

        // Sample grades for each course
        int course1Grade = 4;
        int course2Grade = 3;
        int course3Grade = 3;
        int course4Grade = 3;
        int course5Grade = 4;

        // Calculate GPA
        float totalCredits = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;
        float totalGradePoints = course1Grade * course1Credit + course2Grade * course2Credit + course3Grade * course3Credit + course4Grade * course4Credit + course5Grade * course5Credit;
        float gpa = totalGradePoints / totalCredits;

        Console.WriteLine($"Student: {studentName}\n");
        Console.WriteLine($"Course                  Grade   Credit Hours");
        Console.WriteLine($"{course1Name.PadRight(25)} {course1Grade}       {course1Credit}");
        Console.WriteLine($"{course2Name.PadRight(25)} {course2Grade}       {course2Credit}");
        Console.WriteLine($"{course3Name.PadRight(25)} {course3Grade}       {course3Credit}");
        Console.WriteLine($"{course4Name.PadRight(25)} {course4Grade}       {course4Credit}");
        Console.WriteLine($"{course5Name.PadRight(25)} {course5Grade}       {course5Credit}\n");
        Console.WriteLine($"Final GPA:          {gpa:F2}");
    }
}
