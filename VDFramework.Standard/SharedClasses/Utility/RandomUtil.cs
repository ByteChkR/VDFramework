﻿using VDFramework.Standard.SharedClasses.Extensions;

namespace VDFramework.Standard.SharedClasses.Utility
{
	public static class RandomUtil
	{
		private static readonly bool[] boolValues = {true, false};
		
		public static bool RandomBool()
		{
			return boolValues.GetRandomItem();
		}

		public static object GetRandom(params object[] array)
		{
			return array.GetRandomItem();
		}

		public static TItem GetRandom<TItem>(params TItem[] array)
		{
			return array.GetRandomItem();
		}
	}
}