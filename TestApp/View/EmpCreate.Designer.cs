namespace TestApp.View
{
    partial class EmpCreate
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
            this.label1 = new System.Windows.Forms.Label();
            this.FullName_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TabNumber_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Email_TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Phone_TextBox = new System.Windows.Forms.TextBox();
            this.Department_TextBox = new System.Windows.Forms.ComboBox();
            this.Accept_Button = new System.Windows.Forms.Button();
            this.DateRes_TextBox = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.JobPost_TexBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите значения в поля:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FullName_TextBox
            // 
            this.FullName_TextBox.Location = new System.Drawing.Point(15, 63);
            this.FullName_TextBox.Name = "FullName_TextBox";
            this.FullName_TextBox.Size = new System.Drawing.Size(277, 22);
            this.FullName_TextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "ФИО сотрудника:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Табельный номер сотрудника:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TabNumber_TextBox
            // 
            this.TabNumber_TextBox.Location = new System.Drawing.Point(15, 117);
            this.TabNumber_TextBox.Name = "TabNumber_TextBox";
            this.TabNumber_TextBox.Size = new System.Drawing.Size(277, 22);
            this.TabNumber_TextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email сотрудника:";
            // 
            // Email_TextBox
            // 
            this.Email_TextBox.Location = new System.Drawing.Point(15, 285);
            this.Email_TextBox.Name = "Email_TextBox";
            this.Email_TextBox.Size = new System.Drawing.Size(277, 22);
            this.Email_TextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Отделение сотрудника:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Дата поступления сотрудника:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Номер телефона сотрудника:";
            // 
            // Phone_TextBox
            // 
            this.Phone_TextBox.Location = new System.Drawing.Point(15, 342);
            this.Phone_TextBox.Name = "Phone_TextBox";
            this.Phone_TextBox.Size = new System.Drawing.Size(277, 22);
            this.Phone_TextBox.TabIndex = 9;
            // 
            // Department_TextBox
            // 
            this.Department_TextBox.FormattingEnabled = true;
            this.Department_TextBox.Location = new System.Drawing.Point(15, 173);
            this.Department_TextBox.Name = "Department_TextBox";
            this.Department_TextBox.Size = new System.Drawing.Size(277, 24);
            this.Department_TextBox.TabIndex = 13;
            // 
            // Accept_Button
            // 
            this.Accept_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Accept_Button.Location = new System.Drawing.Point(12, 451);
            this.Accept_Button.Name = "Accept_Button";
            this.Accept_Button.Size = new System.Drawing.Size(118, 36);
            this.Accept_Button.TabIndex = 14;
            this.Accept_Button.Text = "Сохранить";
            this.Accept_Button.UseVisualStyleBackColor = true;
            this.Accept_Button.Click += new System.EventHandler(this.Accept_Button_Click);
            // 
            // DateRes_TextBox
            // 
            this.DateRes_TextBox.Location = new System.Drawing.Point(15, 403);
            this.DateRes_TextBox.Name = "DateRes_TextBox";
            this.DateRes_TextBox.Size = new System.Drawing.Size(277, 22);
            this.DateRes_TextBox.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Должность сотрудника:";
            // 
            // JobPost_TexBox
            // 
            this.JobPost_TexBox.Location = new System.Drawing.Point(15, 228);
            this.JobPost_TexBox.Name = "JobPost_TexBox";
            this.JobPost_TexBox.Size = new System.Drawing.Size(277, 22);
            this.JobPost_TexBox.TabIndex = 16;
            // 
            // EmpCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(25, 25);
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.JobPost_TexBox);
            this.Controls.Add(this.DateRes_TextBox);
            this.Controls.Add(this.Accept_Button);
            this.Controls.Add(this.Department_TextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Phone_TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Email_TextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TabNumber_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FullName_TextBox);
            this.Controls.Add(this.label1);
            this.Name = "EmpCreate";
            this.Text = "Создание сотрудника";
            this.Load += new System.EventHandler(this.EmpCreate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FullName_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TabNumber_TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Email_TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Phone_TextBox;
        private System.Windows.Forms.ComboBox Department_TextBox;
        private System.Windows.Forms.Button Accept_Button;
        private System.Windows.Forms.DateTimePicker DateRes_TextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox JobPost_TexBox;
    }
}