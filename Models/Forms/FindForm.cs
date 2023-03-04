using EmployeeModels;

namespace ViewModels.Forms
{
    public partial class FindForm : Form
    {
        public List<IEmployee> _employees = new List<IEmployee>();
        public FindForm(List<IEmployee> employee)
        {
            InitializeComponent();
            _employees = employee;
            UpdateUi(employee);
        }
        private void Clear_Btn_Click(object sender, EventArgs e)
        {
            UpdateUi(_employees);
        }
        private void Filter_Btn_Click(object sender, EventArgs e)
        {
            List<IEmployee> employees = _employees;
            if (!string.IsNullOrEmpty(FirstName_Tb.Text))
            {
                employees = employees.Where(p => p.FisrtName == FirstName_Tb.Text).ToList();
            }
            if (!string.IsNullOrEmpty(LastNAme_Tb.Text))
            {
                employees = employees.Where(p => p.LastName == LastNAme_Tb.Text).ToList();
            }
            int x = 0, y = 0;
            if (int.TryParse(SalaryMin_Tb.Text, out x))
            {
                employees = employees.Where(p => p.Salary >= x).ToList();
            }
            if (int.TryParse(SalaryMax_Tb.Text, out y))
            {
                employees = employees.Where(p => p.Salary <= y).ToList();
            }
            UpdateUi(employees);
        }
        public void UpdateUi(List<IEmployee> employees)
        {
            SalaryGridView.Rows.Clear();
            foreach (var employer in employees)
            {
                SalaryGridView.Rows.Add();
                SalaryGridView[0, SalaryGridView.RowCount - 1].Value = employer.FisrtName;
                SalaryGridView[1, SalaryGridView.RowCount - 1].Value = employer.LastName;
                SalaryGridView[2, SalaryGridView.RowCount - 1].Value = employer.Salary.ToString();
            }
        }
    }
}
