using System.Drawing;
using System.Windows.Forms;

namespace Salov.NAUKA
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
        /// 


        private void InitializeComponent()
        {

            // настройка параметров окна и его стартовой позиции
            this.StartPosition = FormStartPosition.WindowsDefaultLocation;
            this.Width = 1000;
            this.Height = 1000;
            
            // лейбл окна
            Text = "Учетные данные сотрудников";
            
            // создание элемента упралвения datagridview для табличного отображения данных из бд
            this.dataGridView = new System.Windows.Forms.DataGridView();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(1200, 600);
           
            Controls.Add(dataGridView);
           

            //создание кнопки добавления сотрудника
            Button addEmployee = new Button();
            addEmployee.Text = "Добавить сотрудника";
            addEmployee.Location = new Point(0, 600);
            addEmployee.Size = new Size(333,400);
            addEmployee.Click += new System.EventHandler(this.addEmployee);
            Controls.Add(addEmployee);

            //создание кнопки удаления  сотрудника
            Button editEmployee = new Button();
            editEmployee.Text = "Изменить информацию о сотруднике";
            editEmployee.Location = new Point(334, 600);
            editEmployee.Size = new Size(333, 400);
            editEmployee.Click += new System.EventHandler(this.editEmployee);
            Controls.Add(editEmployee);

            //создание кнопки редактирования информации о сотруднике
            Button deleteEmployee = new Button();
            deleteEmployee.Text = "Удалить сотрудника";
            deleteEmployee.Location = new Point(668, 600);
            deleteEmployee.Size = new Size(333, 400);
            // 
            deleteEmployee.Click += new System.EventHandler(this.deleteEmployee);
            Controls.Add(deleteEmployee);
        }

        #endregion


        private System.Windows.Forms.DataGridView dataGridView;

    }
}

