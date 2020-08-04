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
    }
}