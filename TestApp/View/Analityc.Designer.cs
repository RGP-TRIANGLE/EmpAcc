namespace TestApp.View
{
    partial class Analityc
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Dep_ComboBox = new System.Windows.Forms.ComboBox();
            this.All_RB = new System.Windows.Forms.RadioButton();
            this.Dep_RB = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AllTime_RB = new System.Windows.Forms.RadioButton();
            this.Period_RB = new System.Windows.Forms.RadioButton();
            this.PeriodStart_Picker = new System.Windows.Forms.DateTimePicker();
            this.PeriodFinish_Picker = new System.Windows.Forms.DateTimePicker();
            this.Period1_Label = new System.Windows.Forms.Label();
            this.Period2_Label = new System.Windows.Forms.Label();
            this.ChartView_Button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Chart
            // 
            this.Chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart.Legends.Add(legend1);
            this.Chart.Location = new System.Drawing.Point(12, 199);
            this.Chart.Name = "Chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Chart.Series.Add(series1);
            this.Chart.Size = new System.Drawing.Size(814, 346);
            this.Chart.TabIndex = 0;
            this.Chart.Text = "chart1";
            // 
            // Dep_ComboBox
            // 
            this.Dep_ComboBox.FormattingEnabled = true;
            this.Dep_ComboBox.Location = new System.Drawing.Point(226, 4);
            this.Dep_ComboBox.Name = "Dep_ComboBox";
            this.Dep_ComboBox.Size = new System.Drawing.Size(191, 24);
            this.Dep_ComboBox.TabIndex = 2;
            // 
            // All_RB
            // 
            this.All_RB.AutoSize = true;
            this.All_RB.Location = new System.Drawing.Point(3, 4);
            this.All_RB.Name = "All_RB";
            this.All_RB.Size = new System.Drawing.Size(52, 20);
            this.All_RB.TabIndex = 3;
            this.All_RB.TabStop = true;
            this.All_RB.Text = "Все";
            this.All_RB.UseVisualStyleBackColor = true;
            this.All_RB.CheckedChanged += new System.EventHandler(this.All_RB_CheckedChanged);
            // 
            // Dep_RB
            // 
            this.Dep_RB.AutoSize = true;
            this.Dep_RB.Location = new System.Drawing.Point(64, 4);
            this.Dep_RB.Name = "Dep_RB";
            this.Dep_RB.Size = new System.Drawing.Size(155, 20);
            this.Dep_RB.TabIndex = 4;
            this.Dep_RB.TabStop = true;
            this.Dep_RB.Text = "По подразделению";
            this.Dep_RB.UseVisualStyleBackColor = true;
            this.Dep_RB.CheckedChanged += new System.EventHandler(this.Dep_RB_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите область для статистики:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Выберите время для статистики:";
            // 
            // AllTime_RB
            // 
            this.AllTime_RB.AutoSize = true;
            this.AllTime_RB.Location = new System.Drawing.Point(4, 5);
            this.AllTime_RB.Name = "AllTime_RB";
            this.AllTime_RB.Size = new System.Drawing.Size(114, 20);
            this.AllTime_RB.TabIndex = 6;
            this.AllTime_RB.TabStop = true;
            this.AllTime_RB.Text = "За все время";
            this.AllTime_RB.UseVisualStyleBackColor = true;
            this.AllTime_RB.CheckedChanged += new System.EventHandler(this.AllTime_RB_CheckedChanged);
            // 
            // Period_RB
            // 
            this.Period_RB.AutoSize = true;
            this.Period_RB.Location = new System.Drawing.Point(138, 5);
            this.Period_RB.Name = "Period_RB";
            this.Period_RB.Size = new System.Drawing.Size(96, 20);
            this.Period_RB.TabIndex = 7;
            this.Period_RB.TabStop = true;
            this.Period_RB.Text = "За период";
            this.Period_RB.UseVisualStyleBackColor = true;
            this.Period_RB.CheckedChanged += new System.EventHandler(this.Period_RB_CheckedChanged);
            // 
            // PeriodStart_Picker
            // 
            this.PeriodStart_Picker.Location = new System.Drawing.Point(284, 108);
            this.PeriodStart_Picker.Name = "PeriodStart_Picker";
            this.PeriodStart_Picker.Size = new System.Drawing.Size(200, 22);
            this.PeriodStart_Picker.TabIndex = 8;
            // 
            // PeriodFinish_Picker
            // 
            this.PeriodFinish_Picker.Location = new System.Drawing.Point(523, 108);
            this.PeriodFinish_Picker.Name = "PeriodFinish_Picker";
            this.PeriodFinish_Picker.Size = new System.Drawing.Size(200, 22);
            this.PeriodFinish_Picker.TabIndex = 9;
            // 
            // Period1_Label
            // 
            this.Period1_Label.AutoSize = true;
            this.Period1_Label.Location = new System.Drawing.Point(264, 114);
            this.Period1_Label.Name = "Period1_Label";
            this.Period1_Label.Size = new System.Drawing.Size(14, 16);
            this.Period1_Label.TabIndex = 10;
            this.Period1_Label.Text = "с";
            // 
            // Period2_Label
            // 
            this.Period2_Label.AutoSize = true;
            this.Period2_Label.Location = new System.Drawing.Point(494, 113);
            this.Period2_Label.Name = "Period2_Label";
            this.Period2_Label.Size = new System.Drawing.Size(23, 16);
            this.Period2_Label.TabIndex = 11;
            this.Period2_Label.Text = "по";
            // 
            // ChartView_Button
            // 
            this.ChartView_Button.Location = new System.Drawing.Point(15, 154);
            this.ChartView_Button.Name = "ChartView_Button";
            this.ChartView_Button.Size = new System.Drawing.Size(168, 32);
            this.ChartView_Button.TabIndex = 12;
            this.ChartView_Button.Text = "Вывести";
            this.ChartView_Button.UseVisualStyleBackColor = true;
            this.ChartView_Button.Click += new System.EventHandler(this.ChartView_Button_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.All_RB);
            this.panel1.Controls.Add(this.Dep_RB);
            this.panel1.Controls.Add(this.Dep_ComboBox);
            this.panel1.Location = new System.Drawing.Point(15, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 44);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AllTime_RB);
            this.panel2.Controls.Add(this.Period_RB);
            this.panel2.Location = new System.Drawing.Point(15, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 33);
            this.panel2.TabIndex = 14;
            // 
            // Analityc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.ClientSize = new System.Drawing.Size(838, 557);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ChartView_Button);
            this.Controls.Add(this.Period2_Label);
            this.Controls.Add(this.Period1_Label);
            this.Controls.Add(this.PeriodFinish_Picker);
            this.Controls.Add(this.PeriodStart_Picker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Chart);
            this.Name = "Analityc";
            this.Text = "Статистика";
            this.Load += new System.EventHandler(this.AnalyticWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.ComboBox Dep_ComboBox;
        private System.Windows.Forms.RadioButton All_RB;
        private System.Windows.Forms.RadioButton Dep_RB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton AllTime_RB;
        private System.Windows.Forms.RadioButton Period_RB;
        private System.Windows.Forms.DateTimePicker PeriodStart_Picker;
        private System.Windows.Forms.DateTimePicker PeriodFinish_Picker;
        private System.Windows.Forms.Label Period1_Label;
        private System.Windows.Forms.Label Period2_Label;
        private System.Windows.Forms.Button ChartView_Button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}