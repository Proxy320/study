using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Remoting.Messaging;

namespace MyAppHome
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker1 = new Worker();
            Worker worker2 = new Worker();
            Worker worker3 = new Worker();
            Worker worker4 = new Worker();

            FileStream fin;
            string s;
            string[] FIOs;
            try
            {
                fin = new FileStream("D:\\видео\\C# 5.0. Программирование с нуля\\video\\моё\\test.txt", FileMode.Open);
            }
            catch (IOException exc)
            {
                Console.WriteLine("Ошибка открытия файла:\n" + exc.Message);
                return;
            }

            StreamReader fstr_in = new StreamReader(fin);

            try
            {
                while (!fstr_in.EndOfStream)
                {
                    s = fstr_in.ReadLine();
                    

                    FIOs =  s.Split(new char[] { 'T', '.', '/','Т' });

                    if (FIOs[0] == "")
                    {
                        break;
                    }
                    //Первый рабочий
                    worker1.ID = Convert.ToInt32(FIOs[0]);
                    worker1.FIO = FIOs[1];
                    worker1.NuberDepartment = Convert.ToInt32(FIOs[2]);
                    worker1.Post = FIOs[3];
                    worker1.Salary = Convert.ToInt32(FIOs[4]);
                    worker1.Day = Convert.ToInt32(FIOs[5]);
                    worker1.Month = Convert.ToInt32(FIOs[6]);
                    worker1.Year = Convert.ToInt32(FIOs[7]);
                    worker1.Experience = Convert.ToInt32(FIOs[8]);
                    worker1.EDay = Convert.ToInt32(FIOs[9]);
                    worker1.EMonth = Convert.ToInt32(FIOs[10]);
                    worker1.EYear = Convert.ToInt32(FIOs[11]);
                    //Второй рабочий
                    worker2.ID = Convert.ToInt32(FIOs[12]);
                    worker2.FIO = FIOs[13];
                    worker2.NuberDepartment = Convert.ToInt32(FIOs[14]);
                    worker2.Post = FIOs[15];
                    worker2.Salary = Convert.ToInt32(FIOs[16]);
                    worker2.Day = Convert.ToInt32(FIOs[17]);
                    worker2.Month = Convert.ToInt32(FIOs[18]);
                    worker2.Year = Convert.ToInt32(FIOs[19]);
                    worker2.Experience = Convert.ToInt32(FIOs[20]);
                    worker2.EDay = Convert.ToInt32(FIOs[21]);
                    worker2.EMonth = Convert.ToInt32(FIOs[22]);
                    worker2.EYear = Convert.ToInt32(FIOs[23]);
                    //Третий рабочий
                    worker3.ID = Convert.ToInt32(FIOs[24]);
                    worker3.FIO = FIOs[25];
                    worker3.NuberDepartment = Convert.ToInt32(FIOs[26]);
                    worker3.Post = FIOs[27];
                    worker3.Salary = Convert.ToInt32(FIOs[28]);
                    worker3.Day = Convert.ToInt32(FIOs[29]);
                    worker3.Month = Convert.ToInt32(FIOs[30]);
                    worker3.Year = Convert.ToInt32(FIOs[31]);
                    worker3.Experience = Convert.ToInt32(FIOs[32]);
                    worker3.EDay = Convert.ToInt32(FIOs[33]);
                    worker3.EMonth = Convert.ToInt32(FIOs[34]);
                    worker3.EYear = Convert.ToInt32(FIOs[35]);
                    //Четвертый рабочий
                    worker4.ID = Convert.ToInt32(FIOs[36]);
                    worker4.FIO = FIOs[37];
                    worker4.NuberDepartment = Convert.ToInt32(FIOs[38]);
                    worker4.Post = FIOs[39];
                    worker4.Salary = Convert.ToInt32(FIOs[40]);
                    worker4.Day = Convert.ToInt32(FIOs[41]);
                    worker4.Month = Convert.ToInt32(FIOs[42]);
                    worker4.Year = Convert.ToInt32(FIOs[43]);
                    worker4.Experience = Convert.ToInt32(FIOs[44]);
                    worker4.EDay = Convert.ToInt32(FIOs[45]);
                    worker4.EMonth = Convert.ToInt32(FIOs[46]);
                    worker4.EYear = Convert.ToInt32(FIOs[47]);


                    //foreach (string fiO in FIOs)
                    //{
                    //    Console.WriteLine(fiO);
                    //}
                }


            }
            catch (IOException exc)
            {
                Console.WriteLine("Ошибка ввода-вывода:\n" + exc.Message);
            }
            finally
            {
                fstr_in.Close();
            }



            Worker[] workers = {worker1, worker2, worker3, worker4};

            Print(workers);



        }

        static void Print(Worker[] workers)
        {
            foreach (Worker worker in workers)
            {
                Console.WriteLine("Id: {0}, ФИО: {1}, номер отдела: {2}, должность: {3}, зарплата: {4} рублей, дата рождения: {5}.{6}.{7}, рабочий стаж: {8} лет, дата начало работы: {9}.{10}.{11}",
                    worker.ID, worker.FIO, worker.NuberDepartment, worker.Post, worker.Salary, worker.Day, worker.Month, worker.Year, worker.Experience, worker.EDay, worker.EMonth, worker.EYear);
            }
                               
        }




    }
}
