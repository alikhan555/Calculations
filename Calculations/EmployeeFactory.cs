namespace Calculations
{
    public class EmployeeFactory
    {
        public Employee GetEmployee(string employeeType)
        {
            if (employeeType == "PartTime")
            {
                return new PartTimeEmployee() { HourlySalary = 101};
            }
            if (employeeType == "FullTime")
            {
                return new FullTimeEmployee() { MonthlySalary = 24001 };
            }

            return null;
        }
    }

    public class Employee
    {

    }


    public class PartTimeEmployee : Employee
    {
        public int HourlySalary { get; set; }
    }

    public class FullTimeEmployee : Employee
    {
        public int MonthlySalary { get; set; }
    }
}
