using Aritiafel.Artifacts;
using System.Diagnostics;

namespace AritiafelTest
{
    [TestClass]
    public sealed class AllseerTest
    {
        [TestMethod]
        public void AllTest()
        {
            Stopwatch sw = Stopwatch.StartNew();
            Console.WriteLine("\"aaaa\"");
            Console.WriteLine(Allseer.SeeThrough("aaaa"));
            Console.WriteLine("5");
            Console.WriteLine(Allseer.SeeThrough(5));
            Console.WriteLine("double array");
            Console.WriteLine(Allseer.SeeThrough(new double[] { 1.0, 2.0, 3.0 }));
            Console.WriteLine("stopwatch");
            Console.WriteLine(Allseer.SeeThrough(sw));
            Allseer.RegisterCustomSeeThroughFunction<int>(Plus3);
            Console.WriteLine("Custom Plus 3 Function: 5");
            Console.WriteLine(Allseer.SeeThrough(5));
            sw.Stop();
        }

        public string Plus3(int m)
            => (m + 3).ToString();
    }
}
