using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace BasicC_.Strings
{
    internal class RotationOfString
    {
        // 8.String Rotation: Check if one string is a rotation of another (e.g., "waterbottle" is a rotation of "erbottlewat").

        public static bool isRotated(string str1, string str2)
        {
            if(str1.Length != str2.Length) return false;

            string text = str2 + str2;

            return KmpSearch.search(text, str1);
        }
    }
}
