namespace FindAndReplace.Models
{
    public class Replacer
    {
        public static string Replace(string str, string find, string replace){
            return "";
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