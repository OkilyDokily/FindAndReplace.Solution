using System.Text.RegularExpressions; 

namespace FindAndReplace
{
   static public class StringExtension
{
    static public string ReplaceInsensitive(this string str, string from, string to)
    {
        str = Regex.Replace(str, from, to, RegexOptions.IgnoreCase);
        return str;
    }
}
}