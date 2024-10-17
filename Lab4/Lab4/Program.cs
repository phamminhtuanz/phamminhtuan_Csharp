namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //khởi tạo lớp windows
            Windows win = new Windows(1, 2);
            //khởi tạo lớp listbox
            ListBox lb = new ListBox(3, 4, "Stand a alone list box");
            //khởi tạo lớp button
            Button b = new Button(5, 6);
            win.Drawwindow();
            lb.Drawwindow();
            b.Drawwindow();
            //khởi tạo mảng windows
            Windows[] winArray = new Windows[3];
            winArray[0] = new Windows(1, 2);
            winArray[1] = new ListBox(3, 4, "List box in array");
            winArray[2] = new Button(5, 6);
            for (int i = 0; i < 3; i++)
            {
                winArray[i].Drawwindow();
            }
        }
    }
}
