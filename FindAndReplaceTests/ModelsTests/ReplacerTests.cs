using FindAndReplace.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FindAndReplaceTests.ModelsTests
{
    [TestClass]
    public class ReplacerTests
    {
    [TestMethod]
    public void AddSpacesEnd_AddSpacesToWords_True(){
        string[] ta = new string[]{" hello ", " world "};

        string[] aa = Replacer.AddSpaces("hello","world");
        CollectionAssert.AreEqual(ta, aa);
    }

    

    [TestMethod]
     public void Replace_ReplaceWordsInSentence_True(){
        string s = "come on down to the come on down come";
        string d = "dog on down to the dog on down dog";

        string result = Replacer.Replace(s, "come", 
        "dog");

        Assert.AreEqual(result, d);
    }

    [TestMethod]
     public void Replace_DoesNotReplacePartialWords_True(){
        string s = "the cat is catherine";
        string d = "the dog is catherine";

        string result = Replacer.Replace(s, "cat", 
        "dog");

        Assert.AreEqual(result, d);
    }

     [TestMethod]
     public void Replace_DoesNotReplacePartialWords_True2(){
        string s = "catherine is a cat";
        string d = "catherine is a dog";

        string result = Replacer.Replace(s, "cat", 
        "dog");

        Assert.AreEqual(result, d);
    }


    [TestMethod]
     public void Replace_ReplaceWordsInSentenceWithCapitalization_True(){
        string s = "come on down to the come on down come";
        string d = "dog on down to the dog on down dog";

        string result = Replacer.Replace(s, "Come", 
        "dog");

        Assert.AreEqual(result, d);
    }

     [TestMethod]
     public void Replace_ReplaceWordsInSentenceWithCapitalizationInSentence_True(){
        string s = "come on down to the Come on down come";
        string d = "dog on down to the dog on down dog";

        string result = Replacer.Replace(s, "come", 
        "dog");

        Assert.AreEqual(result, d);
    }
    [TestMethod]
      public void Replace_ReplaceWordsInSentenceWithFirstWordCapitalized_True(){
        string s = "Come on down to the come on down come";
        string d = "dog on down to the dog on down dog";

        string result = Replacer.Replace(s, "come", 
        "dog");

        Assert.AreEqual(result, d);
    }

     [TestMethod]
      public void Replace2_ReplaceWordsWithoutSpaces_True(){
        string s = "I am walking my cat to the cathedral";
        string d =  "I am walking my dog to the doghedral";

        string result = Replacer.Replace2(s, "cat", 
        "dog");

        Assert.AreEqual(d, result);
    }
    }
}