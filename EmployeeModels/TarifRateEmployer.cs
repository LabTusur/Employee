namespace EmployeeModels
{
    public class TarifRateEmployer : BaseEmployee
    {
        private int _tarif, _paymetRatio;

        public int Tarif
        {
            get
            {
                return _tarif;
            }
            set
            {
                if (value >= 0)
                    _tarif = value;
                else
                    throw new ArgumentOutOfRangeException(nameof(Tarif));
            }

        }
        public int PaymentRatio 
        {
            get
            {
                return _paymetRatio;
            }
            set
            {
                if (value >= 0)
                    _paymetRatio = value;
                else
                    throw new ArgumentOutOfRangeException(nameof(Tarif));
            }

        }

        protected override int GetSalary()
        {
            if(_paymetRatio >=0 && _tarif >= 0 )
                return _tarif * _paymetRatio;
            else
                throw new ArgumentException("Wrong values of tarif and payment ratio");
        }
    }
}
