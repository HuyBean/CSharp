using System;

namespace Begin
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Console.Write() 
            // In ra không xuống dòng
            // Console.Write("Hello World!\n");
            // Console.Write(10);
            // Console.Write(10.9f);
            // Console.Write(true);
            #endregion
            #region Console.WriteLine();
            // In ra kèm xuống dòng
            Console.WriteLine("Hello World!\n");
            Console.WriteLine(10);
            Console.WriteLine(10.9f);
            Console.WriteLine(true);
            #endregion
            int a = 5;
            Console.Write("a = " );
            Console.WriteLine(a);
            // Console.WriteLine("a = " + a); In ra màn hình cộng dồn giá trị của a
            // Console.WriteLine("a = {0}", a); In ra màn hình giá trị của a
            Console.WriteLine("{0} {1} {2} {3}", 1, 2, 3, 4); // In ra màn hình giá trị tương ứng
            #region Console.Read()
            // Lệnh này không đọc được phím chức năng
            //Console.WriteLine(Console.Read()); // đọc 1 ký tự từ bán phím bằng lệnh read sau đó in ra ký tự vừa được đọc theo mã ASCII
            #endregion
            #region Console.ReadLine()
            Console.WriteLine(Console.ReadLine()); // đọc từ bán phím bằng lệnh readline đến khi gặp ký tự xuống dòng thì dừng
            // sau đó in ra chuỗi ký tự vừa được đọc
            #endregion
            #region Console.ReadKey()
            Console.ReadKey(); // Không truyền tham số thì mặc định là false
            Console.ReadKey(false);// Hiển thị phím ẩn lên màn hình
            Console.ReadKey(true); // Không hiển thị phím ẩn lên màn hìnhy
            #endregion
        } 
    }
}
