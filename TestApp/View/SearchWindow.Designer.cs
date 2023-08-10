namespace TestApp.View
{
    partial class SearchWindow
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
            this.label2 = new System.Windows.Forms.Label();
            this.Name_RB = new System.Windows.Forms.RadioButton();
            this.TabNumber_RB = new System.Windows.Forms.RadioButton();
            this.JobPost_RB = new System.Windows.Forms.RadioButton();
            this.Search_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Accept_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите критерий для поиска и введите значение:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Критерий:";
            // 
            // Name_RB
            // 
            this.Name_RB.AutoSize = true;
            this.Name_RB.Location = new System.Drawing.Point(16, 87);
            this.Name_RB.Name = "Name_RB";
            this.Name_RB.Size = new System.Drawing.Size(59, 20);
            this.Name_RB.TabIndex = 2;
            this.Name_RB.TabStop = true;
            this.Name_RB.Text = "ФИО";
            this.Name_RB.UseVisualStyleBackColor = true;
            this.Name_RB.CheckedChanged += new System.EventHandler(this.Name_RB_CheckedChanged);
            // 
            // TabNumber_RB
            // 
            this.TabNumber_RB.AutoSize = true;
            this.TabNumber_RB.Location = new System.Drawing.Point(81, 87);
            this.TabNumber_RB.Name = "TabNumber_RB";
            this.TabNumber_RB.Size = new System.Drawing.Size(145, 20);
            this.TabNumber_RB.TabIndex = 3;
            this.TabNumber_RB.TabStop = true;
            this.TabNumber_RB.Text = "Табельный номер";
            this.TabNumber_RB.UseVisualStyleBackColor = true;
            this.TabNumber_RB.CheckedChanged += new System.EventHandler(this.TabNumber_RB_CheckedChanged);
            // 
            // JobPost_RB
            // 
            this.JobPost_RB.AutoSize = true;
            this.JobPost_RB.Location = new System.Drawing.Point(232, 87);
            this.JobPost_RB.Name = "JobPost_RB";
            this.JobPost_RB.Size = new System.Drawing.Size(99, 20);
            this.JobPost_RB.TabIndex = 4;
            this.JobPost_RB.TabStop = true;
            this.JobPost_RB.Text = "Должность";
            this.JobPost_RB.UseVisualStyleBackColor = true;
            this.JobPost_RB.CheckedChanged += new System.EventHandler(this.JobPost_RB_CheckedChanged);
            // 
            // Search_TextBox
            // 
            this.Search_TextBox.Location = new System.Drawing.Point(16, 144);
            this.Search_TextBox.Name = "Search_TextBox";
            this.Search_TextBox.Size = new System.Drawing.Size(362, 22);
            this.Search_TextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Искать:";
            // 
            // Accept_Button
            // 
            this.Accept_Button.Location = new System.Drawing.Point(16, 188);
            this.Accept_Button.Name = "Accept_Button";
            this.Accept_Button.Size = new System.Drawing.Size(119, 37);
            this.Accept_Button.TabIndex = 7;
            this.Accept_Button.Text = "Применить";
            this.Accept_Button.UseVisualStyleBackColor = true;
            this.Accept_Button.Click += new System.EventHandler(this.Accept_Button_Click);
            // 
            // SearchWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 244);
            this.Controls.Add(this.Accept_Button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Search_TextBox);
            this.Controls.Add(this.JobPost_RB);
            this.Controls.Add(this.TabNumber_RB);
            this.Controls.Add(this.Name_RB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SearchWindow";
            this.Text = "Поиск";
            this.Load += new System.EventHandler(this.SearchWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton Name_RB;
        private System.Windows.Forms.RadioButton TabNumber_RB;
        private System.Windows.Forms.RadioButton JobPost_RB;
        private System.Windows.Forms.TextBox Search_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Accept_Button;
    }
}