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

namespace TestApp.View
{
    public partial class DepCreate : Form
    {
        public DepCreate()
        {
            InitializeComponent();
        }

        private void DepCreate_Load(object sender, EventArgs e)
        {
            MainDep_TextBox.DataSource = db.GetDepartments().Select(x => x.Name).ToList();
            Leader_TextBox.DataSource = db.GetEmployees().Select(x=>x.FullName).ToList();
        }

        DataBaseRepository db = new DataBaseRepository();
        Department department;

        private void Accept_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if(!String.IsNullOrEmpty(Name_TextBox.Text))
                {
                    db.SaveDepartment(Guid.NewGuid().ToString(), Name_TextBox.Text, MainDep_TextBox.Text, Leader_TextBox.Text, "Активно");
                    this.Dispose(); this.Close();
                }
                else
                {
                    MessageBox.Show("Вы заполнили не все поля!");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("           Ошибка при сохранении сотрудника в окне создания: " + ex.Message);
            }

        }
    }
}
