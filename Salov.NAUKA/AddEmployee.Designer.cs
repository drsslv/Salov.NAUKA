using System.Drawing;
using System.Windows.Forms;

namespace Salov.NAUKA
{
    partial class AddEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
     
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new Size(800, 600);
            this.Text = "AddEmployee";





            this.Text = "Добавить сотрудника";
            GroupBox groupBox = new GroupBox();
            groupBox.Size = new Size(700, 1000);
            groupBox.Text = "Сотрудник";
            Controls.Add(groupBox);

            // Добавляем лейбл "Имя" в форму
            Label name = new Label();
            name.AutoSize = true;
            name.Text = "Имя:";
            name.Location = new Point(20, 20);
            groupBox.Controls.Add(name);

            //Добавляем поле для ввода имени
            this.namebox = new Salov.NAUKA.TextBoxWithPlaceHolder();
            namebox.Placeholder = "Введите имя";
            namebox.Location = new Point(140, 20);
            namebox.Size = new Size(220, 0);
            groupBox.Controls.Add(namebox);

            //Добавляем лейбл "Фамилия" в форму
            Label surname = new Label();
            surname.AutoSize = true;
            surname.Text = "Фамилия:";
            surname.Location = new Point(20, 60);
            groupBox.Controls.Add(surname);

            //Добавляем поле ввода фамилии
            this.surnamebox = new Salov.NAUKA.TextBoxWithPlaceHolder();
            surnamebox.Placeholder = "Введите фамилию";
            surnamebox.Location = new Point(140, 60);
            surnamebox.Size = new Size(220, 0);
            groupBox.Controls.Add(surnamebox);

            //Добавляем лейбл "Отчество" в форму
            Label thirdname = new Label();
            thirdname.AutoSize = true;
            thirdname.Text = "Отчество:";
            thirdname.Location = new Point(20, 100);
            groupBox.Controls.Add(thirdname);

            //Добавляем поле ввода фамилии
            this.thirdnamebox = new Salov.NAUKA.TextBoxWithPlaceHolder();
            thirdnamebox.Placeholder = "Введите отчество";
            thirdnamebox.Location = new Point(140, 100);
            thirdnamebox.Size = new Size(220, 0);
            groupBox.Controls.Add(thirdnamebox);

            //Добавляем лейбл "Дата рождения" в форму
            Label birthday = new Label();
            birthday.AutoSize = true;
            birthday.Text = "Дата Рождения:";
            birthday.Location = new Point(20, 140);
            groupBox.Controls.Add(birthday);

            //Добавляем поле ввода даты рождения
            this.birthdaybox = new System.Windows.Forms.MonthCalendar();
            birthdaybox.Location = new Point(140, 140);
            birthdaybox.Size = new Size(220, 0);
            groupBox.Controls.Add(birthdaybox);

            //Добавляем лейбл "Адрес проживания" в форму
            Label address = new Label();
            address.AutoSize = true;
            address.Text = "Адрес проживания:";
            address.Location = new Point(20, 320);
            groupBox.Controls.Add(address);

            //Добавляем поле ввода адреса проживания
            this.addressbox = new Salov.NAUKA.TextBoxWithPlaceHolder();
            addressbox.Placeholder = "Введите адрес проживания";
            addressbox.Location = new Point(140, 320);
            addressbox.Size = new Size(220, 0);
            groupBox.Controls.Add(addressbox);

            //Добавляем лейбл "Отдел" в форму
            Label department = new Label();
            department.AutoSize = true;
            department.Text = "Отдел:";
            department.Location = new Point(20, 360);
            groupBox.Controls.Add(department);

            //Добавляем поле ввода отдела
            this.departmentbox = new Salov.NAUKA.TextBoxWithPlaceHolder();
            departmentbox.Placeholder = "Введите отдел";
            departmentbox.Location = new Point(140, 360);
            departmentbox.Size = new Size(220, 0);
            groupBox.Controls.Add(departmentbox);

            //Добавляем лейбл "О себе" в форму
            Label aboutyourself = new Label();
            aboutyourself.AutoSize = true;
            aboutyourself.Text = "О себе:";
            aboutyourself.Location = new Point(20, 400);
            groupBox.Controls.Add(aboutyourself);

            //Добавляем поле ввода краткого описания сотрудника
            this.aboutyourselfbox = new Salov.NAUKA.TextBoxWithPlaceHolder();
            aboutyourselfbox.Placeholder = "Введите краткое  описание сотрудника";
            aboutyourselfbox.Location = new Point(140, 400);
            aboutyourselfbox.Size = new Size(220, 0);
            groupBox.Controls.Add(aboutyourselfbox);


            //Добавляем кнопку Подтверждения
            Button confirm = new Button();
            confirm.Text = "Подтвердить";
            confirm.Location = new Point(380, 20);
            confirm.Size = new Size(150, 100);
            confirm.DialogResult = DialogResult.OK;
            groupBox.Controls.Add(confirm);

            //Добавляем кнопку Отмены
            Button cancel = new Button();
            cancel.Text = "Отменить";
            cancel.Location = new Point(550, 20);
            cancel.Size = new Size(150, 100);
            cancel.DialogResult = DialogResult.Cancel;
            groupBox.Controls.Add(cancel);


            // Ставим активный элемент лейбл чтобы поля ввода были без автофокуса
            this.ActiveControl = surname;
        }

        // Делаем доступными главной форме наши поля для ввода
        protected internal Salov.NAUKA.TextBoxWithPlaceHolder namebox;
        protected internal Salov.NAUKA.TextBoxWithPlaceHolder surnamebox;
        protected internal Salov.NAUKA.TextBoxWithPlaceHolder thirdnamebox;
        protected internal System.Windows.Forms.MonthCalendar birthdaybox;
        protected internal Salov.NAUKA.TextBoxWithPlaceHolder addressbox;
        protected internal Salov.NAUKA.TextBoxWithPlaceHolder departmentbox;
        protected internal Salov.NAUKA.TextBoxWithPlaceHolder aboutyourselfbox;

    

        #endregion
    }
}