namespace TestApp.View
{
    partial class DepCreate
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
            this.components = new System.ComponentModel.Container();
            this.Accept_Button = new System.Windows.Forms.Button();
            this.Leader_TextBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Name_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MainDep_TextBox = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Accept_Button
            // 
            this.Accept_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Accept_Button.Location = new System.Drawing.Point(15, 232);
            this.Accept_Button.Name = "Accept_Button";
            this.Accept_Button.Size = new System.Drawing.Size(118, 36);
            this.Accept_Button.TabIndex = 26;
            this.Accept_Button.Text = "Сохранить";
            this.Accept_Button.UseVisualStyleBackColor = true;
            this.Accept_Button.Click += new System.EventHandler(this.Accept_Button_Click);
            // 
            // Leader_TextBox
            // 
            this.Leader_TextBox.FormattingEnabled = true;
            this.Leader_TextBox.Location = new System.Drawing.Point(15, 184);
            this.Leader_TextBox.Name = "Leader_TextBox";
            this.Leader_TextBox.Size = new System.Drawing.Size(277, 24);
            this.Leader_TextBox.TabIndex = 25;
            this.Leader_TextBox.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(322, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Руководитель подразделения (необязательно):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Головное подразделение (необязательно):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Наименование подразделения:";
            // 
            // Name_TextBox
            // 
            this.Name_TextBox.Location = new System.Drawing.Point(15, 74);
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.Size = new System.Drawing.Size(277, 22);
            this.Name_TextBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Введите значения в поля:";
            // 
            // MainDep_TextBox
            // 
            this.MainDep_TextBox.FormattingEnabled = true;
            this.MainDep_TextBox.Location = new System.Drawing.Point(15, 128);
            this.MainDep_TextBox.Name = "MainDep_TextBox";
            this.MainDep_TextBox.Size = new System.Drawing.Size(277, 24);
            this.MainDep_TextBox.TabIndex = 27;
            this.MainDep_TextBox.Text = "-";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(TestApp.Model.Employee);
            // 
            // DepCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 280);
            this.Controls.Add(this.MainDep_TextBox);
            this.Controls.Add(this.Accept_Button);
            this.Controls.Add(this.Leader_TextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Name_TextBox);
            this.Controls.Add(this.label1);
            this.Name = "DepCreate";
            this.Text = "Создание подразделения";
            this.Load += new System.EventHandler(this.DepCreate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Accept_Button;
        private System.Windows.Forms.ComboBox Leader_TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Name_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.ComboBox MainDep_TextBox;
    }
}