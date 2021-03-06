﻿using System;
class Program
{
    static void Main(string[] args)
    {
        int start, end;
        bool StartNumCheck, EndNumCheck, Accept;
        Console.WriteLine("請輸入開始範圍");
        StartNumCheck = int.TryParse(Console.ReadLine(), out start);
        Accept = false;
        while (!Accept)
        {
            if (StartNumCheck&&start >= 1)
            {
                Accept = true;
            }
            else
            {
                Console.WriteLine("開始範圍必須為大於0之整數，請重新輸入");
                int.TryParse(Console.ReadLine(), out start);
            }
        }
        Console.WriteLine("請輸入結束範圍");
        EndNumCheck = int.TryParse(Console.ReadLine(), out end);
        Accept = false;
        while (!Accept)
        {
            if (EndNumCheck&&end > start)
            {
                Accept = true;
            }
            else
            {
                Console.WriteLine("結束範圍必須大於開始範圍，請重新輸入");
                int.TryParse(Console.ReadLine(), out end);
            }
        }
        Console.WriteLine("-------------------------");
        Console.WriteLine("Method 1：使用for迴圈");
        Console.WriteLine();
        {
            int x; //除數
            int y; //被除數
            bool z; //是否有餘數
            for (y = start; y < end; y++)
            {
                z = true;
                for (x = 2; x < y || y == 1; x++)
                {
                    if (y % x == 0 || y == 1)
                    {
                        z = false;
                        break;
                    }
                }
                if (z)
                {
                    Console.WriteLine(y + " 為質數");
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine("-------------------------");
        Console.WriteLine("Method 2：使用while迴圈");
        Console.WriteLine();
        {
            int a = 2; //除數
            int b = start; //被除數
            bool c = true; //是否為質數

            while (b <= end)
            {
                c = true;
                a = 2;
                while ((a < b) && c)
                {
                    if (b % a == 0)
                    {
                        c = false;
                    }
                    a += 1;
                }
                if (c)
                {
                    Console.WriteLine(b + " 為質數");
                }
                b += 1; //漏寫會導致無窮迴圈
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------");
        }
        Console.ReadKey();
    }
}