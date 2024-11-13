using System.Security.Cryptography;
using KittyMath;

namespace KittyMath
{
    public static class StringExtensions
    {
        static Dictionary<String, Int32> _dictionary = new Dictionary<String, Int32>()
       {
           { "one", 1},
           { "two", 2},
           { "three", 3},
           { "four", 4},
           { "five", 5},
           { "six", 6},
           { "seven", 7},
           { "eight", 8},
           { "nine", 9},
           { "zero", 0}
       };

        //public static decimal ConvertToNumber(this string scribblings)
        //{
        //    scribblings = scribblings.ToLower();
        //    foreach (string word in _dictionary.Keys)
        //    {
        //        scribblings = scribblings.Replace(word, _dictionary[word.Value].ToString());
        //    }
        //    return Decimal.Parse(scribblings);
        //}
        public static decimal FindNumber(this string scribblings)
        {
            string balanceString; 
            foreach (string key in _dictionary) 
                    {
                        balanceString += _dictionary[key].Value
                    }
            return Decimal.Parse(balanceString, out decimal value);
        }
    }
}