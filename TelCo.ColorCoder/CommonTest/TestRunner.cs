using System;
using System.Diagnostics;
using System.Drawing;
using TelCo.ColorCoder.BusinessLogic;
using TelCo.ColorCoder.Models;

namespace TelCo.ColorCoder.CommonTest
{
    public static class TestRunner
    {
        public static void Run()
        {
            var coder = new ColorCode();

            int pairNumber = 4;
            IColorPair testPair1 = coder.GetColorFromPairNumber(pairNumber);
            Console.WriteLine($"[Test] Pair {pairNumber} => {testPair1}");
            Debug.Assert(testPair1.MajorColor == Color.White);
            Debug.Assert(testPair1.MinorColor == Color.Brown);

            pairNumber = 5;
            testPair1 = coder.GetColorFromPairNumber(pairNumber);
            Console.WriteLine($"[Test] Pair {pairNumber} => {testPair1}");
            Debug.Assert(testPair1.MajorColor == Color.White);
            Debug.Assert(testPair1.MinorColor == Color.SlateGray);

            pairNumber = 23;
            testPair1 = coder.GetColorFromPairNumber(pairNumber);
            Console.WriteLine($"[Test] Pair {pairNumber} => {testPair1}");
            Debug.Assert(testPair1.MajorColor == Color.Violet);
            Debug.Assert(testPair1.MinorColor == Color.Green);

            IColorPair testPair2 = new ColorPair() { MajorColor = Color.Yellow, MinorColor = Color.Green };
            pairNumber = coder.GetPairNumberFromColor(testPair2);
            Console.WriteLine($"[Test] Colors {testPair2} => Pair {pairNumber}");
            Debug.Assert(pairNumber == 18);

            testPair2 = new ColorPair() { MajorColor = Color.Red, MinorColor = Color.Blue };
            pairNumber = coder.GetPairNumberFromColor(testPair2);
            Console.WriteLine($"[Test] Colors {testPair2} => Pair {pairNumber}");
            Debug.Assert(pairNumber == 6);

            Console.WriteLine("All tests passed.");
        }
    }
}
