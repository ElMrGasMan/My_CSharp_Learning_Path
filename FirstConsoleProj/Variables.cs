using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleProj
{
    internal class Variables
    {
        /* INTEGERS */

        sbyte mySByte = -3;
        byte myByte = 3;

        ushort myUshort = 4;
        short myShort = -4;

        int myInt = -5;
        uint myUInt = 5;

        long myLong = -6;
        ulong myULong = 6;


        /* DECIMALS */

        float myFloat = 7.45F; // 32 Bit with 7 digits of precision
        double myDouble = 8.4; // 64 Bit with 15 digits of precision
        Decimal myDecimal = new decimal(4.666); // 128 Bit with 28 digits of precision


        /* CASTING */

        double realbalance = 2000.90;
        int shownBalance = 20;

        public void CastingExplicit() 
        {
            shownBalance = (int)realbalance; //Only ignores the decimal part, does NOT round it
        }

        public void CastingImplicit() 
        {
            myLong = myInt; //Can only implicit cast from less bits to more bits 
            myDouble = myFloat;
            myFloat = myInt; // XXX myInt = myFloat XXX
        }


        /* STRING TO NUMERIC AND VICEVERSA */

        public static void ConversDemons() 
        {
            Console.WriteLine("Insert a whole number: ");

            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The number inserted multiplied by 3 is: {num * 3}.");

            string text = num.ToString();
        }


        /* CONSTANTS */

        public static void functionConstants() 
        {
            const int CONSTNUM = 45; //Always both declare and initialize in the same sentence
                                     //All capital letters

            Console.WriteLine("The value of the constant above is: {0}", CONSTNUM);
            //Another way to write variables on the console
        }

        public static void GetAreaCircle() 
        {
            const double PI = 3.1416;

            Console.WriteLine("Insert the radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double areaCircle = Math.Pow(radius, 2) * PI;
            
            Console.WriteLine("The area of your circle is: {0}.", Math.Round(areaCircle, 4));
        }
    }
}
