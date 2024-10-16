using lab03._3;

namespace Lab03._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // tạo đối tượng 
            StudentModel action = new StudentModel();
            //goi phuong thuc lay tat ca sinh vien
            List<Student> listall = action.GetStudent();
            //hien thi
            foreach (var item in listall)
            {
                item.Display();
            }
            //goi phuong thuc lay sinh vien theo id
            Student st = action.GetStudent(2);
            //hien thi
            st.Display();
            //goi phuong thuc lay sinh vien co tuoi tu 25-30
            List<Student> listage = action.GetStudent(25, 30);
            //hien thi
            foreach (var item in listage)
            {
                item.Display();
            }    
        }
    }
}
