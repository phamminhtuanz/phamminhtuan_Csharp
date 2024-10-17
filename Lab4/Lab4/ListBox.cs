using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class ListBox:Windows
    {
        //khia báo trường mới
        private string listBoxContents;
        //phương thức khởi tạo
        public ListBox(int top, int left, string contents)
            :base(top, left) // gọi constructor lớp cơ sở
        {
            listBoxContents = contents;
        }
        //ghi đè phương thức Drawwindow
        public override void Drawwindow()
        {
            base.Drawwindow();  // gọi phương thức lớp cơ sở
            Console.WriteLine("Writing string to the lisbox: {0}", listBoxContents);
        }
    }
}
