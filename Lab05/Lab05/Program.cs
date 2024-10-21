namespace Lab05
{
    internal class Program
    {
        // một số thao tác với mảng
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // khai báo mảng 1 chiều
            int[] m = { 5, 8, 3, 0, 2, 1, 7, 8 };
            // duyetj mảng và in dữ liệu
            Console.WriteLine("các phần tử của mảng");
            for (int i = 0; i < m.Length; i++)
            {
                Console.WriteLine("{0}", m[i]);
            }
            // tìm phần tử lớn nhất
            int max = m[0];
            for (int i = 0; i < m.Length; i++)
            {
                if (max < m[i])
                    max = m[i];
            }
            Console.WriteLine("\nPhần tử lớn nhất:" + max);
            //kiểm tra mảng có đối xứng không
            bool kt = true;
            for (int i = 0; i < m.Length / 2; i++)
            {
                if (m[i] != m[m.Length - 1 - i])
                {
                    kt = false;
                    break;
                }
            }
            if (kt)
                Console.WriteLine("Mảng đối xứng");
            else
                Console.WriteLine("Mảng không đối xứng");
        }
    }
}
