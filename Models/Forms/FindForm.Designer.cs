namespace ViewModels.Forms
{
    partial class FindForm
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
            this.SalaryGridView = new System.Windows.Forms.DataGridView();
            this.FName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salaru_Lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SalaryMin_Tb = new System.Windows.Forms.TextBox();
            this.LastNAme_Tb = new System.Windows.Forms.TextBox();
            this.FirstName_Tb = new System.Windows.Forms.TextBox();
            this.SalaryMax_Tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Clear_Btn = new System.Windows.Forms.Button();
            this.Filter_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SalaryGridView
            // 
            this.SalaryGridView.AllowUserToAddRows = false;
            this.SalaryGridView.AllowUserToDeleteRows = false;
            this.SalaryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalaryGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FName,
            this.LName,
            this.Salary});
            this.SalaryGridView.Location = new System.Drawing.Point(12, 12);
            this.SalaryGridView.Name = "SalaryGridView";
            this.SalaryGridView.ReadOnly = true;
            this.SalaryGridView.RowTemplate.Height = 25;
            this.SalaryGridView.Size = new System.Drawing.Size(351, 360);
            this.SalaryGridView.TabIndex = 1;
            // 
            // FName
            // 
            this.FName.HeaderText = "Имя";
            this.FName.Name = "FName";
            this.FName.ReadOnly = true;
            // 
            // LName
            // 
            this.LName.HeaderText = "Фамилия";
            this.LName.Name = "LName";
            this.LName.ReadOnly = true;
            // 
            // Salary
            // 
            this.Salary.HeaderText = "Зарплата";
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            // 
            // Salaru_Lbl
            // 
            this.Salaru_Lbl.AutoSize = true;
            this.Salaru_Lbl.Location = new System.Drawing.Point(439, 114);
            this.Salaru_Lbl.Name = "Salaru_Lbl";
            this.Salaru_Lbl.Size = new System.Drawing.Size(105, 15);
            this.Salaru_Lbl.TabIndex = 17;
            this.Salaru_Lbl.Text = "Заработная плата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Фамилия сотрудника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Имя сотрудника";
            // 
            // SalaryMin_Tb
            // 
            this.SalaryMin_Tb.Location = new System.Drawing.Point(429, 153);
            this.SalaryMin_Tb.Name = "SalaryMin_Tb";
            this.SalaryMin_Tb.Size = new System.Drawing.Size(61, 23);
            this.SalaryMin_Tb.TabIndex = 14;
            // 
            // LastNAme_Tb
            // 
            this.LastNAme_Tb.Location = new System.Drawing.Point(369, 89);
            this.LastNAme_Tb.Name = "LastNAme_Tb";
            this.LastNAme_Tb.Size = new System.Drawing.Size(235, 23);
            this.LastNAme_Tb.TabIndex = 13;
            // 
            // FirstName_Tb
            // 
            this.FirstName_Tb.Location = new System.Drawing.Point(369, 42);
            this.FirstName_Tb.Name = "FirstName_Tb";
            this.FirstName_Tb.Size = new System.Drawing.Size(235, 23);
            this.FirstName_Tb.TabIndex = 12;
            // 
            // SalaryMax_Tb
            // 
            this.SalaryMax_Tb.Location = new System.Drawing.Point(543, 153);
            this.SalaryMax_Tb.Name = "SalaryMax_Tb";
            this.SalaryMax_Tb.Size = new System.Drawing.Size(61, 23);
            this.SalaryMax_Tb.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "от";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(507, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "до";
            // 
            // Clear_Btn
            // 
            this.Clear_Btn.Location = new System.Drawing.Point(369, 203);
            this.Clear_Btn.Name = "Clear_Btn";
            this.Clear_Btn.Size = new System.Drawing.Size(235, 23);
            this.Clear_Btn.TabIndex = 21;
            this.Clear_Btn.Text = "Очистить поиск";
            this.Clear_Btn.UseVisualStyleBackColor = true;
            this.Clear_Btn.Click += new System.EventHandler(this.Clear_Btn_Click);
            // 
            // Filter_Btn
            // 
            this.Filter_Btn.Location = new System.Drawing.Point(369, 349);
            this.Filter_Btn.Name = "Filter_Btn";
            this.Filter_Btn.Size = new System.Drawing.Size(235, 23);
            this.Filter_Btn.TabIndex = 22;
            this.Filter_Btn.Text = "Отфильтровать";
            this.Filter_Btn.UseVisualStyleBackColor = true;
            this.Filter_Btn.Click += new System.EventHandler(this.Filter_Btn_Click);
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 397);
            this.Controls.Add(this.Filter_Btn);
            this.Controls.Add(this.Clear_Btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SalaryMax_Tb);
            this.Controls.Add(this.Salaru_Lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SalaryMin_Tb);
            this.Controls.Add(this.LastNAme_Tb);
            this.Controls.Add(this.FirstName_Tb);
            this.Controls.Add(this.SalaryGridView);
            this.Name = "FindForm";
            this.Text = "FindForm";
            ((System.ComponentModel.ISupportInitialize)(this.SalaryGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView SalaryGridView;
        private DataGridViewTextBoxColumn FName;
        private DataGridViewTextBoxColumn LName;
        private DataGridViewTextBoxColumn Salary;
        private Label Salaru_Lbl;
        private Label label3;
        private Label label2;
        private TextBox SalaryMin_Tb;
        private TextBox LastNAme_Tb;
        private TextBox FirstName_Tb;
        private TextBox SalaryMax_Tb;
        private Label label1;
        private Label label4;
        private Button Clear_Btn;
        private Button Filter_Btn;
    }
}