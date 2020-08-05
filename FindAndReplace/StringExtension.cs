using System.Text.RegularExpressions; 

namespace FindAndReplace
{
   static public class StringExtension 
{
    static public string ReplaceInsensitiveWholeWord(this string str, string from, string to)
    {
        return Regex.Replace(str,@"\b" + from +@"\b", to, RegexOptions.IgnoreCase);
       
    }

     static public string ReplaceInsensitive(this string str, string from, string to)
    {
        return Regex.Replace(str , from, to, RegexOptions.IgnoreCase);
       
    }
}

}

//Extension method written by 
// Petrucio from https://stackoverflow.com/questions/6275980/string-replace-ignoring-case