﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Bài 2 (3 điểm): Sinh viên sử dụng hàm viết chương trình thực hiện các yêu cầu sau:
1.	Viết hàm nhập vào số nguyên dương N (N>=0).
2.	Viết hàm Tính tổng các số chính phương nhỏ hơn N.
3.	Viết hàm liệt kê các số chính phương nhỏ hơn và bằng N
4.	Viết hàm tính số hạng thứ n của dãy Fibonacci
5.	Viết hàm In ra n số Fibonacci đầu tiên.
6.	Viết hàm kiểm tra N có phải số đối xứng hay không
7.	Viết hàm kiểm tra N có phải là hợp số hay không. Biết hợp số là số chia hết cho số khác ngoài 1 và chính nó.
8.	Viết hàm tìm USCLN và BSCNN của 2 số nguyên.
9.	Viết hàm main gọi thực hiện các chức năng trên, chương trình hỏi người dùng có muốn tiếp tục không? (Y/N). Chọn Y chương trình tiếp tục thực hiện.
10.	Viết chương trình đúng chuẩn code.

Name: Nguyễn Hữu Duy Kha
Date: 11/01/2022
 */

namespace On_Thi
{
    class câu_2_tự_làm_lại
    {

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

        Nhap:
            int n = 0;

            //hàm nhập vào số nguyên dương N
            n = NhapN();

            //hàm Tính tổng các số chính phương nhỏ hơn N
            TongSoChinhPhuong(n);

            //hàm liệt kê các số chính phương nhỏ hơn và bằng N
            LietKeSoChinhPhuong(n);

            //hàm tính số hạng thứ n của dãy Fibonacci
            Console.WriteLine($"Số hạng thứ {n} của dãy Fibonacci: {DayFibonacci(n)}");

            //hàm In ra n số Fibonacci đầu tiên
            Console.WriteLine($"Số Fibonacci đầu tiên là: ");
            InSoFn(n);

            //hàm kiểm tra N có phải số đối xứng hay không
            Console.WriteLine($"{n} có phải là số đối xứng không?: {SoDoiXung(n)}");

            //hàm kiểm tra N có phải là hợp số hay không
            Console.WriteLine($"{n} có phải là hợp số hay không?: {HopSo(n)}");

            //hàm tìm USCLN và BSCNN của 2 số nguyên
            TimUSCLNVaBSCNN();

            //chương trình hỏi người dùng có muốn tiếp tục không? (Y/N). Chọn Y chương trình tiếp tục thực hiện.
            Console.WriteLine("Bạn có muốn tiếp tục không? (Y/N). Chọn Y chương trình tiếp tục thực hiện.");
            char chon = char.Parse(Console.ReadLine());
            if (chon == 'Y' || chon == 'y')
            {
                goto Nhap;
            }

        }



        //8.	Viết hàm tìm USCLN và BSCNN của 2 số nguyên.
        static void TimUSCLNVaBSCNN()
        {
            Console.WriteLine("Nhập vào số nguyên tố thứ 1: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào số nguyên tố thứ 2: ");
            int b = int.Parse(Console.ReadLine());
            int USCLN = 0;
            int BSCNN = 0;

            if (a >= 0 && b >= 0)
            {
                if (a <= 0 && b <= 0)
                {
                    Console.WriteLine("Không tồn tại USCLN, BSCNN");
                }
                else if (a == 0 || b == 0)
                {
                    Console.WriteLine("Không có BSCNN");
                    Console.WriteLine("USCNN = " + ((a == 0) ? b : a));
                }
                else // a != 0 && b != 0
                {
                    int boi = a * b;
                    while (a != 0 && b != 0)
                    {
                        if (a >= b)
                        {
                            a %= b;
                        }
                        else
                        {
                            b %= a;
                        }
                    }
                    USCLN = a + b;
                    BSCNN = boi / USCLN;

                    Console.WriteLine($"USCLN = {USCLN}");
                    Console.WriteLine($"BSCNN = {BSCNN}");
                }
            }
            else
            {
                Console.WriteLine("Nhập vào a,b > 0");
            }
        }

        //7.	Viết hàm kiểm tra N có phải là hợp số hay không. Biết hợp số là số chia hết cho số khác ngoài 1 và chính nó.
        static bool HopSo(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n * i == 0)
                {
                    return true;
                }
            }
            return false;
        }

        //6.	Viết hàm kiểm tra N có phải số đối xứng hay không
        static bool SoDoiXung(int n)
        {
            int doi = 0;
            int doi2 = 0;
            int m = n;
            while (n > 0)
            {
                doi = n % 10; //chia lấy dư cho 10, lấy số cuối cùng. doi chứa số cuối cùng
                doi2 = doi2 * 10 + doi; //mỗi lần cắt cộng lên 10 đơn vị
                n /= 10; //cắt số cuối cùng
            }
            if (doi2 == m)
            {
                return true;
            }
            return false;
        }

        //5.	Viết hàm In ra n số Fibonacci đầu tiên.
        static void InSoFn(int n)
        {
            int dem = 0;
            while (dem < n)
            {
                Console.WriteLine($"F{dem} = {DayFibonacci(dem)}");
                dem++;
            }
        }

        //4.	Viết hàm tính số hạng thứ n của dãy Fibonacci
        static double DayFibonacci(int n)
        {
            double F0 = 1;//giá trị thứ hạng F0
            double F1 = 1;//giá trị thứ hạng F1
            double Fn = 0;//giá trị thứ hàng Fn
            if (n <= 2)
            {
                Fn = 1;
            }
            else
            {
                for (int i = 2; i < n; i++)
                {
                    Fn = F0 + F1;
                    F0 = F1;
                    F1 = Fn;
                }
            }
            return Fn;
        }
        //3.	Viết hàm liệt kê các số chính phương nhỏ hơn và bằng N
        static void LietKeSoChinhPhuong(int n)
        {
            Console.WriteLine($"Các số chính phương nhỏ hơn và bằng {n}: ");
            for (int i = 0; i <= n; i++)
            {
                if (SoChinhPhuong(i) == 1)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        //2.	Viết hàm Tính tổng các số chính phương nhỏ hơn N.
        static void TongSoChinhPhuong(int n)
        {
            int sum = 0;
            for (int i = 0; i <= n; i++)
            {
                if (SoChinhPhuong(i) == 1)
                {
                    sum += i;
                }
            }
            Console.Write($"Tổng số chính phương <= n là: {sum}");
            Console.WriteLine();
        }
        static int SoChinhPhuong(int n)
        {
            if (n < 2)
            {
                return 0;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % 2 == 0)
                {
                    return 0;

                }
            }
            return 1;
        }

        //1.	Viết hàm nhập vào số nguyên dương N (N>=0).
        static int NhapN()
        {
            int n = 0;
            do
            {
                Console.Write("Nhập vào số nguyên dương N >= 0: ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);
            return n;
        }
    }
}
