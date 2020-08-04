using System;

namespace VDFramework.Standard.SharedClasses.Extensions
{
	public static class ObjectExtentions
	{
		public static bool HasValidCastTo<TType>(this object @object)
		{
			// The only way to check if a cast is valid which takes user-defined conversions into account
			
			try
			{
				TType temp = (TType) @object;
			}
			catch (InvalidCastException)
			{
				return false;
			}

			return true;
		}

        public static TNewType ConvertTo<TNewType>(this object @object)
        {
            try
            {
                return (TNewType)Convert.ChangeType(@object, typeof(TNewType));
            }
            catch
            {
                return (TNewType)@object;
            }
        }
	}
}