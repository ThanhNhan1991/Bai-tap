using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so nguyen n: ");
            int n = int.Parse(Console.ReadLine());
            //Bài 1: Viết chương trình nhập vào số nguyên và kiểm tra xem số đó có chia hết
            //cho 3 hay không.Hiển thị kết quả ra màn hình.
            if (n % 3 == 0)
            {
                Console.WriteLine("So {0} chia het cho 3", n);
            }
            else
            {
                Console.WriteLine("So {0} khong chia het cho 3", n);
            }
            //Bài 2: Nhập vào số nguyên dương n, hiển thị bảng cửu chương từ 1 đến n ra màn hình.
            if (n > 0)
            {
                Console.WriteLine("Bang cuu chuong tu 1 den {0} la:", n);
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= 10; j++)
                        Console.WriteLine($"{i} x {j} = {j * i}");
                }
            }
            else
            {
                Console.WriteLine("So {0} khong hop le.", n);
            }
           //Bài 3: Nhập vào số nguyên dương từ n từ bàn phím, tính tổng giai thừa từ 1 đến n
           //và hiển thị kết quả ra màn hình
            if (n > 0)
            {
                int sum = 1;
                Console.WriteLine("Tong giai thua tu 1 den {0} la:", n);
                for (int i = 1; i <= n; i++)
                    sum *= i;
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("So {0} khong hop le.", n);
            }
            //Bài 4: Viết chương trình nhập vào số nguyên từ bàn phím, kiểm tra xem số đó có phải
            //là số chính phương hay không.Hiển thị kết quả đạt được ra màn hình.
            if (n != 0)
            {
                double can = Math.Sqrt(n);
                if (can*can == n)
                {
                    Console.WriteLine("So {0} la so chinh phuong",n);
                }
                else
                {
                    Console.WriteLine("So {0} khong phai so chinh phuong",n);
                }
            }
            //Bài 5: Viết chương trình nhập vào tháng bất kỳ từ bàn phím, hiển thị số ngày
            //có trong tháng ra màn hình.
            Console.WriteLine("Vui long nhap nam can tra cuu: ");
            int nam = int.Parse(Console.ReadLine());
            Console.WriteLine("Vui long nhap nam can tra cuu: ");
            int thang = int.Parse(Console.ReadLine());
            switch (thang)
            {
                case 2:
                    if (DateTime.IsLeapYear(nam))
                    {
                        Console.WriteLine("Thang 2 có 29 ngày");
                    }
                    else
                    {
                        Console.WriteLine("Thang 2 có 28 ngày");
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("Thang {0} có 30 ngày", thang);
                    break;
                default:
                    Console.WriteLine("Thang {0} có 31 ngày",thang);
                    break;
            }

            Console.ReadLine();

            }

        }
    }
