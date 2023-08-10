using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestApp.Service;

namespace TestApp.View
{
    public partial class FilterDialogWindow : Form
    {
        public FilterDialogWindow()
        {
            InitializeComponent();
        }

        string result;

        public string DialogWindowResult
        {
            get { return result; }
        }

        private void Accept_Button_Click(object sender, EventArgs e)
        {
            result = Type_ComboBox.SelectedValue.ToString();
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void FilterDialogWindow_Load(object sender, EventArgs e)
        {
            Type_ComboBox.DataSource = db.GetDepartments().Select(x=>x.Name).ToList();
        }

        DataBaseRepository db = new DataBaseRepository();

    }
}
