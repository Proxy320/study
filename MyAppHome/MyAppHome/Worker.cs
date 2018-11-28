using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAppHome
{
    class Worker
    {
        public string FIO { get; set; }
        public string Post { get; set; }

        public int ID { get; set; }
        public int NuberDepartment { get; set; }
        public int Salary { get; set; }

        //Дата рождения Worker
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        //дата начала работы
        public int EDay { get; set; }
        public int EMonth { get; set; }
        public int EYear { get; set; }

        public int Experience { get; set; } //рабочий стаж

        public Worker()
        {

        }

        
    }
}
