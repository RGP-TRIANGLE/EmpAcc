using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestApp.Model;
using TestApp.Service;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TestApp.View
{
    public partial class EmpCreate : Form
    {
        public EmpCreate()
        {
            InitializeComponent();
        }
        DataBaseRepository db = new DataBaseRepository();
        Employee employee;

        private void Accept_Button_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(FullName_TextBox.Text) && !String.IsNullOrEmpty(TabNumber_TextBox.Text) && !String.IsNullOrEmpty(Department_TextBox.Text) && !String.IsNullOrEmpty(JobPost_TexBox.Text) && !String.IsNullOrEmpty(Email_TextBox.Text) && !String.IsNullOrEmpty(Phone_TextBox.Text) && !String.IsNullOrEmpty(DateRes_TextBox.Value.ToString()))
            {
                try
                {
                    db.SaveEmployee(TabNumber_TextBox.Text, FullName_TextBox.Text, Department_TextBox.Text, JobPost_TexBox.Text, Email_TextBox.Text, Phone_TextBox.Text, DateRes_TextBox.Value, new DateTime(), "Активно");
                    this.Dispose(); this.Close();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("           Ошибка при сохранении сотрудника в окне создания: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Вы заполнили не все поля!");
            }
            
        }

        //public Employee DialogWindowResult
        //{
        //    get { return employee; }
        //}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void EmpCreate_Load(object sender, EventArgs e)
        {
            Department_TextBox.DataSource = db.GetDepartments().Select(x => x.Name).ToList();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
