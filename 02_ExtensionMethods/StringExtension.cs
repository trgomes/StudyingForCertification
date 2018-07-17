using System;

namespace _02_ExtensionMethods
{
    public static class StringExtension
    {
        public static string FirstToUpper( this String str)
        {
            string first = str.Substring(0,1);
            string end = str.Substring(1);

            return first.ToUpper() + end;
        }
    }
}
