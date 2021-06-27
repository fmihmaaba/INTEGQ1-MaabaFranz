using mouse.bl;
using System;

namespace Rotocube
{
    class Program
    {
        static void Main(string[] args)
        {
            //User inputs

            UserValidation user = new UserValidation();

            Console.WriteLine("Welcome to RotoCube");
            Console.WriteLine("(1)Login: ");
            Console.WriteLine("(2)Sign-up: ");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput.Equals(1))
            {
                user.LogIn();
            }
            else if (userInput.Equals(2))
            {
                user.Register();
            }
            else
            {
            }

            Console.ReadKey();


            Console.WriteLine("\n!Welcome to RotoCube!");
            Console.WriteLine("------------------");
            Console.WriteLine("Welcome to our Online Store! Thank you for visiting and hope you find the right Mice that you are looking for");
            Console.WriteLine("------------------");
            Console.WriteLine("Our Mouses");
            Console.WriteLine("\n[1]GLORIOUS MODEL O WIRELESS $86.31 \n[2]Ninjutso Origin One X Wireless Ultralight Gaming Mouse $88.37 \n[3]Pulsar XLITE Gaming Mouse $51.29 \n[4]Glorious Model D Gaming Mouse $59.74 \n[5]XTRFY M4 RGB STREET EDITION Gaming Mouse $67.77 \n[6]Endgame Gear XM1 RGB Gaming Mouse $76.01 \n[7]XTRFY M4 RGB Ultra-Light Gaming Mouse $55.41 \n[8]Endgame Gear XM1 $65.71 \n[9]RAZER Viper Mini Ultra-Lightweight Gaming $43.24 \n[10]RAZER Viper Ambidextrous Wired $60.34");

            Console.WriteLine("------------------");

            int mouse;
            Console.WriteLine("Enter an item");
            Console.WriteLine("------------------");
            mouse = Convert.ToInt32(Console.ReadLine());
            switch (mouse)
            {
                case 1:
                    Console.WriteLine("\n[1] GLORIOUS MODEL O WIRELESS $86.31");
                    break;
                case 2:
                    Console.WriteLine("\n[2] Ninjutso Origin One X Wireless Ultralight Gaming Mouse $88.37");
                    break;
                case 3:
                    Console.WriteLine("\n[3] Pulsar XLITE Gaming Mouse $51.29");
                    break;
                case 4:
                    Console.WriteLine("\n[4] Glorious Model D Gaming Mouse $59.74");
                    break;
                case 5:
                    Console.WriteLine("\n[5] XTRFY M4 RGB STREET EDITION Gaming Mouse $67.77");
                    break;
                case 6:
                    Console.WriteLine("\n[6] Endgame Gear XM1 RGB Gaming Mouse $76.01");
                    break;
                case 7:
                    Console.WriteLine("\n[7] XTRFY M4 RGB Ultra-Light Gaming Mouse $55.41");
                    break;
                case 8:
                    Console.WriteLine("\n[8] Endgame Gear XM1 $65.71");
                    break;
                case 9:
                    Console.WriteLine("\n[9] RAZER Viper Mini Ultra-Lightweight Gaming $43.24");
                    break;
                case 10:
                    Console.WriteLine("\n[10] RAZER Viper Ambidextrous Wired $60.34");
                    break;
            }
            Console.WriteLine("------------------");

            Console.WriteLine("Enter to Confirm your Order");
            Console.WriteLine("------------------");
            Console.ReadKey();
            Console.WriteLine("Thank You for shopping at RotoCube");


        }
    }
}
