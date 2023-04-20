using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    public abstract class Employee : IEmployee, IEmployeeBonus
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Employee(int id , string name) {
            this.Id = id;
            this.Name = name;
        }
        public void Display(decimal bonus)
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Bonus: {bonus}");
        }
        public abstract decimal CalculateBonus(decimal salary);

        public abstract decimal Getsalery();

    }

    public class PermanentEmployee : Employee
    {
        public PermanentEmployee(int id, string name) : base(id, name)
        {
        }

        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .1M;
        }

        public override decimal Getsalery()
        {
            return 50000;
        }
    }

    public class TemporaryEmployee : Employee
    {
        public TemporaryEmployee(int id, string name) : base(id, name)
        {
        }

        public override decimal CalculateBonus(decimal salary)
        {
            return (salary * .05M);
        }

        public override decimal Getsalery()
        {
            return 40000;
        }
    }

    public class ContractEmployee : IEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ContractEmployee(int id, string name)
        {
            this.Id= id;
            this.Name= name;
        }

        public decimal Getsalery()
        {
            return 35000;
        }
    }
    public class TestEmployee
    {
        static void Main()
        {

            List<Employee> employees = new List<Employee>();
            employees.Add(new PermanentEmployee(1, "Alexa"));
            employees.Add(new TemporaryEmployee(2, "Siri"));
            /*employees.Add(new ContractEmployee(3, "Bixby"));*/
            foreach (var emp in employees)
            {
                Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Salery: {emp.Getsalery()}, Bonus: {emp.CalculateBonus(10000)}");

            }

            Console.WriteLine("********************************************************");

            List<IEmployee> list = new List<IEmployee>();
            list.Add(new PermanentEmployee(1,"Alexa"));
            list.Add(new TemporaryEmployee(2, "Siri"));
            list.Add(new ContractEmployee(3, "Bixby"));

            foreach (var emp in list)
            {
                Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Salery: {emp.Getsalery()}");

            }

        }
    }
}
