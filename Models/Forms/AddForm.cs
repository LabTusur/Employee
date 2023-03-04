using EmployeeModels;
using Models;

namespace ViewModels.Forms
{
    public partial class AddForm : Form
    {
        private Form1 _main;
        private readonly Random _random = new Random();
        public AddForm(Form1 main)
        {
            InitializeComponent();
            _main = main;
            ControlUI(-1);

#if !DEBUG
            Geterate_Btn.Visible = false;
#endif
        }
        private void Add_Btn_Click(object sender, EventArgs e)
        {
            if (TypeEmployee_cb.SelectedIndex == 0)
            {

                ControlUI(TypeEmployee_cb.SelectedIndex);
                if (!string.IsNullOrEmpty(FirstName_Tb.Text) &&
                    !string.IsNullOrEmpty(LastNAme_Tb.Text) &&
                    !string.IsNullOrEmpty(Salary_Tb.Text))
                {
                    int x = 0;
                    if (int.TryParse(Salary_Tb.Text, out x))
                    {
                        if (x > 0)
                        {
                            FixSalaryEmployer employer = new FixSalaryEmployer
                            {
                                FisrtName = FirstName_Tb.Text,
                                LastName = LastNAme_Tb.Text,
                                Salary = x
                            };
                            _main._employees.Add(employer);

                        }
                        else
                        {
                            MessageBox.Show("Маленькая заработная плата, не так ли?");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ожидаю ввод целых положительных чисел");
                    }
                }
                else
                {
                    MessageBox.Show("Заполните все поля");
                }
            }
            else if (TypeEmployee_cb.SelectedIndex == 1)
            {
                ControlUI(TypeEmployee_cb.SelectedIndex);
                if (!string.IsNullOrEmpty(FirstName_Tb.Text) &&
                    !string.IsNullOrEmpty(LastNAme_Tb.Text) &&
                    !string.IsNullOrEmpty(PaymentPerHour_Tb.Text) &&
                    !string.IsNullOrEmpty(Hours_Tb.Text))
                {
                    int x = 0, y = 0;
                    if (int.TryParse(PaymentPerHour_Tb.Text, out x) && int.TryParse(Hours_Tb.Text, out y))
                    {
                        if (x > 0 && y > 0)
                        {
                            PaymentPerHourEmployer employer = new PaymentPerHourEmployer
                            {
                                FisrtName = FirstName_Tb.Text,
                                LastName = LastNAme_Tb.Text,
                                CountWorkHours = y,
                                PaymentPerHour = x
                            };
                            _main._employees.Add(employer);
                        }
                        else
                        {
                            MessageBox.Show("Что-то не то с цифрами");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ожидаю ввод целых положительных чисел");
                    }

                }
                else
                {
                    MessageBox.Show("Заполните все поля");
                }
            }
            else if (TypeEmployee_cb.SelectedIndex == 2)
            {
                ControlUI(TypeEmployee_cb.SelectedIndex);
                if (!string.IsNullOrEmpty(FirstName_Tb.Text) &&
                    !string.IsNullOrEmpty(LastNAme_Tb.Text) &&
                    !string.IsNullOrEmpty(Tarif_Tb.Text) &&
                    !string.IsNullOrEmpty(PaymentRatio_Tb.Text))
                {
                    int x = 0, y = 0;
                    if (x > 0 && y > 0)
                    {
                        if (int.TryParse(Tarif_Tb.Text, out x) && int.TryParse(PaymentRatio_Tb.Text, out y))
                        {
                            TarifRateEmployer employer = new TarifRateEmployer
                            {
                                FisrtName = FirstName_Tb.Text,
                                LastName = LastNAme_Tb.Text,
                                PaymentRatio = y,
                                Tarif = x
                            };
                            _main._employees.Add(employer);
                        }
                        else
                        {
                            MessageBox.Show("Ожидаю ввод целых положительных чисел");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Что-то не то с цифрами");
                    }
                }
                else
                {
                    MessageBox.Show("Заполните все поля");
                }
            }
            else
            {
                MessageBox.Show("Выберите тип сотрудника");
            }
            _main.UpdateUi();
        }
        private void Geterate_Btn_Click(object sender, EventArgs e)
        {
            int type = _random.Next(0, 3);
            TypeEmployee_cb.SelectedIndex = type;
            if (type == 0)
            {
                ControlUI(type);

                FirstName_Tb.Text = GetString(10);
                LastNAme_Tb.Text = GetString(10);
                Salary_Tb.Text = _random.Next(20, 40000).ToString();
            }
            else if (type == 1)
            {
                ControlUI(type);
                FirstName_Tb.Text = GetString(10);
                LastNAme_Tb.Text = GetString(10);
                Hours_Tb.Text = _random.Next(40, 100).ToString();
                PaymentPerHour_Tb.Text = _random.Next(6, 50).ToString();

            }
            else if (type == 2)
            {
                FirstName_Tb.Text = GetString(10);
                LastNAme_Tb.Text = GetString(10);
                PaymentRatio_Tb.Text = _random.Next(20, 30).ToString();
                Tarif_Tb.Text = _random.Next(20, 50).ToString();
            }

        }
        private string GetString(int length)
        {
            const string chars = "ЙЦУКЕНГШЩЗХЪЭЖДЛОРПАВЫФЯЧСМИТЬБЮ";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[_random.Next(s.Length)]).ToArray());
        }
        private void ControlUI(int v)
        {
            if (v == -1)
            {
                LastNAme_Tb.Enabled = false;
                FirstName_Tb.Enabled = false;

                Salaru_Lbl.Visible = false;
                Salary_Tb.Visible = false;

                PaymentPerHour_Lbl.Visible = false;
                PaymentPerHour_Tb.Visible = false;

                PaymentRatio_Lbl.Visible = false;
                PaymentRatio_Tb.Visible = false;

                Hours_Lbl.Visible = false;
                Hours_Tb.Visible = false;

                Tariff_Lbl.Visible = false;
                Tarif_Tb.Visible = false;
            }
            if (v == 0)
            {
                LastNAme_Tb.Enabled = true;
                FirstName_Tb.Enabled = true;

                Salaru_Lbl.Visible = true;
                Salary_Tb.Visible = true;

                PaymentPerHour_Lbl.Visible = false;
                PaymentPerHour_Tb.Visible = false;

                PaymentRatio_Lbl.Visible = false;
                PaymentRatio_Tb.Visible = false;

                Hours_Lbl.Visible = false;
                Hours_Tb.Visible = false;

                Tariff_Lbl.Visible = false;
                Tarif_Tb.Visible = false;
            }
            if (v == 1)
            {
                LastNAme_Tb.Enabled = true;
                FirstName_Tb.Enabled = true;

                Salaru_Lbl.Visible = false;
                Salary_Tb.Visible = false;

                PaymentPerHour_Lbl.Visible = true;
                PaymentPerHour_Tb.Visible = true;

                PaymentRatio_Lbl.Visible = false;
                PaymentRatio_Tb.Visible = false;

                Hours_Lbl.Visible = true;
                Hours_Tb.Visible = true;

                Tariff_Lbl.Visible = false;
                Tarif_Tb.Visible = false;
            }
            if (v == 2)
            {
                LastNAme_Tb.Enabled = true;
                FirstName_Tb.Enabled = true;

                Salaru_Lbl.Visible = false;
                Salary_Tb.Visible = false;

                PaymentPerHour_Lbl.Visible = false;
                PaymentPerHour_Tb.Visible = false;

                PaymentRatio_Lbl.Visible = true;
                PaymentRatio_Tb.Visible = true;

                Hours_Lbl.Visible = false;
                Hours_Tb.Visible = false;

                Tariff_Lbl.Visible = true;
                Tarif_Tb.Visible = true;
            }
        }
        private void TypeEmployee_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ControlUI(TypeEmployee_cb.SelectedIndex);
        }
    }
}
