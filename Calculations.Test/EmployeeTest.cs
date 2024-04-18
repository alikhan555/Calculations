using Xunit;

namespace Calculations.Test
{
    public class EmployeeTest
    {
        [Fact]
        public void Employee_MustBePartTimeEmployee()
        {
            EmployeeFactory factory = new EmployeeFactory();
            PartTimeEmployee partTimeEmployee = Assert.IsType<PartTimeEmployee>(factory.GetEmployee("PartTime"));
            Assert.Equal(partTimeEmployee.HourlySalary, 101);
        }

        [Fact]
        public void Employee_MustBeFullTimeEmployee()
        {
            EmployeeFactory factory = new EmployeeFactory();
            FullTimeEmployee fullTimeEmployee = Assert.IsType<FullTimeEmployee>(factory.GetEmployee("FullTime"));
            Assert.Equal(fullTimeEmployee.MonthlySalary, 24001);
        }
    }
}
