using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestApp.Model;
using TestApp.Service;

namespace TestApp.View
{
    public partial class SearchWindow : Form
    {
        public SearchWindow()
        {
            InitializeComponent();
        }

        DataBaseRepository db = new DataBaseRepository();

        private void Name_RB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TabNumber_RB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void JobPost_RB_CheckedChanged(object sender, EventArgs e)
        {

        }

        List<Employee> employees = new List<Employee>();

        public List<Employee> DialogWindowResult
        {
            get { return employees; }
        }

        private void Accept_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(Search_TextBox.Text))
                {
                    if (Name_RB.Checked)
                    {
                        employees = db.GetEmployees().Where(x => x.FullName.ToLower().Contains(Search_TextBox.Text.ToLower())).ToList();

                        this.DialogResult = DialogResult.OK;
                        Close();
                    }
                    else if (TabNumber_RB.Checked)
                    {
                        employees = db.GetEmployees().Where(x => x.ID.ToLower().Contains(Search_TextBox.Text.ToLower())).ToList();

                        this.DialogResult = DialogResult.OK;
                        Close();
                    }
                    else if (JobPost_RB.Checked)
                    {
                        employees = db.GetEmployees().Where(x => x.JobPost.ToLower().Contains(Search_TextBox.Text.ToLower())).ToList();

                        this.DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Вы не установили критерий для поиска!");
                    }
                }
                else
                {
                    MessageBox.Show("Вы не ввели значение в строку поиска!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("При поиске произошла ошибка! Проверьте введенные данные и повторите попытку. Ошибка: " + ex.Message);
            }
        }

        private void SearchWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
