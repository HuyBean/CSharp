using System;

namespace Var
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ví dụ 1
            // Console.WriteLine("Hello World!");
            // int KieuSoNguyen = 5;
            // float BienKieuSoThuc = 6.9f;
            // string BienKieuChuoi = "HowKteam.com - Free Education";
            // bool BienKieuLuanLy = true;
            // char BienKieuKyTu = 'K';

            // Console.WriteLine(KieuSoNguyen);
            // Console.WriteLine(BienKieuSoThuc);
            // Console.WriteLine(BienKieuChuoi);
            // Console.WriteLine(BienKieuLuanLy);
            // Console.WriteLine(BienKieuKyTu);

            // int aNum = 6;
            // int bNum = 9;
            // int cNum = aNum + bNum;

            // Console.WriteLine("a + b = c : {0} + {1} = {2}", aNum, bNum, cNum);

            #endregion

            #region Ví dụ 2
            // byte BienByte = 3;
            // short BienShort = 9;
            // int BienInt = 10;
            // long BienLong = 0;

            // BienLong = BienByte;
            // Console.WriteLine(" BienLong = " + BienLong);
            // BienLong = BienInt;
            // Console.WriteLine(" BienLong = {0}", BienLong);
            // BienShort = BienByte;
            // Console.WriteLine(" BienShort = " + BienShort);
            // BienInt = BienShort;
            // Console.WriteLine(" BienInt = " + BienInt);
            #endregion

            #region Hằng
            // const int a = 15;
            // const int x = a;
            // Console.WriteLine(x);
            #endregion

            #region Parse()
            // string s = "10";
            // int k = int.Parse(s);
            // double e = double.Parse("10.9");
            // Console.WriteLine(k);
            // Console.WriteLine(e);
            #endregion
            
            #region TryParse()
            // int Result;
            // bool isSuccess;
            // string Data1 = "10", Data2 = "Kteam";
            // isSuccess = int.TryParse(Data1, out Result);
            // Console.Write(isSuccess == true ? "Success !" : "Faled !");
            // Console.WriteLine("Result = " + Result);
            #endregion
            
            #region Convert
            #endregion
            Console.ReadKey(true);
        }
    }
}
