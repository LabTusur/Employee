namespace Models
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SalaryGridView = new System.Windows.Forms.DataGridView();
            this.FName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add_Btn = new System.Windows.Forms.Button();
            this.Find_Btn = new System.Windows.Forms.Button();
            this.Remove_Btn = new System.Windows.Forms.Button();
            this.Save_Btn = new System.Windows.Forms.Button();
            this.Open_Btn = new System.Windows.Forms.Button();
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
            this.SalaryGridView.TabIndex = 0;
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
            // Add_Btn
            // 
            this.Add_Btn.Location = new System.Drawing.Point(369, 12);
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.Size = new System.Drawing.Size(154, 23);
            this.Add_Btn.TabIndex = 1;
            this.Add_Btn.Text = "Добавить";
            this.Add_Btn.UseVisualStyleBackColor = true;
            this.Add_Btn.Click += new System.EventHandler(this.Add_Btn_Click);
            // 
            // Find_Btn
            // 
            this.Find_Btn.Location = new System.Drawing.Point(369, 51);
            this.Find_Btn.Name = "Find_Btn";
            this.Find_Btn.Size = new System.Drawing.Size(154, 23);
            this.Find_Btn.TabIndex = 2;
            this.Find_Btn.Text = "Найти";
            this.Find_Btn.UseVisualStyleBackColor = true;
            this.Find_Btn.Click += new System.EventHandler(this.Find_Btn_Click);
            // 
            // Remove_Btn
            // 
            this.Remove_Btn.Location = new System.Drawing.Point(369, 349);
            this.Remove_Btn.Name = "Remove_Btn";
            this.Remove_Btn.Size = new System.Drawing.Size(154, 23);
            this.Remove_Btn.TabIndex = 3;
            this.Remove_Btn.Text = "Удалить";
            this.Remove_Btn.UseVisualStyleBackColor = true;
            this.Remove_Btn.Click += new System.EventHandler(this.Remove_Btn_Click);
            // 
            // Save_Btn
            // 
            this.Save_Btn.Location = new System.Drawing.Point(369, 147);
            this.Save_Btn.Name = "Save_Btn";
            this.Save_Btn.Size = new System.Drawing.Size(154, 23);
            this.Save_Btn.TabIndex = 4;
            this.Save_Btn.Text = "Сохранить";
            this.Save_Btn.UseVisualStyleBackColor = true;
            this.Save_Btn.Click += new System.EventHandler(this.Save_Btn_Click);
            // 
            // Open_Btn
            // 
            this.Open_Btn.Location = new System.Drawing.Point(369, 176);
            this.Open_Btn.Name = "Open_Btn";
            this.Open_Btn.Size = new System.Drawing.Size(154, 23);
            this.Open_Btn.TabIndex = 5;
            this.Open_Btn.Text = "Открыть";
            this.Open_Btn.UseVisualStyleBackColor = true;
            this.Open_Btn.Click += new System.EventHandler(this.Open_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 394);
            this.Controls.Add(this.Open_Btn);
            this.Controls.Add(this.Save_Btn);
            this.Controls.Add(this.Remove_Btn);
            this.Controls.Add(this.Find_Btn);
            this.Controls.Add(this.Add_Btn);
            this.Controls.Add(this.SalaryGridView);
            this.Name = "Form1";
            this.Text = "Сотрудники";
            ((System.ComponentModel.ISupportInitialize)(this.SalaryGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView SalaryGridView;
        private DataGridViewTextBoxColumn FName;
        private DataGridViewTextBoxColumn LName;
        private DataGridViewTextBoxColumn Salary;
        private Button Add_Btn;
        private Button Find_Btn;
        private Button Remove_Btn;
        private Button Save_Btn;
        private Button Open_Btn;
    }
}