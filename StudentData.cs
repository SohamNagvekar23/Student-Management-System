using System.Collections.Generic;
using System.IO;

public static class StudentData
{
    public static List<Student> students = new List<Student>();

    public static void SaveData()
    {
        List<string> lines = new List<string>();

        for (int i = 0; i < students.Count; i++)
        {
            string line = students[i].Id + "|" +
                          students[i].Name + "|" +
                          students[i].Age + "|" +
                          students[i].Course + "|" +
                          students[i].Gpa;

            lines.Add(line);
        }

        File.WriteAllLines("students.txt", lines);
    }

    public static void LoadData()
    {
        if (!File.Exists("students.txt"))
        {
            return;
        }
        string[] lines = File.ReadAllLines("students.txt");
        for (int i = 0; i < lines.Length; i++)
        {
            string[] data = lines[i].Split('|');

            if (data.Length == 5)
            {
                Student student = new Student();

                student.Id = data[0];
                student.Name = data[1];
                student.Age = data[2];
                student.Course = data[3];
                student.Gpa = data[4];

                students.Add(student);
            }
        }
    }
}