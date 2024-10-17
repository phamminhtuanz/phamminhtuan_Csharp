namespace lab_ex4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Document document = new Document();
            //gan noi dung cho documnent
            document.content = "Day la noi dung cua document";
            //ghi vao file
            string filePath = "document.txt";
            document.Write(filePath);
            document.Read(filePath);
            Console.WriteLine($"noi dung tai lieu:{document.content}");

            string encrytedContent = document.Encrypt();
            Console.WriteLine($"ma hoa noi dung:{encrytedContent}");
            //gan du lieu de ma hoa cho document de thu giai ma
            document.content= encrytedContent;
            string decryptedContent= document.Decrypt();
            Console.WriteLine($"Decrypt noi dung:{decryptedContent}");
        }
    }
}
