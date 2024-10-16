namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tạo đối tuowg car
            Car myCar = new Car();
            //gán giá trị cho các trường của đối tượng
            myCar.make = "Toyota";
            myCar.model = "MR2";
            myCar.color = "black";
            myCar.year = 2003;
            //hiển thị thông tin về đối tượng mycar
            System.Console.WriteLine("THONG TIN CHI TIET");
            System.Console.WriteLine("Make: " + myCar.make);
            System.Console.WriteLine("Model: " + myCar.model);
            System.Console.WriteLine("Color: " + myCar.color);
            System.Console.WriteLine("Year release: " + myCar.year);
            //gọi các phương thức
            myCar.Start();
            myCar.Stop();
        }
    }
}
