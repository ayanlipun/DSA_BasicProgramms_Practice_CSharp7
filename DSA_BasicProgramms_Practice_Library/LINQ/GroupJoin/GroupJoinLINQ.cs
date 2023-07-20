namespace DSA_BasicProgramms_Practice_Library.LINQ.GroupJoin
{
    public class GroupJoinLINQ
    {
        public static void ExecGroupJoinLINQ()
        {
            ExecGroupJoinLINQMethodBased();
            //ExecGroupJoinLINQQueryBased();
        }

        public static void ExecGroupJoinLINQMethodBased()
        {
            var GroupJoinMS = Department.GetAllDepartments(). //Outer Data Source i.e. Departments
               GroupJoin( //Performing Group Join with Inner Data Source
                   Employee.GetAllEmployees(), //Inner Data Source
                   dept => dept.ID, //Outer Key Selector  i.e. the Common Property
                   emp => emp.DepartmentId, //Inner Key Selector  i.e. the Common Property
                   (dept, emp) => new { dept, emp });  //Projecting the Result to an Anonymous Type

            //Outer Foreach is for Each department
            foreach (var item in GroupJoinMS)
            {
                Console.WriteLine("Department :" + item.dept.Name);
                //Inner Foreach loop for each employee of a Particular department
                foreach (var employee in item.emp)
                {
                    Console.WriteLine("  EmployeeID : " + employee.ID + " , Name : " + employee.Name);
                }
            }
        }

        public static void ExecGroupJoinLINQQueryBased()
        {
            var GroupJoinQS = from dept in Department.GetAllDepartments() //Outer Data Source i.e. Departments
                              join emp in Employee.GetAllEmployees() //Joining with Inner Data Source i.e. Employees
                              on dept.ID equals emp.DepartmentId //Joining Condition
                              into EmployeeGroups //Projecting the Joining Result into EmployeeGroups, Final Result include each department and the corresponding employees.
                              select new { dept, EmployeeGroups };

            //Outer Foreach is for Each department
            foreach (var item in GroupJoinQS)
            {
                Console.WriteLine("Department :" + item.dept.Name);
                //Inner Foreach loop for each employee of a Particular department
                foreach (var employee in item.EmployeeGroups)
                {
                    Console.WriteLine("  EmployeeID : " + employee.ID + " , Name : " + employee.Name);
                }
            }          
        }
    }
}
