namespace lesson22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // xuat co unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Lenh in ra man hinh 1 dong van ban, sau do xuong dong
            Console.WriteLine("Ho va ten: Minh Tuan");
            Console.WriteLine("Ngay sinh: 04/10/2003");
            Console.WriteLine("Dia chi: Hung Yen");
            Console.WriteLine("Dien Thoai: 0978993465");
            Console.WriteLine("hello");
            //lenh dung man hinh va cho nhan 1 phim
            Console.Read();
        }
    }
}