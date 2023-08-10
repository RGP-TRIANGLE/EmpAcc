using ClosedXML.Excel;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TestApp.Model;
using TestApp.Service;
using TestApp.View;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Department = TestApp.Model.Department;

namespace TestApp
{
    public partial class Form1 : Form
    {
        Employee employee = new Employee();
        DataBaseRepository db = new DataBaseRepository();
        string DirectoryType;

        Department selected_department;

        public Form1()
        {
            InitializeComponent();
            DirectoryType = "Employee";
        }

        List<Employee> emp_list = new List<Employee>();
        List<Department> dep_list = new List<Department>();

        public void GridLoad()
        {
            try
            {
                Tab_Control.Visible = false;

                EmpGridView.DataSource = null;
                selected_employee = null;

                DepGridView.DataSource = null;
                selected_department = null;

                Tab_Control.TabPages.Clear();

                emp_list = db.GetEmployees().ToList();
                dep_list = db.GetDepartments().ToList();

                if (DirectoryType == "Employee")
                {
                    EmpGridView.Visible = true;
                    EmpGridView.Enabled = true;
                    DepSelect_Button.Visible = true;
                    FilterCancel_Button.Visible = false;
                    Search_Button.Visible = true;
                    Tab_Control.TabPages.Add(tabPage1);
                    Tab_Control.TabPages.Add(tabPage2);

                    DepGridView.Visible = false;
                    DepGridView.Enabled = false;

                    DataGrid_Info.Text = "Найдено: " + emp_list.Count;

                    Department_TextBox.DataSource = dep_list.Select(x => x.Name).ToList();
                    EmpGridView.DataSource = emp_list;
                    EmpGridView.ClearSelection();
                }
                else if (DirectoryType == "Department")
                {
                    EmpGridView.Visible = false;
                    EmpGridView.Enabled = false;
                    DepSelect_Button.Visible = false;
                    FilterCancel_Button.Visible = false;
                    Search_Button.Visible = false;

                    DepGridView.Visible = true;
                    DepGridView.Enabled = true;
                    Tab_Control.TabPages.Add(tabPage3);
                    Tab_Control.TabPages.Add(tabPage4);

                    DataGrid_Info.Text = "Найдено: " + dep_list.Count;

                    MainDep_TextBox.DataSource = dep_list.Select(x => x.Name).ToList();
                    Leader_TextBox.DataSource = emp_list.Select(x => x.FullName).ToList();
                    DepGridView.DataSource = dep_list;
                    DepGridView.ClearSelection();
                }

                Debug.WriteLine("Список успешно загружен");
            }
            catch (Exception e)
            {
                Debug.WriteLine("Ошибка при загрузке списке: " + e.Message);
                EmpGridView.DataSource = null;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db.SaveDepartment("1", "Управление", "-", "-", "Активно");
            db.SaveDepartment("2","АСУ", "Управление", "-","Активно");
            db.SaveDepartment("3", "ТП", "Управление", "-", "Активно");
            db.SaveDepartment("4", "Отдел продаж", "Управление", "-", "Активно");
            db.SaveDepartment("5", "ЦВЗ", "Управление", "-", "Закрыто");
            GridLoad();

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
                EditSave_Button.Visible = true;
                selected_employee = null;

                if (row.Cells[1].Value != null)
                {
                    selected_employee = db.GetEmployee(row.Cells[1].Value.ToString());

                    FullName_TextBox.Text = row.Cells[0].Value.ToString();
                    TabNumber_TextBox.Text = row.Cells[1].Value.ToString();
                    Department_TextBox.Text = row.Cells[2].Value.ToString();
                    JobPost_TexBox.Text = row.Cells[3].Value.ToString();
                    Email_TextBox.Text = row.Cells[4].Value.ToString();
                    Phone_TextBox.Text = row.Cells[5].Value.ToString();
                    DateRes_TextBox.Text = row.Cells[6].Value.ToString();

                    if (row.Cells[8].Value.ToString() == "Активно")
                    {
                        Dis_Label.Visible = false;
                        DateDis_TextBox.Visible = false;
                        StatusEdit_Button.Text = "Уволить сотрудника";
                    }
                    else
                    {
                        Dis_Label.Visible = true;
                        DateDis_TextBox.Visible = true;
                        DateDis_TextBox.Text = row.Cells[7].Value.ToString();
                        StatusEdit_Button.Text = "Восстановить сотрудника";
                    }
                }
                else
                {
                    EmpGridView.ClearSelection();
                    Tab_Control.Visible = false;
                }
            }
            catch (Exception ex)
            { 
                Debug.WriteLine("Произошла ошибка при выборе сотруднка: " + ex.Message);
            }
            
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if(EmpGridView.SelectedCells != null)
            {
                EmpGridView.ClearSelection();
                DepGridView.ClearSelection();
                Tab_Control.Visible = false;
            }
        }

