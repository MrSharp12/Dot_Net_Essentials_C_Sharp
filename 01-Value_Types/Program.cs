using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _01_Value_Types
{
    class Program
    {
        public enum Book
        {
            Book,
            Book2,
            Unknown

        }
        static void Main(string[] args)
        {
            int number = 3;
            bool trueOrFalse = true;
            decimal decimalNumbers = 2.34m;
            double doubleTest = 10.308;
            byte byteTest = 255;
            float floatTest = 7.34f;
            sbyte sbyteTest = -128;
            uint uintTest = 4294967295;
            ulong ulongTest = 8446744073709551615;
            ushort ushortTest = 65535;
            Enum enumTest;//declaration, type and name
            short shortTest = 32767;//intialization, sets a value
            int? ni = null;

            char characterTest = 'c';
        }

        struct Address
        {
            public string AddressLine1;
            public string AddressLine2;
        }
    }
}
