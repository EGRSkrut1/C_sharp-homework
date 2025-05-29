public class Student
{
    public string First_name { get; set; }
    public string Last_name { get; set; }
    public double Average_grade { get; set; }
    public Student(string first_Name, string last_Name, double average_Grade) { First_name = first_Name; Last_name = last_Name; Average_grade = average_Grade; }
}
public static class Student_extensions { public static void Display_full_name_and_grade(this Student student) { Console.WriteLine($"Full name: {student.First_name} {student.Last_name}\n Grade: {student.Average_grade}"); } }
public class Program { public static void Main() { Student student = new Student("a", "b", 4.5); student.Display_full_name_and_grade(); } }