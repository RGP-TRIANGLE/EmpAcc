namespace TestApp.View
{
    partial class DialogWindow
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
            this.Accept_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Dialog_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Accept_Button
            // 
            this.Accept_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Accept_Button.Location = new System.Drawing.Point(12, 68);
            this.Accept_Button.Name = "Accept_Button";
            this.Accept_Button.Size = new System.Drawing.Size(189, 45);
            this.Accept_Button.TabIndex = 1;
            this.Accept_Button.Text = "Принять и продолжить";
            this.Accept_Button.UseVisualStyleBackColor = true;
            this.Accept_Button.Click += new System.EventHandler(this.Accept_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel_Button.Location = new System.Drawing.Point(223, 68);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(119, 45);
            this.Cancel_Button.TabIndex = 2;
            this.Cancel_Button.Text = "Отмена";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Dialog_Label
            // 
            this.Dialog_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dialog_Label.AutoEllipsis = true;
            this.Dialog_Label.AutoSize = true;
            this.Dialog_Label.Location = new System.Drawing.Point(12, 9);
            this.Dialog_Label.Name = "Dialog_Label";
            this.Dialog_Label.Size = new System.Drawing.Size(44, 16);
            this.Dialog_Label.TabIndex = 0;
            this.Dialog_Label.Text = "label1";
            // 
            // DialogWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.ClientSize = new System.Drawing.Size(354, 125);
            this.Controls.Add(this.Dialog_Label);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Accept_Button);
            this.MaximizeBox = false;
            this.Name = "DialogWindow";
            this.Text = "Условие";
            this.Load += new System.EventHandler(this.DialogWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Accept_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Label Dialog_Label;
    }
}