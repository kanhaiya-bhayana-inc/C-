namespace InheritanceProject
{

    class Person
    {
        public int Id;
        public string Name, Address, Phone;
    }
    class Student : Person
    {
        int Class;
        char Grade;
        float Marks, Fees;
    }
    class Staff : Person
    {
        public string Designation;
        public double Salary;
    }
    class NonTeaching : Staff
    {
        string Qualification, Subject;
    }
    class Teaching : Staff
    {
        public int ManagerId;
        public string DeptName;
    }

    
    class Program
    {
        public void Display (Teaching tech)
        {
            Console.WriteLine($"Id: {tech.Id}");
            Console.WriteLine($"Name: {tech.Name}");
            Console.WriteLine($"Address: {tech.Address}");
            Console.WriteLine($"Designation: {tech.Designation}");
            Console.WriteLine($"Phone: {tech.Phone}");
            Console.WriteLine($"DeptName: {tech.DeptName}");
            Console.WriteLine($"ManagerId: {tech.ManagerId}");
            Console.WriteLine($"Salary: {tech.Salary}");
        }
        static void Main(string[] args)
        {
            Teaching teaching = new Teaching();
            teaching.Name = "Alok Yadav";
            teaching.Salary = 100000;
            teaching.Address = "Delhi";
            teaching.Designation = "Prof.";
            teaching.Id = 1;
            teaching.Phone = "+91-1234567890";
            teaching.DeptName = "C.S.E.";
            teaching.ManagerId = 101;
            /*Console.WriteLine(teaching);*/
            Program p = new Program();
            p.Display(teaching);

        }
    }
}