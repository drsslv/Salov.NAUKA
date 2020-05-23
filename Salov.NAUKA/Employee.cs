using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salov.NAUKA
{
    class Employee
    {
        // объявляем модель таблицы бд Сотрудник
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Thirdname { get; set; }
        public DateTime Birthday { get; set; }
        public string Address { get; set; }

        public string Department { get; set; }
        public string Aboutyourself { get; set; }

    }
}
