using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAppHome
{
    //А почему бы не добавить сюда модификатор public?
    class Worker
    {
        // Вот ФИО бы я как раз сделал 3-я отдельными полями! (First\Middle\Last Name)
        // А если понадобится получать только фамилии?
        // И можно добавить свойство FIO, которое будет возвращить стоку из этих трех полей
        // А еще лучше посмотреть, что такое Расширения (Extensions) и добавить класс WorkerExtension c методом расширения для получения ФИО
        public string FIO { get; set; }
        public string Post { get; set; }

        // Хочу xml-документацию по классу и всем полям, это делается так:
        /// <summary>
        /// Идентификатор сотрудника
        /// </summary>
        public int ID { get; set; }
        public int NuberDepartment { get; set; }
        public int Salary { get; set; }

        // Почему дата в таком формате?!
        // Почему не используешь DateTime или DateTime?
        // Вот прям совсем не рекомендуется так делать )
        //Дата рождения Worker
        public int Day { get; set; }
        public int Month { get; set; }        
        public int Year { get; set; }

        // То же самое
        //дата начала работы
        public int EDay { get; set; }
        public int EMonth { get; set; }
        public int EYear { get; set; }

        // Как правильно писать комментарии - описано выше, и почему бы не сделать это в виде вычисляемого свойства?
        // Если  не null, то "рабочий стаж" вычисляем вычитаем "дата начала работы" из DateTime.Now, иначе null        
        public int Experience { get; set; } //рабочий стаж

        //Это же конструктор п оумолчанию, разве он не будет создаваться для класса по умолчанию?
        public Worker()
        {

        }

        
    }
}
