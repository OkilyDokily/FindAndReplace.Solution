using FindAndReplace.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FindAndReplaceTests.ModelsTests
{
    [TestClass]
    public class ReplacerTests
    {
    [TestMethod]
    public void AddSpacesEnd_AddSpacesToWords_True(){
        string[] ta = new string[]{"hello ", "world "};

        string[] aa = Replacer.AddSpacesEnd("hello","world");
        CollectionAssert.AreEqual(ta, aa);
    }

    [TestMethod]
     public void AddSpacesFront_AddSpacesToWords_True(){
        string[] ta = new string[]{" hello", " world"};

        string[] aa = Replacer.AddSpacesFront("hello","world");
        CollectionAssert.AreEqual(ta, aa);
    }

    [TestMethod]
     public void Replace_ReplaceWordsInSentence_True(){
        string s = "come on down to the come on down come.";
        string d = "dog on down to the dog on down dog.";

        string result = Replacer.Replace(s, "come", 
        "dog");

        Assert.AreEqual(result, d);
    }
    }
}