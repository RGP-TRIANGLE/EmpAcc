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

namespace TestApp
{
    public partial class Form1 : Form
    {
        Employee employee = new Employee();
        DataBaseRepository db = new DataBaseRepository();
        

        public Form1()
        {
            InitializeComponent();
        }

        public void EmployeesLoad()
        {
            try
            {
                EmpGridView.DataSource = null;
                EmpGridView.DataSource = db.GetEmployees().ToList();
                EmpGridView.ClearSelection();
            }
            catch 
            {
                EmpGridView.DataSource = null;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //db.SaveEmployee("Фролов Петр Евгеньевич", "E90183", "АСУП", "frolov@yandex.ru", "89762873432", new DateTime(2015, 7, 20), new DateTime(2021, 4, 12), "Закрыто");
            //db.SaveEmployee("Тошкин Дмитрий Александрович", "У90183", "ПРВ","toshkin@mail.ru","89172343233", new DateTime(2017, 7, 20), new DateTime(), "Активно");
            //db.SaveEmployee("Элеваторный Петр Сергеевич", "В42181", "АСУП", "evevator@mail.ru", "89532332312", new DateTime(2013, 4, 7), new DateTime(), "Активно");
            EmployeesLoad();

            EmpGridView.ClearSelection();
            Tab_Control.Visible = false;
        }

        Employee selected_employee;

        private void EmpGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.EmpGridView.SelectedRows[0];
                Tab_Control.Visible = true;

                selected_employee = db.GetEmployee(row.Cells[1].Value.ToString());

                FullName_TextBox.Text = row.Cells[0].Value.ToString();
                TabNumber_TextBox.Text = row.Cells[1].Value.ToString();
                Department_TextBox.Text = row.Cells[2].Value.ToString();
                Email_TextBox.Text = row.Cells[3].Value.ToString();
                Phone_TextBox.Text = row.Cells[4].Value.ToString();
                DateRes_TextBox.Text = row.Cells[5].Value.ToString();


                if (row.Cells[7].Value.ToString() == "Активно")
                {
                    Dis_Label.Visible = false;
                    DateDis_TextBox.Visible = false;
                    StatusEdit_Button.Text = "Уволить сотрудника";
                }
                else
                {
                    Dis_Label.Visible = true;
                    DateDis_TextBox.Visible = true;
                    DateDis_TextBox.Text = row.Cells[6].Value.ToString();
                    StatusEdit_Button.Text = "Восстановить сотрудника";
                }
            }
            catch
            { 
            }
            
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if(EmpGridView.SelectedCells != null)
            {
                EmpGridView.ClearSelection();
                Tab_Control.Visible = false;
            }
        }

        private void DeleteRecord_Button_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Удалить запись сотрудника с табельным номером: " + selected_employee.TabelNumber);
            db.DeleteEmployee(selected_employee);
            selected_employee = null;
            EmployeesLoad();
        }
    }
}
