namespace ViewModels.Forms
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Add_Btn = new System.Windows.Forms.Button();
            this.Geterate_Btn = new System.Windows.Forms.Button();
            this.FirstName_Tb = new System.Windows.Forms.TextBox();
            this.LastNAme_Tb = new System.Windows.Forms.TextBox();
            this.Salary_Tb = new System.Windows.Forms.TextBox();
            this.Tarif_Tb = new System.Windows.Forms.TextBox();
            this.PaymentRatio_Tb = new System.Windows.Forms.TextBox();
            this.TypeEmployee_cb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Salaru_Lbl = new System.Windows.Forms.Label();
            this.Tariff_Lbl = new System.Windows.Forms.Label();
            this.PaymentRatio_Lbl = new System.Windows.Forms.Label();
            this.PaymentPerHour_Tb = new System.Windows.Forms.TextBox();
            this.Hours_Tb = new System.Windows.Forms.TextBox();
            this.PaymentPerHour_Lbl = new System.Windows.Forms.Label();
            this.Hours_Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Add_Btn
            // 
            this.Add_Btn.Location = new System.Drawing.Point(51, 348);
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.Size = new System.Drawing.Size(235, 23);
            this.Add_Btn.TabIndex = 0;
            this.Add_Btn.Text = "Добавить";
            this.Add_Btn.UseVisualStyleBackColor = true;
            this.Add_Btn.Click += new System.EventHandler(this.Add_Btn_Click);
            // 
            // Geterate_Btn
            // 
            this.Geterate_Btn.Location = new System.Drawing.Point(51, 319);
            this.Geterate_Btn.Name = "Geterate_Btn";
            this.Geterate_Btn.Size = new System.Drawing.Size(235, 23);
            this.Geterate_Btn.TabIndex = 1;
            this.Geterate_Btn.Text = "Сгенерировать случайные данные";
            this.Geterate_Btn.UseVisualStyleBackColor = true;
            this.Geterate_Btn.Click += new System.EventHandler(this.Geterate_Btn_Click);
            // 
            // FirstName_Tb
            // 
            this.FirstName_Tb.Location = new System.Drawing.Point(51, 80);
            this.FirstName_Tb.Name = "FirstName_Tb";
            this.FirstName_Tb.Size = new System.Drawing.Size(235, 23);
            this.FirstName_Tb.TabIndex = 2;
            // 
            // LastNAme_Tb
            // 
            this.LastNAme_Tb.Location = new System.Drawing.Point(51, 127);
            this.LastNAme_Tb.Name = "LastNAme_Tb";
            this.LastNAme_Tb.Size = new System.Drawing.Size(235, 23);
            this.LastNAme_Tb.TabIndex = 3;
            // 
            // Salary_Tb
            // 
            this.Salary_Tb.Location = new System.Drawing.Point(51, 169);
            this.Salary_Tb.Name = "Salary_Tb";
            this.Salary_Tb.Size = new System.Drawing.Size(235, 23);
            this.Salary_Tb.TabIndex = 4;
            // 
            // Tarif_Tb
            // 
            this.Tarif_Tb.Location = new System.Drawing.Point(51, 219);
            this.Tarif_Tb.Name = "Tarif_Tb";
            this.Tarif_Tb.Size = new System.Drawing.Size(235, 23);
            this.Tarif_Tb.TabIndex = 5;
            // 
            // PaymentRatio_Tb
            // 
            this.PaymentRatio_Tb.Location = new System.Drawing.Point(51, 262);
            this.PaymentRatio_Tb.Name = "PaymentRatio_Tb";
            this.PaymentRatio_Tb.Size = new System.Drawing.Size(235, 23);
            this.PaymentRatio_Tb.TabIndex = 6;
            // 
            // TypeEmployee_cb
            // 
            this.TypeEmployee_cb.FormattingEnabled = true;
            this.TypeEmployee_cb.Items.AddRange(new object[] {
            "Фиксированная плата",
            "Плата по часам",
            "Плата соглавно тарифной сетки"});
            this.TypeEmployee_cb.Location = new System.Drawing.Point(51, 27);
            this.TypeEmployee_cb.Name = "TypeEmployee_cb";
            this.TypeEmployee_cb.Size = new System.Drawing.Size(235, 23);
            this.TypeEmployee_cb.TabIndex = 7;
            this.TypeEmployee_cb.SelectedIndexChanged += new System.EventHandler(this.TypeEmployee_cb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Тип расчета зарплаты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Имя сотрудника";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Фамилия сотрудника";
            // 
            // Salaru_Lbl
            // 
            this.Salaru_Lbl.AutoSize = true;
            this.Salaru_Lbl.Location = new System.Drawing.Point(121, 152);
            this.Salaru_Lbl.Name = "Salaru_Lbl";
            this.Salaru_Lbl.Size = new System.Drawing.Size(105, 15);
            this.Salaru_Lbl.TabIndex = 11;
            this.Salaru_Lbl.Text = "Заработная плата";
            // 
            // Tariff_Lbl
            // 
            this.Tariff_Lbl.AutoSize = true;
            this.Tariff_Lbl.Location = new System.Drawing.Point(124, 197);
            this.Tariff_Lbl.Name = "Tariff_Lbl";
            this.Tariff_Lbl.Size = new System.Drawing.Size(99, 15);
            this.Tariff_Lbl.TabIndex = 12;
            this.Tariff_Lbl.Text = "Тарифная ставка";
            // 
            // PaymentRatio_Lbl
            // 
            this.PaymentRatio_Lbl.AutoSize = true;
            this.PaymentRatio_Lbl.Location = new System.Drawing.Point(111, 243);
            this.PaymentRatio_Lbl.Name = "PaymentRatio_Lbl";
            this.PaymentRatio_Lbl.Size = new System.Drawing.Size(124, 15);
            this.PaymentRatio_Lbl.TabIndex = 13;
            this.PaymentRatio_Lbl.Text = "Минимальная ставка";
            // 
            // PaymentPerHour_Tb
            // 
            this.PaymentPerHour_Tb.Location = new System.Drawing.Point(51, 219);
            this.PaymentPerHour_Tb.Name = "PaymentPerHour_Tb";
            this.PaymentPerHour_Tb.Size = new System.Drawing.Size(235, 23);
            this.PaymentPerHour_Tb.TabIndex = 14;
            // 
            // Hours_Tb
            // 
            this.Hours_Tb.Location = new System.Drawing.Point(51, 262);
            this.Hours_Tb.Name = "Hours_Tb";
            this.Hours_Tb.Size = new System.Drawing.Size(235, 23);
            this.Hours_Tb.TabIndex = 15;
            // 
            // PaymentPerHour_Lbl
            // 
            this.PaymentPerHour_Lbl.AutoSize = true;
            this.PaymentPerHour_Lbl.Location = new System.Drawing.Point(134, 197);
            this.PaymentPerHour_Lbl.Name = "PaymentPerHour_Lbl";
            this.PaymentPerHour_Lbl.Size = new System.Drawing.Size(80, 15);
            this.PaymentPerHour_Lbl.TabIndex = 16;
            this.PaymentPerHour_Lbl.Text = "Ставка за час";
            // 
            // Hours_Lbl
            // 
            this.Hours_Lbl.AutoSize = true;
            this.Hours_Lbl.Location = new System.Drawing.Point(79, 243);
            this.Hours_Lbl.Name = "Hours_Lbl";
            this.Hours_Lbl.Size = new System.Drawing.Size(189, 15);
            this.Hours_Lbl.TabIndex = 17;
            this.Hours_Lbl.Text = "Количество отработанных часов";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 403);
            this.Controls.Add(this.Hours_Lbl);
            this.Controls.Add(this.PaymentPerHour_Lbl);
            this.Controls.Add(this.Hours_Tb);
            this.Controls.Add(this.PaymentPerHour_Tb);
            this.Controls.Add(this.PaymentRatio_Lbl);
            this.Controls.Add(this.Tariff_Lbl);
            this.Controls.Add(this.Salaru_Lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TypeEmployee_cb);
            this.Controls.Add(this.PaymentRatio_Tb);
            this.Controls.Add(this.Tarif_Tb);
            this.Controls.Add(this.Salary_Tb);
            this.Controls.Add(this.LastNAme_Tb);
            this.Controls.Add(this.FirstName_Tb);
            this.Controls.Add(this.Geterate_Btn);
            this.Controls.Add(this.Add_Btn);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Add_Btn;
        private Button Geterate_Btn;
        private TextBox FirstName_Tb;
        private TextBox LastNAme_Tb;
        private TextBox Salary_Tb;
        private TextBox Tarif_Tb;
        private TextBox PaymentRatio_Tb;
        private ComboBox TypeEmployee_cb;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label Salaru_Lbl;
        private Label Tariff_Lbl;
        private Label PaymentRatio_Lbl;
        private TextBox PaymentPerHour_Tb;
        private TextBox Hours_Tb;
        private Label PaymentPerHour_Lbl;
        private Label Hours_Lbl;
    }
}