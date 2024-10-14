namespace lab_01ex3
{/// <summary>
/// author: Phamminhtuan
/// date:04/10/2024
/// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Viết chương trình thực hiện yêu cầu sau");
            //khai báo
            string maNV;
            string hoVaTen;
            DateTime ngaySinh;
            string diaChi;
            string dienThoai;
            string email;
            //gán giá trị
            maNV = "N001";
            hoVaTen = "Minh Tuấn";
            ngaySinh = DateTime.Now;
            diaChi = "Hưng Yên";
            dienThoai = "0978993465";
            email = "phamtuan@gmail.com";
            //hiển thị thông tin
            Console.WriteLine("===== THÔNG TIN CÁ NHÂN");
            Console.WriteLine("Mã Nhân Viên : {0}", maNV);
            Console.WriteLine("Họ và Tên : {0}", hoVaTen);
            Console.WriteLine("Ngày Sinh : {0}", ngaySinh.ToString("MM/dd/yyyy"));
            Console.WriteLine("Địa Chỉ : {0}", diaChi);
            Console.WriteLine("Điện Thoại : {0}", dienThoai);
            Console.WriteLine("Email : {0}", email);

        }
    }
}
