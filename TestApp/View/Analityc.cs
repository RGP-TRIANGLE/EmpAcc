using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TestApp.Model;
using TestApp.Service;

namespace TestApp.View
{
    public partial class Analityc : Form
    {
        public Analityc()
        {
            InitializeComponent();
        }

        DataBaseRepository db = new DataBaseRepository();

        string region = "all";
        string period = "all";

        private void AnalyticWindow_Load(object sender, EventArgs e)
        {
            Chart.Visible = false;
            AllTime_RB.Checked = true;
            All_RB.Checked = true;
            Dep_ComboBox.DataSource = db.GetDepartments().Select(x=>x.Name).ToList();
        }

        List<Employee> employees;

        Series ChartSeries = new Series();

        private void ChartView_Button_Click(object sender, EventArgs e)
        {
            if (region == "all")
            {
                employees = db.GetEmployees().ToList();
            }
            else if (region == "dep")
            {
                employees = db.GetEmployees().Where(x => x.Department == Dep_ComboBox.SelectedValue.ToString()).ToList();
            }

            if (period == "per")
            {
                if (PeriodFinish_Picker.Value < PeriodStart_Picker.Value)
                {
                    MessageBox.Show("Вы установили некорректный период!");
                }
                else
                {
                    employees = employees.Where(x => x.DateReception >= PeriodStart_Picker.Value && x.DateDismissal <= PeriodFinish_Picker.Value).ToList();
                }
            }

            int dis = 0;
            int res = 0;

            foreach (var item in employees)
            {
                if (item.RecordStatus == "Активно")
                {
                    res++;
                }
                else
                {
                    dis++;
                }
            }

            Chart.Visible = true;
            Chart.Series.Clear();
            Chart.Titles.Clear();
            Chart.Palette = ChartColorPalette.BrightPastel;
            Chart.Titles.Add("Статистика приема/увольнения на работу");
            Series chart_series_1 =  Chart.Series.Add("Прием");
            chart_series_1.Points.Add(res);
            Series chart_series_2 = Chart.Series.Add("Увольнение");
            chart_series_2.Points.Add(dis);

        }

        private void All_RB_CheckedChanged(object sender, EventArgs e)
        {
            Dep_ComboBox.Visible = false;
            region = "all";
        }

        private void Dep_RB_CheckedChanged(object sender, EventArgs e)
        {
            Dep_ComboBox.Visible = true;
            region = "dep";
        }

        private void AllTime_RB_CheckedChanged(object sender, EventArgs e)
        {
            Period1_Label.Visible = false;
            Period2_Label.Visible = false;
            PeriodStart_Picker.Visible = false;
            PeriodFinish_Picker.Visible = false;
            period = "all";
        }

        private void Period_RB_CheckedChanged(object sender, EventArgs e)
        {
            Period1_Label.Visible = true;
            Period2_Label.Visible = true;
            PeriodStart_Picker.Visible = true;
            PeriodFinish_Picker.Visible = true;
            period = "per";
        }
    }
}
