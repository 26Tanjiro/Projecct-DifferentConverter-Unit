using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_PUP_DIFF.CONVERT
{
    internal class TimeCon
    {
        public static void Timeconver()
        {
            double input = 0;
           
            Console.WriteLine("\nChoose Time Converter");
            Console.WriteLine("-------------------------");
            string[] time = new string[] { "sec to min ",
                                                   " min to sec ",
                                                   "hours to min ",
                                                   "min to hours ",
                                                   "hours to sec ",
                                                   "sec to hours ",
                                                   "hours to days",
                                                   "days to hours",
                                                   "days to min",
                                                   "min to days",
                                                   "days to sec",
                                                   "sec to days"};

            for (int i = 0; i < time.Length; i++)
            {

                Console.WriteLine($"{i + 1}. {time[i]}");
            }
            
            Console.WriteLine("\nSelect TimeConverter:");
            int timer = Convert.ToInt16(Console.ReadLine());
            
            Console.WriteLine("\nEnter the number:");
            input = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nProcessing please wait..................");

            switch (timer)
            {
                case 1:
                    double sm = input / 60;
                    Console.Write(sm + ", minutes.");
                    break;
                case 2:
                    double ms = input * 60;
                    Console.WriteLine(ms + ",seconds.");
                    break;
                case 3:
                    double hm = input *60;
                    Console.WriteLine(hm + ",minutes.");
                    break;
                case 4:
                    double mh = input / 60;
                    Console.Write(mh + ", hours.");
                    break;
                case 5:
                    double hs = input *3600;
                    Console.WriteLine(hs+", seconds.");
                    break;
                case 6:
                    double sh = input / 3600;
                    Console.WriteLine(sh + ", hours.");
                    break;
                case 7:
                    double hd = input / 24;
                    Console.WriteLine(hd + ", days.");
                    break;
                case 8:
                    double dh = input * 24;
                    Console.WriteLine(dh + ", hours.");
                    break;
                case 9:
                    double dm = input * 24 * 60;
                    Console.WriteLine(dm + ", minutes.");
                    break;
                case 10:
                    double md = input / 24 * 60;
                    Console.WriteLine(md + ", days.");
                    break;
                case 11:
                    double ds = input* 24 * 60 * 60;
                    Console.WriteLine(ds + ", seconds.");
                    break;
                case 12:
                    double sd = input / 24 * 60 * 60;
                    Console.WriteLine(sd + ", days.");
                    break;
                default:
                    Console.WriteLine("Invalid input....");
                    break;
            }


            
        }

    }
}
