using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03.ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Employee e=new Employee();
            e.Id = 1;
            e.Name = "Phạm Minh Tuấn";
            e.salaryLevel = 100;
            e.basicSalary = 300;
            e.Display();
            double Income = e.GetInCome();
            Console.WriteLine("Thu nhập:{0}", Income);
            Console.ReadKey(); 
        }
    }
}
