using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_PUP_DIFF.CONVERT
{
    internal static class SpeedCon
    {
        public static void SpeedConv()
        {

            double input = 0;

            Console.WriteLine("\nChoose Speed Converter:");
            string[] speed = new string[] { " miles per hour to kilometers per hour",
                                                   "kilometers per hours to miles per hour",
                                                   "meters per second to kilometers per hour",
                                                   "kilometers per Hour to mters per second",
                                                   "feet per second to iles per hour",
                                                   "miles per hour to feet per second",};

            for (int i = 0; i < speed.Length; i++)
            {

                Console.WriteLine($"{i + 1}. {speed[i]}");
            }
            Console.WriteLine("\nSelect the number you want to use in Converting unit:");
            int converts = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter the number:");
            input = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nProcessing please wait..................");

            switch (converts)
            {
                case 1:
                    double kmperh =input * 1.60934;
                    Console.Write(kmperh+ ", km/h.");
                    break;
                case 2:
                    double milesperh = input/1.60934;
                    Console.Write(milesperh + ", mph.");
                    break;
                case 3:
                    double meterpers = input *3.6;
                    Console.Write(meterpers + ", km/h.");
                    break;
                case 4:
                    double kmperhs = input/ 3.6;
                    Console.Write(kmperhs + ", m/s.");
                    break;
                case 5:
                    double mph =input * 0.681818;
                    Console.Write(mph + ", mph.");
                    break;
                case 6:
                    double ftpers= input / 0.681818;
                    Console.Write(ftpers + ", ft/s.");
                    break;
                default:
                    Console.WriteLine("Invalid input...............");
                    break;
            }
        }
    }
}
