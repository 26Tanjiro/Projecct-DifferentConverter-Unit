using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_PUP_DIFF.CONVERT
{
    internal class MenuCon
    {
        public static void MenuConver()
        {
            //displaying choseen converter//
            Console.WriteLine("Select from the different types of converters presented below....");
            string[] choose = new string[] { "Time Converter",
                "Speed Converter ", 
                "Length Convert ", 
                "Currency Converter", 
                "Power Converter", 
                "Volume Converter", 
                "Mass Converter", 
                "Temperature Conveter", 
                "Energy Converter", 
                "Area Converter", };

            for (int c = 0; c < choose.Length; c++)
            {
                Console.WriteLine($"{c + 1}.{choose[c]}");
            }
            Console.WriteLine("\nSelect the number you want to use in Converting unit:");
            int convert = Convert.ToInt16(Console.ReadLine());

            //evaluating chossen converter//
            switch (convert)
            {
                case 1:
                    TimeCon.Timeconver();
                    break;
                case 2:
                    SpeedCon.SpeedConv();
                    break;
                case 3:
                    LengthCon.LengthConver();
                    break;
                case 4:
                    CurrencyCon.CurrencyConv();
                    break;
                case 5:
                    PowerCon.PowerConv();
                    break;
                case 6:
                    VolumeCon.VoluneConv();
                    break;
                case 7:
                    MassCon.MassConv();
                    break;
                case 8:
                    TemperatureCon.TemperatureConv();
                    break;
                case 9:
                    EnergyCon.EnergyConv();
                    break;
                case 10:
                    AreaCon.AreaConv();
                    break;
                default:
                    Console.WriteLine("Invalid input.............");
                    break;   
            }
                

        }
    }
}
