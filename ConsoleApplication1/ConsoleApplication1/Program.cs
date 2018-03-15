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
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(" ╔════════╗ ");
            Console.WriteLine(" ║                ║ ");
            Console.WriteLine(" ║     D M A　　  ║ ");
            Console.WriteLine(" ║                ║ ");
            Console.WriteLine(" ╚════════╝ ");

            //定義
            Console.Write("身高(m):");
            string hight = Console.ReadLine();
            Console.Write("體重(kg):");
            string weight = Console.ReadLine();

            // 計算
            double BMI = double.Parse(weight) / (double.Parse(hight) * double.Parse(hight) );
            Console.WriteLine("BMI:" + BMI.ToString());

            //答覆
            if(BMI < 18.5)
            {
                Console.WriteLine("偏輕");
            }
            if(BMI>=18.5 && BMI<24)
            {
                Console.WriteLine("適中");
            }
            if(BMI > 24)
            {
                Console.WriteLine("過重");
            }
            if(BMI < 16.5)
            {
                Console.WriteLine("免疫");
            }
            if(BMI > 31.5)
            {
                Console.WriteLine("免疫");
            }
            Console.ReadLine();
        }
    }
}
