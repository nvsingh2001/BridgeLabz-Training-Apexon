using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_.DataTypes
{
    internal class DataTypes
    {
        public const byte MaxValue = 255;
        public const byte MinValue = 0;

        public const short MaxUValue = short.MaxValue;
        public const short MinUValue = short.MinValue;

        public const sbyte MaxSValue = 127;
        public const sbyte MinSValue = -128;

        public const char MaxCValue = Char.MaxValue;
        public const char MinCValue = Char.MinValue;

        public const string SampleString = "This is a sample string.";

        public const int MaxIValue = Int32.MaxValue;
        public const int MinIValue = Int32.MinValue;

        public const long MaxI64Value = Int64.MaxValue;
        public const long MinI64Value = Int64.MinValue;
       
        public const float MaxFValue = Single.MaxValue;
        public const float MinFValue = Single.MinValue;

        public const double MaxDValue = Double.MaxValue;
        public const double MinDValue = Double.MinValue;

        public const bool TrueValue = true;
        public const bool FalseValue = false;

        public static void DisplayDataTypes()
        {
            Console.WriteLine("Byte: Min = {0}, Max = {1}", MinValue, MaxValue);
            Console.WriteLine("Short: Min = {0}, Max = {1}", MinUValue, MaxUValue);
            Console.WriteLine("SByte: Min = {0}, Max = {1}", MinSValue, MaxSValue);
            Console.WriteLine("Char: Min = {0}, Max = {1}", (int)MinCValue, (int)MaxCValue);
            Console.WriteLine("String Sample: {0}", SampleString);
            Console.WriteLine("Int32: Min = {0}, Max = {1}", MinIValue, MaxIValue);
            Console.WriteLine("Int64: Min = {0}, Max = {1}", MinI64Value, MaxI64Value);
            Console.WriteLine("Float: Min = {0}, Max = {1}", MinFValue, MaxFValue);
            Console.WriteLine("Double: Min = {0}, Max = {1}", MinDValue, MaxDValue);
            Console.WriteLine("Boolean: True = {0}, False = {1}", TrueValue, FalseValue);
        }
    }
}
