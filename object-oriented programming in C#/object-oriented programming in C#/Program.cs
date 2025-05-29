public class Student
{
    public string First_name { get; set; }
    public string Last_name { get; set; }
    public Student_group Group { get; set; }
    public double Average_grade { get; set; }
    public Student(string first_name, string last_name, Student_group group, double average_grade) { First_name = first_name; Last_name = last_name; Group = group; Average_grade = average_grade; }
    public void Display_info() { Console.WriteLine($"First Name: {First_name}\n Last Name: {Last_name}\n Group: {Group}\n Average Grade: {Average_grade}"); }
}
public enum Student_group { P1, P2, P3, None }
public class Program { public static void Main() { Student student = new Student("a", "b", Student_group.P1, 4.5); student.Display_info(); } }