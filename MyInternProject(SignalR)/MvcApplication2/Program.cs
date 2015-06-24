using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;

using myapp;

class Program
{
    public static GPIOState CurrentState { get; set; }
    public static TinyGPIO GPIO24_Sw1 { get; set; }
    public static TinyGPIO GPIO25_LED1 { get; set; }
    private static bool Halt { get; set; }


    private static void InitiGPIO()
    {
        // init GPIO 24 for Switch1
        GPIO24_Sw1 = TinyGPIO.Export(24);
        GPIO24_Sw1.Direction = GPIODirection.In;

        // init GPIO 25 for LED1
        GPIO25_LED1 = TinyGPIO.Export(25);
        GPIO25_LED1.Direction = GPIODirection.Out;
    }

}
