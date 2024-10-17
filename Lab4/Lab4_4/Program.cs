namespace lab4._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPerson staff = new Staff();
            object data = "Bach Khoa Aptech";
            staff.Insert(data);
            staff.Delete(data);
            staff.Update(data);
            staff.Display(data);
            IPerson student = new Student() { Id = "S10", Name = "ChungLD", Age = 20 };
            student.Display(student);
        }
    }
}
