using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_PUP_DIFF.CONVERT
{
    internal static class LengthCon
    {
        public static void  LengthConver()
        {
            double input = 0;
            
            Console.WriteLine("\nChoose Length Converter:");
            string[] length = new string[] { "m to cm ",
                                                   "cm to m ",
                                                   "cm to in ",
                                                   "ft to m ",
                                                   "yd to m ",
                                                   "m to yd ",
                                                   "mile to km ",
                                                   "km to mile ",
                                                   "n mile to m ",
                                                   "m to n mile "};

            for (int i = 0; i < length.Length; i++)
            {

                Console.WriteLine($"{i + 1}. {length[i]}");
            }
            Console.WriteLine("\nSelect the number you want to use in Converting unit:");
            int convertm = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter the number:");
            input = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nProcessing please wait..................");
            switch (convertm)
            {
                case 1:
                    double cm = input * 100;
                    Console.WriteLine(cm);
                    break;
                case 2:
                    ;
                    break;
                case 3:
                    ;
                    break;
                case 4:
                    ;
                    break;
                case 5:
                    ;
                    break;
                case 6:
                    ;
                    break;
                case 7:
                    ;
                    break;
                case 8:
                    ;
                    break;
                case 9:
                    ;
                    break;
                default:
                    Console.WriteLine("Invalid Input.......");
                    break;
            }
        }
    }
}
