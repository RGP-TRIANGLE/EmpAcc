using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp.View
{
    public partial class DialogWindow : Form
    {
        //public string DialogWindowResult
        //{
        //    get { return employee; }
        //}

        public DialogWindow(string dialog_text)
        {
            InitializeComponent();
            Dialog_Label.Text = dialog_text;
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Accept_Button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void DialogWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
