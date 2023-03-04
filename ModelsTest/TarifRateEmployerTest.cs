using EmployeeModels;

namespace ModelsTest;

public class TarifRateEmployerTest
{
    [Fact]
    public void Set_Get_FirstName()
    {
        TarifRateEmployer empl = new TarifRateEmployer();
        string name = "Alex";
        empl.FisrtName = name;
        Assert.Equal(empl.FisrtName, name);
    }
    [Fact]
    public void Set_Get_LastName()
    {
        TarifRateEmployer empl = new TarifRateEmployer();
        string lastName = "LastName";
        empl.LastName = lastName;
        Assert.Equal(empl.LastName, lastName);
    }
    [Fact]
    public void Set_Get_PaymentRatio()
    {
        TarifRateEmployer empl = new TarifRateEmployer();
        Random rnd = new Random();
        int y = rnd.Next(5, 10);
        empl.PaymentRatio = y;
        Assert.Equal(empl.PaymentRatio, y);
    }
    [Fact]
    public void Set_Get_Tarif()
    {
        TarifRateEmployer empl = new TarifRateEmployer();
        Random rnd = new Random();
        int x = rnd.Next(5, 10);
        empl.Tarif = x;
        Assert.Equal(empl.Tarif, x);
    }
    [Fact]
    public void Set_Get_Salary()
    {
        TarifRateEmployer empl = new TarifRateEmployer();   
        Random rnd = new Random();
        int x = rnd.Next(5, 10);
        int y = rnd.Next(5, 10);
        empl.Tarif = x;
        empl.PaymentRatio = y;
        Assert.Equal(empl.Salary, x * y);
    }
}