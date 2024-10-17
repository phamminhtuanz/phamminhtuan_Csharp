using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_3
{
    class Circle : Shape
    {
        //phương thức nhập liệu
        public void InputData()
        {
            Console.Write("Nhập bán kính: ");
            radius = int.Parse(Console.ReadLine());
        }
        //ghi đè phương thức tính diện tích
        public override float Area()
        {
            return 3.14F * radius * radius;
        }
        //ghi đè phương thức tính chi vi
        public override float Circumference()
        {
            return 2 * 3.14F * radius;
        }
    }
}
