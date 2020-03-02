using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetSpeak.Translator;

namespace LeetSpeak.Tests
{
  [TestClass]

  public class LeetSpeakTests
  {
    [TestMethod]

    public void IsUserInput_String_True()
    {
      UserString testUserString = new UserString("Hello!");
      Assert.AreEqual(true, testUserString.UserInput is string);
    }

    [TestMethod]

    public void IsUserInputArrayable_Array_True()
    {
      UserString testUserString = new UserString("Hello!");
      Assert.AreEqual("H.e.l.l.o.!", testUserString.MakeArray("Hello!"));
    }

    [TestMethod]

    public void IsMakeLeet_ChangingE_3()
    {
      UserString testUserString = new UserString("Hello!");
      Assert.AreEqual("H3llo!", testUserString.MakeLeet("Hello!"));
    }
  }
}