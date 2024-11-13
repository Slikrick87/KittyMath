using System.Security.Cryptography;
using KittyMath;
using System.Collections;
using System.Text;

namespace KittyMath
{
    public static class StringExtensions
    {
        public static Dictionary<String, decimal> _dictionary = new Dictionary<String, decimal>()
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
        //        scribblings = scribblings.Replace(word, _dictionary[word.Values].ToString());
        //    }
        //    return Decimal.Parse(scribblings);
        //}
        //public static decimal FindNumber(this String scribblings)
        //{
        //    scribblings = scribblings.ToLower();
        //    string balanceString = "";
        //    foreach (char c in scribblings)
        //    {
        //        if (scribblings.Contains(_dictionary.)){
        //        }
        //            }
        //     Console.WriteLine(scribblings);
        //    return decimal.Parse(scribblings);
        //}
        public static decimal GetNumbers(this String scribblings)
        {
            scribblings = scribblings.ToLower();
            string[] scribble = scribblings.Select(x => x.ToString()).ToArray();
            string result = "";
            string newresult = "";
            decimal numValue;
            foreach (string letter in scribble)
            {
                if (decimal.TryParse(letter, out numValue))
                { newresult += letter; }
                else
                {
                    result += letter;


                    if (_dictionary.TryGetValue(result, out decimal value))
                    {
                        newresult += value.ToString();
                        result = "";
                    }
                    if (letter == ".")
                    {
                        newresult += ".";
                        result = "";
                    }
                }
            }
            if (decimal.TryParse(newresult, out numValue))
                { return numValue; }
            else { return 0; }
        }
    }
}