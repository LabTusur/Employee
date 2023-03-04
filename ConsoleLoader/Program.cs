using EmployeeModels;
List<IEmployee> employees = new List<IEmployee>();
while (true)
{
    Console.WriteLine("Add employee to list");
    Console.WriteLine("Enter employe salary type: 1 - fix salary" +
                                            "2 - tariff rate" +
                                            "3 - payment pay hour 4 - break");
    int type = 0;
    try
    {
        type = int.Parse(Console.ReadLine());
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    if (type == 4)
        break;
    if (type == 1)
    {
        try
        {
            FixSalaryEmployer empl = new FixSalaryEmployer();
            Console.WriteLine("Enter Fisrt Name");
            empl.FisrtName = Console.ReadLine();

            Console.WriteLine("Enter Last Name");
            empl.LastName = Console.ReadLine();

            Console.WriteLine("Enter salary value");
            empl.Salary = int.Parse(Console.ReadLine());

            employees.Add(empl);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
    if (type == 2)
    {
        TarifRateEmployer employer = new TarifRateEmployer();
        try
        {
            Console.WriteLine("Enter Fisrt Name");
            employer.FisrtName = Console.ReadLine();

            Console.WriteLine("Enter Last Name");
            employer.LastName = Console.ReadLine();

            Console.WriteLine("Enter tariff");
            employer.Tarif = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter payment ratio");
            employer.PaymentRatio = int.Parse(Console.ReadLine());

            employees.Add(employer);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
    if (type == 3)
    {
        PaymentPerHourEmployer employer = new PaymentPerHourEmployer();
        try
        {
            Console.WriteLine("Enter Fisrt Name");
            employer.FisrtName = Console.ReadLine();

            Console.WriteLine("Enter Last Name");
            employer.LastName = Console.ReadLine();

            Console.WriteLine("Enter payment per hour");
            employer.PaymentPerHour = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter count work hours");
            employer.CountWorkHours = int.Parse(Console.ReadLine());

            employees.Add(employer);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

}
foreach (var item in employees)
{
    item.ToConsole();
}