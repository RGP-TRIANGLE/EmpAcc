﻿namespace TestApp.View
{
    partial class FilterDialogWindow
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
            this.Accept_Button = new System.Windows.Forms.Button();
            this.Type_ComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите подразделение:";
            // 
            // Accept_Button
            // 
            this.Accept_Button.Location = new System.Drawing.Point(10, 81);
            this.Accept_Button.Name = "Accept_Button";
            this.Accept_Button.Size = new System.Drawing.Size(118, 34);
            this.Accept_Button.TabIndex = 4;
            this.Accept_Button.Text = "Применить";
            this.Accept_Button.UseVisualStyleBackColor = true;
            this.Accept_Button.Click += new System.EventHandler(this.Accept_Button_Click);
            // 
            // Type_ComboBox
            // 
            this.Type_ComboBox.FormattingEnabled = true;
            this.Type_ComboBox.Location = new System.Drawing.Point(10, 38);
            this.Type_ComboBox.Name = "Type_ComboBox";
            this.Type_ComboBox.Size = new System.Drawing.Size(241, 24);
            this.Type_ComboBox.TabIndex = 5;
            // 
            // FilterDialogWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 132);
            this.Controls.Add(this.Type_ComboBox);
            this.Controls.Add(this.Accept_Button);
            this.Controls.Add(this.label1);
            this.Name = "FilterDialogWindow";
            this.Text = "Фильтр";
            this.Load += new System.EventHandler(this.FilterDialogWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Accept_Button;
        private System.Windows.Forms.ComboBox Type_ComboBox;
    }
}