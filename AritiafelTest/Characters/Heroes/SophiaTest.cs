using Aritiafel.Characters.Heroes;
using Aritiafel.Definitions;

namespace AritiafelTest.Characters.Heroes;
[TestClass]
public class SophiaTest
{
    public TestContext TestContext { get; set; }

    [TestMethod]
    public void BasicTest()
    {
        Console.WriteLine("‘ªŽŽŽš‹ø:aabcc");
        Console.WriteLine("Console");
        PrintTestString();
        Sophia.SetOutput(TestContext);
        //Sophia.DisplayResultAt = DebugStringOutputLocation.TestContext;
        TestContext.WriteLine("TestContext");
        PrintTestString();
    }

    internal void PrintTestString()
    {
        //Sophia.SetOutput()
        Sophia.QuickSeeThrough("aab");
        Sophia.SeeThrough("cc");
    }
}
