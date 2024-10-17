using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Windows
    {
        // khai báo các trường
        protected int top;
        protected int left;
        // phương thức khởi tạo
        public Windows(int top, int left)
        {
            this.top = top;
            this.left = left;
        }
        //phương thức virtual vẽ cửa sổ
        public virtual void Drawwindow()
        {
            Console.WriteLine("Window: drawing window at {0}, {1}", top, left);
        }
    }
}
