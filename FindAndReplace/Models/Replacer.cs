namespace FindAndReplace.Models
{
    public class Replacer
    {
        public static string Replace(string str, string find, string replace){
            return str.ReplaceInsensitiveWholeWord(find, replace);
        }

        public static string Replace2(string str, string find, string replace){
            return str.ReplaceInsensitive(find, replace);
        }
    }
}