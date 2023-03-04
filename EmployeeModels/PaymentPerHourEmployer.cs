namespace EmployeeModels
{
    public class PaymentPerHourEmployer : BaseEmployee
    {
        private int _countWorhHours, _paymentPerHour;
        public int CountWorkHours
        {
            get
            {
                return _countWorhHours;
            }
            set
            {
                if (value >= 0)
                    _countWorhHours = value;
                else
                    throw new ArgumentOutOfRangeException(nameof(CountWorkHours));
            }
        }
        public int PaymentPerHour
        {
        get
            {
                return _paymentPerHour;
            }
            set
            {
                if (value > 0)
                    _paymentPerHour = value;
                else
                    throw new ArgumentOutOfRangeException(nameof(PaymentPerHour));
            }
        }
        protected override int GetSalary()
        {
            return CountWorkHours * PaymentPerHour;
        }
    }
}
