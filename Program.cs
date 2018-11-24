using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//VC#だと、ctrl+Dでコードを整列


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Hello World");


            //int a = 10, b = 20;

            //int c = a + b;

            ////◆変数のコマンドライン出力

            //Console.WriteLine("a={0}, b={1}", a, b, c);

            //Console.WriteLine("{0}+{1}={2}", a, b, c);

            ////◆IF文
            //if (a > b)
            //{
            //    Console.WriteLine("{0}は{1}よりも大きい", a, b);
            //}
            //else if (b > a)
            //{
            //    Console.WriteLine("{0}は{1}よりも小さい", a, b);
            //}
            //else
            //    Console.WriteLine("{0}と{1}は等しい", a, b);

            ////◆コンソールから文字入力受付
            //while (true)
            //{
            //    Console.Write("aの値を入力---");
            //    String st_a = Console.ReadLine();
            //    if (Int32.TryParse(st_a, out a)) //整数に変換。整数でなければ(False)エラー処理へ
            //        break;
            //    else
            //        Console.WriteLine("入力値が不正です。");
            //}
            //while (true)
            //    { 
            //    Console.Write("bの値を入力---");
            //    String st_b = Console.ReadLine();
            //    if (Int32.TryParse(st_b, out b))
            //        break;
            //    else
            //        Console.WriteLine("入力値が不正です。");
            //}



            //           Console.WriteLine("a={0}, b={1}", a, b);

            //    //◆SWITCH文
            //    switch (a)
            //    {
            //        case 1:
            //            Console.WriteLine("aは1です");
            //            break;

            //        case 0:
            //            Console.WriteLine("aは0です");
            //            break;

            //        default:
            //            Console.WriteLine("aは0でも1でもないです。");
            //            break;
            //    }

            //    //◆FOR文
            //    int i, max;
            //    Console.WriteLine("繰り返し回数を入力---");
            //    String st_max = Console.ReadLine();
            //    max = Int32.Parse(st_max);

            //    for (i = 0; i < max; i++)
            //        Console.WriteLine("{0}回目の繰り返しです。", i + 1);


            //    //◆WHILE文

            //    i = 10;
            //    while (i > 0)
            //    {
            //        Console.WriteLine("カウントは{0}です。", i);

            //        int check;
            //        Console.Write("0:カウントダウン、1:カウントリセット、2:終了---");
            //        string st_check = Console.ReadLine();
            //        check = Int32.Parse(st_check);

            //        switch (check)
            //        {
            //            case 0:
            //                break;
            //            case 1:
            //                i = 10;
            //                continue;//whileの最初に戻る
            //            case 2:
            //                break;
            //        }



            //        i = i - 1;

            //        if (check == 2) break;


            //    }


            //◆配列

            int[] str = { 10, 20, 30 };

            int i;
            for(i=0;i<3; i++)
                Console.WriteLine("{0}", str[i]);

            //◆2次元配列

            int[,] str2 = new int[2, 3];
            int i, j;

            str2[0,0]

            




            }
        }
    }
