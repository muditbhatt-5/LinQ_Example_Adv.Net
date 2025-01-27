public class Student
{
    public int Rno { get; set; }
    public string Name { get; set; }
    public string Branch { get; set; }
    public int Sem { get; set; }
    public double CPI { get; set; }

    public static List<Student> GetAllStudents()
    {
        List<Student> Students = new List<Student>
        {
            new Student { Rno = 1, Name = "John Doe", Branch = "Computer Science", Sem = 3, CPI = 9 },
            new Student { Rno = 2, Name = "Jane Smith", Branch = "Mathematics", Sem = 2, CPI = 8 }
        };
    return Students;
    }

    public static void Main(string[] args)
    {
        List<Student> students = Student.GetAllStudents();

        // LINQ Query Syntax to find out student names whose CPI is greater than 8
        var studentNames = from student in students
                           where student.CPI > 8
                           select student.Name;
        Console.WriteLine("Student Names whose CPI is greater than 8:");
        foreach (var studentName in studentNames)
        {
            Console.WriteLine(studentName);
        }

        //---------------------------- Method Syntax --------------------------------
        //foreach (var student in students)
        //{
        //    Console.WriteLine("Roll No: {0}, Name: {1}, Branch: {2}, Sem: {3}, CPI: {4}", student.Rno, student.Name, student.Branch, student.Sem, student.CPI);
        //}

        //---------------------------- Select Method --------------------------------
        //var StudentList = Student.GetAllStudents().Select(x => new Student()
        //{
        //    Rno = x.Rno,
        //    Name = x.Name,
        //    Branch = x.Branch,
        //    Sem = x.Sem,
        //    CPI = x.CPI
        //});

        //foreach (var student in StudentList)
        //{
        //    Console.WriteLine("Roll No: {0}, Name: {1}, Branch: {2}, Sem: {3}, CPI: {4}", student.Rno, student.Name, student.Branch, student.Sem, student.CPI);
        //}

        //---------------------------- Anonymous Type -------------------------------
        //var StudentList1 = Student.GetAllStudents().Select(x => new
        //{
        //    NameAndRollNo = x.Name +"-"+ x.Rno,
        //    Branch = x.Branch
        //});

        //foreach (var student in StudentList1)
        //{
        //    Console.WriteLine("Name and Roll No: {0}, Branch: {1}", student.NameAndRollNo, student.Branch);
        //}

        //---------------------------- Where Method --------------------------------
        var StudentList2 = Student.GetAllStudents().Where(x => x.CPI > 8);
        foreach (var student in StudentList2)
        {
            Console.WriteLine("Roll No: {0}, Name: {1}, Branch: {2}, Sem: {3}, CPI: {4}", student.Rno, student.Name, student.Branch, student.Sem, student.CPI);
        }


        //---------------------------- OrderBy Method --------------------------------
        var StudentList3 = Student.GetAllStudents().OrderBy(x => x.Name);
        foreach (var student in StudentList3)
        {
            Console.WriteLine("Roll No: {0}, Name: {1}, Branch: {2}, Sem: {3}, CPI: {4}", student.Rno, student.Name, student.Branch, student.Sem, student.CPI);
        }
    }
}
