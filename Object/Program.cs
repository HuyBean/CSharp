using System;

namespace Object
{
    class Program
    {
        static void Main(string[] args)
        {
            #region OBJ
            //object obj = "Hello ";
            // int value = 109;
            // object objectvalue = value;
            // int newValue = (int)objectvalue;
            // Console.WriteLine("New value " + newValue);
            #endregion 
            #region VAR
            // // var varInt;
            // // varInt = 109;
            // // Var phải được khởi tạo ngay khi khai báo
            // var varString = "Hello";
            // string content = "World wide web";
            // Console.WriteLine(varString);
            // Console.WriteLine(content);
            #endregion
            #region Dynamic
            dynamic StringValue = "Hello World";
            /*
            Chúng ta biết rằng kiểu chuỗi không hỗ trợ toán tử ++
            Nhưng câu lệnh StringValue++ vẫn không báo lỗi là do ở thời điểm hiện tại trình biên dịch vẫn chưa xác định được kiểu dữ liệu cho biến StringValue
            Khi chạy chương trình thì lúc này C# mới phát hiện biến StringValue là kiểu string và không thể thực hiện toán tử ++ 
            */
            StringValue++;
            #endregion
            Console.ReadKey();
        }
    }
}
