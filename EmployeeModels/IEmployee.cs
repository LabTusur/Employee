namespace EmployeeModels
{
    public interface IEmployee
    {
        public string FisrtName { get; set; }
        public string LastName { get; set; }
        public  int Salary { get; set; }
        public void ToConsole();
    }
}
