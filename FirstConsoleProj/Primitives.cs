using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleProj
{
    internal class Primitives
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

        float myFloat = 7; // 32 Bit with 7 digits of precision
        double myDouble = 8.4; // 64 Bit with 15 digits of precision
        Decimal myDecimal = new decimal(4.666); // 128 Bit with 28 digits of precision
    }
}
