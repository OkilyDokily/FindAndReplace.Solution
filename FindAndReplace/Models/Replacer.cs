namespace FindAndReplace.Models
{
    public class Replacer
    {
        public static string Replace(string str, string find, string replace){
            string[] sa = AddSpacesEnd(find, replace);
            string mStr = str.ReplaceInsensitive(sa[0],sa[1]);
            string[] sa2 = AddSpacesEnd(find, replace);
            string fStr = mStr.ReplaceInsensitive(find, replace); 
            return fStr;
        }

        public static string Replace2(string str, string find, string replace){
            return str.ReplaceInsensitive(find, replace)
        }

        public static string[] AddSpacesEnd(string find, string replace){
            string mFind = find + " ";
            string mReplace = replace + " ";
            return new string[]{ mFind, mReplace};
        }

          public static string[] AddSpacesFront(string find, string replace){
            string mFind = " " + find;
            string mReplace = " " + replace ;
            return new string[]{ mFind, mReplace};
        }  
    }
}