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

        public void SaveEmployee(string full_name, int tabel_namber, string department, string email, string phone, DateTime date_reception, DateTime date_dismissal, string record_status)
        {
            using (var db = new LiteDatabase(@"DataBase4.db"))
            {
                try
                {
                    // Получаем коллекцию
                    var col = db.GetCollection<Employee>("Employees");

                    var save_emp = new Employee 
                    { 
                        FullName = full_name, 
                        TabelNumber = tabel_namber,
                        Department = department,
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
                            FullName = full_name,
                            TabelNumber = tabel_namber,
                            Department = department,
                            Email = email,
                            Phone = phone,
                            DateReception = date_reception,
                            DateDismissal = date_dismissal,
                            RecordStatus = record_status
                        } 
                    };

                    if (col.Find(x => x.TabelNumber == tabel_namber).FirstOrDefault() == null)
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
                    Debug.WriteLine("           Ошибка при сохранении организации в БД в репозитории: " + ex.Message);
                }
            }
        }

        public List<Employee> GetEmployees()
        {
            using (var db = new LiteDatabase(@"DataBase4.db"))
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
                        FullName = select_emp.FullName,
                        TabelNumber = select_emp.TabelNumber,
                        Department = select_emp.Department,
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

        public Employee GetEmployee(int tabel_number)
        {
            var employee = GetEmployees().Where(x => x.TabelNumber == tabel_number).FirstOrDefault();
            
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
            using (var db = new LiteDatabase(@"DataBase4.db"))
            {
                var col = db.GetCollection<Employee>("Employees");

                //var local_result = col.Find(x => x.TabelNumber == tab_number).FirstOrDefault();

                //Debug.WriteLine("           Физическое лицо для удаление определено: " + local_result.FullName);

                col.Delete(employee.FullName);

                Debug.WriteLine("           Физическое лицо удалено из БД");
            }
        }

        public void DeleteAllEmployees()
        {
            using (var db = new LiteDatabase(@"DataBase4.db"))
            {
                var col = db.GetCollection<Employee>("Employees");

                col.DeleteAll();

                Debug.WriteLine("           Физические лица удалены из БД");
            }
        }

        #endregion
    }
}
