using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_ex4._3
{
    public class Document : IStoreable, IEncryptable
    {
        public string content {  get; set; }
        public string Data {
            get {  return content; }
            set { content = value; }
        }
        public void Write(string fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.Write(content);
                Console.WriteLine($"Nội dung viết {fileName}");
            }

        }
        public void Read(string fileName)
        {
            if (!File.Exists(fileName)){
                Console.WriteLine($"File{fileName} does not exist");

                return;
            }
            using(FileStream fs= new FileStream(fileName, FileMode.Open))
                using (StreamReader sr = new StreamReader(fs)) 
            { 
               content= sr.ReadToEnd();
                Console.WriteLine($"Noi dung doc duoc tu file{fileName}");
            }
        }
        public string Encrypt()
        {
            string encryptedData=Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(content));
            Console.WriteLine("Noi dung encrypted");
            return encryptedData;

        }
        public string Decrypt()
        {
            string decryptedData = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(content));
            Console.WriteLine("noi dung decrypt");
            return decryptedData;


        }
            
    }
}
