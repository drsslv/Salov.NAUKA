using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Salov.NAUKA
{
    public partial class Form1 : Form
    {
        EmployeeContext database;
        public Form1()
        {
            InitializeComponent();

            // Создаем объект класса EmployContext, через который и будут производиться все операции с БД
            database = new EmployeeContext();
            //Загружаем все данные с таблицы Employees
            database.Employees.Load();
            // В наш элементе управления datagridview в качестве источника данных указываем коллекцию данных с таблицы Employess и выводим информацию в виде списка BindingList
            dataGridView.DataSource = database.Employees.Local.ToBindingList();
            //скрываем столбец id 
            dataGridView.Columns[0].Visible = false;


        }
        // Добавляем сотрудника 
        private void addEmployee(object sender, EventArgs e)
        {
            // создаем экземпляр класса нашей второй формы
            AddEmployee add = new AddEmployee();

            // Открываем вторую форму в качестве даилогового окна
            DialogResult result = add.ShowDialog(this);

            // Нажатие кнопки "Отмена" в диалоговом коне приведет к возврату на главную форму
            if (result == DialogResult.Cancel) return;

            // сохдаем экземпляр класса сотрудник 
            Employee employee = new Employee();

            // Присваиваем каждому полю сотрудниа информарцию введеную в диалоговом окне 
            employee.Name = add.namebox.Text;
            employee.Surname = add.surnamebox.Text;
            employee.Thirdname = add.thirdnamebox.Text;
            employee.Birthday = add.birthdaybox.SelectionRange.Start;
            employee.Address = add.addressbox.Text;
            employee.Department = add.departmentbox.Text;
            employee.Aboutyourself = add.aboutyourselfbox.Text;
            
            // добавляем объект сотрудника с сформированными полями
            database.Employees.Add(employee);
            
           // формируем запрос вставки объекта модели в БД
            database.SaveChanges();

            MessageBox.Show("Новый сотрудник добавлен");
        }

        // Изменяем информацию о сотруднике 
        private void editEmployee(object sender, EventArgs e)
        {
            // обработка выбранной строки 
            if (dataGridView.SelectedRows.Count > 0)
            {
                // индекс указывающий на выбранную строку
                int index = dataGridView.SelectedRows[0].Index;
                int id = 0;
                
                // получаем id выбранной строки 
                bool converted = Int32.TryParse(dataGridView[0, index].Value.ToString(), out id);
                if (converted == false) return;

                // получаем сотрудника по id
                Employee employee = database.Employees.Find(id);

                // создаем экземпляр класса нашей второй формы
                AddEmployee add = new AddEmployee();

                // заполняем поля второй формы информацией о сотруднике 
                add.namebox.Placeholder = employee.Name;
                add.surnamebox.Placeholder = employee.Surname;
                add.thirdnamebox.Placeholder = employee.Thirdname;
                add.birthdaybox.SetDate(employee.Birthday);
                add.addressbox.Placeholder = employee.Address;
                add.departmentbox.Placeholder = employee.Department;
                add.aboutyourselfbox.Placeholder = employee.Aboutyourself;

                // Открываем вторую форму в качестве даилогового окна
                DialogResult result = add.ShowDialog(this);

                // Нажатие кнопки "Отмена" в диалоговом коне приведет к возврату на главную форму
                if (result == DialogResult.Cancel) return;


                // Присваиваем каждому полю сотрудниа информарцию введеную в диалоговом окне 
                employee.Name = add.namebox.Text;
                employee.Surname = add.surnamebox.Text;
                employee.Thirdname = add.thirdnamebox.Text;
                employee.Birthday = add.birthdaybox.SelectionRange.Start;
                employee.Address = add.addressbox.Text;
                employee.Department = add.departmentbox.Text;
                employee.Aboutyourself = add.aboutyourselfbox.Text;

                // формируем запрос вставки объекта модели в БД
                database.SaveChanges();

                // обновляем элемент управления datagrid
                dataGridView.Refresh();
                MessageBox.Show("Информация изменена");
            }
        }

        // Удаление сотрудника
        private void deleteEmployee(object sender, EventArgs e)
        {
            // обработка выбранной строки 
            if (dataGridView.SelectedRows.Count > 0)
            {
                // индекс указывающий на выбранную строку
                int index = dataGridView.SelectedRows[0].Index;
                int id = 0;
                // получаем id выбранной строки 
                bool converted = Int32.TryParse(dataGridView[0, index].Value.ToString(), out id);
                if (converted == false) return;
               
                // получаем сотрудника по id
                Employee employee = database.Employees.Find(id);
                // помечаем сотрудника на удлаение из бд
                database.Employees.Remove(employee);
                // формируем запрос удаления объекта модели из бд
                database.SaveChanges();

                MessageBox.Show("Сотрудник удалён");
            }
        }

    }
}
