namespace Lab03._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tạo đối tượng contact với constructor không tham số
            contact ct1 = new contact();
            // gán giá trị cho ct1
            ct1.Id = 6;
            ct1.Firstname = "Pham Minh";
            ct1.Lastname = "Tuan";
            ct1.Address = "Hung Yen";
            ct1.Phone = "0988885555";
            ct1.Email = "phamtuan@gmail.com";
            //tạo đối tượng contact vơi constructor có tham số
            contact ct2 = new contact(5, "Pham Minh", "Tuan", "Hung Yen", "0988885555", "phamtuan@gmail.com");
            //hiển thị thông tin ct1 và ct2
            ct1.Display();
            ct2.Display();
        }
    }
}
