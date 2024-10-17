namespace Lab4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // khởi tạo hình chữ nhật
            Rectangle rec = new Rectangle();
            //nhập dữ liệu
            rec.InputData();
            //in thông tin
            Console.WriteLine("Diện tích hình chữ nhật là: {0:N}", rec.Area());
            Console.WriteLine("Chu vi hình chữ nhật là:{0:N}", rec.Circumference());
            //khởi tạo hình tròn
            Circle cir = new Circle();
            //nhập dữ liệu
            cir.InputData();
            //in thông tin
            Console.WriteLine("Diện tích hình tròn là: {0:N}", cir.Area());
            Console.WriteLine("Chu vi hình tròn là: {0:N}", cir.Circumference());

        }
    }
}
