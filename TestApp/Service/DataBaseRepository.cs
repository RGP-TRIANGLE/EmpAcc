using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
using TestApp.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TestApp.Service
{
    public class DataBaseRepository
    {
        #region Employee

        Employee emp = new Employee();
        public IList<Employee> Employeeslist { get; set; }

        public void SaveEmployee(string ID, string full_name, string department, string job_post, string email, string phone, DateTime date_reception, DateTime date_dismissal, string record_status)
        {
            using (var db = new LiteDatabase(@"DataBase20.db"))
            {
                try
                {
                    // Получаем коллекцию
                    var col = db.GetCollection<Employee>("Employees");

                    var save_emp = new Employee 
                    { 
                        ID = ID,
                        FullName = full_name, 
                        //TabelNumber = tabel_namber,
                        Department = department,
                        JobPost = job_post,
                        Email = email,
                        Phone = phone,
                        DateReception = date_reception,
                        DateDismissal = date_dismissal,
                        RecordStatus = record_status
                    };

                    save_emp.EmployeesRepository = new List<Employee> 
                    { 
                        new Employee 
                        {
                            ID = save_emp.ID,
                            FullName = full_name,
                            //TabelNumber = tabel_namber,
                            Department = department,
                            JobPost = job_post,
                            Email = email,
                            Phone = phone,
                            DateReception = date_reception,
                            DateDismissal = date_dismissal,
                            RecordStatus = record_status
                        } 
                    };

                    if (col.Find(x => x.ID == ID).FirstOrDefault() == null)
                    {
                        col.Insert(save_emp);
                        Debug.WriteLine("           Физическое лицо сохранено в БД");
                    }
                    else
                    {
                        col.Update(save_emp);
                        Debug.WriteLine("           Физическое лицо обновлено в БД");
                    }


                }
                catch (Exception ex)
                {
                    Debug.WriteLine("           Ошибка при сохранении сотрудника в БД в репозитории: " + ex.Message);
                }
            }
        }

        public List<Employee> GetEmployees()
        {
            using (var db = new LiteDatabase(@"DataBase20.db"))
            {
                Employeeslist = new List<Employee>();

                var col = db.GetCollection<Employee>("Employees");

                if (col.FindAll().Count() > 0)
                {
                    var local_result = col.FindAll();

                    Debug.WriteLine("           Список физических лиц НАЙДЕН");

                    var lst = col.FindAll().Select(select_emp =>
                    new Employee
                    {
                        ID = select_emp.ID,
                        FullName = select_emp.FullName,
                        Department = select_emp.Department,
                        JobPost = select_emp.JobPost,
                        Email = select_emp.Email,
                        Phone = select_emp.Phone,
                        DateReception = select_emp.DateReception,
                        DateDismissal = select_emp.DateDismissal,
                        RecordStatus = select_emp.RecordStatus


                    });

                    Employeeslist = new List<Employee>(lst);

                    return (List<Employee>)Employeeslist;
                }
                else
                {
                    Debug.WriteLine("           Список физических лиц НЕ найден");
                    return null;
                }
            }
        }

        public Employee GetEmployee(string ID)
        {
            var employee = GetEmployees().Where(x => x.ID == ID).FirstOrDefault();
            
            if(employee != null)
            {
                return employee;
            }
            else
            {
                return null;
            }
        }

        public void DeleteEmployee(Employee employee)
        {
            using (var db = new LiteDatabase(@"DataBase20.db"))
            {
                try
                {
                    var col = db.GetCollection<Employee>("Employees");

                    //var local_result = col.Find(x => x.TabelNumber == tab_number).FirstOrDefault();

                    //Debug.WriteLine("           Физическое лицо для удаление определено: " + local_result.FullName);

                    col.Delete(employee.ID);

                    Debug.WriteLine("           Физическое лицо удалено из БД");
                }
                catch(Exception e)
                {
                    Debug.WriteLine("Ошибка при удалении сотрудника: " + e.Message);
                }
                
            }
        }

        public void DeleteAllEmployees()
        {
            using (var db = new LiteDatabase(@"DataBase20.db"))
            {
                var col = db.GetCollection<Employee>("Employees");

                col.DeleteAll();

                Debug.WriteLine("           Физические лица удалены из БД");
            }
        }

        #endregion





        #region Department

        Department dep = new Department();
        public IList<Department> Departmentslist { get; set; }

        public void SaveDepartment(string ID, string name, string main_department, string leader, string status)
        {
            using (var db = new LiteDatabase(@"DataBase20.db"))
            {
                try
                {
                    // Получаем коллекцию
                    var col = db.GetCollection<Department>("Departments");

                    var save_emp = new Department
                    {
                        ID = ID,
                        Name = name,
                        MainDepartment = main_department,
                        Leader = leader,
                        RecordStatus = status
                    };

                    save_emp.DepartmentsRepository = new List<Department>
                    {
                        new Department
                        {
                            ID = save_emp.ID,
                            Name = name,
                            MainDepartment = main_department,
                            Leader = leader,
                            RecordStatus = status
                        }
                    };

                    if (col.Find(x => x.ID == ID).FirstOrDefault() == null)
                    {
                        col.Insert(save_emp);
                        Debug.WriteLine("           Физическое лицо сохранено в БД");
                    }
                    else
                    {
                        col.Update(save_emp);
                        Debug.WriteLine("           Физическое лицо создано в БД");
                    }


                }
                catch (Exception ex)
                {
                    Debug.WriteLine("           Ошибка при сохранении сотрудника в БД в репозитории: " + ex.Message);
                }
            }
        }

        public List<Department> GetDepartments()
        {
            using (var db = new LiteDatabase(@"DataBase20.db"))
            {
                Departmentslist = new List<Department>();

                var col = db.GetCollection<Department>("Departments");

                if (col.FindAll().Count() > 0)
                {
                    var local_result = col.FindAll();

                    Debug.WriteLine("           Список физических лиц НАЙДЕН");

                    var lst = col.FindAll().Select(select_emp =>
                    new Department
                    {
                        ID = select_emp.ID,
                        Name = select_emp.Name,
                        MainDepartment = select_emp.MainDepartment,
                        Leader = select_emp.Leader,
                        RecordStatus = select_emp.RecordStatus,
                    });

                    Departmentslist = new List<Department>(lst);

                    return (List<Department>)Departmentslist;
                }
                else
                {
                    Debug.WriteLine("           Список физических лиц НЕ найден");
                    return null;
                }
            }
        }

        public Department GetDepartment(string ID)
        {
            var employee = GetDepartments().Where(x => x.ID == ID).FirstOrDefault();

            if (employee != null)
            {
                return employee;
            }
            else
            {
                return null;
            }
        }

        public void DeleteDepartment(Department department)
        {
            using (var db = new LiteDatabase(@"DataBase20.db"))
            {
                try
                {
                    var col = db.GetCollection<Department>("Departments");

                    //var local_result = col.Find(x => x.TabelNumber == tab_number).FirstOrDefault();

                    //Debug.WriteLine("           Физическое лицо для удаление определено: " + local_result.FullName);

                    col.Delete(department.ID);

                    Debug.WriteLine("           Физическое лицо удалено из БД");
                }
                catch (Exception e)
                {
                    Debug.WriteLine("Ошибка при удалении сотрудника: " + e.Message);
                }

            }
        }

        public void DeleteAllDepartments()
        {
            using (var db = new LiteDatabase(@"DataBase20.db"))
            {
                var col = db.GetCollection<Department>("Departments");

                col.DeleteAll();

                Debug.WriteLine("           Физические лица удалены из БД");
            }
        }

        #endregion
    }
}
