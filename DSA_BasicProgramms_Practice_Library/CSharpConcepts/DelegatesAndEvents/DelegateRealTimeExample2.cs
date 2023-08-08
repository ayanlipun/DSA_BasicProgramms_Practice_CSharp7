using static DSA_BasicProgramms_Practice_Library.CSharpConcepts.DelegatesAndEvents.DelegateRealTimeExample2;

namespace DSA_BasicProgramms_Practice_Library.CSharpConcepts.DelegatesAndEvents
{
    public delegate bool EligibleToPromotion(Employee EmployeeToPromotion);
    public class DelegateRealTimeExample2
    {
        public static void ExecDelegateRealTimeExample2()
        {
            Employee emp1 = new Employee()
            {
                Id = 101,
                Name = "Pranaya",
                Gender = "Male",
                Experience = 5,
                Salary = 10000
            };
            Employee emp2 = new Employee()
            {
                Id = 102,
                Name = "Priyanka",
                Gender = "Female",
                Experience = 10,
                Salary = 20000
            };
            Employee emp3 = new Employee()
            {
                Id = 103,
                Name = "Anurag",
                Experience = 15,
                Salary = 30000
            };
            List<Employee> lstEmployess = new List<Employee>();
            lstEmployess.Add(emp1);
            lstEmployess.Add(emp2);
            lstEmployess.Add(emp3);
            EligibleToPromotion eligibleTopromote = new EligibleToPromotion(DelegateRealTimeExample2.Promote);
            Employee.PromoteEmployee(lstEmployess, eligibleTopromote);
        }
        public static bool Promote(Employee employee)
        {
            if (employee.Salary > 10000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Experience { get; set; }
        public int Salary { get; set; }

        public static void PromoteEmployee(List<Employee> lstEmployees, EligibleToPromotion isEmployeeEligible)
        {
            foreach (Employee employee in lstEmployees)
            {
                if (isEmployeeEligible(employee))
                {
                    Console.WriteLine($"Employee {employee.Name} Promoted");
                }
            }
        }
    }
}
