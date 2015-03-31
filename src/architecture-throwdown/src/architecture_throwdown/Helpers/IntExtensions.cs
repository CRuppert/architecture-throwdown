using System;

namespace architecture_throwdown.Helpers
{
    public static class IntExtensions
    {
		public static  string IsEven(this int i, string stringToReturnIfTrue)
		{
			if (i % 2 == 0) { return stringToReturnIfTrue; }
			return string.Empty;
		}
		public static string IsOdd(this int i, string stringToReturnIfTrue)
		{
			if (i % 2 != 0) { return stringToReturnIfTrue; }
			return string.Empty;
		}
    }
}