        private void DeleteRecord_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if(selected_employee != null)
                {
                    Debug.WriteLine("Удалить запись сотрудника с табельным номером: " + selected_employee.ID);
                    db.DeleteEmployee(selected_employee);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Произошла ошибка при выборе сотруднка: " + ex.Message);
            }

            selected_employee = null;
            GridLoad();
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpCreate empCreate = new EmpCreate();
            empCreate.ShowDialog();
            GridLoad();

            //if(empCreate.ShowDialog() == DialogResult.OK)
            //{
            //    //Employee employee = empCreate.DialogWindowResult;

            //    //db.SaveEmployee(employee.FullName,employee.TabelNumber,employee.Department,employee.Email,employee.Phone,employee.DateReception,employee.DateDismissal,employee.RecordStatus);
            //    GridLoad();
            //}
        }


        private void EditSave_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (selected_employee != null)
                {
                    db.SaveEmployee(TabNumber_TextBox.Text, FullName_TextBox.Text, Department_TextBox.Text, JobPost_TexBox.Text, Email_TextBox.Text, Phone_TextBox.Text, DateRes_TextBox.Value, DateDis_TextBox.Value, selected_employee.RecordStatus);
                    EditSave_Button.Visible = true;
                    GridLoad();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Произошла ошибка при изменении данных сотрудника: " + ex.Message);
            }
        }

        //private void EmpInfo_TextChanged(object sender, KeyEventArgs e)
        //{
        //    EditSave_Button.Visible = true;
        //}

        private void EmpInfo_TextChanged(object sender, EventArgs e)
        {
            if(selected_employee.FullName != FullName_TextBox.Text ||
                selected_employee.Department != Department_TextBox.Text ||
                selected_employee.Phone != Phone_TextBox.Text ||
                selected_employee.Email != Email_TextBox.Text)
            {
                EditSave_Button.Visible = true;
            }
        }

        private void DateRes_TextBox_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (selected_employee != null)
                {
                    if (DateRes_TextBox.Value != selected_employee.DateReception || DateDis_TextBox.Value != selected_employee.DateDismissal || Department_TextBox.Text != selected_employee.Department)
                    {
                        EditSave_Button.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Произошла ошибка при изменении данных сотрудника: " + ex.Message);
            }
        }

        private void DepCreate_MenuItem_Click(object sender, EventArgs e)
        {
            DepCreate depCreate = new DepCreate();
            depCreate.ShowDialog();
            GridLoad();
        }

        private void DepGridShow_MenuItem_Click(object sender, EventArgs e)
        {
            DirectoryType = "Department";
            GridLoad();
        }

        private void EmpGridShow_MenuItem_Click(object sender, EventArgs e)
        {
            DirectoryType = "Employee";
            GridLoad();
        }

        private void DepDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.DepGridView.SelectedRows[0];
                Tab_Control.Visible = true;
                DepEditSave_Button.Visible = true;
                selected_department = null;

                if (row.Cells[1].Value != null)
                {
                    selected_department = db.GetDepartment(row.Cells[0].Value.ToString());

                    DepName_TextBox.Text = row.Cells[1].Value.ToString();
                    MainDep_TextBox.Text = row.Cells[2].Value.ToString();
                    Leader_TextBox.Text = row.Cells[3].Value.ToString();

                    if (row.Cells[4].Value.ToString() == "Активно")
                    {
                        ActiveDep_RadioButton.Checked = true;
                        ClosedDep_RadioButton.Checked = false;
                    }
                    else
                    {
                        ActiveDep_RadioButton.Checked = false;
                        ClosedDep_RadioButton.Checked = true;
                    }
                }
                else
                {
                    DepGridView.ClearSelection();
                    Tab_Control.Visible = false;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Произошла ошибка при выборе подразделения: " + ex.Message);
            }
        }

        private void DepRecord_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selected_department != null)
                {
                    Debug.WriteLine("Удалить запись подразделения под названием: " + selected_department.Name);
                    db.DeleteDepartment(selected_department);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Произошла ошибка при удалении подразделения: " + ex.Message);
            }

            selected_department = null;
            GridLoad();
        }

        private void DepEditSave_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (selected_department != null)
                {
                    string status = "";
                    
                    if(ActiveDep_RadioButton.Checked)
                    {
                        status = "Активно";
                    }
                    else
                    {
                        status = "Закрыто";
                    }

                    db.SaveDepartment(selected_department.ID, DepName_TextBox.Text, MainDep_TextBox.Text, Leader_TextBox.Text, status);
                    DepEditSave_Button.Visible = true;
                    GridLoad();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Произошла ошибка при изменении данных сотрудника: " + ex.Message);
            }
        }

        private void Dep_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (selected_department != null)
                {
                    EditSave_Button.Visible = true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Произошла ошибка при изменении данных подразделения: " + ex.Message);
            }
        }

        private void ComboBox_TextBox_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (selected_department != null)
                {
                    EditSave_Button.Visible = true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Произошла ошибка при изменении данных подразделения: " + ex.Message);
            }
        }

        private void Dep_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (selected_department.Name != FullName_TextBox.Text ||
                selected_department.MainDepartment != MainDep_TextBox.Text ||
                selected_department.Leader != Leader_TextBox.Text)
            {
                DepEditSave_Button.Visible = true;
            }
        }

        private void StatusEdit_Button_Click(object sender, EventArgs e)
        {
            if(selected_employee.RecordStatus == "Активно")
            {
                DialogWindow dialogWindow = new DialogWindow("Вы действительно хотите уволить сотрудника?");

                dialogWindow.ShowDialog();

                if(dialogWindow.DialogResult == DialogResult.OK)
                {
                    dialogWindow.Close();
                    db.SaveEmployee(selected_employee.ID, selected_employee.FullName, selected_employee.Department, selected_employee.JobPost, selected_employee.Email, selected_employee.Phone, selected_employee.DateReception, DateTime.Today, "Закрыто");
                    GridLoad();
                }
            }
            else
            {
                DialogWindow dialogWindow = new DialogWindow("Вы действительно хотите восстановить сотрудника?");

                dialogWindow.ShowDialog();

                if (dialogWindow.DialogResult == DialogResult.OK)
                {
                    dialogWindow.Close();
                    db.SaveEmployee(selected_employee.ID, selected_employee.FullName, selected_employee.Department, selected_employee.JobPost, selected_employee.Email, selected_employee.Phone, selected_employee.DateReception, new DateTime(), "Активно");
                    GridLoad();
                }
            }
        }

        private void EmpGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ImportBD_MenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("При импорте БД с файла Excel помните, что .xlsx файл должен быть заполнен таким же образом, как заполняется таблица в программе. При неккоректном заполнении данные могут сохраниться неверно или вовсе не сохраниться в БД.\n\nТакже помните, если два или более сотрудников имеют одинаковые табельные номера, в базе сохранится последний принятый сотрудник (Табельный номер = Уникальный идентификтор).\n\nВыберите файл .xlsx и импортируйте БД!");

                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Выберите файл";

                openFileDialog.Filter = "Файлы Excel (*.xlsx)|*.xlsx|Все файлы (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    if (!File.Exists(filePath))
                    {
                        Console.WriteLine("Файл не найден.");
                        return;
                    }

                    using (var workbook = new XLWorkbook(filePath))
                    {
                        var worksheet = workbook.Worksheet(1);
                        var rows = worksheet.RowsUsed();

                        //List<string> temp_list = new List<string>();
                        //Employee add_emp;

                        foreach (var row in rows.Skip(1))
                        {
                            try
                            {
                                DateTime dis = new DateTime();
                                string status = "Активно";
                                if (!String.IsNullOrEmpty(row.Cell(9).Value.ToString()))
                                {
                                    dis = DateTime.Parse(row.Cell(9).Value.ToString());
                                    status = "Закрыто";
                                }
                                else
                                {
                                    dis = new DateTime();
                                    status = "Активно";
                                }

                                db.SaveEmployee(row.Cell(3).Value.ToString(), row.Cell(2).Value.ToString(), row.Cell(5).Value.ToString(), row.Cell(4).Value.ToString(), row.Cell(6).Value.ToString(), row.Cell(7).Value.ToString(), DateTime.Parse(row.Cell(8).Value.ToString()), dis, status);
                            }
                            catch (Exception ex)
                            {
                                Debug.WriteLine("Ошибка при сохранении сотрудника при импорте: " + ex.Message);
                            }
                        }
                    }

                    GridLoad();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка при импорте БД: " + ex.Message);
                Debug.WriteLine("Ошибка при импорте БД: " + ex.Message);
            }

            
        }

        private void DepSelect_Button_Click(object sender, EventArgs e)
        {
            FilterDialogWindow filterDialogWindow = new FilterDialogWindow();
            filterDialogWindow.ShowDialog();

            if(filterDialogWindow.DialogResult == DialogResult.OK)
            {
                string filter = filterDialogWindow.DialogWindowResult;

                emp_list = db.GetEmployees().Where(x => x.Department == filter).ToList();
                EmpGridView.DataSource = emp_list;
                FilterCancel_Button.Visible = true;
                DataGrid_Info.Text = "Найдено: " + emp_list.Count;
            }
        }

        private void FilterCancel_Button_Click(object sender, EventArgs e)
        {
            GridLoad();
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            SearchWindow searchWindow = new SearchWindow();
            searchWindow.ShowDialog();

            if(searchWindow.DialogResult == DialogResult.OK)
            {
                emp_list = searchWindow.DialogWindowResult;
                EmpGridView.DataSource = emp_list;
                FilterCancel_Button.Visible = true;
                DataGrid_Info.Text = "Найдено: " + emp_list.Count;
            }
        }

        private void Analytic_MenuItem_Click(object sender, EventArgs e)
        {
            Analityc analyticWindow = new Analityc();
            analyticWindow.Show();

            //AnalyticWindow analyticWindow = new AnalyticWindow();
            //analyticWindow.Show();
        }

        private void Reference_MenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Здравствуйте! Я Равиль Гатин. Это тестовая программа для ведения учета сотрудников в фирме за 3 дня.\n" +
                "\n" +
                "1) Чтобы импортировать базу данных с фалйа Excel (формата таблицы в программе) нажмите на <<Файл>> -> <<Импортировать БД>>.\n" +
                "2) Чтобы создать нового сотрудника или подразделение, а также вывести их списки, перейдите во вкладку <<Справочники>>\n" +
                "3) Чтобы вывести статистику перейдите во вкладку <<Статистика>>\n" +
                "4) Чтобы изменить свойства справочника или удалить его воспользуйтесь боковым меню на главном экране\n" +
                "5) Чтобы изменить область поиска или фильтровать список воспользуйтесь кнопками <<Найти>> и <<Фильтровать>>\n\n" +
                "Приятного пользования программой!");
        }
    }
}
