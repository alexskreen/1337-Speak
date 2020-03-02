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
      Assert.AreEqual("H3ll0!", testUserString.MakeLeet("Hello!"));
    }

    [TestMethod]

    public void IsMakeLeet_ChangingS_Z()
    {
      UserString testUserString = new UserString("Songs!");
      Assert.AreEqual("S0ngz!", testUserString.MakeLeet("Songs!"));
    }

    [TestMethod]

    public void IsMakeLeet_ChangingO_0()
    {
      UserString testUserString = new UserString("Songs!");
      Assert.AreEqual("S0ngz!", testUserString.MakeLeet("Songs!"));
    }

    [TestMethod]

    public void IsMakeLeet_ChangingL_1()
    {
      UserString testUserString = new UserString("Leet!");
      Assert.AreEqual("1337!", testUserString.MakeLeet("Leet!"));
    }

    [TestMethod]

    public void IsMakeLeet_ChangingT_7()
    {
      UserString testUserString = new UserString("Leet!");
      Assert.AreEqual("1337!", testUserString.MakeLeet("Leet!"));
    }

    [TestMethod]

    public void IsMakeLeet_Changing1S_S()
    {
      UserString testUserString = new UserString("I'm a test sentence!");
      Assert.AreEqual("I'm a 73z7 s3n73nc3!", testUserString.MakeLeet("I'm a test sentence!"));
    }
  }
}