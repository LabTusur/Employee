using EmployeeModels;

namespace ModelsTest;

public class PaymentPerHourEmployerTest
{
    [Fact]
    public void Set_Get_FirstName()
    {
        PaymentPerHourEmployer empl = new PaymentPerHourEmployer();
        string name = "Alex";
        empl.FisrtName = name;
        Assert.Equal(empl.FisrtName, name);
    }
    [Fact]
    public void Set_Get_LastName()
    {
        PaymentPerHourEmployer empl = new PaymentPerHourEmployer();
        string lastName = "LastName";
        empl.LastName = lastName;
        Assert.Equal(empl.LastName, lastName);
    }
    [Fact]
    public void Set_Get_PaymentPerHour()
    {
        PaymentPerHourEmployer empl = new PaymentPerHourEmployer();
        Random rnd = new Random();
        int y = rnd.Next(5, 10);
        empl.PaymentPerHour = y;
        Assert.Equal(empl.PaymentPerHour, y);
    }
    [Fact]
    public void Set_Get_CountWorkHours()
    {
        PaymentPerHourEmployer empl = new PaymentPerHourEmployer();
        Random rnd = new Random();
        int x = rnd.Next(5, 10);
        empl.CountWorkHours = x;
        Assert.Equal(empl.CountWorkHours, x);
    }
    [Fact]
    public void Set_Get_Salary()
    {
        PaymentPerHourEmployer empl = new PaymentPerHourEmployer();   
        Random rnd = new Random();
        int x = rnd.Next(5, 10);
        int y = rnd.Next(5, 10);
        empl.PaymentPerHour = x;
        empl.CountWorkHours = y;
        Assert.Equal(empl.Salary, x * y);
    }
}