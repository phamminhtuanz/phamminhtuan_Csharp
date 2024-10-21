namespace Lab05_2
{
    /// <summary>
    /// Mảng 2 chiều
    /// Khởi tạo mảng 2 chiều 4x3
    /// duyệt mảng và in theo ma trận hàng cột
    /// in ra các phần tử có chỉ số mảng bằng chỉ số cột
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //khai báo và khởi tạo mảng
            int[,] a =
            {
                { 4, 6, 9 }, 
                { 2, 4, 5 },
                { 9, 2, 6 },
                { 1, 6, 3 }
            };
            //duyệt mảng và in theo hàng cột
            Console.WriteLine("Nội dung hàng");
            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j <= a.GetUpperBound(1); j++)
                {
                    Console.Write("{0}", a[i, j]);
                }
                Console.WriteLine();
            }
            //tìm các phần tử có chỉ số hàng bằng chỉ số cột
            Console.WriteLine("Các phần tử có chỉ số hàng bằng chỉ số cột :\n");
            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= a.GetUpperBound(1);j++)
                {
                    if (i == j)
                        Console.Write(" {0} ", a[i, j]);
                }    
            }    
            //các phần tử lớn nhất trên hàng
            Console.WriteLine("Các phần tử lớn nhất trên hàng :\n");
            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {
                int max = a[i, 0];
                for (int j = 0; j <= a.GetUpperBound(1); j++)
                {
                    if (max < a[i, j])
                        max = a[i, j];
                }
                Console.WriteLine("Hàng {0}:{1}", i, max);
            }
        }
    }
}