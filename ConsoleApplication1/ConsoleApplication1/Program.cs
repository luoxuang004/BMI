using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(" ╔════════╗ ");
            Console.WriteLine(" ║                ║ ");
            Console.WriteLine(" ║     D M A　　  ║ ");
            Console.WriteLine(" ║                ║ ");
            Console.WriteLine(" ╚════════╝ ");

            // 宣告匯率變數與數值
            double rate = 0.02748;

            // 顯示匯率
            Console.WriteLine("目前韓幣匯率:" + rate);

            // 接收數值
            Console.Write("請輸入匯率金額:");
            string input = Console.ReadLine();

            //計算
            double total = double.Parse(input) * rate;
            Console.WriteLine(" 換算成台幣是:  " + total );
            Console.ReadLine();
        }
    }
}
