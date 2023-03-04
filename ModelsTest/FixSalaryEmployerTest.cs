using EmployeeModels;

namespace ModelsTest;

public class FixSalaryEmployerTest
{
    [Fact]
    public void Set_Get_FirstName()
    {
        FixSalaryEmployer empl = new FixSalaryEmployer();
        string name = "Alex";
        empl.FisrtName = name;
        Assert.Equal(empl.FisrtName, name);
    }
    [Fact]
    public void Set_Get_LastName()
    {
        FixSalaryEmployer empl = new FixSalaryEmployer();
        string lastName = "LastName";
        empl.LastName = lastName;
        Assert.Equal(empl.LastName, lastName);
    }
    [Fact]
    public void Set_Get_Salary()
    {
        FixSalaryEmployer empl = new FixSalaryEmployer();   
        Random rnd = new Random();
        int x = rnd.Next(5, 10);
        empl.Salary = x;
        Assert.Equal(empl.Salary, x);
    }
}