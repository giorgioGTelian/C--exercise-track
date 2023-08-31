/*  COOLER SOLUTION */
/*
using System;

public class Program
{
    public static void Main()
    {
        int currentAssignments = 5;

        // Sophia's grades and average
        int sophia1 = 93, sophia2 = 87, sophia3 = 98, sophia4 = 95, sophia5 = 100;
        float sophiaFinal = (float)(sophia1 + sophia2 + sophia3 + sophia4 + sophia5) / currentAssignments;
        
        // Nicolas's grades and average
        int nicolas1 = 80, nicolas2 = 83, nicolas3 = 82, nicolas4 = 88, nicolas5 = 85;
        float nicolasFinal = (float)(nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5) / currentAssignments;
        
        // Zahirah's grades and average
        int zahirah1 = 84, zahirah2 = 96, zahirah3 = 73, zahirah4 = 85, zahirah5 = 79;
        float zahirahFinal = (float)(zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5) / currentAssignments;
        
        // Jeong's grades and average
        int jeong1 = 90, jeong2 = 92, jeong3 = 98, jeong4 = 100, jeong5 = 97;
        float jeongFinal = (float)(jeong1 + jeong2 + jeong3 + jeong4 + jeong5) / currentAssignments;

        Console.WriteLine("Student     Grade");
        Console.WriteLine($"Sophia      {sophiaFinal:F1}  {GetLetterGrade(sophiaFinal)}");
        Console.WriteLine($"Nicolas     {nicolasFinal:F1}  {GetLetterGrade(nicolasFinal)}");
        Console.WriteLine($"Zahirah     {zahirahFinal:F1}  {GetLetterGrade(zahirahFinal)}");
        Console.WriteLine($"Jeong       {jeongFinal:F1}  {GetLetterGrade(jeongFinal)}");
    }

    public static string GetLetterGrade(float grade)
    {
        if (grade >= 90) return "A";
        if (grade >= 80) return "B";
        if (grade >= 70) return "C";
        if (grade >= 60) return "D";
        return "F";
    }
}


*/

using System;

public class Program
{
    public static void Main()
    {
        int currentAssignments = 5;

        // Sophia's grades and average
        int sophia1 = 93, sophia2 = 87, sophia3 = 98, sophia4 = 95, sophia5 = 100;
        float sophiaFinal = (float)(sophia1 + sophia2 + sophia3 + sophia4 + sophia5) / currentAssignments;
        string sophiaLetterGrade;
        
        if (sophiaFinal >= 90) sophiaLetterGrade = "A";
        else if (sophiaFinal >= 80) sophiaLetterGrade = "B";
        else if (sophiaFinal >= 70) sophiaLetterGrade = "C";
        else if (sophiaFinal >= 60) sophiaLetterGrade = "D";
        else sophiaLetterGrade = "F";

        // Nicolas's grades and average
        int nicolas1 = 80, nicolas2 = 83, nicolas3 = 82, nicolas4 = 88, nicolas5 = 85;
        float nicolasFinal = (float)(nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5) / currentAssignments;
        string nicolasLetterGrade;

        if (nicolasFinal >= 90) nicolasLetterGrade = "A";
        else if (nicolasFinal >= 80) nicolasLetterGrade = "B";
        else if (nicolasFinal >= 70) nicolasLetterGrade = "C";
        else if (nicolasFinal >= 60) nicolasLetterGrade = "D";
        else nicolasLetterGrade = "F";

        // Zahirah's grades and average
        int zahirah1 = 84, zahirah2 = 96, zahirah3 = 73, zahirah4 = 85, zahirah5 = 79;
        float zahirahFinal = (float)(zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5) / currentAssignments;
        string zahirahLetterGrade;

        if (zahirahFinal >= 90) zahirahLetterGrade = "A";
        else if (zahirahFinal >= 80) zahirahLetterGrade = "B";
        else if (zahirahFinal >= 70) zahirahLetterGrade = "C";
        else if (zahirahFinal >= 60) zahirahLetterGrade = "D";
        else zahirahLetterGrade = "F";

        // Jeong's grades and average
        int jeong1 = 90, jeong2 = 92, jeong3 = 98, jeong4 = 100, jeong5 = 97;
        float jeongFinal = (float)(jeong1 + jeong2 + jeong3 + jeong4 + jeong5) / currentAssignments;
        string jeongLetterGrade;

        if (jeongFinal >= 90) jeongLetterGrade = "A";
        else if (jeongFinal >= 80) jeongLetterGrade = "B";
        else if (jeongFinal >= 70) jeongLetterGrade = "C";
        else if (jeongFinal >= 60) jeongLetterGrade = "D";
        else jeongLetterGrade = "F";

        Console.WriteLine("Student     Grade");
        Console.WriteLine($"Sophia      {sophiaFinal:F1}  {sophiaLetterGrade}");
        Console.WriteLine($"Nicolas     {nicolasFinal:F1}  {nicolasLetterGrade}");
        Console.WriteLine($"Zahirah     {zahirahFinal:F1}  {zahirahLetterGrade}");
        Console.WriteLine($"Jeong       {jeongFinal:F1}  {jeongLetterGrade}");
    }
}
