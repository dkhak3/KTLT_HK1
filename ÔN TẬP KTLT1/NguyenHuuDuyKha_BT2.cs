﻿/*BT2: Viết hàm nhập vào số nguyên dương N (N>=0).
2. Viết hàm kiểm tra số nguyên tố? Nếu là số nguyên tố trả về 1, ngược lại trả về 0.
3. Viết hàm liệt kê các số nguyên tố nhỏ hơn và bằng N.
4. Viết hàm main gọi thực hiện các hàm thực hiện, chương trình hỏi người dùng có muốn tiếp
tục không? (Y/N). Chọn Y chương trình tiếp tục thực hiện.
5. Viết chương trình đúng chuẩn code.
 * Name: Nguyễn Hữu Duy Kha
 * Date: 04/01/2022
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÔN_TẬP_KTLT1
{
    class NguyenHuuDuyKha_BT2
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Khai báo biến
            int n = 0;
            char Chon;
            while (true)
            {
                n = NhapN();
                if (KiemTraSoNguyenTo(n) == 1)
                {
                    Console.WriteLine($"{n} là số nguyên tố.");
                }
                else
                {
                    Console.WriteLine($"{n} không là số nguyên tố.");
                }

                LietKeSoNguyenTo(n);
                Console.WriteLine("Bạn có muốn tiếp tục không ? (y/n)");
                Chon = Convert.ToChar(Console.ReadLine());
                if (Chon == 'n')
                {
                    break;
                }
            }
        }
        //tính và output

        //Hàm liệt kê số nguyên tố nhỏ hơn bằng n
        static void LietKeSoNguyenTo(int n)
        {
            Console.WriteLine($"Các số nguyên tố nhỏ hơn bằng {n} là:");
            for (int i = 0; i <= n; i++)
            {
                if (KiemTraSoNguyenTo(i) == 1)
                {
                    Console.Write($"{i}  ");
                }
            }
            Console.WriteLine();
        }

        //Hàm kiểm tra số nguyên tố
        static int KiemTraSoNguyenTo(int n)
        {
            int dem = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    dem++;
                }
            }
            if (dem == 2)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        //Hàm Nhập n
        static int NhapN()
        {
            int n = 0;
            do
            {
                Console.WriteLine("Nhập vào n:");
                n = int.Parse(Console.ReadLine());
            } while (n < 0);
            return n;
        }
    }
}
