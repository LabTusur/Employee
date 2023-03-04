using EmployeeModels;
using Newtonsoft.Json;
using ViewModels.Forms;

namespace Models
{
    public partial class Form1 : Form
    {
        public List<IEmployee> _employees = new List<IEmployee>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new AddForm(this);
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateUi()
        {
            SalaryGridView.Rows.Clear();
            foreach (var employer in _employees)
            {
                SalaryGridView.Rows.Add();
                SalaryGridView[0, SalaryGridView.RowCount - 1].Value = employer.FisrtName;
                SalaryGridView[1, SalaryGridView.RowCount - 1].Value = employer.LastName;
                SalaryGridView[2, SalaryGridView.RowCount - 1].Value = employer.Salary.ToString();
            }
        }

        private void Find_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new FindForm(_employees);
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            string json = System.Text.Json.JsonSerializer.Serialize(_employees);
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog.FileName;
            File.WriteAllText(filename + ".employee", json);
        }

        private void Open_Btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog.FileName;
            string text = File.ReadAllText(filename);
            try
            {
                var employees = JsonConvert.DeserializeObject<List<BaseEmployee>>(text);
                foreach (var item in employees)
                {
                    _employees.Add(item);
                }
                UpdateUi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Remove_Btn_Click(object sender, EventArgs e)
        {
            var deleteItem = SalaryGridView.CurrentCell;
            if (deleteItem != null)
                _employees.RemoveAt(deleteItem.RowIndex);
            else
                MessageBox.Show("Выберите сотрудника");
            UpdateUi();
        }
    }
}