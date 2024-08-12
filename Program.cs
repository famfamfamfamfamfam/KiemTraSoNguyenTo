using System;

namespace SUDUNGCAULENHLAP
{
    class KiemTraSoNguyenTo
    {
        static void Main(string[] args)
        {
            int socankiemtra;
            Console.WriteLine("Nhap vao so can xet:");
            socankiemtra = int.Parse(Console.ReadLine());

            if (socankiemtra>=2)
            {
                if (socankiemtra<=3)
                {
                    Console.WriteLine("{0} la so nguyen to", socankiemtra);
                }
                int sochia = 2;
                while(sochia <= Math.Sqrt(socankiemtra))
                {
                    if (socankiemtra%sochia==0)
                    {
                        Console.WriteLine("{0} khong phai so nguyen to", socankiemtra);
                        break;
                    }
                    else Console.WriteLine("{0} la so nguyen to", socankiemtra);
                    sochia++;
                }
            } else Console.WriteLine("{0} khong phai so nguyen to", socankiemtra);
        }
    }
}