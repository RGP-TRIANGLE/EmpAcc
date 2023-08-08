namespace TestApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }



        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьНовогоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.EmpGridView = new System.Windows.Forms.DataGridView();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabelNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateReceptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDismissalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DateDis_TextBox = new System.Windows.Forms.DateTimePicker();
            this.DateRes_TextBox = new System.Windows.Forms.DateTimePicker();
            this.Dis_Label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Phone_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Email_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Department_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TabNumber_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FullName_TextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Tab_Control = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DeleteRecord_Button = new System.Windows.Forms.Button();
            this.SetLeader_Button = new System.Windows.Forms.Button();
            this.StatusEdit_Button = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.Tab_Control.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.создатьНовогоToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1049, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(158, 24);
            this.toolStripMenuItem1.Text = "Импортировать БД";
            // 
            // создатьНовогоToolStripMenuItem
            // 
            this.создатьНовогоToolStripMenuItem.Name = "создатьНовогоToolStripMenuItem";
            this.создатьНовогоToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.создатьНовогоToolStripMenuItem.Text = "Сортировать";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Сортировать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EmpGridView
            // 
            this.EmpGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmpGridView.AutoGenerateColumns = false;
            this.EmpGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmpGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.EmpGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullNameDataGridViewTextBoxColumn,
            this.tabelNumberDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.dateReceptionDataGridViewTextBoxColumn,
            this.dateDismissalDataGridViewTextBoxColumn,
            this.recordStatusDataGridViewTextBoxColumn});
            this.EmpGridView.DataSource = this.employeeBindingSource;
            this.EmpGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.EmpGridView.Location = new System.Drawing.Point(3, 0);
            this.EmpGridView.Name = "EmpGridView";
            this.EmpGridView.RowHeadersWidth = 51;
            this.EmpGridView.RowTemplate.Height = 24;
            this.EmpGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmpGridView.Size = new System.Drawing.Size(784, 459);
            this.EmpGridView.TabIndex = 4;
            this.EmpGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmpGridView_CellClick);
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // tabelNumberDataGridViewTextBoxColumn
            // 
            this.tabelNumberDataGridViewTextBoxColumn.DataPropertyName = "TabelNumber";
            this.tabelNumberDataGridViewTextBoxColumn.HeaderText = "ТабНомер";
            this.tabelNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tabelNumberDataGridViewTextBoxColumn.Name = "tabelNumberDataGridViewTextBoxColumn";
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Отделение";
            this.departmentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // dateReceptionDataGridViewTextBoxColumn
            // 
            this.dateReceptionDataGridViewTextBoxColumn.DataPropertyName = "DateReception";
            this.dateReceptionDataGridViewTextBoxColumn.HeaderText = "Дата поступления";
            this.dateReceptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateReceptionDataGridViewTextBoxColumn.Name = "dateReceptionDataGridViewTextBoxColumn";
            // 
            // dateDismissalDataGridViewTextBoxColumn
            // 
            this.dateDismissalDataGridViewTextBoxColumn.DataPropertyName = "DateDismissal";
            this.dateDismissalDataGridViewTextBoxColumn.HeaderText = "Дата увольнения";
            this.dateDismissalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDismissalDataGridViewTextBoxColumn.Name = "dateDismissalDataGridViewTextBoxColumn";
            // 
            // recordStatusDataGridViewTextBoxColumn
            // 
            this.recordStatusDataGridViewTextBoxColumn.DataPropertyName = "RecordStatus";
            this.recordStatusDataGridViewTextBoxColumn.HeaderText = "Статус записи";
            this.recordStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.recordStatusDataGridViewTextBoxColumn.Name = "recordStatusDataGridViewTextBoxColumn";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(TestApp.Model.Employee);
            // 
            // DateDis_TextBox
            // 
            this.DateDis_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateDis_TextBox.Location = new System.Drawing.Point(9, 287);
            this.DateDis_TextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.DateDis_TextBox.Name = "DateDis_TextBox";
            this.DateDis_TextBox.Size = new System.Drawing.Size(197, 22);
            this.DateDis_TextBox.TabIndex = 20;
            // 
            // DateRes_TextBox
            // 
            this.DateRes_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateRes_TextBox.Location = new System.Drawing.Point(9, 243);
            this.DateRes_TextBox.Name = "DateRes_TextBox";
            this.DateRes_TextBox.Size = new System.Drawing.Size(197, 22);
            this.DateRes_TextBox.TabIndex = 19;
            // 
            // Dis_Label
            // 
            this.Dis_Label.AutoSize = true;
            this.Dis_Label.Location = new System.Drawing.Point(6, 268);
            this.Dis_Label.Name = "Dis_Label";
            this.Dis_Label.Size = new System.Drawing.Size(120, 16);
            this.Dis_Label.TabIndex = 14;
            this.Dis_Label.Text = "Дата увольнения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Дата поступления";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Телефон";
            // 
            // Phone_TextBox
            // 
            this.Phone_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Phone_TextBox.Location = new System.Drawing.Point(9, 198);
            this.Phone_TextBox.Name = "Phone_TextBox";
            this.Phone_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.Phone_TextBox.Size = new System.Drawing.Size(197, 22);
            this.Phone_TextBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email";
            // 
            // Email_TextBox
            // 
            this.Email_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Email_TextBox.Location = new System.Drawing.Point(9, 154);
            this.Email_TextBox.Name = "Email_TextBox";
            this.Email_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.Email_TextBox.Size = new System.Drawing.Size(197, 22);
            this.Email_TextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Отделение";
            // 
            // Department_TextBox
            // 
            this.Department_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Department_TextBox.Location = new System.Drawing.Point(9, 110);
            this.Department_TextBox.Name = "Department_TextBox";
            this.Department_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.Department_TextBox.Size = new System.Drawing.Size(197, 22);
            this.Department_TextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Табельный номер";
            // 
            // TabNumber_TextBox
            // 
            this.TabNumber_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabNumber_TextBox.Location = new System.Drawing.Point(9, 66);
            this.TabNumber_TextBox.Name = "TabNumber_TextBox";
            this.TabNumber_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TabNumber_TextBox.Size = new System.Drawing.Size(197, 22);
            this.TabNumber_TextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ФИО";
            // 
            // FullName_TextBox
            // 
            this.FullName_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullName_TextBox.Location = new System.Drawing.Point(9, 22);
            this.FullName_TextBox.Name = "FullName_TextBox";
            this.FullName_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.FullName_TextBox.Size = new System.Drawing.Size(197, 22);
            this.FullName_TextBox.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(103, 28);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(102, 24);
            this.toolStripMenuItem3.Text = "123";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 79);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.EmpGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.Tab_Control);
            this.splitContainer1.Size = new System.Drawing.Size(1025, 459);
            this.splitContainer1.SplitterDistance = 786;
            this.splitContainer1.TabIndex = 6;
            // 
            // Tab_Control
            // 
            this.Tab_Control.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tab_Control.Controls.Add(this.tabPage1);
            this.Tab_Control.Controls.Add(this.tabPage2);
            this.Tab_Control.Location = new System.Drawing.Point(4, 0);
            this.Tab_Control.Name = "Tab_Control";
            this.Tab_Control.SelectedIndex = 0;
            this.Tab_Control.Size = new System.Drawing.Size(228, 459);
            this.Tab_Control.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.AutoScrollMargin = new System.Drawing.Size(25, 25);
            this.tabPage1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tabPage1.Controls.Add(this.DateDis_TextBox);
            this.tabPage1.Controls.Add(this.DateRes_TextBox);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.Dis_Label);
            this.tabPage1.Controls.Add(this.Email_TextBox);
            this.tabPage1.Controls.Add(this.FullName_TextBox);
            this.tabPage1.Controls.Add(this.Department_TextBox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.Phone_TextBox);
            this.tabPage1.Controls.Add(this.TabNumber_TextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(220, 430);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Свойства";
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tabPage2.Controls.Add(this.DeleteRecord_Button);
            this.tabPage2.Controls.Add(this.SetLeader_Button);
            this.tabPage2.Controls.Add(this.StatusEdit_Button);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(220, 430);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Действие";
            // 
            // DeleteRecord_Button
            // 
            this.DeleteRecord_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteRecord_Button.BackColor = System.Drawing.Color.IndianRed;
            this.DeleteRecord_Button.FlatAppearance.BorderSize = 0;
            this.DeleteRecord_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.DeleteRecord_Button.ForeColor = System.Drawing.Color.White;
            this.DeleteRecord_Button.Location = new System.Drawing.Point(6, 84);
            this.DeleteRecord_Button.Name = "DeleteRecord_Button";
            this.DeleteRecord_Button.Size = new System.Drawing.Size(208, 33);
            this.DeleteRecord_Button.TabIndex = 7;
            this.DeleteRecord_Button.Text = "Удалить запись";
            this.DeleteRecord_Button.UseVisualStyleBackColor = false;
            this.DeleteRecord_Button.Click += new System.EventHandler(this.DeleteRecord_Button_Click);
            // 
            // SetLeader_Button
            // 
            this.SetLeader_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SetLeader_Button.Location = new System.Drawing.Point(6, 45);
            this.SetLeader_Button.Name = "SetLeader_Button";
            this.SetLeader_Button.Size = new System.Drawing.Size(208, 33);
            this.SetLeader_Button.TabIndex = 6;
            this.SetLeader_Button.Text = "Назначить руководителем";
            this.SetLeader_Button.UseVisualStyleBackColor = true;
            // 
            // StatusEdit_Button
            // 
            this.StatusEdit_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusEdit_Button.Location = new System.Drawing.Point(6, 6);
            this.StatusEdit_Button.Name = "StatusEdit_Button";
            this.StatusEdit_Button.Size = new System.Drawing.Size(208, 33);
            this.StatusEdit_Button.TabIndex = 5;
            this.StatusEdit_Button.Text = "Уволить сотрудника";
            this.StatusEdit_Button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 561);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.Tab_Control.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem создатьНовогоToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.DataGridView EmpGridView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabelNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateReceptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDismissalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox FullName_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TabNumber_TextBox;
        private System.Windows.Forms.Label Dis_Label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Phone_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Email_TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Department_TextBox;
        private System.Windows.Forms.DateTimePicker DateDis_TextBox;
        private System.Windows.Forms.DateTimePicker DateRes_TextBox;
        private System.Windows.Forms.Button StatusEdit_Button;
        private System.Windows.Forms.TabControl Tab_Control;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button SetLeader_Button;
        private System.Windows.Forms.Button DeleteRecord_Button;
    }
}

