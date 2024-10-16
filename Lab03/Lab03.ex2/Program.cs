namespace Lab03.ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Book b1 = new Book();
            Book b2 = new Book("Phạm Minh Tuấn",10,"VTV","Đắc nhân tâm",30);
            b1.Display();
            b2.Display();
             
            b1.flipPageForWard();
            b1.flipPagesBackward();
            Console.ReadKey();
        }
    }
}
